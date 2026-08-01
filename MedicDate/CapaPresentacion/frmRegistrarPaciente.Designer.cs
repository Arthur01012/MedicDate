namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarPaciente
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
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            dgvPacientes = new DataGridView();
            btnverHistorial = new Button();
            btnEditarPaciente = new Button();
            btnNuevoPaciente = new Button();
            lblBuscar = new Label();
            txtBuscarPaciente = new TextBox();
            pnlHeaderPacientes.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderPacientes
            // 
            pnlHeaderPacientes.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderPacientes.Controls.Add(lblTitulo);
            pnlHeaderPacientes.Dock = DockStyle.Top;
            pnlHeaderPacientes.ForeColor = Color.Black;
            pnlHeaderPacientes.Location = new Point(0, 0);
            pnlHeaderPacientes.Name = "pnlHeaderPacientes";
            pnlHeaderPacientes.Size = new Size(1396, 47);
            pnlHeaderPacientes.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, -1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pacientes";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(dgvPacientes);
            pnlContenedor.Controls.Add(btnverHistorial);
            pnlContenedor.Controls.Add(btnEditarPaciente);
            pnlContenedor.Controls.Add(btnNuevoPaciente);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarPaciente);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 10;
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
            dgvPacientes.Location = new Point(10, 74);
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
            dgvPacientes.Size = new Size(1374, 626);
            dgvPacientes.TabIndex = 11;
            // 
            // btnverHistorial
            // 
            btnverHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnverHistorial.BackColor = Color.DarkGoldenrod;
            btnverHistorial.BackgroundImageLayout = ImageLayout.None;
            btnverHistorial.FlatStyle = FlatStyle.Popup;
            btnverHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnverHistorial.ForeColor = Color.Black;
            btnverHistorial.Image = Properties.Resources.ver_historial_black;
            btnverHistorial.ImageAlign = ContentAlignment.TopLeft;
            btnverHistorial.Location = new Point(1231, 14);
            btnverHistorial.Name = "btnverHistorial";
            btnverHistorial.Padding = new Padding(8, 0, 6, 0);
            btnverHistorial.Size = new Size(148, 45);
            btnverHistorial.TabIndex = 10;
            btnverHistorial.Text = "Ver Historial";
            btnverHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnverHistorial.UseVisualStyleBackColor = false;
            btnverHistorial.Click += btnverHistorial_Click;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarPaciente.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarPaciente.BackgroundImageLayout = ImageLayout.None;
            btnEditarPaciente.FlatStyle = FlatStyle.Popup;
            btnEditarPaciente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarPaciente.Image = Properties.Resources.editar_black;
            btnEditarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarPaciente.Location = new Point(1051, 14);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Padding = new Padding(8, 0, 6, 0);
            btnEditarPaciente.Size = new Size(148, 45);
            btnEditarPaciente.TabIndex = 9;
            btnEditarPaciente.Text = "Editar";
            btnEditarPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnEditarPaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoPaciente.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoPaciente.FlatStyle = FlatStyle.Popup;
            btnNuevoPaciente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoPaciente.Image = Properties.Resources.nuevo_black;
            btnNuevoPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoPaciente.Location = new Point(866, 14);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Padding = new Padding(8, 0, 6, 0);
            btnNuevoPaciente.Size = new Size(148, 45);
            btnNuevoPaciente.TabIndex = 8;
            btnNuevoPaciente.Text = "Agregar";
            btnNuevoPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoPaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.LightGray;
            lblBuscar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBuscar.Location = new Point(17, 26);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 30);
            lblBuscar.TabIndex = 7;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.BackColor = Color.White;
            txtBuscarPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtBuscarPaciente.ForeColor = Color.Black;
            txtBuscarPaciente.Location = new Point(111, 23);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.PlaceholderText = "Ingrese el nombre del Paciente";
            txtBuscarPaciente.Size = new Size(549, 34);
            txtBuscarPaciente.TabIndex = 6;
            txtBuscarPaciente.TextChanged += txtBuscarPaciente_TextChanged;
            // 
            // frmRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderPacientes);
            ForeColor = Color.Black;
            Name = "frmRegistrarPaciente";
            Load += frmRegistrarPaciente_Load;
            pnlHeaderPacientes.ResumeLayout(false);
            pnlHeaderPacientes.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderPacientes;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Button btnverHistorial;
        private Button btnEditarPaciente;
        private Button btnNuevoPaciente;
        private Label lblBuscar;
        private TextBox txtBuscarPaciente;
        private DataGridView dgvPacientes;
    }
}