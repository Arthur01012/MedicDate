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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader14 = new Panel();
            lblTituloCitas = new Label();
            pnlContenedor = new Panel();
            btnConfirmarCita = new Button();
            cmbFiltrarDoctor = new ComboBox();
            dgvPacientes = new DataGridView();
            btnCancelarCita = new Button();
            btnEditarCita = new Button();
            btnNuevoCita = new Button();
            lblfiltrar = new Label();
            pnlHeader14.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
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
            lblTituloCitas.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTituloCitas.ForeColor = Color.White;
            lblTituloCitas.Location = new Point(3, 4);
            lblTituloCitas.Name = "lblTituloCitas";
            lblTituloCitas.Size = new Size(88, 41);
            lblTituloCitas.TabIndex = 0;
            lblTituloCitas.Text = "Citas";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnConfirmarCita);
            pnlContenedor.Controls.Add(cmbFiltrarDoctor);
            pnlContenedor.Controls.Add(dgvPacientes);
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
            btnConfirmarCita.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnConfirmarCita.Location = new Point(1071, 13);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(148, 45);
            btnConfirmarCita.TabIndex = 19;
            btnConfirmarCita.Text = "Confirmar";
            btnConfirmarCita.UseVisualStyleBackColor = false;
            // 
            // cmbFiltrarDoctor
            // 
            cmbFiltrarDoctor.BackColor = Color.White;
            cmbFiltrarDoctor.Font = new Font("Candara", 12F);
            cmbFiltrarDoctor.ForeColor = Color.Black;
            cmbFiltrarDoctor.FormattingEnabled = true;
            cmbFiltrarDoctor.Location = new Point(99, 21);
            cmbFiltrarDoctor.Name = "cmbFiltrarDoctor";
            cmbFiltrarDoctor.Size = new Size(370, 32);
            cmbFiltrarDoctor.TabIndex = 18;
            //
            // dgvPacientes
            //
            dgvPacientes.AllowDrop = true;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = Color.Gray;
            dgvPacientes.Location = new Point(18, 79);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.ScrollBars = ScrollBars.Horizontal;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(1360, 621);
            dgvPacientes.TabIndex = 17;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarCita.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelarCita.FlatStyle = FlatStyle.Popup;
            btnCancelarCita.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnCancelarCita.ForeColor = Color.White;
            btnCancelarCita.Location = new Point(1236, 13);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(148, 45);
            btnCancelarCita.TabIndex = 16;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnEditarCita
            // 
            btnEditarCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarCita.BackColor = Color.FromArgb(165, 165, 173);
            btnEditarCita.BackgroundImageLayout = ImageLayout.None;
            btnEditarCita.FlatStyle = FlatStyle.Popup;
            btnEditarCita.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnEditarCita.Location = new Point(903, 13);
            btnEditarCita.Name = "btnEditarCita";
            btnEditarCita.Size = new Size(148, 45);
            btnEditarCita.TabIndex = 15;
            btnEditarCita.Text = "Editar";
            btnEditarCita.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCita
            // 
            btnNuevoCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoCita.BackColor = Color.FromArgb(166, 202, 236);
            btnNuevoCita.FlatStyle = FlatStyle.Popup;
            btnNuevoCita.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnNuevoCita.Location = new Point(737, 13);
            btnNuevoCita.Name = "btnNuevoCita";
            btnNuevoCita.Size = new Size(148, 45);
            btnNuevoCita.TabIndex = 14;
            btnNuevoCita.Text = "Agregar";
            btnNuevoCita.UseVisualStyleBackColor = false;
            // 
            // lblfiltrar
            // 
            lblfiltrar.AutoSize = true;
            lblfiltrar.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblfiltrar.Location = new Point(18, 25);
            lblfiltrar.Name = "lblfiltrar";
            lblfiltrar.Size = new Size(75, 27);
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
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloCitas;
        private Panel pnlContenedor;
        private ComboBox cmbFiltrarDoctor;
        private DataGridView dgvPacientes;
        private Button btnCancelarCita;
        private Button btnEditarCita;
        private Button btnNuevoCita;
        private Label lblfiltrar;
        private Button btnConfirmarCita;
    }
}