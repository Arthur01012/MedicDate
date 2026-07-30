using MedicDate.Datos;
using MedicDate.Procesos;
using System;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarEspecialidad : Form
    {
        private clsEspecialidadDAL especialidadDAL;
        private int? idEspecialidadSeleccionado = null; // Para saber qué registro estamos editando

        public frmRegistrarEspecialidad()
        {
            InitializeComponent();
            especialidadDAL = new clsEspecialidadDAL();
            cargarGrid();
        }

        private void cargarGrid()
        {
            try
            {
                dgvEspecialidad.DataSource = null;
                dgvEspecialidad.DataSource = especialidadDAL.CargarDataGrid();
                dgvEspecialidad.Columns["id_especialidad"].Visible = false; 
                dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                idEspecialidadSeleccionado = null; 
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtEspecialidad.Text = "";
            txtDescripcion.Text = "";
            idEspecialidadSeleccionado = null;
            txtEspecialidad.Focus();
        }

        private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEspecialidad.Rows[e.RowIndex];
                idEspecialidadSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtEspecialidad.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value != null ? fila.Cells[2].Value.ToString() : "";
            }
        }

        private void btnNuevoEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                {
                    MessageBox.Show("El nombre de la especialidad es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevaEspecialidad = new clsEspecialidad
                {
                    nombre_especialidad = txtEspecialidad.Text.Trim(),
                    descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()
                };

                int nuevoId = clsEspecialidadDAL.Insertar(nuevaEspecialidad);
                if (nuevoId > 0)
                {
                    MessageBox.Show("Especialidad agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!idEspecialidadSeleccionado.HasValue)
                {
                    MessageBox.Show("Por favor, selecciona una especialidad de la tabla para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                {
                    MessageBox.Show("El nombre de la especialidad no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var especialidadEditar = new clsEspecialidad
                {
                    id_especialidad = idEspecialidadSeleccionado.Value,
                    nombre_especialidad = txtEspecialidad.Text.Trim(),
                    descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()
                };

                if (clsEspecialidadDAL.Actualizar(especialidadEditar))
                {
                    MessageBox.Show("Especialidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDarBaja4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!idEspecialidadSeleccionado.HasValue)
                {
                    MessageBox.Show("Por favor, selecciona una especialidad para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de eliminar la especialidad '{txtEspecialidad.Text}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {                    
                    if (clsEspecialidadDAL.Eliminar(idEspecialidadSeleccionado.Value))
                    {
                        MessageBox.Show("Especialidad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar. Es posible que la especialidad ya no exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarEspecialidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarEspecialidad.Text))
                {
                    cargarGrid();
                }
                else
                {
                    dgvEspecialidad.DataSource = null;
                    dgvEspecialidad.DataSource = especialidadDAL.Consultar(txtBuscarEspecialidad.Text);
                    dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}