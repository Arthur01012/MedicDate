namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarHorario
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
            pnlContenedor = new Panel();
            btnDarBaja3 = new Button();
            btnEditarHorario = new Button();
            btnAsignarHora = new Button();
            dgvHorarios = new DataGridView();
            lblBuscar3 = new Label();
            txtBuscarDoctor1 = new TextBox();
            pnlHeader7.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader7
            // 
            pnlHeader7.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader7.Controls.Add(lblHorario);
            pnlHeader7.Dock = DockStyle.Top;
            pnlHeader7.Location = new Point(0, 0);
            pnlHeader7.Name = "pnlHeader7";
            pnlHeader7.Size = new Size(1398, 47);
            pnlHeader7.TabIndex = 10;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.ForeColor = Color.White;
            lblHorario.Location = new Point(25, 9);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(84, 24);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "Horarios";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnDarBaja3);
            pnlContenedor.Controls.Add(btnEditarHorario);
            pnlContenedor.Controls.Add(btnAsignarHora);
            pnlContenedor.Controls.Add(dgvHorarios);
            pnlContenedor.Controls.Add(lblBuscar3);
            pnlContenedor.Controls.Add(txtBuscarDoctor1);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 11;
            // 
            // btnDarBaja3
            // 
            btnDarBaja3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDarBaja3.BackColor = Color.FromArgb(176, 11, 11);
            btnDarBaja3.FlatStyle = FlatStyle.Popup;
            btnDarBaja3.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja3.ForeColor = Color.White;
            btnDarBaja3.Location = new Point(1226, 12);
            btnDarBaja3.Name = "btnDarBaja3";
            btnDarBaja3.Size = new Size(148, 45);
            btnDarBaja3.TabIndex = 11;
            btnDarBaja3.Text = "Dar de Baja";
            btnDarBaja3.UseVisualStyleBackColor = false;
            // 
            // btnEditarHorario
            // 
            btnEditarHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarHorario.BackColor = Color.LightGray;
            btnEditarHorario.BackgroundImageLayout = ImageLayout.None;
            btnEditarHorario.FlatStyle = FlatStyle.Popup;
            btnEditarHorario.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarHorario.Location = new Point(1046, 12);
            btnEditarHorario.Name = "btnEditarHorario";
            btnEditarHorario.Size = new Size(148, 45);
            btnEditarHorario.TabIndex = 10;
            btnEditarHorario.Text = "Editar Horario";
            btnEditarHorario.UseVisualStyleBackColor = false;
            // 
            // btnAsignarHora
            // 
            btnAsignarHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAsignarHora.BackColor = Color.FromArgb(166, 202, 236);
            btnAsignarHora.FlatStyle = FlatStyle.Popup;
            btnAsignarHora.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarHora.Location = new Point(861, 12);
            btnAsignarHora.Name = "btnAsignarHora";
            btnAsignarHora.Size = new Size(148, 45);
            btnAsignarHora.TabIndex = 9;
            btnAsignarHora.Text = "Asignar Horario";
            btnAsignarHora.UseVisualStyleBackColor = false;
            btnAsignarHora.Click += btnAsignarHora_Click;
            // 
            // dgvHorarios
            // 
            dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.Location = new Point(12, 74);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.RowHeadersWidth = 51;
            dgvHorarios.Size = new Size(1374, 626);
            dgvHorarios.TabIndex = 8;
            // 
            // lblBuscar3
            // 
            lblBuscar3.AutoSize = true;
            lblBuscar3.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar3.Location = new Point(12, 24);
            lblBuscar3.Name = "lblBuscar3";
            lblBuscar3.Size = new Size(63, 21);
            lblBuscar3.TabIndex = 7;
            lblBuscar3.Text = "Buscar:";
            // 
            // txtBuscarDoctor1
            // 
            txtBuscarDoctor1.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarDoctor1.Location = new Point(77, 21);
            txtBuscarDoctor1.Name = "txtBuscarDoctor1";
            txtBuscarDoctor1.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor1.Size = new Size(549, 28);
            txtBuscarDoctor1.TabIndex = 6;
            // 
            // frmRegistrarHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader7);
            Name = "frmRegistrarHorario";
            pnlHeader7.ResumeLayout(false);
            pnlHeader7.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader7;
        private Label lblHorario;
        private Panel pnlContenedor;
        private Button btnDarBaja3;
        private Button btnEditarHorario;
        private Button btnAsignarHora;
        private DataGridView dgvHorarios;
        private Label lblBuscar3;
        private TextBox txtBuscarDoctor1;
    }
}