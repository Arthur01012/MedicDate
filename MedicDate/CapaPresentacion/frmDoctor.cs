using MedicDate.Datos;
using MedicDate.Helpers;
using MedicDate.Procesos;
using MySqlConnector;
using System;
using System.Data;
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

            // ✅ CheckBox ACTIVO por defecto
            chkActivo.Checked = true;
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

            using var conexion = clsConexion.ObtenerConexion();
            using var transaccion = conexion.BeginTransaction();

            try
            {
                // Datos personales
                doctor.nombre = txtNombreDoctor.Text.Trim();
                doctor.apellido_paterno = txtAPaterno.Text.Trim();
                doctor.apellido_materno = txtAMaterno.Text.Trim();
                doctor.fecha_nacimiento = dtpFechaNacimiento.Value;
                doctor.curp = txtCurp.Text.Trim().ToUpper();
                doctor.email = txtEmail.Text.Trim();
                doctor.telefono_principal = txtTelefono.Text.Trim();
                doctor.telefono_secundario = txtTelefonoSecundario.Text.Trim();
                doctor.fecha_contratacion = dtpFechaContratacion.Value;
                doctor.estado = chkActivo.Checked; // ✅ Único control de estado

                // Datos del doctor
                doctor.cedula_profesional = txtCedula.Text.Trim();
                doctor.especialidad_principal = (int)cmbEspecialidad.SelectedValue;
                doctor.consultorio = txtConsultorio.Text.Trim();

                // Crear usuario
                doctor.id_usuario = CrearUsuario(transaccion);
                if (!doctor.id_usuario.HasValue)
                    throw new Exception("No se pudo crear el usuario.");

                // Insertar empleado
                doctor.id_empleado = clsEmpleadoDAL.Insertar(doctor, transaccion);
                if (doctor.id_empleado == 0)
                    throw new Exception("No se pudo insertar el empleado.");

                // Insertar doctor
                if (!clsDoctorDAL.Insertar(doctor, transaccion))
                    throw new Exception("No se pudo insertar el doctor.");

                transaccion.Commit();

                MessageBox.Show("Doctor registrado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show($"Error al registrar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? CrearUsuario(MySqlTransaction? transaccion = null)
        {
            clsUsuario usuario = new clsUsuario
            {
                usuario = txtUsuario.Text.Trim(),
                contrasena = txtContrasena.Text.Trim(),
                id_rol = (int)clsUsuario.Roles.Doctor,
                activo = true
            };

            if (clsUsuarioDAL.CrearUsuario(usuario, transaccion))
                return usuario.id_usuario;

            return null;
        }

        private bool ValidarDatos()
        {
            // Nombre
            if (string.IsNullOrEmpty(txtNombreDoctor.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreDoctor.Focus();
                return false;
            }

            // Apellido Paterno
            if (string.IsNullOrEmpty(txtAPaterno.Text))
            {
                MessageBox.Show("El apellido paterno es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAPaterno.Focus();
                return false;
            }

            // CURP (Obligatorio)
            if (string.IsNullOrEmpty(txtCurp.Text))
            {
                MessageBox.Show("El CURP es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurp.Focus();
                return false;
            }
            if (!clsValidaciones.EsCURPValido(txtCurp.Text))
            {
                MessageBox.Show("El CURP no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurp.Focus();
                return false;
            }

            // Email
            if (!clsValidaciones.EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("El email no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Teléfono principal (opcional)
            if (!string.IsNullOrEmpty(txtTelefono.Text) && !clsValidaciones.EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono principal no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            // Teléfono secundario (opcional)
            if (!string.IsNullOrEmpty(txtTelefonoSecundario.Text) && !clsValidaciones.EsTelefonoValido(txtTelefonoSecundario.Text))
            {
                MessageBox.Show("El teléfono secundario no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefonoSecundario.Focus();
                return false;
            }

            // Cédula profesional
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("La cédula profesional es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            // Especialidad seleccionada
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una especialidad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEspecialidad.Focus();
                return false;
            }

            // Fecha de nacimiento (mayor de 18 años)
            if (!clsValidaciones.EsEdadValida(dtpFechaNacimiento.Value, 18, 120))
            {
                MessageBox.Show("El doctor debe ser mayor de 18 años.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return false;
            }

            // Fecha de contratación (no futura)
            if (dtpFechaContratacion.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de contratación no puede ser futura.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaContratacion.Focus();
                return false;
            }

            // Usuario
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            // Contraseña
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

        private void LimpiarFormulario()
        {
            txtNombreDoctor.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtCurp.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtTelefonoSecundario.Clear();
            txtCedula.Clear();
            txtConsultorio.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();

            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-25);
            dtpFechaContratacion.Value = DateTime.Today;
            chkActivo.Checked = true; // ✅ Por defecto ACTIVO

            cmbEspecialidad.SelectedIndex = -1;
            txtNombreDoctor.Focus();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}