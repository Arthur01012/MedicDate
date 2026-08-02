using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)// Carga inicial del formulario
        {
            if (Sesion.IdEmpleadoActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión como doctor para ver la agenda.",
                                "Sesión no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            dtpFechaCita.Value = DateTime.Today;
            CargarFiltrosEstados();
            CargarCitas();
        }

        private void CargarFiltrosEstados()// Carga de los filtros de estado en el ComboBox
        {
            // Obtenemos la lista de estados desde la Capa de Negocio
            cmbFiltroEstado.DataSource = clsCitaNegocio.ObtenerEstadosCita();
            cmbFiltroEstado.SelectedIndex = 0;
        }
        private void CargarCitas()// Carga de las citas en el DataGridView
        {
            try
            {
                int idDoctor = Sesion.IdEmpleadoActual; // El ID del doctor logueado
                DateTime fecha = dtpFechaCita.Value.Date;
                string estadoSeleccionado = cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos";

                DataTable tabla = clsCitaNegocio.ObtenerAgendaDoctor(idDoctor, fecha, estadoSeleccionado);// Obtenemos las citas desde la Capa de Negocio

                dgvCita.DataSource = tabla;
                dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustamos el tamaño de las columnas automáticamente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la agenda del doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)// Evento que se dispara al cambiar la selección del ComboBox de doctores
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)// private void cmbFiltroEstado_ValueChanged(
        {
            CargarCitas();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de ver detalle de la cita
        {
            if (dgvCita.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para ver el detalle.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCita = Convert.ToInt32(dgvCita.SelectedRows[0].Cells["id_cita"].Value);// Obtenemos el ID de la cita seleccionada

            frmDetalleCita frm = new frmDetalleCita(idCita);// Creamos una instancia del formulario de detalle de cita

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCitas();
            }
        }
    }
}