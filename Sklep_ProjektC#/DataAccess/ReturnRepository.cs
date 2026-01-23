using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class ReturnRepository
    {
        // Dodaje nowy zwrot do bazy
        public void Create(Return returnItem)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO dbo.Zwroty (ID_Zamowienia, Powod, StatusZwrotu) 
                                   VALUES (@ID_Zamowienia, @Powod, @StatusZwrotu)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zamowienia", returnItem.ID_Zamowienia);
                        command.Parameters.AddWithValue("@Powod", returnItem.Powod);
                        command.Parameters.AddWithValue("@StatusZwrotu", returnItem.StatusZwrotu);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating return: " + ex.Message);
            }
        }

        // Pobiera wszystkie zwroty z bazy
        public List<Return> ReadAll()
        {
            var returns = new List<Return>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM dbo.Zwroty";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                returns.Add(new Return
                                {
                                    ID_Zwrotu = (int)reader["ID_Zwrotu"],
                                    ID_Zamowienia = (int)reader["ID_Zamowienia"],
                                    Powod = reader["Powod"].ToString() ?? string.Empty,
                                    StatusZwrotu = reader["StatusZwrotu"].ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading returns: " + ex.Message);
            }
            return returns;
        }

        // Aktualizuje istniej¹cy zwrot
        public void Update(Return returnItem)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"UPDATE dbo.Zwroty 
                                   SET ID_Zamowienia = @ID_Zamowienia, 
                                       Powod = @Powod, 
                                       StatusZwrotu = @StatusZwrotu 
                                   WHERE ID_Zwrotu = @ID_Zwrotu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zwrotu", returnItem.ID_Zwrotu);
                        command.Parameters.AddWithValue("@ID_Zamowienia", returnItem.ID_Zamowienia);
                        command.Parameters.AddWithValue("@Powod", returnItem.Powod);
                        command.Parameters.AddWithValue("@StatusZwrotu", returnItem.StatusZwrotu);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating return: " + ex.Message);
            }
        }

        // Usuwa zwrot z bazy
        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Zwroty WHERE ID_Zwrotu = @ID_Zwrotu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zwrotu", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting return: " + ex.Message);
            }
        }
    }
}
