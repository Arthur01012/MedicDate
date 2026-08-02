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
        private int? _idCita = null;// Variable para almacenar el ID de la cita (null si es nueva)
        private int _idPacienteSeleccionado = 0;// Variable para almacenar el ID del paciente seleccionado
        private DataTable _dtPacientes;// Variable para almacenar los datos de los pacientes
        private clsCitaNegocio _citaNegocio; // Instancia de la capa de negocio

        private DateTime _fechaOriginalCita;// Variable para almacenar la fecha original de la cita (para ediciones)
        private TimeSpan _horaOriginalCita;// Variable para almacenar la hora original de la cita (para ediciones)

        public frmCita() // Constructor para nueva cita
        {
            InitializeComponent();
            _citaNegocio = new clsCitaNegocio();
        }

        public frmCita(int idCita)// Constructor para editar cita existente
        {
            InitializeComponent();
            _idCita = idCita;// Guardamos el ID de la cita a editar
            _citaNegocio = new clsCitaNegocio();// Inicializamos la capa de negocio
        }

        private void frmCita_Load(object sender, EventArgs e)// Evento que se ejecuta al cargar el formulario
        {
            CargarDoctores();
            CargarAutocompletadoPacientes();

            if (_idCita.HasValue)
                CargarDatosCita(_idCita.Value);// Cargamos los datos de la cita si es una edición
        }

        private void CargarDoctores()// Método para cargar los doctores activos en el ComboBox
        {
            DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
            cmbDoctor.DataSource = doctores;
            cmbDoctor.DisplayMember = "NombreCompleto";
            cmbDoctor.ValueMember = "id_empleado";
            cmbDoctor.SelectedIndex = -1;
        }

        private void CargarAutocompletadoPacientes()// Método para cargar los nombres de los pacientes en el TextBox con autocompletado
        {
            _dtPacientes = clsPacienteDAL.ObtenerTodos();// Obtenemos todos los pacientes de la base de datos
            AutoCompleteStringCollection listaNombres = new AutoCompleteStringCollection();// Creamos una colección para los nombres de los pacientes
            foreach (DataRow row in _dtPacientes.Rows)// Recorremos cada fila de la tabla de pacientes
                listaNombres.Add(row["NombreCompleto"].ToString());// Agregamos el nombre completo del paciente a la colección

            tctNombrePaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;// Configuramos el modo de autocompletado para sugerir y completar
            tctNombrePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;// Configuramos la fuente de autocompletado para usar una fuente personalizada
            tctNombrePaciente.AutoCompleteCustomSource = listaNombres;// Asignamos la colección de nombres al TextBox
        }

        private void CargarHorasDisponibles()// Método para cargar las horas disponibles según el doctor y la fecha seleccionada
        {
            cmbHoraCita.Items.Clear();
            cmbHoraCita.Text = "";
            cmbHoraCita.Enabled = false;

            if (cmbDoctor.SelectedValue == null || dtpFechaCita.Value == null) return;// Si no hay doctor seleccionado o fecha, salimos del método

            int idDoctor = (int)cmbDoctor.SelectedValue;// Obtenemos el ID del doctor seleccionado
            DateTime fecha = dtpFechaCita.Value.Date;// Obtenemos la fecha seleccionada 


            var resultado = _citaNegocio.ObtenerHorasDisponibles(idDoctor, fecha, _idCita);// Obtenemos las horas disponibles del doctor para la fecha seleccionada

            if (!resultado.DoctorAtiende)// Si el doctor no atiende en la fecha seleccionada, mostramos un mensaje y deshabilitamos el ComboBox
            {

                if (_idCita.HasValue && _fechaOriginalCita == fecha)// Si es una edición y la fecha original coincide con la seleccionada, mostramos la hora original de la cita
                {
                    cmbHoraCita.Items.Add(_horaOriginalCita.ToString(@"hh\:mm"));// Agregamos la hora original de la cita al ComboBox
                    cmbHoraCita.Text = _horaOriginalCita.ToString(@"hh\:mm");// Mostramos la hora original de la cita en el ComboBox
                    cmbHoraCita.Enabled = true;// Habilitamos el ComboBox para permitir la edición de la hora original
                    return;
                }

                cmbHoraCita.Items.Add("Sin horario disponible");// Agregamos un mensaje indicando que no hay horario disponible
                cmbHoraCita.SelectedIndex = 0;// Seleccionamos el mensaje en el ComboBox
                cmbHoraCita.Enabled = false;// Deshabilitamos el ComboBox para evitar la selección de horas
                return;
            }

            cmbHoraCita.Items.AddRange(resultado.HorasDisponibles.ToArray());// Agregamos las horas disponibles al ComboBox
            cmbHoraCita.Enabled = true;// Habilitamos el ComboBox para permitir la selección de horas

            if (resultado.HoraOriginalEdicion.HasValue)// Si hay una hora original de edición, la agregamos al ComboBox y la seleccionamos
            {
                string horaStr = resultado.HoraOriginalEdicion.Value.ToString(@"hh\:mm");// Convertimos la hora original a string en formato hh:mm
                if (!cmbHoraCita.Items.Contains(horaStr))// Si la hora original no está en la lista de horas disponibles, la agregamos al ComboBox
                {
                    cmbHoraCita.Items.Add(horaStr);// Agregamos la hora original al ComboBox
                }
                cmbHoraCita.Text = horaStr;// Mostramos la hora original en el ComboBox
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e) => CargarHorasDisponibles();// Evento que se dispara al cambiar la selección del ComboBox de doctores
        private void dtpFechaCita_ValueChanged(object sender, EventArgs e) => CargarHorasDisponibles();// Evento que se dispara al cambiar la fecha del DateTimePicker

        private void tctNombrePaciente_Validating(object sender, System.ComponentModel.CancelEventArgs e)// Evento que se dispara al validar el TextBox de nombre de paciente
        {
            if (string.IsNullOrWhiteSpace(tctNombrePaciente.Text))// Si el TextBox está vacío, no hacemos nada y salimos del método
            {
                _idPacienteSeleccionado = 0;
                e.Cancel = false; 
                return;
            }

            string input = tctNombrePaciente.Text.Trim();// Obtenemos el texto ingresado en el TextBox y eliminamos espacios en blanco al inicio y al final

            var foundRows = _dtPacientes.AsEnumerable()// Buscamos en la tabla de pacientes una fila que coincida con el nombre ingresado, ignorando mayúsculas y minúsculas
                .Where(r => string.Equals(r["NombreCompleto"].ToString().Trim(), input, StringComparison.OrdinalIgnoreCase))// Comparamos el nombre completo de cada fila con el texto ingresado, ignorando mayúsculas y minúsculas
                .ToList();// Convertimos el resultado a una lista

            if (foundRows.Count > 0)// Si encontramos al menos una coincidencia, obtenemos el ID del paciente de la primera fila encontrada
            {
                _idPacienteSeleccionado = Convert.ToInt32(foundRows[0]["id_paciente"]);
            }
            else
            {
                _idPacienteSeleccionado = 0;
            }

            e.Cancel = false;// No cancelamos la validación, permitiendo que el usuario continúe editando el TextBox
        }

        private void CargarDatosCita(int idCita)// Método para cargar los datos de la cita a editar
        {
            clsCita cita = clsCitaDAL.ObtenerPorId(idCita);// Obtenemos la cita de la base de datos por su ID
            if (cita != null)// Si la cita existe, llenamos los controles del formulario con sus datos
            {
                _fechaOriginalCita = cita.fecha;
                _horaOriginalCita = cita.hora;

                tctNombrePaciente.Text = cita.nombre_paciente;
                _idPacienteSeleccionado = cita.id_paciente;
                cmbDoctor.SelectedValue = cita.id_doctor;
                dtpFechaCita.Value = cita.fecha;
                txtcosto.Text = cita.costo.HasValue ? cita.costo.Value.ToString("N2") : "";// Mostramos el costo de la cita en formato numérico con dos decimales, o vacío si no tiene costo
                txtMotivo.Text = cita.motivo;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de guardar cita
        {
            try
            {
                if (_idPacienteSeleccionado == 0 && !string.IsNullOrWhiteSpace(tctNombrePaciente.Text))// Si no se ha seleccionado un paciente válido, intentamos buscarlo en la lista de pacientes
                {
                    string input = tctNombrePaciente.Text.Trim();// Obtenemos el texto ingresado en el TextBox y eliminamos espacios en blanco al inicio y al final
                    var foundRows = _dtPacientes.AsEnumerable()// Buscamos en la tabla de pacientes una fila que coincida con el nombre ingresado, ignorando mayúsculas y minúsculas
                        .Where(r => string.Equals(r["NombreCompleto"].ToString().Trim(), input, StringComparison.OrdinalIgnoreCase))// Comparamos el nombre completo de cada fila con el texto ingresado, ignorando mayúsculas y minúsculas
                        .ToList();// Convertimos el resultado a una lista

                    if (foundRows.Count > 0)
                    {
                        _idPacienteSeleccionado = Convert.ToInt32(foundRows[0]["id_paciente"]);// Si encontramos al menos una coincidencia, obtenemos el ID del paciente de la primera fila encontrada
                    }
                }

                if (_idPacienteSeleccionado == 0)// Si aún no se ha seleccionado un paciente válido, mostramos un mensaje de advertencia y enfocamos el TextBox de nombre de paciente
                {
                    MessageBox.Show("Seleccione un paciente válido de la lista desplegable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tctNombrePaciente.Focus();
                    return;
                }


                if (cmbDoctor.SelectedValue == null)// Si no se ha seleccionado un doctor, mostramos un mensaje de advertencia y enfocamos el ComboBox de doctores
                {
                    MessageBox.Show("Seleccione un doctor.");
                    cmbDoctor.Focus();
                    return;
                }

                if (!cmbHoraCita.Enabled)// Si el ComboBox de horas de cita está deshabilitado, significa que no hay horas disponibles para la fecha y doctor seleccionados
                {
                    if (_idCita.HasValue && _fechaOriginalCita != dtpFechaCita.Value.Date)
                    {
                        _citaNegocio.ValidarYPrepararCita(null, _idCita, _fechaOriginalCita, null); // Lanza excepción por fallo de validación de horario al cambiar fecha
                    }
                    if (!_idCita.HasValue)
                    {
                        _citaNegocio.ValidarYPrepararCita(null, null, DateTime.MinValue, null); // Lanza excepción en caso de nueva cita sin horario disponible
                    }
                }

                if (string.IsNullOrWhiteSpace(txtMotivo.Text))// Si el motivo de la cita está vacío, mostramos un mensaje de advertencia y enfocamos el TextBox de motivo
                {
                    MessageBox.Show("El motivo es obligatorio.");
                    return;
                }

                TimeSpan horaCita;// Variable para almacenar la hora de la cita
                if (cmbHoraCita.Enabled && !string.IsNullOrWhiteSpace(cmbHoraCita.Text))// Si el ComboBox de horas de cita está habilitado y tiene un valor seleccionado, parseamos la hora seleccionada
                {
                    horaCita = TimeSpan.Parse(cmbHoraCita.Text);
                }
                else
                {
                    horaCita = _horaOriginalCita; // Para ediciones con horario deshabilitado permitido
                }

                int idDoctor = (int)cmbDoctor.SelectedValue;// Obtenemos el ID del doctor seleccionado
                DateTime fechaCita = dtpFechaCita.Value.Date;// Obtenemos la fecha seleccionada para la cita

                clsCita cita = new clsCita// Creamos un objeto de tipo clsCita con los datos ingresados en el formulario
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

                _citaNegocio.ValidarYPrepararCita(cita, _idCita, _fechaOriginalCita, _horaOriginalCita);// Validamos y preparamos la cita antes de guardarla en la base de datos

                if (_idCita.HasValue)// Si estamos editando una cita existente, actualizamos la cita en la base de datos
                {
                    cita.id_cita = _idCita.Value;// Asignamos el ID de la cita al objeto cita para actualizarla correctamente
                    if (clsCitaDAL.Actualizar(cita))// Si la actualización fue exitosa, mostramos un mensaje de éxito y cerramos el formulario
                    {
                        MessageBox.Show("Cita actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (clsCitaDAL.Insertar(cita) > 0)// Si la inserción fue exitosa, mostramos un mensaje de éxito y cerramos el formulario
                    {
                        MessageBox.Show("Cita registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar1_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de cancelar, cierra el formulario sin guardar cambios
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}