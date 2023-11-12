using PAS.Views;
namespace PAS
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
           Inicio ventanainicio  = new Inicio();
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