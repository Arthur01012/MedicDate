namespace MedicDate.CapaPresentacion
{
    partial class frmCita
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
            pnlHeader15 = new Panel();
            lblCitas = new Label();
            panel1 = new Panel();
            dtpHoraCita = new DateTimePicker();
            lblHoraCita = new Label();
            dtpFechaCita = new DateTimePicker();
            lblFechaCita = new Label();
            cmbDoctor = new ComboBox();
            lblNombreDoctor = new Label();
            lblNombrePaciente = new Label();
            tctNombrePaciente = new TextBox();
            lblCosto = new Label();
            txtcosto = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            pnlHeader15.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader15
            // 
            pnlHeader15.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader15.Controls.Add(lblCitas);
            pnlHeader15.Dock = DockStyle.Top;
            pnlHeader15.Location = new Point(0, 0);
            pnlHeader15.Name = "pnlHeader15";
            pnlHeader15.Size = new Size(641, 55);
            pnlHeader15.TabIndex = 9;
            // 
            // lblCitas
            // 
            lblCitas.AutoSize = true;
            lblCitas.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCitas.ForeColor = Color.White;
            lblCitas.Location = new Point(259, 0);
            lblCitas.Name = "lblCitas";
            lblCitas.Size = new Size(114, 54);
            lblCitas.TabIndex = 0;
            lblCitas.Text = "Citas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar1);
            panel1.Controls.Add(lblMotivo);
            panel1.Controls.Add(txtMotivo);
            panel1.Controls.Add(lblCosto);
            panel1.Controls.Add(txtcosto);
            panel1.Controls.Add(dtpHoraCita);
            panel1.Controls.Add(lblHoraCita);
            panel1.Controls.Add(dtpFechaCita);
            panel1.Controls.Add(lblFechaCita);
            panel1.Controls.Add(cmbDoctor);
            panel1.Controls.Add(lblNombreDoctor);
            panel1.Controls.Add(lblNombrePaciente);
            panel1.Controls.Add(tctNombrePaciente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 488);
            panel1.TabIndex = 10;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.CustomFormat = "hh:mm";
            dtpHoraCita.Font = new Font("Segoe UI", 12F);
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(330, 125);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(299, 34);
            dtpHoraCita.TabIndex = 31;
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Font = new Font("Segoe UI", 12F);
            lblHoraCita.Location = new Point(330, 94);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(55, 28);
            lblHoraCita.TabIndex = 30;
            lblHoraCita.Text = "Hora";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Font = new Font("Segoe UI", 12F);
            dtpFechaCita.Location = new Point(12, 125);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(299, 34);
            dtpFechaCita.TabIndex = 29;
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Font = new Font("Segoe UI", 12F);
            lblFechaCita.Location = new Point(12, 94);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(62, 28);
            lblFechaCita.TabIndex = 28;
            lblFechaCita.Text = "Fecha";
            // 
            // cmbDoctor
            // 
            cmbDoctor.Font = new Font("Segoe UI", 12F);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(330, 47);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(299, 36);
            cmbDoctor.TabIndex = 27;
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Segoe UI", 12F);
            lblNombreDoctor.Location = new Point(330, 16);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(73, 28);
            lblNombreDoctor.TabIndex = 26;
            lblNombreDoctor.Text = "Doctor";
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Segoe UI", 12F);
            lblNombrePaciente.Location = new Point(12, 16);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(84, 28);
            lblNombrePaciente.TabIndex = 4;
            lblNombrePaciente.Text = "Paciente";
            // 
            // tctNombrePaciente
            // 
            tctNombrePaciente.Font = new Font("Segoe UI", 12F);
            tctNombrePaciente.Location = new Point(12, 47);
            tctNombrePaciente.Name = "tctNombrePaciente";
            tctNombrePaciente.Size = new Size(299, 34);
            tctNombrePaciente.TabIndex = 3;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 12F);
            lblCosto.Location = new Point(12, 166);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(63, 28);
            lblCosto.TabIndex = 33;
            lblCosto.Text = "Costo";
            // 
            // txtcosto
            // 
            txtcosto.Font = new Font("Segoe UI", 12F);
            txtcosto.Location = new Point(12, 197);
            txtcosto.Name = "txtcosto";
            txtcosto.Size = new Size(299, 34);
            txtcosto.TabIndex = 32;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 12F);
            lblMotivo.Location = new Point(12, 232);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(76, 28);
            lblMotivo.TabIndex = 35;
            lblMotivo.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 12F);
            txtMotivo.Location = new Point(12, 263);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(617, 123);
            txtMotivo.TabIndex = 34;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(499, 411);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar1
            // 
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Location = new Point(332, 411);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(130, 52);
            btnCancelar1.TabIndex = 36;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            // 
            // frmCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 543);
            Controls.Add(panel1);
            Controls.Add(pnlHeader15);
            Name = "frmCita";
            Text = "Gestion de Citas";
            pnlHeader15.ResumeLayout(false);
            pnlHeader15.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader15;
        private Label lblCitas;
        private Panel panel1;
        private Label lblNombrePaciente;
        private TextBox tctNombrePaciente;
        private ComboBox cmbDoctor;
        private Label lblNombreDoctor;
        private DateTimePicker dtpHoraCita;
        private Label lblHoraCita;
        private DateTimePicker dtpFechaCita;
        private Label lblFechaCita;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblCosto;
        private TextBox txtcosto;
        private Button btnGuardar;
        private Button btnCancelar1;
    }
}