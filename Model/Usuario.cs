using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Model
{
    internal class Usuario {
        private BigInteger identificacion;
        private string nombre, apellido, direccion, telefono, genero, rol, correo;
        private int sede;
        private Blob huella;
        private bool activo;
        private string inicio, fin;

        public Usuario() {
            this.identificacion = 0;
            this.nombre = "";
            this.apellido = "";
            this.direccion = "";
            this.telefono = "";
            this.genero = "";
            this.rol = "USER";
            this.correo = "";
            this.activo = true;
            this.inicio = "";
            this.fin = "";
        }

        public Usuario(BigInteger identificacion, string nombre, string apellido, string direccion, 
                       string telefono, string genero, string correo, bool activo)  
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.genero = genero;
            this.rol = "USER";
            this.correo = correo;
            this.activo = activo;
            this.inicio = "";
            this.fin = "";
        }


        public BigInteger Identificacion { get { return this.identificacion; } }
        public string Nombre { get { return this.nombre; }  }
        public string Apellido { get { return this.apellido; } }
        public string Direccion { get { return this.direccion; } }
        public string Telefono { get { return this.telefono; } }
        public string Genero { get { return this.genero; } }
        public string Rol { get { return this.rol; } }
        public string Correo { get { return this.correo; } }
        public string Inicio { get { return this.inicio; } }
        public string Final { get { return this.fin; } }

        //public Blob Huella { get { return this.huella; } }

        public void setIdentificacion(BigInteger identificacion) {
            this.identificacion = identificacion;
        }

        public void setNombre(string nombre) { this.nombre = nombre; }

        public void setApellido(string apellido) { this.apellido = apellido; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setGenero(string genero) { this.genero = genero; }
        public void setRol(string rol) { this.rol = rol;}
        public void setCorreo(string correo) { this.correo = correo; }
        public void setInicio(string inicio) { this.inicio = inicio; }
        public void setFinal(string final) { this.fin = final; }

        //public void setHuella(Blob huella) { this.huella = huella; }

        public string AddToDataBase()
        {
            return "INSERT INTO usuarios(" +
                "identificacion, " +
                "id_sede, " +
                "nombre, " +
                "apellido, " +
                "direccion, " +
                "telefono, " +
                "genero, " +
                "rol, " +
                "activo, " +
                "correo) " +

                "VALUES (" + 

                identificacion + 
                ",1,'" + nombre + "','" + 
                apellido + "','" + 
                direccion + "','" + 
                telefono + "','" + 
                genero + "','" + 
                rol + "',1,'" + 
                correo + "');";
        }

        public string searchUser(BigInteger identificacion) {
            return "SELECT * FROM usuarios WHERE identificacion=" + identificacion + ";";
        }

        public string updateUser()
        {
            return "UPDATE usuarios SET nombre = '" + nombre
                    + "', apellido = '" + apellido
                    + "', direccion = '" + direccion
                    + "', telefono = '" + telefono
                    + "', genero = '" + genero
                    + "', correo = '" + correo + "' " +
                    "WHERE identificacion = " + identificacion  + ";";
        }
        public string deleteUser(BigInteger identificacion)
        {
            return "DELETE FROM usuarios WHERE identificacion=" + identificacion + ";";
        }

        public void toClass(DataRow usuario)
        {
            this.identificacion = (UInt32) usuario[0];
            this.sede = (int)(UInt32) usuario[1];
            this.nombre = (string) usuario[2];
            this.apellido = (string)usuario[3];
            this.direccion = (string)usuario[4];
            this.telefono = (string)usuario[5];
            this.genero = (string)usuario[6];
            this.rol = (string)usuario[8];
            this.activo = (bool)usuario[9];
            this.correo = (string)usuario[10];
        }
    }
}

