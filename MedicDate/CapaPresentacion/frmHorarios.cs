using MedicDate.Datos;
using MedicDate.Procesos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using System.Windows.Forms;

namespace MedicDate.CapaPresentacion
{
    public partial class frmHorarios : Form
    {
        private int? idHorarioEditando = null; // Para saber si estamos editando
        private bool estadoOriginal; // Guarda el estado original del checkbox 

        public frmHorarios()// Constructor para creación de nuevo horario
        {
            InitializeComponent();
            CargarDoctores();
            ConfigurarDateTimePickers();
            chkActivo.Checked = true;
            chkActivo.Enabled = false; 
                                       

            btnGuardar.Click += btnGuardar_Click;
        }

        
        public frmHorarios(int idHorario) : this()// Constructor para edición (recibe el ID del horario a editar)
        {
            idHorarioEditando = idHorario;// Guardamos el ID del horario que estamos editando
            CargarDatosHorario(idHorario);// Cargamos los datos del horario en los controles
        }

        private void CargarDoctores()// Carga los doctores activos en el ComboBox
        {
            try
            {
                DataTable doctores = clsDoctorDAL.ObtenerDoctoresActivos();
                cmbDoctores.DataSource = doctores;
                cmbDoctores.DisplayMember = "NombreCompleto";
                cmbDoctores.ValueMember = "id_empleado";
                cmbDoctores.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message);
            }
        }

        private void ConfigurarDateTimePickers()// Configura los DateTimePickers para mostrar solo la hora en formato de 12 horas
        {
            dtpInicio.CustomFormat = "hh:mm tt";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.ShowUpDown = true;

            dtpFin.CustomFormat = "hh:mm tt";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.ShowUpDown = true;

            dtpInicio.Value = DateTime.Today.AddHours(8);
            dtpFin.Value = DateTime.Today.AddHours(12);
        }

