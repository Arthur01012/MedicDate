namespace MedicDate
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
            pnlHeader3 = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnDarBaja = new Button();
            btnEditarDoctor = new Button();
            btnNuevoDoctor = new Button();
            dgvDoctores = new DataGridView();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            pnlHeader3.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader3
            // 
            pnlHeader3.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader3.Controls.Add(lblTitulo);
            pnlHeader3.Dock = DockStyle.Top;
            pnlHeader3.Location = new Point(0, 0);
            pnlHeader3.Name = "pnlHeader3";
            pnlHeader3.Size = new Size(1398, 47);
            pnlHeader3.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Doctores";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Gainsboro;
            pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedor.Controls.Add(btnDarBaja);
            pnlContenedor.Controls.Add(btnEditarDoctor);
            pnlContenedor.Controls.Add(btnNuevoDoctor);
            pnlContenedor.Controls.Add(dgvDoctores);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 10;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDarBaja.BackColor = Color.FromArgb(176, 11, 11);
            btnDarBaja.FlatStyle = FlatStyle.Popup;
            btnDarBaja.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Location = new Point(1225, 11);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(148, 45);
            btnDarBaja.TabIndex = 5;
            btnDarBaja.Text = "Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // btnEditarDoctor
            // 
            btnEditarDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarDoctor.BackColor = Color.LightGray;
            btnEditarDoctor.BackgroundImageLayout = ImageLayout.None;
            btnEditarDoctor.FlatStyle = FlatStyle.Popup;
            btnEditarDoctor.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarDoctor.Location = new Point(1045, 11);
            btnEditarDoctor.Name = "btnEditarDoctor";
            btnEditarDoctor.Size = new Size(148, 45);
            btnEditarDoctor.TabIndex = 4;
            btnEditarDoctor.Text = "Editar Doctor";
            btnEditarDoctor.UseVisualStyleBackColor = false;
            btnEditarDoctor.Click += btnEditarDoctor_Click;
            // 
            // btnNuevoDoctor
            // 
            btnNuevoDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoDoctor.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoDoctor.FlatStyle = FlatStyle.Popup;
            btnNuevoDoctor.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoDoctor.Location = new Point(860, 11);
            btnNuevoDoctor.Name = "btnNuevoDoctor";
            btnNuevoDoctor.Size = new Size(148, 45);
            btnNuevoDoctor.TabIndex = 3;
            btnNuevoDoctor.Text = "Agregar Doctor";
            btnNuevoDoctor.UseVisualStyleBackColor = false;
            btnNuevoDoctor.Click += btnNuevoDoctor_Click;
            // 
            // dgvDoctores
            // 
            dgvDoctores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.Location = new Point(11, 73);
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.RowHeadersWidth = 51;
            dgvDoctores.Size = new Size(1374, 626);
            dgvDoctores.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(11, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(63, 21);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarDoctor.Location = new Point(76, 20);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor.Size = new Size(549, 28);
            txtBuscarDoctor.TabIndex = 0;
            // 
            // frmRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader3);
            Name = "frmRegistrarDoctor";
            Text = "Administrador";
            pnlHeader3.ResumeLayout(false);
            pnlHeader3.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader3;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dgvDoctores;
        private Button btnNuevoDoctor;
        private Button btnDarBaja;
        private Button btnEditarDoctor;
    }
}