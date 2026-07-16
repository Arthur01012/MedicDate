using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmRegistrarEspecialidad : Form
    {
        public frmRegistrarEspecialidad()
        {
            InitializeComponent();
        }

        private void btnNuevoEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidades frm = new frmEspecialidades();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
