namespace AZ_Quiz
{
    public partial class GameMenu : Form
    {
        AccountsManager myAccountsManager = new AccountsManager();
        public GameMenu()
        {
            InitializeComponent();
            myMessageBox1.Hide();
            singlePlayer1.Hide();
            azQuizGame.Hide();
            login1.Hide();
            scoreBoard1.Hide();

            azQuizGame.SetAccountsManager(myAccountsManager);
            login1.SetAccountsManager(myAccountsManager);
            scoreBoard1.SetAccountsManager(myAccountsManager);
        }
        private void PVP_Click(object sender, EventArgs e)///starts Player vs. Player mode = AZ Quiz
        {
            tableMenuPanel.SendToBack();
            login1.Show();
            login1.BringToFront();
            int Xcoordinate = (azQuizGame.Width - login1.Width) / 2;
            int Ycoordinate = (azQuizGame.Height - login1.Height) / 2;
            login1.Location = new System.Drawing.Point(Xcoordinate, Ycoordinate);///sets login window in the middle of AZ Quiz user control
            azQuizGame.Location = new System.Drawing.Point(0, 0);
            azQuizGame.Show();
        }
        private void Solo_Click(object sender, EventArgs e)///starts questions training
        {
            tableMenuPanel.SendToBack();
            singlePlayer1.Show();
            singlePlayer1.Location = new System.Drawing.Point(0, 0);
        }
        private void AC_Click(object sender, EventArgs e)///open scoreboard and delete account option
        {
            tableMenuPanel.SendToBack();
            scoreBoard1.Show();
            scoreBoard1.Location = new System.Drawing.Point(0, 0);
        }
        private void Help_Click(object sender, EventArgs e)///open game rules inside web-explorer
        {
            AccountsManager.HelpLoad();
        }
        private void END_Click(object sender, EventArgs e)///with this you can leave the game
        {
            Close();
        }
    }
}
