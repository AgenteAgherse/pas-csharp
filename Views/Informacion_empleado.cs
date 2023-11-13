using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS.Views
{
    public partial class Informacion_empleado : Form
    {

        private Inicio inicio;
        public Informacion_empleado(Inicio inicio)
        {
            InitializeComponent();
            Genero.Items.Add("Masculino");
            Genero.Items.Add("Femenino");
            Genero.Items.Add("Otro");
            this.inicio = inicio;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Informacion_empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
        }
    }
}
