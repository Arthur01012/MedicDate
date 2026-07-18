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
    public partial class frmRegistrarDoctor : Form
    {
        clsDoctorDal Doctor;
        public frmRegistrarDoctor()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid()
        {
            Doctor = new clsDoctorDal();
            dgvDoctores.DataSource = null;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDoctores.DataSource = Doctor.CargarDataGrid();
                dgvDoctores.Columns["id_empleado"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnEditarDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void txtBuscarDoctor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarDoctor.Text))
            {
                cargarGrid();
                return;
            }

            Doctor = new clsDoctorDal();
            dgvDoctores.DataSource = null;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDoctores.DataSource = Doctor.Consultar(txtBuscarDoctor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
      

