namespace MedicDate.CapaPresentacion
{
    partial class frmReportes
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
            lblTituloReporte = new Label();
            pnlContenedor = new Panel();
            rdbReporteAgenda = new RadioButton();
            lblSubtituloReportes = new Label();
            rdbReporteCitas = new RadioButton();
            rdbReporteIngresos = new RadioButton();
            pnlFiltros = new Panel();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblPeriodo = new Label();
            cmbPeriodo = new ComboBox();
            pnlBotonesFiltro = new Panel();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
            btnExportarPDF = new Button();
            pnlHeader14.SuspendLayout();
            pnlContenedor.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlBotonesFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader14
            // 
            pnlHeader14.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader14.Controls.Add(lblTituloReporte);
            pnlHeader14.Dock = DockStyle.Top;
            pnlHeader14.ForeColor = Color.Black;
            pnlHeader14.Location = new Point(0, 0);
            pnlHeader14.Name = "pnlHeader14";
            pnlHeader14.Size = new Size(1396, 47);
            pnlHeader14.TabIndex = 11;
            // 
            // lblTituloReporte
            // 
            lblTituloReporte.AutoSize = true;
            lblTituloReporte.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloReporte.ForeColor = Color.White;
            lblTituloReporte.Location = new Point(3, -1);
            lblTituloReporte.Name = "lblTituloReporte";
            lblTituloReporte.Size = new Size(162, 46);
            lblTituloReporte.TabIndex = 0;
            lblTituloReporte.Text = "Reportes";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(rdbReporteAgenda);
            pnlContenedor.Controls.Add(lblSubtituloReportes);
            pnlContenedor.Controls.Add(rdbReporteCitas);
            pnlContenedor.Controls.Add(rdbReporteIngresos);
            pnlContenedor.Controls.Add(pnlFiltros);
            pnlContenedor.Controls.Add(dgvReporte);
            pnlContenedor.Controls.Add(btnExportarPDF);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 12;
            // 
            // rdbReporteAgenda
            // 
            rdbReporteAgenda.AutoSize = true;
            rdbReporteAgenda.Font = new Font("Segoe UI", 11F);
            rdbReporteAgenda.Location = new Point(102, 62);
            rdbReporteAgenda.Name = "rdbReporteAgenda";
            rdbReporteAgenda.Size = new Size(279, 29);
            rdbReporteAgenda.TabIndex = 0;
            rdbReporteAgenda.TabStop = true;
            rdbReporteAgenda.Text = "Agenda por Rango de Fechas";
            rdbReporteAgenda.UseVisualStyleBackColor = true;
            rdbReporteAgenda.CheckedChanged += radioReporte_CheckedChanged;
            // 
            // lblSubtituloReportes
            // 
            lblSubtituloReportes.AutoSize = true;
            lblSubtituloReportes.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSubtituloReportes.ForeColor = Color.Black;
            lblSubtituloReportes.Location = new Point(83, 21);
            lblSubtituloReportes.Name = "lblSubtituloReportes";
            lblSubtituloReportes.Size = new Size(643, 30);
            lblSubtituloReportes.TabIndex = 0;
            lblSubtituloReportes.Text = "Seleccione uno de los reportes para consultar la información.";
            // 
            // rdbReporteCitas
            // 
            rdbReporteCitas.AutoSize = true;
            rdbReporteCitas.Font = new Font("Segoe UI", 11F);
            rdbReporteCitas.Location = new Point(102, 100);
            rdbReporteCitas.Name = "rdbReporteCitas";
            rdbReporteCitas.Size = new Size(169, 29);
            rdbReporteCitas.TabIndex = 1;
            rdbReporteCitas.TabStop = true;
            rdbReporteCitas.Text = "Citas por Estado";
            rdbReporteCitas.UseVisualStyleBackColor = true;
            rdbReporteCitas.CheckedChanged += radioReporte_CheckedChanged;
            // 
            // rdbReporteIngresos
            // 
            rdbReporteIngresos.AutoSize = true;
            rdbReporteIngresos.Font = new Font("Segoe UI", 11F);
            rdbReporteIngresos.Location = new Point(102, 138);
            rdbReporteIngresos.Name = "rdbReporteIngresos";
            rdbReporteIngresos.Size = new Size(104, 29);
            rdbReporteIngresos.TabIndex = 2;
            rdbReporteIngresos.TabStop = true;
            rdbReporteIngresos.Text = "Ingresos";
            rdbReporteIngresos.UseVisualStyleBackColor = true;
            rdbReporteIngresos.CheckedChanged += radioReporte_CheckedChanged;
            // 
            // pnlFiltros
            // 
            pnlFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblPeriodo);
            pnlFiltros.Controls.Add(cmbPeriodo);
            pnlFiltros.Controls.Add(pnlBotonesFiltro);
            pnlFiltros.Location = new Point(83, 195);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1231, 60);
            pnlFiltros.TabIndex = 1;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10.2F);
            lblDesde.Location = new Point(0, 18);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(57, 23);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarForeColor = Color.Black;
            dtpDesde.CalendarMonthBackground = Color.White;
            dtpDesde.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpDesde.CalendarTitleForeColor = Color.Black;
            dtpDesde.CalendarTrailingForeColor = Color.Gray;
            dtpDesde.Font = new Font("Segoe UI", 12F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(65, 15);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(160, 34);
            dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10.2F);
            lblHasta.Location = new Point(245, 18);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(53, 23);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarForeColor = Color.Black;
            dtpHasta.CalendarMonthBackground = Color.White;
            dtpHasta.CalendarTitleBackColor = Color.FromArgb(166, 202, 236);
            dtpHasta.CalendarTitleForeColor = Color.Black;
            dtpHasta.CalendarTrailingForeColor = Color.Gray;
            dtpHasta.Font = new Font("Segoe UI", 12F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(305, 15);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(160, 34);
            dtpHasta.TabIndex = 3;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Segoe UI", 10.2F);
            lblPeriodo.Location = new Point(485, 18);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(68, 23);
            lblPeriodo.TabIndex = 4;
            lblPeriodo.Text = "Periodo";
            lblPeriodo.Visible = false;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.BackColor = Color.White;
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodo.Font = new Font("Segoe UI", 12F);
            cmbPeriodo.ForeColor = Color.Black;
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Items.AddRange(new object[] { "Semanal", "Mensual" });
            cmbPeriodo.Location = new Point(560, 15);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(150, 36);
            cmbPeriodo.TabIndex = 5;
            cmbPeriodo.Visible = false;
            // 
            // pnlBotonesFiltro
            // 
            pnlBotonesFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlBotonesFiltro.Controls.Add(btnLimpiar);
            pnlBotonesFiltro.Controls.Add(btnGenerar);
            pnlBotonesFiltro.Location = new Point(906, 9);
            pnlBotonesFiltro.Name = "pnlBotonesFiltro";
            pnlBotonesFiltro.Size = new Size(325, 40);
            pnlBotonesFiltro.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(165, 165, 173);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(12, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar filtros";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(166, 202, 236);
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.Black;
            btnGenerar.Image = Properties.Resources.reportes_black;
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(168, 0);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Padding = new Padding(8, 0, 6, 0);
            btnGenerar.Size = new Size(150, 40);
            btnGenerar.TabIndex = 7;
            btnGenerar.Text = "Generar";
            btnGenerar.TextAlign = ContentAlignment.MiddleRight;
            btnGenerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowDrop = true;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AllowUserToResizeColumns = false;
            dgvReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.GridColor = Color.Gray;
            dgvReporte.Location = new Point(83, 265);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvReporte.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvReporte.ScrollBars = ScrollBars.Horizontal;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1231, 380);
            dgvReporte.TabIndex = 2;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarPDF.BackColor = Color.FromArgb(50, 205, 50);
            btnExportarPDF.FlatStyle = FlatStyle.Popup;
            btnExportarPDF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExportarPDF.ForeColor = Color.Black;
            btnExportarPDF.Image = Properties.Resources.reportes_black;
            btnExportarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarPDF.Location = new Point(1124, 660);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Padding = new Padding(8, 0, 6, 0);
            btnExportarPDF.Size = new Size(190, 40);
            btnExportarPDF.TabIndex = 3;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.TextAlign = ContentAlignment.MiddleRight;
            btnExportarPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader14);
            ForeColor = Color.Black;
            Name = "frmReportes";
            Text = "MedicDate v.1";
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlBotonesFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloReporte;
        private Panel pnlContenedor;
        private Label lblSubtituloReportes;
        private RadioButton rdbReporteIngresos;
        private RadioButton rdbReporteCitas;
        private RadioButton rdbReporteAgenda;
        private Panel pnlFiltros;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Label lblPeriodo;
        private ComboBox cmbPeriodo;
        private Panel pnlBotonesFiltro;
        private Button btnLimpiar;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Button btnExportarPDF;
    }
}