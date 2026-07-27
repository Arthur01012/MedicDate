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
            pnlHeaderCita = new Panel();
            lblCitas = new Label();
            pnlContanedor = new Panel();
            btnGuardar = new Button();
            btnCancelar1 = new Button();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblCosto = new Label();
            txtcosto = new TextBox();
            dtpHoraCita = new DateTimePicker();
            lblHoraCita = new Label();
            dtpFechaCita = new DateTimePicker();
            lblFechaCita = new Label();
            cmbDoctor = new ComboBox();
            lblNombreDoctor = new Label();
            lblNombrePaciente = new Label();
            tctNombrePaciente = new TextBox();
            pnlHeaderCita.SuspendLayout();
            pnlContanedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderCita
            // 
            pnlHeaderCita.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderCita.Controls.Add(lblCitas);
            pnlHeaderCita.Dock = DockStyle.Top;
            pnlHeaderCita.ForeColor = Color.Black;
            pnlHeaderCita.Location = new Point(0, 0);
            pnlHeaderCita.Name = "pnlHeaderCita";
            pnlHeaderCita.Size = new Size(641, 55);
            pnlHeaderCita.TabIndex = 9;
            // 
            // lblCitas
            // 
            lblCitas.AutoSize = true;
            lblCitas.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblCitas.ForeColor = Color.White;
            lblCitas.Location = new Point(3, 7);
            lblCitas.Name = "lblCitas";
            lblCitas.Size = new Size(88, 41);
            lblCitas.TabIndex = 0;
            lblCitas.Text = "Citas";
            // 
            // pnlContanedor
            // 
            pnlContanedor.BackColor = Color.LightGray;
            pnlContanedor.Controls.Add(btnGuardar);
            pnlContanedor.Controls.Add(btnCancelar1);
            pnlContanedor.Controls.Add(lblMotivo);
            pnlContanedor.Controls.Add(txtMotivo);
            pnlContanedor.Controls.Add(lblCosto);
            pnlContanedor.Controls.Add(txtcosto);
            pnlContanedor.Controls.Add(dtpHoraCita);
            pnlContanedor.Controls.Add(lblHoraCita);
            pnlContanedor.Controls.Add(dtpFechaCita);
            pnlContanedor.Controls.Add(lblFechaCita);
            pnlContanedor.Controls.Add(cmbDoctor);
            pnlContanedor.Controls.Add(lblNombreDoctor);
            pnlContanedor.Controls.Add(lblNombrePaciente);
            pnlContanedor.Controls.Add(tctNombrePaciente);
            pnlContanedor.Dock = DockStyle.Fill;
            pnlContanedor.ForeColor = Color.Black;
            pnlContanedor.Location = new Point(0, 55);
            pnlContanedor.Name = "pnlContanedor";
            pnlContanedor.Size = new Size(641, 488);
            pnlContanedor.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(499, 411);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar1
            // 
            btnCancelar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar1.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar1.FlatStyle = FlatStyle.Popup;
            btnCancelar1.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnCancelar1.ForeColor = Color.White;
            btnCancelar1.Location = new Point(332, 411);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(130, 52);
            btnCancelar1.TabIndex = 36;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = false;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Candara", 10.2F);
            lblMotivo.ForeColor = Color.Black;
            lblMotivo.Location = new Point(12, 240);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(63, 21);
            lblMotivo.TabIndex = 35;
            lblMotivo.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.White;
            txtMotivo.Font = new Font("Candara", 12F);
            txtMotivo.ForeColor = Color.Black;
            txtMotivo.Location = new Point(12, 263);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(617, 123);
            txtMotivo.TabIndex = 34;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Candara", 10.2F);
            lblCosto.ForeColor = Color.Black;
            lblCosto.Location = new Point(12, 174);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(52, 21);
            lblCosto.TabIndex = 33;
            lblCosto.Text = "Costo";
            // 
            // txtcosto
            // 
            txtcosto.BackColor = Color.White;
            txtcosto.Font = new Font("Candara", 12F);
            txtcosto.ForeColor = Color.Black;
            txtcosto.Location = new Point(12, 197);
            txtcosto.Name = "txtcosto";
            txtcosto.Size = new Size(299, 32);
            txtcosto.TabIndex = 32;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.CalendarForeColor = Color.Black;
            dtpHoraCita.CalendarMonthBackground = Color.White;
            dtpHoraCita.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpHoraCita.CalendarTitleForeColor = Color.Black;
            dtpHoraCita.CalendarTrailingForeColor = Color.Gray;
            dtpHoraCita.CustomFormat = "hh:mm";
            dtpHoraCita.Font = new Font("Candara", 12F);
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(330, 125);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(299, 32);
            dtpHoraCita.TabIndex = 31;
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Font = new Font("Candara", 10.2F);
            lblHoraCita.Location = new Point(330, 102);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(45, 21);
            lblHoraCita.TabIndex = 30;
            lblHoraCita.Text = "Hora";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CalendarForeColor = Color.Black;
            dtpFechaCita.CalendarMonthBackground = Color.White;
            dtpFechaCita.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaCita.CalendarTitleForeColor = Color.Black;
            dtpFechaCita.CalendarTrailingForeColor = Color.Gray;
            dtpFechaCita.Font = new Font("Candara", 12F);
            dtpFechaCita.Location = new Point(12, 125);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(299, 32);
            dtpFechaCita.TabIndex = 29;
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Font = new Font("Candara", 10.2F);
            lblFechaCita.Location = new Point(12, 102);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(52, 21);
            lblFechaCita.TabIndex = 28;
            lblFechaCita.Text = "Fecha";
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.White;
            cmbDoctor.Font = new Font("Candara", 12F);
            cmbDoctor.ForeColor = Color.Black;
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(330, 47);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(299, 32);
            cmbDoctor.TabIndex = 27;
            // 
            // lblNombreDoctor
            // 
            lblNombreDoctor.AutoSize = true;
            lblNombreDoctor.Font = new Font("Candara", 10.2F);
            lblNombreDoctor.ForeColor = Color.Black;
            lblNombreDoctor.Location = new Point(330, 24);
            lblNombreDoctor.Name = "lblNombreDoctor";
            lblNombreDoctor.Size = new Size(61, 21);
            lblNombreDoctor.TabIndex = 26;
            lblNombreDoctor.Text = "Doctor";
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Candara", 10.2F);
            lblNombrePaciente.ForeColor = Color.Black;
            lblNombrePaciente.Location = new Point(12, 23);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(72, 21);
            lblNombrePaciente.TabIndex = 4;
            lblNombrePaciente.Text = "Paciente";
            lblNombrePaciente.Click += lblNombrePaciente_Click;
            // 
            // tctNombrePaciente
            // 
            tctNombrePaciente.BackColor = Color.White;
            tctNombrePaciente.Font = new Font("Candara", 12F);
            tctNombrePaciente.ForeColor = Color.Black;
            tctNombrePaciente.Location = new Point(12, 47);
            tctNombrePaciente.Name = "tctNombrePaciente";
            tctNombrePaciente.Size = new Size(299, 32);
            tctNombrePaciente.TabIndex = 3;
            // 
            // frmCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 543);
            Controls.Add(pnlContanedor);
            Controls.Add(pnlHeaderCita);
            Name = "frmCita";
            Text = "Gestion de Citas";
            pnlHeaderCita.ResumeLayout(false);
            pnlHeaderCita.PerformLayout();
            pnlContanedor.ResumeLayout(false);
            pnlContanedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderCita;
        private Label lblCitas;
        private Panel pnlContanedor;
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