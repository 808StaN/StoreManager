using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class StatusRepository
    {
        public List<Status> ReadAll()
        {
            var statuses = new List<Status>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Statusu, Nazwa FROM dbo.StatusyZamowienia";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                statuses.Add(new Status
                                {
                                    ID_Statusu = (int)reader["ID_Statusu"],
                                    Nazwa = reader["Nazwa"].ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all statuses: " + ex.Message);
            }
            return statuses;
        }
    }

    public class Status
    {
        public int ID_Statusu { get; set; }
        public string Nazwa { get; set; } = string.Empty;
    }
}