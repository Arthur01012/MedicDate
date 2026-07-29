namespace MedicDate.CapaPresentacion
{
    partial class frmDoctor
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
            pnlHeaderDoctor = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            dtpFechaContratacion = new DateTimePicker();
            lblFechaContratacion = new Label();
            chkActivo = new CheckBox();
            txtCurp = new TextBox();
            lblCurp = new Label();
            txtTelefonoSecundario = new TextBox();
            lblTelefonoSecundario = new Label();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            txtContraseña = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtConsultorio = new TextBox();
            lblConsultorio = new Label();
            cmbEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            lblDatosLaboral = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaRegistro = new Label();
            txtTelefonoPrimario = new TextBox();
            lblTelefonoPrimario = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAMaterno = new TextBox();
            lblApeMaterno = new Label();
            txtAPaterno = new TextBox();
            lblApePaterno = new Label();
            lblNombreDoctor = new Label();
            txtNombreDoctor = new TextBox();
            lblDatosPersonales = new Label();
            pnlHeaderDoctor.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderDoctor
            // 
            pnlHeaderDoctor.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderDoctor.Controls.Add(lblTitulo);
            pnlHeaderDoctor.Dock = DockStyle.Top;
            pnlHeaderDoctor.ForeColor = Color.Black;
            pnlHeaderDoctor.Location = new Point(0, 0);
            pnlHeaderDoctor.Margin = new Padding(3, 2, 3, 2);
            pnlHeaderDoctor.Name = "pnlHeaderDoctor";
            pnlHeaderDoctor.Size = new Size(573, 41);
            pnlHeaderDoctor.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Doctor";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(txtConfirmarContrasena);
            pnlContenedor.Controls.Add(lblConfirmarContrasena);
            pnlContenedor.Controls.Add(dtpFechaContratacion);
            pnlContenedor.Controls.Add(lblFechaContratacion);
            pnlContenedor.Controls.Add(chkActivo);
            pnlContenedor.Controls.Add(txtCurp);
            pnlContenedor.Controls.Add(lblCurp);
            pnlContenedor.Controls.Add(txtTelefonoSecundario);
            pnlContenedor.Controls.Add(lblTelefonoSecundario);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnCancelar1);
            pnlContenedor.Controls.Add(txtContraseña);
            pnlContenedor.Controls.Add(lblPassword);
            pnlContenedor.Controls.Add(txtUsuario);
            pnlContenedor.Controls.Add(lblUsuario);
            pnlContenedor.Controls.Add(txtConsultorio);
            pnlContenedor.Controls.Add(lblConsultorio);
            pnlContenedor.Controls.Add(cmbEspecialidad);
            pnlContenedor.Controls.Add(lblEspecialidad);
            pnlContenedor.Controls.Add(txtCedula);
            pnlContenedor.Controls.Add(lblCedula);
            pnlContenedor.Controls.Add(lblDatosLaboral);
            pnlContenedor.Controls.Add(dtpFechaNacimiento);
            pnlContenedor.Controls.Add(lblFechaRegistro);
            pnlContenedor.Controls.Add(txtTelefonoPrimario);
            pnlContenedor.Controls.Add(lblTelefonoPrimario);
            pnlContenedor.Controls.Add(txtEmail);
            pnlContenedor.Controls.Add(lblEmail);
            pnlContenedor.Controls.Add(txtAMaterno);
            pnlContenedor.Controls.Add(lblApeMaterno);
            pnlContenedor.Controls.Add(txtAPaterno);
            pnlContenedor.Controls.Add(lblApePaterno);
            pnlContenedor.Controls.Add(lblNombreDoctor);
            pnlContenedor.Controls.Add(txtNombreDoctor);
            pnlContenedor.Controls.Add(lblDatosPersonales);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 41);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(573, 567);
            pnlContenedor.TabIndex = 8;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BackColor = Color.White;
            txtConfirmarContrasena.Font = new Font("Segoe UI", 12F);
            txtConfirmarContrasena.ForeColor = Color.Black;
            txtConfirmarContrasena.Location = new Point(301, 416);
            txtConfirmarContrasena.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(262, 29);
            txtConfirmarContrasena.TabIndex = 35;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 10.2F);
            lblConfirmarContrasena.Location = new Point(301, 397);
            lblConfirmarContrasena.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(144, 19);
            lblConfirmarContrasena.TabIndex = 34;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.CalendarForeColor = Color.Black;
            dtpFechaContratacion.CalendarMonthBackground = Color.White;
            dtpFechaContratacion.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaContratacion.CalendarTitleForeColor = Color.Black;
            dtpFechaContratacion.CalendarTrailingForeColor = Color.Gray;
            dtpFechaContratacion.Font = new Font("Segoe UI", 12F);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(10, 465);
            dtpFechaContratacion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(262, 29);
            dtpFechaContratacion.TabIndex = 33;
            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.AutoSize = true;
            lblFechaContratacion.Font = new Font("Segoe UI", 10.2F);
            lblFechaContratacion.Location = new Point(10, 448);
            lblFechaContratacion.Margin = new Padding(4, 0, 4, 0);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(127, 19);
            lblFechaContratacion.TabIndex = 32;
            lblFechaContratacion.Text = "Fecha Contratación";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 11F);
            chkActivo.Location = new Point(301, 471);
            chkActivo.Margin = new Padding(4, 2, 4, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(70, 24);
            chkActivo.TabIndex = 31;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtCurp
            // 
            txtCurp.BackColor = Color.White;
            txtCurp.Font = new Font("Segoe UI", 12F);
            txtCurp.ForeColor = Color.Black;
            txtCurp.Location = new Point(301, 212);
            txtCurp.Margin = new Padding(3, 2, 3, 2);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(262, 29);
            txtCurp.TabIndex = 16;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI", 10.2F);
            lblCurp.Location = new Point(301, 194);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(44, 19);
            lblCurp.TabIndex = 28;
            lblCurp.Text = "CURP";
            // 
            // txtTelefonoSecundario
            // 
            txtTelefonoSecundario.BackColor = Color.White;
            txtTelefonoSecundario.Font = new Font("Segoe UI", 12F);
            txtTelefonoSecundario.ForeColor = Color.Black;
            txtTelefonoSecundario.Location = new Point(10, 212);
            txtTelefonoSecundario.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoSecundario.Name = "txtTelefonoSecundario";
            txtTelefonoSecundario.Size = new Size(262, 29);
            txtTelefonoSecundario.TabIndex = 14;
            // 
            // lblTelefonoSecundario
            // 
            lblTelefonoSecundario.AutoSize = true;
            lblTelefonoSecundario.Font = new Font("Segoe UI", 10.2F);
            lblTelefonoSecundario.Location = new Point(10, 194);
            lblTelefonoSecundario.Name = "lblTelefonoSecundario";
            lblTelefonoSecundario.Size = new Size(131, 19);
            lblTelefonoSecundario.TabIndex = 14;
            lblTelefonoSecundario.Text = "Teléfono Secundario";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(449, 518);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 39);
            btnGuardar.TabIndex = 29;
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
            btnCancelar1.Location = new Point(301, 518);
            btnCancelar1.Margin = new Padding(3, 2, 3, 2);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(114, 39);
            btnCancelar1.TabIndex = 30;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            btnCancelar1.Click += btnCancelar1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(301, 364);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(262, 29);
            txtContraseña.TabIndex = 36;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F);
            lblPassword.Location = new Point(301, 346);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 19);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(301, 315);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(262, 29);
            txtUsuario.TabIndex = 24;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F);
            lblUsuario.Location = new Point(301, 297);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 20;
            lblUsuario.Text = "Usuario";
            // 
            // txtConsultorio
            // 
            txtConsultorio.BackColor = Color.White;
            txtConsultorio.Font = new Font("Segoe UI", 12F);
            txtConsultorio.ForeColor = Color.Black;
            txtConsultorio.Location = new Point(10, 364);
            txtConsultorio.Margin = new Padding(3, 2, 3, 2);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.Size = new Size(262, 29);
            txtConsultorio.TabIndex = 22;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 10.2F);
            lblConsultorio.Location = new Point(10, 346);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(80, 19);
            lblConsultorio.TabIndex = 18;
            lblConsultorio.Text = "Consultorio";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.BackColor = Color.White;
            cmbEspecialidad.Font = new Font("Segoe UI", 12F);
            cmbEspecialidad.ForeColor = Color.Black;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(10, 416);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(262, 29);
            cmbEspecialidad.TabIndex = 20;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 10.2F);
            lblEspecialidad.Location = new Point(10, 397);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(82, 19);
            lblEspecialidad.TabIndex = 16;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.White;
            txtCedula.Font = new Font("Segoe UI", 12F);
            txtCedula.ForeColor = Color.Black;
            txtCedula.Location = new Point(10, 315);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(262, 29);
            txtCedula.TabIndex = 18;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10.2F);
            lblCedula.Location = new Point(10, 297);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(122, 19);
            lblCedula.TabIndex = 14;
            lblCedula.Text = "Cédula profesional";
            // 
            // lblDatosLaboral
            // 
            lblDatosLaboral.AutoSize = true;
            lblDatosLaboral.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDatosLaboral.Location = new Point(10, 272);
            lblDatosLaboral.Name = "lblDatosLaboral";
            lblDatosLaboral.Size = new Size(156, 25);
            lblDatosLaboral.TabIndex = 17;
            lblDatosLaboral.Text = "Datos de Trabajo";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarFont = new Font("Candara", 12F);
            dtpFechaNacimiento.CalendarForeColor = Color.Black;
            dtpFechaNacimiento.CalendarMonthBackground = Color.White;
            dtpFechaNacimiento.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaNacimiento.CalendarTitleForeColor = Color.Black;
            dtpFechaNacimiento.CalendarTrailingForeColor = Color.Gray;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(301, 111);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(262, 29);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 10.2F);
            lblFechaRegistro.Location = new Point(301, 94);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(136, 19);
            lblFechaRegistro.TabIndex = 11;
            lblFechaRegistro.Text = "Fecha de Nacimiento";
            // 
            // txtTelefonoPrimario
            // 
            txtTelefonoPrimario.BackColor = Color.White;
            txtTelefonoPrimario.Font = new Font("Segoe UI", 12F);
            txtTelefonoPrimario.ForeColor = Color.Black;
            txtTelefonoPrimario.Location = new Point(301, 163);
            txtTelefonoPrimario.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoPrimario.Name = "txtTelefonoPrimario";
            txtTelefonoPrimario.Size = new Size(262, 29);
            txtTelefonoPrimario.TabIndex = 12;
            // 
            // lblTelefonoPrimario
            // 
            lblTelefonoPrimario.AutoSize = true;
            lblTelefonoPrimario.Font = new Font("Segoe UI", 10.2F);
            lblTelefonoPrimario.Location = new Point(301, 145);
            lblTelefonoPrimario.Name = "lblTelefonoPrimario";
            lblTelefonoPrimario.Size = new Size(115, 19);
            lblTelefonoPrimario.TabIndex = 9;
            lblTelefonoPrimario.Text = "Teléfono primario";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(10, 163);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 29);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F);
            lblEmail.Location = new Point(10, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtAMaterno
            // 
            txtAMaterno.BackColor = Color.White;
            txtAMaterno.Font = new Font("Segoe UI", 12F);
            txtAMaterno.ForeColor = Color.Black;
            txtAMaterno.Location = new Point(10, 112);
            txtAMaterno.Margin = new Padding(3, 2, 3, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(262, 29);
            txtAMaterno.TabIndex = 6;
            // 
            // lblApeMaterno
            // 
            lblApeMaterno.AutoSize = true;
            lblApeMaterno.Font = new Font("Segoe UI", 10.2F);
            lblApeMaterno.Location = new Point(10, 94);
            lblApeMaterno.Name = "lblApeMaterno";
            lblApeMaterno.Size = new Size(115, 19);
            lblApeMaterno.TabIndex = 5;
            lblApeMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.BackColor = Color.White;
            txtAPaterno.Font = new Font("Segoe UI", 12F);
            txtAPaterno.ForeColor = Color.Black;
            txtAPaterno.Location = new Point(301, 56);
            txtAPaterno.Margin = new Padding(3, 2, 3, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(262, 29);
            txtAPaterno.TabIndex = 4;
            // 
            // lblApePaterno
            // 
            lblApePaterno.AutoSize = true;
            lblApePaterno.Font = new Font("Segoe UI", 10.2F);
            lblApePaterno.Location = new Point(301, 38);
            lblApePaterno.Name = "lblApePaterno";
            lblApePaterno.Size = new Size(110, 19);
            lblApePaterno.TabIndex = 3;
            lblApePaterno.Text = "Apellido Paterno";
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Segoe UI", 10.2F);
            lblNombreDoctor.Location = new Point(10, 38);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(59, 19);
            lblNombreDoctor.TabIndex = 2;
            lblNombreDoctor.Text = "Nombre";
            // 
            // txtNombreDoctor
            // 
            txtNombreDoctor.BackColor = Color.White;
            txtNombreDoctor.Font = new Font("Segoe UI", 12F);
            txtNombreDoctor.ForeColor = Color.Black;
            txtNombreDoctor.Location = new Point(10, 56);
            txtNombreDoctor.Margin = new Padding(3, 2, 3, 2);
            txtNombreDoctor.Name = "txtNombreDoctor";
            txtNombreDoctor.Size = new Size(262, 29);
            txtNombreDoctor.TabIndex = 1;
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDatosPersonales.ForeColor = Color.Black;
            lblDatosPersonales.Location = new Point(3, 10);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(156, 25);
            lblDatosPersonales.TabIndex = 0;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 608);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderDoctor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDoctor";
            Text = "Gestinar Doctor";
            pnlHeaderDoctor.ResumeLayout(false);
            pnlHeaderDoctor.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderDoctor;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Label lblDatosPersonales;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtTelefonoSecundario;
        private TextBox txtNombreDoctor;
        private Label lblNombreDoctor;
        private TextBox txtAPaterno;
        private Label lblApePaterno;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAMaterno;
        private Label lblApeMaterno;
        private Label lblFechaRegistro;
        private TextBox txtTelefonoPrimario;
        private Label lblTelefonoPrimario;
        private Label lblCedula;
        private Label lblDatosLaboral;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblEspecialidad;
        private TextBox txtCedula;
        private Label lblPassword;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtConsultorio;
        private Label lblConsultorio;
        private ComboBox cmbEspecialidad;
        private TextBox txtContraseña;
        private Button btnGuardar;
        private Button btnCancelar1;
        private Label lblTelefonoSecundario;
        private TextBox txtCurp;
        private Label lblCurp;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private DateTimePicker dtpFechaContratacion;
        private Label lblFechaContratacion;
        private CheckBox chkActivo;
    }
}