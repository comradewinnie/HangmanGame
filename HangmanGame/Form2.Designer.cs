namespace HangmanGame
{
    partial class Form2
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
            buttonNewWord = new Button();
            buttonNewTopic = new Button();
            buttonLogOut = new Button();
            buttonEditLB = new Button();
            labelLogged = new Label();
            tabControl1 = new TabControl();
            tabPageWords = new TabPage();
            tabPageTopics = new TabPage();
            tabPageLB = new TabPage();
            labelTotal = new Label();
            labelTotalText = new Label();
            buttonDeleteWord = new Button();
            buttonDeleteTopic = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNewWord
            // 
            buttonNewWord.Location = new Point(14, 254);
            buttonNewWord.Margin = new Padding(3, 2, 3, 2);
            buttonNewWord.Name = "buttonNewWord";
            buttonNewWord.Size = new Size(102, 22);
            buttonNewWord.TabIndex = 0;
            buttonNewWord.Text = "Add new word";
            buttonNewWord.UseVisualStyleBackColor = true;
            // 
            // buttonNewTopic
            // 
            buttonNewTopic.Location = new Point(238, 254);
            buttonNewTopic.Margin = new Padding(3, 2, 3, 2);
            buttonNewTopic.Name = "buttonNewTopic";
            buttonNewTopic.Size = new Size(102, 22);
            buttonNewTopic.TabIndex = 1;
            buttonNewTopic.Text = "Add new topic";
            buttonNewTopic.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(369, 7);
            buttonLogOut.Margin = new Padding(3, 2, 3, 2);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(83, 22);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "Log out";
            buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonEditLB
            // 
            buttonEditLB.Location = new Point(14, 287);
            buttonEditLB.Margin = new Padding(3, 2, 3, 2);
            buttonEditLB.Name = "buttonEditLB";
            buttonEditLB.Size = new Size(437, 22);
            buttonEditLB.TabIndex = 5;
            buttonEditLB.Text = "Edit leaderboard";
            buttonEditLB.UseVisualStyleBackColor = true;
            // 
            // labelLogged
            // 
            labelLogged.AutoSize = true;
            labelLogged.Location = new Point(10, 7);
            labelLogged.Name = "labelLogged";
            labelLogged.Size = new Size(97, 15);
            labelLogged.TabIndex = 6;
            labelLogged.Text = "You logged in as:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageWords);
            tabControl1.Controls.Add(tabPageTopics);
            tabControl1.Controls.Add(tabPageLB);
            tabControl1.Location = new Point(10, 32);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(445, 209);
            tabControl1.TabIndex = 7;
            // 
            // tabPageWords
            // 
            tabPageWords.Location = new Point(4, 24);
            tabPageWords.Margin = new Padding(3, 2, 3, 2);
            tabPageWords.Name = "tabPageWords";
            tabPageWords.Padding = new Padding(3, 2, 3, 2);
            tabPageWords.Size = new Size(437, 181);
            tabPageWords.TabIndex = 0;
            tabPageWords.Text = "Words";
            tabPageWords.UseVisualStyleBackColor = true;
            // 
            // tabPageTopics
            // 
            tabPageTopics.Location = new Point(4, 24);
            tabPageTopics.Margin = new Padding(3, 2, 3, 2);
            tabPageTopics.Name = "tabPageTopics";
            tabPageTopics.Padding = new Padding(3, 2, 3, 2);
            tabPageTopics.Size = new Size(437, 181);
            tabPageTopics.TabIndex = 1;
            tabPageTopics.Text = "Topics";
            tabPageTopics.UseVisualStyleBackColor = true;
            // 
            // tabPageLB
            // 
            tabPageLB.Location = new Point(4, 24);
            tabPageLB.Margin = new Padding(3, 2, 3, 2);
            tabPageLB.Name = "tabPageLB";
            tabPageLB.Padding = new Padding(3, 2, 3, 2);
            tabPageLB.Size = new Size(437, 181);
            tabPageLB.TabIndex = 2;
            tabPageLB.Text = "Leaderboard";
            tabPageLB.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(17, 322);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(35, 15);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Total:";
            // 
            // labelTotalText
            // 
            labelTotalText.AutoSize = true;
            labelTotalText.Location = new Point(59, 322);
            labelTotalText.Name = "labelTotalText";
            labelTotalText.Size = new Size(152, 15);
            labelTotalText.TabIndex = 9;
            labelTotalText.Text = "n words    n topics    n users";
            // 
            // buttonDeleteWord
            // 
            buttonDeleteWord.Location = new Point(126, 254);
            buttonDeleteWord.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteWord.Name = "buttonDeleteWord";
            buttonDeleteWord.Size = new Size(102, 22);
            buttonDeleteWord.TabIndex = 10;
            buttonDeleteWord.Text = "Delete word";
            buttonDeleteWord.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTopic
            // 
            buttonDeleteTopic.Location = new Point(349, 254);
            buttonDeleteTopic.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteTopic.Name = "buttonDeleteTopic";
            buttonDeleteTopic.Size = new Size(102, 22);
            buttonDeleteTopic.TabIndex = 11;
            buttonDeleteTopic.Text = "Delete topic";
            buttonDeleteTopic.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(469, 346);
            Controls.Add(buttonDeleteTopic);
            Controls.Add(buttonDeleteWord);
            Controls.Add(labelTotalText);
            Controls.Add(labelTotal);
            Controls.Add(tabControl1);
            Controls.Add(labelLogged);
            Controls.Add(buttonEditLB);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonNewTopic);
            Controls.Add(buttonNewWord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "The Hangman Game [ADMIN]";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNewWord;
        private Button buttonNewTopic;
        private Button buttonLogOut;
        private Button buttonEditLB;
        private Label labelLogged;
        private TabControl tabControl1;
        private TabPage tabPageWords;
        private TabPage tabPageTopics;
        private TabPage tabPageLB;
        private Label labelTotal;
        private Label labelTotalText;
        private Button buttonDeleteWord;
        private Button buttonDeleteTopic;
    }
}