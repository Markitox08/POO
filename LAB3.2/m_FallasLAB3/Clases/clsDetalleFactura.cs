using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_FallasLAB3.Clases
{
    public class clsDetalleFactura
    {

        #region Atributos
        private int idDetalleFactura, idReceta, idFactura, 
                    iva, catidadMedicamentos;
        private decimal subtotal;

        #endregion

        #region Cosntructores
        public clsDetalleFactura()
        {
            this.idDetalleFactura = 0;
            this.idReceta = 0;
            this.idFactura = 0;
            this.iva = 0;
            this.catidadMedicamentos = 0;
            this.subtotal = 0;
        }

        public clsDetalleFactura( int IdDetalleFactura, int IdReceta,
                                  int IdFactura, int Iva,
                                  int CatidadMedicamentos, decimal Sudtotal)
        {
            this.idDetalleFactura = IdDetalleFactura;
            this.idReceta = IdReceta;
            this.idFactura = IdFactura;
            this.iva = Iva;
            this.catidadMedicamentos = CatidadMedicamentos;
            this.subtotal = Sudtotal;
        }
        #endregion

        #region Metodos

        public int IdDetalleFactura

        {
            set { idDetalleFactura = value; }
            get { return idDetalleFactura; }
        }

        public int IdReceta
        {
            set { idReceta = value; }
            get { return idReceta; }
        }
        public int IdFactura
        {
            set { idFactura = value; }
            get { return idFactura; }
        }
       
        public int Iva
        {
            set { iva = value; }
            get { return iva; }
        }
        public int CatidadMedicamentos
        {
            set { catidadMedicamentos = value; }
            get { return catidadMedicamentos; }
        }
        public decimal Sudtotal
        {
            set { subtotal = value; }
            get { return subtotal; }
        }
       
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " Id Detalle Factura: " + this.idDetalleFactura + "\n" +
                    " Id Receta: " + this.idReceta + "\n" +
                    " Id Factura : " + this.idFactura + "\n" +
                    " Iva : " + this.iva + "\n" +
                    " Catidad de Medicamentos : " + this.catidadMedicamentos + "\n" +
                    " Subtotal : " + this.subtotal + "\n";

            return datos;
        }

        #endregion
    }
}
