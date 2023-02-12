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
            sintomas = "";
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

        public int identificador

        {
            set { identificador = value; }
            get { return identificador; }
        }

        public string sintomas

        #endregion

    }


}
