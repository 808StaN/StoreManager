using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class BrandRepository
    {
        // Dodaje now¹ markê do bazy
        public void Create(Brand brand)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO dbo.Marki (Nazwa, Opis) 
                                   VALUES (@Nazwa, @Opis)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nazwa", brand.Nazwa);
                        command.Parameters.AddWithValue("@Opis", brand.Opis);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating brand: " + ex.Message);
            }
        }

        // Pobiera wszystkie marki z bazy
        public List<Brand> ReadAll()
        {
            var brands = new List<Brand>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM dbo.Marki";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                brands.Add(new Brand
                                {
                                    ID_Marki = (int)reader["ID_Marki"],
                                    Nazwa = reader["Nazwa"].ToString() ?? string.Empty,
                                    Opis = reader["Opis"].ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading brands: " + ex.Message);
            }
            return brands;
        }

        // Aktualizuje istniej¹c¹ markê
        public void Update(Brand brand)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"UPDATE dbo.Marki 
                                   SET Nazwa = @Nazwa, 
                                       Opis = @Opis 
                                   WHERE ID_Marki = @ID_Marki";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Marki", brand.ID_Marki);
                        command.Parameters.AddWithValue("@Nazwa", brand.Nazwa);
                        command.Parameters.AddWithValue("@Opis", brand.Opis);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating brand: " + ex.Message);
            }
        }

        // Usuwa markê z bazy
        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Marki WHERE ID_Marki = @ID_Marki";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Marki", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting brand: " + ex.Message);
            }
        }
    }
}
