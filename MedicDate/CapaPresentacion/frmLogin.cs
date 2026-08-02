using MedicDate.Datos;
using MedicDate.Procesos;
namespace MedicDate.CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // bloquea el tamaño, no se puede estirar
            this.MaximizeBox = false;                            // oculta/deshabilita el botón maximizar
            this.MinimizeBox = false;                              // opcional, normalmente se deja
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnAcceder_Click(object sender, EventArgs e)// Evento para iniciar sesión
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese su usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtPassword.Text.Trim();

                // PASO 1: Verificar si el usuario existe en la base de datos
                if (!clsUsuarioDAL.UsuarioExiste(usuario))
                {
                    MessageBox.Show("El usuario ingresado no existe en el sistema.\n\n" +
                                   "Verifique que el nombre de usuario sea correcto.",
                                   "Usuario no encontrado",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                    return;
                }
                // PASO 2: Verificar si el usuario está activo
                if (!clsUsuarioDAL.UsuarioActivo(usuario))
                {
                    MessageBox.Show("El usuario está desactivado.\n\n" +
                                   "Contacte al administrador para activar su cuenta.",
                                   "Usuario inactivo",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                    return;
                }
                // PASO 3: Intentar autenticar con las credenciales
                clsUsuario user = clsUsuarioDAL.Autenticar(usuario, contrasena);

                if (user != null)
                {
                    // Autenticación exitosa
                    Sesion.UsuarioActual = user;
                    Sesion.IdEmpleadoActual = clsUsuarioDAL.ObtenerIdEmpleadoPorIdUsuario(user.id_usuario);

                    AbrirFormularioSegunRol(user);
                }
                else
                {
                    // Contraseña incorrecta
                    MessageBox.Show("Contraseña incorrecta.\n\n" +
                                   "Por favor verifique su contraseña e intente nuevamente.",
                                   "Error de autenticación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión:\n\n{ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
        private void AbrirFormularioSegunRol(clsUsuario usuario)// Método para abrir el formulario principal según el rol del usuario
        {
            try
            {
                Form formPrincipal = null;

                switch (usuario.id_rol)
                {
                    case (int)clsUsuario.Roles.Administrador:
                        formPrincipal = new frmPrincipalAdmin();
                        
                        break;
                    case (int)clsUsuario.Roles.Asistente:
                        formPrincipal = new frmPrincipalAdmin();

                        break;
                    case (int)clsUsuario.Roles.Doctor:
                        formPrincipal = new frmPrincipalAdmin();

                        break;
                    default:
                        MessageBox.Show($"Rol no reconocido: {usuario.nombre_rol}",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                        return;
                }
                this.Hide();
                formPrincipal.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario principal:\n\n{ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)// Evento para cerrar la aplicación
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAcceder_Click(sender, e);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
    }
    public static class Sesion// Clase estática para almacenar la información de la sesión actual
    {
        public static clsUsuario UsuarioActual { get; set; }
        public static int IdEmpleadoActual { get; set; }
        public static string NombreEmpleadoActual { get; set; }
    }
}
