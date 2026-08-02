using MySqlConnector;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System.Windows.Forms;
using QuestPDF.Infrastructure;
using System;
using System.Data;

namespace MedicDate.Procesos
{
    internal class clsReporteDAL
    {
        // Reporte 1: Agenda por rango de fechas
        public DataTable ObtenerAgenda(DateTime desde, DateTime hasta)
        {
            string sql = @"SELECT CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', p.apellido_materno) AS Paciente,
                                  CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', e.apellido_materno) AS Doctor,
                                         c.fecha AS Fecha,
                                         c.hora AS Hora,
                                         c.motivo AS Motivo,
                                         c.estado AS Estado
                                         FROM cita c
                                         INNER JOIN paciente p ON c.id_paciente = p.id_paciente
                                         INNER JOIN empleado e ON c.id_doctor = e.id_empleado
                                         WHERE c.fecha BETWEEN @desde AND @hasta
                                         ORDER BY c.fecha, c.hora;";

            MySqlParameter[] parametros =
            {
                new MySqlParameter("@desde", desde.Date),
                new MySqlParameter("@hasta", hasta.Date)
            };

            return clsConexion.EjecutarConsulta(sql, parametros);
        }


        // Reporte 2: Citas por estado
        public DataTable ObtenerCitasPorEstado(DateTime desde, DateTime hasta)
        {
            string sql = @"
                SELECT
                    c.estado AS Estado,
                    COUNT(*) AS Total
                FROM cita c
                WHERE c.fecha BETWEEN @desde AND @hasta
                GROUP BY c.estado
                ORDER BY Total DESC;";

            MySqlParameter[] parametros =
            {
                new MySqlParameter("@desde", desde.Date),
                new MySqlParameter("@hasta", hasta.Date)
            };

            return clsConexion.EjecutarConsulta(sql, parametros);
        }

        // Reporte 3: Ingresos (semanal o mensual), solo citas Completadas
        public DataTable ObtenerIngresos(DateTime desde, DateTime hasta, string periodo)
        {
            string agrupador = periodo == "Semanal"
                ? "YEARWEEK(c.fecha, 1)"
                : "DATE_FORMAT(c.fecha, '%Y-%m')";

            string sql = $@"
                SELECT
                    {agrupador} AS Periodo,
                    COUNT(*) AS CitasCompletadas,
                    SUM(c.costo) AS Ingresos
                FROM cita c
                WHERE c.estado = 'Completada'
                  AND c.fecha BETWEEN @desde AND @hasta
                GROUP BY {agrupador}
                ORDER BY Periodo;";

            MySqlParameter[] parametros =
            {
                new MySqlParameter("@desde", desde.Date),
                new MySqlParameter("@hasta", hasta.Date)
            };

            return clsConexion.EjecutarConsulta(sql, parametros);

        }
        private IDocument CrearDocumentoPdf(DataTable tabla, string tituloReporte, string rangoFechas)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter.Landscape());
                    page.Margin(1.5f, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontFamily(Fonts.TimesNewRoman));

                    // Encabezado
                    page.Header().Column(col =>
                    {
                        col.Item().Text("MedicDate")
                            .FontSize(18).Bold().FontColor("#19558C");
                        col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                    });

                    // Contenido
                    page.Content().PaddingTop(20).Column(column =>
                    {
                        column.Item().PaddingBottom(3).Text(tituloReporte)
                            .FontSize(14).Bold().FontColor(Colors.Black);

                        column.Item().PaddingBottom(15).Text(rangoFechas)
                            .FontSize(10).FontColor(Colors.Grey.Darken1);

                        column.Item().Table(table =>
                        {
                            int totalColumnas = tabla.Columns.Count;

                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    columns.RelativeColumn();
                                }
                            });

                            foreach (DataColumn columna in tabla.Columns)
                            {
                                table.Cell().Background("#19558C").Padding(8).AlignMiddle()
                                    .Text(columna.ColumnName)
                                    .FontSize(10).Bold().FontColor(Colors.White);
                            }

                            bool alternarFila = true;
                            foreach (DataRow fila in tabla.Rows)
                            {
                                string colorFondo = alternarFila ? "#E6E8F5" : "#FFFFFF";
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    table.Cell().Background(colorFondo)
                                        .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                        .Padding(7).AlignMiddle()
                                        .Text(fila[i]?.ToString() ?? "")
                                        .FontSize(9).FontColor(Colors.Black);
                                }
                                alternarFila = !alternarFila;
                            }
                        });
                    });

                    // Pie de página
                    page.Footer().AlignRight().Text(x =>
                    {
                        x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Darken1);
                        x.CurrentPageNumber().FontSize(9).Bold();
                        x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                        x.TotalPages().FontSize(9).Bold();
                    });
                });
            });
        }

        public void ExportarPDF(DataTable tabla, string tituloReporte, string rangoFechas, string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar a PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog guardarArchivo = new SaveFileDialog())
            {
                guardarArchivo.FileName = nombreArchivoSugerido;
                guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CrearDocumentoPdf(tabla, tituloReporte, rangoFechas).GeneratePdf(guardarArchivo.FileName);
                        MessageBox.Show("Reporte exportado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}







