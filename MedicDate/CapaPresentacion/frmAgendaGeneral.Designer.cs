namespace MedicDate.CapaPresentacion
{
    partial class frmAgendaGeneral
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
            pnlHeaderAgendaGeneral = new Panel();
            lblTituloAgenda = new Label();
            pnlContenedor = new Panel();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            dgvCitas = new DataGridView();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            pnlHeaderAgendaGeneral.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderAgendaGeneral
            // 
            pnlHeaderAgendaGeneral.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderAgendaGeneral.Controls.Add(lblTituloAgenda);
            pnlHeaderAgendaGeneral.Dock = DockStyle.Top;
            pnlHeaderAgendaGeneral.Font = new Font("Segoe UI", 9F);
            pnlHeaderAgendaGeneral.Location = new Point(0, 0);
            pnlHeaderAgendaGeneral.Name = "pnlHeaderAgendaGeneral";
            pnlHeaderAgendaGeneral.Size = new Size(1396, 47);
            pnlHeaderAgendaGeneral.TabIndex = 11;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, -1);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(275, 46);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda General";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(dtpFecha);
            pnlContenedor.Controls.Add(lblFecha);
            pnlContenedor.Controls.Add(dgvCitas);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 12;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(764, 19);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(199, 34);
            dtpFecha.TabIndex = 12;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(687, 26);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha:";
            // 
            // dgvCitas
            // 
            dgvCitas.AllowDrop = true;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AllowUserToResizeColumns = false;
            dgvCitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.GridColor = Color.Gray;
            dgvCitas.Location = new Point(12, 67);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCitas.ScrollBars = ScrollBars.Horizontal;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(1372, 633);
            dgvCitas.TabIndex = 10;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Black;
            lblBuscar.Location = new Point(7, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 30);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.BackColor = Color.White;
            txtBuscarDoctor.Font = new Font("Segoe UI", 12F);
            txtBuscarDoctor.ForeColor = Color.Black;
            txtBuscarDoctor.Location = new Point(101, 19);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor.Size = new Size(549, 34);
            txtBuscarDoctor.TabIndex = 8;
            txtBuscarDoctor.TextChanged += txtBuscarDoctor_TextChanged;
            // 
            // frmAgendaGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderAgendaGeneral);
            ForeColor = Color.Black;
            Name = "frmAgendaGeneral";
            Load += frmAgendaGeneral_Load;
            pnlHeaderAgendaGeneral.ResumeLayout(false);
            pnlHeaderAgendaGeneral.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderAgendaGeneral;
        private Label lblTituloAgenda;
        private Panel pnlContenedor;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dgvCitas;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
    }
}