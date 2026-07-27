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

        private void btnDarBaja2_Click(object sender, EventArgs e)
        {
            // Verificar que haya filas en el grid
            if (dgvAsistentes.Rows.Count == 0)
            {
                MessageBox.Show("No hay asistentes registrados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataGridViewRow? fila = null;
            if (dgvAsistentes.CurrentRow != null)
                fila = dgvAsistentes.CurrentRow;

            if (fila == null)
            {
                MessageBox.Show("Seleccione un asistente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // Obtener valores
            int idAsistente = Convert.ToInt32(fila.Cells["id_empleado"].Value);
            string nombreAsistente = fila.Cells["nombre completo"].Value?.ToString() ?? "Sin nombre";

            // Confirmar
            DialogResult confirm = MessageBox.Show(
                $"¿Está seguro de dar de baja al asistente {nombreAsistente}?\n\n" +
                "Esta acción:\n" +
                "- Desactivará al asistente y su usario.\n",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.No)
                return;

            try
            {
                bool resultado = clsAsistenteDAL.DarBaja(idAsistente);

                if (resultado)
                {
                    MessageBox.Show($"El asistente {nombreAsistente} ha sido dado de baja.",
                        "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrid(); // Recargar grid
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja al asistente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarAsistente_Click(object sender, EventArgs e)
        {
            // Obtener la fila actual (donde está el cursor)
            DataGridViewRow? fila = dgvAsistentes.CurrentRow;

            // Validar que exista una fila y que tenga datos
            if (fila == null || fila.Cells["id_empleado"].Value == null)
            {
                MessageBox.Show("Seleccione un doctor para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del doctor desde la fila actual
            int idAsistente = Convert.ToInt32(fila.Cells["id_empleado"].Value);

            // Abrir el formulario de edición
            frmAsistente frm = new frmAsistente(idAsistente);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarGrid(); // Refrescar el DataGridView
            }
        }
    }
}
