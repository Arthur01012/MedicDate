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

        private void frmAgenda_Load(object sender, EventArgs e)
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

        private void CargarFiltrosEstados()
        {
            // Obtenemos la lista de estados desde la Capa de Negocio
            cmbFiltroEstado.DataSource = clsCitaNegocio.ObtenerEstadosCita();
            cmbFiltroEstado.SelectedIndex = 0;
        }
        private void CargarCitas()
        {
            try
            {
                int idDoctor = Sesion.IdEmpleadoActual; // El ID del doctor logueado
                DateTime fecha = dtpFechaCita.Value.Date;
                string estadoSeleccionado = cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos";

                DataTable tabla = clsCitaNegocio.ObtenerAgendaDoctor(idDoctor, fecha, estadoSeleccionado);

                dgvCita.DataSource = tabla;
                dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la agenda del doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCita.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para ver el detalle.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCita = Convert.ToInt32(dgvCita.SelectedRows[0].Cells["id_cita"].Value);

            frmDetalleCita frm = new frmDetalleCita(idCita);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCitas();
            }
        }
    }
}