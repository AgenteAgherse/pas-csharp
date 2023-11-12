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
    public partial class Descargar : Form
    {
        public Descargar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ventana6 = new Inicio();
            ventana6.Show();
        }

    }
}
