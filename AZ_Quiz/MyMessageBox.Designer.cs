namespace AZ_Quiz
{
    partial class MyMessageBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.message1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message1
            // 
            this.message1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.message1.Location = new System.Drawing.Point(3, 48);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(327, 25);
            this.message1.TabIndex = 1;
            this.message1.Text = "message";
            this.message1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.message1);
            this.Controls.Add(this.button1);
            this.Name = "MyMessageBox";
            this.Size = new System.Drawing.Size(333, 150);
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label message1;
    }
}
