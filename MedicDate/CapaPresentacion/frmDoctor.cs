using MedicDate.Datos;
using MedicDate.Helpers;
using MedicDate.Procesos;
using MySqlConnector;
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
    public partial class frmDoctor : Form
    {
        private clsDoctor doctor = new clsDoctor();

        public frmDoctor()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarEspecialidades();
        }
        private void ConfigurarFormulario()
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);
            dtpFechaContratacion.Value = DateTime.Today;
        }

        private void CargarEspecialidades()
        {
            DataTable especialidades = clsEspecialidadDAL.ObtenerTodos();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "nombre_especialidad";
            cmbEspecialidad.ValueMember = "id_especialidad";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            try
            {
                // Datos personales
                doctor.nombre = txtNombreDoctor.Text.Trim();
                doctor.apellido_paterno = txtAPaterno.Text.Trim();
                doctor.apellido_materno = txtAMaterno.Text.Trim();
                doctor.fecha_nacimiento = dtpFechaNacimiento.Value;
                doctor.email = txtEmail.Text.Trim();
                doctor.telefono_principal = txtTelefono.Text.Trim();
                doctor.telefono_secundario = txtTelefonoSecundario.Text.Trim();
                doctor.fecha_contratacion = dtpFechaContratacion.Value;
                doctor.estado = chkActivo.Checked;

                // Datos del doctor
                doctor.cedula_profesional = txtCedula.Text.Trim();
                doctor.especialidad_principal = (int)cmbEspecialidad.SelectedValue;
                doctor.consultorio = txtConsultorio.Text.Trim();

                // Datos de usuario
                doctor.id_usuario = CrearUsuario();

                // Insertar empleado
                int idEmpleado = clsEmpleadoDAL.Insertar(doctor);
                if (idEmpleado > 0)
                {
                    doctor.id_empleado = idEmpleado;

                    // Insertar doctor
                    if (clsDoctorDAL.Insertar(doctor))
                    {
                        MessageBox.Show("Doctor registrado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar los datos del doctor.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar el empleado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreDoctor.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreDoctor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAPaterno.Text))
            {
                MessageBox.Show("El apellido paterno es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAPaterno.Focus();
                return false;
            }

            if (!clsValidaciones.EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("El email no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("La cédula profesional es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                txtConfirmarContrasena.Clear();
                txtContrasena.Focus();
                return false;
            }

            return true;
        }

        private int? CrearUsuario()
        {
            clsUsuario usuario = new clsUsuario
            {
                usuario = txtUsuario.Text.Trim(),
                contrasena = txtContrasena.Text.Trim(),
                id_rol = (int)clsUsuario.Roles.Doctor,
                activo = true
            };

            if (clsUsuarioDAL.CrearUsuario(usuario))
            {
                return usuario.id_usuario;
            }
            return null;
        }

        private void LimpiarFormulario()
        {
            txtNombreDoctor.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtTelefonoSecundario.Clear();
            txtCedula.Clear();
            txtConsultorio.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            chkActivo.Checked = true;
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-25);
            dtpFechaContratacion.Value = DateTime.Today;
            txtNombreDoctor.Focus();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
