using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class ProfileForm : Form
    {
        private string username;

        public ProfileForm(string user)
        {
            InitializeComponent();
            username = user;
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT points, words, login FROM Users WHERE login = @username";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblNickname.Text = username;
                    lblPoints.Text = reader["points"].ToString();
                    lblSolvedWords.Text = reader["words"].ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}