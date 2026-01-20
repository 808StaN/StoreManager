using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class ProductRepository
    {
        public void Create(Product product)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO dbo.Produkty (Nazwa, Opis, CenaBazowa, ID_Kategorii, ID_Marki) VALUES (@Nazwa, @Opis, @CenaBazowa, @ID_Kategorii, @ID_Marki)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nazwa", product.Nazwa);
                        command.Parameters.AddWithValue("@Opis", product.Opis);
                        command.Parameters.AddWithValue("@CenaBazowa", product.CenaBazowa);
                        command.Parameters.AddWithValue("@ID_Kategorii", product.ID_Kategorii);
                        command.Parameters.AddWithValue("@ID_Marki", product.ID_Marki);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error
                throw new Exception("Error creating product: " + ex.Message);
            }
        }

        public Product Read(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Produktu, Nazwa, Opis, CenaBazowa, ID_Kategorii, ID_Marki FROM dbo.Produkty WHERE ID_Produktu = @ID_Produktu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Product
                                {
                                    ID_Produktu = (int)reader["ID_Produktu"],
                                    Nazwa = reader["Nazwa"].ToString(),
                                    Opis = reader["Opis"].ToString(),
                                    CenaBazowa = (decimal)reader["CenaBazowa"],
                                    ID_Kategorii = (int)reader["ID_Kategorii"],
                                    ID_Marki = (int)reader["ID_Marki"]
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading product: " + ex.Message);
            }
        }

        public List<Product> ReadAll()
        {
            var products = new List<Product>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Produktu, Nazwa, Opis, CenaBazowa, ID_Kategorii, ID_Marki FROM dbo.Produkty";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ID_Produktu = (int)reader["ID_Produktu"],
                                    Nazwa = reader["Nazwa"].ToString(),
                                    Opis = reader["Opis"].ToString(),
                                    CenaBazowa = (decimal)reader["CenaBazowa"],
                                    ID_Kategorii = (int)reader["ID_Kategorii"],
                                    ID_Marki = (int)reader["ID_Marki"]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all products: " + ex.Message);
            }
            return products;
        }

        public void Update(Product product)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE dbo.Produkty SET Nazwa = @Nazwa, Opis = @Opis, CenaBazowa = @CenaBazowa, ID_Kategorii = @ID_Kategorii, ID_Marki = @ID_Marki WHERE ID_Produktu = @ID_Produktu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", product.ID_Produktu);
                        command.Parameters.AddWithValue("@Nazwa", product.Nazwa);
                        command.Parameters.AddWithValue("@Opis", product.Opis);
                        command.Parameters.AddWithValue("@CenaBazowa", product.CenaBazowa);
                        command.Parameters.AddWithValue("@ID_Kategorii", product.ID_Kategorii);
                        command.Parameters.AddWithValue("@ID_Marki", product.ID_Marki);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating product: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Produkty WHERE ID_Produktu = @ID_Produktu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product: " + ex.Message);
            }
        }
    }
}