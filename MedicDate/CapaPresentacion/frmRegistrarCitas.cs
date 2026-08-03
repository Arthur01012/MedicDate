using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarCitas : Form
    {
        private clsCitaNegocio _citaNegocio = new clsCitaNegocio();

        public frmRegistrarCitas()
        {
            InitializeComponent();
        }

        private void frmRegistrarCitas_Load(object sender, EventArgs e)
        {
            dtpFechaCita.Value = DateTime.Today;
            CargarComboDoctores();
            RefrescarVista();
        }
        private void CargarComboDoctores()
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
            cmbFiltrarDoctor.DataSource = doctores;
            cmbFiltrarDoctor.DisplayMember = "NombreCompleto";
            cmbFiltrarDoctor.ValueMember = "id_empleado";
            cmbFiltrarDoctor.SelectedIndex = -1;
        }

        private int? ObtenerIdDoctorSeleccionado()
        {
            if (cmbFiltrarDoctor.SelectedValue == null || cmbFiltrarDoctor.SelectedIndex == -1)
                return null;

            if (int.TryParse(cmbFiltrarDoctor.SelectedValue.ToString(), out int id))
                return id;

            return null;
        }

        private (int idCita, string nombrePaciente)? ObtenerCitaSeleccionada()
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView == null)
            {
                MessageBox.Show("No se pudo obtener la cita seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            int idCita = Convert.ToInt32(rowView["id_cita"]);
            string nombrePaciente = rowView["Paciente"].ToString();
            return (idCita, nombrePaciente);
        }

        private bool ProcesarCambioEstadoCita(string nuevoEstado, string mensajeAccion, bool esCancelacion = false)
        {
            var cita = ObtenerCitaSeleccionada();
            if (cita == null) return false;

            var (idCita, nombrePaciente) = cita.Value;
            string titulo = esCancelacion ? "Cancelar" : "Confirmar";

            DialogResult res = MessageBox.Show(
                $"¿{titulo} la cita de {nombrePaciente}?",
                titulo,
                MessageBoxButtons.YesNo,
                esCancelacion ? MessageBoxIcon.Warning : MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return false;

            bool exito = clsCitaDAL.CambiarEstado(idCita, nuevoEstado);
            if (exito)
            {
                MessageBox.Show($"Cita {mensajeAccion}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarVista();
            }
            else
            {
                MessageBox.Show($"No se pudo {mensajeAccion}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exito;
        }
        private void RefrescarVista()
        {
            try
            {
                int? idDoctor = ObtenerIdDoctorSeleccionado();
                DateTime fecha = dtpFechaCita.Value.Date;

                DataTable citas;
                if (idDoctor.HasValue)
                    citas = clsCitaDAL.ObtenerCitas(idDoctor.Value, fecha);
                else
                    citas = clsCitaDAL.CargarDataGrid(fecha);

                
                dgvCitas.DataSource = null;
                dgvCitas.DataSource = citas;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                
                RefrescarHorasDisponibles(idDoctor, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarHorasDisponibles(int? idDoctor, DateTime fecha)
        {
            lstHorasDisponibles.Items.Clear();

            if (!idDoctor.HasValue)
            {
                lstHorasDisponibles.Items.Add("Seleccione un doctor para ver disponibilidad.");
                return;
            }

            var resultado = _citaNegocio.ObtenerHorasDisponibles(idDoctor.Value, fecha, null);

            if (!resultado.DoctorAtiende)
            {
                lstHorasDisponibles.Items.Add("El doctor no atiende en esta fecha.");
                return;
            }

            if (resultado.HorasDisponibles.Count == 0)
            {
                lstHorasDisponibles.Items.Add("No hay horas libres para esta fecha.");
            }
            else
            {
                foreach (string hora in resultado.HorasDisponibles)
                    lstHorasDisponibles.Items.Add(hora);
            }
        }

        private void cmbFiltrarDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarVista();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            RefrescarVista();
        }

        private void btnNuevoCita_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCita())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SincronizarFiltroConCitaGuardada(frm);
                    RefrescarVista();
                }
            }
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            // Obtener cita seleccionada
            var cita = ObtenerCitaSeleccionada();
            if (cita == null) return;

            int idCita = cita.Value.idCita;

            // Abrir formulario de edición
            using (var frm = new frmCita(idCita))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    SincronizarFiltroConCitaGuardada(frm);

                RefrescarVista();
            }
        }

        // Actualiza el filtro de doctor/fecha con los datos de la cita recién guardada,
        // para que aparezca de inmediato en el grid aunque no coincidiera con el filtro previo.
        private void SincronizarFiltroConCitaGuardada(frmCita frm)
        {
            if (frm.DoctorGuardado.HasValue)
                cmbFiltrarDoctor.SelectedValue = frm.DoctorGuardado.Value;

            if (frm.FechaGuardada.HasValue)
                dtpFechaCita.Value = frm.FechaGuardada.Value;
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstadoCita("Confirmada", "confirmada");
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstadoCita("Cancelada", "cancelada", esCancelacion: true);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cmbFiltrarDoctor.SelectedIndex = -1;
            dtpFechaCita.Value = DateTime.Today;
            RefrescarVista();
        }
    }
}