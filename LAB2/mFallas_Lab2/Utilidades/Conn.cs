using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFallas_Lab2.Utilidades
{
    public class Conn
    {
        Conn() 
        {
            
        }
        public static string GetConnectionString()
        {
            string resultado = "";
            ConnectionStringSettingsCollection settingsCollection = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {

                resultado = settings[0].ConnectionString;
            }
            return resultado;
        }
    }
}
