using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsReceta
    {
        #region Atributos

        private int idReceta, idHojaMedica;
        private string clinica, descripcionTratamiento, dosis;
        #endregion

        #region Cosntructores
        public clsReceta()
        {
            this.idReceta = 0;
            this.idHojaMedica = 0;
            this.clinica = "";
            this.descripcionTratamiento = "";
            this.dosis = "";
        }

        public clsReceta(int IdReceta, int IdHojaMedica,
                            string Clinica, string DescripcionTratamiento,
                            string Dosis)
        {
            this.idReceta = IdReceta;
            this.idHojaMedica = IdHojaMedica;
            this.clinica = Clinica;
            this.descripcionTratamiento = DescripcionTratamiento;
            this.dosis = Dosis;

        }
        #endregion

        #region Metodos

        public int IdRecetas

        {
            set { idReceta = value; }
            get { return idReceta; }
        }

        public int IdHojaMedica
        {
            set { idHojaMedica = value; }
            get { return idHojaMedica; }
        }
        public string Clinica
        {
            set { clinica = value; }
            get { return clinica; }
        }
        public string DescripcionTratamiento
        {
            set { descripcionTratamiento = value; }
            get { return descripcionTratamiento; }
        }
        public string Dosis
        {
            set { dosis = value; }
            get { return dosis; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdReceta: " + this.idReceta + "\n" +
                    " Hoja Medica: " + this.idHojaMedica + "\n" +
                    " Clinica : " + this.clinica + "\n" +
                    " Descripcion del tratamiento: " + this.descripcionTratamiento + "\n" +
                    " Dosis: " + this.dosis + "\n";

            return datos;
        }

        #endregion
    }
}
