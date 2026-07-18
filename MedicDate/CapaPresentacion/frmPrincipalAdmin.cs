using MedicDate.Procesos;
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
