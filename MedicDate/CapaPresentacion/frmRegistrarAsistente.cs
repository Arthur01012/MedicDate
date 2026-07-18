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
    public partial class frmRegistrarAsistente : Form
    {
        clsAsistenteDAL asistente;
        public frmRegistrarAsistente()
        {
            InitializeComponent();
            cargarGrid();
        }

        private void btnNuevoAsistente_Click(object sender, EventArgs e)
        {
            frmAsistente frm = new frmAsistente();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
        public void cargarGrid()
        {
            asistente = new clsAsistenteDAL();
            dgvAsistentes.DataSource = null;
            dgvAsistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAsistentes.DataSource = asistente.CargarDataGrid();
                dgvAsistentes.Columns["id_empleado"].Visible = false;
                dgvAsistentes.Columns["id_empleado1"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarAsistente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarAsistente.Text))
            {
                cargarGrid();
                return;
            }

            asistente = new clsAsistenteDAL();
            dgvAsistentes.DataSource = null;
            dgvAsistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAsistentes.DataSource = asistente.Consultar(txtBuscarAsistente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
