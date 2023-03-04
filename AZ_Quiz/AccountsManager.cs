using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_Quiz
{
    internal class AccountsManager
    {
        const string AccountsPath = "C:\\Users\\Ondra\\source\\repos\\AZ_Quiz\\Accounts.txt";
        public string[] accounts;

        public string[] nicknames = new string[0];
        public string[] passwords = new string[0];

        public string newNickname = "";
        public string newPassword = "";
        public string LoginNickname = "";
        public string LoginPassword = "";

        public string Account1 = "";
        public string Account2 = "";

        internal void LoadData()
        {
            accounts = File.ReadAllLines(AccountsPath);
            nicknames= new string[accounts.Length];
            passwords= new string[accounts.Length];
        }
        public void SplitTextLine()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                string[] splitAccounts;
                splitAccounts = accounts[i].Split(" ");
                nicknames[i] = splitAccounts[0];
                passwords[i] = splitAccounts[1];
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
            int EmptyScore = 0;
            string NewAccScore = EmptyScore.ToString();
            string seperator = " ";
            string[] linkedAccount = new string[] {newNickname,newPassword, NewAccScore};
            string[]NP = new string[] {String.Join(seperator, linkedAccount)};
            File.AppendAllLines(AccountsPath, NP);
        }
        public void SaveData()
        {

        }

    }
}
