using System;
using System.Data;
using System.Windows.Forms;
using MedicDate.Procesos;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarHorario : Form
    {
        private clsHorarioDAL horarioDAL = new clsHorarioDAL();

        public frmRegistrarHorario()// Constructor del formulario
        {
            InitializeComponent();
            CargarGrid();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()// Método para configurar las propiedades del DataGridView
        {
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.MultiSelect = false;
            dgvHorarios.ReadOnly = true;
        }

        private void CargarGrid()// Método para cargar los datos en el DataGridView
        {
            try
            {
                DataTable dt = horarioDAL.CargarGrid();
                dgvHorarios.DataSource = dt;
                // Ocultar columnas que no se necesitan mostrar
                if (dgvHorarios.Columns.Contains("id_horario"))
                    dgvHorarios.Columns["id_horario"].Visible = false;
                if (dgvHorarios.Columns.Contains("id_doctor"))
                    dgvHorarios.Columns["id_doctor"].Visible = false;
                if (dgvHorarios.Columns.Contains("ActivoBool"))
                    dgvHorarios.Columns["ActivoBool"].Visible = false;
                // Ajustar títulos de columnas
                if (dgvHorarios.Columns.Contains("Doctor"))
                    dgvHorarios.Columns["Doctor"].HeaderText = "Doctor";
                if (dgvHorarios.Columns.Contains("dia_semana"))
                    dgvHorarios.Columns["dia_semana"].HeaderText = "Día";
                if (dgvHorarios.Columns.Contains("hora_inicio"))
                    dgvHorarios.Columns["hora_inicio"].HeaderText = "Hora Inicio";
                if (dgvHorarios.Columns.Contains("hora_fin"))
                    dgvHorarios.Columns["hora_fin"].HeaderText = "Hora Fin";
                if (dgvHorarios.Columns.Contains("intervalo_atencion"))
                    dgvHorarios.Columns["intervalo_atencion"].HeaderText = "Intervalo";
                if (dgvHorarios.Columns.Contains("Estado"))
                    dgvHorarios.Columns["Estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar horarios: " + ex.Message);
            }
        }

        private void Buscar(string texto)// Método para buscar horarios por doctor
        {
            try
            {
                DataTable dt = horarioDAL.Buscar(texto);// Llamar al método de búsqueda en la capa de datos
                dgvHorarios.DataSource = dt;// Actualizar el DataGridView con los resultados de la búsqueda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }

        private void btnAsignarHora_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Asignar Hora"
        {
            frmHorarios frm = new frmHorarios();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CargarGrid(); // Refrescar después de guardar
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Editar Horario"
        {
            if (dgvHorarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un horario para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHorario = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells["id_horario"].Value);
            frmHorarios frm = new frmHorarios(idHorario);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CargarGrid();
        }

        private void txtBuscarDoctor1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarDoctor1.Text))
                CargarGrid();
            else
                Buscar(txtBuscarDoctor1.Text);
        }
        private void btnDesactivar_Click(object sender, EventArgs e)// Evento que se ejecuta al hacer clic en el botón "Desactivar"
        {
            try
            {

                DataGridViewRow filaSeleccionada = dgvHorarios.SelectedRows[0];// Obtener la fila seleccionada

                int idDoctor = Convert.ToInt32(filaSeleccionada.Cells["id_doctor"].Value);// Obtener el ID del doctor de la fila seleccionada
                string nombreDoctor = filaSeleccionada.Cells["Doctor"].Value?.ToString() ?? "Doctor";// Obtener el nombre del doctor de la fila seleccionada

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de desactivar TODOS los horarios del doctor '{nombreDoctor}'?\n\n" +
                    "Todos los bloques horarios activos de este doctor pasarán a estar inactivos.",
                    "Desactivar horarios masivos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (clsHorarioDAL.DesactivarTodosPorDoctor(idDoctor))// Llamar al método para desactivar todos los horarios del doctor
                    {
                        MessageBox.Show($"Todos los horarios del doctor '{nombreDoctor}' han sido desactivados.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarGrid(); // Recargar la tabla para reflejar el cambio
                    }
                    else
                    {
                        MessageBox.Show("No se pudo desactivar los horarios. Verifique que el doctor exista.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al desactivar los horarios: {ex.Message}",
                    "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}