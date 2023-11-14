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
            switch (opcion)
            {
                case 0:
                    this.llenarDatos(usuario);
                    Queries.sendToDataBase(usuario.AddToDataBase());
                    break;
                case 1:
                    DataTable table = Queries.results(usuario.searchUser(BigInteger.Parse(this.identificacion.Text)));
                    if (table == null) { MessageBox.Show("Empleado no encontrado."); break; }
                    usuario.toClass(table.Rows[0]);
                    llenarCampos(usuario);
                    break;
                case 2:
                    this.llenarDatos(usuario);
                    Queries.sendToDataBase(usuario.updateUser());
                    break;
                case 3:
                    DialogResult result = MessageBox.Show("¿Quieres realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        Queries.sendToDataBase(usuario.deleteUser(BigInteger.Parse(this.identificacion.Text)));
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
            this.huella.Enabled = condicion;
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
            usuario.setInicio(this.inicio_contrato.Value.ToShortDateString());
            usuario.setFinal(this.final.Value.ToShortDateString());
            usuario.setCorreo(this.correo.Text);
        }

        private void llenarCampos(Usuario usuario) {
            this.nombre.Text = usuario.Nombre;
            this.apellido.Text = usuario.Apellido;
            this.telefono.Text = usuario.Telefono;
            string genero = usuario.Genero;
            if (genero.Equals("Masculino")) { this.Genero.SelectedIndex = 0; }
            else if (genero.Equals("Femenino")) { this.Genero.SelectedIndex = 1; }
            if (genero.Equals("Otro")) { this.Genero.SelectedIndex = 2; }
            this.direccion.Text = usuario.Direccion;
            this.correo.Text = usuario.Correo;
        }

        private void limpiarCampos()
        {
            this.nombre.Text = "";
            this.apellido.Text = "";
            this.telefono.Text = "";
            this.Genero.SelectedIndex = 0;
            this.direccion.Text = "";
            this.correo.Text = "";
        }
    }
}
