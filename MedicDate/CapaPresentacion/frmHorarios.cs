using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MedicDate.Datos;
using MedicDate.Procesos;

namespace MedicDate.CapaPresentacion
{
    public partial class frmHorarios : Form
    {
        private int? idHorarioEditando = null; // Para saber si estamos editando

        public frmHorarios()
        {
            InitializeComponent();
            CargarDoctores();
            ConfigurarDateTimePickers();
            btnGuardar.Click += btnGuardar_Click;
        }

        // Constructor para edición (recibe el ID del horario a editar)
        public frmHorarios(int idHorario) : this()
        {
            idHorarioEditando = idHorario;
            CargarDatosHorario(idHorario);
        }

        private void CargarDoctores()
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

        private void ConfigurarDateTimePickers()
        {
            // Configurar para que solo muestren la hora en formato 12h
            dtpInicio.CustomFormat = "hh:mm tt";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.ShowUpDown = true;

            dtpFin.CustomFormat = "hh:mm tt";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.ShowUpDown = true;

            // Valores por defecto
            dtpInicio.Value = DateTime.Today.AddHours(8); // 8:00 AM
            dtpFin.Value = DateTime.Today.AddHours(12); // 12:00 PM
        }

        private void CargarDatosHorario(int idHorario)
        {
            try
            {
                // Obtener el horario por ID
                DataTable dt = clsHorarioDAL.ObtenerHorarioPorId(idHorario);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Horario no encontrado.");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];
                int idDoctor = Convert.ToInt32(row["id_doctor"]);
                cmbDoctores.SelectedValue = idDoctor;
                cmbDoctores.Enabled = false; // No se puede cambiar el doctor al editar

                // Marcar el día correspondiente
                string dia = row["dia_semana"].ToString();
                MarcarDia(dia);

                dtpInicio.Value = DateTime.Today.Add(TimeSpan.Parse(row["hora_inicio"].ToString()));
                dtpFin.Value = DateTime.Today.Add(TimeSpan.Parse(row["hora_fin"].ToString()));
                txtIntervalo.Text = row["intervalo_atencion"].ToString();
                chkActivo.Checked = Convert.ToBoolean(row["activo"]);

                btnGuardar.Text = "Actualizar";
                this.Text = "Editar Horario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar horario: " + ex.Message);
            }
        }

        private void MarcarDia(string dia)
        {
            // Desmarcar todos primero
            chkLunes.Checked = chkMartes.Checked = chkMiercoles.Checked =
            chkJueves.Checked = chkViernes.Checked = chkSabado.Checked = chkDomingo.Checked = false;

            switch (dia)
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

        private List<string> ObtenerDiasSeleccionados()
        {
            var dias = new List<string>();
            if (chkLunes.Checked) dias.Add("Lunes");
            if (chkMartes.Checked) dias.Add("Martes");
            if (chkMiercoles.Checked) dias.Add("Miércoles");
            if (chkJueves.Checked) dias.Add("Jueves");
            if (chkViernes.Checked) dias.Add("Viernes");
            if (chkSabado.Checked) dias.Add("Sábado");
            if (chkDomingo.Checked) dias.Add("Domingo");
            return dias;
        }

        private bool ValidarDatos()
        {
            if (cmbDoctores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un doctor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDoctores.Focus();
                return false;
            }

            var dias = ObtenerDiasSeleccionados();
            if (dias.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un día de la semana.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan horaInicio = dtpInicio.Value.TimeOfDay;
            TimeSpan horaFin = dtpFin.Value.TimeOfDay;

            if (horaInicio >= horaFin)
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIntervalo.Text, out int intervalo) || intervalo <= 0)
            {
                MessageBox.Show("El intervalo debe ser un número entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntervalo.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            int idDoctor = (int)cmbDoctores.SelectedValue;
            TimeSpan horaInicio = dtpInicio.Value.TimeOfDay;
            TimeSpan horaFin = dtpFin.Value.TimeOfDay;
            int intervalo = Convert.ToInt32(txtIntervalo.Text);
            bool activo = chkActivo.Checked;
            var dias = ObtenerDiasSeleccionados();

            //
            if (idHorarioEditando.HasValue && dias.Count > 1)
            {
                MessageBox.Show("En modo edición solo puede seleccionar un día.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                using var transaccion = conexion.BeginTransaction();

                if (idHorarioEditando.HasValue) // EDITAR
                {
                    clsHorario horario = new clsHorario
                    {
                        id_horario = idHorarioEditando.Value,
                        id_doctor = idDoctor,
                        dia_semana = dias[0], // solo uno
                        hora_inicio = horaInicio,
                        hora_fin = horaFin,
                        intervalo_atencion = intervalo,
                        activo = activo
                    };

                    if (clsHorarioDAL.ExisteSolapamiento(idDoctor, dias[0], horaInicio, horaFin, idHorarioEditando))
                    {
                        MessageBox.Show($"Ya existe un horario para {dias[0]} en ese rango.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (clsHorarioDAL.Actualizar(horario, transaccion))
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
                else // NUEVO (puede insertar varios días)
                {
                    int insertados = 0;
                    foreach (string dia in dias)
                    {
                        // Validar solapamiento para cada día
                        if (clsHorarioDAL.ExisteSolapamiento(idDoctor, dia, horaInicio, horaFin, null))
                        {
                            MessageBox.Show($"Ya existe un horario para {dia} en ese rango. Se omite.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        clsHorario horario = new clsHorario
                        {
                            id_doctor = idDoctor,
                            dia_semana = dia,
                            hora_inicio = horaInicio,
                            hora_fin = horaFin,
                            intervalo_atencion = intervalo,
                            activo = activo
                        };

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
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}