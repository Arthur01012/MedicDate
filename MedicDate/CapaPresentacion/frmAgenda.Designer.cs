namespace MedicDate.CapaPresentacion
{
    partial class frmAgenda
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
            pnlHeaderAgenda = new Panel();
            lblTituloAgenda = new Label();
            dtpFechaCita = new DateTimePicker();
            cmbDoctor = new ComboBox();
            btnVerDetalle = new Button();
            dgvCita = new DataGridView();
            pnlHeaderAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCita).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderAgenda
            // 
            pnlHeaderAgenda.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderAgenda.Controls.Add(lblTituloAgenda);
            pnlHeaderAgenda.Dock = DockStyle.Top;
            pnlHeaderAgenda.Font = new Font("Segoe UI", 9F);
            pnlHeaderAgenda.ForeColor = Color.Black;
            pnlHeaderAgenda.Location = new Point(0, 0);
            pnlHeaderAgenda.Name = "pnlHeaderAgenda";
            pnlHeaderAgenda.Size = new Size(882, 47);
            pnlHeaderAgenda.TabIndex = 12;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, 3);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(130, 41);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda";
            lblTituloAgenda.Click += lblTituloAgenda_Click;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CalendarFont = new Font("Candara", 12F);
            dtpFechaCita.CalendarForeColor = Color.Black;
            dtpFechaCita.CalendarMonthBackground = Color.White;
            dtpFechaCita.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaCita.CalendarTitleForeColor = Color.Black;
            dtpFechaCita.CalendarTrailingForeColor = Color.Gray;
            dtpFechaCita.Font = new Font("Candara", 12F);
            dtpFechaCita.Location = new Point(12, 53);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(299, 32);
            dtpFechaCita.TabIndex = 30;
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.White;
            cmbDoctor.Font = new Font("Candara", 12F);
            cmbDoctor.ForeColor = Color.Black;
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(333, 52);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(299, 32);
            cmbDoctor.TabIndex = 31;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerDetalle.BackColor = Color.FromArgb(166, 202, 236);
            btnVerDetalle.FlatStyle = FlatStyle.Popup;
            btnVerDetalle.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalle.ForeColor = Color.Black;
            btnVerDetalle.Location = new Point(722, 396);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(148, 45);
            btnVerDetalle.TabIndex = 33;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // dgvCita
            // 
            dgvCita.BackgroundColor = Color.Gray;
            dgvCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCita.GridColor = Color.Gray;
            dgvCita.Location = new Point(13, 93);
            dgvCita.Name = "dgvCita";
            dgvCita.RowHeadersWidth = 51;
            dgvCita.Size = new Size(858, 297);
            dgvCita.TabIndex = 34;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(882, 453);
            Controls.Add(dgvCita);
            Controls.Add(btnVerDetalle);
            Controls.Add(cmbDoctor);
            Controls.Add(dtpFechaCita);
            Controls.Add(pnlHeaderAgenda);
            ForeColor = Color.Black;
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            pnlHeaderAgenda.ResumeLayout(false);
            pnlHeaderAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCita).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderAgenda;
        private Label lblTituloAgenda;
        private DateTimePicker dtpFechaCita;
        private ComboBox cmbDoctor;
        private Panel panel1;
        private Button btnVerDetalle;
        private DataGridView dgvCita;
    }
}