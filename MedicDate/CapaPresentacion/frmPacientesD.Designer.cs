namespace MedicDate.CapaPresentacion
{
    partial class frmPacientesD
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
            pnlHeaderPacientes = new Panel();
            lblPaciente = new Label();
            txtBuscar = new TextBox();
            dgvPacientes = new DataGridView();
            btnVerHistorial = new Button();
            pnlHeaderPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderPacientes
            // 
            pnlHeaderPacientes.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderPacientes.Controls.Add(lblPaciente);
            pnlHeaderPacientes.Dock = DockStyle.Top;
            pnlHeaderPacientes.ForeColor = Color.Black;
            pnlHeaderPacientes.Location = new Point(0, 0);
            pnlHeaderPacientes.Name = "pnlHeaderPacientes";
            pnlHeaderPacientes.Size = new Size(982, 47);
            pnlHeaderPacientes.TabIndex = 11;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPaciente.ForeColor = Color.White;
            lblPaciente.Location = new Point(3, -2);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(169, 46);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Pacientes";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(12, 56);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscar.Size = new Size(549, 34);
            txtBuscar.TabIndex = 12;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscarDoctor_TextChanged;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowDrop = true;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = Color.Gray;
            dgvPacientes.Location = new Point(12, 99);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.ScrollBars = ScrollBars.Horizontal;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(958, 220);
            dgvPacientes.TabIndex = 13;
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.BackColor = Color.FromArgb(166, 202, 236);
            btnVerHistorial.FlatStyle = FlatStyle.Popup;
            btnVerHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVerHistorial.ForeColor = Color.Black;
            btnVerHistorial.Image = Properties.Resources.ver_historial_black;
            btnVerHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerHistorial.Location = new Point(840, 339);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Padding = new Padding(8, 0, 6, 0);
            btnVerHistorial.Size = new Size(130, 52);
            btnVerHistorial.TabIndex = 44;
            btnVerHistorial.Text = "Historial";
            btnVerHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerHistorial.UseVisualStyleBackColor = false;
            // 
            // frmPacientesD
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 403);
            Controls.Add(btnVerHistorial);
            Controls.Add(dgvPacientes);
            Controls.Add(txtBuscar);
            Controls.Add(pnlHeaderPacientes);
            ForeColor = Color.Black;
            Name = "frmPacientesD";
            Text = "MedicDate v.1";
            pnlHeaderPacientes.ResumeLayout(false);
            pnlHeaderPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeaderPacientes;
        private Label lblPaciente;
        private TextBox txtBuscar;
        private DataGridView dgvPacientes;
        private Button btnVerHistorial;
    }
}