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

                clsCita cita = clsCitaDAL.ObtenerPorId(_idCita);
                if (cita == null)
                {
                    MessageBox.Show("No se encontró la cita solicitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

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

                txtNotaInterna.Text = cita.notas_internas;

                ActualizarBotones(cita.estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el detalle de la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarBotones(string estadoActual)
        {
            btnIniciarConsulta.Enabled = (estadoActual == "Pendiente" || estadoActual == "Confirmada");
            btnFinalizarConsulta.Enabled = (estadoActual == "En Progreso");
        }

        private void btnIniciarConsulta_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstado("En Progreso", "¿Está seguro de INICIAR la consulta?");
        }

        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            ProcesarCambioEstado("Completada", "¿Está seguro de FINALIZAR la consulta?");
        }

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
                    clsCita citaTemp = clsCitaDAL.ObtenerPorId(_idCita);
                    citaTemp.notas_internas = txtNotaInterna.Text;
                    clsCitaDAL.Actualizar(citaTemp);

                    clsCitaDAL.CambiarEstado(_idCita, nuevoEstado);

                    MessageBox.Show($"Cita actualizada correctamente a '{nuevoEstado}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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