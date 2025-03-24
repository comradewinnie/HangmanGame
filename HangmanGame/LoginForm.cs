using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HangmanGame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            string role;
            if (DatabaseManager.TryLogin(login, password, out isNewUser, out role))
            {
                if (isNewUser == true)
                {
                    MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // adminiem ir cits logs
                if (role == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MainMenuForm mainMenu = new MainMenuForm(login);
                    mainMenu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}