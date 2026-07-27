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
            dgvFicha.BackgroundColor = Color.Gray;
            dgvFicha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFicha.GridColor = Color.Gray;
            dgvFicha.Location = new Point(12, 81);
            dgvFicha.Name = "dgvFicha";
            dgvFicha.RowHeadersWidth = 51;
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
            dataGridView2.BackgroundColor = Color.Gray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Gray;
            dataGridView2.Location = new Point(12, 271);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
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