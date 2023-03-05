namespace AZ_Quiz
{
    partial class Mplayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.PlayersAnswer = new System.Windows.Forms.TextBox();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(1145, 645);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(69, 36);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AZ_Quiz.Properties.Resources.BlueTabel;
            this.pictureBox1.Location = new System.Drawing.Point(100, 264);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 390);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AZ_Quiz.Properties.Resources.OrangeTabel;
            this.pictureBox2.Location = new System.Drawing.Point(930, 264);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 390);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 642);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "TestButt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(177, 201);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(69, 25);
            this.player1.TabIndex = 27;
            this.player1.Text = "Player1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(1006, 201);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(69, 25);
            this.player2.TabIndex = 28;
            this.player2.Text = "Player2";
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Question.Location = new System.Drawing.Point(221, 19);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(802, 113);
            this.Question.TabIndex = 29;
            this.Question.Text = "label1";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightAnswer
            // 
            this.RightAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightAnswer.Location = new System.Drawing.Point(406, 155);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(456, 71);
            this.RightAnswer.TabIndex = 31;
            this.RightAnswer.Text = "label2";
            this.RightAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersAnswer
            // 
            this.PlayersAnswer.Location = new System.Drawing.Point(440, 245);
            this.PlayersAnswer.Name = "PlayersAnswer";
            this.PlayersAnswer.Size = new System.Drawing.Size(370, 31);
            this.PlayersAnswer.TabIndex = 32;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(177, 132);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(59, 25);
            this.score1.TabIndex = 33;
            this.score1.Text = "label1";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(1016, 132);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(59, 25);
            this.score2.TabIndex = 34;
            this.score2.Text = "label1";
            // 
            // Mplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.PlayersAnswer);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mplayer";
            this.Size = new System.Drawing.Size(1230, 695);
            this.Load += new System.EventHandler(this.Mplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button back_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label player1;
        private Label player2;
        private Label Question;
        private Label RightAnswer;
        private TextBox PlayersAnswer;
        private Label score1;
        private Label score2;
    }
}
