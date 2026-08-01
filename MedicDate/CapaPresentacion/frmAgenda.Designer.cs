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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            pnlHeaderAgenda.Margin = new Padding(3, 2, 3, 2);
            pnlHeaderAgenda.Name = "pnlHeaderAgenda";
            pnlHeaderAgenda.Size = new Size(772, 35);
            pnlHeaderAgenda.TabIndex = 12;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, -2);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(116, 37);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CalendarFont = new Font("Candara", 12F);
            dtpFechaCita.CalendarForeColor = Color.Black;
            dtpFechaCita.CalendarMonthBackground = Color.White;
            dtpFechaCita.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaCita.CalendarTitleForeColor = Color.Black;
            dtpFechaCita.CalendarTrailingForeColor = Color.Gray;
            dtpFechaCita.Font = new Font("Segoe UI", 12F);
            dtpFechaCita.Location = new Point(10, 40);
            dtpFechaCita.Margin = new Padding(3, 2, 3, 2);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(262, 29);
            dtpFechaCita.TabIndex = 30;
            dtpFechaCita.ValueChanged += dtpFechaCita_ValueChanged;
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.White;
            cmbDoctor.Font = new Font("Segoe UI", 12F);
            cmbDoctor.ForeColor = Color.Black;
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(291, 39);
            cmbDoctor.Margin = new Padding(3, 2, 3, 2);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(262, 29);
            cmbDoctor.TabIndex = 31;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerDetalle.BackColor = Color.FromArgb(166, 202, 236);
            btnVerDetalle.FlatStyle = FlatStyle.Popup;
            btnVerDetalle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVerDetalle.ForeColor = Color.Black;
            btnVerDetalle.Image = Properties.Resources.detalle_black;
            btnVerDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerDetalle.Location = new Point(632, 297);
            btnVerDetalle.Margin = new Padding(3, 2, 3, 2);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Padding = new Padding(7, 0, 5, 0);
            btnVerDetalle.Size = new Size(130, 34);
            btnVerDetalle.TabIndex = 33;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.TextAlign = ContentAlignment.MiddleRight;
            btnVerDetalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // dgvCita
            // 
            dgvCita.AllowDrop = true;
            dgvCita.AllowUserToAddRows = false;
            dgvCita.AllowUserToDeleteRows = false;
            dgvCita.AllowUserToResizeColumns = false;
            dgvCita.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCita.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCita.EnableHeadersVisualStyles = false;
            dgvCita.GridColor = Color.Gray;
            dgvCita.Location = new Point(11, 70);
            dgvCita.Margin = new Padding(3, 2, 3, 2);
            dgvCita.MultiSelect = false;
            dgvCita.Name = "dgvCita";
            dgvCita.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCita.RowHeadersVisible = false;
            dgvCita.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCita.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCita.ScrollBars = ScrollBars.Horizontal;
            dgvCita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCita.Size = new Size(751, 223);
            dgvCita.TabIndex = 34;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(772, 340);
            Controls.Add(dgvCita);
            Controls.Add(btnVerDetalle);
            Controls.Add(cmbDoctor);
            Controls.Add(dtpFechaCita);
            Controls.Add(pnlHeaderAgenda);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
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