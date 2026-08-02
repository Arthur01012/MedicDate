using MedicDate.Procesos;
using MedicDate.Datos;
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
        clsDoctorDAL Doctor;

        private int paginaActual = 1;
        private int registrosPorPagina = 10;
        private int totalPaginas;

        public frmRegistrarDoctor()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid()
        {
            Doctor = new clsDoctorDAL();
            int total = Doctor.TotalDoctores();

            totalPaginas = (int)Math.Ceiling((double)total / registrosPorPagina);
            dgvDoctores.DataSource = null;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvDoctores.DataSource = Doctor.CargarDataGrid(paginaActual,registrosPorPagina);
                dgvDoctores.Columns["id_empleado"].Visible = false;
                lblPagina.Text = $"Página {paginaActual} de {totalPaginas}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor(0);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnEditarDoctor_Click(object sender, EventArgs e)
        {
            // Obtener la fila actual 
            DataGridViewRow? fila = dgvDoctores.CurrentRow;

            // Validar que exista una fila y que tenga datos
            if (fila == null || fila.Cells["id_empleado"].Value == null)
            {
                MessageBox.Show("Seleccione un doctor para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del doctor desde la fila actual
            int idDoctor = Convert.ToInt32(fila.Cells["id_empleado"].Value);

            // Abrir el formulario de edición
            frmDoctor frm = new frmDoctor(idDoctor);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarGrid(); // Refrescar el DataGridView
            }
        }

        private void txtBuscarDoctor_TextChanged(object sender, EventArgs e)
        {
            paginaActual = 1;

            Doctor = new clsDoctorDAL();

            if (string.IsNullOrWhiteSpace(txtBuscarDoctor.Text))
            {
                cargarGrid();
                return;
            }

            int total = Doctor.TotalBusqueda(txtBuscarDoctor.Text);

            totalPaginas = (int)Math.Ceiling((double)total / registrosPorPagina);

            dgvDoctores.DataSource = Doctor.Consultar(
                txtBuscarDoctor.Text,
                paginaActual,
                registrosPorPagina);
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            // Verificar que haya filas
            if (dgvDoctores.Rows.Count == 0)
            {
                MessageBox.Show("No hay doctores registrados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener fila seleccionada
            DataGridViewRow? fila = null;
            if (dgvDoctores.CurrentRow != null)
                fila = dgvDoctores.CurrentRow;


            if (fila == null)
            {
                MessageBox.Show("Seleccione un doctor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores
            int idDoctor = Convert.ToInt32(fila.Cells["id_empleado"].Value);
            string nombreDoctor = fila.Cells["Nombre Completo"].Value?.ToString() ?? "Sin nombre";

            // Confirmar
            DialogResult confirm = MessageBox.Show(
                $"¿Dar de baja al doctor {nombreDoctor}?" +
                "Esta acción:\n" +
                "-Desactivará al doctor.\n" +
                "-Desactivará su horario.\n" +
                "-Desactivará su usario",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            try
            {
                bool resultado = clsDoctorDAL.DarBaja(idDoctor);
                if (resultado)
                {
                    MessageBox.Show("Baja exitosa.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrid(); // Recargar
                }
                else
                {
                    MessageBox.Show("Error al dar de baja.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                cargarGrid();
            }
        }

        private void btnDespues_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                cargarGrid();
            }
        }
    }
}
      

