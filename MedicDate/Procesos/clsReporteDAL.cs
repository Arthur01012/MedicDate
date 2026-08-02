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
        private IDocument CrearDocumentoPdf(DataTable tabla, string tituloReporte)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter.Landscape());
                    page.Margin(1.5f, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontFamily(Fonts.TimesNewRoman));

                    //Agregar Titulo al reporte
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                        {
                            col.Item().Text("MedicDate")
                            .FontSize(18)
                            .Bold()
                            .FontColor("#19558C");
                            col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                        });

                        // NO TENGO EL LOGO XD
                        // if (Properties.Resources.LOGO != null)
                        // {
                        //     byte[] bytesLogo = Properties.Resources.LOGO;
                        //     row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                        // }
                    });

                    // ---CONTENIDO CENTRAL ---
                    page.Content().Padding(20).Column(column =>
                    {
                        //Se imprime el titulo que le pases por parámetro
                        column.Item().PaddingBottom(15).Text(tituloReporte)
                        .FontSize(12).Bold().FontColor(Colors.Black);

                        //la tabla se construye sola según las columnas que traigan el DataTable
                        column.Item().Table(table =>
                        {
                            int totalColumnas = tabla.Columns.Count;

                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    if (i > 0 && i < totalColumnas - 1)
                                    {
                                        columns.RelativeColumn(2f);
                                    }
                                    else
                                    {
                                        columns.RelativeColumn(1.2f);
                                    }
                                }
                            });

                            //Nombres de las columnas en automatico de acuerdo a la tabla
                            foreach (DataColumn columnaObj in tabla.Columns)
                            {
                                table.Cell().Background("#19558C").Padding(8).AlignLeft().AlignMiddle()
                                                                    .Text(columnaObj.ColumnName)
                                                                    .FontSize(10)
                                                                    .Bold()
                                                                    .FontColor(Colors.White);
                            }

                            //Filas automaticas
                            bool alternarFila = true;
                            foreach (DataRow fila in tabla.Rows)
                            {
                                string colorFondo = alternarFila ? "#E6E8F5" : "#FFFFFF";
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    var celda = table.Cell().Background(colorFondo)
                                                            .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                            .Padding(7).AlignMiddle();
                                    if (i == 0 || i == (totalColumnas - 1))
                                        celda.AlignCenter();
                                    else
                                        celda.AlignLeft();

                                    celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                }
                                alternarFila = !alternarFila;
                            }
                        });
                    });
                    //Este es el pie de pagina
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

        // Exporta el reporte a PDF (pide dónde guardarlo).
        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            // Validar que haya datos
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Abre la ventana para guardar el archivo pdf
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Generar y guardar el PDF
                    CrearDocumentoPdf(tabla, tituloReporte).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Finaliza el metodo de conversion
    }
}







