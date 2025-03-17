using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class TopicSelectionForm : Form
    {
        private string username;

        public TopicSelectionForm(string user)
        {
            InitializeComponent();
            username = user;
            LoadTopics();
        }

        private void LoadTopics()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT topic FROM Topics";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string topic = reader.GetString(0);
                    Console.WriteLine("Loaded topic: " + topic);
                    listBoxTopics.Items.Add(topic);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem != null)
            {
                string selectedTopic = listBoxTopics.SelectedItem.ToString();
                GameForm gameForm = new GameForm(username, selectedTopic); // Передаем selectedTopic в конструктор
                gameForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите тему!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm(username);
            mainMenu.Show();
            this.Close();
        }
    }
}