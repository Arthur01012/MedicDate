namespace MedicDate.CapaPresentacion
{
    partial class frmPaciente
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
            pnlHeaderPaciente = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            txtNotas = new TextBox();
            txtAlergias = new TextBox();
            lblNotas = new Label();
            lblAlergias = new Label();
            lblDatosMedicos = new Label();
            cmbMunicipio = new ComboBox();
            lblMunicipio = new Label();
            txtLocalidad = new TextBox();
            lblLocalidad = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtColonia = new TextBox();
            lblColonia = new Label();
            lblDomicilio = new Label();
            txtCalle = new TextBox();
            lblSubDomicilio = new Label();
            lblSubDatosPersonales = new Label();
            dtpFechaRegistro = new DateTimePicker();
            lblFechaNac = new Label();
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
            pnlHeaderPaciente.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderPaciente
            // 
            pnlHeaderPaciente.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderPaciente.Controls.Add(lblTitulo);
            pnlHeaderPaciente.Dock = DockStyle.Top;
            pnlHeaderPaciente.ForeColor = Color.Black;
            pnlHeaderPaciente.Location = new Point(0, 0);
            pnlHeaderPaciente.Name = "pnlHeaderPaciente";
            pnlHeaderPaciente.Size = new Size(657, 55);
            pnlHeaderPaciente.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Paciente";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnCancelar1);
            pnlContenedor.Controls.Add(txtNotas);
            pnlContenedor.Controls.Add(txtAlergias);
            pnlContenedor.Controls.Add(lblNotas);
            pnlContenedor.Controls.Add(lblAlergias);
            pnlContenedor.Controls.Add(lblDatosMedicos);
            pnlContenedor.Controls.Add(cmbMunicipio);
            pnlContenedor.Controls.Add(lblMunicipio);
            pnlContenedor.Controls.Add(txtLocalidad);
            pnlContenedor.Controls.Add(lblLocalidad);
            pnlContenedor.Controls.Add(txtNumero);
            pnlContenedor.Controls.Add(lblNumero);
            pnlContenedor.Controls.Add(txtColonia);
            pnlContenedor.Controls.Add(lblColonia);
            pnlContenedor.Controls.Add(lblDomicilio);
            pnlContenedor.Controls.Add(txtCalle);
            pnlContenedor.Controls.Add(lblSubDomicilio);
            pnlContenedor.Controls.Add(lblSubDatosPersonales);
            pnlContenedor.Controls.Add(dtpFechaRegistro);
            pnlContenedor.Controls.Add(lblFechaNac);
            pnlContenedor.Controls.Add(txtTelefono);
            pnlContenedor.Controls.Add(lblTelefono);
            pnlContenedor.Controls.Add(txtEmal);
            pnlContenedor.Controls.Add(lblEmail);
            pnlContenedor.Controls.Add(txtAMaterno);
            pnlContenedor.Controls.Add(lblAMaterno);
            pnlContenedor.Controls.Add(txtAPaterno);
            pnlContenedor.Controls.Add(lblAPaterno);
            pnlContenedor.Controls.Add(lblNombreDoctor);
            pnlContenedor.Controls.Add(tctNombreDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 55);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(657, 767);
            pnlContenedor.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = MedicDate.Properties.Resources.guardar_black;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.Padding = new Padding(8, 0, 6, 0);
            btnGuardar.Location = new Point(514, 703);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 43;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar1
            // 
            btnCancelar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Image = MedicDate.Properties.Resources.cancelar_white;
            btnCancelar1.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar1.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar1.Padding = new Padding(8, 0, 6, 0);
            btnCancelar1.Location = new Point(347, 703);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(130, 52);
            btnCancelar1.TabIndex = 42;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            // 
            // txtNotas
            // 
            txtNotas.BackColor = Color.White;
            txtNotas.Font = new Font("Segoe UI", 12F);
            txtNotas.ForeColor = Color.Black;
            txtNotas.Location = new Point(346, 597);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(299, 89);
            txtNotas.TabIndex = 41;
            // 
            // txtAlergias
            // 
            txtAlergias.BackColor = Color.White;
            txtAlergias.Font = new Font("Segoe UI", 12F);
            txtAlergias.ForeColor = Color.Black;
            txtAlergias.Location = new Point(14, 597);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(299, 89);
            txtAlergias.TabIndex = 40;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Font = new Font("Segoe UI", 10.2F);
            lblNotas.ForeColor = Color.Black;
            lblNotas.Location = new Point(346, 573);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(122, 23);
            lblNotas.TabIndex = 39;
            lblNotas.Text = "Notas Medicas";
            lblNotas.Click += lblNotas_Click;
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Font = new Font("Segoe UI", 10.2F);
            lblAlergias.ForeColor = Color.Black;
            lblAlergias.Location = new Point(14, 573);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(70, 23);
            lblAlergias.TabIndex = 38;
            lblAlergias.Text = "Alergias";
            // 
            // lblDatosMedicos
            // 
            lblDatosMedicos.AutoSize = true;
            lblDatosMedicos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDatosMedicos.ForeColor = Color.Black;
            lblDatosMedicos.Location = new Point(3, 527);
            lblDatosMedicos.Name = "lblDatosMedicos";
            lblDatosMedicos.Size = new Size(166, 30);
            lblDatosMedicos.TabIndex = 37;
            lblDatosMedicos.Text = "Datos Medicos";
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.BackColor = Color.White;
            cmbMunicipio.Font = new Font("Segoe UI", 12F);
            cmbMunicipio.ForeColor = Color.Black;
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Location = new Point(14, 479);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(298, 36);
            cmbMunicipio.TabIndex = 36;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Segoe UI", 10.2F);
            lblMunicipio.ForeColor = Color.Black;
            lblMunicipio.Location = new Point(14, 456);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(89, 23);
            lblMunicipio.TabIndex = 35;
            lblMunicipio.Text = "Muinicipio";
            // 
            // txtLocalidad
            // 
            txtLocalidad.BackColor = Color.White;
            txtLocalidad.Font = new Font("Segoe UI", 12F);
            txtLocalidad.ForeColor = Color.Black;
            txtLocalidad.Location = new Point(345, 408);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(299, 34);
            txtLocalidad.TabIndex = 34;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 10.2F);
            lblLocalidad.ForeColor = Color.Black;
            lblLocalidad.Location = new Point(345, 385);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(82, 23);
            lblLocalidad.TabIndex = 33;
            lblLocalidad.Text = "Localidad";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.White;
            txtNumero.Font = new Font("Segoe UI", 12F);
            txtNumero.ForeColor = Color.Black;
            txtNumero.Location = new Point(13, 408);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(299, 34);
            txtNumero.TabIndex = 32;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10.2F);
            lblNumero.ForeColor = Color.Black;
            lblNumero.Location = new Point(13, 385);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(73, 23);
            lblNumero.TabIndex = 31;
            lblNumero.Text = "Numero";
            // 
            // txtColonia
            // 
            txtColonia.BackColor = Color.White;
            txtColonia.Font = new Font("Segoe UI", 12F);
            txtColonia.ForeColor = Color.Black;
            txtColonia.Location = new Point(345, 333);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(299, 34);
            txtColonia.TabIndex = 30;
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Font = new Font("Segoe UI", 10.2F);
            lblColonia.ForeColor = Color.Black;
            lblColonia.Location = new Point(345, 308);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(68, 23);
            lblColonia.TabIndex = 29;
            lblColonia.Text = "Colonia";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 10.2F);
            lblDomicilio.ForeColor = Color.Black;
            lblDomicilio.Location = new Point(13, 308);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(47, 23);
            lblDomicilio.TabIndex = 28;
            lblDomicilio.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.White;
            txtCalle.Font = new Font("Segoe UI", 12F);
            txtCalle.ForeColor = Color.Black;
            txtCalle.Location = new Point(13, 333);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(299, 34);
            txtCalle.TabIndex = 27;
            // 
            // lblSubDomicilio
            // 
            lblSubDomicilio.AutoSize = true;
            lblSubDomicilio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSubDomicilio.ForeColor = Color.Black;
            lblSubDomicilio.Location = new Point(3, 274);
            lblSubDomicilio.Name = "lblSubDomicilio";
            lblSubDomicilio.Size = new Size(110, 30);
            lblSubDomicilio.TabIndex = 26;
            lblSubDomicilio.Text = "Domicilio";
            // 
            // lblSubDatosPersonales
            // 
            lblSubDatosPersonales.AutoSize = true;
            lblSubDatosPersonales.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSubDatosPersonales.ForeColor = Color.Black;
            lblSubDatosPersonales.Location = new Point(3, 12);
            lblSubDatosPersonales.Name = "lblSubDatosPersonales";
            lblSubDatosPersonales.Size = new Size(189, 30);
            lblSubDatosPersonales.TabIndex = 25;
            lblSubDatosPersonales.Text = "Datos Personales";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.CalendarForeColor = Color.Black;
            dtpFechaRegistro.CalendarMonthBackground = Color.White;
            dtpFechaRegistro.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaRegistro.CalendarTitleForeColor = Color.Black;
            dtpFechaRegistro.CalendarTrailingForeColor = Color.Gray;
            dtpFechaRegistro.Font = new Font("Segoe UI", 12F);
            dtpFechaRegistro.Location = new Point(346, 221);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(299, 34);
            dtpFechaRegistro.TabIndex = 24;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 10.2F);
            lblFechaNac.ForeColor = Color.Black;
            lblFechaNac.Location = new Point(346, 197);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(147, 23);
            lblFechaNac.TabIndex = 23;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(14, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(299, 34);
            txtTelefono.TabIndex = 22;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(14, 197);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 23);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmal
            // 
            txtEmal.BackColor = Color.White;
            txtEmal.Font = new Font("Segoe UI", 12F);
            txtEmal.ForeColor = Color.Black;
            txtEmal.Location = new Point(346, 149);
            txtEmal.Name = "txtEmal";
            txtEmal.Size = new Size(299, 34);
            txtEmal.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(346, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // txtAMaterno
            // 
            txtAMaterno.BackColor = Color.White;
            txtAMaterno.Font = new Font("Segoe UI", 12F);
            txtAMaterno.ForeColor = Color.Black;
            txtAMaterno.Location = new Point(14, 149);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(299, 34);
            txtAMaterno.TabIndex = 18;
            // 
            // lblAMaterno
            // 
            lblAMaterno.AutoSize = true;
            lblAMaterno.Font = new Font("Segoe UI", 10.2F);
            lblAMaterno.ForeColor = Color.Black;
            lblAMaterno.Location = new Point(14, 124);
            lblAMaterno.Name = "lblAMaterno";
            lblAMaterno.Size = new Size(142, 23);
            lblAMaterno.TabIndex = 17;
            lblAMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.BackColor = Color.White;
            txtAPaterno.Font = new Font("Segoe UI", 12F);
            txtAPaterno.ForeColor = Color.Black;
            txtAPaterno.Location = new Point(346, 74);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(299, 34);
            txtAPaterno.TabIndex = 16;
            // 
            // lblAPaterno
            // 
            lblAPaterno.AutoSize = true;
            lblAPaterno.Font = new Font("Segoe UI", 10.2F);
            lblAPaterno.ForeColor = Color.Black;
            lblAPaterno.Location = new Point(346, 50);
            lblAPaterno.Name = "lblAPaterno";
            lblAPaterno.Size = new Size(136, 23);
            lblAPaterno.TabIndex = 15;
            lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Segoe UI", 10.2F);
            lblNombreDoctor.ForeColor = Color.Black;
            lblNombreDoctor.Location = new Point(14, 50);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(73, 23);
            lblNombreDoctor.TabIndex = 14;
            lblNombreDoctor.Text = "Nombre";
            // 
            // tctNombreDoctor
            // 
            tctNombreDoctor.BackColor = Color.White;
            tctNombreDoctor.Font = new Font("Segoe UI", 12F);
            tctNombreDoctor.ForeColor = Color.Black;
            tctNombreDoctor.Location = new Point(14, 74);
            tctNombreDoctor.Name = "tctNombreDoctor";
            tctNombreDoctor.Size = new Size(299, 34);
            tctNombreDoctor.TabIndex = 13;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 822);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderPaciente);
            Name = "frmPaciente";
            Text = "frmPaciente";
            pnlHeaderPaciente.ResumeLayout(false);
            pnlHeaderPaciente.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderPaciente;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private DateTimePicker dtpFechaRegistro;
        private Label lblFechaNac;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEmal;
        private Label lblEmail;
        private TextBox txtAMaterno;
        private Label lblAMaterno;
        private TextBox txtAPaterno;
        private Label lblAPaterno;
        private Label lblNombreDoctor;
        private TextBox tctNombreDoctor;
        private Label lblSubDatosPersonales;
        private Label lblSubDomicilio;
        private TextBox txtLocalidad;
        private Label lblLocalidad;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtColonia;
        private Label lblColonia;
        private Label lblDomicilio;
        private TextBox txtCalle;
        private Label lblMunicipio;
        private Label lblDatosMedicos;
        private ComboBox cmbMunicipio;
        private Label lblNotas;
        private Label lblAlergias;
        private TextBox txtNotas;
        private TextBox txtAlergias;
        private Button btnGuardar;
        private Button btnCancelar1;
    }
}