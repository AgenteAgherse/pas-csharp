﻿using PAS.Database;
using PAS.PDF;
using System.Data;
using System.Numerics;

namespace PAS.Views
{
    public partial class Descargar : Form
    {
        private Inicio inicio;
        private string correoAdmin;
        public Descargar(Inicio inicio, string correo)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.correoAdmin = correo;
            results.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            results.Enabled = true;
            string sql = "SELECT tipo_registro, hora, dia FROM registro WHERE id_usuario=";
            if (identificacion.Text != "" && identificacion != null)
            {
                BigInteger identification = BigInteger.Parse(this.identificacion.Text);
                sql += "" + identification + ";";
            }
            else if (nombres.Text != "" && nombres.Text != null)
            {
                sql += "" + buscarPorNombre(nombres.Text) + ";";
            }

            consulta(Queries.results(sql));
        }

        private void Descargar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
        }


        /**
         * Métodos que no son eventos.
         **/
        private void consulta(DataTable results)
        {
            if (results == null)
            {
                MessageBox.Show("No se encuentra a la persona.");
                return;
            }

            if (results.Rows.Count > 0)
            {
                this.results.DataSource = results;
            }
            else
            {
                MessageBox.Show("No se encuentra a la persona.");
            }
        }

        private BigInteger buscarPorNombre(string nombre)
        {
            string[] data = nombre.Split(' ');
            MessageBox.Show(data[0] + " " + data[1] + " " + data[2]);
            string sql = "SELECT identificacion FROM usuarios WHERE ";
            if (data.Length == 3)
            {
                sql += "nombre LIKE '%" + data[0] + "%' AND apellido LIKE '%" + data[1] + " " + data[2] + "%';";
            }
            else if (data.Length == 4)
            {
                sql += "nombre LIKE '%" + data[0] + " " + data[1] + "%' AND apellido LIKE '%" + data[1] + " " + data[2] + "%';";
            }

            DataTable result = Queries.results(sql);

            return (result != null) ? (UInt32)result.Rows[0][0] : 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigInteger id = 0;

            if (identificacion.Text != "" || identificacion.Text != " ") {
                id = BigInteger.Parse(this.identificacion.Text);
            }
            else if (nombres.Text != "" || nombres.Text != " ") {
                id = buscarPorNombre(nombres.Text);
            }
            else {return;}

            sendTo.sendEmail(CreatePDF.Create(id), this.correoAdmin);

        }
    }
}
