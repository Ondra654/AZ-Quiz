using System.Windows.Forms.VisualStyles;

namespace AZ_Quiz
{
    partial class SinglePlayer
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
            this.SinAnswer = new System.Windows.Forms.TextBox();
            this.SinQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.RevealAnswer = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SinAnswer
            // 
            this.SinAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SinAnswer.BackColor = System.Drawing.Color.BurlyWood;
            this.SinAnswer.Location = new System.Drawing.Point(222, 380);
            this.SinAnswer.Name = "SinAnswer";
            this.SinAnswer.Size = new System.Drawing.Size(403, 27);
            this.SinAnswer.TabIndex = 0;
            this.SinAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SinAnswer_Entered);
            // 
            // SinQuestion
            // 
            this.SinQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SinQuestion.AutoEllipsis = true;
            this.SinQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SinQuestion.Location = new System.Drawing.Point(60, 88);
            this.SinQuestion.Name = "SinQuestion";
            this.SinQuestion.Size = new System.Drawing.Size(727, 166);
            this.SinQuestion.TabIndex = 1;
            this.SinQuestion.Text = "Press Question button to start.";
            this.SinQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(835, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(908, 507);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(55, 29);
            this.back_button.TabIndex = 3;
            this.back_button.TabStop = false;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // RevealAnswer
            // 
            this.RevealAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RevealAnswer.Location = new System.Drawing.Point(222, 488);
            this.RevealAnswer.Name = "RevealAnswer";
            this.RevealAnswer.Size = new System.Drawing.Size(403, 24);
            this.RevealAnswer.TabIndex = 7;
            this.RevealAnswer.Text = ".";
            this.RevealAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.score.Location = new System.Drawing.Point(835, 301);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(86, 25);
            this.score.TabIndex = 8;
            this.score.Text = "score: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.87048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.12952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.back_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.score, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RevealAnswer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SinAnswer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SinQuestion, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.17431F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.84098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 556);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SinglePlayer";
            this.Size = new System.Drawing.Size(984, 556);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox SinAnswer;
        private Label SinQuestion;
        private Button button1;
        private Button back_button;
        private Label RevealAnswer;
        private Label score;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
