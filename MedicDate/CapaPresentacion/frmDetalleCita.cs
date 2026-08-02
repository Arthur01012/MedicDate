using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;
using MedicDate.Datos;
namespace MedicDate.CapaPresentacion
{
    public partial class frmDetalleCita : Form
    {
        private int _idCita;// Variable para almacenar el ID de la cita

        public frmDetalleCita(int idCita)// Constructor que recibe el ID de la cita
        {
            InitializeComponent();
            _idCita = idCita;
        }

        private void frmDetalleCita_Load(object sender, EventArgs e)// Evento que se ejecuta al cargar el formulario
        {
            CargarDetalle();
        }

        private void CargarDetalle()// Método para cargar el detalle de la cita
        {
            try
            {
                if (_idCita == 0) return;// Si el ID de la cita es 0, no se hace nada

                clsCita cita = clsCitaDAL.ObtenerPorId(_idCita);// Se obtiene la cita por su ID
                if (cita == null)// Si no se encuentra la cita, se muestra un mensaje de error y se cierra el formulario
                {
                    MessageBox.Show("No se encontró la cita solicitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                DataTable tabla = new DataTable();// Se crea una tabla para mostrar los datos de la cita
                // Se agregan las columnas a la tabla
                tabla.Columns.Add("ID", typeof(int));
                tabla.Columns.Add("Fecha", typeof(DateTime));
                tabla.Columns.Add("Hora", typeof(TimeSpan));
                tabla.Columns.Add("Paciente", typeof(string));
                tabla.Columns.Add("Doctor", typeof(string));
                tabla.Columns.Add("Motivo", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Costo", typeof(decimal));
                // Se agrega una fila con los datos de la cita
                DataRow row = tabla.NewRow();
                row["ID"] = cita.id_cita;
                row["Fecha"] = cita.fecha;
                row["Hora"] = cita.hora;
                row["Paciente"] = cita.nombre_paciente;
                row["Doctor"] = cita.nombre_doctor;
                row["Motivo"] = cita.motivo;
                row["Estado"] = cita.estado;
                row["Costo"] = cita.costo.HasValue ? cita.costo.Value : 0;
                tabla.Rows.Add(row);
                // Se asigna la tabla al DataGridView y se configuran sus propiedades
                dgvCitas.DataSource = tabla;// Se asigna la tabla al DataGridView
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Se ajusta el tamaño de las columnas al contenido
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;// Se selecciona toda la fila al hacer clic en una celda
                dgvCitas.ReadOnly = true;// Se hace que el DataGridView sea de solo lectura
                dgvCitas.AllowUserToAddRows = false;// Se desactiva la opción de agregar filas manualmente
                dgvCitas.AllowUserToDeleteRows = false;// Se desactiva la opción de eliminar filas manualmente

                txtNotaInterna.Text = cita.notas_internas;// Se asigna el valor de las notas internas al TextBox

                ActualizarBotones(cita.estado);// Se actualizan los botones según el estado de la cita
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el detalle de la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarBotones(string estadoActual)// Método para habilitar o deshabilitar los botones según el estado de la cita
        {
            btnIniciarConsulta.Enabled = (estadoActual == "Pendiente" || estadoActual == "Confirmada");// Solo se puede iniciar la consulta si está pendiente o confirmada
            btnFinalizarConsulta.Enabled = (estadoActual == "En Progreso");// Solo se puede finalizar la consulta si está en progreso
        }

        private void btnIniciarConsulta_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de iniciar consulta
        {
            ProcesarCambioEstado("En Progreso", "¿Está seguro de INICIAR la consulta?");// Se llama al método para procesar el cambio de estado a "En Progreso"
        }

        private void btnFinalizarConsulta_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de finalizar consulta
        {
            ProcesarCambioEstado("Completada", "¿Está seguro de FINALIZAR la consulta?");// Se llama al método para procesar el cambio de estado a "Completada"
        }

        private void ProcesarCambioEstado(string nuevoEstado, string mensajeConfirmacion)// Método para procesar el cambio de estado de la cita
        {
            DialogResult res = MessageBox.Show(
                $"{mensajeConfirmacion}\n\nLas notas internas se guardarán automáticamente antes de cambiar el estado.",
                "Cambiar estado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            // Se muestra un mensaje de confirmación antes de cambiar el estado
            if (res == DialogResult.Yes)
            {
                try
                {
                    clsCita citaTemp = clsCitaDAL.ObtenerPorId(_idCita);// Se obtiene la cita actual para actualizar las notas internas
                    citaTemp.notas_internas = txtNotaInterna.Text;// Se actualizan las notas internas con el valor del TextBox
                    clsCitaDAL.Actualizar(citaTemp);// Se guarda la cita actualizada en la base de datos

                    clsCitaDAL.CambiarEstado(_idCita, nuevoEstado);// Se cambia el estado de la cita en la base de datos

                    MessageBox.Show($"Cita actualizada correctamente a '{nuevoEstado}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDetalle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de cerrar el formulario
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}