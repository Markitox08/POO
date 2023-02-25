using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Clases
{
    public class clsHojaClinica
    {
        #region Atributos

        private int idHojaClinica, idDoctor, idCliente;
        private string sintomas, diagnostico;
        private DateTime fechaAtencion;

        #endregion

        #region Cosntructores
        public clsHojaClinica()
        {
            this.idCliente = 0;
            this.idDoctor = 0;
            this.idCliente = 0;
            this.sintomas = "";
            this.diagnostico = "";
            this.fechaAtencion = Convert.ToDateTime("01/01/1990");
        }

        public clsHojaClinica(int IdHojaMedica, int IdDoctor,
                            int IdCliente, string Sintomas,
                            string Diagnostico, DateTime FechaAtencion)
        { 
            this.idHojaClinica = IdHojaMedica;
            this.idCliente = IdCliente;
            this.idDoctor = IdDoctor;
            this.sintomas = Sintomas;
            this.diagnostico = Diagnostico;
            this.fechaAtencion = FechaAtencion;
        }
        #endregion

        #region Metodos

        public int IdClientes

        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public int IdDoctor
        {
            set { idDoctor = value; }
            get { return idDoctor; }
        }
        public int IdHojaMedica
        {
            set { idHojaClinica = value; }
            get { return idHojaClinica; }
        }
        public string Diagnostico
        {
            set { diagnostico = value; }
            get { return diagnostico; }
        }
        public string Sintomas
        {
            set { sintomas = value; }
            get { return sintomas; }
        }
        public DateTime FechaAtencion
        {
            set { fechaAtencion = value; }
            get { return fechaAtencion; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdCliente: " + this.idCliente + "\n" +
                    " Id Hoja Mediaca: " + this.idHojaClinica + "\n" +
                    " Id Doctor : " + this.idDoctor + "\n" +
                    " Fecha Atencion: " + this.fechaAtencion + "\n" +
                    " Sintomas: " + this.sintomas + "\n" +
                    " Diagnostico: " + this.diagnostico + "\n";

            return datos;
        }

        #endregion
    }
}
