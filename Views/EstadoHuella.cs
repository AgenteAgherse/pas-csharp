using PAS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAS.Views
{
    public partial class RegistroEntradas : Form
    {
        private Inicio inicio;
        private int newEmployee;
        private int opcion;
        private Thread lecturaDatos;

        public RegistroEntradas(Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.Visible = true;
            lecturaDatos = new Thread(getMessage);
            lecturaDatos.Start();
        }

        private void EstadoHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
            this.Dispose();
        }


        private void addTextMessage(string text)
        {
            if (mensajes.InvokeRequired)
                mensajes.Invoke(new Action<string>(addTextMessage), text);
            else
                mensajes.Text += "\n" + text;
        }



        private void getMessage()
        {
            while (true)
            {
                string data = Arduino.ArduinoTarjeta.SeriaConnection();
                string cardResponseSQL = "SELECT identificacion FROM usuarios WHERE tarjeta = '" + data + "'";
                DataTable dataTable = Queries.results(cardResponseSQL);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    string insertRecord = "INSERT INTO registro (id_usuario) VALUES (" + (UInt32)dataRow[0] + ");";
                    Queries.sendToDataBase(insertRecord);

                    // Se obtiene el último registro
                    cardResponseSQL = ListOfResults.obtenerRegistroUsuario();
                    dataTable = Queries.results(cardResponseSQL);

                    if (dataTable.Rows.Count > 0)
                    {

                        dataRow = dataTable.Rows[0];

                        string response = "(" + dataRow[0] + " " + dataRow[1] + ") -> " + dataRow[2] + " " + dataRow[3] + "\n";
                        addTextMessage(response); // Problema
                    }
                    else
                    {
                        MessageBox.Show("No hay registro");
                    }
                }

            }
        }
    }
}
