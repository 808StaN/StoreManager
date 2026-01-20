using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class ProductVariantRepository
    {
        public void Create(ProductVariant variant)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO dbo.WariantyProduktu 
                                   (ID_Produktu, ID_Rozmiaru, ID_Koloru, StanMagazynowy, KodEAN) 
                                   VALUES (@ID_Produktu, @ID_Rozmiaru, @ID_Koloru, @StanMagazynowy, @KodEAN)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Produktu", variant.ID_Produktu);
                        command.Parameters.AddWithValue("@ID_Rozmiaru", variant.ID_Rozmiaru);
                        command.Parameters.AddWithValue("@ID_Koloru", variant.ID_Koloru);
                        command.Parameters.AddWithValue("@StanMagazynowy", variant.StanMagazynowy);
                        command.Parameters.AddWithValue("@KodEAN", variant.KodEAN);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating product variant: " + ex.Message);
            }
        }

        public List<ProductVariant> ReadAll()
        {
            var variants = new List<ProductVariant>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM dbo.WariantyProduktu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var variant = new ProductVariant
                                {
                                    ID_Wariantu = (int)reader["ID_Wariantu"],
                                    ID_Produktu = (int)reader["ID_Produktu"],
                                    ID_Rozmiaru = (int)reader["ID_Rozmiaru"],
                                    ID_Koloru = (int)reader["ID_Koloru"],
                                    StanMagazynowy = (int)reader["StanMagazynowy"]
                                };

                                // Bezpieczne odczytanie KodEAN
                                try
                                {
                                    int kodEANOrdinal = reader.GetOrdinal("KodEAN");
                                    variant.KodEAN = reader.IsDBNull(kodEANOrdinal) ? string.Empty : reader.GetString(kodEANOrdinal);
                                }
                                catch
                                {
                                    variant.KodEAN = string.Empty;
                                }

                                variants.Add(variant);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading product variants: " + ex.Message);
            }
            return variants;
        }

        public void Update(ProductVariant variant)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = @"UPDATE dbo.WariantyProduktu 
                                   SET ID_Produktu = @ID_Produktu, 
                                       ID_Rozmiaru = @ID_Rozmiaru, 
                                       ID_Koloru = @ID_Koloru, 
                                       StanMagazynowy = @StanMagazynowy, 
                                       KodEAN = @KodEAN 
                                   WHERE ID_Wariantu = @ID_Wariantu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Wariantu", variant.ID_Wariantu);
                        command.Parameters.AddWithValue("@ID_Produktu", variant.ID_Produktu);
                        command.Parameters.AddWithValue("@ID_Rozmiaru", variant.ID_Rozmiaru);
                        command.Parameters.AddWithValue("@ID_Koloru", variant.ID_Koloru);
                        command.Parameters.AddWithValue("@StanMagazynowy", variant.StanMagazynowy);
                        command.Parameters.AddWithValue("@KodEAN", variant.KodEAN);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating product variant: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.WariantyProduktu WHERE ID_Wariantu = @ID_Wariantu";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Wariantu", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product variant: " + ex.Message);
            }
        }
    }
}
