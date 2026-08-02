using System;
using System.Data;
using System.Windows.Forms;
using MedicDate.Procesos;

namespace MedicDate
{
    public partial class frmReportes : Form
    {
        private clsReporteDAL reporte;
        
        public frmReportes()
        {
            InitializeComponent();
            ActualizarControlesPorReporte();

        }

        private void radioReporte_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarControlesPorReporte();
        }

        private void ActualizarControlesPorReporte()
        {
            bool esIngresos = rdbReporteIngresos.Checked;
            lblPeriodo.Visible = esIngresos;
            cmbPeriodo.Visible = esIngresos;

            dgvReporte.DataSource = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = DateTime.Today;
            cmbPeriodo.SelectedIndex = 1;
            rdbReporteAgenda.Checked = true;
            dgvReporte.DataSource = null;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            reporte = new clsReporteDAL();

            try
            {
                if (rdbReporteAgenda.Checked)
                {
                    dgvReporte.DataSource = reporte.ObtenerAgenda(dtpDesde.Value.Date, dtpHasta.Value.Date);
                }
                else if (rdbReporteCitas.Checked)
                {
                    dgvReporte.DataSource = reporte.ObtenerCitasPorEstado(dtpDesde.Value.Date, dtpHasta.Value.Date);
                }
                else
                {
                    string periodo = cmbPeriodo.SelectedItem?.ToString() ?? "Mensual";
                    dgvReporte.DataSource = reporte.ObtenerIngresos(dtpDesde.Value.Date, dtpHasta.Value.Date, periodo);
                }

                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerTituloReporte()
        {
            if (rdbReporteAgenda.Checked) return "Agenda por Rango de Fechas";
            if (rdbReporteCitas.Checked) return "Citas por Estado";
            return "Ingresos";
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvReporte.DataSource == null || dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("Primero genera el reporte para poder exportarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable tabla = dgvReporte.DataSource as DataTable;

            string titulo = ObtenerTituloReporte();
            string rangoFechas = $"Del {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy}";
            if (rdbReporteIngresos.Checked)
            {
                rangoFechas += $" — Período: {cmbPeriodo.SelectedItem?.ToString() ?? "Mensual"}";
            }
            string nombreArchivo = titulo.Replace(" ", "_") + ".pdf";

            if (reporte == null) reporte = new clsReporteDAL();
            reporte.ExportarPDF(tabla, titulo, rangoFechas, nombreArchivo);
        }
    }
}
