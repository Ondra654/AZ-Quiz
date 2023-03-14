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


        public ScoreBoard()
        {
            InitializeComponent();
        }
        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            myAccountmanager.LoadData();
            myAccountmanager.SplitTextLine();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nick = myAccountmanager.nicknames;
            dataGridView1.DataSource = nick.ToString();
        }

        private void DelAccount_Click(object sender, EventArgs e)
        {
            myAccountmanager.LoginNickname = DeleteNickname.Text;
            myAccountmanager.LoginPassword = DeletePassword.Text;
            myAccountmanager.FindAccount();
            if(myAccountmanager.AccountExists == true)
            {
                DelLabel.Text = "success";
                myAccountmanager.DeleteAccount();
            }else{
                DelLabel.Text = "smt went wrong";
            }
        }

    }
}
