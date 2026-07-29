namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarEspecialidad
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
            pnlHeaderEspecialidades = new Panel();
            lblEspecialidad = new Label();
            pnlContenedor = new Panel();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtEspecialidad = new TextBox();
            lblNombreEspecialidad = new Label();
            btnDarBaja4 = new Button();
            btnEditarEspecialidad = new Button();
            btnNuevoEspecialidad = new Button();
            dgvEspecialidad = new DataGridView();
            lblBuscar1 = new Label();
            txtBuscarEspecialidad = new TextBox();
            pnlHeaderEspecialidades.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderEspecialidades
            // 
            pnlHeaderEspecialidades.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderEspecialidades.Controls.Add(lblEspecialidad);
            pnlHeaderEspecialidades.Dock = DockStyle.Top;
            pnlHeaderEspecialidades.ForeColor = Color.Black;
            pnlHeaderEspecialidades.Location = new Point(0, 0);
            pnlHeaderEspecialidades.Name = "pnlHeaderEspecialidades";
            pnlHeaderEspecialidades.Size = new Size(1398, 47);
            pnlHeaderEspecialidades.TabIndex = 10;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblEspecialidad.ForeColor = Color.White;
            lblEspecialidad.Location = new Point(3, 4);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(229, 41);
            lblEspecialidad.TabIndex = 0;
            lblEspecialidad.Text = "Especialidades";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(txtDescripcion);
            pnlContenedor.Controls.Add(lblDescripcion);
            pnlContenedor.Controls.Add(txtEspecialidad);
            pnlContenedor.Controls.Add(lblNombreEspecialidad);
            pnlContenedor.Controls.Add(btnDarBaja4);
            pnlContenedor.Controls.Add(btnEditarEspecialidad);
            pnlContenedor.Controls.Add(btnNuevoEspecialidad);
            pnlContenedor.Controls.Add(dgvEspecialidad);
            pnlContenedor.Controls.Add(lblBuscar1);
            pnlContenedor.Controls.Add(txtBuscarEspecialidad);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(12, 102);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(1374, 142);
            txtDescripcion.TabIndex = 119;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Candara", 10.2F);
            lblDescripcion.Location = new Point(12, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(95, 21);
            lblDescripcion.TabIndex = 118;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = Color.White;
            txtEspecialidad.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.ForeColor = Color.Black;
            txtEspecialidad.Location = new Point(12, 40);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(1374, 32);
            txtEspecialidad.TabIndex = 117;
            // 
            // lblNombreEspecialidad
            // 
            lblNombreEspecialidad.AutoSize = true;
            lblNombreEspecialidad.Font = new Font("Candara", 10.2F);
            lblNombreEspecialidad.Location = new Point(12, 16);
            lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            lblNombreEspecialidad.Size = new Size(69, 21);
            lblNombreEspecialidad.TabIndex = 116;
            lblNombreEspecialidad.Text = "Nombre";
            // 
            // btnDarBaja4
            // 
            btnDarBaja4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDarBaja4.BackColor = Color.FromArgb(176, 11, 11);
            btnDarBaja4.FlatStyle = FlatStyle.Popup;
            btnDarBaja4.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja4.ForeColor = Color.White;
            btnDarBaja4.Location = new Point(1226, 280);
            btnDarBaja4.Name = "btnDarBaja4";
            btnDarBaja4.Size = new Size(148, 45);
            btnDarBaja4.TabIndex = 17;
            btnDarBaja4.Text = "Dar de Baja";
            btnDarBaja4.UseVisualStyleBackColor = false;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarEspecialidad.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarEspecialidad.BackgroundImageLayout = ImageLayout.None;
            btnEditarEspecialidad.FlatStyle = FlatStyle.Popup;
            btnEditarEspecialidad.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEspecialidad.Location = new Point(1046, 280);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new Size(148, 45);
            btnEditarEspecialidad.TabIndex = 16;
            btnEditarEspecialidad.Text = "Editar";
            btnEditarEspecialidad.UseVisualStyleBackColor = false;
            // 
            // btnNuevoEspecialidad
            // 
            btnNuevoEspecialidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoEspecialidad.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoEspecialidad.FlatStyle = FlatStyle.Popup;
            btnNuevoEspecialidad.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoEspecialidad.Location = new Point(861, 280);
            btnNuevoEspecialidad.Name = "btnNuevoEspecialidad";
            btnNuevoEspecialidad.Size = new Size(148, 45);
            btnNuevoEspecialidad.TabIndex = 15;
            btnNuevoEspecialidad.Text = "Nuevo";
            btnNuevoEspecialidad.UseVisualStyleBackColor = false;
            //
            // dgvEspecialidad
            //
            dgvEspecialidad.AllowDrop = true;
            dgvEspecialidad.AllowUserToAddRows = false;
            dgvEspecialidad.AllowUserToDeleteRows = false;
            dgvEspecialidad.AllowUserToResizeColumns = false;
            dgvEspecialidad.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvEspecialidad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEspecialidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidad.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.EnableHeadersVisualStyles = false;
            dgvEspecialidad.GridColor = Color.Gray;
            dgvEspecialidad.Location = new Point(12, 403);
            dgvEspecialidad.MultiSelect = false;
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEspecialidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEspecialidad.RowHeadersVisible = false;
            dgvEspecialidad.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvEspecialidad.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEspecialidad.ScrollBars = ScrollBars.Horizontal;
            dgvEspecialidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidad.Size = new Size(1374, 300);
            dgvEspecialidad.TabIndex = 14;
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblBuscar1.Location = new Point(12, 355);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(81, 27);
            lblBuscar1.TabIndex = 13;
            lblBuscar1.Text = "Buscar:";
            // 
            // txtBuscarEspecialidad
            // 
            txtBuscarEspecialidad.BackColor = Color.White;
            txtBuscarEspecialidad.Font = new Font("Candara", 12F);
            txtBuscarEspecialidad.ForeColor = Color.Black;
            txtBuscarEspecialidad.Location = new Point(97, 353);
            txtBuscarEspecialidad.Name = "txtBuscarEspecialidad";
            txtBuscarEspecialidad.PlaceholderText = "Nombre de la Especialidad";
            txtBuscarEspecialidad.Size = new Size(549, 32);
            txtBuscarEspecialidad.TabIndex = 12;
            txtBuscarEspecialidad.TextChanged += txtBuscarEspecialidad_TextChanged;
            // 
            // frmRegistrarEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderEspecialidades);
            Name = "frmRegistrarEspecialidad";
            Text = "frmRegistrarEspecialidadcs";
            pnlHeaderEspecialidades.ResumeLayout(false);
            pnlHeaderEspecialidades.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderEspecialidades;
        private Label lblEspecialidad;
        private Panel pnlContenedor;
        private Button btnDarBaja4;
        private Button btnEditarEspecialidad;
        private Button btnNuevoEspecialidad;
        private DataGridView dgvEspecialidad;
        private Label lblBuscar1;
        private TextBox txtBuscarEspecialidad;
        private TextBox txtEspecialidad;
        private Label lblNombreEspecialidad;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
    }
}