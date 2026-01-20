using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class CategoryRepository
    {
        // Tworzy now¹ kategoriê w bazie danych
        public void Create(Category category)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO dbo.Kategorie (ID_Rodzica, Nazwa) VALUES (@ID_Rodzica, @Nazwa)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Rodzica", (object?)category.ID_Rodzica ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Nazwa", category.Nazwa);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating category: " + ex.Message);
            }
        }

        // Pobiera pojedyncz¹ kategoriê po ID
        public Category? Read(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Kategorii, ID_Rodzica, Nazwa FROM dbo.Kategorie WHERE ID_Kategorii = @ID_Kategorii";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Kategorii", id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Category
                                {
                                    ID_Kategorii = (int)reader["ID_Kategorii"],
                                    ID_Rodzica = reader["ID_Rodzica"] != DBNull.Value ? (int?)reader["ID_Rodzica"] : null,
                                    Nazwa = reader["Nazwa"].ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading category: " + ex.Message);
            }
        }

        // Zwraca wszystkie kategorie z bazy
        public List<Category> ReadAll()
        {
            var categories = new List<Category>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Kategorii, ID_Rodzica, Nazwa FROM dbo.Kategorie";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categories.Add(new Category
                                {
                                    ID_Kategorii = (int)reader["ID_Kategorii"],
                                    ID_Rodzica = reader["ID_Rodzica"] != DBNull.Value ? (int?)reader["ID_Rodzica"] : null,
                                    Nazwa = reader["Nazwa"].ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all categories: " + ex.Message);
            }
            return categories;
        }

        // Aktualizuje istniej¹c¹ kategoriê
        public void Update(Category category)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE dbo.Kategorie SET ID_Rodzica = @ID_Rodzica, Nazwa = @Nazwa WHERE ID_Kategorii = @ID_Kategorii";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Kategorii", category.ID_Kategorii);
                        command.Parameters.AddWithValue("@ID_Rodzica", (object?)category.ID_Rodzica ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Nazwa", category.Nazwa);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating category: " + ex.Message);
            }
        }

        // Usuwa kategoriê z bazy
        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Kategorie WHERE ID_Kategorii = @ID_Kategorii";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Kategorii", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting category: " + ex.Message);
            }
        }
    }
}