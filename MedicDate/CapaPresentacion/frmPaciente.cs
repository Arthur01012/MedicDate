using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicDate.Datos;
using MedicDate.Helpers;
using MedicDate.Procesos;

namespace MedicDate.CapaPresentacion
{
    public partial class frmPaciente : Form
    {
        // Variables
        private clsPaciente paciente = new clsPaciente();// Instancia de la clase clsPaciente para almacenar los datos del paciente
        private int? idPacienteEditar = null;// Variable para almacenar el ID del paciente a editar, si es necesario

        // Constructor
        public frmPaciente()
        {
            InitializeComponent();
            // Asegura que los manejadores estén registrados

            ConfigurarFormulario();
            CargarMunicipios();
        }

        private void CargarMunicipios()// Carga los municipios en el ComboBox
        {
            try
            {
                DataTable municipios = clsMunicipioDAL.ObtenerMunicipios();

                cmbMunicipio.DataSource = municipios;
                cmbMunicipio.DisplayMember = "nombre";
                cmbMunicipio.ValueMember = "id_municipio";
                cmbMunicipio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar municipios: " + ex.Message);
            }
        }
        
        private void ConfigurarFormulario()// Configuración inicial del formulario
        {
            // No permite seleccionar una fecha mayor a la actual
            dtpFechaRegistro.MaxDate = DateTime.Today;

            // El ComboBox de municipios inicia sin ninguna selección
            cmbMunicipio.SelectedIndex = -1;

            // Coloca el cursor en el primer campo
            tctNombreP.Focus();
        }
        
        private bool ValidarDatos()// Validar datos ingresados
        {
            // Nombre
            if (string.IsNullOrEmpty(tctNombreP.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tctNombreP.Focus();
                return false;
            }

            //Apellido Paterno
            if (string.IsNullOrEmpty(txtAPaterno.Text))
            {
                MessageBox.Show("El apellido paterno es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAPaterno.Focus();
                return false;
            }

            // Verifica que el formato del correo sea válido
            if (!string.IsNullOrEmpty(txtEmal.Text) && !clsValidaciones.EsTelefonoValido(txtEmal.Text))
            {
                MessageBox.Show("El email no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtEmal.Focus();
                return false;
            }

            // Teléfono 
            if (string.IsNullOrEmpty(txtTelefono.Text) && !clsValidaciones.EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }

            
            // Verifica que el número de teléfono secundario
            if (!string.IsNullOrEmpty(txtTelefonoSec.Text) && !clsValidaciones.EsTelefonoValido(txtTelefonoSec.Text))
            {
                MessageBox.Show("El teléfono secundario no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTelefonoSec.Focus();
                return false;
            }

            //Fecha de nacimiento 
            if (dtpFechaRegistro.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFechaRegistro.Focus();
                return false;
            }

            //Calle 
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("La calle es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCalle.Focus();
                return false;
            }

            //Colonia 
            if (string.IsNullOrEmpty(txtColonia.Text))
            {
                MessageBox.Show("La colonia es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtColonia.Focus();
                return false;
            }

            //Numero
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("El número es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNumero.Focus();
                return false;
            }

            //Localidadd
            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                MessageBox.Show("La localidad es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtLocalidad.Focus();
                return false;
            }

            //Municipio
            if (cmbMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un municipio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbMunicipio.Focus();
                return false;
            }

            //Alergias
            if (string.IsNullOrEmpty(txtAlergias.Text))
            {
                MessageBox.Show("El campo Alergias es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAlergias.Focus();
                return false;
            }


            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)// Evento para guardar los datos del paciente
        {
            // Si alguna validación falla, no continúa
            if (!ValidarDatos()) return;

            using var conexion = clsConexion.ObtenerConexion();
            using var transaccion = conexion.BeginTransaction();

            try
            {
                // Datos del paciente
                paciente.nombre = tctNombreP.Text.Trim();
                paciente.apellido_paterno = txtAPaterno.Text.Trim();
                paciente.apellido_materno = txtAMaterno.Text.Trim();
                paciente.email = txtEmal.Text.Trim();
                paciente.telefono_principal = txtTelefono.Text.Trim();
                paciente.telefono_secundario = txtTelefonoSec.Text.Trim();
                paciente.fecha_nacimiento = dtpFechaRegistro.Value;
                // Dirección
                paciente.calle = txtCalle.Text.Trim();
                paciente.colonia = txtColonia.Text.Trim();
                paciente.numero = txtNumero.Text.Trim();
                paciente.localidad = txtLocalidad.Text.Trim();
                paciente.id_municipio = (int?)cmbMunicipio.SelectedValue;
                // Información médica
                paciente.alergias = txtAlergias.Text.Trim();
                paciente.notas_medicas = txtNotas.Text.Trim();

                // Guardar el paciente en la base de datos.
                int idPaciente = clsPacienteDAL.Insertar(paciente, transaccion);

                if (idPaciente > 0)
                {
                    transaccion.Commit();

                    MessageBox.Show("Paciente registrado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                else
                {
                    transaccion.Rollback();

                    MessageBox.Show("No se pudo registrar el paciente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)//si ocurre un error se cansela la transaccion y se muestra un mensaje de error
            {
                transaccion.Rollback();

                MessageBox.Show($"Error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void LimpiarFormulario()// Limpia todos los campos del formulario
        {
            tctNombreP.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtEmal.Clear();
            txtTelefono.Clear();
            dtpFechaRegistro.Value = DateTime.Today;
            txtCalle.Clear();
            txtColonia.Clear();
            txtNumero.Clear();
            txtLocalidad.Clear();
            cmbMunicipio.SelectedIndex = -1;
            txtAlergias.Clear();
            txtNotas.Clear();

            // Regresa el cursor al primer campo

            tctNombreP.Focus();
        }
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

