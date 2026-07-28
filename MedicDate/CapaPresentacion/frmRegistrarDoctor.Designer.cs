namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarDoctor
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
            pnlHeaderDoctores = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnDesactivar = new Button();
            btnEditarDoctor = new Button();
            btnNuevoDoctor = new Button();
            dgvDoctores = new DataGridView();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            pnlHeaderDoctores.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderDoctores
            // 
            pnlHeaderDoctores.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderDoctores.Controls.Add(lblTitulo);
            pnlHeaderDoctores.Dock = DockStyle.Top;
            pnlHeaderDoctores.ForeColor = Color.Black;
            pnlHeaderDoctores.Location = new Point(0, 0);
            pnlHeaderDoctores.Name = "pnlHeaderDoctores";
            pnlHeaderDoctores.Size = new Size(1398, 47);
            pnlHeaderDoctores.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(4, -1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(163, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Doctores";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedor.Controls.Add(btnDesactivar);
            pnlContenedor.Controls.Add(btnEditarDoctor);
            pnlContenedor.Controls.Add(btnNuevoDoctor);
            pnlContenedor.Controls.Add(dgvDoctores);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 10;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDesactivar.BackColor = Color.FromArgb(176, 11, 11);
            btnDesactivar.FlatStyle = FlatStyle.Popup;
            btnDesactivar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDesactivar.ForeColor = Color.White;
            btnDesactivar.Location = new Point(1191, 31);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(148, 45);
            btnDesactivar.TabIndex = 5;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            btnDesactivar.Click += btnDarBaja_Click;
            // 
            // btnEditarDoctor
            // 
            btnEditarDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarDoctor.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarDoctor.BackgroundImageLayout = ImageLayout.None;
            btnEditarDoctor.FlatStyle = FlatStyle.Popup;
            btnEditarDoctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarDoctor.Location = new Point(1015, 31);
            btnEditarDoctor.Name = "btnEditarDoctor";
            btnEditarDoctor.Size = new Size(148, 45);
            btnEditarDoctor.TabIndex = 4;
            btnEditarDoctor.Text = "Editar";
            btnEditarDoctor.UseVisualStyleBackColor = false;
            btnEditarDoctor.Click += btnEditarDoctor_Click;
            // 
            // btnNuevoDoctor
            // 
            btnNuevoDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoDoctor.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoDoctor.FlatStyle = FlatStyle.Popup;
            btnNuevoDoctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoDoctor.Location = new Point(832, 31);
            btnNuevoDoctor.Name = "btnNuevoDoctor";
            btnNuevoDoctor.Size = new Size(148, 45);
            btnNuevoDoctor.TabIndex = 3;
            btnNuevoDoctor.Text = "Agregar";
            btnNuevoDoctor.UseVisualStyleBackColor = false;
            btnNuevoDoctor.Click += btnNuevoDoctor_Click;
            // 
            // dgvDoctores
            // 
            dgvDoctores.AllowDrop = true;
            dgvDoctores.AllowUserToAddRows = false;
            dgvDoctores.AllowUserToDeleteRows = false;
            dgvDoctores.AllowUserToResizeColumns = false;
            dgvDoctores.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvDoctores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctores.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDoctores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.EnableHeadersVisualStyles = false;
            dgvDoctores.GridColor = Color.Gray;
            dgvDoctores.Location = new Point(55, 98);
            dgvDoctores.MultiSelect = false;
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDoctores.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDoctores.RowHeadersVisible = false;
            dgvDoctores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDoctores.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDoctores.ScrollBars = ScrollBars.Horizontal;
            dgvDoctores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctores.Size = new Size(1284, 601);
            dgvDoctores.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.LightGray;
            lblBuscar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Black;
            lblBuscar.Location = new Point(55, 49);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 30);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.BackColor = Color.White;
            txtBuscarDoctor.Font = new Font("Segoe UI", 12F);
            txtBuscarDoctor.ForeColor = Color.Black;
            txtBuscarDoctor.Location = new Point(147, 52);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor.Size = new Size(549, 34);
            txtBuscarDoctor.TabIndex = 0;
            txtBuscarDoctor.TextChanged += txtBuscarDoctor_TextChanged;
            // 
            // frmRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderDoctores);
            Name = "frmRegistrarDoctor";
            Text = "Administrador";
            pnlHeaderDoctores.ResumeLayout(false);
            pnlHeaderDoctores.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderDoctores;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dgvDoctores;
        private Button btnNuevoDoctor;
        private Button btnDesactivar;
        private Button btnEditarDoctor;
    }
}