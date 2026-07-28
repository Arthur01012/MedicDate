namespace MedicDate.CapaPresentacion
{
    partial class frmAsistente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeaderAsistente = new Panel();
            lblTituloAsistente = new Label();
            pnlContenedor = new Panel();
            cmbTurno = new ComboBox();
            lblTurno = new Label();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuarioAsistente = new TextBox();
            lblUsuario = new Label();
            dtpFechaRegistro = new DateTimePicker();
            lblFechaRegistro = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtApeMaterno = new TextBox();
            lblApeMaterno = new Label();
            txtApePaterno = new TextBox();
            lblApePaterno = new Label();
            lblNombreAsistente = new Label();
            tctNombreAsistente = new TextBox();
            lblDatosPersonales1 = new Label();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            txtTelefonoSecundario = new TextBox();
            lblTelefonoSecundario = new Label();
            txtCurp = new TextBox();
            lblCurp = new Label();
            pnlHeaderAsistente.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderAsistente
            // 
            pnlHeaderAsistente.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderAsistente.Controls.Add(lblTituloAsistente);
            pnlHeaderAsistente.Dock = DockStyle.Top;
            pnlHeaderAsistente.Font = new Font("Segoe UI", 9F);
            pnlHeaderAsistente.ForeColor = Color.Black;
            pnlHeaderAsistente.Location = new Point(0, 0);
            pnlHeaderAsistente.Name = "pnlHeaderAsistente";
            pnlHeaderAsistente.Size = new Size(657, 55);
            pnlHeaderAsistente.TabIndex = 8;
            // 
            // lblTituloAsistente
            // 
            lblTituloAsistente.AutoSize = true;
            lblTituloAsistente.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloAsistente.ForeColor = Color.White;
            lblTituloAsistente.Location = new Point(3, 7);
            lblTituloAsistente.Name = "lblTituloAsistente";
            lblTituloAsistente.Size = new Size(167, 46);
            lblTituloAsistente.TabIndex = 0;
            lblTituloAsistente.Text = "Asistente";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(cmbTurno);
            pnlContenedor.Controls.Add(lblTurno);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnCancelar1);
            pnlContenedor.Controls.Add(cmbEstado);
            pnlContenedor.Controls.Add(lblEstado);
            pnlContenedor.Controls.Add(txtPassword);
            pnlContenedor.Controls.Add(lblPassword);
            pnlContenedor.Controls.Add(txtUsuarioAsistente);
            pnlContenedor.Controls.Add(lblUsuario);
            pnlContenedor.Controls.Add(dtpFechaRegistro);
            pnlContenedor.Controls.Add(lblFechaRegistro);
            pnlContenedor.Controls.Add(txtTelefono);
            pnlContenedor.Controls.Add(lblTelefono);
            pnlContenedor.Controls.Add(txtEmail);
            pnlContenedor.Controls.Add(lblEmail);
            pnlContenedor.Controls.Add(txtApeMaterno);
            pnlContenedor.Controls.Add(lblApeMaterno);
            pnlContenedor.Controls.Add(txtApePaterno);
            pnlContenedor.Controls.Add(lblApePaterno);
            pnlContenedor.Controls.Add(lblNombreAsistente);
            pnlContenedor.Controls.Add(tctNombreAsistente);
            pnlContenedor.Controls.Add(lblDatosPersonales1);
            pnlContenedor.Controls.Add(lblConfirmarContrasena);
            pnlContenedor.Controls.Add(txtConfirmarContrasena);
            pnlContenedor.Controls.Add(txtTelefonoSecundario);
            pnlContenedor.Controls.Add(lblTelefonoSecundario);
            pnlContenedor.Controls.Add(txtCurp);
            pnlContenedor.Controls.Add(lblCurp);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 55);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(657, 660);
            pnlContenedor.TabIndex = 9;
            // 
            // cmbTurno
            // 
            cmbTurno.BackColor = Color.White;
            cmbTurno.Font = new Font("Segoe UI", 12F);
            cmbTurno.ForeColor = Color.Black;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(344, 306);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(299, 36);
            cmbTurno.TabIndex = 56;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 10.2F);
            lblTurno.ForeColor = Color.Black;
            lblTurno.Location = new Point(344, 282);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 23);
            lblTurno.TabIndex = 56;
            lblTurno.Text = "Turno";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(513, 583);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 62;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar1
            // 
            btnCancelar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Location = new Point(347, 583);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(130, 52);
            btnCancelar1.TabIndex = 60;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            btnCancelar1.Click += btnCancelar1_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.Font = new Font("Segoe UI", 12F);
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(15, 510);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(299, 36);
            cmbEstado.TabIndex = 58;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.2F);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(15, 486);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(61, 23);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(342, 439);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 34);
            txtPassword.TabIndex = 51;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(342, 416);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 23);
            lblPassword.TabIndex = 50;
            lblPassword.Text = "Contraseña";
            // 
            // txtUsuarioAsistente
            // 
            txtUsuarioAsistente.BackColor = Color.White;
            txtUsuarioAsistente.Font = new Font("Segoe UI", 12F);
            txtUsuarioAsistente.ForeColor = Color.Black;
            txtUsuarioAsistente.Location = new Point(15, 371);
            txtUsuarioAsistente.Name = "txtUsuarioAsistente";
            txtUsuarioAsistente.Size = new Size(299, 34);
            txtUsuarioAsistente.TabIndex = 49;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(15, 347);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 48;
            lblUsuario.Text = "Usuario";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.CalendarForeColor = Color.Black;
            dtpFechaRegistro.CalendarMonthBackground = Color.White;
            dtpFechaRegistro.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaRegistro.CalendarTitleForeColor = Color.Black;
            dtpFechaRegistro.CalendarTrailingForeColor = Color.Gray;
            dtpFechaRegistro.Font = new Font("Segoe UI", 12F);
            dtpFechaRegistro.Location = new Point(344, 374);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(299, 34);
            dtpFechaRegistro.TabIndex = 40;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 10.2F);
            lblFechaRegistro.ForeColor = Color.Black;
            lblFechaRegistro.Location = new Point(344, 350);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(171, 23);
            lblFechaRegistro.TabIndex = 39;
            lblFechaRegistro.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(17, 234);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(299, 34);
            txtTelefono.TabIndex = 38;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(17, 210);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 23);
            lblTelefono.TabIndex = 37;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(349, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 34);
            txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(349, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.BackColor = Color.White;
            txtApeMaterno.Font = new Font("Segoe UI", 12F);
            txtApeMaterno.ForeColor = Color.Black;
            txtApeMaterno.Location = new Point(17, 162);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(299, 34);
            txtApeMaterno.TabIndex = 34;
            // 
            // lblApeMaterno
            // 
            lblApeMaterno.AutoSize = true;
            lblApeMaterno.Font = new Font("Segoe UI", 10.2F);
            lblApeMaterno.ForeColor = Color.Black;
            lblApeMaterno.Location = new Point(17, 139);
            lblApeMaterno.Name = "lblApeMaterno";
            lblApeMaterno.Size = new Size(142, 23);
            lblApeMaterno.TabIndex = 33;
            lblApeMaterno.Text = "Apellido Materno";
            // 
            // txtApePaterno
            // 
            txtApePaterno.BackColor = Color.White;
            txtApePaterno.Font = new Font("Segoe UI", 12F);
            txtApePaterno.ForeColor = Color.Black;
            txtApePaterno.Location = new Point(349, 87);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(299, 34);
            txtApePaterno.TabIndex = 32;
            // 
            // lblApePaterno
            // 
            lblApePaterno.AutoSize = true;
            lblApePaterno.Font = new Font("Segoe UI", 10.2F);
            lblApePaterno.ForeColor = Color.Black;
            lblApePaterno.Location = new Point(349, 63);
            lblApePaterno.Name = "lblApePaterno";
            lblApePaterno.Size = new Size(136, 23);
            lblApePaterno.TabIndex = 31;
            lblApePaterno.Text = "Apellido Paterno";
            // 
            // lblNombreAsistente
            // 
            lblNombreAsistente.AutoSize = true;
            lblNombreAsistente.Font = new Font("Segoe UI", 10.2F);
            lblNombreAsistente.ForeColor = Color.Black;
            lblNombreAsistente.Location = new Point(17, 63);
            lblNombreAsistente.Name = "lblNombreAsistente";
            lblNombreAsistente.Size = new Size(73, 23);
            lblNombreAsistente.TabIndex = 30;
            lblNombreAsistente.Text = "Nombre";
            // 
            // tctNombreAsistente
            // 
            tctNombreAsistente.BackColor = Color.White;
            tctNombreAsistente.Font = new Font("Segoe UI", 12F);
            tctNombreAsistente.ForeColor = Color.Black;
            tctNombreAsistente.Location = new Point(17, 87);
            tctNombreAsistente.Name = "tctNombreAsistente";
            tctNombreAsistente.Size = new Size(299, 34);
            tctNombreAsistente.TabIndex = 29;
            // 
            // lblDatosPersonales1
            // 
            lblDatosPersonales1.AutoSize = true;
            lblDatosPersonales1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDatosPersonales1.ForeColor = Color.Black;
            lblDatosPersonales1.Location = new Point(8, 15);
            lblDatosPersonales1.Name = "lblDatosPersonales1";
            lblDatosPersonales1.Size = new Size(189, 30);
            lblDatosPersonales1.TabIndex = 28;
            lblDatosPersonales1.Text = "Datos Personales";
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.2F);
            lblConfirmarContrasena.Location = new Point(15, 415);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(178, 23);
            lblConfirmarContrasena.TabIndex = 63;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Segoe UI", 12F);
            txtConfirmarContrasena.ForeColor = Color.Black;
            txtConfirmarContrasena.Location = new Point(15, 439);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(299, 34);
            txtConfirmarContrasena.TabIndex = 53;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // txtTelefonoSecundario
            // 
            txtTelefonoSecundario.Font = new Font("Segoe UI", 12F);
            txtTelefonoSecundario.ForeColor = Color.Black;
            txtTelefonoSecundario.Location = new Point(344, 234);
            txtTelefonoSecundario.Name = "txtTelefonoSecundario";
            txtTelefonoSecundario.Size = new Size(299, 34);
            txtTelefonoSecundario.TabIndex = 65;
            // 
            // lblTelefonoSecundario
            // 
            lblTelefonoSecundario.AutoSize = true;
            lblTelefonoSecundario.Font = new Font("Segoe UI", 10.2F);
            lblTelefonoSecundario.Location = new Point(344, 210);
            lblTelefonoSecundario.Name = "lblTelefonoSecundario";
            lblTelefonoSecundario.Size = new Size(74, 23);
            lblTelefonoSecundario.TabIndex = 64;
            lblTelefonoSecundario.Text = "Teléfono";
            // 
            // txtCurp
            // 
            txtCurp.Font = new Font("Segoe UI", 12F);
            txtCurp.ForeColor = Color.Black;
            txtCurp.Location = new Point(17, 306);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(299, 34);
            txtCurp.TabIndex = 67;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI", 10.2F);
            lblCurp.Location = new Point(17, 283);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(53, 23);
            lblCurp.TabIndex = 66;
            lblCurp.Text = "CURP";
            // 
            // frmAsistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 715);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderAsistente);
            Name = "frmAsistente";
            Text = "Gestion de Asistente";
            pnlHeaderAsistente.ResumeLayout(false);
            pnlHeaderAsistente.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderAsistente;
        private Label lblTituloAsistente;
        private Panel pnlContenedor;
        private ComboBox cmbTurno;
        private Label lblTurno;
        private Button btnGuardar;
        private Button btnCancelar1;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsuarioAsistente;
        private Label lblUsuario;
        private DateTimePicker dtpFechaRegistro;
        private Label lblFechaRegistro;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtApeMaterno;
        private Label lblApeMaterno;
        private TextBox txtApePaterno;
        private Label lblApePaterno;
        private Label lblNombreAsistente;
        private TextBox tctNombreAsistente;
        private Label lblDatosPersonales1;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private TextBox txtCurp;
        private Label lblCurp;
        private TextBox txtTelefonoSecundario;
        private Label lblTelefonoSecundario;
    }
}