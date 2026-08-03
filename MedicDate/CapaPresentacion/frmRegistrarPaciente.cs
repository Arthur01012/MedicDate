using MedicDate.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarPaciente : Form
    {
        public frmRegistrarPaciente()
        {
            InitializeComponent();
        }
        private void frmRegistrarPaciente_Load(object sender, EventArgs e)
        {
            clsPacienteDAL pacienteDAL = new clsPacienteDAL();
            dgvPacientes.DataSource = pacienteDAL.CargarDataGrid();
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            clsPacienteDAL pacienteDAL = new clsPacienteDAL();
            dgvPacientes.DataSource = pacienteDAL.Consultar(txtBuscarPaciente.Text);
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnverHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente(0);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

            // Refresca el grid al cerrar, por si se registró un paciente nuevo.
            clsPacienteDAL pacienteDAL = new clsPacienteDAL();
            dgvPacientes.DataSource = pacienteDAL.CargarDataGrid();
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Editar Paciente"
        {
            // Obtener la fila actual
            DataGridViewRow? fila = dgvPacientes.CurrentRow;

            // Validar que exista una fila y que tenga datos
            if (fila == null || fila.Cells["id_paciente"].Value == null)
            {
                MessageBox.Show("Seleccione un paciente para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del paciente desde la fila actual
            int idPaciente = Convert.ToInt32(fila.Cells["id_paciente"].Value);

            // Abrir el formulario de edición
            frmPaciente frm = new frmPaciente(idPaciente);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                clsPacienteDAL pacienteDAL = new clsPacienteDAL();
                dgvPacientes.DataSource = pacienteDAL.CargarDataGrid();
                dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
