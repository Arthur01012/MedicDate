using MedicDate.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarEspecialidad : Form
    {
        clsEspecialidadDAL especialidad;
        public frmRegistrarEspecialidad()
        {
            InitializeComponent();
            cargarGrid();
        }
        public void cargarGrid()
        {
            especialidad = new clsEspecialidadDAL();
            dgvEspecialidad.DataSource = null;
            dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvEspecialidad.DataSource = especialidad.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarEspecialidad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarEspecialidad.Text))
            {
                cargarGrid();
                return;
            }

            especialidad = new clsEspecialidadDAL();
            dgvEspecialidad.DataSource = null;
            dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvEspecialidad.DataSource = especialidad.Consultar(txtBuscarEspecialidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
