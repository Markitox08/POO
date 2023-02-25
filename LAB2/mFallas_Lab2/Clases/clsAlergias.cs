using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsAlergias
    {
        #region Atributos

        private int idAlergias, numeroIdentificacion;
        private string alergia;

        #endregion

        #region Cosntructores
        public clsAlergias()
        {
            this.idAlergias = 0;
            this.numeroIdentificacion = 0;
            this.alergia = "";
        }

        public clsAlergias(int IdAlergias, int NumeroIdentificacion,                           
                            string Alergia)
        {
            this.idAlergias = IdAlergias;
            this.numeroIdentificacion = NumeroIdentificacion;
            this.alergia = Alergia;

        }
        #endregion

        #region Metodos

        public int IdAlergias

        {
            set { idAlergias = value; }
            get { return idAlergias; }
        }

        public int NumeroIdentificacion
        {
            set { numeroIdentificacion = value; }
            get { return numeroIdentificacion; }
        }

        public string Alergias
        {
            set { alergia = value; }
            get { return alergia; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdCliente: " + this.idAlergias + "\n" +
                    " Numero identificacion del Cliente : " + this.numeroIdentificacion + "\n" +
                    " Alergias: " + this.alergia + "\n";

            return datos;
        }

        #endregion
    }
}
