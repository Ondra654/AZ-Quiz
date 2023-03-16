namespace AZ_Quiz
{
    partial class ScoreBoard
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteNickname = new System.Windows.Forms.TextBox();
            this.DeletePassword = new System.Windows.Forms.TextBox();
            this.DelAccount = new System.Windows.Forms.Button();
            this.DelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.back_button.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(718, 392);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DeleteNickname
            // 
            this.DeleteNickname.Location = new System.Drawing.Point(878, 202);
            this.DeleteNickname.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteNickname.Name = "DeleteNickname";
            this.DeleteNickname.Size = new System.Drawing.Size(254, 31);
            this.DeleteNickname.TabIndex = 0;
            // 
            // DeletePassword
            // 
            this.DeletePassword.Location = new System.Drawing.Point(878, 261);
            this.DeletePassword.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.PasswordChar = '*';
            this.DeletePassword.Size = new System.Drawing.Size(254, 31);
            this.DeletePassword.TabIndex = 1;
            // 
            // DelAccount
            // 
            this.DelAccount.Location = new System.Drawing.Point(922, 320);
            this.DelAccount.Margin = new System.Windows.Forms.Padding(2);
            this.DelAccount.Name = "DelAccount";
            this.DelAccount.Size = new System.Drawing.Size(155, 34);
            this.DelAccount.TabIndex = 2;
            this.DelAccount.Text = "Delete Account";
            this.DelAccount.UseVisualStyleBackColor = true;
            this.DelAccount.Click += new System.EventHandler(this.DelAccount_Click);
            // 
            // DelLabel
            // 
            this.DelLabel.AutoSize = true;
            this.DelLabel.Location = new System.Drawing.Point(968, 384);
            this.DelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(59, 25);
            this.DelLabel.TabIndex = 12;
            this.DelLabel.Text = "label1";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelLabel);
            this.Controls.Add(this.DelAccount);
            this.Controls.Add(this.DeletePassword);
            this.Controls.Add(this.DeleteNickname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(1230, 695);
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button back_button;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox DeleteNickname;
        private TextBox DeletePassword;
        private Button DelAccount;
        private Label DelLabel;
    }
}
