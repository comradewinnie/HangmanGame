namespace HangmanGame
{
    partial class TopicSelectionForm
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
            labelTopic = new Label();
            listBoxTopics = new ListBox();
            btnBack = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // labelTopic
            // 
            labelTopic.Anchor = AnchorStyles.Top;
            labelTopic.AutoSize = true;
            labelTopic.BackColor = Color.Transparent;
            labelTopic.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopic.ForeColor = Color.DarkRed;
            labelTopic.Location = new Point(76, 48);
            labelTopic.Margin = new Padding(4, 0, 4, 0);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(549, 70);
            labelTopic.TabIndex = 4;
            labelTopic.Text = "Choose the topic";
            labelTopic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxTopics
            // 
            listBoxTopics.BackColor = Color.Black;
            listBoxTopics.BorderStyle = BorderStyle.None;
            listBoxTopics.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxTopics.ForeColor = SystemColors.Control;
            listBoxTopics.FormattingEnabled = true;
            listBoxTopics.ItemHeight = 33;
            listBoxTopics.Location = new Point(192, 152);
            listBoxTopics.Margin = new Padding(4);
            listBoxTopics.Name = "listBoxTopics";
            listBoxTopics.Size = new Size(339, 198);
            listBoxTopics.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(374, 386);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(258, 57);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.Control;
            btnStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.ControlText;
            btnStart.Location = new Point(76, 386);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(258, 57);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // TopicSelectionForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 480);
            Controls.Add(btnStart);
            Controls.Add(btnBack);
            Controls.Add(listBoxTopics);
            Controls.Add(labelTopic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "TopicSelectionForm";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTopic;
        private ListBox listBoxTopics;
        private Button buttonBack;
        private Button btnStart;
        private Button btnBack;
    }
}