using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA.Clases
{
    public class clsMascota
    {
        #region Atributos
        private int identificador; //todo atributo va en minuscula
        private string nombre, alergias;
        private DateTime fechaNacimiento;
        private char sexo;
        private decimal peso;
        private int idPropietario;
        #endregion

        #region
        public clsMascota()
        {
            this.identificador = 0;
            this.nombre= "";
            this.fechaNacimiento = Convert.ToDateTime("01/01/1990");
            this.sexo = '*';
            this.peso = 0;
            this.alergias= "";
            this.idPropietario= 0;
        }
        public clsMascota(int identificador, string nombre, string alergias, DateTime fechaNacimiento, char sexo, decimal peso, int idPropietario)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.alergias = alergias;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.peso = peso;
            this.idPropietario = idPropietario;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string dato = "";
            dato = " Nombre:  " + this.nombre + "\n"+
                  " Fecha de Nacimiento: " + this.fechaNacimiento + "\n"+
                  " Sexo: " + this.sexo + "\n"+
                  " Peso: " + this.peso + "\n"+
                  " Alergias: " + this.alergias + "\n"+
                  " Id Propietario: " + this.idPropietario;
            return dato;
        }
        #endregion


        #region Metodos

        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }
        public String Nombre
        {
            set { nombre = value.ToUpper(); }
            get { return nombre; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public decimal Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public string Alergias
        {
            set { alergias = value; }
            get { return alergias; }
        }

        public int IdentificacionPropietario
        {
            set { idPropietario = value; }
            get { return idPropietario; }
        }

        #endregion
    }
}
