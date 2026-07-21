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
            pnlHeader5 = new Panel();
            lbEspecialidad = new Label();
            pnlContenedor = new Panel();
            btnDarBaja4 = new Button();
            btnEditarEspecialidad = new Button();
            btnNuevoEspecialidad = new Button();
            dgvEspecialidad = new DataGridView();
            lblBuscar1 = new Label();
            txtBuscarEspecialidad = new TextBox();
            pnlHeader5.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader5
            // 
            pnlHeader5.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader5.Controls.Add(lbEspecialidad);
            pnlHeader5.Dock = DockStyle.Top;
            pnlHeader5.Location = new Point(0, 0);
            pnlHeader5.Name = "pnlHeader5";
            pnlHeader5.Size = new Size(1398, 47);
            pnlHeader5.TabIndex = 10;
            // 
            // lbEspecialidad
            // 
            lbEspecialidad.AutoSize = true;
            lbEspecialidad.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEspecialidad.ForeColor = Color.White;
            lbEspecialidad.Location = new Point(25, 9);
            lbEspecialidad.Name = "lbEspecialidad";
            lbEspecialidad.Size = new Size(134, 24);
            lbEspecialidad.TabIndex = 0;
            lbEspecialidad.Text = "Especialidades";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnDarBaja4);
            pnlContenedor.Controls.Add(btnEditarEspecialidad);
            pnlContenedor.Controls.Add(btnNuevoEspecialidad);
            pnlContenedor.Controls.Add(dgvEspecialidad);
            pnlContenedor.Controls.Add(lblBuscar1);
            pnlContenedor.Controls.Add(txtBuscarEspecialidad);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 11;
            // 
            // btnDarBaja4
            // 
            btnDarBaja4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDarBaja4.BackColor = Color.FromArgb(176, 11, 11);
            btnDarBaja4.FlatStyle = FlatStyle.Popup;
            btnDarBaja4.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja4.ForeColor = Color.White;
            btnDarBaja4.Location = new Point(1226, 12);
            btnDarBaja4.Name = "btnDarBaja4";
            btnDarBaja4.Size = new Size(148, 45);
            btnDarBaja4.TabIndex = 17;
            btnDarBaja4.Text = "Dar de Baja";
            btnDarBaja4.UseVisualStyleBackColor = false;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarEspecialidad.BackColor = Color.LightGray;
            btnEditarEspecialidad.BackgroundImageLayout = ImageLayout.None;
            btnEditarEspecialidad.FlatStyle = FlatStyle.Popup;
            btnEditarEspecialidad.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEspecialidad.Location = new Point(1046, 12);
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
            btnNuevoEspecialidad.Location = new Point(861, 12);
            btnNuevoEspecialidad.Name = "btnNuevoEspecialidad";
            btnNuevoEspecialidad.Size = new Size(148, 45);
            btnNuevoEspecialidad.TabIndex = 15;
            btnNuevoEspecialidad.Text = "Nuevo";
            btnNuevoEspecialidad.UseVisualStyleBackColor = false;
            btnNuevoEspecialidad.Click += btnNuevoEspecialidad_Click;
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.Location = new Point(12, 74);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.RowHeadersWidth = 51;
            dgvEspecialidad.Size = new Size(1374, 626);
            dgvEspecialidad.TabIndex = 14;
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar1.Location = new Point(12, 24);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(63, 21);
            lblBuscar1.TabIndex = 13;
            lblBuscar1.Text = "Buscar:";
            // 
            // txtBuscarEspecialidad
            // 
            txtBuscarEspecialidad.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarEspecialidad.Location = new Point(77, 21);
            txtBuscarEspecialidad.Name = "txtBuscarEspecialidad";
            txtBuscarEspecialidad.PlaceholderText = "Nombre de la Especialidad";
            txtBuscarEspecialidad.Size = new Size(549, 28);
            txtBuscarEspecialidad.TabIndex = 12;
            txtBuscarEspecialidad.TextChanged += txtBuscarEspecialidad_TextChanged;
            // 
            // frmRegistrarEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader5);
            Name = "frmRegistrarEspecialidad";
            Text = "frmRegistrarEspecialidadcs";
            pnlHeader5.ResumeLayout(false);
            pnlHeader5.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader5;
        private Label lbEspecialidad;
        private Panel pnlContenedor;
        private Button btnDarBaja4;
        private Button btnEditarEspecialidad;
        private Button btnNuevoEspecialidad;
        private DataGridView dgvEspecialidad;
        private Label lblBuscar1;
        private TextBox txtBuscarEspecialidad;
    }
}