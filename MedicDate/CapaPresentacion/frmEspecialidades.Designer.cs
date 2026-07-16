namespace MedicDate.CapaPresentacion
{
    partial class frmEspecialidades
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
            pnlHeader8 = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnGuardar = new Button();
            btnCancelar5 = new Button();
            textBox1 = new TextBox();
            lblDescripcion = new Label();
            txtEspecialidad = new TextBox();
            lblNombreEspecialidad = new Label();
            pnlHeader8.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader8
            // 
            pnlHeader8.BackColor = Color.FromArgb(25, 85, 140);
            pnlHeader8.Controls.Add(lblTitulo);
            pnlHeader8.Dock = DockStyle.Top;
            pnlHeader8.Location = new Point(0, 0);
            pnlHeader8.Name = "pnlHeader8";
            pnlHeader8.Size = new Size(680, 55);
            pnlHeader8.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 26.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(207, -2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Especialidades";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.LightGray;
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnCancelar5);
            pnlContenedor.Controls.Add(textBox1);
            pnlContenedor.Controls.Add(lblDescripcion);
            pnlContenedor.Controls.Add(txtEspecialidad);
            pnlContenedor.Controls.Add(lblNombreEspecialidad);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 55);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(680, 375);
            pnlContenedor.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(166, 202, 236);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(538, 300);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 52);
            btnGuardar.TabIndex = 119;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar5
            // 
            btnCancelar5.BackColor = Color.FromArgb(176, 11, 11);
            btnCancelar5.FlatStyle = FlatStyle.Popup;
            btnCancelar5.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar5.ForeColor = Color.White;
            btnCancelar5.Location = new Point(371, 300);
            btnCancelar5.Name = "btnCancelar5";
            btnCancelar5.Size = new Size(130, 52);
            btnCancelar5.TabIndex = 118;
            btnCancelar5.Text = "Cancelar";
            btnCancelar5.UseVisualStyleBackColor = false;
            btnCancelar5.Click += btnCancelar5_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(656, 142);
            textBox1.TabIndex = 117;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(12, 95);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(107, 24);
            lblDescripcion.TabIndex = 116;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(12, 46);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(656, 32);
            txtEspecialidad.TabIndex = 115;
            txtEspecialidad.TextChanged += txtIntervalo_TextChanged;
            // 
            // lblNombreEspecialidad
            // 
            lblNombreEspecialidad.AutoSize = true;
            lblNombreEspecialidad.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEspecialidad.Location = new Point(12, 22);
            lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            lblNombreEspecialidad.Size = new Size(78, 24);
            lblNombreEspecialidad.TabIndex = 114;
            lblNombreEspecialidad.Text = "Nombre";
            // 
            // frmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 430);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader8);
            Name = "frmEspecialidades";
            Text = "frmEspecialidades";
            pnlHeader8.ResumeLayout(false);
            pnlHeader8.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader8;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private TextBox txtEspecialidad;
        private Label lblNombreEspecialidad;
        private TextBox textBox1;
        private Label lblDescripcion;
        private Button btnGuardar;
        private Button btnCancelar5;
    }
}