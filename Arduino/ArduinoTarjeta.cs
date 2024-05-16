using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Arduino
{
    internal class ArduinoTarjeta
    {
        private static string portName = "COM3";
        private static int baudRate = 9600;



        public static string SeriaConnection() {
            string receivedData = string.Empty;

            using (SerialPort serialPort = new SerialPort(portName, baudRate))
            {
                serialPort.Open();
                Console.WriteLine($"Conexión serial establecida en el puerto {portName}. Esperando datos...");

                // Esperar hasta que se reciban datos
                while (true)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        receivedData = serialPort.ReadLine();
                        break;
                    }
                }
            }

            return receivedData;

        }

    }
}
