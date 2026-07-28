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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeaderHorarios = new Panel();
            lblHorario = new Label();
            pnlContenedor = new Panel();
            btnDesactivar = new Button();
            btnEditarHorario = new Button();
            btnAsignarHora = new Button();
            dgvHorarios = new DataGridView();
            lblBuscar3 = new Label();
            txtBuscarDoctor1 = new TextBox();
            pnlHeaderHorarios.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderHorarios
            // 
            pnlHeaderHorarios.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderHorarios.Controls.Add(lblHorario);
            pnlHeaderHorarios.Dock = DockStyle.Top;
            pnlHeaderHorarios.ForeColor = Color.Black;
            pnlHeaderHorarios.Location = new Point(0, 0);
            pnlHeaderHorarios.Name = "pnlHeaderHorarios";
            pnlHeaderHorarios.Size = new Size(1398, 47);
            pnlHeaderHorarios.TabIndex = 10;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHorario.ForeColor = Color.White;
            lblHorario.Location = new Point(3, -1);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(159, 46);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "Horarios";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnDesactivar);
            pnlContenedor.Controls.Add(btnEditarHorario);
            pnlContenedor.Controls.Add(btnAsignarHora);
            pnlContenedor.Controls.Add(dgvHorarios);
            pnlContenedor.Controls.Add(lblBuscar3);
            pnlContenedor.Controls.Add(txtBuscarDoctor1);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1398, 712);
            pnlContenedor.TabIndex = 11;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDesactivar.BackColor = Color.FromArgb(176, 11, 11);
            btnDesactivar.FlatStyle = FlatStyle.Popup;
            btnDesactivar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDesactivar.ForeColor = Color.White;
            btnDesactivar.Location = new Point(1226, 12);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(148, 45);
            btnDesactivar.TabIndex = 11;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnEditarHorario
            // 
            btnEditarHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarHorario.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarHorario.BackgroundImageLayout = ImageLayout.None;
            btnEditarHorario.FlatStyle = FlatStyle.Popup;
            btnEditarHorario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarHorario.ForeColor = Color.Black;
            btnEditarHorario.Location = new Point(1046, 12);
            btnEditarHorario.Name = "btnEditarHorario";
            btnEditarHorario.Size = new Size(148, 45);
            btnEditarHorario.TabIndex = 10;
            btnEditarHorario.Text = "Editar";
            btnEditarHorario.UseVisualStyleBackColor = false;
            btnEditarHorario.Click += btnEditarHorario_Click;
            // 
            // btnAsignarHora
            // 
            btnAsignarHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAsignarHora.BackColor = Color.FromArgb(166, 202, 236);
            btnAsignarHora.FlatStyle = FlatStyle.Popup;
            btnAsignarHora.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAsignarHora.ForeColor = Color.Black;
            btnAsignarHora.Location = new Point(861, 12);
            btnAsignarHora.Name = "btnAsignarHora";
            btnAsignarHora.Size = new Size(148, 45);
            btnAsignarHora.TabIndex = 9;
            btnAsignarHora.Text = "Asignar";
            btnAsignarHora.UseVisualStyleBackColor = false;
            btnAsignarHora.Click += btnAsignarHora_Click;
            // 
            // dgvHorarios
            // 
            dgvHorarios.AllowDrop = true;
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AllowUserToDeleteRows = false;
            dgvHorarios.AllowUserToResizeColumns = false;
            dgvHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorarios.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.EnableHeadersVisualStyles = false;
            dgvHorarios.GridColor = Color.Gray;
            dgvHorarios.Location = new Point(12, 74);
            dgvHorarios.MultiSelect = false;
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHorarios.RowHeadersVisible = false;
            dgvHorarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvHorarios.ScrollBars = ScrollBars.Horizontal;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.Size = new Size(1374, 626);
            dgvHorarios.TabIndex = 8;
            // 
            // lblBuscar3
            // 
            lblBuscar3.AutoSize = true;
            lblBuscar3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBuscar3.ForeColor = Color.Black;
            lblBuscar3.Location = new Point(12, 24);
            lblBuscar3.Name = "lblBuscar3";
            lblBuscar3.Size = new Size(89, 30);
            lblBuscar3.TabIndex = 7;
            lblBuscar3.Text = "Buscar:";
            // 
            // txtBuscarDoctor1
            // 
            txtBuscarDoctor1.BackColor = Color.White;
            txtBuscarDoctor1.Font = new Font("Segoe UI", 12F);
            txtBuscarDoctor1.ForeColor = Color.Black;
            txtBuscarDoctor1.Location = new Point(102, 26);
            txtBuscarDoctor1.Name = "txtBuscarDoctor1";
            txtBuscarDoctor1.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor1.Size = new Size(549, 34);
            txtBuscarDoctor1.TabIndex = 6;
            txtBuscarDoctor1.TextChanged += txtBuscarDoctor1_TextChanged;
            // 
            // frmRegistrarHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeaderHorarios);
            Name = "frmRegistrarHorario";
            pnlHeaderHorarios.ResumeLayout(false);
            pnlHeaderHorarios.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderHorarios;
        private Label lblHorario;
        private Panel pnlContenedor;
        private Button btnDesactivar;
        private Button btnEditarHorario;
        private Button btnAsignarHora;
        private DataGridView dgvHorarios;
        private Label lblBuscar3;
        private TextBox txtBuscarDoctor1;
    }
}