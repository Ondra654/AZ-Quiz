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
using System.Security.Cryptography;

namespace AZ_Quiz
{
    public class AccountsManager
    {
        string path = GetPath("data", "Accounts.txt");
        
        public string[] accounts = Array.Empty<string>();
        public string[] nicknames = Array.Empty<string>();
        public string[] passwords = Array.Empty<string>();
        public string[] highscores= Array.Empty<string>();

        public bool AccountExists = false;

        public int EmptyScore = 0;
        public string newNickname = "";
        public string newPassword = "";
        public int hashedPassword;

        public string LoginNickname = "";
        public string LoginPassword = "";
        public string DeletingAccount = "";
        public string seperator = " ";

        public string Account1 = "";
        public string Account2 = "";
        static string GetPath(params string[] segments)
        {
            string path = Directory.GetCurrentDirectory();

            path = Path.Combine(path);

            for (int i = 0; i < segments.Length; i += 1)
            {
                path = Path.Combine(path, segments[i]);
            }
            return path;
        }
        internal void LoadData()
        {
            accounts = File.ReadAllLines(path);
            nicknames= new string[accounts.Length];
            passwords= new string[accounts.Length];
            highscores= new string[accounts.Length];
        }
        public void SplitTextLine()
        {
            for (int i = 0; i < accounts.Length; i++){
                string[] splitAccounts;
                splitAccounts = accounts[i].Split(" ");
                nicknames[i] = splitAccounts[0];
                passwords[i] = splitAccounts[1];
                highscores[i] = splitAccounts[2];
            }
        }
        public void JoinTextLine()
        {
            for (int i = 0; i < accounts.Length; i++){
                accounts[i] = (nicknames[i] + " " + passwords[i]);
            }
        }
        public void FindAccount()
        {
            foreach (var checkNickname in nicknames){
                if (LoginNickname == checkNickname){
                    foreach (var checkPassword in passwords){
                        if (LoginPassword == checkPassword){  
                            JoinTextLine();
                            string EnteredData = (LoginNickname + " " + LoginPassword);
                            foreach (var checkData in accounts){
                                if (EnteredData == checkData){
                                    AccountExists = true;
                                }
                            }break;
                        }else{
                            AccountExists = false;
                        }
                    }break;
                }else {AccountExists= false;}
            }
        }
        public void Register()
        {
            string NewAccScore = EmptyScore.ToString();
            newPassword = HashPasswords(newPassword);
            string[] linkedAccount = new string[] {newNickname,newPassword, NewAccScore};
            string[]NP = new string[] {String.Join(seperator, linkedAccount)};
            File.AppendAllLines(path, NP);
            LoadData();
            SplitTextLine();
        }
        public static string HashPasswords(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA1 hashAlgorithm = SHA1.Create();
            byte[] hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        public void DeleteAccount()
        {
            for (int i = 0; i < accounts.Length; i++){
                accounts[i] = (accounts[i] + " " + highscores[i]);
            }
            for (int y = 0; y < accounts.Length; y++){
                foreach (var JoinedAccData in accounts){
                    string NP = (LoginNickname + " " + LoginPassword);
                    DeletingAccount = (NP + " " + highscores[y]);
                    if (DeletingAccount == JoinedAccData){
                        accounts = accounts.Where(e => e != DeletingAccount).ToArray();
                        File.WriteAllLines(path, accounts);
                    }
                }
            }
        }
        public static void HelpLoad() 
        {
            string HelpPath = GetPath("data", "rules.html");
            ProcessStartInfo info = new ProcessStartInfo();//z netu
            info.FileName = HelpPath;
            info.UseShellExecute = true;
            Process.Start(info);
        }
    }
}
