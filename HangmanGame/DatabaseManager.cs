using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HangmanGame
{
    public static class DatabaseManager
    {
        private static string dbPath = "database.db";

        public static bool TryLogin(string login, string password, out bool isNewUser)
        {
            isNewUser = false;
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
                        return result.ToString() == password;
                    }
                    else
                    {
                        isNewUser = true;
                        string insertUserQuery = "INSERT INTO Users (login, password, points, words, role) VALUES (@login, @password, 0, 0, 'user')";
                        using (var insertCommand = new SQLiteCommand(insertUserQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@login", login);
                            insertCommand.Parameters.AddWithValue("@password", password);
                            insertCommand.ExecuteNonQuery();
                        }
                        return true;
                    }
                }
            }
        }
    }

}
