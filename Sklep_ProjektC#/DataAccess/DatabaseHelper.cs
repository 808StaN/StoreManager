using System.Data;
using System.Data.SqlClient;

namespace SklepProjektC.DataAccess
{
    public static class DatabaseHelper
    {
        // Connection string bêdzie ustawiany dynamicznie po zalogowaniu
        private static string connectionString = string.Empty;

        // Ustawia connection string po pomyœlnym zalogowaniu
        public static void SetConnectionString(string server, string database, string userId, string password)
        {
            connectionString = $"Server={server};Database={database};" +
                             $"User Id={userId};Password={password};" +
                             $"Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        // Zwraca nowe po³¹czenie do bazy
        public static SqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Brak po³¹czenia z baz¹ danych. Najpierw zaloguj siê.");
            }
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

        // Sprawdza czy connection string jest ustawiony
        public static bool IsConnected()
        {
            return !string.IsNullOrEmpty(connectionString);
        }

        // Czyœci connection string (wylogowanie)
        public static void ClearConnection()
        {
            connectionString = string.Empty;
        }
    }
}