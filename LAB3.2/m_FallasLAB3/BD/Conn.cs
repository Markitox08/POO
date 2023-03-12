using System.Configuration;

namespace m_FallasLAB3.BD
{
    public class Conn
    {
        Conn()
        {

        }
        public static string GetConnectionStrings()
        {
            string resultado = "";
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                resultado = settings[0].ConnectionString;
            }
            return resultado;
        }
    }
}
