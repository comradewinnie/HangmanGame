namespace HangmanGame
{
    partial class AdminForm
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
            dataGridViewWords = new DataGridView();
            tabPageTopics = new TabPage();
            dataGridViewTopics = new DataGridView();
            tabPageLB = new TabPage();
            dataGridViewLeaderboard = new DataGridView();
            buttonDeleteWord = new Button();
            buttonDeleteTopic = new Button();
            tabControl1.SuspendLayout();
            tabPageWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWords).BeginInit();
            tabPageTopics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopics).BeginInit();
            tabPageLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).BeginInit();
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
            buttonNewWord.Click += buttonNewWord_Click;
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
            buttonNewTopic.Click += buttonNewTopic_Click;
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
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonEditLB
            // 
            buttonEditLB.Location = new Point(14, 287);
            buttonEditLB.Margin = new Padding(3, 2, 3, 2);
            buttonEditLB.Name = "buttonEditLB";
            buttonEditLB.Size = new Size(437, 22);
            buttonEditLB.TabIndex = 5;
            buttonEditLB.Text = "Update leaderboard";
            buttonEditLB.UseVisualStyleBackColor = true;
            buttonEditLB.Click += buttonEditLB_Click;
            // 
            // labelLogged
            // 
            labelLogged.AutoSize = true;
            labelLogged.Location = new Point(10, 7);
            labelLogged.Name = "labelLogged";
            labelLogged.Size = new Size(134, 15);
            labelLogged.TabIndex = 6;
            labelLogged.Text = "You logged in as admin.";
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
            tabPageWords.Controls.Add(dataGridViewWords);
            tabPageWords.Location = new Point(4, 24);
            tabPageWords.Margin = new Padding(3, 2, 3, 2);
            tabPageWords.Name = "tabPageWords";
            tabPageWords.Padding = new Padding(3, 2, 3, 2);
            tabPageWords.Size = new Size(437, 181);
            tabPageWords.TabIndex = 0;
            tabPageWords.Text = "Words";
            tabPageWords.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWords
            // 
            dataGridViewWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWords.Location = new Point(0, 0);
            dataGridViewWords.Name = "dataGridViewWords";
            dataGridViewWords.RowHeadersWidth = 51;
            dataGridViewWords.RowTemplate.Height = 25;
            dataGridViewWords.Size = new Size(437, 181);
            dataGridViewWords.TabIndex = 0;
            // 
            // tabPageTopics
            // 
            tabPageTopics.Controls.Add(dataGridViewTopics);
            tabPageTopics.Location = new Point(4, 24);
            tabPageTopics.Margin = new Padding(3, 2, 3, 2);
            tabPageTopics.Name = "tabPageTopics";
            tabPageTopics.Padding = new Padding(3, 2, 3, 2);
            tabPageTopics.Size = new Size(437, 181);
            tabPageTopics.TabIndex = 1;
            tabPageTopics.Text = "Topics";
            tabPageTopics.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTopics
            // 
            dataGridViewTopics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTopics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopics.Location = new Point(0, 0);
            dataGridViewTopics.Name = "dataGridViewTopics";
            dataGridViewTopics.RowHeadersWidth = 51;
            dataGridViewTopics.RowTemplate.Height = 25;
            dataGridViewTopics.Size = new Size(437, 181);
            dataGridViewTopics.TabIndex = 0;
            // 
            // tabPageLB
            // 
            tabPageLB.Controls.Add(dataGridViewLeaderboard);
            tabPageLB.Location = new Point(4, 24);
            tabPageLB.Margin = new Padding(3, 2, 3, 2);
            tabPageLB.Name = "tabPageLB";
            tabPageLB.Padding = new Padding(3, 2, 3, 2);
            tabPageLB.Size = new Size(437, 181);
            tabPageLB.TabIndex = 2;
            tabPageLB.Text = "Leaderboard";
            tabPageLB.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeaderboard
            // 
            dataGridViewLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeaderboard.Location = new Point(0, 0);
            dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            dataGridViewLeaderboard.RowHeadersWidth = 51;
            dataGridViewLeaderboard.RowTemplate.Height = 25;
            dataGridViewLeaderboard.Size = new Size(437, 181);
            dataGridViewLeaderboard.TabIndex = 0;
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
            buttonDeleteWord.Click += buttonDeleteWord_Click;
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
            buttonDeleteTopic.Click += buttonDeleteTopic_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(469, 327);
            Controls.Add(buttonDeleteTopic);
            Controls.Add(buttonDeleteWord);
            Controls.Add(tabControl1);
            Controls.Add(labelLogged);
            Controls.Add(buttonEditLB);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonNewTopic);
            Controls.Add(buttonNewWord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "The Hangman Game [ADMIN]";
            tabControl1.ResumeLayout(false);
            tabPageWords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWords).EndInit();
            tabPageTopics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopics).EndInit();
            tabPageLB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).EndInit();
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
        private Button buttonDeleteWord;
        private Button buttonDeleteTopic;
        private DataGridView dataGridViewWords;
        private DataGridView dataGridViewTopics;
        private DataGridView dataGridViewLeaderboard;
    }
}