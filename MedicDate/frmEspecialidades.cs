using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicDate
{
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void txtIntervalo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
