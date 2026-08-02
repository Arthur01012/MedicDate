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
    public partial class frmAsistente : Form
    {
        private clsAsistente asistente = new clsAsistente();// Variable para almacenar el asistente actual
        private int? idAsistenteEditar = null;// Variable para almacenar el ID del asistente a editar (si es edición)

        public frmAsistente()// Constructor para registro nuevo
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarTurnos();
            CargarEstados();
        }

        public frmAsistente(int idAsistente) : this()// Constructor para edición de asistente existente
        {
            idAsistenteEditar = idAsistente;
            CargarDatosAsistente(idAsistente);
        }

        private void ConfigurarFormulario()// Configuración inicial del formulario
        {
            dtpFechaRegistro.MaxDate = DateTime.Today.AddYears(-18); // Fecha de nacimiento: mayor de 18
        }

        private void CargarTurnos()// Cargar opciones de turno en el ComboBox
        {
            cmbTurno.Items.Clear();
            cmbTurno.Items.AddRange(new object[] { "Matutino", "Vespertino", "Nocturno" });
        }

        private void CargarEstados()// Cargar opciones de estado en el ComboBox
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0; // Activo por defecto en registro nuevo
        }

        private void CargarDatosAsistente(int idAsistente)// Cargar datos del asistente para edición
        {
            try
            {
                clsAsistente? asistenteEdit = clsAsistenteDAL.ObtenerAsistentePorId(idAsistente);
                if (asistenteEdit == null)
                {
                    MessageBox.Show("No se encontró el asistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                asistente = asistenteEdit;

                lblTituloAsistente.Text = "Editar Asistente";

                // Llenar controles
                tctNombreAsistente.Text = asistente.nombre;
                txtApePaterno.Text = asistente.apellido_paterno;
                txtApeMaterno.Text = asistente.apellido_materno;
                dtpFechaRegistro.Value = asistente.fecha_nacimiento;
                txtCurp.Text = asistente.curp;
                txtEmail.Text = asistente.email;
                txtTelefono.Text = asistente.telefono_principal;
                txtTelefonoSecundario.Text = asistente.telefono_secundario;
                cmbEstado.SelectedItem = asistente.estado ? "Activo" : "Inactivo";
                cmbTurno.Text = asistente.turno;

                // Mostrar nombre de usuario 
                txtUsuarioAsistente.Text = asistenteEdit.NombreUsuario ?? "";
                txtUsuarioAsistente.Enabled = false; // No se puede editar el usuario
                txtPassword.Enabled = false;
                txtConfirmarContrasena.Enabled = false;
                txtPassword.Text = "";
                txtConfirmarContrasena.Text = "";
                lblPassword.Text = "Contraseña (no editable)";
                lblConfirmarContrasena.Text = "Confirmar (no editable)";

                // Cambiar texto del botón
                btnGuardar.Text = "Actualizar";
                this.Text = "Editar Asistente";

                // Deshabilitar campos de usuario y contraseña
                txtUsuarioAsistente.BackColor = System.Drawing.Color.LightGray;
                txtPassword.BackColor = System.Drawing.Color.LightGray;
                txtConfirmarContrasena.BackColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)// Evento del botón Guardar
        {
            if (!ValidarDatos()) return;

            using var conexion = clsConexion.ObtenerConexion();
            using var transaccion = conexion.BeginTransaction();

            try
            {
                // Llenar objeto asistente con los datos del formulario
                asistente.nombre = tctNombreAsistente.Text.Trim();
                asistente.apellido_paterno = txtApePaterno.Text.Trim();
                asistente.apellido_materno = txtApeMaterno.Text.Trim();
                asistente.fecha_nacimiento = dtpFechaRegistro.Value;
                asistente.email = txtEmail.Text.Trim();
                asistente.curp = txtCurp.Text.Trim().ToUpper();
                asistente.telefono_secundario = txtTelefonoSecundario.Text.Trim();
                asistente.telefono_principal = txtTelefono.Text.Trim();
                asistente.estado = cmbEstado.SelectedItem?.ToString() == "Activo";
                asistente.turno = cmbTurno.Text.Trim();

                if (!idAsistenteEditar.HasValue)
                    asistente.fecha_contratacion = DateTime.Today; 

                if (idAsistenteEditar.HasValue) // MODO EDICIÓN
                {
                    asistente.id_empleado = idAsistenteEditar.Value;
                    if (!clsEmpleadoDAL.Actualizar(asistente, transaccion))
                        throw new Exception("No se pudo actualizar el empleado.");

                    if (!clsAsistenteDAL.Actualizar(asistente, transaccion))
                        throw new Exception("No se pudo actualizar el asistente.");

                    transaccion.Commit();
                    MessageBox.Show("Asistente actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else // MODO REGISTRO (nuevo)
                {
                    // Crear usuario
                    asistente.id_usuario = CrearUsuario(transaccion);
                    if (!asistente.id_usuario.HasValue)
                        throw new Exception("No se pudo crear el usuario.");

                    // Insertar empleado
                    asistente.id_empleado = clsEmpleadoDAL.Insertar(asistente, transaccion);
                    if (asistente.id_empleado == 0)
                        throw new Exception("No se pudo insertar el empleado.");

                    // Insertar asistente
                    if (!clsAsistenteDAL.Insertar(asistente, transaccion))
                        throw new Exception("No se pudo insertar el asistente.");

                    transaccion.Commit();
                    MessageBox.Show("Asistente registrado exitosamente.", "Éxito",
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
        private bool ValidarDatos()// Validación de datos del formulario
        {
            // Nombre
            if (string.IsNullOrEmpty(tctNombreAsistente.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tctNombreAsistente.Focus();
                return false;
            }

            // Apellido Paterno
            if (string.IsNullOrEmpty(txtApePaterno.Text))
            {
                MessageBox.Show("El apellido paterno es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApePaterno.Focus();
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

            if (string.IsNullOrEmpty(txtCurp.Text))
            {
                MessageBox.Show("El CURP es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurp.Focus();
                return false;
            }

            // Teléfono (opcional)
            if (!string.IsNullOrEmpty(txtTelefono.Text) && !clsValidaciones.EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtTelefonoSecundario.Text) && !clsValidaciones.EsTelefonoValido(txtTelefonoSecundario.Text))
            {
                MessageBox.Show("El teléfono secundario no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefonoSecundario.Focus();
                return false;
            }

            // Turno
            if (string.IsNullOrEmpty(cmbTurno.Text))
            {
                MessageBox.Show("Seleccione un turno.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTurno.Focus();
                return false;
            }

            // Estado
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }

            // Fecha de nacimiento (mayor de 18 años)
            if (!clsValidaciones.EsEdadValida(dtpFechaRegistro.Value, 18, 120))
            {
                MessageBox.Show("El asistente debe ser mayor de 18 años.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaRegistro.Focus();
                return false;
            }

            if (!idAsistenteEditar.HasValue) // Solo si es registro nuevo
            {
                // Usuario
                if (string.IsNullOrEmpty(txtUsuarioAsistente.Text))
                {
                    MessageBox.Show("El nombre de usuario es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuarioAsistente.Focus();
                    return false;
                }

                // Contraseña
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }
                if (txtPassword.Text != txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtConfirmarContrasena.Clear();
                    txtPassword.Focus();
                    return false;
                }
            }

            return true;
        }
        private int? CrearUsuario(MySqlTransaction? transaccion = null)// Crear usuario en la base de datos
        {
            clsUsuario usuario = new clsUsuario
            {
                usuario = txtUsuarioAsistente.Text.Trim(),
                contrasena = txtPassword.Text.Trim(),
                id_rol = (int)clsUsuario.Roles.Asistente,
                activo = true
            };

            if (clsUsuarioDAL.CrearUsuario(usuario, transaccion))
                return usuario.id_usuario;

            return null;
        }
        private void LimpiarFormulario()// Limpiar controles del formulario después de guardar
        {
            tctNombreAsistente.Clear();
            txtApePaterno.Clear();
            txtApeMaterno.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtUsuarioAsistente.Clear();
            txtPassword.Clear();
            txtConfirmarContrasena.Clear();

            dtpFechaRegistro.Value = DateTime.Today.AddYears(-25);
            cmbEstado.SelectedIndex = 0; // Activo
            cmbTurno.SelectedIndex = -1;
            tctNombreAsistente.Focus();

            // Restaurar estado de controles (por si quedó deshabilitado de una edición)
            txtUsuarioAsistente.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmarContrasena.Enabled = true;
            txtUsuarioAsistente.BackColor = System.Drawing.Color.White;
            txtPassword.BackColor = System.Drawing.Color.White;
            txtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            lblPassword.Text = "Contraseña";
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            btnGuardar.Text = "Guardar";
            this.Text = "Gestion de Asistente";
            idAsistenteEditar = null;
        }

        private void btnCancelar1_Click(object sender, EventArgs e)// Evento del botón Cancelar
        {
            this.Close();
        }
    }
}
