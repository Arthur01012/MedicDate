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
    public partial class frmDoctor : Form
    {
        private bool esEdicion = false;

        // Constructor para AGREGAR
        public frmDoctor()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
        }

        // Constructor para EDITAR
        public frmDoctor(bool esEdicion)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;

            this.esEdicion = esEdicion;

            if (esEdicion)
            {
                cmbEstado.Enabled = false;
                dtpFechaRegistro.Enabled = false;
            }
        }
        private void btnCancelarGeneral_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
