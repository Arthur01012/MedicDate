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
            dgvDoctores = new DataGridView();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            pnlHeaderAgendaGeneral.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
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
            lblTituloAgenda.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, 4);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(250, 41);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda General";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(dgvDoctores);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 12;
            //
            // dgvDoctores
            //
            dgvDoctores.AllowDrop = true;
            dgvDoctores.AllowUserToAddRows = false;
            dgvDoctores.AllowUserToDeleteRows = false;
            dgvDoctores.AllowUserToResizeColumns = false;
            dgvDoctores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvDoctores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctores.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDoctores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.EnableHeadersVisualStyles = false;
            dgvDoctores.GridColor = Color.Gray;
            dgvDoctores.Location = new Point(12, 67);
            dgvDoctores.MultiSelect = false;
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDoctores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctores.RowHeadersVisible = false;
            dgvDoctores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDoctores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDoctores.ScrollBars = ScrollBars.Horizontal;
            dgvDoctores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctores.Size = new Size(1372, 633);
            dgvDoctores.TabIndex = 10;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Black;
            lblBuscar.Location = new Point(7, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(81, 27);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.BackColor = Color.White;
            txtBuscarDoctor.Font = new Font("Candara", 12F);
            txtBuscarDoctor.ForeColor = Color.Black;
            txtBuscarDoctor.Location = new Point(101, 19);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor.Size = new Size(549, 32);
            txtBuscarDoctor.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderAgendaGeneral;
        private Label lblTituloAgenda;
        private Panel pnlContenedor;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dgvDoctores;
    }
}