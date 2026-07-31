namespace MedicDate.CapaPresentacion
{
    partial class frmRegistrarCitas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlHeader14 = new Panel();
            lblTituloCitas = new Label();
            pnlContenedor = new Panel();
            btnConfirmarCita = new Button();
            cmbFiltrarDoctor = new ComboBox();
            dgvCitas = new DataGridView();
            btnCancelarCita = new Button();
            btnEditarCita = new Button();
            btnNuevoCita = new Button();
            lblfiltrar = new Label();
            pnlHeader14.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader14
            // 
            pnlHeader14.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader14.Controls.Add(lblTituloCitas);
            pnlHeader14.Dock = DockStyle.Top;
            pnlHeader14.ForeColor = Color.Black;
            pnlHeader14.Location = new Point(0, 0);
            pnlHeader14.Name = "pnlHeader14";
            pnlHeader14.Size = new Size(1396, 47);
            pnlHeader14.TabIndex = 10;
            // 
            // lblTituloCitas
            // 
            lblTituloCitas.AutoSize = true;
            lblTituloCitas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloCitas.ForeColor = Color.White;
            lblTituloCitas.Location = new Point(3, -1);
            lblTituloCitas.Name = "lblTituloCitas";
            lblTituloCitas.Size = new Size(97, 46);
            lblTituloCitas.TabIndex = 0;
            lblTituloCitas.Text = "Citas";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnConfirmarCita);
            pnlContenedor.Controls.Add(cmbFiltrarDoctor);
            pnlContenedor.Controls.Add(dgvCitas);
            pnlContenedor.Controls.Add(btnCancelarCita);
            pnlContenedor.Controls.Add(btnEditarCita);
            pnlContenedor.Controls.Add(btnNuevoCita);
            pnlContenedor.Controls.Add(lblfiltrar);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 11;
            // 
            // btnConfirmarCita
            // 
            btnConfirmarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmarCita.BackColor = Color.LimeGreen;
            btnConfirmarCita.BackgroundImageLayout = ImageLayout.None;
            btnConfirmarCita.FlatStyle = FlatStyle.Popup;
            btnConfirmarCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConfirmarCita.Location = new Point(1071, 13);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(148, 45);
            btnConfirmarCita.TabIndex = 19;
            btnConfirmarCita.Text = "Confirmar";
            btnConfirmarCita.UseVisualStyleBackColor = false;
            btnConfirmarCita.Click += btnConfirmarCita_Click;
            // 
            // cmbFiltrarDoctor
            // 
            cmbFiltrarDoctor.BackColor = Color.White;
            cmbFiltrarDoctor.Font = new Font("Segoe UI", 12F);
            cmbFiltrarDoctor.ForeColor = Color.Black;
            cmbFiltrarDoctor.FormattingEnabled = true;
            cmbFiltrarDoctor.Location = new Point(106, 27);
            cmbFiltrarDoctor.Name = "cmbFiltrarDoctor";
            cmbFiltrarDoctor.Size = new Size(370, 36);
            cmbFiltrarDoctor.TabIndex = 18;
            cmbFiltrarDoctor.SelectedIndexChanged += cmbFiltrarDoctor_SelectedIndexChanged;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowDrop = true;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AllowUserToResizeColumns = false;
            dgvCitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.GridColor = Color.Gray;
            dgvCitas.Location = new Point(18, 79);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvCitas.ScrollBars = ScrollBars.Horizontal;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(1360, 621);
            dgvCitas.TabIndex = 17;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarCita.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelarCita.FlatStyle = FlatStyle.Popup;
            btnCancelarCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelarCita.ForeColor = Color.White;
            btnCancelarCita.Location = new Point(1236, 13);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(148, 45);
            btnCancelarCita.TabIndex = 16;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.UseVisualStyleBackColor = false;
            btnCancelarCita.Click += btnCancelarCita_Click;
            // 
            // btnEditarCita
            // 
            btnEditarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarCita.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarCita.BackgroundImageLayout = ImageLayout.None;
            btnEditarCita.FlatStyle = FlatStyle.Popup;
            btnEditarCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditarCita.Location = new Point(903, 13);
            btnEditarCita.Name = "btnEditarCita";
            btnEditarCita.Size = new Size(148, 45);
            btnEditarCita.TabIndex = 15;
            btnEditarCita.Text = "Editar";
            btnEditarCita.UseVisualStyleBackColor = false;
            btnEditarCita.Click += btnEditarCita_Click;
            // 
            // btnNuevoCita
            // 
            btnNuevoCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoCita.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoCita.FlatStyle = FlatStyle.Popup;
            btnNuevoCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoCita.Location = new Point(737, 13);
            btnNuevoCita.Name = "btnNuevoCita";
            btnNuevoCita.Size = new Size(148, 45);
            btnNuevoCita.TabIndex = 14;
            btnNuevoCita.Text = "Agregar";
            btnNuevoCita.UseVisualStyleBackColor = false;
            btnNuevoCita.Click += btnNuevoCita_Click;
            // 
            // lblfiltrar
            // 
            lblfiltrar.AutoSize = true;
            lblfiltrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblfiltrar.Location = new Point(18, 25);
            lblfiltrar.Name = "lblfiltrar";
            lblfiltrar.Size = new Size(82, 30);
            lblfiltrar.TabIndex = 13;
            lblfiltrar.Text = "Filtrar:";
            // 
            // frmRegistrarCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader14);
            Name = "frmRegistrarCitas";
            Load += frmRegistrarCitas_Load;
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloCitas;
        private Panel pnlContenedor;
        private ComboBox cmbFiltrarDoctor;
        private DataGridView dgvCitas;
        private Button btnCancelarCita;
        private Button btnEditarCita;
        private Button btnNuevoCita;
        private Label lblfiltrar;
        private Button btnConfirmarCita;
    }
}