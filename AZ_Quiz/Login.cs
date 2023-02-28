﻿using System;
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
            myAccountsManager.LoadData();
            myAccountsManager.SplitTextLine();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            foreach (var checkNickname in myAccountsManager.nicknames){
                if (LoginNickname.Text == checkNickname){
                    foreach (var checkPassword in myAccountsManager.passwords){
                        if(LoginPassword.Text == checkPassword){
                            myAccountsManager.JoinTextLine();
                            string EnteredData = string.Join(LoginNickname.Text," ",LoginPassword.Text);
                            foreach(var checkData in myAccountsManager.accounts){
                                if(EnteredData == checkData){
                                    TESTLABEL2.Text = "success";
                                }
                            }break;
                        }else{
                            TESTLABEL2.Text = "This Password does not exists!";
                        }
                    }break;
                }
            }
        }
        public void CheckIfNameAlreadyExists()
        {
            foreach (var checkNickname in myAccountsManager.nicknames){
                if (RegisterNickName.Text == checkNickname){
                    TESTLABEL.Text = "This name already exists!";
                    break;
                }else{
                    TESTLABEL.Text = "success";
                }
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CheckIfNameAlreadyExists();
            if(TESTLABEL.Text == "success"){
                myAccountsManager.newNickname = RegisterNickName.Text;
                myAccountsManager.newPassword = RegisterPassword.Text;
                myAccountsManager.Register();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
