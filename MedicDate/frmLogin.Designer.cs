namespace MedicDate
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
            lblTitulo = new Label();
            lblPassword = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            pnlHeader1 = new Panel();
            lblIniciar = new Label();
            btnCancelar = new Button();
            btnAcceder = new Button();
            panel1.SuspendLayout();
            pnlHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(31, 59, 75);
            lblTitulo.Location = new Point(141, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar sesión";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Candara", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(96, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(125, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Candara", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(96, 151);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 28);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Candara", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(96, 182);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(322, 31);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Candara", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(96, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese su contraseña";
            txtPassword.Size = new Size(322, 31);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 186, 174);
            panel1.Controls.Add(pnlHeader1);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 72);
            panel1.TabIndex = 5;
            // 
            // pnlHeader1
            // 
            pnlHeader1.BackColor = Color.FromArgb(14, 121, 196);
            pnlHeader1.Controls.Add(lblIniciar);
            pnlHeader1.Dock = DockStyle.Top;
            pnlHeader1.Location = new Point(0, 0);
            pnlHeader1.Name = "pnlHeader1";
            pnlHeader1.Size = new Size(532, 72);
            pnlHeader1.TabIndex = 6;
            // 
            // lblIniciar
            // 
            lblIniciar.AutoSize = true;
            lblIniciar.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIniciar.ForeColor = Color.White;
            lblIniciar.Location = new Point(141, 7);
            lblIniciar.Name = "lblIniciar";
            lblIniciar.Size = new Size(269, 54);
            lblIniciar.TabIndex = 0;
            lblIniciar.Text = "Iniciar sesión";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(96, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelarGeneral_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(14, 121, 196);
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ControlLightLight;
            btnAcceder.Location = new Point(308, 318);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(110, 47);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            //btnAcceder.Click += btnAcceder_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(532, 480);
            Controls.Add(txtUsuario);
            Controls.Add(btnAcceder);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblPassword);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHeader1.ResumeLayout(false);
            pnlHeader1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPassword;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnAcceder;
        private Panel pnlHeader1;
        private Label lblIniciar;
    }
}
