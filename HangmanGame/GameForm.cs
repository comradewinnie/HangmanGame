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
        private string _selectedTopic;  // Закрытое поле
        public string SelectedTopic
        {
            get { return _selectedTopic; }
            private set { _selectedTopic = value; }  // Можно только присвоить значение при инициализации
        }
        private string topic;
        private string wordToGuess;
        private char[] guessedWord;
        private int mistakes = 0;
        private int maxMistakes = 6;
        private List<Button> letterButtons = new List<Button>();

        public GameForm(string user, string selectedTopic)
        {
            InitializeComponent();
            username = user;
            SelectedTopic = selectedTopic;
            label2.Text = SelectedTopic;
            LoadWord();
            CreateLetterButtons();
        }

        private void LoadWord()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();

                // Получаем topic_id по названию темы

                string getTopicIdQuery = "SELECT id FROM Topics WHERE topic = @topic";
                SQLiteCommand getTopicIdCmd = new SQLiteCommand(getTopicIdQuery, conn);
                getTopicIdCmd.Parameters.AddWithValue("@topic", SelectedTopic);

                object topicIdResult = getTopicIdCmd.ExecuteScalar();
                if (topicIdResult == null)
                {
                    MessageBox.Show("Error: Topic not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                int topicId = Convert.ToInt32(topicIdResult);

                // Выбираем случайное слово из Words по topic_id
                string getWordQuery = "SELECT word FROM Words WHERE topic_id = @topic_id ORDER BY RANDOM() LIMIT 1";
                SQLiteCommand getWordCmd = new SQLiteCommand(getWordQuery, conn);
                getWordCmd.Parameters.AddWithValue("@topic_id", topicId);

                object wordResult = getWordCmd.ExecuteScalar();
                if (wordResult == null)
                {
                    MessageBox.Show("Error: No words found for this topic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                wordToGuess = wordResult.ToString().ToUpper();
            }

            // Проверяем, что слово загружено корректно
            if (string.IsNullOrEmpty(wordToGuess))
            {
                MessageBox.Show("Error: Loaded word is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

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
            int columns = 13; // Количество столбцов

            using (Graphics g = this.CreateGraphics())
            {
                float dpiScale = g.DpiX / 96f; // Коэффициент масштабирования DPI
                int buttonSize = (int)(40 * dpiScale); // Масштабируем размер кнопки
                int padding = (int)(2 * dpiScale); // Масштабируем отступ

                // Вычисляем ширину всей клавиатуры
                int keyboardWidth = columns * buttonSize + (columns - 1) * padding;
                int offsetX = (int)(100 * dpiScale);
                // Центрируем клавиатуру по ширине формы
                int startX = (this.ClientSize.Width - keyboardWidth) / 2 + offsetX;
                int startY = this.ClientSize.Height - (int)(250 * dpiScale); // Отступ от нижнего края

                foreach (var btn in letterButtons)
                {
                    this.Controls.Remove(btn); // Очищаем старые кнопки, если они есть
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
                    MessageBox.Show("Congratulations! You won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateUserStats(true);
                    this.Close();
                }
            }
            else
            {
                mistakes++;
                DrawHangman();

                if (mistakes >= maxMistakes)
                {
                    MessageBox.Show("Game over! The word was: " + wordToGuess, "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateUserStats(false);
                    this.Close();
                }
            }

            clickedButton.Enabled = false;
        }

        private void DrawHangman()
        {
            string imagePath = $"Images/{mistakes + 1}vis.png"; // Путь к картинке

            if (System.IO.File.Exists(imagePath)) // Проверяем, существует ли файл
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем по окну
            }
        }

        private void UpdateUserStats(bool won)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                conn.Open();
                string query = won ?
                    "UPDATE users SET points = points + 10, words = words + 1 WHERE login = @username" :
                    "UPDATE users SET points = points - 5 WHERE login = @username";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}