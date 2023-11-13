using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PAS.PDF
{
    internal class sendTo {
        private const string origin = "agus.hdez2011@gmail.com";
        private const int port = 587;
        private const string protocol = "smtp.gmail.com";
        private const string password = "quvzjyhmvbcgqaic";

        /**
         * Extensión del código de crear PDF.
         * Los datos que recibe en su parámetro son respectivamente
         *      * Ruta.
         *      * Título de correo.
         */
        public static void sendEmail(string[] datos, string destino) {
            if (datos.Length == 0) return;

            using (var clientEmail = new SmtpClient(protocol)) {
                //Credenciales y datos de correo.
                clientEmail.Port = port;
                clientEmail.Credentials = new NetworkCredential(origin, password);
                clientEmail.EnableSsl = true;

                using (var message = new MailMessage(origin, destino)) {
                    message.Subject = datos[1];
                    message.Body = datos[1];
                    message.BodyEncoding = Encoding.UTF8;
                    message.Attachments.Add(new Attachment(datos[0]));

                    clientEmail.Send(message);
                }
                MessageBox.Show("Documento enviado con éxito. Revise su correo.");
            }
            
        }


    }
}
