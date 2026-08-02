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

        private void frmPerfilDoctor_Load(object sender, EventArgs e)// Evento que se ejecuta al cargar el formulario
        {
            CargarDatos();
        }

        private void CargarDatos()// Método para cargar los datos del doctor en el formulario
        {
            try
            {
                if (Sesion.IdEmpleadoActual == 0)
                {
                    MessageBox.Show("No se pudo identificar al doctor en sesión.",
                                    "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idDoctor = Sesion.IdEmpleadoActual;// Obtener el ID del doctor en sesión


                DataTable ficha = clsDoctorDAL.ObtenerFichaDoctor(idDoctor);// Obtener la ficha del doctor desde la base de datos
                dgvFicha.DataSource = ficha;// Asignar la ficha al DataGridView
                dgvFicha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustar el tamaño de las columnas automáticamente


                DataTable horarios = clsHorarioDAL.ObtenerHorariosDoctor(idDoctor);// Obtener los horarios del doctor desde la base de datos
                dataGridView2.DataSource = horarios;// Asignar los horarios al DataGridView
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustar el tamaño de las columnas automáticamente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el perfil: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}