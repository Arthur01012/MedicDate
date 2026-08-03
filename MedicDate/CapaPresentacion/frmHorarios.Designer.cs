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
            pnlHeaderHorario = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
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
            pnlHeaderHorario.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderHorario
            // 
            pnlHeaderHorario.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderHorario.Controls.Add(lblTitulo);
            pnlHeaderHorario.Dock = DockStyle.Top;
            pnlHeaderHorario.ForeColor = Color.Black;
            pnlHeaderHorario.Location = new Point(0, 0);
            pnlHeaderHorario.Name = "pnlHeaderHorario";
            pnlHeaderHorario.Size = new Size(632, 55);
            pnlHeaderHorario.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Horario";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(dtpFin);
            pnlContenedor.Controls.Add(dtpInicio);
            pnlContenedor.Controls.Add(chkActivo);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnCancelar5);
            pnlContenedor.Controls.Add(txtIntervalo);
            pnlContenedor.Controls.Add(lblIntervalo);
            pnlContenedor.Controls.Add(lblHoraFin);
            pnlContenedor.Controls.Add(lblHoraInicio);
            pnlContenedor.Controls.Add(chkDomingo);
            pnlContenedor.Controls.Add(chkSabado);
            pnlContenedor.Controls.Add(chkViernes);
            pnlContenedor.Controls.Add(chkJueves);
            pnlContenedor.Controls.Add(chkMiercoles);
            pnlContenedor.Controls.Add(chkMartes);
            pnlContenedor.Controls.Add(chkLunes);
            pnlContenedor.Controls.Add(lblDias);
            pnlContenedor.Controls.Add(cmbDoctores);
            pnlContenedor.Controls.Add(lblDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 55);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(632, 488);
            pnlContenedor.TabIndex = 1;
            // 
            // dtpFin
            // 
            dtpFin.CalendarForeColor = Color.Black;
            dtpFin.CalendarMonthBackground = Color.White;
            dtpFin.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFin.CalendarTitleForeColor = Color.Black;
            dtpFin.CalendarTrailingForeColor = Color.Gray;
            dtpFin.CustomFormat = "hh:mm tt";
            dtpFin.Font = new Font("Segoe UI", 12F);
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.Location = new Point(159, 303);
            dtpFin.Name = "dtpFin";
            dtpFin.RightToLeftLayout = true;
            dtpFin.ShowUpDown = true;
            dtpFin.Size = new Size(118, 34);
            dtpFin.TabIndex = 118;
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarFont = new Font("Segoe UI", 12F);
            dtpInicio.CalendarForeColor = Color.Black;
            dtpInicio.CalendarMonthBackground = Color.White;
            dtpInicio.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpInicio.CalendarTitleForeColor = Color.Black;
            dtpInicio.CalendarTrailingForeColor = Color.Gray;
            dtpInicio.CustomFormat = "hh:mm tt";
            dtpInicio.Font = new Font("Segoe UI", 12F);
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(16, 303);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(124, 34);
            dtpInicio.TabIndex = 117;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 11F);
            chkActivo.Location = new Point(27, 363);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(86, 29);
            chkActivo.TabIndex = 116;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Image = Properties.Resources.guardar_black;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(479, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(8, 0, 6, 0);
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 115;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar5
            // 
            btnCancelar5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar5.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar5.FlatStyle = FlatStyle.Popup;
            btnCancelar5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar5.ForeColor = Color.White;
            btnCancelar5.Image = Properties.Resources.cancelar_white;
            btnCancelar5.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar5.Location = new Point(312, 409);
            btnCancelar5.Name = "btnCancelar5";
            btnCancelar5.Padding = new Padding(8, 0, 6, 0);
            btnCancelar5.Size = new Size(130, 52);
            btnCancelar5.TabIndex = 114;
            btnCancelar5.Text = "Cancelar";
            btnCancelar5.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar5.UseVisualStyleBackColor = false;
            btnCancelar5.Click += btnCancelar5_Click;
            // 
            // txtIntervalo
            // 
            txtIntervalo.BackColor = Color.White;
            txtIntervalo.Font = new Font("Segoe UI", 12F);
            txtIntervalo.ForeColor = Color.Black;
            txtIntervalo.Location = new Point(312, 303);
            txtIntervalo.Name = "txtIntervalo";
            txtIntervalo.Size = new Size(297, 34);
            txtIntervalo.TabIndex = 113;
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblIntervalo.Location = new Point(312, 271);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(169, 30);
            lblIntervalo.TabIndex = 112;
            lblIntervalo.Text = "Intervalo (Min)";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHoraFin.Location = new Point(159, 272);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(100, 30);
            lblHoraFin.TabIndex = 109;
            lblHoraFin.Text = "Hora Fin";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHoraInicio.Location = new Point(16, 272);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(126, 30);
            lblHoraInicio.TabIndex = 108;
            lblHoraInicio.Text = "Hora Inicio";
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Font = new Font("Segoe UI", 11F);
            chkDomingo.ForeColor = Color.Black;
            chkDomingo.Location = new Point(312, 193);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(112, 29);
            chkDomingo.TabIndex = 107;
            chkDomingo.Text = "Domingo";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Font = new Font("Segoe UI", 11F);
            chkSabado.ForeColor = Color.Black;
            chkSabado.Location = new Point(171, 193);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(97, 29);
            chkSabado.TabIndex = 106;
            chkSabado.Text = "Sabado";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 11F);
            chkViernes.ForeColor = Color.Black;
            chkViernes.Location = new Point(27, 193);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(97, 29);
            chkViernes.TabIndex = 105;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 11F);
            chkJueves.ForeColor = Color.Black;
            chkJueves.Location = new Point(470, 137);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(89, 29);
            chkJueves.TabIndex = 104;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 11F);
            chkMiercoles.ForeColor = Color.Black;
            chkMiercoles.Location = new Point(312, 136);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(116, 29);
            chkMiercoles.TabIndex = 103;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 11F);
            chkMartes.ForeColor = Color.Black;
            chkMartes.Location = new Point(171, 136);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(92, 29);
            chkMartes.TabIndex = 102;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 11F);
            chkLunes.ForeColor = Color.Black;
            chkLunes.Location = new Point(27, 137);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(83, 29);
            chkLunes.TabIndex = 101;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDias.ForeColor = Color.Black;
            lblDias.Location = new Point(16, 103);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(200, 30);
            lblDias.TabIndex = 100;
            lblDias.Text = "Dias de la Semana";
            // 
            // cmbDoctores
            // 
            cmbDoctores.BackColor = Color.White;
            cmbDoctores.FlatStyle = FlatStyle.System;
            cmbDoctores.Font = new Font("Segoe UI", 12F);
            cmbDoctores.ForeColor = Color.Black;
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(16, 52);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(297, 36);
            cmbDoctores.TabIndex = 99;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDoctor.ForeColor = Color.Black;
            lblDoctor.Location = new Point(16, 20);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(84, 30);
            lblDoctor.TabIndex = 98;
            lblDoctor.Text = "Doctor";
            // 
            // frmHorarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(632, 543);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderHorario);
            ForeColor = Color.Black;
            Name = "frmHorarios";
            Text = "MedicDate v.1";
            pnlHeaderHorario.ResumeLayout(false);
            pnlHeaderHorario.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderHorario;
        private Panel pnlContenedor;
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
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label lblTitulo;
    }
}