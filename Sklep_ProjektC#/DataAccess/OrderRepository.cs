using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class OrderRepository
    {
        public void Create(Order order)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO dbo.Zamowienia (ID_Uzytkownika, DataZamowienia, ID_Statusu, WartoscCalkowita) VALUES (@ID_Uzytkownika, @DataZamowienia, @ID_Statusu, @WartoscCalkowita)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Uzytkownika", order.ID_Uzytkownika);
                        command.Parameters.AddWithValue("@DataZamowienia", order.DataZamowienia);
                        command.Parameters.AddWithValue("@ID_Statusu", order.ID_Statusu);
                        command.Parameters.AddWithValue("@WartoscCalkowita", order.WartoscCalkowita);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating order: " + ex.Message);
            }
        }

        public Order Read(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Zamowienia, ID_Uzytkownika, DataZamowienia, ID_Statusu, WartoscCalkowita FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zamowienia", id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Order
                                {
                                    ID_Zamowienia = (int)reader["ID_Zamowienia"],
                                    ID_Uzytkownika = (int)reader["ID_Uzytkownika"],
                                    DataZamowienia = (DateTime)reader["DataZamowienia"],
                                    ID_Statusu = (int)reader["ID_Statusu"],
                                    WartoscCalkowita = (decimal)reader["WartoscCalkowita"]
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading order: " + ex.Message);
            }
        }

        public List<Order> ReadAll()
        {
            var orders = new List<Order>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Zamowienia, ID_Uzytkownika, DataZamowienia, ID_Statusu, WartoscCalkowita FROM dbo.Zamowienia";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders.Add(new Order
                                {
                                    ID_Zamowienia = (int)reader["ID_Zamowienia"],
                                    ID_Uzytkownika = (int)reader["ID_Uzytkownika"],
                                    DataZamowienia = (DateTime)reader["DataZamowienia"],
                                    ID_Statusu = (int)reader["ID_Statusu"],
                                    WartoscCalkowita = (decimal)reader["WartoscCalkowita"]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all orders: " + ex.Message);
            }
            return orders;
        }

        public void Update(Order order)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE dbo.Zamowienia SET ID_Uzytkownika = @ID_Uzytkownika, DataZamowienia = @DataZamowienia, ID_Statusu = @ID_Statusu, WartoscCalkowita = @WartoscCalkowita WHERE ID_Zamowienia = @ID_Zamowienia";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zamowienia", order.ID_Zamowienia);
                        command.Parameters.AddWithValue("@ID_Uzytkownika", order.ID_Uzytkownika);
                        command.Parameters.AddWithValue("@DataZamowienia", order.DataZamowienia);
                        command.Parameters.AddWithValue("@ID_Statusu", order.ID_Statusu);
                        command.Parameters.AddWithValue("@WartoscCalkowita", order.WartoscCalkowita);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating order: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Zamowienia WHERE ID_Zamowienia = @ID_Zamowienia";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Zamowienia", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting order: " + ex.Message);
            }
        }
    }
}