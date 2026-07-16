namespace MedicDate.CapaPresentacion
{
    partial class frmAgendaGeneral
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
            pnlHeader14 = new Panel();
            lblTituloAgenda = new Label();
            pnlContenedor = new Panel();
            lblBuscar = new Label();
            txtBuscarDoctor = new TextBox();
            dataGridView1 = new DataGridView();
            pnlHeader14.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader14
            // 
            pnlHeader14.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader14.Controls.Add(lblTituloAgenda);
            pnlHeader14.Dock = DockStyle.Top;
            pnlHeader14.Location = new Point(0, 0);
            pnlHeader14.Name = "pnlHeader14";
            pnlHeader14.Size = new Size(1396, 47);
            pnlHeader14.TabIndex = 11;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(25, 9);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(146, 24);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Agenda General";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(dataGridView1);
            pnlContenedor.Controls.Add(lblBuscar);
            pnlContenedor.Controls.Add(txtBuscarDoctor);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1396, 712);
            pnlContenedor.TabIndex = 12;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblBuscar.Location = new Point(7, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarDoctor
            // 
            txtBuscarDoctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtBuscarDoctor.Location = new Point(72, 18);
            txtBuscarDoctor.Name = "txtBuscarDoctor";
            txtBuscarDoctor.PlaceholderText = "Ingrese el nombre del Doctor";
            txtBuscarDoctor.Size = new Size(549, 30);
            txtBuscarDoctor.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1372, 633);
            dataGridView1.TabIndex = 10;
            // 
            // frmAgendaGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 759);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader14);
            Name = "frmAgendaGeneral";
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloAgenda;
        private Panel pnlContenedor;
        private Label lblBuscar;
        private TextBox txtBuscarDoctor;
        private DataGridView dataGridView1;
    }
}