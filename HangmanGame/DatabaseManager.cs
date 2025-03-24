using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HangmanGame
{
    public static class DatabaseManager
    {
        private static string dbPath = "database.db";

        public static bool TryLogin(string login, string password, out bool isNewUser, out string role)
        {
            isNewUser = false;
            role = "user";
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                string checkUserQuery = "SELECT password FROM Users WHERE login = @login";
                using (var command = new SQLiteCommand(checkUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string getRoleQuery = "SELECT role FROM Users WHERE login = @login";
                        using (var roleCommand = new SQLiteCommand(getRoleQuery, connection))
                        {
                            roleCommand.Parameters.AddWithValue("@login", login);
                            role = roleCommand.ExecuteScalar()?.ToString() ?? "user";
                        }
                        // pārbaudam hešu
                        return Hashing.CheckPasswordHash(password, result.ToString());
                    }
                    else
                    {
                        isNewUser = true;
                        // veidojam hašu
                        string hashedPassword = Hashing.GeneratePasswordHash(password);

                        string insertUserQuery = "INSERT INTO Users (login, password, points, words, role) VALUES (@login, @password, 0, 0, 'user')";
                        using (var insertCommand = new SQLiteCommand(insertUserQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@login", login);
                            insertCommand.Parameters.AddWithValue("@password", hashedPassword);
                            insertCommand.ExecuteNonQuery();
                        }
                        return true;
                    }
                }
            }
        }
    }
}
