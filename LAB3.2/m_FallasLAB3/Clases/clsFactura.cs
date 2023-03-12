using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_FallasLAB3.Clases
{
    public class clsFactura
    {

        #region Atributos

        private int idFactura, idFarmacia;
        private float totalPago;
        private string formaPago;

        #endregion

        #region Cosntructores
        public clsFactura()
        {
            this.idFactura = 0;
            this.idFarmacia = 0;
            this.totalPago = 0;
            this.formaPago = "";
        }

        public clsFactura(int IdFactura, int IdFarmacia,
                            float TotalPago, string FormaPago)
        {
            this.idFactura = IdFactura;
            this.idFarmacia = IdFarmacia;
            this.totalPago = TotalPago;
            this.formaPago = FormaPago;
        }
        #endregion

        #region Metodos

        public int IdFactura

        {
            set { idFactura = value; }
            get { return idFactura; }
        }

        public int IdFarmacia
        {
            set { idFarmacia = value; }
            get { return idFarmacia; }
        }
        public float TotalPago
        {
            set { totalPago = value; }
            get { return totalPago; }
        }
        public string FormaPago
        {
            set { formaPago = value; }
            get { return formaPago; }
        }
       
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " Id Farmacia: " + this.idFarmacia + "\n" +
                    " Id Farmacia: " + this.idFarmacia + "\n" +
                    " Total a Pago : " + this.totalPago + "\n" +
                    " Forma de Pago: " + this.formaPago + "\n";

            return datos;
        }

        #endregion
    }
}
