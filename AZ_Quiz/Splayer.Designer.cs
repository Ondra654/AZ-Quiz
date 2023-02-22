using System.Windows.Forms.VisualStyles;

namespace AZ_Quiz
{
    partial class Splayer
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
            this.EnterAnswer = new System.Windows.Forms.Button();
            this.RevealAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SinAnswer
            // 
            this.SinAnswer.BackColor = System.Drawing.Color.BurlyWood;
            this.SinAnswer.Location = new System.Drawing.Point(279, 301);
            this.SinAnswer.Name = "SinAnswer";
            this.SinAnswer.Size = new System.Drawing.Size(403, 27);
            this.SinAnswer.TabIndex = 0;
            // 
            // SinQuestion
            // 
            this.SinQuestion.AutoEllipsis = true;
            this.SinQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SinQuestion.Location = new System.Drawing.Point(36, 119);
            this.SinQuestion.Name = "SinQuestion";
            this.SinQuestion.Size = new System.Drawing.Size(931, 166);
            this.SinQuestion.TabIndex = 1;
            this.SinQuestion.Text = "Press Question button to start";
            this.SinQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(915, 512);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(55, 29);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // EnterAnswer
            // 
            this.EnterAnswer.Location = new System.Drawing.Point(697, 300);
            this.EnterAnswer.Name = "EnterAnswer";
            this.EnterAnswer.Size = new System.Drawing.Size(128, 29);
            this.EnterAnswer.TabIndex = 6;
            this.EnterAnswer.Text = "reveal answer";
            this.EnterAnswer.UseVisualStyleBackColor = true;
            this.EnterAnswer.Click += new System.EventHandler(this.EnterAnswer_Click);
            // 
            // RevealAnswer
            // 
            this.RevealAnswer.Location = new System.Drawing.Point(36, 407);
            this.RevealAnswer.Name = "RevealAnswer";
            this.RevealAnswer.Size = new System.Drawing.Size(931, 42);
            this.RevealAnswer.TabIndex = 7;
            this.RevealAnswer.Text = ".";
            this.RevealAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.RevealAnswer);
            this.Controls.Add(this.EnterAnswer);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SinQuestion);
            this.Controls.Add(this.SinAnswer);
            this.Name = "Splayer";
            this.Size = new System.Drawing.Size(985, 555);
            this.Load += new System.EventHandler(this.Splayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SinAnswer;
        private Label SinQuestion;
        private Button button1;
        private Button back_button;
        private Button EnterAnswer;
        private Label RevealAnswer;
    }
}
