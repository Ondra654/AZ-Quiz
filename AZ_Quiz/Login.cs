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
    public partial class Login : UserControl
    {
        AccountsManager myAccountsManager = new AccountsManager();
        public Login(){
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e){
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            myAccountsManager.LoadData();
            myAccountsManager.SplitTextLine();

            TESTLABEL.Text = "";
            TESTLABEL2.Text = "";
            foreach (var name in myAccountsManager.nicknames)
            {
                TESTLABEL.Text = TESTLABEL.Text + name;
            }
            foreach(var password in myAccountsManager.passwords)
            {
                TESTLABEL2.Text = TESTLABEL2.Text + password;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            myAccountsManager.newNickname = RegisterNickName.Text;
            myAccountsManager.newPassword = RegisterPassword.Text;
            myAccountsManager.Register();
        }
    }
}
