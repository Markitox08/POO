using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA.Clases
{
    internal class clsHoja
    {
        #region Atributos
        private int identificador;
        private string sintomas, diagnostico, tratamiento;
        private int idMascota;
        #endregion

        #region Cosntructores

        public clsHoja()
        {
            this.identificador = 0;
            this.sintomas = "";
            this.diagnostico = "";
            this.tratamiento = "";
            this.idMascota = 0;
        }

        public clsHoja(int identificador, string sintomas, string diagnostico, string tratamiento, int idMascota)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.idMascota = idMascota;
        }
        #endregion

        #region Metodos

        public int Identificador

        {
            set { identificador = value; }
            get { return identificador; }
        }

        public string Sintomas
        {
            set { sintomas = value; }
            get { return sintomas; }
        }

        public string Diagnostico
        {
            set { diagnostico = value; }
            get { return diagnostico; }
        }
        public string Tratamiento
        {
            set { tratamiento = value; }
            get { return tratamiento; }
        }

        public int IdMascota

        {
            set { idMascota = value; }
            get { return idMascota; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " Sintomas: " + this.sintomas + "\n" +
                    " Diagnostico: " + this.diagnostico + "\n" +
                    " Tratamiento: " + this.tratamiento + "\n" +
                    " ID Mascota: " + this.idMascota;
            return datos;
        }

        #endregion

    }
}
