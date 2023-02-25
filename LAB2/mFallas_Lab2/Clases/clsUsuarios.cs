using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsUsuarios
    {
        #region Atributos
        private int idUsuario;
        private string usuario,contrasena;
        #endregion

        #region constructor
        public clsUsuarios()
        {
            this.idUsuario = 0;
            this.contrasena = "";
            this.usuario = "";
        }
        public clsUsuarios( int identificador, string contrasena, string usuario)
        {
            this.idUsuario = identificador;
            this.contrasena = contrasena;
            this.usuario = usuario;
        }
        #endregion

        #region Metodos

        public int IdUsuarios

        {
            set { idUsuario = value; }
            get { return idUsuario; }
        }

        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Contrasena
        {
            set { contrasena = value; }
            get { return contrasena; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdUsuarios: " + this.idUsuario + "\n" +
                    " Usuario: " + this.usuario + "\n" +
                    " Contrasena: " + this.contrasena + "\n";

            return datos;
        }

        #endregion
    }
}
