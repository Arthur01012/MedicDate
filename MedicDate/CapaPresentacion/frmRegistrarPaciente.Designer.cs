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
            pnlHeaderPacientes = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            dgvPacientes = new DataGridView();
            btnverHistorial = new Button();
            btnEditarPaciente = new Button();
            btnNuevoPaciente = new Button();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
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
            lblTitulo.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 41);
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
            dgvPacientes.BackgroundColor = Color.Gray;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.GridColor = Color.Gray;
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
            btnverHistorial.Font = new Font("Candara", 10.2F, FontStyle.Bold);
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
            btnEditarPaciente.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarPaciente.BackgroundImageLayout = ImageLayout.None;
            btnEditarPaciente.FlatStyle = FlatStyle.Popup;
            btnEditarPaciente.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnEditarPaciente.Location = new Point(1051, 14);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(148, 45);
            btnEditarPaciente.TabIndex = 9;
            btnEditarPaciente.Text = "Editar";
            btnEditarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoPaciente.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoPaciente.FlatStyle = FlatStyle.Popup;
            btnNuevoPaciente.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnNuevoPaciente.Location = new Point(866, 14);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(148, 45);
            btnNuevoPaciente.TabIndex = 8;
            btnNuevoPaciente.Text = "Agregar";
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
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.BackColor = Color.White;
            txtBuscarDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtBuscarDoctor.ForeColor = Color.Black;
            txtBuscarDoctor.Location = new Point(111, 23);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Paciente";
            txtBuscarDoctor.Size = new Size(549, 34);
            txtBuscarDoctor.TabIndex = 6;
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
        private TextBox txtBuscarDoctor;
        private DataGridView dgvPacientes;
    }
}