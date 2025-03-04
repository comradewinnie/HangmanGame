namespace HangmanGame
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelProfile = new Label();
            labelNickname = new Label();
            labelEarnedPts = new Label();
            labelSolvWords = new Label();
            buttonBack = new Button();
            labelNicknameValue = new Label();
            labelPtsValue = new Label();
            labelWordsValue = new Label();
            SuspendLayout();
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.BackColor = Color.Transparent;
            labelProfile.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelProfile.ForeColor = Color.DarkRed;
            labelProfile.Location = new Point(24, 27);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(174, 47);
            labelProfile.TabIndex = 2;
            labelProfile.Text = "Profile";
            labelProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNickname
            // 
            labelNickname.AutoSize = true;
            labelNickname.BackColor = Color.Transparent;
            labelNickname.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNickname.ForeColor = SystemColors.Control;
            labelNickname.Location = new Point(30, 104);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(162, 36);
            labelNickname.TabIndex = 3;
            labelNickname.Text = "Nickname:";
            labelNickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEarnedPts
            // 
            labelEarnedPts.AutoSize = true;
            labelEarnedPts.BackColor = Color.Transparent;
            labelEarnedPts.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEarnedPts.ForeColor = SystemColors.Control;
            labelEarnedPts.Location = new Point(30, 148);
            labelEarnedPts.Name = "labelEarnedPts";
            labelEarnedPts.Size = new Size(219, 36);
            labelEarnedPts.TabIndex = 4;
            labelEarnedPts.Text = "Earned points:";
            labelEarnedPts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSolvWords
            // 
            labelSolvWords.AutoSize = true;
            labelSolvWords.BackColor = Color.Transparent;
            labelSolvWords.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSolvWords.ForeColor = SystemColors.Control;
            labelSolvWords.Location = new Point(30, 192);
            labelSolvWords.Name = "labelSolvWords";
            labelSolvWords.Size = new Size(209, 36);
            labelSolvWords.TabIndex = 5;
            labelSolvWords.Text = "Solved words:";
            labelSolvWords.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Control;
            buttonBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(156, 259);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(172, 38);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelNicknameValue
            // 
            labelNicknameValue.AutoSize = true;
            labelNicknameValue.BackColor = Color.Transparent;
            labelNicknameValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNicknameValue.ForeColor = Color.DarkRed;
            labelNicknameValue.Location = new Point(271, 104);
            labelNicknameValue.Name = "labelNicknameValue";
            labelNicknameValue.Size = new Size(69, 36);
            labelNicknameValue.TabIndex = 10;
            labelNicknameValue.Text = "nnn";
            labelNicknameValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPtsValue
            // 
            labelPtsValue.AutoSize = true;
            labelPtsValue.BackColor = Color.Transparent;
            labelPtsValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPtsValue.ForeColor = Color.DarkRed;
            labelPtsValue.Location = new Point(271, 148);
            labelPtsValue.Name = "labelPtsValue";
            labelPtsValue.Size = new Size(69, 36);
            labelPtsValue.TabIndex = 11;
            labelPtsValue.Text = "nnn";
            labelPtsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWordsValue
            // 
            labelWordsValue.AutoSize = true;
            labelWordsValue.BackColor = Color.Transparent;
            labelWordsValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordsValue.ForeColor = Color.DarkRed;
            labelWordsValue.Location = new Point(271, 192);
            labelWordsValue.Name = "labelWordsValue";
            labelWordsValue.Size = new Size(69, 36);
            labelWordsValue.TabIndex = 12;
            labelWordsValue.Text = "nnn";
            labelWordsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 320);
            Controls.Add(labelWordsValue);
            Controls.Add(labelPtsValue);
            Controls.Add(labelNicknameValue);
            Controls.Add(buttonBack);
            Controls.Add(labelSolvWords);
            Controls.Add(labelEarnedPts);
            Controls.Add(labelNickname);
            Controls.Add(labelProfile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProfile;
        private Label labelNickname;
        private Label labelEarnedPts;
        private Label labelSolvWords;
        private Button buttonBack;
        private Label labelNicknameValue;
        private Label labelPtsValue;
        private Label labelWordsValue;
    }
}