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
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
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
            pnlHeaderAsistente.SuspendLayout();
            pnlContenedor.SuspendLayout();
            txtTelefonoSecundario = new TextBox();
            lblTelefonoSecundario = new Label();
            txtCurp = new TextBox();
            lblCurp = new Label();
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
            lblTituloAsistente.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTituloAsistente.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAsistente.ForeColor = Color.White;
            lblTituloAsistente.Location = new Point(3, 8);
            lblTituloAsistente.Name = "lblTituloAsistente";
            lblTituloAsistente.Size = new Size(152, 41);
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
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 55);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(657, 520);
            pnlContenedor.TabIndex = 9;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.Location = new Point(15, 409);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(166, 21);
            lblConfirmarContrasena.TabIndex = 63;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarContrasena.Location = new Point(15, 433);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(299, 32);
            txtConfirmarContrasena.TabIndex = 53;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // cmbTurno
            // 
            cmbTurno.BackColor = Color.White;
            cmbTurno.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTurno.ForeColor = Color.Black;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(344, 306);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(299, 32);
            cmbTurno.TabIndex = 56;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.Black;
            lblTurno.Location = new Point(349, 344);
            lblTurno.Location = new Point(344, 282);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(52, 21);
            lblTurno.TabIndex = 56;
            lblTurno.Text = "Turno";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnCancelar1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            cmbEstado.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(15, 501);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(299, 32);
            cmbEstado.TabIndex = 58;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(17, 344);
            lblEstado.Location = new Point(15, 477);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(347, 301);
            txtPassword.Location = new Point(342, 432);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 32);
            txtPassword.TabIndex = 51;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuarioAsistente
            // 
            txtUsuarioAsistente.BackColor = Color.White;
            txtUsuarioAsistente.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioAsistente.ForeColor = Color.Black;
            txtUsuarioAsistente.Location = new Point(17, 301);
            txtUsuarioAsistente.Location = new Point(15, 365);
            txtUsuarioAsistente.Name = "txtUsuarioAsistente";
            txtUsuarioAsistente.Size = new Size(299, 32);
            txtUsuarioAsistente.TabIndex = 49;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(17, 277);
            lblUsuario.Location = new Point(15, 341);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 21);
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
            dtpFechaRegistro.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaRegistro.Location = new Point(344, 365);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(299, 32);
            dtpFechaRegistro.TabIndex = 40;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaRegistro.ForeColor = Color.Black;
            lblFechaRegistro.Location = new Point(349, 210);
            lblFechaRegistro.Location = new Point(344, 341);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(161, 21);
            lblFechaRegistro.TabIndex = 39;
            lblFechaRegistro.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(17, 234);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(299, 32);
            txtTelefono.TabIndex = 38;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(17, 210);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 21);
            lblTelefono.TabIndex = 37;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(349, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 32);
            txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(349, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 21);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.BackColor = Color.White;
            txtApeMaterno.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApeMaterno.ForeColor = Color.Black;
            txtApeMaterno.Location = new Point(17, 162);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(299, 32);
            txtApeMaterno.TabIndex = 34;
            // 
            // lblApeMaterno
            // 
            lblApeMaterno.AutoSize = true;
            lblApeMaterno.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApeMaterno.ForeColor = Color.Black;
            lblApeMaterno.Location = new Point(17, 139);
            lblApeMaterno.Name = "lblApeMaterno";
            lblApeMaterno.Size = new Size(136, 21);
            lblApeMaterno.TabIndex = 33;
            lblApeMaterno.Text = "Apellido Materno";
            // 
            // txtApePaterno
            // 
            txtApePaterno.BackColor = Color.White;
            txtApePaterno.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApePaterno.ForeColor = Color.Black;
            txtApePaterno.Location = new Point(349, 87);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(299, 32);
            txtApePaterno.TabIndex = 32;
            // 
            // lblApePaterno
            // 
            lblApePaterno.AutoSize = true;
            lblApePaterno.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApePaterno.ForeColor = Color.Black;
            lblApePaterno.Location = new Point(349, 63);
            lblApePaterno.Name = "lblApePaterno";
            lblApePaterno.Size = new Size(130, 21);
            lblApePaterno.TabIndex = 31;
            lblApePaterno.Text = "Apellido Paterno";
            // 
            // lblNombreAsistente
            // 
            lblNombreAsistente.AutoSize = true;
            lblNombreAsistente.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAsistente.ForeColor = Color.Black;
            lblNombreAsistente.Location = new Point(17, 63);
            lblNombreAsistente.Name = "lblNombreAsistente";
            lblNombreAsistente.Size = new Size(69, 21);
            lblNombreAsistente.TabIndex = 30;
            lblNombreAsistente.Text = "Nombre";
            // 
            // tctNombreAsistente
            // 
            tctNombreAsistente.BackColor = Color.White;
            tctNombreAsistente.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctNombreAsistente.ForeColor = Color.Black;
            tctNombreAsistente.Location = new Point(17, 87);
            tctNombreAsistente.Name = "tctNombreAsistente";
            tctNombreAsistente.Size = new Size(299, 32);
            tctNombreAsistente.TabIndex = 29;
            // 
            // lblDatosPersonales1
            // 
            lblDatosPersonales1.AutoSize = true;
            lblDatosPersonales1.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblDatosPersonales1.ForeColor = Color.Black;
            lblDatosPersonales1.Location = new Point(8, 15);
            lblDatosPersonales1.Name = "lblDatosPersonales1";
            lblDatosPersonales1.Size = new Size(172, 27);
            lblDatosPersonales1.TabIndex = 28;
            lblDatosPersonales1.Text = "Datos Personales";
            // 
            // txtTelefonoSecundario
            // 
            txtTelefonoSecundario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoSecundario.Location = new Point(344, 234);
            txtTelefonoSecundario.Name = "txtTelefonoSecundario";
            txtTelefonoSecundario.Size = new Size(299, 32);
            txtTelefonoSecundario.TabIndex = 65;
            // 
            // lblTelefonoSecundario
            // 
            lblTelefonoSecundario.AutoSize = true;
            lblTelefonoSecundario.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefonoSecundario.Location = new Point(344, 210);
            lblTelefonoSecundario.Name = "lblTelefonoSecundario";
            lblTelefonoSecundario.Size = new Size(75, 21);
            lblTelefonoSecundario.TabIndex = 64;
            lblTelefonoSecundario.Text = "Teléfono";
            // 
            // txtCurp
            // 
            txtCurp.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurp.Location = new Point(17, 306);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(299, 32);
            txtCurp.TabIndex = 67;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurp.Location = new Point(17, 283);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(50, 21);
            lblCurp.TabIndex = 66;
            lblCurp.Text = "CURP";
            // 
            // frmAsistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 575);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderAsistente);
            Name = "frmAsistente";
            Text = "Gestion de Asistente";
            pnlHeaderAsistente.ResumeLayout(false);
            pnlHeaderAsistente.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ClientSize = new Size(657, 715);
            Name = "frmAsistente";
            Text = "Gestion de Asistente";
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