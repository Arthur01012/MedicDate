using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;
using MedicDate.Datos;
namespace MedicDate.CapaPresentacion
{
    public partial class frmDetalleCita : Form
    {
        private int _idCita;

        // Constructor vacío (por si acaso)
        public frmDetalleCita()
        {
            InitializeComponent();
        }

        // Constructor que recibe el ID de la cita (El que usaremos)
        public frmDetalleCita(int idCita)
        {
            InitializeComponent();
            _idCita = idCita;
        }

        private void frmDetalleCita_Load(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            try
            {
                if (_idCita == 0) return;

                // 1. Obtener los datos de la cita
                clsCita cita = clsCitaDAL.ObtenerPorId(_idCita);
                if (cita == null)
                {
                    MessageBox.Show("No se encontró la cita solicitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 2. Cargar la información en el DataGridView (como una sola fila)
                DataTable tabla = new DataTable();
                tabla.Columns.Add("ID", typeof(int));
                tabla.Columns.Add("Fecha", typeof(DateTime));
                tabla.Columns.Add("Hora", typeof(TimeSpan));
                tabla.Columns.Add("Paciente", typeof(string));
                tabla.Columns.Add("Doctor", typeof(string));
                tabla.Columns.Add("Motivo", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Costo", typeof(decimal));

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

                dgvCitas.DataSource = tabla;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;
                dgvCitas.AllowUserToAddRows = false;
                dgvCitas.AllowUserToDeleteRows = false;

                // 3. Cargar la Nota Interna
                txtNotaInterna.Text = cita.notas_internas;

                // 4. Habilitar/Deshabilitar los botones según el estado actual
                ActualizarBotones(cita.estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el detalle de la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para habilitar o deshabilitar los botones de estado
        private void ActualizarBotones(string estadoActual)
        {
            // Solo se puede iniciar si está Pendiente o Confirmada
            btnIniciarConsulta.Enabled = (estadoActual == "Pendiente" || estadoActual == "Confirmada");
            // Solo se puede finalizar si está En Progreso
            btnFinalizarConsulta.Enabled = (estadoActual == "En Progreso");
        }

        // --- BOTÓN: INICIAR CONSULTA ---
        private void btnIniciarConsulta_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstado("En Progreso", "¿Está seguro de INICIAR la consulta?");
        }

        // --- BOTÓN: FINALIZAR CONSULTA ---
        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstado("Completada", "¿Está seguro de FINALIZAR la consulta?");
        }

        // Método central para manejar el cambio de estado
        private void ProcesarCambioEstado(string nuevoEstado, string mensajeConfirmacion)
        {
            DialogResult res = MessageBox.Show(
                $"{mensajeConfirmacion}\n\nLas notas internas se guardarán automáticamente antes de cambiar el estado.",
                "Cambiar estado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    // 1. Guardamos la nota interna actualizada
                    clsCita citaTemp = clsCitaDAL.ObtenerPorId(_idCita);
                    citaTemp.notas_internas = txtNotaInterna.Text;
                    clsCitaDAL.Actualizar(citaTemp);

                    // 2. Cambiamos el estado
                    clsCitaDAL.CambiarEstado(_idCita, nuevoEstado);

                    MessageBox.Show($"Cita actualizada correctamente a '{nuevoEstado}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargamos para que los botones se actualicen según el nuevo estado
                    CargarDetalle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN: CERRAR ---
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}