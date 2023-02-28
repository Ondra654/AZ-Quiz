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
            this.hexagonButton1 = new AZ_Quiz.HexagonButton();
            this.hexagonButton16 = new AZ_Quiz.HexagonButton();
            this.hexagonButton17 = new AZ_Quiz.HexagonButton();
            this.SuspendLayout();
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
            this.back_button.TabIndex = 6;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // hexagonButton1
            // 
            this.hexagonButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton1.FlatAppearance.BorderSize = 0;
            this.hexagonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexagonButton1.ForeColor = System.Drawing.Color.White;
            this.hexagonButton1.HexagonSide = 10;
            this.hexagonButton1.Location = new System.Drawing.Point(300, 450);
            this.hexagonButton1.Name = "hexagonButton1";
            this.hexagonButton1.Size = new System.Drawing.Size(40, 46);
            this.hexagonButton1.TabIndex = 7;
            this.hexagonButton1.Text = "hexagonButton1";
            this.hexagonButton1.TextColor = System.Drawing.Color.White;
            this.hexagonButton1.UseVisualStyleBackColor = false;
            // 
            // hexagonButton16
            // 
            this.hexagonButton16.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton16.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton16.FlatAppearance.BorderSize = 0;
            this.hexagonButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexagonButton16.ForeColor = System.Drawing.Color.White;
            this.hexagonButton16.HexagonSide = 10;
            this.hexagonButton16.Location = new System.Drawing.Point(323, 409);
            this.hexagonButton16.Name = "hexagonButton16";
            this.hexagonButton16.Size = new System.Drawing.Size(40, 46);
            this.hexagonButton16.TabIndex = 22;
            this.hexagonButton16.Text = "hexagonButton16";
            this.hexagonButton16.TextColor = System.Drawing.Color.White;
            this.hexagonButton16.UseVisualStyleBackColor = false;
            // 
            // hexagonButton17
            // 
            this.hexagonButton17.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton17.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.hexagonButton17.FlatAppearance.BorderSize = 0;
            this.hexagonButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexagonButton17.ForeColor = System.Drawing.Color.White;
            this.hexagonButton17.HexagonSide = 10;
            this.hexagonButton17.Location = new System.Drawing.Point(346, 450);
            this.hexagonButton17.Name = "hexagonButton17";
            this.hexagonButton17.Size = new System.Drawing.Size(40, 46);
            this.hexagonButton17.TabIndex = 23;
            this.hexagonButton17.Text = "hexagonButton17";
            this.hexagonButton17.TextColor = System.Drawing.Color.White;
            this.hexagonButton17.UseVisualStyleBackColor = false;
            // 
            // Mplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(123)))));
            this.Controls.Add(this.hexagonButton17);
            this.Controls.Add(this.hexagonButton16);
            this.Controls.Add(this.hexagonButton1);
            this.Controls.Add(this.back_button);
            this.Name = "Mplayer";
            this.Size = new System.Drawing.Size(985, 555);
            this.Load += new System.EventHandler(this.Mplayer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button back_button;
        private HexagonButton hexagonButton1;
        private HexagonButton hexagonButton16;
        private HexagonButton hexagonButton17;
    }
}
