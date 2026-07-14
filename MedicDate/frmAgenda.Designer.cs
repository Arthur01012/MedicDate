namespace MedicDate
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
            pnlHeader14 = new Panel();
            lblTituloAgenda = new Label();
            dtpFechaCita = new DateTimePicker();
            cmbDoctor = new ComboBox();
            btnVerDetalle = new Button();
            dataGridView1 = new DataGridView();
            pnlHeader14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader14
            // 
            pnlHeader14.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader14.Controls.Add(lblTituloAgenda);
            pnlHeader14.Dock = DockStyle.Top;
            pnlHeader14.Location = new Point(0, 0);
            pnlHeader14.Name = "pnlHeader14";
            pnlHeader14.Size = new Size(882, 47);
            pnlHeader14.TabIndex = 12;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(25, 9);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(76, 24);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Font = new Font("Segoe UI", 12F);
            dtpFechaCita.Location = new Point(12, 53);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(299, 34);
            dtpFechaCita.TabIndex = 30;
            // 
            // cmbDoctor
            // 
            cmbDoctor.Font = new Font("Segoe UI", 12F);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(333, 51);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(299, 36);
            cmbDoctor.TabIndex = 31;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerDetalle.BackColor = Color.FromArgb(166, 202, 236);
            btnVerDetalle.FlatStyle = FlatStyle.Popup;
            btnVerDetalle.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalle.Location = new Point(12, 396);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(148, 45);
            btnVerDetalle.TabIndex = 33;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 297);
            dataGridView1.TabIndex = 34;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(dataGridView1);
            Controls.Add(btnVerDetalle);
            Controls.Add(cmbDoctor);
            Controls.Add(dtpFechaCita);
            Controls.Add(pnlHeader14);
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloAgenda;
        private DateTimePicker dtpFechaCita;
        private ComboBox cmbDoctor;
        private Panel panel1;
        private Button btnVerDetalle;
        private DataGridView dataGridView1;
    }
}