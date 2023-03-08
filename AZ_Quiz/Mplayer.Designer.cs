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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.PlayersAnswer = new System.Windows.Forms.TextBox();
            this.scoreBlue = new System.Windows.Forms.Label();
            this.scoreOrange = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
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
            this.back_button.Location = new System.Drawing.Point(1158, 4);
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
            this.pictureBox1.Location = new System.Drawing.Point(40, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 387);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AZ_Quiz.Properties.Resources.OrangeTabel;
            this.pictureBox2.Location = new System.Drawing.Point(989, 289);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 387);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(562, 289);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(112, 34);
            this.StartGameButton.TabIndex = 26;
            this.StartGameButton.Text = "StartGame";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(107, 355);
            this.player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(69, 25);
            this.player1.TabIndex = 27;
            this.player1.Text = "Player1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(1058, 355);
            this.player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(69, 25);
            this.player2.TabIndex = 28;
            this.player2.Text = "Player2";
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Question.Location = new System.Drawing.Point(137, 20);
            this.Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(963, 94);
            this.Question.TabIndex = 29;
            this.Question.Text = "label1";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightAnswer
            // 
            this.RightAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightAnswer.Location = new System.Drawing.Point(137, 142);
            this.RightAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(963, 44);
            this.RightAnswer.TabIndex = 31;
            this.RightAnswer.Text = "label2";
            this.RightAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersAnswer
            // 
            this.PlayersAnswer.Location = new System.Drawing.Point(435, 240);
            this.PlayersAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.PlayersAnswer.Name = "PlayersAnswer";
            this.PlayersAnswer.Size = new System.Drawing.Size(370, 31);
            this.PlayersAnswer.TabIndex = 32;
            this.PlayersAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayersAnswer_Entered);
            // 
            // scoreBlue
            // 
            this.scoreBlue.AutoSize = true;
            this.scoreBlue.Location = new System.Drawing.Point(40, 246);
            this.scoreBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreBlue.Name = "scoreBlue";
            this.scoreBlue.Size = new System.Drawing.Size(59, 25);
            this.scoreBlue.TabIndex = 33;
            this.scoreBlue.Text = "label1";
            // 
            // scoreOrange
            // 
            this.scoreOrange.AutoSize = true;
            this.scoreOrange.Location = new System.Drawing.Point(1134, 246);
            this.scoreOrange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreOrange.Name = "scoreOrange";
            this.scoreOrange.Size = new System.Drawing.Size(59, 25);
            this.scoreOrange.TabIndex = 34;
            this.scoreOrange.Text = "label1";
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YesButton.Location = new System.Drawing.Point(475, 201);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(92, 34);
            this.YesButton.TabIndex = 35;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NoButton.Location = new System.Drawing.Point(671, 201);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(92, 34);
            this.NoButton.TabIndex = 36;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Mplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.scoreOrange);
            this.Controls.Add(this.scoreBlue);
            this.Controls.Add(this.PlayersAnswer);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.StartGameButton);
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
        private Button StartGameButton;
        private Label player1;
        private Label player2;
        private Label Question;
        private Label RightAnswer;
        private TextBox PlayersAnswer;
        private Label scoreBlue;
        private Label scoreOrange;
        private Button YesButton;
        private Button NoButton;
    }
}
