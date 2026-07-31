using MedicDate.Procesos;
using MedicDate.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmPrincipalAdmin : Form
    {
        clsPrincipal principal;


        public frmPrincipalAdmin()
        {
            InitializeComponent();
            principal = new clsPrincipal();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarDoctor(), pnlContenedor);
        }
        private void btnAsistentes_Click_1(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarAsistente(), pnlContenedor);
        }

        private void btnHorarios_Click_1(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarHorario(), pnlContenedor);
        }

        private void btnEspecialidades_Click_1(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarEspecialidad(), pnlContenedor);
        }

        private void btnPacientesA_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarPaciente(), pnlContenedor);
        }

        private void btnCitasA_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmRegistrarCitas(), pnlContenedor);
        }

        private void btnAgendaGeneralA_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmAgendaGeneral(), pnlContenedor);
        }

        private void btnAgendaD_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmAgenda(), pnlContenedor);
        }

        private void btnPacientesD_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmPacientesD(), pnlContenedor);
        }

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmPerfilDoctor(), pnlContenedor);
        }

        
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                lblUsuario.Text = Sesion.UsuarioActual.nombre_rol;
                ConfigurarMenu();
            }

        }

        private void ConfigurarMenu()
        {
            if (Sesion.UsuarioActual != null)
            {
                // Ocultar todos los botones por defecto
                btnDoctores.Visible = false;
                btnAsistentes.Visible = false;
                btnHorarios.Visible = false;
                btnEspecialidades.Visible = false;
                btnReportes.Visible = false;
                btnPacientesA.Visible = false;
                btnCitasA.Visible = false;
                btnAgendaGeneralA.Visible = false;
                btnAgendaD.Visible = false;
                btnPacientesD.Visible = false;
                btnPerfilD.Visible = false;

                // Mostrar botones según el rol del usuario
                switch (Sesion.UsuarioActual.id_rol)
                {
                    case (int)clsUsuario.Roles.Administrador:
                        btnDoctores.Visible = true;
                        btnDoctores.Location = new Point(10, 55);

                        btnAsistentes.Visible = true;
                        btnAsistentes.Location = new Point(10, 122);

                        btnHorarios.Visible = true;
                        btnHorarios.Location = new Point(10, 189);

                        btnEspecialidades.Visible = true;
                        btnEspecialidades.Location = new Point(10, 256);

                        btnReportes.Visible = true;
                        btnReportes.Location = new Point(10, 323);

                        break;
                    case (int)clsUsuario.Roles.Asistente:
                        btnPacientesA.Visible = true;
                        btnPacientesA.Location = new Point(10, 55); // Ajusta la posición

                        btnCitasA.Visible = true;
                        btnCitasA.Location = new Point(10, 122); // Ajusta la posición

                        btnAgendaGeneralA.Visible = true;
                        btnAgendaGeneralA.Location = new Point(10, 189); // Ajusta la posición

                        break;
                    case (int)clsUsuario.Roles.Doctor:
                        btnAgendaD.Visible = true;
                        btnAgendaD.Location = new Point(10, 55); // Ajusta la posición

                        btnPacientesD.Visible = true;
                        btnPacientesD.Location = new Point(10, 122); // Ajusta la posición

                        btnPerfilD.Visible = true;
                        btnPerfilD.Location = new Point(10, 189); // Ajusta la posición
                        break;
                }
            }
        }
    }
}
