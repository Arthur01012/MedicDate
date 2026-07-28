namespace MedicDate.CapaPresentacion
{
    partial class frmDetalleCita
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
            pnlHeaderCita = new Panel();
            lblTituloAgenda = new Label();
            dgvCitas = new DataGridView();
            lblNotaInterna = new Label();
            txtNotaInterna = new TextBox();
            btnCerrar = new Button();
            btnIniciarConsulta = new Button();
            btnFinalizarConsulta = new Button();
            pnlHeaderCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderCita
            // 
            pnlHeaderCita.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderCita.Controls.Add(lblTituloAgenda);
            pnlHeaderCita.Dock = DockStyle.Top;
            pnlHeaderCita.Font = new Font("Segoe UI", 9F);
            pnlHeaderCita.ForeColor = Color.Black;
            pnlHeaderCita.Location = new Point(0, 0);
            pnlHeaderCita.Name = "pnlHeaderCita";
            pnlHeaderCita.Size = new Size(882, 47);
            pnlHeaderCita.TabIndex = 13;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(3, 3);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(180, 41);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Detalle cita";
            //
            // dgvCitas
            //
            dgvCitas.AllowDrop = true;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AllowUserToResizeColumns = false;
            dgvCitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.GridColor = Color.Gray;
            dgvCitas.Location = new Point(12, 53);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCitas.ScrollBars = ScrollBars.Horizontal;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(858, 190);
            dgvCitas.TabIndex = 14;
            // 
            // lblNotaInterna
            // 
            lblNotaInterna.AutoSize = true;
            lblNotaInterna.Font = new Font("Candara", 10.2F);
            lblNotaInterna.ForeColor = Color.Black;
            lblNotaInterna.Location = new Point(12, 260);
            lblNotaInterna.Name = "lblNotaInterna";
            lblNotaInterna.Size = new Size(100, 21);
            lblNotaInterna.TabIndex = 117;
            lblNotaInterna.Text = "Nota interna";
            // 
            // txtNotaInterna
            // 
            txtNotaInterna.BackColor = Color.White;
            txtNotaInterna.Font = new Font("Candara", 12F);
            txtNotaInterna.ForeColor = Color.Black;
            txtNotaInterna.Location = new Point(12, 284);
            txtNotaInterna.Multiline = true;
            txtNotaInterna.Name = "txtNotaInterna";
            txtNotaInterna.Size = new Size(858, 100);
            txtNotaInterna.TabIndex = 118;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(176, 11, 11);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(398, 397);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 45);
            btnCerrar.TabIndex = 119;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnIniciarConsulta
            // 
            btnIniciarConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciarConsulta.BackColor = Color.DarkGoldenrod;
            btnIniciarConsulta.FlatStyle = FlatStyle.Popup;
            btnIniciarConsulta.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnIniciarConsulta.ForeColor = Color.Black;
            btnIniciarConsulta.Location = new Point(552, 397);
            btnIniciarConsulta.Name = "btnIniciarConsulta";
            btnIniciarConsulta.Size = new Size(148, 45);
            btnIniciarConsulta.TabIndex = 120;
            btnIniciarConsulta.Text = "Iniciar Consulta";
            btnIniciarConsulta.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarConsulta
            // 
            btnFinalizarConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarConsulta.BackColor = Color.LimeGreen;
            btnFinalizarConsulta.BackgroundImageLayout = ImageLayout.None;
            btnFinalizarConsulta.FlatStyle = FlatStyle.Popup;
            btnFinalizarConsulta.Font = new Font("Candara", 10.2F, FontStyle.Bold);
            btnFinalizarConsulta.ForeColor = Color.Black;
            btnFinalizarConsulta.Location = new Point(706, 397);
            btnFinalizarConsulta.Name = "btnFinalizarConsulta";
            btnFinalizarConsulta.Size = new Size(164, 45);
            btnFinalizarConsulta.TabIndex = 121;
            btnFinalizarConsulta.Text = "Finalizar consulta";
            btnFinalizarConsulta.UseVisualStyleBackColor = false;
            // 
            // frmDetalleCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(882, 453);
            Controls.Add(btnFinalizarConsulta);
            Controls.Add(btnIniciarConsulta);
            Controls.Add(btnCerrar);
            Controls.Add(txtNotaInterna);
            Controls.Add(lblNotaInterna);
            Controls.Add(dgvCitas);
            Controls.Add(pnlHeaderCita);
            Name = "frmDetalleCita";
            Text = "frmDetalleCita";
            Load += frmDetalleCita_Load;
            pnlHeaderCita.ResumeLayout(false);
            pnlHeaderCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeaderCita;
        private Label lblTituloAgenda;
        private DataGridView dgvCitas;
        private Label lblNotaInterna;
        private TextBox txtNotaInterna;
        private Button btnCerrar;
        private Button btnIniciarConsulta;
        private Button btnFinalizarConsulta;
    }
}