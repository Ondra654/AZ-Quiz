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
            this.components = new System.ComponentModel.Container();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.DisplayInfo = new System.Windows.Forms.Label();
            this.PlayersAnswer = new System.Windows.Forms.TextBox();
            this.scoreBlue = new System.Windows.Forms.Label();
            this.scoreOrange = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.progressBarQuestion = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarGame = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(613, 105);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(55, 24);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::AZ_Quiz.Properties.Resources.BlueTabel;
            this.pictureBox1.Location = new System.Drawing.Point(61, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = global::AZ_Quiz.Properties.Resources.OrangeTabel;
            this.pictureBox2.Location = new System.Drawing.Point(718, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartGameButton.Location = new System.Drawing.Point(445, 165);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(90, 26);
            this.StartGameButton.TabIndex = 26;
            this.StartGameButton.Text = "StartGame";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // player1
            // 
            this.player1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(133, 138);
            this.player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(57, 20);
            this.player1.TabIndex = 27;
            this.player1.Text = "Player1";
            // 
            // player2
            // 
            this.player2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(790, 138);
            this.player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(57, 20);
            this.player2.TabIndex = 28;
            this.player2.Text = "Player2";
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Question, 5);
            this.Question.Location = new System.Drawing.Point(16, 9);
            this.Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(947, 44);
            this.Question.TabIndex = 29;
            this.Question.Text = "label1";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayInfo
            // 
            this.DisplayInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayInfo, 5);
            this.DisplayInfo.Location = new System.Drawing.Point(43, 58);
            this.DisplayInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DisplayInfo.Name = "DisplayInfo";
            this.DisplayInfo.Size = new System.Drawing.Size(893, 38);
            this.DisplayInfo.TabIndex = 31;
            this.DisplayInfo.Text = "label2";
            this.DisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersAnswer
            // 
            this.PlayersAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayersAnswer.Location = new System.Drawing.Point(396, 135);
            this.PlayersAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.PlayersAnswer.Name = "PlayersAnswer";
            this.PlayersAnswer.Size = new System.Drawing.Size(188, 27);
            this.PlayersAnswer.TabIndex = 32;
            this.PlayersAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayersAnswer_Entered);
            // 
            // scoreBlue
            // 
            this.scoreBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreBlue.AutoSize = true;
            this.scoreBlue.Location = new System.Drawing.Point(136, 107);
            this.scoreBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreBlue.Name = "scoreBlue";
            this.scoreBlue.Size = new System.Drawing.Size(50, 20);
            this.scoreBlue.TabIndex = 33;
            this.scoreBlue.Text = "label1";
            // 
            // scoreOrange
            // 
            this.scoreOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreOrange.AutoSize = true;
            this.scoreOrange.Location = new System.Drawing.Point(793, 107);
            this.scoreOrange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreOrange.Name = "scoreOrange";
            this.scoreOrange.Size = new System.Drawing.Size(50, 20);
            this.scoreOrange.TabIndex = 34;
            this.scoreOrange.Text = "label1";
            // 
            // YesButton
            // 
            this.YesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YesButton.Location = new System.Drawing.Point(313, 135);
            this.YesButton.Margin = new System.Windows.Forms.Padding(2);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(74, 26);
            this.YesButton.TabIndex = 35;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NoButton.Location = new System.Drawing.Point(592, 135);
            this.NoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(74, 26);
            this.NoButton.TabIndex = 36;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 900;
            this.timerGame.Tick += new System.EventHandler(this.IncreaseProgressBar);
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.TimeLimit);
            // 
            // progressBarQuestion
            // 
            this.progressBarQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarQuestion.Location = new System.Drawing.Point(430, 107);
            this.progressBarQuestion.Maximum = 20;
            this.progressBarQuestion.Name = "progressBarQuestion";
            this.progressBarQuestion.Size = new System.Drawing.Size(120, 20);
            this.progressBarQuestion.TabIndex = 38;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.player1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.player2, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBarGame, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.YesButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.NoButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.StartGameButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.DisplayInfo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBarQuestion, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayersAnswer, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Question, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.scoreBlue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.scoreOrange, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.back_button, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.643731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.007596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.897327F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.694291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.516345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.716F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.884049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6406679F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 556);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // progressBarGame
            // 
            this.progressBarGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarGame, 5);
            this.progressBarGame.Location = new System.Drawing.Point(152, 531);
            this.progressBarGame.Maximum = 900;
            this.progressBarGame.Name = "progressBarGame";
            this.progressBarGame.Size = new System.Drawing.Size(675, 15);
            this.progressBarGame.TabIndex = 37;
            // 
            // Mplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Mplayer";
            this.Size = new System.Drawing.Size(984, 556);
            this.Load += new System.EventHandler(this.Mplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button back_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button StartGameButton;
        private Label player1;
        private Label player2;
        private Label Question;
        private Label DisplayInfo;
        private TextBox PlayersAnswer;
        private Label scoreBlue;
        private Label scoreOrange;
        private Button YesButton;
        private Button NoButton;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerQuestion;
        private ProgressBar progressBarQuestion;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progressBarGame;
    }
}
