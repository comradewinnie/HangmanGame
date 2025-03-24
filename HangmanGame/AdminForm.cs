using System;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadData();
            // lai leaderboardā rediģētu tikai points
            dataGridViewLeaderboard.ReadOnly = false;
            dataGridViewLeaderboard.Columns["login"].ReadOnly = true;
            dataGridViewLeaderboard.Columns["words"].ReadOnly = true;

        }

        private void LoadData()
        {
            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    LoadTable("SELECT Words.id, Words.word, Topics.topic FROM Words JOIN Topics ON Words.topic_id = Topics.id", dataGridViewWords, connection);
                    LoadTable("SELECT id, topic FROM Topics", dataGridViewTopics, connection);
                    LoadTable("SELECT login, points, words FROM Users ORDER BY points DESC", dataGridViewLeaderboard, connection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading data: " + ex.Message);
                }
            }
        }

        private void LoadTable(string query, DataGridView dgv, SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(query, connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
        }

        // jaunajam logam, kur izvēlas tēmu
        private string SelectItem(string title, string[] items)
        {
            Form form = new Form();
            form.Text = title;
            form.Width = 300;
            form.Height = 150;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            ComboBox comboBox = new ComboBox() { Left = 20, Top = 20, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            Button buttonOK = new Button() { Text = "OK", Left = 100, Width = 100, Top = 60, DialogResult = DialogResult.OK };

            comboBox.Items.AddRange(items);
            comboBox.SelectedIndex = 0;

            form.Controls.Add(comboBox);
            form.Controls.Add(buttonOK);
            form.AcceptButton = buttonOK;

            return form.ShowDialog() == DialogResult.OK ? comboBox.SelectedItem.ToString() : null;
        }


        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    string newWord = Microsoft.VisualBasic.Interaction.InputBox("Insert new word:", "Add new word", "");
                    if (string.IsNullOrWhiteSpace(newWord)) return;

                    DataTable topicsTable = new DataTable();
                    using (var command = new SQLiteCommand("SELECT id, topic FROM Topics", connection))
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(topicsTable);
                    }

                    string[] topicsArray = topicsTable.AsEnumerable().Select(row => row["topic"].ToString()).ToArray();
                    string selectedTopic = SelectItem("Choose the topic", topicsArray);
                    if (selectedTopic == null) return;

                    int topicId = Convert.ToInt32(topicsTable.AsEnumerable().First(row => row["topic"].ToString() == selectedTopic)["id"]);

                    using (var insertCommand = new SQLiteCommand("INSERT INTO Words (word, topic_id) VALUES (@word, @topicId)", connection))
                    {
                        insertCommand.Parameters.AddWithValue("@word", newWord);
                        insertCommand.Parameters.AddWithValue("@topicId", topicId);
                        insertCommand.ExecuteNonQuery();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            if (dataGridViewWords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a word to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int wordId = Convert.ToInt32(dataGridViewWords.SelectedRows[0].Cells["id"].Value);
            string wordText = dataGridViewWords.SelectedRows[0].Cells["word"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the word \"{wordText}\"?",
                                                  "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    using (var command = new SQLiteCommand("DELETE FROM Words WHERE id = @wordId", connection))
                    {
                        command.Parameters.AddWithValue("@wordId", wordId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting word: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonNewTopic_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    string newTopic = Microsoft.VisualBasic.Interaction.InputBox("Insert new topic:", "Add new topic", "");
                    if (string.IsNullOrWhiteSpace(newTopic)) return;

                    using (var checkCommand = new SQLiteCommand("SELECT COUNT(*) FROM Topics WHERE topic = @topic", connection))
                    {
                        checkCommand.Parameters.AddWithValue("@topic", newTopic);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("This topic already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (var insertCommand = new SQLiteCommand("INSERT INTO Topics (topic) VALUES (@topic)", connection))
                    {
                        insertCommand.Parameters.AddWithValue("@topic", newTopic);
                        insertCommand.ExecuteNonQuery();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding topic: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e)
        {
            if (dataGridViewTopics.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a topic to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int topicId = Convert.ToInt32(dataGridViewTopics.SelectedRows[0].Cells["id"].Value);
            string topicName = dataGridViewTopics.SelectedRows[0].Cells["topic"].Value.ToString();

            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();
                    // pārbaudam, vai ir vārdi topicā
                    using (var checkCommand = new SQLiteCommand("SELECT COUNT(*) FROM Words WHERE topic_id = @topicId", connection))
                    {
                        checkCommand.Parameters.AddWithValue("@topicId", topicId);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show($"You cannot delete topic \"{topicName}\", while it has existing words!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the topic \"{topicName}\"?",
                                                          "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;

                    using (var deleteCommand = new SQLiteCommand("DELETE FROM Topics WHERE id = @topicId", connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@topicId", topicId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting topic: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEditLB_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=database.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    // nolasam aktuālus punktus un atjaunojam leaderboardu
                    foreach (DataGridViewRow row in dataGridViewLeaderboard.Rows)
                    {
                        if (row.Cells["login"].Value == null) continue;

                        string login = row.Cells["login"].Value.ToString();
                        int points = Convert.ToInt32(row.Cells["points"].Value);

                        using (var command = new SQLiteCommand("UPDATE Users SET points = @points WHERE login = @login", connection))
                        {
                            command.Parameters.AddWithValue("@points", points);
                            command.Parameters.AddWithValue("@login", login);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Leaderboard updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating leaderboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
