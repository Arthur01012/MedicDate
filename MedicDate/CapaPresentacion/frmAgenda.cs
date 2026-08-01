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
            // Establecemos fecha por defecto al cargar
            dtpFechaCita.Value = DateTime.Today;
            CargarDoctores();
            CargarCitas();
        }

        // --- Cargar el ComboBox con los doctores activos ---
        private void CargarDoctores()
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
            cmbDoctor.DataSource = doctores;
            cmbDoctor.DisplayMember = "NombreCompleto";
            cmbDoctor.ValueMember = "id_empleado";
            cmbDoctor.SelectedIndex = -1; // Sin selección por defecto
        }

        private void CargarCitas()
        {
            try
            {
                // Validamos que haya una fila seleccionada en el ComboBox
                if (cmbDoctor.SelectedItem == null)
                {
                    dgvCita.DataSource = null;
                    return;
                }

                // Extraemos el objeto DataRowView de la selección
                DataRowView rowView = cmbDoctor.SelectedItem as DataRowView;
                if (rowView == null)
                {
                    dgvCita.DataSource = null;
                    return;
                }

                // Obtenemos el ID del doctor directamente desde la fila del DataTable
                int idDoctor = Convert.ToInt32(rowView["id_empleado"]);
                DateTime fecha = dtpFechaCita.Value.Date;

                // Cargamos las citas usando el método de la DAL
                DataTable tabla = clsCitaDAL.ObtenerCitas(idDoctor, fecha);

                dgvCita.DataSource = tabla;
                dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la agenda del doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Eventos de cambio ---
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        // --- Botón Ver Detalle ---
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCita.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para ver el detalle.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tomamos el ID de la cita de la fila seleccionada
            int idCita = Convert.ToInt32(dgvCita.SelectedRows[0].Cells["id_cita"].Value);

            // Abrimos el formulario frmCita en modo EDICIÓN
            frmCita frm = new frmCita(idCita);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCitas(); // Refrescamos el grid si se editó o canceló la cita
            }
        }
    }
}