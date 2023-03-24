namespace AZ_Quiz
{
    partial class GameMenu
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
            this.PVP = new System.Windows.Forms.Button();
            this.Solo = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.End_button = new System.Windows.Forms.Button();
            this.azQuizGame = new AZ_Quiz.AZQuizGame();
            this.help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login1 = new AZ_Quiz.Login();
            this.scoreBoard1 = new AZ_Quiz.ScoreBoard();
            this.tableMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.singlePlayer1 = new AZ_Quiz.SinglePlayer();
            this.myMessageBox1 = new AZ_Quiz.MyMessageBox();
            this.tableMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PVP
            // 
            this.PVP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVP.Location = new System.Drawing.Point(370, 249);
            this.PVP.Name = "PVP";
            this.PVP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PVP.Size = new System.Drawing.Size(240, 56);
            this.PVP.TabIndex = 1;
            this.PVP.Text = "PVP";
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.Click += new System.EventHandler(this.PVP_Click);
            // 
            // Solo
            // 
            this.Solo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Solo.Location = new System.Drawing.Point(54, 249);
            this.Solo.Name = "Solo";
            this.Solo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Solo.Size = new System.Drawing.Size(240, 56);
            this.Solo.TabIndex = 2;
            this.Solo.Text = "Solo";
            this.Solo.UseVisualStyleBackColor = true;
            this.Solo.Click += new System.EventHandler(this.Solo_Click);
            // 
            // AC
            // 
            this.AC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AC.Location = new System.Drawing.Point(686, 249);
            this.AC.Name = "AC";
            this.AC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AC.Size = new System.Drawing.Size(240, 56);
            this.AC.TabIndex = 3;
            this.AC.Text = "Manage Account/Scoreboard";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // End_button
            // 
            this.End_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.End_button.BackColor = System.Drawing.Color.Red;
            this.End_button.Cursor = System.Windows.Forms.Cursors.No;
            this.End_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.End_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.End_button.Location = new System.Drawing.Point(906, 506);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(55, 29);
            this.End_button.TabIndex = 4;
            this.End_button.Text = "quit";
            this.End_button.UseVisualStyleBackColor = false;
            this.End_button.Click += new System.EventHandler(this.END_Click);
            // 
            // azQuizGame
            // 
            this.azQuizGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(123)))));
            this.azQuizGame.Location = new System.Drawing.Point(1042, 564);
            this.azQuizGame.Margin = new System.Windows.Forms.Padding(4);
            this.azQuizGame.Name = "azQuizGame";
            this.azQuizGame.Size = new System.Drawing.Size(984, 556);
            this.azQuizGame.TabIndex = 6;
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help.BackColor = System.Drawing.Color.Yellow;
            this.help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.help.Location = new System.Drawing.Point(932, 18);
            this.help.Margin = new System.Windows.Forms.Padding(2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(30, 27);
            this.help.TabIndex = 7;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(397, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "AZ Quiz";
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.SeaGreen;
            this.login1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login1.Location = new System.Drawing.Point(35, 564);
            this.login1.Margin = new System.Windows.Forms.Padding(4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(900, 400);
            this.login1.TabIndex = 9;
            // 
            // scoreBoard1
            // 
            this.scoreBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(133)))), ((int)(((byte)(224)))));
            this.scoreBoard1.Location = new System.Drawing.Point(14, 979);
            this.scoreBoard1.Margin = new System.Windows.Forms.Padding(2);
            this.scoreBoard1.Name = "scoreBoard1";
            this.scoreBoard1.Size = new System.Drawing.Size(984, 556);
            this.scoreBoard1.TabIndex = 12;
            // 
            // tableMenuPanel
            // 
            this.tableMenuPanel.ColumnCount = 5;
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableMenuPanel.Controls.Add(this.help, 3, 1);
            this.tableMenuPanel.Controls.Add(this.End_button, 3, 3);
            this.tableMenuPanel.Controls.Add(this.Solo, 1, 2);
            this.tableMenuPanel.Controls.Add(this.PVP, 2, 2);
            this.tableMenuPanel.Controls.Add(this.AC, 3, 2);
            this.tableMenuPanel.Controls.Add(this.label1, 2, 1);
            this.tableMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.tableMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableMenuPanel.Name = "tableMenuPanel";
            this.tableMenuPanel.RowCount = 5;
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableMenuPanel.Size = new System.Drawing.Size(984, 556);
            this.tableMenuPanel.TabIndex = 13;
            // 
            // singlePlayer1
            // 
            this.singlePlayer1.BackColor = System.Drawing.Color.CadetBlue;
            this.singlePlayer1.Location = new System.Drawing.Point(1042, 1);
            this.singlePlayer1.Name = "singlePlayer1";
            this.singlePlayer1.Size = new System.Drawing.Size(984, 556);
            this.singlePlayer1.TabIndex = 14;
            // 
            // myMessageBox1
            // 
            this.myMessageBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.myMessageBox1.Location = new System.Drawing.Point(570, 1005);
            this.myMessageBox1.Name = "myMessageBox1";
            this.myMessageBox1.Size = new System.Drawing.Size(416, 188);
            this.myMessageBox1.TabIndex = 15;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.myMessageBox1);
            this.Controls.Add(this.singlePlayer1);
            this.Controls.Add(this.tableMenuPanel);
            this.Controls.Add(this.scoreBoard1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.azQuizGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameMenu";
            this.Text = "AZ Quiz";
            this.tableMenuPanel.ResumeLayout(false);
            this.tableMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button PVP;
        private Button Solo;
        private Button AC;
        private Button End_button;
        private AZQuizGame azQuizGame;
        private Button help;
        private Label label1;
        private Login login1;
        private ScoreBoard scoreBoard1;
        private TableLayoutPanel tableMenuPanel;
        private SinglePlayer singlePlayer1;
        private MyMessageBox myMessageBox1;
    }
}