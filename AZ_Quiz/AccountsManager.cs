﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_Quiz
{
    internal class AccountsManager
    {
        const string AccountsPath = "C:\\Users\\Ondra\\source\\repos\\AZ_Quiz\\Accounts.txt";
        public string[] accounts = new string[0];

        private string[] nicknames = new string [0];
        private string[] passwords = new string [0];

        public string Nickname = "";
        public string Password = "";
        public AccountsManager() 
        { 

        }
        internal void LoadData()
        {
            accounts = File.ReadAllLines(AccountsPath);
            nicknames= new string[accounts.Length];
            passwords= new string[accounts.Length];
        }
        internal void SavedData()
        {
            File.WriteAllLines(AccountsPath, accounts);
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
        public void Login()
        {
            
        }
        public void Register()
        {

        }
    }
}
