namespace MedicDate
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
            dtpFechaRegistro = new DateTimePicker();
            lblFechaRegistro = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmal = new TextBox();
            lblEmail = new Label();
            txtAMaterno = new TextBox();
            lblAMaterno = new Label();
            txtAPaterno = new TextBox();
            lblAPaterno = new Label();
            lblNombreDoctor = new Label();
            tctNombreDoctor = new TextBox();
            lblDatosPersonales = new Label();
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
            pnlHeader4.Name = "pnlHeader4";
            pnlHeader4.Size = new Size(657, 55);
            pnlHeader4.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(256, -2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Doctor";
            // 
            // pnlContenedor2
            // 
            pnlContenedor2.BackColor = Color.LightGray;
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
            pnlContenedor2.Controls.Add(dtpFechaRegistro);
            pnlContenedor2.Controls.Add(lblFechaRegistro);
            pnlContenedor2.Controls.Add(txtTelefono);
            pnlContenedor2.Controls.Add(lblTelefono);
            pnlContenedor2.Controls.Add(txtEmal);
            pnlContenedor2.Controls.Add(lblEmail);
            pnlContenedor2.Controls.Add(txtAMaterno);
            pnlContenedor2.Controls.Add(lblAMaterno);
            pnlContenedor2.Controls.Add(txtAPaterno);
            pnlContenedor2.Controls.Add(lblAPaterno);
            pnlContenedor2.Controls.Add(lblNombreDoctor);
            pnlContenedor2.Controls.Add(tctNombreDoctor);
            pnlContenedor2.Controls.Add(lblDatosPersonales);
            pnlContenedor2.Dock = DockStyle.Fill;
            pnlContenedor2.Location = new Point(0, 55);
            pnlContenedor2.Name = "pnlContenedor2";
            pnlContenedor2.Size = new Size(657, 643);
            pnlContenedor2.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(511, 564);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar1
            // 
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Location = new Point(344, 564);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(130, 52);
            btnCancelar1.TabIndex = 26;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            btnCancelar1.Click += btnCancelarGeneral_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 10.8F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(344, 488);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(299, 33);
            cmbEstado.TabIndex = 25;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.8F);
            lblEstado.Location = new Point(344, 464);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.Location = new Point(12, 488);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 31);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPaswword
            // 
            lblPaswword.AutoSize = true;
            lblPaswword.Font = new Font("Segoe UI", 10.8F);
            lblPaswword.Location = new Point(12, 464);
            lblPaswword.Name = "lblPaswword";
            lblPaswword.Size = new Size(101, 25);
            lblPaswword.TabIndex = 22;
            lblPaswword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.8F);
            txtUsuario.Location = new Point(344, 419);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 31);
            txtUsuario.TabIndex = 21;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F);
            lblUsuario.Location = new Point(344, 395);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 20;
            lblUsuario.Text = "Usuario";
            // 
            // txtConsultorio
            // 
            txtConsultorio.Font = new Font("Segoe UI", 10.8F);
            txtConsultorio.Location = new Point(12, 419);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.Size = new Size(299, 31);
            txtConsultorio.TabIndex = 19;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 10.8F);
            lblConsultorio.Location = new Point(12, 395);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(104, 25);
            lblConsultorio.TabIndex = 18;
            lblConsultorio.Text = "Consultorio";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Font = new Font("Segoe UI", 10.8F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(344, 348);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(299, 33);
            cmbEspecialidad.TabIndex = 17;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 10.8F);
            lblEspecialidad.Location = new Point(344, 324);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(109, 25);
            lblEspecialidad.TabIndex = 16;
            lblEspecialidad.Text = "Especialidad";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(12, 348);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 31);
            textBox1.TabIndex = 15;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10.8F);
            lblCedula.Location = new Point(12, 324);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(160, 25);
            lblCedula.TabIndex = 14;
            lblCedula.Text = "Cédula profesional";
            // 
            // lblDatosLaboral
            // 
            lblDatosLaboral.AutoSize = true;
            lblDatosLaboral.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosLaboral.Location = new Point(12, 279);
            lblDatosLaboral.Name = "lblDatosLaboral";
            lblDatosLaboral.Size = new Size(156, 25);
            lblDatosLaboral.TabIndex = 13;
            lblDatosLaboral.Text = "Datos de Trabajo";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 10.8F);
            dtpFechaRegistro.Location = new Point(344, 222);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(299, 31);
            dtpFechaRegistro.TabIndex = 12;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 10.8F);
            lblFechaRegistro.Location = new Point(344, 198);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(57, 25);
            lblFechaRegistro.TabIndex = 11;
            lblFechaRegistro.Text = "Fecha";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.8F);
            txtTelefono.Location = new Point(12, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(299, 31);
            txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F);
            lblTelefono.Location = new Point(12, 198);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmal
            // 
            txtEmal.Font = new Font("Segoe UI", 10.8F);
            txtEmal.Location = new Point(344, 150);
            txtEmal.Name = "txtEmal";
            txtEmal.Size = new Size(299, 31);
            txtEmal.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F);
            lblEmail.Location = new Point(344, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 10.8F);
            txtAMaterno.Location = new Point(12, 150);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(299, 31);
            txtAMaterno.TabIndex = 6;
            // 
            // lblAMaterno
            // 
            lblAMaterno.AutoSize = true;
            lblAMaterno.Font = new Font("Segoe UI", 10.8F);
            lblAMaterno.Location = new Point(12, 127);
            lblAMaterno.Name = "lblAMaterno";
            lblAMaterno.Size = new Size(150, 25);
            lblAMaterno.TabIndex = 5;
            lblAMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 10.8F);
            txtAPaterno.Location = new Point(344, 75);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(299, 31);
            txtAPaterno.TabIndex = 4;
            // 
            // lblAPaterno
            // 
            lblAPaterno.AutoSize = true;
            lblAPaterno.Font = new Font("Segoe UI", 10.8F);
            lblAPaterno.Location = new Point(344, 51);
            lblAPaterno.Name = "lblAPaterno";
            lblAPaterno.Size = new Size(143, 25);
            lblAPaterno.TabIndex = 3;
            lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Segoe UI", 10.8F);
            lblNombreDoctor.Location = new Point(12, 51);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(78, 25);
            lblNombreDoctor.TabIndex = 2;
            lblNombreDoctor.Text = "Nombre";
            // 
            // tctNombreDoctor
            // 
            tctNombreDoctor.Font = new Font("Segoe UI", 10.8F);
            tctNombreDoctor.Location = new Point(12, 75);
            tctNombreDoctor.Name = "tctNombreDoctor";
            tctNombreDoctor.Size = new Size(299, 31);
            tctNombreDoctor.TabIndex = 1;
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersonales.Location = new Point(3, 3);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(156, 25);
            lblDatosPersonales.TabIndex = 0;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 698);
            Controls.Add(pnlContenedor2);
            Controls.Add(pnlHeader4);
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
        private TextBox textBox2;
        private TextBox tctNombreDoctor;
        private Label lblNombreDoctor;
        private TextBox txtAPaterno;
        private Label lblAPaterno;
        private TextBox txtEmal;
        private Label lblEmail;
        private TextBox txtAMaterno;
        private Label lblAMaterno;
        private Label lblFechaRegistro;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblCedula;
        private Label lblDatosLaboral;
        private DateTimePicker dtpFechaRegistro;
        private Label lblEspecialidad;
        private TextBox textBox1;
        private Label lblPaswword;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtConsultorio;
        private Label lblConsultorio;
        private ComboBox cmbEspecialidad;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private TextBox txtPassword;
        private Button btnGuardar;
        private Button btnCancelar1;
    }
}