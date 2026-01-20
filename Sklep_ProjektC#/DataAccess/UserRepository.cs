using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SklepProjektC.Models;

namespace SklepProjektC.DataAccess
{
    public class UserRepository
    {
        public void Create(User user)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO dbo.Uzytkownicy (Imie, Nazwisko, Rola, Email, HasloHash) VALUES (@Imie, @Nazwisko, @Rola, @Email, @HasloHash)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", user.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", user.Nazwisko);
                        command.Parameters.AddWithValue("@Rola", user.Rola);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@HasloHash", user.HasloHash);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating user: " + ex.Message);
            }
        }

        public User Read(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Uzytkownika, Imie, Nazwisko, Rola, Email, HasloHash FROM dbo.Uzytkownicy WHERE ID_Uzytkownika = @ID_Uzytkownika";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Uzytkownika", id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    ID_Uzytkownika = (int)reader["ID_Uzytkownika"],
                                    Imie = reader["Imie"].ToString() ?? string.Empty,
                                    Nazwisko = reader["Nazwisko"].ToString() ?? string.Empty,
                                    Rola = reader["Rola"].ToString() ?? string.Empty,
                                    Email = reader["Email"].ToString() ?? string.Empty,
                                    HasloHash = reader["HasloHash"].ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading user: " + ex.Message);
            }
        }

        public List<User> ReadAll()
        {
            var users = new List<User>();
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT ID_Uzytkownika, Imie, Nazwisko, Rola, Email, HasloHash FROM dbo.Uzytkownicy";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new User
                                {
                                    ID_Uzytkownika = (int)reader["ID_Uzytkownika"],
                                    Imie = reader["Imie"].ToString() ?? string.Empty,
                                    Nazwisko = reader["Nazwisko"].ToString() ?? string.Empty,
                                    Rola = reader["Rola"].ToString() ?? string.Empty,
                                    Email = reader["Email"].ToString() ?? string.Empty,
                                    HasloHash = reader["HasloHash"].ToString() ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading all users: " + ex.Message);
            }
            return users;
        }

        public void Update(User user)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE dbo.Uzytkownicy SET Imie = @Imie, Nazwisko = @Nazwisko, Rola = @Rola, Email = @Email, HasloHash = @HasloHash WHERE ID_Uzytkownika = @ID_Uzytkownika";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Uzytkownika", user.ID_Uzytkownika);
                        command.Parameters.AddWithValue("@Imie", user.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", user.Nazwisko);
                        command.Parameters.AddWithValue("@Rola", user.Rola);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@HasloHash", user.HasloHash);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM dbo.Uzytkownicy WHERE ID_Uzytkownika = @ID_Uzytkownika";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Uzytkownika", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user: " + ex.Message);
            }
        }
    }
}