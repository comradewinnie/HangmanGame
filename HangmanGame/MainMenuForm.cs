using System;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class MainMenuForm : Form
    {
        private string username;

        public MainMenuForm(string user)
        {
            InitializeComponent();
            username = user;
            label1.Text = username;
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(username);
            profileForm.ShowDialog();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            TopicSelectionForm topicForm = new TopicSelectionForm(username);
            topicForm.Show();
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            leaderboardForm.ShowDialog();
        }
    }
}

