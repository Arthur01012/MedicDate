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
    
    }
}
