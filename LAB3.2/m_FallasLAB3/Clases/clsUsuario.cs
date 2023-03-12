using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_FallasLAB3.Clases
{
    public class clsUsuario
    {
        #region Atributos
        private int idUsuario;
        private string usuario,clave, estado, nombre, apellidos, identificacion;
        private DateTime fechaRegistro, fechaActualizado;
        private String registradoPor, actualizadoPor;
        #endregion

        #region constructor

        public clsUsuario(String usu, String cla)
        {
            this.usuario = usu;
            this.clave = cla;

        }
        //para Modificar
        public clsUsuario(int id, String usua, String clav, String iden, String esta, String nomb, String apell, String acp, DateTime fea)
        {
            this.idUsuario = id;
            this.usuario = usua;
            this.clave = clav;
            this.estado = esta;
            this.identificacion = iden;
            this.nombre = nomb;
            this.apellidos = apell;
            this.actualizadoPor = acp;
            this.fechaActualizado = fea;

        }
        //para registro
       public clsUsuario(String usu, String cla, String ide, String est, String nom, String ape, String rtp, DateTime fer)
        {
            this.usuario = usu;
            this.clave = cla;
            this.estado = est;
            this.identificacion = ide;
            this.nombre= nom;
            this.apellidos = ape;
            this.registradoPor= rtp;
            this.fechaRegistro= fer;

        }
        public clsUsuario()
        {
            this.idUsuario = 0;
            this.clave = "";
            this.usuario = "";
        }
        public clsUsuario( int identificador, string clave, string usuario)
        {
            this.idUsuario = identificador;
            this.clave = clave;
            this.usuario = usuario;
        }
        #endregion

        #region Metodos

        public int IdUsuarios

        {
            set { idUsuario = value; }
            get { return idUsuario; }
        }
        public String Identificacion

        {
            set { identificacion = value; }
            get { return identificacion; }
        }
        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Clave
        {
            set { clave = value; }
            get { return clave; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellidos
        {
            set { apellidos = value; }
            get { return apellidos; }
        }
        public string RegistardoPor
        {
            set { registradoPor = value; }
            get { return registradoPor; }
        }
        public string ActualizadoPor
        {
            set { actualizadoPor = value; }
            get { return actualizadoPor; }
        }
        public DateTime FechaRegistro
        {
            set { fechaRegistro = value; }
            get { return fechaRegistro; }
        }
        public DateTime FechaActualizado
        {
            set { fechaActualizado = value; }
            get { return fechaActualizado; }
        }
        #endregion

        #region Funciones y Procedimientos

        public String imprimirDatos()
        {
            string datos = "";
            datos = " IdUsuarios: " + this.idUsuario + "\n" +
                    " Usuario: " + this.usuario + "\n" +
                    " Clave: " + this.clave + "\n";

            return datos;
        }

        #endregion
    }
}
