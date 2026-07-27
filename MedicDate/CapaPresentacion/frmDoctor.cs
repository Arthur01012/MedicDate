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
        private int? idDoctorEditar = null; // Indica si estamos en modo edición
        private bool estadoOriginal;
        // Constructor para registro nuevo
        public frmDoctor()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarEspecialidades();
        }

        // Constructor para edición (recibe el ID del doctor)
        public frmDoctor(int idDoctor) : this()
        {
            idDoctorEditar = idDoctor;
            CargarDatosDoctor(idDoctor);
        }

        private void ConfigurarFormulario()
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);
            dtpFechaContratacion.Value = DateTime.Today;
            chkActivo.Checked = true;
        }

        private void CargarEspecialidades()
        {
            DataTable especialidades = clsEspecialidadDAL.ObtenerTodos();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "nombre_especialidad";
            cmbEspecialidad.ValueMember = "id_especialidad";
        }

        private void CargarDatosDoctor(int idDoctor)
        {
            try
            {
                clsDoctor? doctorEdit = clsDoctorDAL.ObtenerDoctorPorId(idDoctor);
                if (doctorEdit == null)
                {
                    MessageBox.Show("No se encontró el doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Asignar el doctor real y guardar su estado original
                doctor = doctorEdit;
                estadoOriginal = doctor.estado; // ✅ AHORA sí es el estado real del doctor cargado

                // Llenar controles
                txtNombreDoctor.Text = doctor.nombre;
                txtAPaterno.Text = doctor.apellido_paterno;
                txtAMaterno.Text = doctor.apellido_materno;
                dtpFechaNacimiento.Value = doctor.fecha_nacimiento;
                txtCurp.Text = doctor.curp;
                txtEmail.Text = doctor.email;
                txtTelefono.Text = doctor.telefono_principal;
                txtTelefonoSecundario.Text = doctor.telefono_secundario;
                dtpFechaContratacion.Value = doctor.fecha_contratacion;
                chkActivo.Checked = doctor.estado;
                txtCedula.Text = doctor.cedula_profesional;
                txtConsultorio.Text = doctor.consultorio;

                // Seleccionar especialidad
                if (doctor.especialidad_principal.HasValue)
                    cmbEspecialidad.SelectedValue = doctor.especialidad_principal.Value;

                // Mostrar nombre de usuario (si existe)
                txtUsuario.Text = doctorEdit.NombreUsuario ?? "";
                txtUsuario.Enabled = false;
                txtContrasena.Enabled = false;
                txtConfirmarContrasena.Enabled = false;
                txtContrasena.Text = "";
                txtConfirmarContrasena.Text = "";
                lblPaswword.Text = "Contraseña (no editable)";
                lblConfirmarContrasena.Text = "Confirmar (no editable)";

                // Cambiar texto del botón y título
                btnGuardar.Text = "Actualizar";
                this.Text = "Editar Doctor";

                // Deshabilitar campos de usuario y contraseña visualmente
                txtUsuario.Enabled = false;
                txtContrasena.Enabled = false;
                txtConfirmarContrasena.Enabled = false;
                txtUsuario.BackColor = System.Drawing.Color.LightGray;
                txtContrasena.BackColor = System.Drawing.Color.LightGray;
                txtConfirmarContrasena.BackColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            using var conexion = clsConexion.ObtenerConexion();
            using var transaccion = conexion.BeginTransaction();

            try
            {
                // Llenar objeto doctor con los datos del formulario
                doctor.nombre = txtNombreDoctor.Text.Trim();
                doctor.apellido_paterno = txtAPaterno.Text.Trim();
                doctor.apellido_materno = txtAMaterno.Text.Trim();
                doctor.fecha_nacimiento = dtpFechaNacimiento.Value;
                doctor.curp = txtCurp.Text.Trim().ToUpper();
                doctor.email = txtEmail.Text.Trim();
                doctor.telefono_principal = txtTelefonoPrimario.Text.Trim();
                doctor.telefono_secundario = txtTelefonoSecundario.Text.Trim();
                doctor.fecha_contratacion = dtpFechaContratacion.Value;
                doctor.estado = chkActivo.Checked;
                doctor.cedula_profesional = txtCedula.Text.Trim();
                doctor.especialidad_principal = (int)cmbEspecialidad.SelectedValue;
                doctor.consultorio = txtConsultorio.Text.Trim();

                if (idDoctorEditar.HasValue) // MODO EDICIÓN
                {
                    doctor.id_empleado = idDoctorEditar.Value;

                    // 1. Siempre actualizar datos personales del empleado
                    if (!clsEmpleadoDAL.Actualizar(doctor, transaccion))
                        throw new Exception("No se pudo actualizar el empleado.");

                    // 2. Siempre actualizar datos del doctor
                    if (!clsDoctorDAL.Actualizar(doctor, transaccion))
                        throw new Exception("No se pudo actualizar el doctor.");

                    // 3. Si cambió el estado, aplicar baja o reactivación
                    if (doctor.estado != estadoOriginal)
                    {
                        if (doctor.estado) // Nuevo estado = activo
                        {
                            if (!clsDoctorDAL.Reactivar(doctor.id_empleado, transaccion))
                                throw new Exception("No se pudo reactivar el doctor.");
                        }
                        else // Nuevo estado = inactivo
                        {
                            if (!clsDoctorDAL.DarBaja(doctor.id_empleado, transaccion))
                                throw new Exception("No se pudo dar de baja al doctor.");
                        }
                    }

                    transaccion.Commit();
                    MessageBox.Show("Doctor actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else // MODO REGISTRO 
                {
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
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? CrearUsuario(MySqlTransaction? transaccion = null)
        {
            clsUsuario usuario = new clsUsuario
            {
                usuario = txtUsuario.Text.Trim(),
                contrasena = txtContraseña.Text.Trim(),
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
            // Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("El email es obligatorio" +
                    ".", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!clsValidaciones.EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("El email no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            // CURP 
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


            // Teléfono principal (opcional)
            if (!string.IsNullOrEmpty(txtTelefonoPrimario.Text) && !clsValidaciones.EsTelefonoValido(txtTelefonoPrimario.Text))
            // Teléfono principal 
            if (!string.IsNullOrEmpty(txtTelefono.Text) && !clsValidaciones.EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono principal no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefonoPrimario.Focus();
                return false;
            }

            // Teléfono secundario
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


            // Fecha de nacimiento
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

        
        
            if (!idDoctorEditar.HasValue) // Solo si es registro nuevo
            {
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
            }

            // Contraseña
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }
            if (txtContraseña.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtConfirmarContrasena.Clear();
                txtContraseña.Focus();
                return false;
            }
            return true;
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

        private void LimpiarFormulario()
        {
            txtNombreDoctor.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtCurp.Clear();
            txtEmail.Clear();
            txtTelefonoPrimario.Clear();
            txtTelefonoSecundario.Clear();
            txtCedula.Clear();
            txtConsultorio.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmarContrasena.Clear();

            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-25);
            dtpFechaContratacion.Value = DateTime.Today;
            chkActivo.Checked = true;
            cmbEspecialidad.SelectedIndex = -1;
            txtNombreDoctor.Focus();

            // Restaurar estado de controles
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtConfirmarContrasena.Enabled = true;
            txtUsuario.BackColor = System.Drawing.Color.White;
            txtContrasena.BackColor = System.Drawing.Color.White;
            txtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            lblPaswword.Text = "Contraseña";
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            btnGuardar.Text = "Guardar";
            this.Text = "Registrar Doctor";
            idDoctorEditar = null;
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}