namespace MedicDate
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
            pnlHeader5 = new Panel();
            lbAsistente = new Label();
            pnlContenedor2 = new Panel();
            btnDarBaja2 = new Button();
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
            pnlHeader5.Location = new Point(0, 0);
            pnlHeader5.Name = "pnlHeader5";
            pnlHeader5.Size = new Size(1398, 47);
            pnlHeader5.TabIndex = 9;
            // 
            // lbAsistente
            // 
            lbAsistente.AutoSize = true;
            lbAsistente.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAsistente.ForeColor = Color.White;
            lbAsistente.Location = new Point(25, 9);
            lbAsistente.Name = "lbAsistente";
            lbAsistente.Size = new Size(97, 24);
            lbAsistente.TabIndex = 0;
            lbAsistente.Text = "Asistentes";
            // 
            // pnlContenedor2
            // 
            pnlContenedor2.BackColor = Color.LightGray;
            pnlContenedor2.Controls.Add(btnDarBaja2);
            pnlContenedor2.Controls.Add(btnEditarAsistente);
            pnlContenedor2.Controls.Add(btnNuevoAsistente);
            pnlContenedor2.Controls.Add(dgvAsistentes);
            pnlContenedor2.Controls.Add(lblBuscar1);
            pnlContenedor2.Controls.Add(txtBuscarAsistente);
            pnlContenedor2.Dock = DockStyle.Fill;
            pnlContenedor2.Location = new Point(0, 47);
            pnlContenedor2.Name = "pnlContenedor2";
            pnlContenedor2.Size = new Size(1398, 712);
            pnlContenedor2.TabIndex = 10;
            // 
            // btnDarBaja2
            // 
            btnDarBaja2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDarBaja2.BackColor = Color.FromArgb(176, 11, 11);
            btnDarBaja2.FlatStyle = FlatStyle.Popup;
            btnDarBaja2.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja2.ForeColor = Color.White;
            btnDarBaja2.Location = new Point(1226, 12);
            btnDarBaja2.Name = "btnDarBaja2";
            btnDarBaja2.Size = new Size(148, 45);
            btnDarBaja2.TabIndex = 11;
            btnDarBaja2.Text = "Dar de Baja";
            btnDarBaja2.UseVisualStyleBackColor = false;
            // 
            // btnEditarAsistente
            // 
            btnEditarAsistente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarAsistente.BackColor = Color.LightGray;
            btnEditarAsistente.BackgroundImageLayout = ImageLayout.None;
            btnEditarAsistente.FlatStyle = FlatStyle.Popup;
            btnEditarAsistente.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarAsistente.Location = new Point(1046, 12);
            btnEditarAsistente.Name = "btnEditarAsistente";
            btnEditarAsistente.Size = new Size(148, 45);
            btnEditarAsistente.TabIndex = 10;
            btnEditarAsistente.Text = "Editar Asistente";
            btnEditarAsistente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoAsistente
            // 
            btnNuevoAsistente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoAsistente.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoAsistente.FlatStyle = FlatStyle.Popup;
            btnNuevoAsistente.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAsistente.Location = new Point(861, 12);
            btnNuevoAsistente.Name = "btnNuevoAsistente";
            btnNuevoAsistente.Size = new Size(148, 45);
            btnNuevoAsistente.TabIndex = 9;
            btnNuevoAsistente.Text = "Agrgar Asistente";
            btnNuevoAsistente.UseVisualStyleBackColor = false;
            btnNuevoAsistente.Click += btnNuevoAsistente_Click;
            // 
            // dgvAsistentes
            // 
            dgvAsistentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistentes.Location = new Point(12, 74);
            dgvAsistentes.Name = "dgvAsistentes";
            dgvAsistentes.RowHeadersWidth = 51;
            dgvAsistentes.Size = new Size(1374, 626);
            dgvAsistentes.TabIndex = 8;
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar1.Location = new Point(12, 24);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(63, 21);
            lblBuscar1.TabIndex = 7;
            lblBuscar1.Text = "Buscar:";
            // 
            // txtBuscarAsistente
            // 
            txtBuscarAsistente.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarAsistente.Location = new Point(77, 21);
            txtBuscarAsistente.Name = "txtBuscarAsistente";
            txtBuscarAsistente.PlaceholderText = "Ingrese el nombre del Asistente";
            txtBuscarAsistente.Size = new Size(549, 28);
            txtBuscarAsistente.TabIndex = 6;
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
        private Button btnDarBaja2;
        private Button btnEditarAsistente;
        private Button btnNuevoAsistente;
        private DataGridView dgvAsistentes;
        private Label lblBuscar1;
        private TextBox txtBuscarAsistente;
    }
}