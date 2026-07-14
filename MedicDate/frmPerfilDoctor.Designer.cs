namespace MedicDate
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
            pnlHeader2 = new Panel();
            lblTitulo = new Label();
            lblSubDomicilio = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            pnlHeader2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader2
            // 
            pnlHeader2.BackColor = Color.FromArgb(14, 121, 196);
            pnlHeader2.Controls.Add(lblTitulo);
            pnlHeader2.Dock = DockStyle.Top;
            pnlHeader2.Location = new Point(0, 0);
            pnlHeader2.Name = "pnlHeader2";
            pnlHeader2.Size = new Size(982, 47);
            pnlHeader2.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Perfil";
            // 
            // lblSubDomicilio
            // 
            lblSubDomicilio.AutoSize = true;
            lblSubDomicilio.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubDomicilio.Location = new Point(12, 50);
            lblSubDomicilio.Name = "lblSubDomicilio";
            lblSubDomicilio.Size = new Size(170, 28);
            lblSubDomicilio.TabIndex = 27;
            lblSubDomicilio.Text = "Ficha del doctor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 150);
            dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuPopup;
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 29;
            label1.Text = "Horario";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ClientSize = new Size(982, 453);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lblSubDomicilio);
            Controls.Add(pnlHeader2);
            Name = "frmPerfilDoctor";
            Text = "frmPerfilDoctor";
            pnlHeader2.ResumeLayout(false);
            pnlHeader2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader2;
        private Label lblTitulo;
        private Label lblSubDomicilio;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
    }
}