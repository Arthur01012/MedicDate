using MedicDate.Datos;
using MedicDate.Procesos;
using MySqlConnector;
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
                dtpFecha.Enabled = false;
            }
        }
        private void btnCancelarGeneral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreDoctor.Text) ||
            string.IsNullOrWhiteSpace(txtAPaterno.Text) ||
            string.IsNullOrWhiteSpace(txtUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Completa los campos obligatorios.");
                return;
            }

            using (var conexion = clsConexion.ObtenerConexion())
            {
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    // 1. Crear usuario (llena usuario.id_usuario automáticamente)
                    var usuario = new clsUsuario
                    {
                        usuario = txtUsuario.Text,
                        contrasena = txtPassword.Text, // se encripta dentro de CrearUsuario
                        id_rol = 2, // el id_rol correspondiente a "Doctor"
                        activo = cmbEstado.SelectedItem.ToString() == "Activo" // ajusta según tu tipo de dato real
                    };

                    bool usuarioCreado = clsUsuarioDal.CrearUsuario(usuario, transaccion);
                    if (!usuarioCreado)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("No se pudo crear el usuario.");
                        return;
                    }

                    // 2. Insertar empleado usando el id_usuario recién creado
                    var empleado = new clsEmpleado
                    {
                        nombre = txtNombreDoctor.Text,
                        apellido_paterno = txtAPaterno.Text,
                        apellido_materno = txtAMaterno.Text,
                        fecha_nacimiento = dtpFecha.Value, // ajusta al control real
                        curp = txtCurp.Text,
                        email = txtEmail.Text,
                        telefono_principal = txtTelefono.Text,
                        telefono_secundario = txtTelefonoSecundario?.Text,
                        tipo_empleado = "Doctor",
                        fecha_contratacion = DateTime.Now,
                        estado = true,
                        id_usuario = usuario.id_usuario // <-- viene del paso 1
                    };

                    int idEmpleado = clsEmpleadoDal.Insertar(empleado, transaccion);
                    if (idEmpleado == 0)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("No se pudo crear el empleado.");
                        return;
                    }

                    // 3. Insertar doctor usando el id_empleado recién creado
                    var doctor = new clsDoctor
                    {
                        id_empleado = idEmpleado, // <-- viene del paso 2
                        cedula_profesional = textBox1.Text,
                        especialidad_principal = cmbEspecialidad.SelectedValue as int?,
                        consultorio = txtConsultorio.Text
                    };

                    bool doctorCreado = clsDoctorDal.Insertar(doctor, transaccion);

                    if (doctorCreado)
                    {
                        transaccion.Commit();
                        MessageBox.Show("Doctor guardado correctamente.");
                        this.Close();
                    }
                    else
                    {
                        transaccion.Rollback();
                        MessageBox.Show("No se pudo guardar el doctor.");
                    }
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }*/
    }
}
