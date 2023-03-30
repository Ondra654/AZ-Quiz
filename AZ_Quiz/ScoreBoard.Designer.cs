using System.Drawing.Drawing2D;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloadbutton = new System.Windows.Forms.Button();
            this.DeleteNickname = new System.Windows.Forms.TextBox();
            this.DeletePassword = new System.Windows.Forms.TextBox();
            this.DelAccount = new System.Windows.Forms.Button();
            this.DelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Red;
            this.back_button.Cursor = System.Windows.Forms.Cursors.No;
            this.back_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(908, 507);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(55, 29);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(390, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(568, 316);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "nickname";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "score";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Reloadbutton
            // 
            this.Reloadbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Reloadbutton.Location = new System.Drawing.Point(626, 439);
            this.Reloadbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Reloadbutton.Name = "Reloadbutton";
            this.Reloadbutton.Size = new System.Drawing.Size(109, 27);
            this.Reloadbutton.TabIndex = 8;
            this.Reloadbutton.Text = "Refresh";
            this.Reloadbutton.UseVisualStyleBackColor = false;
            this.Reloadbutton.Click += new System.EventHandler(this.Reloadbutton_Click);
            // 
            // DeleteNickname
            // 
            this.DeleteNickname.Location = new System.Drawing.Point(60, 154);
            this.DeleteNickname.Name = "DeleteNickname";
            this.DeleteNickname.Size = new System.Drawing.Size(201, 27);
            this.DeleteNickname.TabIndex = 0;
            // 
            // DeletePassword
            // 
            this.DeletePassword.Location = new System.Drawing.Point(60, 200);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.PasswordChar = '*';
            this.DeletePassword.Size = new System.Drawing.Size(201, 27);
            this.DeletePassword.TabIndex = 1;
            // 
            // DelAccount
            // 
            this.DelAccount.Location = new System.Drawing.Point(100, 241);
            this.DelAccount.Margin = new System.Windows.Forms.Padding(2);
            this.DelAccount.Name = "DelAccount";
            this.DelAccount.Size = new System.Drawing.Size(124, 27);
            this.DelAccount.TabIndex = 2;
            this.DelAccount.Text = "Delete Account";
            this.DelAccount.UseVisualStyleBackColor = true;
            this.DelAccount.Click += new System.EventHandler(this.DelAccount_Click);
            // 
            // DelLabel
            // 
            this.DelLabel.Location = new System.Drawing.Point(60, 279);
            this.DelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(200, 52);
            this.DelLabel.TabIndex = 12;
            this.DelLabel.Text = "For deleting, enter account´s nickname and password";
            this.DelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.DeleteNickname);
            this.panel1.Controls.Add(this.DelLabel);
            this.panel1.Controls.Add(this.DeletePassword);
            this.panel1.Controls.Add(this.DelAccount);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 556);
            this.panel1.TabIndex = 13;
            // 
            // dataInfo
            // 
            this.dataInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dataInfo.Location = new System.Drawing.Point(506, 270);
            this.dataInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.Size = new System.Drawing.Size(340, 52);
            this.dataInfo.TabIndex = 14;
            this.dataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(133)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dataInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reloadbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(984, 556);
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button back_button;
        private DataGridView dataGridView1;
        private Button Reloadbutton;
        private TextBox DeleteNickname;
        private TextBox DeletePassword;
        private Button DelAccount;
        private Label DelLabel;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label dataInfo;
    }
}
