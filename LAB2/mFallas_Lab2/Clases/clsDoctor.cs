using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsDoctor
    {

        #region Atributos

        private int idDoctor;
        private string primerNombre, segundoNombre, primerApellido,
                       segundoApellido, codigoMedico, numeroIdentificacion;

        #endregion

        #region Cosntructores
        public clsDoctor()
        {
            this.idDoctor = 0;
            this.numeroIdentificacion = "";
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.codigoMedico = "";
        }

        public clsDoctor(int IdDoctor, string NumeroIdentificacion,
                            string PrimerNombre, string SegundoNombre,
                            string PrimerApellido, string SegundoApellido,
                            string CodigoMedico)
        {
            this.idDoctor = IdDoctor;
            this.numeroIdentificacion = NumeroIdentificacion;
            this.primerNombre = PrimerNombre;
            this.segundoNombre = SegundoNombre;
            this.primerApellido = PrimerApellido;
            this.segundoApellido = SegundoApellido;
            this.codigoMedico = CodigoMedico;
        }
        #endregion

        #region Metodos

        public int IdDoctor

        {
            set { idDoctor = value; }
            get { return idDoctor; }
        }

        public string NumeroIdentificacion
        {
            set { numeroIdentificacion = value; }
            get { return numeroIdentificacion; }
        }
        public string CodigoMedico
        {
            set { codigoMedico = value; }
            get { return codigoMedico; }
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
       
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdDoctor: " + this.idDoctor + "\n" +
                    " Numero identificacion : " + this.numeroIdentificacion + "\n" +
                    " Primer Nombre: " + this.primerNombre + "\n" +
                    " Segundo Nombre: " + this.segundoNombre + "\n" +
                    " Primer Apellido: " + this.primerApellido + "\n" +
                    " Segundo Apellido: " + this.SegundoApellido + "\n" +
                    " Codigo Medico: " + this.codigoMedico + "\n";

            return datos;
        }

        #endregion
    }
}
