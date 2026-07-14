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
    public partial class frmAsistente : Form
    {
        public frmAsistente()
        {
            InitializeComponent();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
