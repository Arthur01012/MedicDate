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
    }
}
