namespace MedicDate.CapaPresentacion
{
    partial class frmHorarios
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
            pnlHeader8 = new Panel();
            lblTitulo = new Label();
            pnlContenedor6 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar5 = new Button();
            txtIntervalo = new TextBox();
            lblIntervalo = new Label();
            lblHoraFin = new Label();
            lblHoraInicio = new Label();
            chkDomingo = new CheckBox();
            chkSabado = new CheckBox();
            chkViernes = new CheckBox();
            chkJueves = new CheckBox();
            chkMiercoles = new CheckBox();
            chkMartes = new CheckBox();
            chkLunes = new CheckBox();
            lblDias = new Label();
            cmbDoctores = new ComboBox();
            lblDoctor = new Label();
            pnlHeader8.SuspendLayout();
            pnlContenedor6.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader8
            // 
            pnlHeader8.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader8.Controls.Add(lblTitulo);
            pnlHeader8.Dock = DockStyle.Top;
            pnlHeader8.Location = new Point(0, 0);
            pnlHeader8.Name = "pnlHeader8";
            pnlHeader8.Size = new Size(632, 55);
            pnlHeader8.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(240, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Horario";
            // 
            // pnlContenedor6
            // 
            pnlContenedor6.BackColor = Color.LightGray;
            pnlContenedor6.Controls.Add(dateTimePicker2);
            pnlContenedor6.Controls.Add(dateTimePicker1);
            pnlContenedor6.Controls.Add(chkActivo);
            pnlContenedor6.Controls.Add(btnGuardar);
            pnlContenedor6.Controls.Add(btnCancelar5);
            pnlContenedor6.Controls.Add(txtIntervalo);
            pnlContenedor6.Controls.Add(lblIntervalo);
            pnlContenedor6.Controls.Add(lblHoraFin);
            pnlContenedor6.Controls.Add(lblHoraInicio);
            pnlContenedor6.Controls.Add(chkDomingo);
            pnlContenedor6.Controls.Add(chkSabado);
            pnlContenedor6.Controls.Add(chkViernes);
            pnlContenedor6.Controls.Add(chkJueves);
            pnlContenedor6.Controls.Add(chkMiercoles);
            pnlContenedor6.Controls.Add(chkMartes);
            pnlContenedor6.Controls.Add(chkLunes);
            pnlContenedor6.Controls.Add(lblDias);
            pnlContenedor6.Controls.Add(cmbDoctores);
            pnlContenedor6.Controls.Add(lblDoctor);
            pnlContenedor6.Dock = DockStyle.Fill;
            pnlContenedor6.Location = new Point(0, 55);
            pnlContenedor6.Name = "pnlContenedor6";
            pnlContenedor6.Size = new Size(632, 488);
            pnlContenedor6.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "hh:mm tt";
            dateTimePicker2.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(159, 303);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(118, 31);
            dateTimePicker2.TabIndex = 118;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "hh:mm tt";
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(16, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(124, 31);
            dateTimePicker1.TabIndex = 117;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 10.8F);
            chkActivo.Location = new Point(27, 363);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(84, 29);
            chkActivo.TabIndex = 116;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(479, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 115;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar5
            // 
            btnCancelar5.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar5.FlatStyle = FlatStyle.Popup;
            btnCancelar5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar5.ForeColor = Color.White;
            btnCancelar5.Location = new Point(312, 409);
            btnCancelar5.Name = "btnCancelar5";
            btnCancelar5.Size = new Size(130, 52);
            btnCancelar5.TabIndex = 114;
            btnCancelar5.Text = "Cancelar";
            btnCancelar5.UseVisualStyleBackColor = false;
            btnCancelar5.Click += btnCancelar5_Click;
            // 
            // txtIntervalo
            // 
            txtIntervalo.Font = new Font("Segoe UI", 10.8F);
            txtIntervalo.Location = new Point(312, 303);
            txtIntervalo.Name = "txtIntervalo";
            txtIntervalo.Size = new Size(297, 31);
            txtIntervalo.TabIndex = 113;
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblIntervalo.Location = new Point(312, 279);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(142, 25);
            lblIntervalo.TabIndex = 112;
            lblIntervalo.Text = "Intervalo (Min)";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblHoraFin.Location = new Point(159, 279);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(84, 25);
            lblHoraFin.TabIndex = 109;
            lblHoraFin.Text = "Hora Fin";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblHoraInicio.Location = new Point(16, 279);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(106, 25);
            lblHoraInicio.TabIndex = 108;
            lblHoraInicio.Text = "Hora Inicio";
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Font = new Font("Segoe UI", 10.8F);
            chkDomingo.Location = new Point(312, 193);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(110, 29);
            chkDomingo.TabIndex = 107;
            chkDomingo.Text = "Domingo";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Font = new Font("Segoe UI", 10.8F);
            chkSabado.Location = new Point(171, 193);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(95, 29);
            chkSabado.TabIndex = 106;
            chkSabado.Text = "Sabado";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 10.8F);
            chkViernes.Location = new Point(27, 193);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(91, 29);
            chkViernes.TabIndex = 105;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 10.8F);
            chkJueves.Location = new Point(470, 137);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(85, 29);
            chkJueves.TabIndex = 104;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 10.8F);
            chkMiercoles.Location = new Point(312, 136);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(109, 29);
            chkMiercoles.TabIndex = 103;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 10.8F);
            chkMartes.Location = new Point(171, 136);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(88, 29);
            chkMartes.TabIndex = 102;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 10.8F);
            chkLunes.Location = new Point(27, 137);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(79, 29);
            chkLunes.TabIndex = 101;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(16, 103);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(166, 25);
            lblDias.TabIndex = 100;
            lblDias.Text = "Dias de la Semana";
            // 
            // cmbDoctores
            // 
            cmbDoctores.FlatStyle = FlatStyle.System;
            cmbDoctores.Font = new Font("Segoe UI", 10.8F);
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(16, 52);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(297, 33);
            cmbDoctores.TabIndex = 99;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(16, 25);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(70, 25);
            lblDoctor.TabIndex = 98;
            lblDoctor.Text = "Doctor";
            // 
            // frmHorarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 543);
            Controls.Add(pnlContenedor6);
            Controls.Add(pnlHeader8);
            Name = "frmHorarios";
            Text = "frmHorarios";
            pnlHeader8.ResumeLayout(false);
            pnlHeader8.PerformLayout();
            pnlContenedor6.ResumeLayout(false);
            pnlContenedor6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader8;
        private Label lblTitulo;
        private Panel pnlContenedor6;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnCancelar5;
        private TextBox txtIntervalo;
        private Label lblIntervalo;
        private Label lblHoraFin;
        private Label lblHoraInicio;
        private CheckBox chkDomingo;
        private CheckBox chkSabado;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox chkLunes;
        private Label lblDias;
        private ComboBox cmbDoctores;
        private Label lblDoctor;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}