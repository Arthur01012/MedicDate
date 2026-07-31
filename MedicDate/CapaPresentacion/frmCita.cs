using MedicDate.Datos;
using MedicDate.Procesos;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmCita : Form
    {
        private int? _idCita = null;
        private int _idPacienteSeleccionado = 0;
        private DataTable _dtPacientes;
        private clsCitaNegocio _citaNegocio; // Instancia de la capa de negocio

        // Variables para guardar la cita original en caso de edición
        private DateTime _fechaOriginalCita;
        private TimeSpan _horaOriginalCita;

        public frmCita()
        {
            InitializeComponent();
            _citaNegocio = new clsCitaNegocio();
        }

        public frmCita(int idCita)
        {
            InitializeComponent();
            _idCita = idCita;
            _citaNegocio = new clsCitaNegocio();
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
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
        }

        private void CargarAutocompletadoPacientes()
        {
            _dtPacientes = clsPacienteDAL.ObtenerTodos();
            AutoCompleteStringCollection listaNombres = new AutoCompleteStringCollection();
            foreach (DataRow row in _dtPacientes.Rows)
                listaNombres.Add(row["NombreCompleto"].ToString());

            tctNombrePaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tctNombrePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tctNombrePaciente.AutoCompleteCustomSource = listaNombres;
        }

        private void CargarHorasDisponibles()
        {
            cmbHoraCita.Items.Clear();
            cmbHoraCita.Text = "";
            cmbHoraCita.Enabled = false;

            if (cmbDoctor.SelectedValue == null || dtpFechaCita.Value == null) return;

            int idDoctor = (int)cmbDoctor.SelectedValue;
            DateTime fecha = dtpFechaCita.Value.Date;

            // CONSULTAMOS DIRECTAMENTE A LA CAPA DE NEGOCIO
            var resultado = _citaNegocio.ObtenerHorasDisponibles(idDoctor, fecha, _idCita);

            if (!resultado.DoctorAtiende)
            {
                // Si es edición y la fecha es la original, dejamos que el usuario pueda editar otros campos
                if (_idCita.HasValue && _fechaOriginalCita == fecha)
                {
                    cmbHoraCita.Items.Add(_horaOriginalCita.ToString(@"hh\:mm"));
                    cmbHoraCita.Text = _horaOriginalCita.ToString(@"hh\:mm");
                    cmbHoraCita.Enabled = true;
                    return;
                }

                cmbHoraCita.Items.Add("Sin horario disponible");
                cmbHoraCita.SelectedIndex = 0;
                cmbHoraCita.Enabled = false;
                return;
            }

            cmbHoraCita.Items.AddRange(resultado.HorasDisponibles.ToArray());
            cmbHoraCita.Enabled = true;

            // Si estamos editando y tenemos hora original
            if (resultado.HoraOriginalEdicion.HasValue)
            {
                string horaStr = resultado.HoraOriginalEdicion.Value.ToString(@"hh\:mm");
                if (!cmbHoraCita.Items.Contains(horaStr))
                {
                    cmbHoraCita.Items.Add(horaStr);
                }
                cmbHoraCita.Text = horaStr;
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e) => CargarHorasDisponibles();
        private void dtpFechaCita_ValueChanged(object sender, EventArgs e) => CargarHorasDisponibles();

        private void tctNombrePaciente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tctNombrePaciente.Text)) { _idPacienteSeleccionado = 0; return; }
            foreach (DataRow row in _dtPacientes.Rows)
            {
                if (row["NombreCompleto"].ToString().Trim() == tctNombrePaciente.Text.Trim())
                {
                    _idPacienteSeleccionado = Convert.ToInt32(row["id_paciente"]);
                    return;
                }
            }
            MessageBox.Show("El paciente no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _idPacienteSeleccionado = 0;
            e.Cancel = true;
        }

        private void CargarDatosCita(int idCita)
        {
            clsCita cita = clsCitaDAL.ObtenerPorId(idCita);
            if (cita != null)
            {
                _fechaOriginalCita = cita.fecha;
                _horaOriginalCita = cita.hora;

                tctNombrePaciente.Text = cita.nombre_paciente;
                _idPacienteSeleccionado = cita.id_paciente;
                cmbDoctor.SelectedValue = cita.id_doctor;
                dtpFechaCita.Value = cita.fecha;
                txtcosto.Text = cita.costo.HasValue ? cita.costo.Value.ToString("N2") : "";
                txtMotivo.Text = cita.motivo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idPacienteSeleccionado == 0) { MessageBox.Show("Seleccione un paciente válido."); return; }
                if (cmbDoctor.SelectedValue == null) { MessageBox.Show("Seleccione un doctor."); return; }

                // Usamos la capa de negocio para validar el estado del guardado
                if (!cmbHoraCita.Enabled)
                {
                    if (_idCita.HasValue && _fechaOriginalCita != dtpFechaCita.Value.Date)
                    {
                        _citaNegocio.ValidarYPrepararCita(null, _idCita, _fechaOriginalCita, null); // Lanza excepción por fallo
                    }
                    if (!_idCita.HasValue)
                    {
                        _citaNegocio.ValidarYPrepararCita(null, null, DateTime.MinValue, null); // Lanza excepción
                    }
                }

                if (string.IsNullOrWhiteSpace(txtMotivo.Text)) { MessageBox.Show("El motivo es obligatorio."); return; }

                TimeSpan horaCita;
                if (cmbHoraCita.Enabled && !string.IsNullOrWhiteSpace(cmbHoraCita.Text))
                {
                    horaCita = TimeSpan.Parse(cmbHoraCita.Text);
                }
                else
                {
                    horaCita = _horaOriginalCita; // Para ediciones con horario deshabilitado permitido
                }

                int idDoctor = (int)cmbDoctor.SelectedValue;
                DateTime fechaCita = dtpFechaCita.Value.Date;

                // Crear objeto Cita
                clsCita cita = new clsCita
                {
                    id_paciente = _idPacienteSeleccionado,
                    id_doctor = idDoctor,
                    fecha = fechaCita,
                    hora = horaCita,
                    duracion = 30,
                    motivo = txtMotivo.Text,
                    estado = "Pendiente",
                    costo = string.IsNullOrWhiteSpace(txtcosto.Text) ? (decimal?)null : decimal.Parse(txtcosto.Text),
                    id_registrado_por = Sesion.IdEmpleadoActual
                };

                // Validación final centralizada
                _citaNegocio.ValidarYPrepararCita(cita, _idCita, _fechaOriginalCita, _horaOriginalCita);

                if (_idCita.HasValue)
                {
                    cita.id_cita = _idCita.Value;
                    if (clsCitaDAL.Actualizar(cita))
                    {
                        MessageBox.Show("Cita actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; this.Close();
                    }
                }
                else
                {
                    if (clsCitaDAL.Insertar(cita) > 0)
                    {
                        MessageBox.Show("Cita registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}