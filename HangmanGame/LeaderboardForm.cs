using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            listBoxLeaderboard.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT login, points FROM Users ORDER BY points DESC LIMIT 10";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxLeaderboard.Items.Add($"{reader["login"]} - {reader["points"]} points");
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

