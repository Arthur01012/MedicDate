using System;
using System.Data;
using System.Windows.Forms;
using MedicDate.Procesos;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarHorario : Form
    {
        private clsHorarioDAL horarioDAL = new clsHorarioDAL();

        public frmRegistrarHorario()
        {
            InitializeComponent();
            CargarGrid();
            ConfigurarDataGridView();
            // Eventos
            btnAsignarHora.Click += btnAsignarHora_Click;
            btnEditarHorario.Click += btnEditarHorario_Click;
            btnDarBaja3.Click += btnDarBaja3_Click;
            txtBuscarDoctor1.TextChanged += txtBuscarDoctor1_TextChanged;
        }

        private void ConfigurarDataGridView()
        {
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.MultiSelect = false;
            dgvHorarios.ReadOnly = true;
        }

        private void CargarGrid()
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

        private void Buscar(string texto)
        {
            try
            {
                DataTable dt = horarioDAL.Buscar(texto);
                dgvHorarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }

        private void btnAsignarHora_Click(object sender, EventArgs e)
        {
            frmHorarios frm = new frmHorarios();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CargarGrid(); // Refrescar después de guardar
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
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

        private void btnDarBaja3_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un horario para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHorario = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells["id_horario"].Value);
            string doctor = dgvHorarios.SelectedRows[0].Cells["Doctor"].Value.ToString();
            bool activo = Convert.ToBoolean(dgvHorarios.SelectedRows[0].Cells["ActivoBool"].Value);

            if (!activo)
            {
                MessageBox.Show("El horario ya está inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show($"¿Dar de baja el horario del doctor {doctor}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            try
            {
                if (clsHorarioDAL.CambiarEstado(idHorario, false))
                {
                    MessageBox.Show("Horario dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error al dar de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarDoctor1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarDoctor1.Text))
                CargarGrid();
            else
                Buscar(txtBuscarDoctor1.Text);
        }
    }
}