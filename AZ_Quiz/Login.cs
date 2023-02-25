using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            string[] Names = new string[myAccountsManager.nicknames.Length];

            foreach (var checkNickname in myAccountsManager.nicknames)
            {
                if (checkNickname == LoginNickname.Text)
                {
                    foreach (var checkPassword in myAccountsManager.passwords)
                    {
                        if(LoginPassword.Text == checkPassword)
                        {
                            myAccountsManager.LoginNickname = LoginNickname.Text;
                            myAccountsManager.LoginPassword= LoginPassword.Text;
                        }
                    }
                    TESTLABEL2.Text = "success";
                }else{
                    TESTLABEL2.Text = "This Nickname does not exist!";
                }
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
