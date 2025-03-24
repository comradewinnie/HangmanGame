namespace HangmanGame
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcome = new Label();
            labelWelcome2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            buttonLoginRegister = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Anchor = AnchorStyles.Top;
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(130, 11);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(321, 59);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome to\r";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome2
            // 
            labelWelcome2.Anchor = AnchorStyles.Top;
            labelWelcome2.BackColor = Color.Transparent;
            labelWelcome2.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome2.ForeColor = Color.DarkRed;
            labelWelcome2.Location = new Point(44, 70);
            labelWelcome2.Margin = new Padding(4, 0, 4, 0);
            labelWelcome2.Name = "labelWelcome2";
            labelWelcome2.Size = new Size(511, 59);
            labelWelcome2.TabIndex = 1;
            labelWelcome2.Text = "the Hangman game!";
            labelWelcome2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.DarkRed;
            textBoxLogin.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.Control;
            textBoxLogin.Location = new Point(265, 174);
            textBoxLogin.Margin = new Padding(4, 2, 4, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(306, 41);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DarkRed;
            textBoxPassword.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.Control;
            textBoxPassword.Location = new Point(265, 259);
            textBoxPassword.Margin = new Padding(4, 2, 4, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(306, 41);
            textBoxPassword.TabIndex = 3;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.Control;
            labelLogin.Location = new Point(265, 140);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(199, 26);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Enter your login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.Control;
            labelPassword.Location = new Point(265, 226);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(188, 26);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Enter password";
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.BackColor = SystemColors.Control;
            buttonLoginRegister.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginRegister.ForeColor = SystemColors.ControlText;
            buttonLoginRegister.Location = new Point(265, 319);
            buttonLoginRegister.Margin = new Padding(4, 2, 4, 2);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(306, 48);
            buttonLoginRegister.TabIndex = 7;
            buttonLoginRegister.Text = "LOGIN / REGISTER";
            buttonLoginRegister.UseVisualStyleBackColor = false;
            buttonLoginRegister.Click += buttonLoginRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 400);
            Controls.Add(buttonLoginRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelWelcome2);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoginForm";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelWelcome2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonLoginRegister;
    }
}