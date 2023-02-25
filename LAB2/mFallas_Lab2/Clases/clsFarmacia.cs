using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsFarmacia
    {
        #region Atributos

        private int idFarmacia;
        private string cedulaJuridica, nombre, correoElectronico, telefono;
        #endregion

        #region Cosntructores
        public clsFarmacia()
        {
            this.idFarmacia = 0;
            this.cedulaJuridica = "";
            this.nombre = "";
            this.correoElectronico = "";
            this.telefono = "";
        }

        public clsFarmacia(int IdFarmacia, string Nombre, 
                            string CedulaJuridica, string CorreoElectronico,
                            string Telefono)
        {
            this.idFarmacia = IdFarmacia;
            this.cedulaJuridica = CedulaJuridica;
            this.nombre = Nombre;
            this.correoElectronico = CorreoElectronico;
            this.telefono = Telefono;
        }
        #endregion

        #region Metodos

        public int IdFarmacia

        {
            set { idFarmacia= value; }
            get { return idFarmacia; }
        }
        public string CedulaJuridica
        {
            set { cedulaJuridica = value; }
            get { return cedulaJuridica; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string CorreoElectronico
        {
            set { correoElectronico = value; }
            get { return correoElectronico; }
        }
        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " Id Farmacia: " + this.idFarmacia + "\n" +
                    " Cedual Juridica: " + this.cedulaJuridica + "\n" +
                    " Nombre: " + this.nombre + "\n" +
                    " Telefono : " + this.telefono + "\n" +
                    " Correo Electronico : " + this.correoElectronico + "\n";

            return datos;
        }

        #endregion
    }
}
