namespace MedicDate.CapaPresentacion
{
    partial class frmPrincipalAdmin
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
            pnlLateral1 = new Panel();
            btnCerrar = new Button();
            btnEspecialidades = new Button();
            btnHorarios = new Button();
            btnAsistentes = new Button();
            btnDoctores = new Button();
            lblTituloLateral = new Label();
            pnlContenedor = new Panel();
            pnlHeader2.SuspendLayout();
            pnlLateral1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader2
            // 
            pnlHeader2.BackColor = Color.FromArgb(14, 121, 196);
            pnlHeader2.Controls.Add(lblTitulo);
            pnlHeader2.Dock = DockStyle.Top;
            pnlHeader2.Location = new Point(0, 0);
            pnlHeader2.Name = "pnlHeader2";
            pnlHeader2.Size = new Size(1582, 47);
            pnlHeader2.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Administrador";
            // 
            // pnlLateral1
            // 
            pnlLateral1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlLateral1.BackColor = Color.FromArgb(25, 85, 140);
            pnlLateral1.Controls.Add(btnCerrar);
            pnlLateral1.Controls.Add(btnEspecialidades);
            pnlLateral1.Controls.Add(btnHorarios);
            pnlLateral1.Controls.Add(btnAsistentes);
            pnlLateral1.Controls.Add(btnDoctores);
            pnlLateral1.Controls.Add(lblTituloLateral);
            pnlLateral1.Dock = DockStyle.Left;
            pnlLateral1.Location = new Point(0, 47);
            pnlLateral1.Name = "pnlLateral1";
            pnlLateral1.Size = new Size(168, 806);
            pnlLateral1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(176, 11, 11);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(12, 734);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(148, 60);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar sesión";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.BackColor = Color.FromArgb(166, 202, 236);
            btnEspecialidades.FlatStyle = FlatStyle.Popup;
            btnEspecialidades.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEspecialidades.Location = new Point(12, 261);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(148, 60);
            btnEspecialidades.TabIndex = 4;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = false;
            btnEspecialidades.Click += btnEspecialidades_Click_1;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.FromArgb(166, 202, 236);
            btnHorarios.FlatStyle = FlatStyle.Popup;
            btnHorarios.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorarios.Location = new Point(12, 195);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(148, 60);
            btnHorarios.TabIndex = 3;
            btnHorarios.Text = "Horarios";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click_1;
            // 
            // btnAsistentes
            // 
            btnAsistentes.BackColor = Color.FromArgb(166, 202, 236);
            btnAsistentes.FlatStyle = FlatStyle.Popup;
            btnAsistentes.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsistentes.Location = new Point(12, 128);
            btnAsistentes.Name = "btnAsistentes";
            btnAsistentes.Size = new Size(148, 61);
            btnAsistentes.TabIndex = 2;
            btnAsistentes.Text = "Asistentes";
            btnAsistentes.UseVisualStyleBackColor = false;
            btnAsistentes.Click += btnAsistentes_Click_1;
            // 
            // btnDoctores
            // 
            btnDoctores.BackColor = Color.FromArgb(166, 202, 236);
            btnDoctores.FlatStyle = FlatStyle.Popup;
            btnDoctores.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctores.Location = new Point(12, 61);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(148, 61);
            btnDoctores.TabIndex = 0;
            btnDoctores.Text = "Doctores";
            btnDoctores.UseVisualStyleBackColor = false;
            btnDoctores.Click += btnDoctores_Click;
            // 
            // lblTituloLateral
            // 
            lblTituloLateral.AutoSize = true;
            lblTituloLateral.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLateral.ForeColor = Color.White;
            lblTituloLateral.Location = new Point(42, 12);
            lblTituloLateral.Name = "lblTituloLateral";
            lblTituloLateral.Size = new Size(84, 24);
            lblTituloLateral.TabIndex = 1;
            lblTituloLateral.Text = "Modulos";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Location = new Point(166, 47);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1416, 806);
            pnlContenedor.TabIndex = 9;
            // 
            // frmPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1582, 853);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlLateral1);
            Controls.Add(pnlHeader2);
            Name = "frmPrincipalAdmin";
            Text = "Seccion";
            WindowState = FormWindowState.Maximized;
            pnlHeader2.ResumeLayout(false);
            pnlHeader2.PerformLayout();
            pnlLateral1.ResumeLayout(false);
            pnlLateral1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader2;
        private Panel pnlLateral1;
        private Panel pnlContenedor;
        private Label lblTitulo;
        private Label lblTituloLateral;
        private Button btnCerrar;
        private Button btnEspecialidades;
        private Button btnHorarios;
        private Button btnAsistentes;
        private Button btnDoctores;
    }
}