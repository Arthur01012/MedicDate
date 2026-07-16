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
    public partial class frmRegistrarDoctor : Form
    {
        public frmRegistrarDoctor()
        {
            InitializeComponent();
        }

        private void btnNuevoDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnEditarDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor(true);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
