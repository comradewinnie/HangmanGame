using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HangmanGame
{
    class DatabaseInitializer
    {
        static void Main()
        {
            string dbPath = "database.db";
            SQLiteConnection.CreateFile(dbPath);

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                string createTablesQuery = @"
                    CREATE TABLE Topics (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        topic TEXT NOT NULL
                    );

                    CREATE TABLE Words (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        word TEXT NOT NULL,
                        topic_id INTEGER NOT NULL,
                        FOREIGN KEY (topic_id) REFERENCES Topics(id)
                    );

                    CREATE TABLE Users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        login TEXT NOT NULL,
                        password TEXT NOT NULL,
                        points INTEGER,
                        words INTEGER,
                        role TEXT NOT NULL
                    );

                    CREATE TABLE Sessions (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        datetime TEXT NOT NULL,
                        user_id INTEGER NOT NULL,
                        FOREIGN KEY (user_id) REFERENCES Users(id)
                    );";

                using (var command = new SQLiteCommand(createTablesQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string insertDataQuery = @"
                    INSERT INTO Topics (topic) VALUES ('animals'), ('technology'), ('food');

                    INSERT INTO Words (word, topic_id) VALUES ('apple', 3), ('computer', 2), ('racoon', 1);

                    INSERT INTO Users (login, password, points, words, role) VALUES
                    ('admin', 'admin', NULL, NULL, 'admin'),
                    ('pineapple123', '12345', 40, 8, 'user'),
                    ('blueberry345', '67890', 30, 6, 'user');

                    INSERT INTO Sessions (datetime, user_id) VALUES
                    ('2025-03-02 14:37:25', 2),
                    ('2025-03-01 12:35:27', 2),
                    ('2025-02-28 02:05:09', 3);
                ";

                using (var command = new SQLiteCommand(insertDataQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Database created and populated successfully.");
        }
    }
}
