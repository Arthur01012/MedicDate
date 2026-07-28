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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeaderPerfil = new Panel();
            lblTitulo = new Label();
            lblFichaDoctor = new Label();
            dgvFicha = new DataGridView();
            lblHorario = new Label();
            dataGridView2 = new DataGridView();
            pnlHeaderPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFicha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            lblTitulo.Font = new Font("Candara", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Perfil";
            // 
            // lblFichaDoctor
            // 
            lblFichaDoctor.AutoSize = true;
            lblFichaDoctor.BackColor = Color.LightGray;
            lblFichaDoctor.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblFichaDoctor.ForeColor = Color.Black;
            lblFichaDoctor.Location = new Point(12, 52);
            lblFichaDoctor.Name = "lblFichaDoctor";
            lblFichaDoctor.Size = new Size(162, 27);
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
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvFicha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFicha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFicha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFicha.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFicha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFicha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFicha.EnableHeadersVisualStyles = false;
            dgvFicha.GridColor = Color.Gray;
            dgvFicha.Location = new Point(12, 81);
            dgvFicha.MultiSelect = false;
            dgvFicha.Name = "dgvFicha";
            dgvFicha.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFicha.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFicha.RowHeadersVisible = false;
            dgvFicha.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvFicha.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFicha.ScrollBars = ScrollBars.Horizontal;
            dgvFicha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFicha.Size = new Size(958, 150);
            dgvFicha.TabIndex = 28;
            // 
            // lblHorario
            // 
            lblHorario.AccessibleRole = AccessibleRole.MenuPopup;
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Candara", 13F, FontStyle.Bold);
            lblHorario.ForeColor = Color.Black;
            lblHorario.Location = new Point(12, 242);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(82, 27);
            lblHorario.TabIndex = 29;
            lblHorario.Text = "Horario";
            //
            // dataGridView2
            //
            dataGridView2.AllowDrop = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 85, 140);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.Gray;
            dataGridView2.Location = new Point(12, 271);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(166, 202, 236);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.ScrollBars = ScrollBars.Horizontal;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(958, 170);
            dataGridView2.TabIndex = 30;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // frmPerfilDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 453);
            Controls.Add(dataGridView2);
            Controls.Add(lblHorario);
            Controls.Add(dgvFicha);
            Controls.Add(lblFichaDoctor);
            Controls.Add(pnlHeaderPerfil);
            Name = "frmPerfilDoctor";
            Text = "frmPerfilDoctor";
            pnlHeaderPerfil.ResumeLayout(false);
            pnlHeaderPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFicha).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeaderPerfil;
        private Label lblTitulo;
        private Label lblFichaDoctor;
        private DataGridView dgvFicha;
        private Label lblHorario;
        private DataGridView dataGridView2;
    }
}