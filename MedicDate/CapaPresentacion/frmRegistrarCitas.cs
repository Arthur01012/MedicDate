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

        private void frmRegistrarCitas_Load(object sender, EventArgs e)// Evento que se ejecuta al cargar el formulario
        {
            // Fecha por defecto: hoy
            dtpFechaCita.Value = DateTime.Today;
            CargarComboDoctores();
            CargarCitas();
        }

        private void CargarComboDoctores()// Método para cargar el combo de doctores
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();// Obtener los doctores activos de la base de datos
            cmbFiltrarDoctor.DataSource = doctores;
            cmbFiltrarDoctor.DisplayMember = "NombreCompleto";
            cmbFiltrarDoctor.ValueMember = "id_empleado";
            cmbFiltrarDoctor.SelectedIndex = -1; // Sin selección = ver todos los doctores
        }

        private void CargarCitas()// Método para cargar las citas en el DataGridView
        {
            try
            {
                // Obtener el doctor seleccionado 
                int? idDoctor = null;
                if (cmbFiltrarDoctor.SelectedValue != null && cmbFiltrarDoctor.SelectedIndex != -1)
                {
                    if (int.TryParse(cmbFiltrarDoctor.SelectedValue.ToString(), out int id))
                        idDoctor = id;
                }

                DateTime fecha = dtpFechaCita.Value.Date;

                //Cargar citas del día 
                DataTable citas;
                if (idDoctor.HasValue)
                    citas = clsCitaDAL.ObtenerCitas(idDoctor.Value, fecha);
                else
                    citas = clsCitaDAL.CargarDataGrid(fecha); 

                dgvCitas.DataSource = citas;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //Cargar horas disponibles (solo si hay doctor seleccionado)
                CargarHorasDisponibles(idDoctor, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // muestra las horas libres en un ListBox 
        private void CargarHorasDisponibles(int? idDoctor, DateTime fecha)// Método para cargar las horas disponibles en el ListBox
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
                    lstHorasDisponibles.Items.Add(hora);// Agregamos cada hora disponible al ListBox
                }
            }
        }

        private void cmbFiltrarDoctor_SelectedIndexChanged(object sender, EventArgs e)// Evento que se ejecuta al cambiar la selección del combo de doctores
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)// Evento que se ejecuta al cambiar la fecha en el DateTimePicker
        {
            CargarCitas();
        }

        private void btnNuevoCita_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Nueva Cita"
        {
            frmCita frm = new frmCita();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarCitas();
        }

        private void btnEditarCita_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Editar Cita"
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;// Obtenemos la fila seleccionada como DataRowView
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                frmCita frm = new frmCita(idCita);// Creamos una instancia de frmCita pasando el id de la cita a editar
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarCitas();
            }
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Confirmar Cita"
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;// Obtenemos la fila seleccionada como DataRowView
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                string nombrePaciente = rowView["Paciente"].ToString();

                DialogResult res = MessageBox.Show($"¿Confirmar la cita de {nombrePaciente}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (clsCitaDAL.CambiarEstado(idCita, "Confirmada"))// Cambiamos el estado de la cita a "Confirmada"
                    {
                        MessageBox.Show("Cita confirmada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else MessageBox.Show("No se pudo confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Cancelar Cita"
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

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Limpiar Filtro"
        {
            cmbFiltrarDoctor.SelectedIndex = -1;
            dtpFechaCita.Value = DateTime.Today;
            CargarCitas();
        }

    }
}