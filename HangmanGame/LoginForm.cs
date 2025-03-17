using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HangmanGame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter login and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isNewUser;
            if (DatabaseManager.TryLogin(login, password, out isNewUser))
            {
                MessageBox.Show(isNewUser ? "Registered successfully! Welcome, " + login + "!" : "Welcome, " + login + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenuForm mainMenu = new MainMenuForm(login);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}