using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    internal class clsUsuarios
    {
        #region Atributos
        private int identificador;
        private string contrasena;
        #endregion


        #region
        public clsUsuarios()
        {
            this.identificador = 0;
            this.contrasena = "";
        }
        public clsUsuarios( int identificador, string contrasena)
        {
            this.identificador = identificador;
            this.contrasena = contrasena;
        }
        #endregion

        #region Metodos

        public int Identificador

        {
            set { identificador = value; }
            get { return identificador; }
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
            datos = " Identificador: " + this.identificador + "\n" +
                    " Contrasena: " + this.contrasena + "\n";

            return datos;
        }

        #endregion
    }
}
