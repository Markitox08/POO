using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_FallasLAB3.Clases
{
    public class clsClientes
    {
        #region Atributos

        private int idcliente, numeroIdentificacion;
        private char tipoIdentificador, genero;
        private string primerNombre, segundoNombre, primerApellido, 
                       segundoApellido, correoElectronico, telefonoCelular;
        private DateTime fechaNacimiento;
        private decimal peso;

        #endregion

        #region Cosntructores
        public clsClientes()
        {
            this.idcliente = 0;
            this.numeroIdentificacion= 0;   
            this.tipoIdentificador = '*';
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.fechaNacimiento = Convert.ToDateTime("01/01/1990");
            this.peso = 0;
            this.genero = '*';
            this.telefonoCelular = "";
            this.correoElectronico = "";
        }

        public clsClientes(int IdCliente, int NumeroIdentificacion,
                            char TipoIdentificador, char Genero,
                            string PrimerNombre, string SegundoNombre, 
                            string PrimerApellido, string SegundoApellido,
                            string CorreoElectronico, string TelefonoCelular,
                            DateTime FechaNacimiento, decimal Peso)
        {
            this.idcliente = IdCliente;
            this.numeroIdentificacion = NumeroIdentificacion;
            this.tipoIdentificador = TipoIdentificador;
            this.genero = Genero;
            this.primerNombre = PrimerNombre;
            this.segundoNombre = SegundoNombre;
            this.primerApellido = PrimerApellido;
            this.segundoApellido = SegundoApellido;
            this.correoElectronico = CorreoElectronico;
            this.telefonoCelular = TelefonoCelular;
            this.fechaNacimiento = FechaNacimiento;
            this.peso = Peso;

        }
        #endregion

        #region Metodos

        public int IdClientes

        {
            set { idcliente = value; }
            get { return idcliente; }
        }

        public int NumeroIdentificacion
        {
            set { numeroIdentificacion = value; }
            get { return numeroIdentificacion; }
        }
        public char TipoIdentificador
        {
            set { tipoIdentificador = value; }
            get { return tipoIdentificador; }
        }
        public char Genero
        {
            set { genero = value; }
            get { return genero; }
        }
        public string PrimerNombre
        {
            set { primerNombre = value; }
            get { return primerNombre; }
        }
        public string SegundoNombre
        {
            set { segundoNombre = value; }
            get { return segundoNombre; }
        }
        public string PrimerApellido
        {
            set { primerApellido = value; }
            get { return primerApellido; }
        }
        public string SegundoApellido
        {
            set { segundoApellido = value; }
            get { return segundoApellido; }
        }
        public string CorreoElectronico
        {
            set { correoElectronico = value; }
            get { return correoElectronico; }
        }
        public string TelefonoCelular
        {
            set { telefonoCelular = value; }
            get { return telefonoCelular; }
        }
        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }
        public Decimal Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdCliente: " + this.idcliente + "\n" +
                    " Tipo de identificacion: " + this.tipoIdentificador + "\n" +
                    " Numero identificacion : " + this.numeroIdentificacion + "\n" +
                    " Primer Nombre: " + this.primerNombre + "\n" +
                    " Segundo Nombre: " + this.segundoNombre + "\n" +
                    " Primer Apellido: " + this.primerApellido + "\n" +
                    " Segundo Apellido: " + this.SegundoApellido + "\n" +
                    " Fecha de nacimiento: " + this.fechaNacimiento + "\n" +
                    " Peso: " + this.peso + "\n" +
                    " Genero: " + this.genero + "\n" +
                    " Telefono Celular: " + this.telefonoCelular + "\n" +
                    " Correo Electronico : " + this.correoElectronico + "\n";


            return datos;
        }

        #endregion
    }
}
