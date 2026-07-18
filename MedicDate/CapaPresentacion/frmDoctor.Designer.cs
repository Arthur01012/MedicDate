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
            pnlHeader4 = new Panel();
            lblTitulo = new Label();
            pnlContenedor2 = new Panel();
            txtCurp = new TextBox();
            lblCurp = new Label();
            txtTelefonoSecundario = new TextBox();
            lblTelefonoSecundario = new Label();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            txtPassword = new TextBox();
            lblPaswword = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtConsultorio = new TextBox();
            lblConsultorio = new Label();
            cmbEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            textBox1 = new TextBox();
            lblCedula = new Label();
            lblDatosLaboral = new Label();
            dtpFecha = new DateTimePicker();
            lblFechaRegistro = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAMaterno = new TextBox();
            lblAMaterno = new Label();
            txtAPaterno = new TextBox();
            lblAPaterno = new Label();
            lblNombreDoctor = new Label();
            txtNombreDoctor = new TextBox();
            lblDatosPersonales = new Label();
            chkActivo = new CheckBox();
            dtpFechaContratacion = new DateTimePicker();
            lblFechaContratacion = new Label();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            pnlHeader4.SuspendLayout();
            pnlContenedor2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader4
            // 
            pnlHeader4.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader4.Controls.Add(lblTitulo);
            pnlHeader4.Dock = DockStyle.Top;
            pnlHeader4.Location = new Point(0, 0);
            pnlHeader4.Margin = new Padding(3, 2, 3, 2);
            pnlHeader4.Name = "pnlHeader4";
            pnlHeader4.Size = new Size(851, 41);
            pnlHeader4.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(213, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Doctor";
            // 
            // pnlContenedor2
            // 
            pnlContenedor2.BackColor = Color.LightGray;
            pnlContenedor2.Controls.Add(txtConfirmarContrasena);
            pnlContenedor2.Controls.Add(lblConfirmarContrasena);
            pnlContenedor2.Controls.Add(dtpFechaContratacion);
            pnlContenedor2.Controls.Add(lblFechaContratacion);
            pnlContenedor2.Controls.Add(chkActivo);
            pnlContenedor2.Controls.Add(txtCurp);
            pnlContenedor2.Controls.Add(lblCurp);
            pnlContenedor2.Controls.Add(txtTelefonoSecundario);
            pnlContenedor2.Controls.Add(lblTelefonoSecundario);
            pnlContenedor2.Controls.Add(btnGuardar);
            pnlContenedor2.Controls.Add(btnCancelar1);
            pnlContenedor2.Controls.Add(cmbEstado);
            pnlContenedor2.Controls.Add(lblEstado);
            pnlContenedor2.Controls.Add(txtPassword);
            pnlContenedor2.Controls.Add(lblPaswword);
            pnlContenedor2.Controls.Add(txtUsuario);
            pnlContenedor2.Controls.Add(lblUsuario);
            pnlContenedor2.Controls.Add(txtConsultorio);
            pnlContenedor2.Controls.Add(lblConsultorio);
            pnlContenedor2.Controls.Add(cmbEspecialidad);
            pnlContenedor2.Controls.Add(lblEspecialidad);
            pnlContenedor2.Controls.Add(textBox1);
            pnlContenedor2.Controls.Add(lblCedula);
            pnlContenedor2.Controls.Add(lblDatosLaboral);
            pnlContenedor2.Controls.Add(dtpFecha);
            pnlContenedor2.Controls.Add(lblFechaRegistro);
            pnlContenedor2.Controls.Add(txtTelefono);
            pnlContenedor2.Controls.Add(lblTelefono);
            pnlContenedor2.Controls.Add(txtEmail);
            pnlContenedor2.Controls.Add(lblEmail);
            pnlContenedor2.Controls.Add(txtAMaterno);
            pnlContenedor2.Controls.Add(lblAMaterno);
            pnlContenedor2.Controls.Add(txtAPaterno);
            pnlContenedor2.Controls.Add(lblAPaterno);
            pnlContenedor2.Controls.Add(lblNombreDoctor);
            pnlContenedor2.Controls.Add(txtNombreDoctor);
            pnlContenedor2.Controls.Add(lblDatosPersonales);
            pnlContenedor2.Dock = DockStyle.Fill;
            pnlContenedor2.Location = new Point(0, 41);
            pnlContenedor2.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor2.Name = "pnlContenedor2";
            pnlContenedor2.Size = new Size(851, 521);
            pnlContenedor2.TabIndex = 8;
            // 
            // txtCurp
            // 
            txtCurp.Font = new Font("Segoe UI", 10.8F);
            txtCurp.Location = new Point(301, 212);
            txtCurp.Margin = new Padding(3, 2, 3, 2);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(262, 27);
            txtCurp.TabIndex = 16;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI", 10.8F);
            lblCurp.Location = new Point(301, 194);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(45, 20);
            lblCurp.TabIndex = 28;
            lblCurp.Text = "CURP";
            // 
            // txtTelefonoSecundario
            // 
            txtTelefonoSecundario.Font = new Font("Segoe UI", 10.8F);
            txtTelefonoSecundario.Location = new Point(10, 212);
            txtTelefonoSecundario.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoSecundario.Name = "txtTelefonoSecundario";
            txtTelefonoSecundario.Size = new Size(262, 27);
            txtTelefonoSecundario.TabIndex = 14;
            // 
            // lblTelefonoSecundario
            // 
            lblTelefonoSecundario.AutoSize = true;
            lblTelefonoSecundario.Font = new Font("Segoe UI", 10.8F);
            lblTelefonoSecundario.Location = new Point(10, 194);
            lblTelefonoSecundario.Name = "lblTelefonoSecundario";
            lblTelefonoSecundario.Size = new Size(145, 20);
            lblTelefonoSecundario.TabIndex = 14;
            lblTelefonoSecundario.Text = "Teléfono Secundario";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(447, 477);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 39);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar1
            // 
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Location = new Point(301, 477);
            btnCancelar1.Margin = new Padding(3, 2, 3, 2);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(114, 39);
            btnCancelar1.TabIndex = 30;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 10.8F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(301, 420);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(262, 27);
            cmbEstado.TabIndex = 28;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.8F);
            lblEstado.Location = new Point(301, 402);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.Location = new Point(10, 420);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 26;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPaswword
            // 
            lblPaswword.AutoSize = true;
            lblPaswword.Font = new Font("Segoe UI", 10.8F);
            lblPaswword.Location = new Point(10, 402);
            lblPaswword.Name = "lblPaswword";
            lblPaswword.Size = new Size(83, 20);
            lblPaswword.TabIndex = 22;
            lblPaswword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.8F);
            txtUsuario.Location = new Point(301, 368);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(262, 27);
            txtUsuario.TabIndex = 24;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F);
            lblUsuario.Location = new Point(301, 350);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 20;
            lblUsuario.Text = "Usuario";
            // 
            // txtConsultorio
            // 
            txtConsultorio.Font = new Font("Segoe UI", 10.8F);
            txtConsultorio.Location = new Point(10, 368);
            txtConsultorio.Margin = new Padding(3, 2, 3, 2);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.Size = new Size(262, 27);
            txtConsultorio.TabIndex = 22;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 10.8F);
            lblConsultorio.Location = new Point(10, 350);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(85, 20);
            lblConsultorio.TabIndex = 18;
            lblConsultorio.Text = "Consultorio";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Font = new Font("Segoe UI", 10.8F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(301, 315);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(262, 27);
            cmbEspecialidad.TabIndex = 20;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 10.8F);
            lblEspecialidad.Location = new Point(301, 297);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 16;
            lblEspecialidad.Text = "Especialidad";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(10, 315);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 18;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10.8F);
            lblCedula.Location = new Point(10, 297);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(134, 20);
            lblCedula.TabIndex = 14;
            lblCedula.Text = "Cédula profesional";
            // 
            // lblDatosLaboral
            // 
            lblDatosLaboral.AutoSize = true;
            lblDatosLaboral.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosLaboral.Location = new Point(10, 263);
            lblDatosLaboral.Name = "lblDatosLaboral";
            lblDatosLaboral.Size = new Size(127, 20);
            lblDatosLaboral.TabIndex = 17;
            lblDatosLaboral.Text = "Datos de Trabajo";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10.8F);
            dtpFecha.Location = new Point(301, 111);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(262, 27);
            dtpFecha.TabIndex = 8;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 10.8F);
            lblFechaRegistro.Location = new Point(301, 93);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(149, 20);
            lblFechaRegistro.TabIndex = 11;
            lblFechaRegistro.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.8F);
            txtTelefono.Location = new Point(301, 163);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(262, 27);
            txtTelefono.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F);
            lblTelefono.Location = new Point(301, 145);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F);
            txtEmail.Location = new Point(10, 163);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F);
            lblEmail.Location = new Point(10, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 10.8F);
            txtAMaterno.Location = new Point(10, 112);
            txtAMaterno.Margin = new Padding(3, 2, 3, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(262, 27);
            txtAMaterno.TabIndex = 6;
            // 
            // lblAMaterno
            // 
            lblAMaterno.AutoSize = true;
            lblAMaterno.Font = new Font("Segoe UI", 10.8F);
            lblAMaterno.Location = new Point(10, 95);
            lblAMaterno.Name = "lblAMaterno";
            lblAMaterno.Size = new Size(126, 20);
            lblAMaterno.TabIndex = 5;
            lblAMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 10.8F);
            txtAPaterno.Location = new Point(301, 56);
            txtAPaterno.Margin = new Padding(3, 2, 3, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(262, 27);
            txtAPaterno.TabIndex = 4;
            // 
            // lblAPaterno
            // 
            lblAPaterno.AutoSize = true;
            lblAPaterno.Font = new Font("Segoe UI", 10.8F);
            lblAPaterno.Location = new Point(301, 38);
            lblAPaterno.Name = "lblAPaterno";
            lblAPaterno.Size = new Size(120, 20);
            lblAPaterno.TabIndex = 3;
            lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Segoe UI", 10.8F);
            lblNombreDoctor.Location = new Point(10, 38);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(64, 20);
            lblNombreDoctor.TabIndex = 2;
            lblNombreDoctor.Text = "Nombre";
            // 
            // txtNombreDoctor
            // 
            txtNombreDoctor.Font = new Font("Segoe UI", 10.8F);
            txtNombreDoctor.Location = new Point(10, 56);
            txtNombreDoctor.Margin = new Padding(3, 2, 3, 2);
            txtNombreDoctor.Name = "txtNombreDoctor";
            txtNombreDoctor.Size = new Size(262, 27);
            txtNombreDoctor.TabIndex = 1;
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersonales.Location = new Point(3, 2);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(129, 20);
            lblDatosPersonales.TabIndex = 0;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 12F);
            chkActivo.Location = new Point(589, 465);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(72, 25);
            chkActivo.TabIndex = 31;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Segoe UI", 12F);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(589, 112);
            dtpFechaContratacion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(233, 29);
            dtpFechaContratacion.TabIndex = 33;
            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.AutoSize = true;
            lblFechaContratacion.Font = new Font("Segoe UI", 12F);
            lblFechaContratacion.Location = new Point(589, 83);
            lblFechaContratacion.Margin = new Padding(4, 0, 4, 0);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(143, 21);
            lblFechaContratacion.TabIndex = 32;
            lblFechaContratacion.Text = "Fecha Contratación";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Segoe UI", 12F);
            txtConfirmarContrasena.Location = new Point(10, 480);
            txtConfirmarContrasena.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(291, 29);
            txtConfirmarContrasena.TabIndex = 35;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 12F);
            lblConfirmarContrasena.Location = new Point(10, 451);
            lblConfirmarContrasena.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(164, 21);
            lblConfirmarContrasena.TabIndex = 34;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 562);
            Controls.Add(pnlContenedor2);
            Controls.Add(pnlHeader4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDoctor";
            Text = "Gestinar Doctor";
            pnlHeader4.ResumeLayout(false);
            pnlHeader4.PerformLayout();
            pnlContenedor2.ResumeLayout(false);
            pnlContenedor2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader4;
        private Label lblTitulo;
        private Panel pnlContenedor2;
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
        private Label lblAPaterno;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAMaterno;
        private Label lblAMaterno;
        private Label lblFechaRegistro;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblCedula;
        private Label lblDatosLaboral;
        private DateTimePicker dtpFecha;
        private Label lblEspecialidad;
        private TextBox textBox1;
        private Label lblPaswword;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtConsultorio;
        private Label lblConsultorio;
        private ComboBox cmbEspecialidad;
        private TextBox txtPassword;
        private Button btnGuardar;
        private Button btnCancelar1;
        private Label lblTelefonoSecundario;
        private TextBox txtCurp;
        private Label lblCurp;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private DateTimePicker dtpFechaContratacion;
        private Label lblFechaContratacion;
        private CheckBox chkActivo;
    }
}