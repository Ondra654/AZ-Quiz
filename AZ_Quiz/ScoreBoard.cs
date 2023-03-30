﻿using Microsoft.VisualBasic;
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
        int rowsize;
        int maxrowsize = 60;
        public ScoreBoard()
        {
            InitializeComponent();
        }
        public void SetAccountsManager(AccountsManager accountManager)
        {
            myAccountsManager = accountManager;
        }
        private void ScoreBoard_Load(object sender, EventArgs e)//for working datagridview I used this: https://www.youtube.com/watch?v=GyLlpBZGsrE&t=201s and https://learn.microsoft.com/cs-cz/dotnet/api/system.windows.forms.datagridview?view=windowsdesktop-7.0for for learning how this tool works.
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            myAccountsManager.LoadData();
            myAccountsManager.SplitTextLine();
            SortData();
            dataGridView1.Rows.Clear();
            int rows = sortednicks.Length;
            if (sortednicks.Length > 10)
            {
                rows = 10;
            }
            if (rows == 0)
            {
                rowsize = (dataGridView1.Height - dataGridView1.ColumnHeadersHeight);
                dataInfo.Text = "0 existing profiles, create some to display scoreboard";
                dataInfo.Show();
            }
            else
            {
                rowsize = (dataGridView1.Height - dataGridView1.ColumnHeadersHeight) / rows;
                if(rowsize > maxrowsize){
                    rowsize = maxrowsize;
                }
                dataInfo.Hide();
            }
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
            sortedscore = Array.ConvertAll(myAccountsManager.highscores, int.Parse);//take over and applied from: https://stackoverflow.com/questions/1297231/convert-string-to-int-in-one-line-of-code-using-linq
            Array.Sort(sortedscore, sortednicks);
            Array.Reverse(sortedscore);
            Array.Reverse(sortednicks);
        }
        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
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
            LoadDataGridView();
            DeleteNickname.Text = string.Empty;
            DeletePassword.Text = string.Empty;
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            DeleteNickname.Text = "";
            DeletePassword.Text = "";
            DelLabel.Text = "For deleting, enter account´s nickname and password";
            this.Hide();
        }
    }
}
