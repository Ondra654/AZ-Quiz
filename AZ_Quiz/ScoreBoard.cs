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
        AccountsManager myAccountsManager;

        string[] sortednicks;
        int[] sortedscore;
        public ScoreBoard()
        {
            InitializeComponent();
        }
        public void SetAccountsManager(AccountsManager accountManager)
        {
            myAccountsManager = accountManager;
        }
        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            myAccountsManager.LoadData();//nebude třeba -> same accountmanager -> předělat
            myAccountsManager.SplitTextLine();
            SortData();
            int rows = sortednicks.Length;
            int rowsize = (dataGridView1.Height - dataGridView1.ColumnHeadersHeight) / rows;
            dataGridView1.RowTemplate.Height = rowsize;
            for (int i = 0; i < sortednicks.Length; i++)
            {
                dataGridView1.Rows.Add(sortednicks[i], sortedscore[i]);
            }
        }
        private void SortData()
        {
            sortednicks = new string[myAccountsManager.nicknames.Length];
            for(int i = 0;i < myAccountsManager.nicknames.Length;i++)
            {
                string nick = myAccountsManager.nicknames[i];
                sortednicks[i]= nick;
            }
            sortedscore = Array.ConvertAll(myAccountsManager.highscores, int.Parse);
            Array.Sort(sortedscore, sortednicks);
            Array.Reverse(sortedscore);
            Array.Reverse(sortednicks);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            myAccountsManager.LoadData();
            myAccountsManager.SplitTextLine();
            SortData();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < sortednicks.Length; i++)
            {
                dataGridView1.Rows.Add(sortednicks[i], sortedscore[i]);
            }
        }
        private void DelAccount_Click(object sender, EventArgs e)
        {
            myAccountsManager.loginNickname = DeleteNickname.Text;
            string hashedPassword = AccountsManager.HashPasswords(DeletePassword.Text);
            myAccountsManager.loginPassword = hashedPassword;
            myAccountsManager.FindAccount();
            if(myAccountsManager.AccountExists == true)
            {
                DelLabel.Text = "success";
                myAccountsManager.DeleteAccount();
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
