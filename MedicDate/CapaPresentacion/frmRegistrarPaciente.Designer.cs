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
            pnlHeader12 = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            dgvPacientes = new DataGridView();
            btnverHistorial = new Button();
            btnEditarPaciente = new Button();
            btnNuevoPaciente = new Button();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            pnlHeader12.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader12
            // 
            pnlHeader12.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader12.Controls.Add(lblTitulo);
            pnlHeader12.Dock = DockStyle.Top;
            pnlHeader12.Location = new Point(0, 0);
            pnlHeader12.Name = "pnlHeader12";
            pnlHeader12.Size = new Size(1396, 47);
            pnlHeader12.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pacientes";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Gainsboro;
            pnlContenedor.Controls.Add(dgvPacientes);
            pnlContenedor.Controls.Add(btnverHistorial);
            pnlContenedor.Controls.Add(btnEditarPaciente);
            pnlContenedor.Controls.Add(btnNuevoPaciente);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 10;
            // 
            // dgvPacientes
            // 
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(10, 74);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(1374, 626);
            dgvPacientes.TabIndex = 11;
            // 
            // btnverHistorial
            // 
            btnverHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnverHistorial.BackColor = Color.DarkGoldenrod;
            btnverHistorial.FlatStyle = FlatStyle.Popup;
            btnverHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnverHistorial.ForeColor = Color.Black;
            btnverHistorial.Location = new Point(1231, 14);
            btnverHistorial.Name = "btnverHistorial";
            btnverHistorial.Size = new Size(148, 45);
            btnverHistorial.TabIndex = 10;
            btnverHistorial.Text = "Ver Historial";
            btnverHistorial.UseVisualStyleBackColor = false;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarPaciente.BackColor = Color.LightGray;
            btnEditarPaciente.BackgroundImageLayout = ImageLayout.None;
            btnEditarPaciente.FlatStyle = FlatStyle.Popup;
            btnEditarPaciente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarPaciente.Location = new Point(1051, 14);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(148, 45);
            btnEditarPaciente.TabIndex = 9;
            btnEditarPaciente.Text = "Editar Paciente";
            btnEditarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoPaciente.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoPaciente.FlatStyle = FlatStyle.Popup;
            btnNuevoPaciente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoPaciente.Location = new Point(866, 14);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(148, 45);
            btnNuevoPaciente.TabIndex = 8;
            btnNuevoPaciente.Text = "Agrgar Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblBuscar.Location = new Point(17, 26);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 7;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtBuscarDoctor.Location = new Point(82, 23);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Paciente";
            txtBuscarDoctor.Size = new Size(549, 30);
            txtBuscarDoctor.TabIndex = 6;
            // 
            // frmRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader12);
            Name = "frmRegistrarPaciente";
            pnlHeader12.ResumeLayout(false);
            pnlHeader12.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader12;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Button btnverHistorial;
        private Button btnEditarPaciente;
        private Button btnNuevoPaciente;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dgvPacientes;
    }
}