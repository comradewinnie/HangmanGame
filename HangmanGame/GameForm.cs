using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class GameForm : Form
    {
        private string username;

        // lai korekti iegūtu izvēlēto tēmu
        private string _selectedTopic;
        public string SelectedTopic
        {
            get { return _selectedTopic; }
            private set { _selectedTopic = value; }
        }

        private string topic;
        private string wordToGuess;
        private char[] guessedWord;
        private int mistakes = 0;
        private int maxMistakes = 6;
        private int currentWordId;
        private List<Button> letterButtons = new List<Button>();

        public GameForm(string user, string selectedTopic)
        {
            InitializeComponent();
            username = user;
            SelectedTopic = selectedTopic;
            label2.Text = SelectedTopic;
            LoadWord();
        }

        private void LoadWord()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();

                string getTopicIdQuery = "SELECT id FROM Topics WHERE topic = @topic";
                using (SQLiteCommand getTopicIdCmd = new SQLiteCommand(getTopicIdQuery, conn))
                {
                    getTopicIdCmd.Parameters.AddWithValue("@topic", SelectedTopic);
                    object topicIdResult = getTopicIdCmd.ExecuteScalar();

                    int topicId = Convert.ToInt32(topicIdResult);
                    int userId = GetUserId();

                    bool wordFound = false;
                    while (!wordFound)
                    {
                        // izvēlamies nejaušu vārdu no tiem, kuri vēl nav atrisināti
                        string getWordQuery = @"
                                SELECT id, word FROM Words 
                                WHERE topic_id = @topic_id 
                                AND id NOT IN (SELECT word_id FROM SolvedWords WHERE user_id = @userId) 
                                ORDER BY RANDOM() LIMIT 1";

                        using (SQLiteCommand getWordCmd = new SQLiteCommand(getWordQuery, conn))
                        {
                            getWordCmd.Parameters.AddWithValue("@topic_id", topicId);
                            getWordCmd.Parameters.AddWithValue("@userId", userId);

                            using (SQLiteDataReader reader = getWordCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    wordToGuess = reader["word"].ToString().ToUpper();
                                    currentWordId = Convert.ToInt32(reader["id"]);
                                    wordFound = true;
                                    CreateLetterButtons();
                                }
                            }
                        }
                    }
                }
            }

            // pārvēršam vārdu par svītriņām
            guessedWord = new char[wordToGuess.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            lblWord.Text = string.Join(" ", guessedWord);
        }



        private void CreateLetterButtons()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int columns = 13;

            using (Graphics g = this.CreateGraphics())
            {
                // izmantots DPI, lai visos monitoros programma izskatītos vienādi
                float dpiScale = g.DpiX / 96f;
                int buttonSize = (int)(40 * dpiScale);
                int padding = (int)(2 * dpiScale);

                int keyboardWidth = columns * buttonSize + (columns - 1) * padding;
                int offsetX = (int)(100 * dpiScale);
                int startX = (this.ClientSize.Width - keyboardWidth) / 2 + offsetX;
                int startY = this.ClientSize.Height - (int)(250 * dpiScale);

                foreach (var btn in letterButtons)
                {
                    this.Controls.Remove(btn);
                }
                letterButtons.Clear();

                for (int i = 0; i < alphabet.Length; i++)
                {
                    Button btn = new Button
                    {
                        Text = alphabet[i].ToString(),
                        Width = buttonSize,
                        Height = buttonSize,
                        Location = new Point(startX + (buttonSize + padding) * (i % columns),
                                             startY + (buttonSize + padding) * (i / columns)),
                        Font = new Font("Showcard Gothic", 18 * dpiScale, FontStyle.Regular),
                        Tag = alphabet[i]
                    };

                    btn.Click += LetterButton_Click;
                    this.Controls.Add(btn);
                    letterButtons.Add(btn);
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

        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            char guessedLetter = (char)clickedButton.Tag;

            if (wordToGuess.Contains(guessedLetter))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                    }
                }

                lblWord.Text = string.Join(" ", guessedWord);

                if (!guessedWord.Contains('_'))
                {
                    int userId = GetUserId();
                    if (userId != -1)
                    {
                        UpdateUserStats(true, currentWordId, userId);
                    }
                    MessageBox.Show("Congratulations! You won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenuForm mainMenu = new MainMenuForm(username);
                    mainMenu.Show();
                    this.Close();
                }
            }
            else
            {
                mistakes++;
                DrawHangman();

                if (mistakes >= maxMistakes)
                {
                    int userId = GetUserId();
                    if (userId != -1)
                    {
                        UpdateUserStats(false, currentWordId, userId);
                    }
                    MessageBox.Show("Game over! The word was: " + wordToGuess, "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainMenuForm mainMenu = new MainMenuForm(username);
                    mainMenu.Show();
                    this.Close();
                }
            }

            clickedButton.Enabled = false;
        }

        private void DrawHangman()
        {
            // maina fonu no attēliem mapē
            string imagePath = $"Images/{mistakes + 1}vis.png";

            if (System.IO.File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void UpdateUserStats(bool won, int wordId, int userId)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();

                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = won ?
                            "UPDATE users SET points = points + 10, words = words + 1 WHERE id = @userId" :
                            "UPDATE users SET points = points - 5 WHERE id = @userId";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        string insertQuery = "INSERT INTO SolvedWords (word_id, user_id) VALUES (@wordId, @userId)";
                        using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@wordId", wordId);
                            insertCmd.Parameters.AddWithValue("@userId", userId);
                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error updating user stats: " + ex.Message);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm(username);
            mainMenu.Show();
            this.Close();
        }
    }
}