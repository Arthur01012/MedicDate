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

        public frmRegistrarEspecialidad()// Constructor del formulario
        {
            InitializeComponent();
            especialidadDAL = new clsEspecialidadDAL();
            cargarGrid();
        }

        private void cargarGrid()// Método para cargar los datos en el DataGridView
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

        private void LimpiarCampos()// Método para limpiar los campos de texto y restablecer el estado del formulario
        {
            txtEspecialidad.Text = "";
            txtDescripcion.Text = "";
            idEspecialidadSeleccionado = null;
            txtEspecialidad.Focus();
        }

        private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)// Evento que se ejecuta al hacer clic en una celda del DataGridView
        {
            if (e.RowIndex >= 0)// Validar que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgvEspecialidad.Rows[e.RowIndex];
                idEspecialidadSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtEspecialidad.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value != null ? fila.Cells[2].Value.ToString() : "";
            }
        }

        private void btnNuevoEspecialidad_Click(object sender, EventArgs e)//evento que se ejecuta al hacer clic en el botón "Nuevo"
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                {
                    MessageBox.Show("El nombre de la especialidad es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevaEspecialidad = new clsEspecialidad// Crear un nuevo objeto de especialidad con los datos ingresados
                {
                    nombre_especialidad = txtEspecialidad.Text.Trim(),// Asignar el nombre de la especialidad, eliminando espacios en blanco al inicio y al final
                    descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()// Asignar la descripción de la especialidad, si está vacía se asigna null
                };

                int nuevoId = clsEspecialidadDAL.Insertar(nuevaEspecialidad);// Insertar la nueva especialidad en la base de datos y obtener el ID generado
                if (nuevoId > 0)// Validar si la inserción fue exitosa
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

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)//evento que se ejecuta al hacer clic en el botón "Editar"
        {
            try
            {
                if (!idEspecialidadSeleccionado.HasValue)// Validar que se haya seleccionado una especialidad para editar
                {
                    MessageBox.Show("Por favor, selecciona una especialidad de la tabla para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))// Validar que el nombre de la especialidad no esté vacío
                {
                    MessageBox.Show("El nombre de la especialidad no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var especialidadEditar = new clsEspecialidad// Crear un objeto de especialidad con los datos actualizados
                {
                    id_especialidad = idEspecialidadSeleccionado.Value,// Asignar el ID de la especialidad seleccionada
                    nombre_especialidad = txtEspecialidad.Text.Trim(),// Asignar el nombre de la especialidad, eliminando espacios en blanco al inicio y al final
                    descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()// Asignar la descripción de la especialidad, si está vacía se asigna null
                };

                if (clsEspecialidadDAL.Actualizar(especialidadEditar))// Intentar actualizar la especialidad en la base de datos
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

        private void btnDarBaja4_Click(object sender, EventArgs e)//evento que se ejecuta al hacer clic en el botón "Dar de baja"
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
                    if (clsEspecialidadDAL.Eliminar(idEspecialidadSeleccionado.Value))// Intentar eliminar la especialidad de la base de datos
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

        private void txtBuscarEspecialidad_TextChanged(object sender, EventArgs e)//evento que se ejecuta al cambiar el texto en el cuadro de búsqueda
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarEspecialidad.Text))// Si el cuadro de búsqueda está vacío, recargar el grid completo
                {
                    cargarGrid();
                }
                else
                {
                    dgvEspecialidad.DataSource = null;
                    dgvEspecialidad.DataSource = especialidadDAL.Consultar(txtBuscarEspecialidad.Text);// Filtrar las especialidades según el texto ingresado
                    dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustar el tamaño de las columnas automáticamente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}