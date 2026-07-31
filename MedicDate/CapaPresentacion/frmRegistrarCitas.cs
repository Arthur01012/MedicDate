using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarCitas : Form
    {
        public frmRegistrarCitas()
        {
            InitializeComponent();
        }

        private void frmRegistrarCitas_Load(object sender, EventArgs e)
        {
            CargarComboDoctores();
            CargarCitas();
        }


        private void CargarComboDoctores()
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();

            cmbFiltrarDoctor.DataSource = doctores;
            cmbFiltrarDoctor.DisplayMember = "NombreCompleto"; 
            cmbFiltrarDoctor.ValueMember = "id_empleado";      


            cmbFiltrarDoctor.SelectedIndex = -1;
        }


        private void CargarCitas()
        {
            try
            {
                int? idDoctor = null;

                if (cmbFiltrarDoctor.SelectedValue != null && cmbFiltrarDoctor.SelectedIndex != -1)
                {
                    if (int.TryParse(cmbFiltrarDoctor.SelectedValue.ToString(), out int id))
                    {
                        idDoctor = id;
                    }
                }

                dgvCitas.DataSource = clsCitaDAL.ObtenerCitas(idDoctor);
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbFiltrarDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }


        private void btnNuevoCita_Click(object sender, EventArgs e)
        {
            frmCita frm = new frmCita();
            frm.ShowDialog();
            CargarCitas(); 
        }


        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]); 

                // Descomenta esto cuando tengas tu frmCita preparado para editar:
                // frmCita frm = new frmCita(idCita);
                // frm.ShowDialog();

                MessageBox.Show($"Funcionalidad pendiente: Editar cita ID {idCita}", "Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCitas();
            }
        }


        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                string nombrePaciente = rowView["Paciente"].ToString();

                DialogResult res = MessageBox.Show($"¿Confirmar la cita del paciente {nombrePaciente}?", "Confirmar cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (clsCitaDAL.CambiarEstado(idCita, "Confirmada"))
                    {
                        MessageBox.Show("Cita confirmada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo confirmar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para cancelar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = dgvCitas.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                int idCita = Convert.ToInt32(rowView["id_cita"]);
                string nombrePaciente = rowView["Paciente"].ToString();

                DialogResult res = MessageBox.Show($"¿Está seguro de CANCELAR la cita de {nombrePaciente}?\nEsta acción no se puede deshacer.",
                    "Cancelar cita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    if (clsCitaDAL.Cancelar(idCita))
                    {
                        MessageBox.Show("Cita cancelada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cancelar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}