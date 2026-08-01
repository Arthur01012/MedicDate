using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // 1. Validar que la sesión esté activa
            if (Sesion.IdEmpleadoActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión como doctor para ver la agenda.",
                                "Sesión no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 2. Configurar fecha por defecto y cargar filtros
            dtpFechaCita.Value = DateTime.Today;
            CargarFiltrosEstados();
            CargarCitas();
        }

        // --- CARGA EL COMBOBOX CON LOS ESTADOS DISPONIBLES ---
        private void CargarFiltrosEstados()
        {
            // Obtenemos la lista de estados desde la Capa de Negocio
            cmbFiltroEstado.DataSource = clsCitaNegocio.ObtenerEstadosCita();
            // Seleccionamos "Todos" por defecto
            cmbFiltroEstado.SelectedIndex = 0;
        }

        // --- CARGA LAS CITAS DEL DOCTOR LOGEADO, FILTRADAS POR FECHA Y ESTADO ---
        private void CargarCitas()
        {
            try
            {
                int idDoctor = Sesion.IdEmpleadoActual; // El ID del doctor logueado
                DateTime fecha = dtpFechaCita.Value.Date;
                string estadoSeleccionado = cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos";

                // Pedimos la agenda filtrada a la Capa de Negocio
                DataTable tabla = clsCitaNegocio.ObtenerAgendaDoctor(idDoctor, fecha, estadoSeleccionado);

                dgvCita.DataSource = tabla;
                dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la agenda del doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- EVENTOS DE CAMBIO DE FECHA O ESTADO ---
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarCitas();
        }

        // --- BOTÓN VER DETALLE ---
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCita.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una cita para ver el detalle.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el ID de la cita de la fila seleccionada
            int idCita = Convert.ToInt32(dgvCita.SelectedRows[0].Cells["id_cita"].Value);

            // Abrimos el formulario de detalle
            frmDetalleCita frm = new frmDetalleCita(idCita);

            // Si el usuario hizo algún cambio y cerró con OK, recargamos la agenda
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCitas();
            }
        }
    }
}