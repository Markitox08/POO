using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA.Clases
{
    internal class clsPropietario
    {

        #region
        private int identificador;
        private string primerNombre, primerApellido, segundoNombre, segundoApellido, numeroIdentificador, 
                        correoElectronico, telefonoCelular;
        #endregion

        #region
        public clsPropietario()
        {
            this.identificador = 0;
            this.primerNombre= "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.numeroIdentificador = "";
            this.correoElectronico = "";
            this.telefonoCelular = "";

        }

        public clsPropietario(int identificador, string primerNombre, string primerApellido, string segundoNombre, string segundoApellido, string numeroIdentificador, string correoElectronico, string telefonoCelular)
        {
            this.identificador = identificador;
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.segundoNombre = segundoNombre;
            this.segundoApellido = segundoApellido;
            this.numeroIdentificador = numeroIdentificador;
            this.correoElectronico = correoElectronico;
            this.telefonoCelular = telefonoCelular;
        }
        #endregion

        #region Funciones y procedimientos

        public string imprimirDatos()
        {

            string dato = "";
            dato = "Nombre Completo: " + this.primerNombre + " " + this.segundoNombre + "\n"+
                    this.primerApellido + " " + this.segundoApellido + "\n" +
                    "Número Identificacion: " + this.numeroIdentificador + "\n" +
                    "Correo Electronico: " + this.correoElectronico + "\n"+ 
                    "Telefono Celular: " + this.telefonoCelular + "\n";
            return dato;
        }
        #endregion

        #region 

        public int Identificador
        {
             set{ identificador = value; }
            get { return identificador; }
        }

        public string PrimerNombre
        {
            set { primerNombre = value.ToUpper(); }
            get { return primerNombre; }
        }

        public string SegundoNombre
        {
            set { segundoNombre = value.ToUpper(); }
            get { return segundoNombre; }
        }

        public string PrimerApellido
        {
            set { primerApellido = value.ToUpper(); }
            get { return primerApellido; }
        }

        public string SegundoApellido
        {
            set { segundoApellido = value.ToUpper(); }
            get { return SegundoApellido; }
        }

        public string CorreoElectronico
        {
            set { correoElectronico = value.ToUpper(); }
            get { return correoElectronico; }
        }

        public string TelefonoCelular
        {
            set { telefonoCelular = value.ToUpper(); }
            get { return telefonoCelular; }
        }
        #endregion
    }
}
