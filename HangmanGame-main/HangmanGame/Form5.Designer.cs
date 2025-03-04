namespace HangmanGame
{
    partial class Form5
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
            labelLeaderboard.Location = new Point(24, 27);
            labelLeaderboard.Name = "labelLeaderboard";
            labelLeaderboard.Size = new Size(286, 47);
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
            listBoxLeaderboard.ItemHeight = 22;
            listBoxLeaderboard.Location = new Point(33, 90);
            listBoxLeaderboard.Name = "listBoxLeaderboard";
            listBoxLeaderboard.Size = new Size(413, 154);
            listBoxLeaderboard.TabIndex = 4;
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
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 320);
            Controls.Add(buttonBack);
            Controls.Add(listBoxLeaderboard);
            Controls.Add(labelLeaderboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form5";
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