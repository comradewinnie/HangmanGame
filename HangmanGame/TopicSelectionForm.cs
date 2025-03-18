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

        private bool HasAvailableWords(string selectedTopic, int userId)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();

                // Получаем ID темы
                string getTopicIdQuery = "SELECT id FROM Topics WHERE topic = @topic";
                using (SQLiteCommand getTopicIdCmd = new SQLiteCommand(getTopicIdQuery, conn))
                {
                    getTopicIdCmd.Parameters.AddWithValue("@topic", selectedTopic);
                    object topicIdResult = getTopicIdCmd.ExecuteScalar();

                    if (topicIdResult == null)
                        return false; // Если темы нет, слов тоже нет

                    int topicId = Convert.ToInt32(topicIdResult);

                    // Проверяем, есть ли доступные слова, которые пользователь ещё не решил
                    string checkWordsQuery = @"
                SELECT COUNT(*) FROM Words 
                WHERE topic_id = @topic_id 
                AND id NOT IN (SELECT word_id FROM SolvedWords WHERE user_id = @userId)";

                    using (SQLiteCommand checkWordsCmd = new SQLiteCommand(checkWordsQuery, conn))
                    {
                        checkWordsCmd.Parameters.AddWithValue("@topic_id", topicId);
                        checkWordsCmd.Parameters.AddWithValue("@userId", userId);

                        int availableWords = Convert.ToInt32(checkWordsCmd.ExecuteScalar());
                        return availableWords > 0;
                    }
                }
            }
        }

        private int GetUserId()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();
                string getUserIdQuery = "SELECT id FROM users WHERE login = @username";
                using (SQLiteCommand getUserIdCmd = new SQLiteCommand(getUserIdQuery, conn))
                {
                    getUserIdCmd.Parameters.AddWithValue("@username", username);
                    object userIdResult = getUserIdCmd.ExecuteScalar();
                    return userIdResult != null ? Convert.ToInt32(userIdResult) : -1;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem != null)
            {
                string selectedTopic = listBoxTopics.SelectedItem.ToString();
                int userId = GetUserId();

                if (userId == -1)
                {
                    MessageBox.Show("Ошибка: Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!HasAvailableWords(selectedTopic, userId)) // Проверяем доступность слов
                {
                    MessageBox.Show("Вы уже решили все слова в этой теме!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GameForm gameForm = new GameForm(username, selectedTopic); // Открываем только если есть слова
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