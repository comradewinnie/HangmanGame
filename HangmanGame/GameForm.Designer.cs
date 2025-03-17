namespace HangmanGame
{
    partial class GameForm
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
            label1 = new Label();
            label2 = new Label();
            lblWord = new Label();
            button26 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelTopic
            // 
            labelTopic.Anchor = AnchorStyles.Top;
            labelTopic.AutoSize = true;
            labelTopic.BackColor = Color.Transparent;
            labelTopic.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopic.ForeColor = SystemColors.Control;
            labelTopic.Location = new Point(42, 38);
            labelTopic.Margin = new Padding(4, 0, 4, 0);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(180, 59);
            labelTopic.TabIndex = 5;
            labelTopic.Text = "Topic:";
            labelTopic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(42, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 59);
            label1.TabIndex = 6;
            label1.Text = "Word:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(230, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 44);
            label2.TabIndex = 7;
            label2.Text = "nnn";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord
            // 
            lblWord.Anchor = AnchorStyles.Top;
            lblWord.AutoSize = true;
            lblWord.BackColor = Color.Transparent;
            lblWord.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblWord.ForeColor = SystemColors.Control;
            lblWord.Location = new Point(230, 121);
            lblWord.Margin = new Padding(4, 0, 4, 0);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(103, 44);
            lblWord.TabIndex = 8;
            lblWord.Text = "_ _ _";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button26
            // 
            button26.BackColor = SystemColors.Control;
            button26.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button26.ForeColor = Color.DarkRed;
            button26.Location = new Point(525, 389);
            button26.Margin = new Padding(4, 2, 4, 2);
            button26.Name = "button26";
            button26.Size = new Size(215, 48);
            button26.TabIndex = 39;
            button26.Text = "Start again";
            button26.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(643, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 59);
            label4.TabIndex = 40;
            label4.Text = "Attempts: 7";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources._1vis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(label4);
            Controls.Add(button26);
            Controls.Add(lblWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTopic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "GameForm";
            Text = "The Hangman Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTopic;
        private Label label1;
        private Label label2;
        private Label lblWord;
        private Button buttonStart;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Label label4;
    }
}