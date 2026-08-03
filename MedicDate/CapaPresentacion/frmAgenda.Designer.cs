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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeaderAgenda = new Panel();
            lblTituloAgenda = new Label();
            dtpFechaCita = new DateTimePicker();
            cmbFiltroEstado = new ComboBox();
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
            lblTituloAgenda.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, -3);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(143, 46);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CalendarFont = new Font("Segoe UI", 12F);
            dtpFechaCita.CalendarForeColor = Color.Black;
            dtpFechaCita.CalendarMonthBackground = Color.White;
            dtpFechaCita.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpFechaCita.CalendarTitleForeColor = Color.Black;
            dtpFechaCita.CalendarTrailingForeColor = Color.Gray;
            dtpFechaCita.Font = new Font("Segoe UI", 12F);
            dtpFechaCita.Location = new Point(11, 53);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(299, 34);
            dtpFechaCita.TabIndex = 30;
            dtpFechaCita.ValueChanged += dtpFechaCita_ValueChanged;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.BackColor = Color.White;
            cmbFiltroEstado.Font = new Font("Segoe UI", 12F);
            cmbFiltroEstado.ForeColor = Color.Black;
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new Point(333, 52);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(299, 36);
            cmbFiltroEstado.TabIndex = 31;
            cmbFiltroEstado.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
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
            btnVerDetalle.Location = new Point(722, 396);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Padding = new Padding(8, 0, 6, 0);
            btnVerDetalle.Size = new Size(149, 45);
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
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvCita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCita.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCita.EnableHeadersVisualStyles = false;
            dgvCita.GridColor = Color.Gray;
            dgvCita.Location = new Point(13, 93);
            dgvCita.MultiSelect = false;
            dgvCita.Name = "dgvCita";
            dgvCita.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCita.RowHeadersVisible = false;
            dgvCita.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCita.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvCita.ScrollBars = ScrollBars.Horizontal;
            dgvCita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            Controls.Add(cmbFiltroEstado);
            Controls.Add(dtpFechaCita);
            Controls.Add(pnlHeaderAgenda);
            ForeColor = Color.Black;
            Name = "frmAgenda";
            Text = "MedicDate v.1";
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
        private ComboBox cmbFiltroEstado;
        private Button btnVerDetalle;
        private DataGridView dgvCita;
    }
}