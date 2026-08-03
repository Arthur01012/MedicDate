namespace MedicDate.CapaPresentacion
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblPassword = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pnlHeaderLogin = new Panel();
            lblIniciarSesion = new Label();
            btnCancelar = new Button();
            btnAcceder = new Button();
            pcbLogo = new PictureBox();
            pnlHeaderLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            //
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(117, 347);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(130, 30);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.LightGray;
            lblUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(117, 273);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 30);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(117, 302);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(322, 34);
            txtUsuario.TabIndex = 3;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(117, 376);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese su contraseña";
            txtPassword.Size = new Size(322, 34);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            //
            // pnlHeaderLogin
            // 
            pnlHeaderLogin.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderLogin.Controls.Add(lblIniciarSesion);
            pnlHeaderLogin.Dock = DockStyle.Top;
            pnlHeaderLogin.Location = new Point(0, 0);
            pnlHeaderLogin.Name = "pnlHeaderLogin";
            pnlHeaderLogin.Size = new Size(552, 72);
            pnlHeaderLogin.TabIndex = 6;
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIniciarSesion.ForeColor = Color.White;
            lblIniciarSesion.Location = new Point(167, 15);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(229, 46);
            lblIniciarSesion.TabIndex = 0;
            lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = Properties.Resources.cancelar_white;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(117, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(6, 0, 4, 0);
            btnCancelar.Size = new Size(130, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAcceder.BackColor = Color.FromArgb(14, 121, 196);
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Image = Properties.Resources.acceder_black;
            btnAcceder.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcceder.Location = new Point(309, 438);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Padding = new Padding(6, 0, 4, 0);
            btnAcceder.Size = new Size(130, 47);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.TextAlign = ContentAlignment.MiddleRight;
            btnAcceder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.LightGray;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(186, 94);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(179, 155);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 8;
            pcbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(552, 543);
            Controls.Add(pcbLogo);
            Controls.Add(txtUsuario);
            Controls.Add(btnAcceder);
            Controls.Add(btnCancelar);
            Controls.Add(pnlHeaderLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblPassword);
            ForeColor = Color.Black;
            Name = "frmLogin";
            Text = "Control de Acceso";
            pnlHeaderLogin.ResumeLayout(false);
            pnlHeaderLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnCancelar;
        private Button btnAcceder;
        private Panel pnlHeaderLogin;
        private Label lblIniciarSesion;
        private PictureBox pcbLogo;
    }
}
