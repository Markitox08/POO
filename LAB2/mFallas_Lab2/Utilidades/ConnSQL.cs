using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mFallas_Lab2.Utilidades
{
    public class ConnSQL
    {
        public SqlDateReader SQLCargaDataReader(string _SQLConnection, string SQLQuery)
        {
            SqlConnection cn = new _SQLConnection();
            SqlCommand sqlCommand = new SqlCommand(SQLQuery, cn);
            SqlDataReader dr;

            try
            {
                cn = new SqlConnection(_SQLConnection);
                if ((cn.State == ConnectionState)) 
                {
                    cn.Open();
                }
                sqlCommand = new SqlCommand(SQLQuery, cn);
                sqlCommand.CommandTimeout = 300;

                dr = sqlCommand.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
                cn.Close();
                throw ex;
            }

        }
    }
}
