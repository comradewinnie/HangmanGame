namespace HangmanGame
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            labelWelcome = new Label();
            btnProfile = new Button();
            btnStartGame = new Button();
            btnLeaderboard = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(27, 45);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(184, 59);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Hello,";
            labelWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.Control;
            btnProfile.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = SystemColors.ControlText;
            btnProfile.Location = new Point(242, 148);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(307, 48);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "My profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = SystemColors.Control;
            btnStartGame.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartGame.ForeColor = SystemColors.ControlText;
            btnStartGame.Location = new Point(242, 217);
            btnStartGame.Margin = new Padding(3, 2, 3, 2);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(307, 48);
            btnStartGame.TabIndex = 9;
            btnStartGame.Text = "Start the game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = SystemColors.Control;
            btnLeaderboard.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaderboard.ForeColor = SystemColors.ControlText;
            btnLeaderboard.Location = new Point(242, 282);
            btnLeaderboard.Margin = new Padding(3, 2, 3, 2);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(307, 48);
            btnLeaderboard.TabIndex = 10;
            btnLeaderboard.Text = "Leaderboard";
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(203, 45);
            label1.Name = "label1";
            label1.Size = new Size(264, 59);
            label1.TabIndex = 2;
            label1.Text = "username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 400);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnStartGame);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenuForm";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelWelcome;
        private Button btnProfile;
        private Button btnStartGame;
        private Button btnLeaderboard;
        private Label label1;
        private Label lblUsername;
    }
}