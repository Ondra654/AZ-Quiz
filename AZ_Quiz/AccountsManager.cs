using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_Quiz
{
    internal class AccountsManager
    {
        const string AccountsPath = "C:\\Users\\Ondra\\source\\repos\\AZ-Quiz\\Accounts.txt";
        public string[] accounts;

        public string[] nicknames = new string[0];
        public string[] passwords = new string[0];
        public string[] highscores= new string[0];

        public int EmptyScore = 0;
        public string DeletingAccount = "";
        public string newNickname = "";
        public string newPassword = "";
        public string LoginNickname = "";
        public string LoginPassword = "";

        public bool AccountExists = false;

        public string Account1 = "";
        public string Account2 = "";

        internal void LoadData()
        {
            accounts = File.ReadAllLines(AccountsPath);
            nicknames= new string[accounts.Length];
            passwords= new string[accounts.Length];
            highscores= new string[accounts.Length];
        }
        public void SplitTextLine()
        {
                for (int i = 0; i < accounts.Length; i++)
                {
                    string[] splitAccounts;
                    splitAccounts = accounts[i].Split(" ");
                    nicknames[i] = splitAccounts[0];
                    passwords[i] = splitAccounts[1];
                    highscores[i] = splitAccounts[2];
                }
        }
        public void JoinTextLine()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = string.Join(nicknames[i], " ", passwords[i]);
            }
        }
        public void Register()
        {
            string NewAccScore = EmptyScore.ToString();
            string seperator = " ";
            string[] linkedAccount = new string[] {newNickname,newPassword, NewAccScore};
            string[]NP = new string[] {String.Join(seperator, linkedAccount)};
            File.AppendAllLines(AccountsPath, NP);
        }
        public void FindAccount()
        {
            foreach (var checkNickname in nicknames){
                if (LoginNickname == checkNickname){
                    foreach (var checkPassword in passwords){
                        if (LoginPassword == checkPassword){   
                            JoinTextLine();
                            string EnteredData = string.Join(LoginNickname, " ", LoginPassword);
                            foreach (var checkData in accounts){
                                if (EnteredData == checkData){
                                    AccountExists = true;
                                }
                            }break;
                        }else{
                            AccountExists = false;
                        }
                    }break;
                }
            }
        }
        public void DeleteAccount() 
        {
            string JoinedAccData = string.Join(LoginNickname, " ", LoginPassword, " ", EmptyScore);
            DeletingAccount = JoinedAccData;
            foreach(var findRow in accounts)
            {
                
            }
        }

        public void SaveData()
        {

        }

    }
}
