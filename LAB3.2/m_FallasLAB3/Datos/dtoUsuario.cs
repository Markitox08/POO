using m_FallasLAB3.BD;
using m_FallasLAB3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace m_FallasLAB3.Datos
{
    public class dtoUsuario
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();

        //consulta
        public bool validarIngreso(clsUsuario datos)
        {
            try
            {
                string consulta = "SELECT Us_Usuario FROM Farmacia.dbo.TB_USUARIO WHERE Us_Usuario ='"
                    + datos.Usuario + "' AND Us_Clave = '" + datos.Clave + "'";

                var existe = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
                if (existe.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        //consulta
        public void consultarTodosUsuarios(ComboBox cmb)
        {
            try
            {
                string consulta = "SELECT Us_Usuario, Us_Clave, Us_Estado, Us_Nombre, Us_Apellidos, Us_Identificacion, Us_Estado, " +
                    "Us_IngresadoPor, Us_FechaIngreso, Us_ActualizadoPor, Us_FechaActualizado FROM Farmacia.dbo.TB_USUARIO";

                var usuarios = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
                if (usuarios.Rows.Count > 0)
                {
                    for (int i = 0; i < usuarios.Rows.Count; i++)
                    {
                        cmb.Items.Add(usuarios.Rows[i].ItemArray[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //guarda
        public bool guardarUsuario(clsUsuario datos)
        {
            try
            {
                string registro = "INSERT INTO Farmacia.dbo.TB_USUARIO VALUES ('" + datos.Usuario + "', '" + datos.Clave + "', '" + datos.Nombre + "', '" + datos.Apellidos + "', '" + datos.Estado + "', '" + datos.RegistardoPor + "', null , '" + datos.FechaRegistro + "', null, '" + datos.Identificacion + "')";
                conn.SQLExecuteCmm(_SQLConnection, registro);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        //modificar 
        public bool ActualizarUsuario(clsUsuario datos, string usuarioAnterior)
        {
            try
            {
                string actualizar = "UPDATE Farmacia.dbo.TB_USUARIO SET Us_Usuario = '" + datos.Usuario + "', Us_Clave = '" + datos.Clave + "', Us_Nombre = '" + datos.Nombre + "', Us_Apellidos = '" + datos.Apellidos + "', Us_Estado = '" + datos.Estado +"', Us_ActualizadoPor = '" + datos.ActualizadoPor + "', Us_FechaActualizado = '" + datos.FechaActualizado + "' WHERE Us_Usuario = '" + usuarioAnterior + "'";
                conn.SQLExecuteCmm(_SQLConnection, actualizar);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
