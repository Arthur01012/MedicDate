using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmPerfilDoctor : Form
    {
        public frmPerfilDoctor()
        {
            InitializeComponent();
        }

        private void frmPerfilDoctor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                if (Sesion.IdEmpleadoActual == 0)
                {
                    MessageBox.Show("No se pudo identificar al doctor en sesión.",
                                    "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idDoctor = Sesion.IdEmpleadoActual;


                DataTable ficha = clsDoctorDAL.ObtenerFichaDoctor(idDoctor);
                dgvFicha.DataSource = ficha;
                dgvFicha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                DataTable horarios = clsHorarioDAL.ObtenerHorariosDoctor(idDoctor);
                dataGridView2.DataSource = horarios;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el perfil: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}