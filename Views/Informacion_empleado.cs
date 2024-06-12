using PAS.Database;
using PAS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            this.inicio.Visible = false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Informacion_empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Visible = true;
            this.inicio.habilitarBotones(true);
            this.Dispose();
        }

        private void acciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = this.acciones.SelectedIndex;
            deshabilitar(!(seleccion == 1 || seleccion == 3));

        }
        private void definir_accion_Click(object sender, EventArgs e)
        {
            int opcion = this.acciones.SelectedIndex;
            Usuario usuario = new Usuario();
            string sql = "";


            // Filtros
            if (!(opcion == 1 || opcion == 3))
            {
                if (!isPhoneNumber(telefono.Text))
                {
                    MessageBox.Show("Ingrese bien el número de teléfono.");
                    return;
                }

                if (!validContract(inicio_contrato, final))
                {
                    MessageBox.Show("Tiene que ingresar un rango de contrato válido");
                    return;
                }
            }

            switch (opcion)
            {
                case 0:
                    this.llenarDatos(usuario);

                    // Filtro de registro.
                    string isRegistered = usuario.searchUser(usuario.Identificacion);
                    string isCardRegistered = usuario.searchByCard(usuario.Tarjeta);

                    if (Queries.results(isRegistered).Rows.Count > 0) {
                        MessageBox.Show("Persona registrada con anterioridad.");
                        return;
                    }

                    if (cardResponse.Text.Length <= 0) {
                        MessageBox.Show("Tarjeta no leída.");
                        return;
                    }

                    if (Queries.results(isCardRegistered).Rows.Count > 0) {
                        MessageBox.Show("Tarjeta agregada con anterioridad.");
                        return;
                    }

                    sql = usuario.AddToDataBase();
                    Queries.sendToDataBase(sql);

                    sql = ListOfResults.crearContrato("" + usuario.Identificacion, usuario.Inicio, usuario.Final);
                    Queries.sendToDataBase(sql);
                    
                    this.limpiarCampos();
                    break;

                case 1:
                    DataTable table = null;
                    if (identificacion.Text.Length > 0)
                        table = Queries.results(usuario.searchUser(BigInteger.Parse(this.identificacion.Text)));
                    else    
                        table = Queries.results(usuario.searchByCard(this.cardResponse.Text));
                    

                    if (table.Rows.Count <= 0) { MessageBox.Show("Empleado no encontrado."); break; }

                    usuario.toClass(table.Rows[0]);
                    llenarCampos(usuario);
                    break;

                case 2:
                    this.llenarDatos(usuario);
                    Queries.sendToDataBase(usuario.updateUser());

                    sql = ListOfResults.actualizarContrato("" + usuario.Identificacion, usuario.Inicio, usuario.Final);

                    Queries.sendToDataBase(sql);
                    this.limpiarCampos();
                    break;
                case 3:
                    DialogResult result = MessageBox.Show("¿Quieres realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Queries.sendToDataBase(usuario.deleteUser(BigInteger.Parse(this.identificacion.Text)));
                        this.limpiarCampos();
                    }
                    break;
                default: MessageBox.Show("Ingrese una opción válida."); break;
            }
        }


        /**
         * 
         * Métodos de manipulación de datos.
         * 
         */
        private void deshabilitar(bool condicion)
        {
            this.nombre.Enabled = condicion;
            this.apellido.Enabled = condicion;
            this.telefono.Enabled = condicion;
            this.direccion.Enabled = condicion;
            this.Genero.Enabled = condicion;
            this.inicio_contrato.Enabled = condicion;
            this.final.Enabled = condicion;
            this.correo.Enabled = condicion;

        }

        private void llenarDatos(Usuario usuario)
        {
            usuario.setIdentificacion(BigInteger.Parse(this.identificacion.Text));
            usuario.setNombre(this.nombre.Text);
            usuario.setApellido(this.apellido.Text);
            usuario.setTelefono(this.telefono.Text);
            usuario.setGenero((string)this.Genero.SelectedItem);
            usuario.setDireccion(this.direccion.Text);
            usuario.setInicio(this.inicio_contrato.Value.ToString("yyyy-MM-dd"));
            usuario.setFinal(this.final.Value.ToString("yyyy-MM-dd"));
            usuario.setCorreo(this.correo.Text);
            usuario.setTarjeta(this.cardResponse.Text);
        }

        private void llenarCampos(Usuario usuario)
        {
            this.identificacion.Text = "" + usuario.Identificacion;
            this.nombre.Text = usuario.Nombre;
            this.apellido.Text = usuario.Apellido;
            this.telefono.Text = usuario.Telefono;
            string genero = usuario.Genero;
            if (genero.Equals("Masculino")) { this.Genero.SelectedIndex = 0; }
            else if (genero.Equals("Femenino")) { this.Genero.SelectedIndex = 1; }
            if (genero.Equals("Otro")) { this.Genero.SelectedIndex = 2; }
            this.direccion.Text = usuario.Direccion;
            this.correo.Text = usuario.Correo;
            this.cardResponse.Text = usuario.Tarjeta;
        }

        private void limpiarCampos()
        {
            this.identificacion.Text = "";
            this.nombre.Text = "";
            this.apellido.Text = "";
            this.telefono.Text = "";
            this.Genero.SelectedIndex = 0;
            this.direccion.Text = "";
            this.correo.Text = "";
        }

        private Boolean isPhoneNumber(string telefono)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(telefono, pattern);
        }

        private Boolean validContract(DateTimePicker inicio, DateTimePicker fin)
        {
            DateTime dateInicio = inicio.Value, dateFinal = fin.Value;
            MessageBox.Show(dateInicio + " " + dateFinal + " = " + DateTime.Compare(dateInicio, dateFinal));
            return DateTime.Compare(dateInicio, dateFinal) <= 0;
        }


        private void huella_Click(object sender, EventArgs e)
        {
            string data = Arduino.ArduinoTarjeta.SeriaConnection();
            cardResponse.Text = data;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese el número de teléfono sin espacios.");
        }
    }
}
