namespace MedicDate
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

        private void btnCancelarGeneral_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txtUsuario.Text;
                login.Password = txtPassword.Text;

                bool resp = login.ValidarAcceso();

                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Cierra el login y abre el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
