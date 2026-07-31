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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader5 = new Panel();
            lbAsistente = new Label();
            pnlContenedor2 = new Panel();
            lblPagina = new Label();
            btnDespues = new Button();
            btnAnterior = new Button();
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
            lbAsistente.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbAsistente.ForeColor = Color.White;
            lbAsistente.Location = new Point(3, -1);
            lbAsistente.Name = "lbAsistente";
            lbAsistente.Size = new Size(182, 46);
            lbAsistente.TabIndex = 0;
            lbAsistente.Text = "Asistentes";
            // 
            // pnlContenedor2
            // 
            pnlContenedor2.BackColor = Color.LightGray;
            pnlContenedor2.Controls.Add(lblPagina);
            pnlContenedor2.Controls.Add(btnDespues);
            pnlContenedor2.Controls.Add(btnAnterior);
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
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPagina.AutoSize = true;
            lblPagina.BackColor = Color.LightGray;
            lblPagina.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagina.ForeColor = Color.Black;
            lblPagina.Location = new Point(1171, 668);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(64, 23);
            lblPagina.TabIndex = 14;
            lblPagina.Text = "Página";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDespues
            // 
            btnDespues.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDespues.BackColor = Color.FromArgb(166, 202, 236);
            btnDespues.FlatStyle = FlatStyle.Popup;
            btnDespues.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDespues.Image = MedicDate.Properties.Resources.siguiente_black;
            btnDespues.ImageAlign = ContentAlignment.MiddleCenter;
            btnDespues.Location = new Point(1295, 652);
            btnDespues.Name = "btnDespues";
            btnDespues.Size = new Size(55, 45);
            btnDespues.TabIndex = 13;
            btnDespues.UseVisualStyleBackColor = false;
            btnDespues.Click += btnDespues_Click;
            //
            // btnAnterior
            //
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.BackColor = Color.FromArgb(166, 202, 236);
            btnAnterior.FlatStyle = FlatStyle.Popup;
            btnAnterior.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Image = MedicDate.Properties.Resources.anterior_black;
            btnAnterior.ImageAlign = ContentAlignment.MiddleCenter;
            btnAnterior.Location = new Point(1093, 652);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(55, 45);
            btnAnterior.TabIndex = 12;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            //
            // btnDesactivar
            //
            btnDesactivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDesactivar.BackColor = Color.FromArgb(176, 11, 11);
            btnDesactivar.FlatStyle = FlatStyle.Popup;
            btnDesactivar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDesactivar.ForeColor = Color.White;
            btnDesactivar.Image = MedicDate.Properties.Resources.desactivar_white;
            btnDesactivar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDesactivar.TextAlign = ContentAlignment.MiddleRight;
            btnDesactivar.Padding = new Padding(8, 0, 6, 0);
            btnDesactivar.Location = new Point(1202, 31);
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
            btnEditarAsistente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarAsistente.Image = MedicDate.Properties.Resources.editar_black;
            btnEditarAsistente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarAsistente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarAsistente.TextAlign = ContentAlignment.MiddleRight;
            btnEditarAsistente.Padding = new Padding(8, 0, 6, 0);
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
            btnNuevoAsistente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoAsistente.Image = MedicDate.Properties.Resources.nuevo_black;
            btnNuevoAsistente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoAsistente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoAsistente.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoAsistente.Padding = new Padding(8, 0, 6, 0);
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
            dgvAsistentes.AllowDrop = true;
            dgvAsistentes.AllowUserToAddRows = false;
            dgvAsistentes.AllowUserToDeleteRows = false;
            dgvAsistentes.AllowUserToResizeColumns = false;
            dgvAsistentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvAsistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsistentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistentes.BackgroundColor = Color.LightGray;
            dgvAsistentes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAsistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistentes.EnableHeadersVisualStyles = false;
            dgvAsistentes.GridColor = Color.Gray;
            dgvAsistentes.Location = new Point(41, 95);
            dgvAsistentes.MultiSelect = false;
            dgvAsistentes.Name = "dgvAsistentes";
            dgvAsistentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAsistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAsistentes.RowHeadersVisible = false;
            dgvAsistentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAsistentes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAsistentes.ScrollBars = ScrollBars.Horizontal;
            dgvAsistentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistentes.Size = new Size(1309, 551);
            dgvAsistentes.TabIndex = 8;
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblBuscar1.Location = new Point(42, 43);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(68, 23);
            lblBuscar1.TabIndex = 7;
            lblBuscar1.Text = "Buscar:";
            // 
            // txtBuscarAsistente
            // 
            txtBuscarAsistente.BackColor = Color.White;
            txtBuscarAsistente.Font = new Font("Segoe UI", 12F);
            txtBuscarAsistente.ForeColor = Color.Black;
            txtBuscarAsistente.Location = new Point(113, 38);
            txtBuscarAsistente.Name = "txtBuscarAsistente";
            txtBuscarAsistente.PlaceholderText = "Ingrese el nombre del Asistente";
            txtBuscarAsistente.Size = new Size(549, 34);
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
        private Label lblPagina;
        private Button btnDespues;
        private Button btnAnterior;
    }
}