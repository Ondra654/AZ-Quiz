namespace AZ_Quiz
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginNickname = new System.Windows.Forms.TextBox();
            this.RegisterNickName = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterLabel2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginLabel1 = new System.Windows.Forms.Label();
            this.RegisterLabel1 = new System.Windows.Forms.Label();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginLabel2 = new System.Windows.Forms.Label();
            this.TESTLABEL = new System.Windows.Forms.Label();
            this.TESTLABEL2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(640, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register";
            // 
            // LoginNickname
            // 
            this.LoginNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginNickname.Location = new System.Drawing.Point(154, 126);
            this.LoginNickname.Name = "LoginNickname";
            this.LoginNickname.Size = new System.Drawing.Size(192, 27);
            this.LoginNickname.TabIndex = 2;
            // 
            // RegisterNickName
            // 
            this.RegisterNickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterNickName.Location = new System.Drawing.Point(607, 126);
            this.RegisterNickName.Name = "RegisterNickName";
            this.RegisterNickName.Size = new System.Drawing.Size(197, 27);
            this.RegisterNickName.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterButton.Location = new System.Drawing.Point(636, 211);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(140, 28);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Create new acc";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterLabel2
            // 
            this.RegisterLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel2.AutoSize = true;
            this.RegisterLabel2.Location = new System.Drawing.Point(509, 175);
            this.RegisterLabel2.Name = "RegisterLabel2";
            this.RegisterLabel2.Size = new System.Drawing.Size(73, 20);
            this.RegisterLabel2.TabIndex = 6;
            this.RegisterLabel2.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginButton.Location = new System.Drawing.Point(180, 211);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 28);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginLabel1
            // 
            this.LoginLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel1.AutoSize = true;
            this.LoginLabel1.Location = new System.Drawing.Point(57, 129);
            this.LoginLabel1.Name = "LoginLabel1";
            this.LoginLabel1.Size = new System.Drawing.Size(82, 20);
            this.LoginLabel1.TabIndex = 8;
            this.LoginLabel1.Text = "Nickname: ";
            // 
            // RegisterLabel1
            // 
            this.RegisterLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel1.AutoSize = true;
            this.RegisterLabel1.Location = new System.Drawing.Point(504, 129);
            this.RegisterLabel1.Name = "RegisterLabel1";
            this.RegisterLabel1.Size = new System.Drawing.Size(82, 20);
            this.RegisterLabel1.TabIndex = 9;
            this.RegisterLabel1.Text = "Nickname: ";
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPassword.Location = new System.Drawing.Point(607, 171);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '*';
            this.RegisterPassword.Size = new System.Drawing.Size(197, 27);
            this.RegisterPassword.TabIndex = 10;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPassword.Location = new System.Drawing.Point(154, 171);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(192, 27);
            this.LoginPassword.TabIndex = 11;
            // 
            // LoginLabel2
            // 
            this.LoginLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel2.AutoSize = true;
            this.LoginLabel2.Location = new System.Drawing.Point(62, 175);
            this.LoginLabel2.Name = "LoginLabel2";
            this.LoginLabel2.Size = new System.Drawing.Size(73, 20);
            this.LoginLabel2.TabIndex = 12;
            this.LoginLabel2.Text = "Password:";
            // 
            // TESTLABEL
            // 
            this.TESTLABEL.Location = new System.Drawing.Point(533, 278);
            this.TESTLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TESTLABEL.Name = "TESTLABEL";
            this.TESTLABEL.Size = new System.Drawing.Size(294, 20);
            this.TESTLABEL.TabIndex = 13;
            this.TESTLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TESTLABEL2
            // 
            this.TESTLABEL2.Location = new System.Drawing.Point(61, 271);
            this.TESTLABEL2.Name = "TESTLABEL2";
            this.TESTLABEL2.Size = new System.Drawing.Size(294, 20);
            this.TESTLABEL2.TabIndex = 14;
            this.TESTLABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(825, 289);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(58, 29);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructions.Location = new System.Drawing.Point(26, 26);
            this.instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(875, 34);
            this.instructions.TabIndex = 16;
            this.instructions.Text = "For PVP mode login 2 existing accounts or create new one.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterNickName, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.RegisterPassword, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.RegisterButton, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.RegisterLabel1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.RegisterLabel2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginPassword, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.LoginButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LoginNickname, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.back_button, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.86826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.13174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 338);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(428, 301);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.TESTLABEL2);
            this.Controls.Add(this.TESTLABEL);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label RegisterLabel2;
        private Label LoginLabel1;
        private TextBox LoginNickname;
        private TextBox RegisterNickName;
        private Button RegisterButton;
        private Button LoginButton;
        private Label RegisterLabel1;
        private TextBox RegisterPassword;
        private TextBox LoginPassword;
        private Label LoginLabel2;
        private Label TESTLABEL;
        private Label TESTLABEL2;
        private Button back_button;
        private Label instructions;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ResultLabel;
    }
}
