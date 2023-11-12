using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS.Views
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacion_empleado ventana4 = new Informacion_empleado();
            ventana4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Descargar ventana5 = new Descargar();
            ventana5.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
           System.Windows.Forms.Application.Exit();
        }
    }
}
