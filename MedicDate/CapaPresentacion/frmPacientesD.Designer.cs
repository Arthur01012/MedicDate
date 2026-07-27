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
            pnlHeaderPacientes = new Panel();
            lblPaciente = new Label();
            txtBuscar = new TextBox();
            dgvPacientes = new DataGridView();
            btnGuardar = new Button();
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
            lblPaciente.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblPaciente.ForeColor = Color.White;
            lblPaciente.Location = new Point(3, 3);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(156, 41);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Pacientes";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.Font = new Font("Candara", 12F);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(12, 56);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscar.Size = new Size(549, 32);
            txtBuscar.TabIndex = 12;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscarDoctor_TextChanged;
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = Color.Gray;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.GridColor = Color.Gray;
            dgvPacientes.Location = new Point(12, 99);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(958, 220);
            dgvPacientes.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(840, 339);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Ver Historial";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmPacientesD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 403);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPacientes);
            Controls.Add(txtBuscar);
            Controls.Add(pnlHeaderPacientes);
            ForeColor = Color.Black;
            Name = "frmPacientesD";
            Text = "frmPacientes";
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
        private Button btnGuardar;
    }
}