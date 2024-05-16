using PAS.Database;
using PAS.PDF;
using PAS.Views;
using System.Data;
using System.Windows.Forms;

namespace PAS
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();

            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;


            this.StartPosition = FormStartPosition.Manual;
            this.txtPassword.PasswordChar = '*';
            this.Location = new System.Drawing.Point((int)(width * 0.35), (int)(height * 0.25));
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se obtiene el usuario y contraseña del programa.
            string username = txtUsuario.Text;
            string password = txtPassword.Text;
            string sql = "SELECT * FROM admin WHERE username = '" + username + "' AND password = sha('" + txtPassword.Text + "');";
            DataTable results = Queries.results(sql);
            if (results == null || results.Rows.Count == 0)
            {
                MessageBox.Show("Credenciales erroneas.");
                return;
            }

            //Toma ahora los datos del usuario y los pasa al formulario de inicio.
            sql = "SELECT * FROM usuarios WHERE identificacion = " + results.Rows[0][0] + ";";
            results = Queries.results(sql);
            DataRow admin = results.Rows[0];

            //Se oculta el proceso del login para evitar problemas.
            this.Hide();
            Inicio ventanainicio = new Inicio(admin);
            ventanainicio.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /* private void showMainWindow()
         {
             Boolean isVisible = true;
             Inicio mainWindow = new Inicio();
             mainWindow.Show();

         }*/

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}