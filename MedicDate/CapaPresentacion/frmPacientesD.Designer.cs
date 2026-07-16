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
            pnlHeader7 = new Panel();
            lblHorario = new Label();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            pnlHeader7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader7
            // 
            pnlHeader7.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader7.Controls.Add(lblHorario);
            pnlHeader7.Dock = DockStyle.Top;
            pnlHeader7.Location = new Point(0, 0);
            pnlHeader7.Name = "pnlHeader7";
            pnlHeader7.Size = new Size(982, 47);
            pnlHeader7.TabIndex = 11;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.ForeColor = Color.White;
            lblHorario.Location = new Point(25, 9);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(91, 24);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "Pacientes";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtBuscar.Location = new Point(12, 56);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscar.Size = new Size(549, 30);
            txtBuscar.TabIndex = 12;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscarDoctor_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 220);
            dataGridView1.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(12, 339);
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
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(pnlHeader7);
            Name = "frmPacientesD";
            Text = "frmPacientes";
            pnlHeader7.ResumeLayout(false);
            pnlHeader7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader7;
        private Label lblHorario;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private Button btnGuardar;
    }
}