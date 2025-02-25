namespace HangmanGame
{
    partial class Form1
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
            labelWelcome.Location = new Point(104, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(261, 47);
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
            labelWelcome2.Location = new Point(35, 56);
            labelWelcome2.Name = "labelWelcome2";
            labelWelcome2.Size = new Size(409, 47);
            labelWelcome2.TabIndex = 1;
            labelWelcome2.Text = "the Hangman game!";
            labelWelcome2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.DarkRed;
            textBoxLogin.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.Control;
            textBoxLogin.Location = new Point(212, 139);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(246, 34);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DarkRed;
            textBoxPassword.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.Control;
            textBoxPassword.Location = new Point(212, 207);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(246, 34);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBox2_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.Control;
            labelLogin.Location = new Point(212, 112);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(159, 20);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Enter your login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.Control;
            labelPassword.Location = new Point(212, 181);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(153, 20);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Enter password";
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.BackColor = SystemColors.Control;
            buttonLoginRegister.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoginRegister.ForeColor = SystemColors.ControlText;
            buttonLoginRegister.Location = new Point(212, 255);
            buttonLoginRegister.Margin = new Padding(3, 2, 3, 2);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(245, 38);
            buttonLoginRegister.TabIndex = 7;
            buttonLoginRegister.Text = "LOGIN / REGISTER";
            buttonLoginRegister.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 320);
            Controls.Add(buttonLoginRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelWelcome2);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
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