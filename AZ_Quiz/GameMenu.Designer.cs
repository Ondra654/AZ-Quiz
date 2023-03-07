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
            this.mplayer1 = new AZ_Quiz.Mplayer();
            this.help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login1 = new AZ_Quiz.Login();
            this.splayer1 = new AZ_Quiz.Splayer();
            this.scoreBoard1 = new AZ_Quiz.ScoreBoard();
            this.tableMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PVP
            // 
            this.PVP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVP.Location = new System.Drawing.Point(464, 312);
            this.PVP.Margin = new System.Windows.Forms.Padding(4);
            this.PVP.Name = "PVP";
            this.PVP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PVP.Size = new System.Drawing.Size(300, 70);
            this.PVP.TabIndex = 1;
            this.PVP.Text = "PVP";
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.Click += new System.EventHandler(this.PVP_Click);
            // 
            // Solo
            // 
            this.Solo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Solo.Location = new System.Drawing.Point(68, 312);
            this.Solo.Margin = new System.Windows.Forms.Padding(4);
            this.Solo.Name = "Solo";
            this.Solo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Solo.Size = new System.Drawing.Size(300, 70);
            this.Solo.TabIndex = 2;
            this.Solo.Text = "Solo";
            this.Solo.UseVisualStyleBackColor = true;
            this.Solo.Click += new System.EventHandler(this.Solo_Click);
            // 
            // AC
            // 
            this.AC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AC.Location = new System.Drawing.Point(860, 312);
            this.AC.Margin = new System.Windows.Forms.Padding(4);
            this.AC.Name = "AC";
            this.AC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AC.Size = new System.Drawing.Size(300, 70);
            this.AC.TabIndex = 3;
            this.AC.Text = "Manage Account";
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
            this.End_button.Location = new System.Drawing.Point(1135, 634);
            this.End_button.Margin = new System.Windows.Forms.Padding(4);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(69, 36);
            this.End_button.TabIndex = 4;
            this.End_button.Text = "quit";
            this.End_button.UseVisualStyleBackColor = false;
            this.End_button.Click += new System.EventHandler(this.END_Click);
            // 
            // mplayer1
            // 
            this.mplayer1.BackColor = System.Drawing.Color.White;
            this.mplayer1.Location = new System.Drawing.Point(1255, 705);
            this.mplayer1.Margin = new System.Windows.Forms.Padding(5);
            this.mplayer1.Name = "mplayer1";
            this.mplayer1.Size = new System.Drawing.Size(1230, 695);
            this.mplayer1.TabIndex = 6;
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help.BackColor = System.Drawing.Color.Yellow;
            this.help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.help.Location = new System.Drawing.Point(1168, 22);
            this.help.Margin = new System.Windows.Forms.Padding(2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(38, 34);
            this.help.TabIndex = 7;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(503, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "AZ Quiz";
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.SeaGreen;
            this.login1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login1.Location = new System.Drawing.Point(44, 705);
            this.login1.Margin = new System.Windows.Forms.Padding(5);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1124, 500);
            this.login1.TabIndex = 9;
            // 
            // splayer1
            // 
            this.splayer1.BackColor = System.Drawing.Color.CadetBlue;
            this.splayer1.Location = new System.Drawing.Point(1255, 1);
            this.splayer1.Margin = new System.Windows.Forms.Padding(5);
            this.splayer1.Name = "splayer1";
            this.splayer1.Size = new System.Drawing.Size(1230, 695);
            this.splayer1.TabIndex = 10;
            // 
            // scoreBoard1
            // 
            this.scoreBoard1.BackColor = System.Drawing.Color.White;
            this.scoreBoard1.Location = new System.Drawing.Point(17, 1224);
            this.scoreBoard1.Name = "scoreBoard1";
            this.scoreBoard1.Size = new System.Drawing.Size(1230, 695);
            this.scoreBoard1.TabIndex = 12;
            // 
            // tableMenuPanel
            // 
            this.tableMenuPanel.ColumnCount = 5;
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMenuPanel.Controls.Add(this.help, 3, 1);
            this.tableMenuPanel.Controls.Add(this.End_button, 3, 3);
            this.tableMenuPanel.Controls.Add(this.Solo, 1, 2);
            this.tableMenuPanel.Controls.Add(this.PVP, 2, 2);
            this.tableMenuPanel.Controls.Add(this.AC, 3, 2);
            this.tableMenuPanel.Controls.Add(this.label1, 2, 1);
            this.tableMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.tableMenuPanel.Name = "tableMenuPanel";
            this.tableMenuPanel.RowCount = 5;
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMenuPanel.Size = new System.Drawing.Size(1230, 695);
            this.tableMenuPanel.TabIndex = 13;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1234, 699);
            this.Controls.Add(this.tableMenuPanel);
            this.Controls.Add(this.scoreBoard1);
            this.Controls.Add(this.splayer1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.mplayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameMenu";
            this.Text = "AZ Quiz";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.tableMenuPanel.ResumeLayout(false);
            this.tableMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button PVP;
        private Button Solo;
        private Button AC;
        private Button End_button;
        private Mplayer mplayer1;
        private Button help;
        private Label label1;
        private Login login1;
        private Splayer splayer1;
        private ScoreBoard scoreBoard1;
        private TableLayoutPanel tableMenuPanel;
    }
}