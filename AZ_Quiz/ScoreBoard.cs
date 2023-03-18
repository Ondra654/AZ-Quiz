using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_Quiz
{
    public partial class ScoreBoard : UserControl
    {
        AccountsManager myAccountmanager = new AccountsManager();

        string[] sortedNicks;
        string[] sortedScores;
        public ScoreBoard()
        {
            InitializeComponent();
        }
        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            myAccountmanager.LoadData();//nebude třeba -> same accountmanager -> předělat
            myAccountmanager.SplitTextLine();
            SortData();
        }
        private void SortData()
        {
            for (int i = 0; i < myAccountmanager.accounts.Length; i++)
            {
                int score = Convert.ToInt32(myAccountmanager.highscores[i]);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "nickname";
            dataGridView1.Columns[1].HeaderText = "score";
            for (int i = 0; i < myAccountmanager.accounts.Length; i++)
            {
                string[] scoreData = myAccountmanager.nicknames;
                dataGridView1.Rows.Add(scoreData);
            }
        }
        private void DelAccount_Click(object sender, EventArgs e)
        {
            myAccountmanager.loginNickname = DeleteNickname.Text;
            myAccountmanager.loginPassword = DeletePassword.Text;
            myAccountmanager.FindAccount();
            if(myAccountmanager.AccountExists == true)
            {
                DelLabel.Text = "success";
                myAccountmanager.DeleteAccount();
            }else{
                DelLabel.Text = "smt went wrong";
            }
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    
    }
}
