using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarCitas : Form
    {
        public frmRegistrarCitas()
        {
            InitializeComponent();
        }

        private void frmRegistrarCitas_Load(object sender, EventArgs e)
        {
            // Fecha por defecto: hoy
            dtpFechaCita.Value = DateTime.Today;
            CargarComboDoctores();
            CargarCitas();
        }

        private void CargarComboDoctores()
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
            cmbFiltrarDoctor.DataSource = doctores;
            cmbFiltrarDoctor.DisplayMember = "NombreCompleto";
            cmbFiltrarDoctor.ValueMember = "id_empleado";
            cmbFiltrarDoctor.SelectedIndex = -1; // Sin selección = ver todos los doctores
        }

        private void CargarCitas()
        {
            try
            {
                // 1. Obtener el doctor seleccionado 
                int? idDoctor = null;
                if (cmbFiltrarDoctor.SelectedValue != null && cmbFiltrarDoctor.SelectedIndex != -1)
                {
                    if (int.TryParse(cmbFiltrarDoctor.SelectedValue.ToString(), out int id))
                        idDoctor = id;
                }

                DateTime fecha = dtpFechaCita.Value.Date;

                // 2. Cargar citas del día 
                DataTable citas;
                if (idDoctor.HasValue)
                    citas = clsCitaDAL.ObtenerCitas(idDoctor.Value, fecha);
                else
                    citas = clsCitaDAL.CargarDataGrid(fecha); 

                dgvCitas.DataSource = citas;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // 3. Cargar horas disponibles (solo si hay doctor seleccionado)
                CargarHorasDisponibles(idDoctor, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // muestra las horas libres en un ListBox 
        private void CargarHorasDisponibles(int? idDoctor, DateTime fecha)
        {
            lstHorasDisponibles.Items.Clear();
            if (!idDoctor.HasValue)
            {
                lstHorasDisponibles.Items.Add("Seleccione un doctor para ver disponibilidad.");
                return;
            }

            // Usamos la misma capa de negocio que en frmCita
            clsCitaNegocio negocio = new clsCitaNegocio();
            var resultado = negocio.ObtenerHorasDisponibles(idDoctor.Value, fecha, null);

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
                {
                    lstHorasDisponibles.Items.Add(hora);
                }
            }
        }

        private void cmbFiltrarDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void btnNuevoCita_Click(object sender, EventArgs e)
        {
            frmCita frm = new frmCita();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarCitas();
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                frmCita frm = new frmCita(idCita);
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarCitas();
            }
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                string nombrePaciente = rowView["Paciente"].ToString();

                DialogResult res = MessageBox.Show($"¿Confirmar la cita de {nombrePaciente}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (clsCitaDAL.CambiarEstado(idCita, "Confirmada"))
                    {
                        MessageBox.Show("Cita confirmada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else MessageBox.Show("No se pudo confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para cancelar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                string nombrePaciente = rowView["Paciente"].ToString();

                DialogResult res = MessageBox.Show($"¿Cancelar la cita de {nombrePaciente}?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (clsCitaDAL.Cancelar(idCita))
                    {
                        MessageBox.Show("Cita cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else MessageBox.Show("No se pudo cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cmbFiltrarDoctor.SelectedIndex = -1;
            dtpFechaCita.Value = DateTime.Today;
            CargarCitas();
        }

    }
}