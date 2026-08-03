namespace MedicDate.CapaPresentacion
{
    partial class frmPerfilDoctor
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            pnlHeaderPerfil = new Panel();
            lblTitulo = new Label();
            lblFichaDoctor = new Label();
            dgvFicha = new DataGridView();
            lblHorario = new Label();
            dgvHorario = new DataGridView();
            pnlHeaderPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFicha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderPerfil
            // 
            pnlHeaderPerfil.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeaderPerfil.Controls.Add(lblTitulo);
            pnlHeaderPerfil.Dock = DockStyle.Top;
            pnlHeaderPerfil.ForeColor = Color.Black;
            pnlHeaderPerfil.Location = new Point(0, 0);
            pnlHeaderPerfil.Name = "pnlHeaderPerfil";
            pnlHeaderPerfil.Size = new Size(982, 47);
            pnlHeaderPerfil.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, -2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Perfil";
            // 
            // lblFichaDoctor
            // 
            lblFichaDoctor.AutoSize = true;
            lblFichaDoctor.BackColor = Color.LightGray;
            lblFichaDoctor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFichaDoctor.ForeColor = Color.Black;
            lblFichaDoctor.Location = new Point(12, 49);
            lblFichaDoctor.Name = "lblFichaDoctor";
            lblFichaDoctor.Size = new Size(179, 30);
            lblFichaDoctor.TabIndex = 27;
            lblFichaDoctor.Text = "Ficha del doctor";
            // 
            // dgvFicha
            // 
            dgvFicha.AllowDrop = true;
            dgvFicha.AllowUserToAddRows = false;
            dgvFicha.AllowUserToDeleteRows = false;
            dgvFicha.AllowUserToResizeColumns = false;
            dgvFicha.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dgvFicha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvFicha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFicha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFicha.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvFicha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvFicha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFicha.EnableHeadersVisualStyles = false;
            dgvFicha.GridColor = Color.Gray;
            dgvFicha.Location = new Point(12, 81);
            dgvFicha.MultiSelect = false;
            dgvFicha.Name = "dgvFicha";
            dgvFicha.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvFicha.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvFicha.RowHeadersVisible = false;
            dgvFicha.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvFicha.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvFicha.ScrollBars = ScrollBars.Horizontal;
            dgvFicha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFicha.Size = new Size(958, 150);
            dgvFicha.TabIndex = 28;
            // 
            // lblHorario
            // 
            lblHorario.AccessibleRole = AccessibleRole.MenuPopup;
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHorario.ForeColor = Color.Black;
            lblHorario.Location = new Point(12, 239);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(92, 30);
            lblHorario.TabIndex = 29;
            lblHorario.Text = "Horario";
            // 
            // dgvHorario
            // 
            dgvHorario.AllowDrop = true;
            dgvHorario.AllowUserToAddRows = false;
            dgvHorario.AllowUserToDeleteRows = false;
            dgvHorario.AllowUserToResizeColumns = false;
            dgvHorario.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.LightGray;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dgvHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorario.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorario.EnableHeadersVisualStyles = false;
            dgvHorario.GridColor = Color.Gray;
            dgvHorario.Location = new Point(12, 271);
            dgvHorario.MultiSelect = false;
            dgvHorario.Name = "dgvHorario";
            dgvHorario.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvHorario.RowHeadersVisible = false;
            dgvHorario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvHorario.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvHorario.ScrollBars = ScrollBars.Horizontal;
            dgvHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorario.Size = new Size(958, 170);
            dgvHorario.TabIndex = 30;
            // 
            // frmPerfilDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 453);
            Controls.Add(dgvHorario);
            Controls.Add(lblHorario);
            Controls.Add(dgvFicha);
            Controls.Add(lblFichaDoctor);
            Controls.Add(pnlHeaderPerfil);
            ForeColor = Color.Black;
            Name = "frmPerfilDoctor";
            Text = "MedicDate v.1";
            Load += frmPerfilDoctor_Load;
            pnlHeaderPerfil.ResumeLayout(false);
            pnlHeaderPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFicha).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeaderPerfil;
        private Label lblTitulo;
        private Label lblFichaDoctor;
        private DataGridView dgvFicha;
        private Label lblHorario;
        private DataGridView dgvHorario;
    }
}