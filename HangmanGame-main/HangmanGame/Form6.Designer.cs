namespace HangmanGame
{
    partial class Form6
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
            buttonBack = new Button();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // labelTopic
            // 
            labelTopic.Anchor = AnchorStyles.Top;
            labelTopic.AutoSize = true;
            labelTopic.BackColor = Color.Transparent;
            labelTopic.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopic.ForeColor = Color.DarkRed;
            labelTopic.Location = new Point(51, 32);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(370, 47);
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
            listBoxTopics.ItemHeight = 22;
            listBoxTopics.Location = new Point(128, 101);
            listBoxTopics.Name = "listBoxTopics";
            listBoxTopics.Size = new Size(226, 132);
            listBoxTopics.TabIndex = 5;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Control;
            buttonBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(249, 257);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(172, 38);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.Control;
            buttonStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = SystemColors.ControlText;
            buttonStart.Location = new Point(51, 257);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(172, 38);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._360_F_262244537_RjHfRBucxPyo7o6QetIAQYpd5O3h6cEN__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 320);
            Controls.Add(buttonStart);
            Controls.Add(buttonBack);
            Controls.Add(listBoxTopics);
            Controls.Add(labelTopic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form6";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTopic;
        private ListBox listBoxTopics;
        private Button buttonBack;
        private Button buttonStart;
    }
}