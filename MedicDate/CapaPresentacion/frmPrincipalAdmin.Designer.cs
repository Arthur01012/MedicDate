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
            pnlHeaderMedicDate = new Panel();
            lblUsuario = new Label();
            lblTitulo = new Label();
            pnlLateral1 = new Panel();
            btnPerfilD = new Button();
            btnPacientesD = new Button();
            btnAgendaD = new Button();
            btnAgendaGeneralA = new Button();
            btnCitasA = new Button();
            btnPacientesA = new Button();
            label1 = new Label();
            btnCerrar = new Button();
            btnEspecialidades = new Button();
            btnHorarios = new Button();
            btnAsistentes = new Button();
            btnDoctores = new Button();
            pnlContenedor = new Panel();
            pnlHeaderMedicDate.SuspendLayout();
            pnlLateral1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderMedicDate
            // 
            pnlHeaderMedicDate.BackColor = Color.FromArgb(14, 121, 196);
            pnlHeaderMedicDate.Controls.Add(lblUsuario);
            pnlHeaderMedicDate.Controls.Add(lblTitulo);
            pnlHeaderMedicDate.Dock = DockStyle.Top;
            pnlHeaderMedicDate.ForeColor = Color.Black;
            pnlHeaderMedicDate.Location = new Point(0, 0);
            pnlHeaderMedicDate.Name = "pnlHeaderMedicDate";
            pnlHeaderMedicDate.Size = new Size(1582, 47);
            pnlHeaderMedicDate.TabIndex = 7;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(1450, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 30);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 46);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Medic Date";
            // 
            // pnlLateral1
            // 
            pnlLateral1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlLateral1.BackColor = Color.FromArgb(25, 85, 140);
            pnlLateral1.Controls.Add(btnPerfilD);
            pnlLateral1.Controls.Add(btnPacientesD);
            pnlLateral1.Controls.Add(btnAgendaD);
            pnlLateral1.Controls.Add(btnAgendaGeneralA);
            pnlLateral1.Controls.Add(btnCitasA);
            pnlLateral1.Controls.Add(btnPacientesA);
            pnlLateral1.Controls.Add(label1);
            pnlLateral1.Controls.Add(btnCerrar);
            pnlLateral1.Controls.Add(btnEspecialidades);
            pnlLateral1.Controls.Add(btnHorarios);
            pnlLateral1.Controls.Add(btnAsistentes);
            pnlLateral1.Controls.Add(btnDoctores);
            pnlLateral1.Dock = DockStyle.Left;
            pnlLateral1.Location = new Point(0, 47);
            pnlLateral1.Name = "pnlLateral1";
            pnlLateral1.Size = new Size(168, 806);
            pnlLateral1.TabIndex = 8;
            // 
            // btnPerfilD
            // 
            btnPerfilD.BackColor = Color.FromArgb(166, 202, 236);
            btnPerfilD.FlatStyle = FlatStyle.Popup;
            btnPerfilD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerfilD.Location = new Point(12, 651);
            btnPerfilD.Name = "btnPerfilD";
            btnPerfilD.Size = new Size(148, 60);
            btnPerfilD.TabIndex = 2;
            btnPerfilD.Text = "Perfil";
            btnPerfilD.UseVisualStyleBackColor = false;
            // 
            // btnPacientesD
            // 
            btnPacientesD.BackColor = Color.FromArgb(166, 202, 236);
            btnPacientesD.FlatStyle = FlatStyle.Popup;
            btnPacientesD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPacientesD.ForeColor = Color.Black;
            btnPacientesD.Location = new Point(12, 585);
            btnPacientesD.Name = "btnPacientesD";
            btnPacientesD.Size = new Size(148, 60);
            btnPacientesD.TabIndex = 1;
            btnPacientesD.Text = "Pacientes";
            btnPacientesD.UseVisualStyleBackColor = false;
            // 
            // btnAgendaD
            // 
            btnAgendaD.BackColor = Color.FromArgb(166, 202, 236);
            btnAgendaD.FlatStyle = FlatStyle.Popup;
            btnAgendaD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendaD.ForeColor = Color.Black;
            btnAgendaD.Location = new Point(12, 519);
            btnAgendaD.Name = "btnAgendaD";
            btnAgendaD.Size = new Size(148, 60);
            btnAgendaD.TabIndex = 0;
            btnAgendaD.Text = "Agenda";
            btnAgendaD.UseVisualStyleBackColor = false;
            // 
            // btnAgendaGeneralA
            // 
            btnAgendaGeneralA.BackColor = Color.FromArgb(166, 202, 236);
            btnAgendaGeneralA.FlatStyle = FlatStyle.Popup;
            btnAgendaGeneralA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendaGeneralA.ForeColor = Color.Black;
            btnAgendaGeneralA.Location = new Point(10, 453);
            btnAgendaGeneralA.Name = "btnAgendaGeneralA";
            btnAgendaGeneralA.Size = new Size(148, 60);
            btnAgendaGeneralA.TabIndex = 2;
            btnAgendaGeneralA.Text = "Agenda general";
            btnAgendaGeneralA.UseVisualStyleBackColor = false;
            // 
            // btnCitasA
            // 
            btnCitasA.BackColor = Color.FromArgb(166, 202, 236);
            btnCitasA.FlatStyle = FlatStyle.Popup;
            btnCitasA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCitasA.Location = new Point(11, 387);
            btnCitasA.Name = "btnCitasA";
            btnCitasA.Size = new Size(148, 60);
            btnCitasA.TabIndex = 1;
            btnCitasA.Text = "Citas";
            btnCitasA.UseVisualStyleBackColor = false;
            // 
            // btnPacientesA
            // 
            btnPacientesA.BackColor = Color.FromArgb(166, 202, 236);
            btnPacientesA.FlatStyle = FlatStyle.Popup;
            btnPacientesA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientesA.ForeColor = Color.Black;
            btnPacientesA.Location = new Point(10, 321);
            btnPacientesA.Name = "btnPacientesA";
            btnPacientesA.Size = new Size(148, 60);
            btnPacientesA.TabIndex = 0;
            btnPacientesA.Text = "Pacientes";
            btnPacientesA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Modulo";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(176, 11, 11);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            btnEspecialidades.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEspecialidades.ForeColor = Color.Black;
            btnEspecialidades.Location = new Point(10, 255);
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
            btnHorarios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHorarios.ForeColor = Color.Black;
            btnHorarios.Location = new Point(10, 189);
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
            btnAsistentes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAsistentes.ForeColor = Color.Black;
            btnAsistentes.Location = new Point(10, 122);
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
            btnDoctores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDoctores.ForeColor = Color.Black;
            btnDoctores.Location = new Point(10, 55);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(148, 61);
            btnDoctores.TabIndex = 0;
            btnDoctores.Text = "Doctores";
            btnDoctores.UseVisualStyleBackColor = false;
            btnDoctores.Click += btnDoctores_Click;
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
            Controls.Add(pnlHeaderMedicDate);
            Name = "frmPrincipalAdmin";
            Text = "Seccion";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipalAdmin_Load;
            pnlHeaderMedicDate.ResumeLayout(false);
            pnlHeaderMedicDate.PerformLayout();
            pnlLateral1.ResumeLayout(false);
            pnlLateral1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderMedicDate;
        private Panel pnlLateral1;
        private Panel pnlContenedor;
        private Button btnCerrar;
        private Button btnEspecialidades;
        private Button btnHorarios;
        private Button btnAsistentes;
        private Button btnDoctores;
        public Label lblUsuario;
        public Label lblTitulo;
        private Label label1;
        private Button btnPacientesA;
        private Button btnAgendaGeneralA;
        private Button btnCitasA;
        private Button btnPacientesD;
        private Button btnAgendaD;
        private Button btnPerfilD;
    }
}