using PAS.Database;
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
            Boolean filtro = false;
            Boolean repetido = false;
            results.Enabled = true;

            string sql = "SELECT tipo_registro, hora, dia FROM registro WHERE ";

            if (identificacion.Text.Length > 0)
                sql += "id_usuario='" + identificacion.Text + "';";
            else if (telefono.Text.Length > 0)
            {
                sql += "id_usuario='" + buscarPorTelefono(telefono.Text) + "';";
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
                MessageBox.Show("No se encuentra a la persona o registros de entrada.");
            }
        }

        private long buscarPorTelefono(string telefono)
        {
            Boolean condition = false;
            string sql = "SELECT identificacion FROM usuarios WHERE telefono = '" + telefono + "'";


            DataTable result = Queries.results(sql);
            identificacion.Text = (result != null) ? "" + (UInt32)result.Rows[0][0] : "";
            return (result != null) ? (UInt32)result.Rows[0][0] : -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigInteger id = 0;

            if (identificacion.Text != "" || identificacion.Text != " ")
            {
                id = BigInteger.Parse(this.identificacion.Text);
            }
            else if (telefono.Text != "" || telefono.Text != " ")
            {
                id = buscarPorTelefono(telefono.Text);
            }
            else { return; }

            sendTo.sendEmail(CreatePDF.Create(id), this.correoAdmin);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("En caso de no saber la información de la cédula, ingrese el número de teléfono sin espacios.");
        }
    }
}
