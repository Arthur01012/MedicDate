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
            CargarAgenda();
        }

        private void CargarAgenda()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarDoctor.Text))
                {
                    dgvCitas.DataSource = clsCitaDAL.CargarDataGrid(dtpFecha.Value);
                }
                else
                {
                    dgvCitas.DataSource = clsCitaDAL.Consultar(dtpFecha.Value, txtBuscarDoctor.Text);
                }

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar agenda:\n\n{ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarAgenda();
        }


        private void txtBuscarDoctor_TextChanged(object sender, EventArgs e)
        {
            CargarAgenda(); 
        }
    }
}