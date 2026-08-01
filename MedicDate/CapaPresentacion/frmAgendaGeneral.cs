using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmAgendaGeneral : Form
    {
        public frmAgendaGeneral()
        {
            InitializeComponent();
        }

        
        private void frmAgendaGeneral_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today; // Establecemos la fecha de hoy
            ActualizarAgenda();              // Cargamos la agenda del día de hoy
        }

        
        private void ActualizarAgenda()
        {
            try
            {
                DataTable tabla = clsCitaDAL.Consultar(dtpFecha.Value, txtBuscarDoctor.Text);

                dgvCitas.DataSource = tabla;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCitas.Columns["id_cita"].Visible = false; // Oculta el ID de la cita
                dgvCitas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de fecha
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la agenda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarAgenda();
        }
       
        private void txtBuscarDoctor_TextChanged(object sender, EventArgs e)
        {
            ActualizarAgenda();
        }
    }
}