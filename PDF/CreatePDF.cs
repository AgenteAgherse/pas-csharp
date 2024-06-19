using IronPdf;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using MySqlX.XDevAPI.Relational;
using PAS.Database;
using System.Data;
using System.Numerics;

namespace PAS.PDF
{
    internal class CreatePDF {
        private static string route = AppDomain.CurrentDomain.BaseDirectory + "\\Informe ";
        public CreatePDF() { }

        /**
         * Toma en cuenta el documento HTML de la ruta, edita sus propiedades
         * en base a los resultados y genera el pdf devolviendo su ruta.
         * Parámetros:
         *     * Datatable ➡️ [Usuario, Registros].
         **/
        public static string[] Create(BigInteger identificacion) {
            DataTable persona = Queries.results("SELECT * FROM usuarios WHERE identificacion = "+ identificacion +";");
            if (persona == null) return new string[0];

            DataRow p = persona.Rows[0];
            persona = Queries.results("SELECT dia, hora, tipo_registro FROM registro WHERE id_usuario = " + identificacion + ";");

            string plantilla = GetPlantilla(p, persona);
            string titulo = "Informe " + p[2] + " " + p[3];
            string absoluteRoute = route + titulo +".pdf";

            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(plantilla);
            pdf.SaveAs(absoluteRoute);

            
            string[] data = { absoluteRoute, titulo};
            return data;
        }

        private static string GetPlantilla(DataRow persona, DataTable registros)
        {             
            string documento =
                "<!DOCTYPE html>\n" +
                "<html lang='es'>\n" +
                "<head>\n" +
                "<style>\n" +
                "        body {\n" +
                "            font - family: Arial, sans - serif;\n" +
                "            margin: 0;\n" +
                "            padding: 0;\n" +
                "            }\n" +

                "header {\n" +
                "    background-color: #0d47a1;\n" +
                "    padding: 20px;\n" +
                "    text-align: center;\n" +
                "    color: #fff;\n" +
                "}\n" +

                "section {\n" +
                "    margin: 20px;\n" +
                "}\n" +
                "table {\n" +
                "    width: 80%;\n" +
                "    margin: 20px auto;\n" +
                "    border-collapse: collapse;\n" +
                "}\n" +

                "th, td {\n" +
                "    padding: 12px;\n" +
                "    text-align: left;\n" +
                "    border-bottom: 1px solid #ddd;\n" +
                "}\n" +
                "#totalGanancias {\n" +
                "    margin-top: 20px;}\n" +
                    "</style>\n" +
                "</head>\n" +
                "<body>\n" +

                    "<header>\n" +
                        "<h1>Informe Empleado</h1>\n" +
                    "</header>\n" +

                    "<section>\n" +
                        "<h2 style='text-center'>Información del Empleado</h2>\n" +
                        "<p> <strong> Nombre:</strong>" + persona[2] + " " + persona[3] + "</p>\n" +
                        "<p> <strong> Identificación: </strong>" + persona[0] + "</p>\n" +
                        "<p> <strong> Dirección:</strong>" + persona[4] + "</p>\n" +
                        "<p> <strong> Teléfono: </strong>" + persona[5] + "</p>\n" +
                    "</section>\n" +
                    "<section>\n" +
                        "<h2>Registro de Actividades</h2>\n" +
                        "<table>\n" +
                            "<thead>\n" +
                                "<tr>\n" +
                                    "<th>Día</th>\n" +
                                    "<th>Hora</th>\n" +
                                    "<th>Tipo de Registro</th>\n" +
                                "</tr>\n" +
                            "</thead>\n" +
                            "<tbody>\n";



            if (registros != null) {
                for (int i = 0; i < registros.Rows.Count; i++)
                {
                    DateTime fecha = (DateTime)registros.Rows[i][0];
                    DateTime soloFecha = fecha.Date;
                    string fechaString = soloFecha.ToString("yyyy-MM-dd");
                    documento += "<tr>\n" +
                                    "<td>" + fechaString + "</td>\n" +
                                    "<td>" + registros.Rows[i][1] + "</td>\n" +
                                    "<td>" + registros.Rows[i][2] + "</td>\n" +
                                "</tr>\n";
                }
            }
            documento +=    "</tbody>\n" +
                        "</table>\n" +
                    "</section>\n" +
                "</body>\n" +
            "</html>";
            return documento;
        }
    }
}
