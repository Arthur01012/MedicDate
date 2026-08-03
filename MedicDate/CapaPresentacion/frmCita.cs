using MedicDate.Datos;
using MedicDate.Procesos;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmCita : Form
    {
        private int? _idCita = null;
        private int _idPacienteSeleccionado = 0;
        private DataTable _dtPacientes;
        private readonly clsCitaNegocio _citaNegocio;

        private DateTime _fechaOriginalCita;
        private TimeSpan _horaOriginalCita;

        public frmCita()
        {
            InitializeComponent();
            _citaNegocio = new clsCitaNegocio();
        }

        public frmCita(int idCita) : this()
        {
            _idCita = idCita;
        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            CargarAutocompletadoPacientes();

            if (_idCita.HasValue)
                CargarDatosCita(_idCita.Value);
        }

        private void CargarDoctores()
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
            cmbDoctor.DataSource = doctores;
            cmbDoctor.DisplayMember = "NombreCompleto";
            cmbDoctor.ValueMember = "id_empleado";
            cmbDoctor.SelectedIndex = -1;
        }

        private void CargarAutocompletadoPacientes()
        {
            _dtPacientes = clsPacienteDAL.ObtenerTodos();
            AutoCompleteStringCollection listaNombres = new AutoCompleteStringCollection();

            foreach (DataRow row in _dtPacientes.Rows)
                listaNombres.Add(row["NombreCompleto"].ToString());

            txtNombrePaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombrePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombrePaciente.AutoCompleteCustomSource = listaNombres;
        }

        private void CargarHorasDisponibles()
        {
            cmbHoraCita.Items.Clear();
            cmbHoraCita.Text = "";
            cmbHoraCita.Enabled = false;

            if (cmbDoctor.SelectedValue == null || dtpFechaCita.Value == null)
                return;

            int idDoctor;
            try
            {
                idDoctor = Convert.ToInt32(cmbDoctor.SelectedValue);
            }
            catch
            {
                if (cmbDoctor.SelectedItem is DataRowView rowView)
                    idDoctor = Convert.ToInt32(rowView["id_empleado"]);
                else
                {
                    cmbHoraCita.Items.Add("Error al identificar al doctor.");
                    return;
                }
            }

            DateTime fecha = dtpFechaCita.Value.Date;
            var resultado = _citaNegocio.ObtenerHorasDisponibles(idDoctor, fecha, _idCita);

            // Variable para almacenar la hora que debe seleccionarse
            string horaSeleccionar = null;

            if (!resultado.DoctorAtiende)
            {
                // Si es edición y la fecha no cambió, mostrar la hora original
                if (_idCita.HasValue && _fechaOriginalCita == fecha)
                {
                    string horaOriginal = _horaOriginalCita.ToString(@"hh\:mm");
                    cmbHoraCita.Items.Add(horaOriginal);
                    cmbHoraCita.Text = horaOriginal;
                    cmbHoraCita.Enabled = true;
                    horaSeleccionar = horaOriginal; // Seleccionar esta hora
                }
                else
                {
                    cmbHoraCita.Items.Add("Sin horario disponible");
                    cmbHoraCita.SelectedIndex = 0;
                    cmbHoraCita.Enabled = false;
                    return;
                }
            }
            else
            {
                cmbHoraCita.Items.AddRange(resultado.HorasDisponibles.ToArray());
                cmbHoraCita.Enabled = true;

                // Si hay hora original de edición, agregarla y seleccionarla
                if (resultado.HoraOriginalEdicion.HasValue)
                {
                    string horaStr = resultado.HoraOriginalEdicion.Value.ToString(@"hh\:mm");
                    if (!cmbHoraCita.Items.Contains(horaStr))
                        cmbHoraCita.Items.Add(horaStr);
                    horaSeleccionar = horaStr; 
                }
                else
                {
                    // Si no hay hora original, seleccionar la primera disponible
                    if (cmbHoraCita.Items.Count > 0)
                        horaSeleccionar = cmbHoraCita.Items[0].ToString();
                }
            }

            
            if (!string.IsNullOrEmpty(horaSeleccionar))
            {
                int idx = cmbHoraCita.FindStringExact(horaSeleccionar);
                if (idx >= 0)
                    cmbHoraCita.SelectedIndex = idx;
                else
                    cmbHoraCita.SelectedIndex = 0; // Fallback: primer elemento
            }
            else if (cmbHoraCita.Items.Count > 0)
            {
                cmbHoraCita.SelectedIndex = 0;
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHorasDisponibles();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            CargarHorasDisponibles();
        }

        private void tctNombrePaciente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                _idPacienteSeleccionado = 0;
                e.Cancel = false;
                return;
            }

            string input = txtNombrePaciente.Text.Trim();
            var foundRows = _dtPacientes.AsEnumerable()
                .Where(r => string.Equals(r["NombreCompleto"].ToString().Trim(), input, StringComparison.OrdinalIgnoreCase))
                .ToList();

            _idPacienteSeleccionado = foundRows.Count > 0 ? Convert.ToInt32(foundRows[0]["id_paciente"]) : 0;
            e.Cancel = false;
        }

        private void CargarDatosCita(int idCita)
        {
            clsCita cita = clsCitaDAL.ObtenerPorId(idCita);
            if (cita == null) return;

            _fechaOriginalCita = cita.fecha;
            _horaOriginalCita = cita.hora;

            txtNombrePaciente.Text = cita.nombre_paciente;
            _idPacienteSeleccionado = cita.id_paciente;

            bool doctorEncontrado = false;
            foreach (DataRowView row in cmbDoctor.Items)
            {
                if (Convert.ToInt32(row["id_empleado"]) == cita.id_doctor)
                {
                    cmbDoctor.SelectedValue = cita.id_doctor;
                    doctorEncontrado = true;
                    break;
                }
            }

            if (!doctorEncontrado)
            {
                cmbDoctor.SelectedIndex = -1;
                MessageBox.Show(
                    $"El doctor de esta cita ({cita.nombre_doctor}) no está activo actualmente.\n\n" +
                    "Si lo desea, puede seleccionar otro doctor para reprogramar la cita.",
                    "Doctor inactivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            dtpFechaCita.Value = cita.fecha;
            txtCosto.Text = cita.costo.HasValue ? cita.costo.Value.ToString("N2") : "";
            txtMotivo.Text = cita.motivo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar paciente
                if (_idPacienteSeleccionado == 0 && !string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
                {
                    string input = txtNombrePaciente.Text.Trim();
                    var foundRows = _dtPacientes.AsEnumerable()
                        .Where(r => string.Equals(r["NombreCompleto"].ToString().Trim(), input, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    if (foundRows.Count > 0)
                        _idPacienteSeleccionado = Convert.ToInt32(foundRows[0]["id_paciente"]);
                }

                if (_idPacienteSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un paciente válido de la lista desplegable.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombrePaciente.Focus();
                    return;
                }

                // 2. Validar doctor
                if (cmbDoctor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un doctor activo.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbDoctor.Focus();
                    return;
                }

                int idDoctor;
                try
                {
                    idDoctor = Convert.ToInt32(cmbDoctor.SelectedValue);
                }
                catch
                {
                    if (cmbDoctor.SelectedItem is DataRowView rowView)
                        idDoctor = Convert.ToInt32(rowView["id_empleado"]);
                    else
                    {
                        MessageBox.Show("Error al obtener el doctor seleccionado.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 3. Validar disponibilidad de horario
                if (!cmbHoraCita.Enabled)
                {
                    if (_idCita.HasValue && _fechaOriginalCita != dtpFechaCita.Value.Date)
                        _citaNegocio.ValidarYPrepararCita(null, _idCita, _fechaOriginalCita, null);
                    else if (!_idCita.HasValue)
                        _citaNegocio.ValidarYPrepararCita(null, null, DateTime.MinValue, null);
                }

                // 4. Validar motivo
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("El motivo es obligatorio.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMotivo.Focus();
                    return;
                }

                // 5. Obtener hora de la cita
                TimeSpan horaCita;
                if (cmbHoraCita.Enabled && !string.IsNullOrWhiteSpace(cmbHoraCita.Text))
                    horaCita = TimeSpan.Parse(cmbHoraCita.Text);
                else
                    horaCita = _horaOriginalCita;

                DateTime fechaCita = dtpFechaCita.Value.Date;

                // 6. Construir objeto cita
                clsCita cita = new clsCita
                {
                    id_paciente = _idPacienteSeleccionado,
                    id_doctor = idDoctor,
                    fecha = fechaCita,
                    hora = horaCita,
                    duracion = 30,
                    motivo = txtMotivo.Text,
                    estado = "Pendiente",
                    costo = string.IsNullOrWhiteSpace(txtCosto.Text) ? (decimal?)null : decimal.Parse(txtCosto.Text),
                    id_registrado_por = Sesion.IdEmpleadoActual
                };

                // 7. Validar y preparar (lanza excepción si hay conflicto)
                _citaNegocio.ValidarYPrepararCita(cita, _idCita, _fechaOriginalCita, _horaOriginalCita);

                // 8. Guardar con la corrección
                bool exito = false;

                if (_idCita.HasValue && _idCita.Value > 0) // EDICIÓN
                {
                    cita.id_cita = _idCita.Value;
                    exito = clsCitaDAL.Actualizar(cita);
                }
                else // NUEVA CITA
                {
                    int idGenerado = clsCitaDAL.Insertar(cita);
                    exito = idGenerado > 0;
                }

                if (exito)
                {
                    MessageBox.Show(_idCita.HasValue ? "Cita actualizada." : "Cita registrada.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}