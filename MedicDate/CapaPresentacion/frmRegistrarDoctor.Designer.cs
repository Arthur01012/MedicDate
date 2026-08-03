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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeaderDoctores = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            lblPagina = new Label();
            btnDespues = new Button();
            btnAnterior = new Button();
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
            pnlContenedor.Controls.Add(lblPagina);
            pnlContenedor.Controls.Add(btnDespues);
            pnlContenedor.Controls.Add(btnAnterior);
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
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPagina.AutoSize = true;
            lblPagina.BackColor = Color.LightGray;
            lblPagina.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagina.ForeColor = Color.Black;
            lblPagina.Location = new Point(1155, 663);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(64, 23);
            lblPagina.TabIndex = 8;
            lblPagina.Text = "Página";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDespues
            // 
            btnDespues.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDespues.BackColor = Color.FromArgb(166, 202, 236);
            btnDespues.FlatStyle = FlatStyle.Popup;
            btnDespues.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDespues.Image = Properties.Resources.siguiente_black;
            btnDespues.Location = new Point(1284, 647);
            btnDespues.Name = "btnDespues";
            btnDespues.Size = new Size(55, 45);
            btnDespues.TabIndex = 7;
            btnDespues.UseVisualStyleBackColor = false;
            btnDespues.Click += btnDespues_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.BackColor = Color.FromArgb(166, 202, 236);
            btnAnterior.FlatStyle = FlatStyle.Popup;
            btnAnterior.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Image = Properties.Resources.anterior_black;
            btnAnterior.Location = new Point(1082, 647);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(55, 45);
            btnAnterior.TabIndex = 6;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDesactivar.BackColor = Color.FromArgb(176, 11, 11);
            btnDesactivar.FlatStyle = FlatStyle.Popup;
            btnDesactivar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDesactivar.ForeColor = Color.White;
            btnDesactivar.Image = Properties.Resources.desactivar_white;
            btnDesactivar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesactivar.Location = new Point(1191, 31);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Padding = new Padding(8, 0, 6, 0);
            btnDesactivar.Size = new Size(148, 45);
            btnDesactivar.TabIndex = 5;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.TextAlign = ContentAlignment.MiddleRight;
            btnDesactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnEditarDoctor.Image = Properties.Resources.editar_black;
            btnEditarDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarDoctor.Location = new Point(1015, 31);
            btnEditarDoctor.Name = "btnEditarDoctor";
            btnEditarDoctor.Padding = new Padding(8, 0, 6, 0);
            btnEditarDoctor.Size = new Size(148, 45);
            btnEditarDoctor.TabIndex = 4;
            btnEditarDoctor.Text = "Editar";
            btnEditarDoctor.TextAlign = ContentAlignment.MiddleRight;
            btnEditarDoctor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarDoctor.UseVisualStyleBackColor = false;
            btnEditarDoctor.Click += btnEditarDoctor_Click;
            // 
            // btnNuevoDoctor
            // 
            btnNuevoDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoDoctor.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoDoctor.FlatStyle = FlatStyle.Popup;
            btnNuevoDoctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoDoctor.Image = Properties.Resources.nuevo_black;
            btnNuevoDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoDoctor.Location = new Point(832, 31);
            btnNuevoDoctor.Name = "btnNuevoDoctor";
            btnNuevoDoctor.Padding = new Padding(8, 0, 6, 0);
            btnNuevoDoctor.Size = new Size(148, 45);
            btnNuevoDoctor.TabIndex = 3;
            btnNuevoDoctor.Text = "Agregar";
            btnNuevoDoctor.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoDoctor.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvDoctores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctores.BackgroundColor = Color.LightGray;
            dgvDoctores.BorderStyle = BorderStyle.None;
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
            dgvDoctores.Location = new Point(55, 98);
            dgvDoctores.MultiSelect = false;
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDoctores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctores.RowHeadersVisible = false;
            dgvDoctores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            dgvDoctores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDoctores.ScrollBars = ScrollBars.Horizontal;
            dgvDoctores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctores.Size = new Size(1284, 543);
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
            BackColor = Color.White;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderDoctores);
            ForeColor = Color.Black;
            Name = "frmRegistrarDoctor";
            Text = "MedicDate v.1";
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
        private Button btnDespues;
        private Button btnAnterior;
        private Label lblPagina;
    }
}