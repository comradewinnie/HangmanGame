namespace HangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show("������� ����� � ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isNewUser;
            if (DatabaseManager.TryLogin(login, password, out isNewUser))
            {
                MessageBox.Show(isNewUser ? "����������� �������! ����� ����������, " + login + "!" : "����� ����������, " + login + "!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}