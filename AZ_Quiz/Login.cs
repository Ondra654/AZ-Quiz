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
        AccountsManager myAccountsManager;
        GameManager myGamemanager = new GameManager();

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
        public void CheckIfNameAlreadyExists(){
            foreach (var checkNickname in myAccountsManager.nicknames){
                if (RegisterNickName.Text == checkNickname){
                    ResultLabel.Text = "This name already exists!";
                    break;
                }else{
                    ResultLabel.Text = "success";
                }
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            myAccountsManager.LoginNickname = LoginNickname.Text;
            string hashedPassword = AccountsManager.HashPasswords(LoginPassword.Text);
            myAccountsManager.LoginPassword = hashedPassword;
            myAccountsManager.FindAccount();
            if(myAccountsManager.AccountExists == true){
                ResultLabel.Text = "success";
                if (myAccountsManager.Account1 == ""){
                    myAccountsManager.Account1 = LoginNickname.Text;
                }else{
                    myAccountsManager.Account2 = LoginNickname.Text;
                    this.Hide();
                }
            }
            else if (myAccountsManager.AccountExists == false){
                ResultLabel.Text = "This Password does not exists!";
            }
            LoginNickname.Text = "";
            LoginPassword.Text = "";
        }
        private void RegisterButton_Click(object sender, EventArgs e){
            CheckIfNameAlreadyExists();
            if(ResultLabel.Text == "success"){
                myAccountsManager.newNickname = RegisterNickName.Text;
                myAccountsManager.newPassword = RegisterPassword.Text;
                myAccountsManager.Register();
                if (myAccountsManager.Account1 == ""){
                    myAccountsManager.Account1 = RegisterNickName.Text;
                }else{
                    myAccountsManager.Account2 = RegisterNickName.Text;
                    this.Hide();
                }
            }
            RegisterNickName.Text = "";
            RegisterPassword.Text = "";
        }        
        private void back_button_Click(object sender, EventArgs e){
            this.Hide();
        }
    }
}
