using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS.Views
{
    public partial class Inicio : Form
    {
        private DataRow adminCredentials;
        public Inicio(DataRow admin)
        {
            InitializeComponent();
            this.adminCredentials = admin;

            
            switch ((string) this.adminCredentials[6])
            {
                case "Masculino": this.bienvenida.Text = "Bienvenido " + adminCredentials[2] + "!"; break;
                case "Femenino": this.bienvenida.Text = "Bienvenida " + adminCredentials[2] + "!"; break;
                case "Otro": this.bienvenida.Text = "Hola " + adminCredentials[2] + "!"; break;
            }


            //Centrar el título de bienvenida.
            int welcomeWidth = this.bienvenida.Left/2;
            this.bienvenida.SetBounds(this.Width / 2 - welcomeWidth, this.bienvenida.Top, this.bienvenida.Width, this.bienvenida.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            Informacion_empleado ventana4 = new Informacion_empleado(this);
            ventana4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            habilitarBotones(false);
            Descargar ventana5 = new Descargar(this, (string) adminCredentials[10]);
            ventana5.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



        /**
         * Creación de métodos no génerados por Visual Studio.
         */
        public void habilitarBotones(bool habilitar)
        {
            button1.Enabled = habilitar;
            button2.Enabled = habilitar;
            button3.Enabled = habilitar;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
