using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_Quiz
{
    public partial class Login : UserControl
    {
        AccountsManager myAccountsManager;

        bool nickContain = false;

        public void SetAccountsManager(AccountsManager accountManager)
        {
            myAccountsManager = accountManager;
        }
        public Login(){
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e){
            myAccountsManager.LoadData();
            myAccountsManager.SplitTextLine();
        }
        private void SearchForSeparator()
        {
            char character = '%';
            if (RegisterNickName.Text.Contains(character))
            {
                nickContain = true;
            }
        }
        public void CheckIfNameAlreadyExists(){
            if(myAccountsManager.nicknames.Length == 0)
            {
                ResultLabel.Text = "success";
            }else{
                foreach (var checkNickname in myAccountsManager.nicknames){
                    if (RegisterNickName.Text == checkNickname){
                        ResultLabel.Text = "This name already exists!";
                        break;
                    }else{
                        ResultLabel.Text = "success";
                    }
                }
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            myAccountsManager.loginNickname = LoginNickname.Text;
            string hashedPassword = AccountsManager.HashPasswords(LoginPassword.Text);
            myAccountsManager.loginPassword = hashedPassword;
            myAccountsManager.FindAccount();
            if(myAccountsManager.AccountExists == true){
                ResultLabel.Text = "success";
                if (myAccountsManager.account1 == ""){
                    myAccountsManager.account1 = LoginNickname.Text;
                }else{
                    myAccountsManager.account2 = LoginNickname.Text;
                    ResultLabel.Text = "";
                    this.Hide();
                }
            }
            else if (myAccountsManager.AccountExists == false){
                ResultLabel.Text = "Something went wrong, try again.";
            }
            LoginNickname.Text = "";
            LoginPassword.Text = "";
        }
        private void RegisterButton_Click(object sender, EventArgs e){
            if (string.IsNullOrWhiteSpace(RegisterNickName.Text)||string.IsNullOrWhiteSpace(RegisterPassword.Text))
            {
                ResultLabel.Text = "Your new account data must contain some characters.";
            }else if(RegisterNickName.Text.Substring(0,1) == " "||RegisterPassword.Text.Substring(0, 1) == " ")
            {
                ResultLabel.Text = "Your new nickname/password can not start with empty gap";
            }else{
                SearchForSeparator();
                if (nickContain == false)
                {
                    CheckIfNameAlreadyExists();
                }else{
                    ResultLabel.Text = "Your nick can not contain '%', try again please.";
                    nickContain = false;
                }
                if(ResultLabel.Text == "success"){
                    myAccountsManager.newNickname = RegisterNickName.Text;
                    myAccountsManager.newPassword = RegisterPassword.Text;
                    myAccountsManager.Register();
                    if (myAccountsManager.account1 == ""){
                        myAccountsManager.account1 = RegisterNickName.Text;
                    }else{
                        myAccountsManager.account2 = RegisterNickName.Text;
                        ResultLabel.Text = "";
                        this.Hide();
                    }
                }
            }
            RegisterNickName.Text = "";
            RegisterPassword.Text = "";
        }        
        private void Backbutton_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
