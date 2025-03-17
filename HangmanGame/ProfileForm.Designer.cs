namespace HangmanGame
{
    partial class ProfileForm
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
            lblNickname = new Label();
            lblPoints = new Label();
            lblSolvedWords = new Label();
            SuspendLayout();
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.BackColor = Color.Transparent;
            labelProfile.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelProfile.ForeColor = Color.DarkRed;
            labelProfile.Location = new Point(30, 33);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(216, 59);
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
            labelNickname.Location = new Point(38, 130);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(203, 44);
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
            labelEarnedPts.Location = new Point(38, 185);
            labelEarnedPts.Name = "labelEarnedPts";
            labelEarnedPts.Size = new Size(276, 44);
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
            labelSolvWords.Location = new Point(38, 240);
            labelSolvWords.Name = "labelSolvWords";
            labelSolvWords.Size = new Size(263, 44);
            labelSolvWords.TabIndex = 5;
            labelSolvWords.Text = "Solved words:";
            labelSolvWords.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Control;
            buttonBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(195, 323);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(215, 48);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += btnBack_Click;
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.BackColor = Color.Transparent;
            lblNickname.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNickname.ForeColor = Color.DarkRed;
            lblNickname.Location = new Point(338, 130);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(88, 44);
            lblNickname.TabIndex = 10;
            lblNickname.Text = "nnn";
            lblNickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.BackColor = Color.Transparent;
            lblPoints.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoints.ForeColor = Color.DarkRed;
            lblPoints.Location = new Point(338, 185);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(88, 44);
            lblPoints.TabIndex = 11;
            lblPoints.Text = "nnn";
            lblPoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolvedWords
            // 
            lblSolvedWords.AutoSize = true;
            lblSolvedWords.BackColor = Color.Transparent;
            lblSolvedWords.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolvedWords.ForeColor = Color.DarkRed;
            lblSolvedWords.Location = new Point(338, 240);
            lblSolvedWords.Name = "lblSolvedWords";
            lblSolvedWords.Size = new Size(88, 44);
            lblSolvedWords.TabIndex = 12;
            lblSolvedWords.Text = "nnn";
            lblSolvedWords.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 400);
            Controls.Add(lblSolvedWords);
            Controls.Add(lblPoints);
            Controls.Add(lblNickname);
            Controls.Add(buttonBack);
            Controls.Add(labelSolvWords);
            Controls.Add(labelEarnedPts);
            Controls.Add(labelNickname);
            Controls.Add(labelProfile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProfileForm";
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
        private Label lblNickname;
        private Label lblPoints;
        private Label lblSolvedWords;
    }
}