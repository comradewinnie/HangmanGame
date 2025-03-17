namespace HangmanGame
{
    partial class LeaderboardForm
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
            labelLeaderboard = new Label();
            listBoxLeaderboard = new ListBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelLeaderboard
            // 
            labelLeaderboard.AutoSize = true;
            labelLeaderboard.BackColor = Color.Transparent;
            labelLeaderboard.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeaderboard.ForeColor = Color.DarkRed;
            labelLeaderboard.Location = new Point(36, 40);
            labelLeaderboard.Margin = new Padding(4, 0, 4, 0);
            labelLeaderboard.Name = "labelLeaderboard";
            labelLeaderboard.Size = new Size(429, 70);
            labelLeaderboard.TabIndex = 3;
            labelLeaderboard.Text = "Leaderboard";
            labelLeaderboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxLeaderboard
            // 
            listBoxLeaderboard.BackColor = Color.Black;
            listBoxLeaderboard.BorderStyle = BorderStyle.None;
            listBoxLeaderboard.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxLeaderboard.ForeColor = SystemColors.Control;
            listBoxLeaderboard.FormattingEnabled = true;
            listBoxLeaderboard.ItemHeight = 33;
            listBoxLeaderboard.Location = new Point(50, 135);
            listBoxLeaderboard.Margin = new Padding(4, 4, 4, 4);
            listBoxLeaderboard.Name = "listBoxLeaderboard";
            listBoxLeaderboard.Size = new Size(620, 231);
            listBoxLeaderboard.TabIndex = 4;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Control;
            buttonBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(234, 388);
            buttonBack.Margin = new Padding(4, 3, 4, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(258, 57);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += this.btnBack_Click;
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 480);
            Controls.Add(buttonBack);
            Controls.Add(listBoxLeaderboard);
            Controls.Add(labelLeaderboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "LeaderboardForm";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLeaderboard;
        private ListBox listBoxLeaderboard;
        private Button buttonBack;
    }
}