namespace MedicDate
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
            pnlHeader14 = new Panel();
            lblTituloAgenda = new Label();
            dataGridView1 = new DataGridView();
            lblNotaInterna = new Label();
            txtNotaInterna = new TextBox();
            btnCerrar = new Button();
            btnIniciarConsulta = new Button();
            btnFinalizarConsulta = new Button();
            pnlHeader14.SuspendLayout();
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
            pnlHeader14.Size = new Size(882, 47);
            pnlHeader14.TabIndex = 13;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAgenda.ForeColor = Color.White;
            lblTituloAgenda.Location = new Point(25, 9);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(105, 24);
            lblTituloAgenda.TabIndex = 0;
            lblTituloAgenda.Text = "Detalle cita";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 190);
            dataGridView1.TabIndex = 14;
            // 
            // lblNotaInterna
            // 
            lblNotaInterna.AutoSize = true;
            lblNotaInterna.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotaInterna.Location = new Point(12, 257);
            lblNotaInterna.Name = "lblNotaInterna";
            lblNotaInterna.Size = new Size(115, 24);
            lblNotaInterna.TabIndex = 117;
            lblNotaInterna.Text = "Nota interna";
            // 
            // txtNotaInterna
            // 
            txtNotaInterna.Location = new Point(12, 284);
            txtNotaInterna.Multiline = true;
            txtNotaInterna.Name = "txtNotaInterna";
            txtNotaInterna.Size = new Size(858, 100);
            txtNotaInterna.TabIndex = 118;
            // 
            // btnCerrar
            // 
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
            btnIniciarConsulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            btnFinalizarConsulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            ClientSize = new Size(882, 453);
            Controls.Add(btnFinalizarConsulta);
            Controls.Add(btnIniciarConsulta);
            Controls.Add(btnCerrar);
            Controls.Add(txtNotaInterna);
            Controls.Add(lblNotaInterna);
            Controls.Add(dataGridView1);
            Controls.Add(pnlHeader14);
            Name = "frmDetalleCita";
            Text = "frmDetalleCita";
            pnlHeader14.ResumeLayout(false);
            pnlHeader14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader14;
        private Label lblTituloAgenda;
        private DataGridView dataGridView1;
        private Label lblNotaInterna;
        private TextBox txtNotaInterna;
        private Button btnCerrar;
        private Button btnIniciarConsulta;
        private Button btnFinalizarConsulta;
    }
}