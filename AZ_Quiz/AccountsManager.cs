using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;

namespace AZ_Quiz
{
    public class AccountsManager
    {
        MyMessageBox myMessageBox = new MyMessageBox();
        AZQuizGame azquiz;

        string accPath = GetPath("data", "Accounts.txt");
        
        public string[] accounts = Array.Empty<string>();
        public string[] nicknames = Array.Empty<string>();
        public string[] passwords = Array.Empty<string>();
        public string[] highscores= Array.Empty<string>();

        public bool AccountExists = false;

        public int emptyScore = 0;
        public string seperator = "%?!%";
        public string newNickname = "";
        public string newPassword = "";
        public int hashedPassword;

        public string errormsg = "";

        public string loginNickname = "";
        public string loginPassword = "";
        public string deletingAccount = "";

        public string account1 = "";
        public string account2 = "";
        public int acc1score = 0;
        public int acc2score = 0;
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
            try{
                accounts = File.ReadAllLines(accPath);
            }catch (FileNotFoundException){
                myMessageBox.message = "File 'Accounts' is not located in 'data' folder, redownload game or put this file back";
                myMessageBox.BringToFront();
                myMessageBox.errorMsg = true;
                //this.azquiz.Parent.Controls.Add(myMessageBox);
                throw new FileNotFoundException("File 'Accounts' is not located in 'data' folder, redownload game or put this file back");
            }
            nicknames= new string[accounts.Length];
            passwords= new string[accounts.Length];
            highscores= new string[accounts.Length];
        }
        internal void SaveData()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = nicknames[i] + seperator + passwords[i] + seperator + highscores[i];
            }
            File.WriteAllLines(accPath, accounts);
        }
        public void SplitTextLine()
        {
            for (int i = 0; i < accounts.Length; i++){
                string[] splitAccounts;
                splitAccounts = accounts[i].Split(seperator);
                nicknames[i] = splitAccounts[0];
                passwords[i] = splitAccounts[1];
                highscores[i] = splitAccounts[2];
            }
        }
        public void JoinTextLine()
        {
            for (int i = 0; i < accounts.Length; i++){
                accounts[i] = (nicknames[i] + seperator + passwords[i]);
            }
        }
        public void Register()
        {
            string NewAccScore = emptyScore.ToString();
            newPassword = HashPasswords(newPassword);
            string[] linkedAccount = new string[] {newNickname,newPassword, NewAccScore};
            string[]NP = new string[] {String.Join(seperator, linkedAccount)};
            File.AppendAllLines(accPath, NP);
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
        public void FindAccount()
        {            
            foreach (var checkNickname in nicknames){
                if (loginNickname == checkNickname && loginNickname != account1){
                    foreach (var checkPassword in passwords){
                        if (loginPassword == checkPassword){  
                            JoinTextLine();
                            string EnteredData = (loginNickname + seperator + loginPassword);
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
        public void DeleteAccount()
        {
            for (int i = 0; i < accounts.Length; i++){
                accounts[i] = (accounts[i] + seperator + highscores[i]);
            }
            for (int y = 0; y < accounts.Length; y++){
                foreach (var JoinedAccData in accounts){
                    string NP = (loginNickname + seperator + loginPassword);
                    deletingAccount = (NP + seperator + highscores[y]);
                    if (deletingAccount == JoinedAccData){
                        accounts = accounts.Where(e => e != deletingAccount).ToArray();
                        File.WriteAllLines(accPath, accounts);
                    }
                }
            }
        }
        public void RewriteScore()
        {
            for (int i = 0; i < accounts.Length; i++){
                var account = nicknames[i];
                int hs = Convert.ToInt32(highscores[i]);
                int gamesc;
                int newhs;

                if (account == account1){
                    gamesc = Convert.ToInt32(acc1score);
                    newhs = hs + gamesc;
                    highscores[i] = newhs.ToString();
                }else if(account == account2){
                    gamesc = Convert.ToInt32(acc2score);
                    newhs = hs + gamesc;
                    highscores[i] = newhs.ToString();
                }
            }
            SaveData();
        }
        public void ErrorMsgBox()
        {
            string title = "Error MessageBox";
            var result = MessageBox.Show(errormsg, title, MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
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
