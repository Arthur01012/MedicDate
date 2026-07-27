namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarAsistente
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pnlHeader5 = new Panel();
            lbAsistente = new Label();
            pnlContenedor2 = new Panel();
            btnDesactivar = new Button();
            btnEditarAsistente = new Button();
            btnNuevoAsistente = new Button();
            dgvAsistentes = new DataGridView();
            lblBuscar1 = new Label();
            txtBuscarAsistente = new TextBox();
            pnlHeader5.SuspendLayout();
            pnlContenedor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistentes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader5
            // 
            pnlHeader5.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader5.Controls.Add(lbAsistente);
            pnlHeader5.Dock = DockStyle.Top;
            pnlHeader5.ForeColor = Color.Black;
            pnlHeader5.Location = new Point(0, 0);
            pnlHeader5.Name = "pnlHeader5";
            pnlHeader5.Size = new Size(1398, 47);
            pnlHeader5.TabIndex = 9;
            // 
            // lbAsistente
            // 
            lbAsistente.AutoSize = true;
            lbAsistente.Font = new Font("Candara", 20F, FontStyle.Bold);
            lbAsistente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAsistente.ForeColor = Color.White;
            lbAsistente.Location = new Point(3, 4);
            lbAsistente.Name = "lbAsistente";
            lbAsistente.Size = new Size(166, 41);
            lbAsistente.Size = new Size(109, 28);
            lbAsistente.TabIndex = 0;
            lbAsistente.Text = "Asistentes";
            // 
            // pnlContenedor2
            // 
            pnlContenedor2.BackColor = Color.LightGray;
            pnlContenedor2.Controls.Add(btnDesactivar);
            pnlContenedor2.Controls.Add(btnEditarAsistente);
            pnlContenedor2.Controls.Add(btnNuevoAsistente);
            pnlContenedor2.Controls.Add(dgvAsistentes);
            pnlContenedor2.Controls.Add(lblBuscar1);
            pnlContenedor2.Controls.Add(txtBuscarAsistente);
            pnlContenedor2.Dock = DockStyle.Fill;
            pnlContenedor2.ForeColor = Color.Black;
            pnlContenedor2.Location = new Point(0, 47);
            pnlContenedor2.Name = "pnlContenedor2";
            pnlContenedor2.Size = new Size(1398, 712);
            pnlContenedor2.TabIndex = 10;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDesactivar.BackColor = Color.FromArgb(176, 11, 11);
            btnDesactivar.FlatStyle = FlatStyle.Popup;
            btnDesactivar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesactivar.ForeColor = Color.White;
            btnDesactivar.Location = new Point(1226, 12);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(148, 45);
            btnDesactivar.TabIndex = 11;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            btnDesactivar.Click += btnDarBaja2_Click;
            // 
            // btnEditarAsistente
            // 
            btnEditarAsistente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarAsistente.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarAsistente.BackgroundImageLayout = ImageLayout.None;
            btnEditarAsistente.FlatStyle = FlatStyle.Popup;
            btnEditarAsistente.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarAsistente.Location = new Point(1022, 31);
            btnEditarAsistente.Name = "btnEditarAsistente";
            btnEditarAsistente.Size = new Size(148, 45);
            btnEditarAsistente.TabIndex = 10;
            btnEditarAsistente.Text = "Editar";
            btnEditarAsistente.UseVisualStyleBackColor = false;
            btnEditarAsistente.Click += btnEditarAsistente_Click;
            // 
            // btnNuevoAsistente
            // 
            btnNuevoAsistente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoAsistente.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoAsistente.FlatStyle = FlatStyle.Popup;
            btnNuevoAsistente.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAsistente.Location = new Point(837, 31);
            btnNuevoAsistente.Name = "btnNuevoAsistente";
            btnNuevoAsistente.Size = new Size(148, 45);
            btnNuevoAsistente.TabIndex = 9;
            btnNuevoAsistente.Text = "Agregar";
            btnNuevoAsistente.UseVisualStyleBackColor = false;
            btnNuevoAsistente.Click += btnNuevoAsistente_Click;
            // 
            // dgvAsistentes
            // 
            dgvAsistentes.AllowUserToAddRows = false;
            dgvAsistentes.AllowUserToDeleteRows = false;
            dgvAsistentes.AllowUserToResizeColumns = false;
            dgvAsistentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAsistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvAsistentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAsistentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAsistentes.BackgroundColor = Color.Gray;
            dgvAsistentes.EnableHeadersVisualStyles = false;
            dgvAsistentes.GridColor = Color.Gray;
            dgvAsistentes.Location = new Point(12, 74);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvAsistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvAsistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Gray;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvAsistentes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvAsistentes.EnableHeadersVisualStyles = false;
            dgvAsistentes.Location = new Point(41, 106);
            dgvAsistentes.MultiSelect = false;
            dgvAsistentes.Name = "dgvAsistentes";
            dgvAsistentes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvAsistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvAsistentes.RowHeadersVisible = false;
            dgvAsistentes.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAsistentes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvAsistentes.Size = new Size(1309, 594);
            dgvAsistentes.TabIndex = 8;
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblBuscar1.Location = new Point(12, 24);
            lblBuscar1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar1.Location = new Point(42, 43);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(81, 27);
            lblBuscar1.TabIndex = 7;
            lblBuscar1.Text = "Buscar:";
            // 
            // txtBuscarAsistente
            // 
            txtBuscarAsistente.BackColor = Color.White;
            txtBuscarAsistente.Font = new Font("Candara", 12F);
            txtBuscarAsistente.ForeColor = Color.Black;
            txtBuscarAsistente.Location = new Point(99, 24);
            txtBuscarAsistente.Name = "txtBuscarAsistente";
            txtBuscarAsistente.PlaceholderText = "Ingrese el nombre del Asistente";
            txtBuscarAsistente.Size = new Size(549, 32);
            txtBuscarAsistente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarAsistente.Location = new Point(107, 40);
            txtBuscarAsistente.Name = "txtBuscarAsistente";
            txtBuscarAsistente.PlaceholderText = "Ingrese el nombre del Asistente";
            txtBuscarAsistente.Size = new Size(549, 30);
            txtBuscarAsistente.TabIndex = 6;
            txtBuscarAsistente.TextChanged += txtBuscarAsistente_TextChanged;
            // 
            // frmRegistrarAsistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 759);
            Controls.Add(pnlContenedor2);
            Controls.Add(pnlHeader5);
            Name = "frmRegistrarAsistente";
            Text = "Administrador";
            pnlHeader5.ResumeLayout(false);
            pnlHeader5.PerformLayout();
            pnlContenedor2.ResumeLayout(false);
            pnlContenedor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader5;
        private Label lbAsistente;
        private Panel pnlContenedor2;
        private Button btnDesactivar;
        private Button btnEditarAsistente;
        private Button btnNuevoAsistente;
        private DataGridView dgvAsistentes;
        private Label lblBuscar1;
        private TextBox txtBuscarAsistente;
    }
}