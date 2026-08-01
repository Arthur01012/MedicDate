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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeader14 = new Panel();
            lblTituloCitas = new Label();
            pnlContenedor = new Panel();
            lstHorasDisponibles = new ListBox();
            lblHorasLibres = new Label();
            dtpFechaCita = new DateTimePicker();
            btnLimpiarFiltro = new Button();
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
            pnlContenedor.Controls.Add(lstHorasDisponibles);
            pnlContenedor.Controls.Add(lblHorasLibres);
            pnlContenedor.Controls.Add(dtpFechaCita);
            pnlContenedor.Controls.Add(btnLimpiarFiltro);
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
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // lstHorasDisponibles
            // 
            lstHorasDisponibles.FormattingEnabled = true;
            lstHorasDisponibles.Location = new Point(152, 67);
            lstHorasDisponibles.Name = "lstHorasDisponibles";
            lstHorasDisponibles.Size = new Size(150, 104);
            lstHorasDisponibles.TabIndex = 23;
            // 
            // lblHorasLibres
            // 
            lblHorasLibres.AutoSize = true;
            lblHorasLibres.Location = new Point(18, 67);
            lblHorasLibres.Name = "lblHorasLibres";
            lblHorasLibres.Size = new Size(128, 20);
            lblHorasLibres.TabIndex = 22;
            lblHorasLibres.Text = "Horas disponibles";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(661, 37);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(250, 27);
            dtpFechaCita.TabIndex = 21;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarFiltro.BackColor = Color.FromArgb(165, 165, 173);
            btnLimpiarFiltro.BackgroundImageLayout = ImageLayout.None;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Popup;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiarFiltro.Location = new Point(482, 28);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(173, 36);
            btnLimpiarFiltro.TabIndex = 20;
            btnLimpiarFiltro.Text = "Limpiar Filtro";
            btnLimpiarFiltro.UseVisualStyleBackColor = false;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // btnConfirmarCita
            // 
            btnConfirmarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmarCita.BackColor = Color.LimeGreen;
            btnConfirmarCita.BackgroundImageLayout = ImageLayout.None;
            btnConfirmarCita.FlatStyle = FlatStyle.Popup;
            btnConfirmarCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConfirmarCita.Image = Properties.Resources.confirmar_cita_black;
            btnConfirmarCita.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarCita.Location = new Point(1071, 13);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Padding = new Padding(8, 0, 6, 0);
            btnConfirmarCita.Size = new Size(148, 45);
            btnConfirmarCita.TabIndex = 19;
            btnConfirmarCita.Text = "Confirmar";
            btnConfirmarCita.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmarCita.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.GridColor = Color.Gray;
            dgvCitas.Location = new Point(18, 179);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvCitas.ScrollBars = ScrollBars.Horizontal;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(1360, 521);
            dgvCitas.TabIndex = 17;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarCita.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelarCita.FlatStyle = FlatStyle.Popup;
            btnCancelarCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelarCita.ForeColor = Color.White;
            btnCancelarCita.Image = Properties.Resources.cancelar_white;
            btnCancelarCita.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarCita.Location = new Point(1236, 13);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Padding = new Padding(8, 0, 6, 0);
            btnCancelarCita.Size = new Size(148, 45);
            btnCancelarCita.TabIndex = 16;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarCita.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnEditarCita.Image = Properties.Resources.editar_black;
            btnEditarCita.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarCita.Location = new Point(903, 13);
            btnEditarCita.Name = "btnEditarCita";
            btnEditarCita.Padding = new Padding(8, 0, 6, 0);
            btnEditarCita.Size = new Size(148, 45);
            btnEditarCita.TabIndex = 15;
            btnEditarCita.Text = "Editar";
            btnEditarCita.TextAlign = ContentAlignment.MiddleRight;
            btnEditarCita.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarCita.UseVisualStyleBackColor = false;
            btnEditarCita.Click += btnEditarCita_Click;
            // 
            // btnNuevoCita
            // 
            btnNuevoCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoCita.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoCita.FlatStyle = FlatStyle.Popup;
            btnNuevoCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoCita.Image = Properties.Resources.nuevo_black;
            btnNuevoCita.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoCita.Location = new Point(737, 13);
            btnNuevoCita.Name = "btnNuevoCita";
            btnNuevoCita.Padding = new Padding(8, 0, 6, 0);
            btnNuevoCita.Size = new Size(148, 45);
            btnNuevoCita.TabIndex = 14;
            btnNuevoCita.Text = "Agregar";
            btnNuevoCita.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoCita.TextImageRelation = TextImageRelation.ImageBeforeText;
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
        private Button btnLimpiarFiltro;
        private DateTimePicker dtpFechaCita;
        private ListBox lstHorasDisponibles;
        private Label lblHorasLibres;
    }
}