        private void CargarDatosHorario(int idHorario)// Carga los datos del horario a editar en los controles del formulario
        {
            try
            {
                DataTable dt = clsHorarioDAL.ObtenerHorarioPorId(idHorario);// Obtenemos los datos del horario desde la base de datos
                if (dt.Rows.Count == 0)// Si no se encuentra el horario, mostramos un mensaje y cerramos el formulario
                {
                    MessageBox.Show("Horario no encontrado.");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];// Tomamos la primera fila (debería ser la única)
                int idDoctor = Convert.ToInt32(row["id_doctor"]);// Obtenemos el ID del doctor del horario
                cmbDoctores.SelectedValue = idDoctor;// Seleccionamos el doctor en el ComboBox
                cmbDoctores.Enabled = false; // No se puede cambiar el doctor al editar

                string dia = row["dia_semana"].ToString();// Obtenemos el día de la semana del horario
                MarcarDia(dia);// Marcamos el día correspondiente en los CheckBoxes

                dtpInicio.Value = DateTime.Today.Add(TimeSpan.Parse(row["hora_inicio"].ToString()));// Obtenemos la hora de inicio del horario y la asignamos al DateTimePicker
                dtpFin.Value = DateTime.Today.Add(TimeSpan.Parse(row["hora_fin"].ToString()));// Obtenemos la hora de fin del horario y la asignamos al DateTimePicker
                txtIntervalo.Text = row["intervalo_atencion"].ToString();// Obtenemos el intervalo de atención del horario y lo asignamos al TextBox


                estadoOriginal = Convert.ToBoolean(row["activo"]);//Guardamos el estado original del checkbox para poder restaurarlo si es necesario
                chkActivo.Checked = estadoOriginal;// Asignamos el estado original al checkbox
                chkActivo.Enabled = true; // Habilitado porque estamos editando
                

                btnGuardar.Text = "Actualizar";
                this.Text = "Editar Horario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar horario: " + ex.Message);
            }
        }

        private void MarcarDia(string dia)// Marca el CheckBox correspondiente al día de la semana del horario
        {
            chkLunes.Checked = chkMartes.Checked = chkMiercoles.Checked =
            chkJueves.Checked = chkViernes.Checked = chkSabado.Checked = chkDomingo.Checked = false;// Limpiamos todos los CheckBoxes antes de marcar el correcto

            switch (dia)// Dependiendo del día, marcamos el CheckBox correspondiente
            {
                case "Lunes": chkLunes.Checked = true; break;
                case "Martes": chkMartes.Checked = true; break;
                case "Miércoles": chkMiercoles.Checked = true; break;
                case "Jueves": chkJueves.Checked = true; break;
                case "Viernes": chkViernes.Checked = true; break;
                case "Sábado": chkSabado.Checked = true; break;
                case "Domingo": chkDomingo.Checked = true; break;
            }
        }

        private List<string> ObtenerDiasSeleccionados()// Obtiene una lista de los días de la semana seleccionados en los CheckBoxes
        {
            var dias = new List<string>();// Creamos una lista vacía para almacenar los días seleccionados
            if (chkLunes.Checked) dias.Add("Lunes");
            if (chkMartes.Checked) dias.Add("Martes");
            if (chkMiercoles.Checked) dias.Add("Miércoles");
            if (chkJueves.Checked) dias.Add("Jueves");
            if (chkViernes.Checked) dias.Add("Viernes");
            if (chkSabado.Checked) dias.Add("Sábado");
            if (chkDomingo.Checked) dias.Add("Domingo");
            return dias;// Devolvemos la lista de días seleccionados
        }

        private bool ValidarDatos()// Valida los datos ingresados antes de guardar o actualizar el horario
        {
            if (cmbDoctores.SelectedIndex == -1)// Si no se ha seleccionado un doctor, mostramos un mensaje de advertencia y retornamos false
            {
                MessageBox.Show("Seleccione un doctor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDoctores.Focus();
                return false;
            }

            var dias = ObtenerDiasSeleccionados();// Obtenemos la lista de días seleccionados
            if (dias.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un día de la semana.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (idHorarioEditando.HasValue && dias.Count > 1)// Si estamos editando un horario y se seleccionaron más de un día, mostramos un mensaje de advertencia y retornamos false
            {
                MessageBox.Show("En modo edición solo puede seleccionar un día.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan horaInicio = dtpInicio.Value.TimeOfDay;// Obtenemos la hora de inicio y fin del horario para compararlas
            TimeSpan horaFin = dtpFin.Value.TimeOfDay;// Obtenemos la hora de inicio y fin del horario para compararlas

            if (horaInicio >= horaFin)// Si la hora de inicio es mayor o igual a la hora de fin, mostramos un mensaje de advertencia y retornamos false
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIntervalo.Text, out int intervalo) || intervalo <= 0)// Si el intervalo no es un número entero positivo, mostramos un mensaje de advertencia y retornamos false
            {
                MessageBox.Show("El intervalo debe ser un número entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntervalo.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de guardar o actualizar el horario
        {
            if (!ValidarDatos()) return;// Si los datos no son válidos, salimos del método

            int idDoctor = (int)cmbDoctores.SelectedValue;// Obtenemos el ID del doctor seleccionado
            TimeSpan horaInicio = dtpInicio.Value.TimeOfDay;// Obtenemos la hora de inicio y fin del horario
            TimeSpan horaFin = dtpFin.Value.TimeOfDay;// Obtenemos la hora de inicio y fin del horario
            int intervalo = Convert.ToInt32(txtIntervalo.Text);// Obtenemos el intervalo de atención
            bool activo = chkActivo.Checked;// Obtenemos el estado del checkbox de activo
            var dias = ObtenerDiasSeleccionados();// Obtenemos la lista de días seleccionados

            if (idHorarioEditando.HasValue && dias.Count > 1)// Si estamos editando un horario y se seleccionaron más de un día, mostramos un mensaje de advertencia y retornamos
            {
                MessageBox.Show("En modo edición solo puede seleccionar un día.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conexion = clsConexion.ObtenerConexion();// Obtenemos la conexión a la base de datos
            using var transaccion = conexion.BeginTransaction();// Iniciamos una transacción para asegurar que todas las operaciones se realicen correctamente o se deshagan en caso de error

            try
            {
                if (idHorarioEditando.HasValue)// MODO EDICIÓN 
                {
                    clsHorario horario = new clsHorario// Creamos un objeto clsHorario con los datos ingresados
                    {
                        id_horario = idHorarioEditando.Value,
                        id_doctor = idDoctor,
                        dia_semana = dias[0],
                        hora_inicio = horaInicio,
                        hora_fin = horaFin,
                        intervalo_atencion = intervalo,
                        activo = activo
                    };

                    // Validaciones 0
                    if (clsHorarioDAL.ExisteDuplicadoExacto(idDoctor, dias[0], horaInicio, horaFin, idHorarioEditando))// Verificamos si ya existe un horario idéntico para el mismo doctor y día, excluyendo el horario que estamos editando
                    {
                        MessageBox.Show($"Ya existe un horario idéntico para {dias[0]} en ese rango.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (clsHorarioDAL.ExisteSolapamiento(idDoctor, dias[0], horaInicio, horaFin, idHorarioEditando))// Verificamos si ya existe un horario activo que se solape con el rango de horas ingresado para el mismo doctor y día, excluyendo el horario que estamos editando
                    {
                        MessageBox.Show($"Ya existe un horario activo para {dias[0]} en ese rango.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Actualizar con transacción
                    if (clsHorarioDAL.Actualizar(horario, transaccion))// Intentamos actualizar el horario en la base de datos
                    {
                        transaccion.Commit();
                        MessageBox.Show("Horario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al actualizar el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // MODO NUEVO
                {
                    int insertados = 0;// Contador de horarios insertados correctamente
                    foreach (string dia in dias)// Iteramos sobre cada día seleccionado para crear un horario por cada uno
                    {
                        if (clsHorarioDAL.ExisteDuplicadoExacto(idDoctor, dia, horaInicio, horaFin, null))// Verificamos si ya existe un horario idéntico para el mismo doctor y día
                        {
                            MessageBox.Show($"Ya existe un horario idéntico para {dia} en ese rango. Se omite.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        if (clsHorarioDAL.ExisteSolapamiento(idDoctor, dia, horaInicio, horaFin, null))// Verificamos si ya existe un horario activo que se solape con el rango de horas ingresado para el mismo doctor y día
                        {
                            MessageBox.Show($"Ya existe un horario activo para {dia} en ese rango. Se omite.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        clsHorario horario = new clsHorario// Creamos un objeto clsHorario con los datos ingresados
                        {
                            id_doctor = idDoctor,
                            dia_semana = dia,
                            hora_inicio = horaInicio,
                            hora_fin = horaFin,
                            intervalo_atencion = intervalo,
                            activo = activo
                        };

                        // Insertar con transacción
                        if (clsHorarioDAL.Insertar(horario, transaccion) > 0)
                            insertados++;
                    }

                    transaccion.Commit();

                    if (insertados > 0)
                    {
                        MessageBox.Show($"{insertados} horario(s) guardado(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar ningún horario. Verifique los conflictos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar5_Click(object sender, EventArgs e)// Evento que se dispara al hacer clic en el botón de cancelar, cierra el formulario sin guardar cambios
        {
            this.Close();
        }
    }
}