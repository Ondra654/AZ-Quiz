using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AZ_Quiz.Properties;
using System.Text.RegularExpressions;
using System.Diagnostics;

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


        static string GetPath(params string[] segments)
        {
            string path = Directory.GetCurrentDirectory();

            path = Path.Combine(path, "..", "..", "AZ-Quiz", "AZ_Quiz");

            for (int i = 0; i < segments.Length; i += 1)
            {
                path = Path.Combine(path, segments[i]);
            }
            return path;
        }
        internal void LoadData()
        {
            string path = GetPath("data", "Accounts.txt");
            accounts = File.ReadAllLines(path);
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
        public void JoinTextLineForDelete()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = string.Join(accounts[i], " ", highscores[i]);
            }
        }
        public void Register()
        {
            string NewAccScore = EmptyScore.ToString();
            string seperator = " ";
            string[] linkedAccount = new string[] {newNickname,newPassword, NewAccScore};
            string[]NP = new string[] {String.Join(seperator, linkedAccount)};
            string path = GetPath("data", "Accounts.txt");
            File.AppendAllLines(path, NP);
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
            string NickPass = string.Join(LoginNickname, " ", LoginPassword);
            string JoinedAccData = string.Join(NickPass, " ", EmptyScore.ToString());
            DeletingAccount = JoinedAccData;
            JoinTextLineForDelete();
            accounts = accounts.Where(e => e != DeletingAccount).ToArray();

            File.WriteAllLines(AccountsPath, accounts);
        }
        public void HelpLoad() 
        {
            string HelpPath = GetPath("data", "rules.html");
            ProcessStartInfo info = new ProcessStartInfo();//z netu
            info.FileName = HelpPath;
            info.UseShellExecute = true;
            Process.Start(info);
        }

    }
}
