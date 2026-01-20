using System.Data;
using System.Data.SqlClient;

namespace SklepProjektC.DataAccess
{
    public static class DatabaseHelper
    {
        // Connection string do bazy Azure
        private static readonly string connectionString = "Server=polska.database.windows.net;Database=72420_Sklep Internetowy - odzie¿ + obuwie;User Id=CloudSA48b973ec;Password=!@#QWE456rty;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Zwraca nowe po³¹czenie do bazy
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Sprawdza czy po³¹czenie z baz¹ dzia³a
        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}