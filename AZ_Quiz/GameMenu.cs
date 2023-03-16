using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AZ_Quiz
{
    public partial class GameMenu : Form
    {
        AccountsManager myAccountsManager = new AccountsManager();
        public GameMenu()
        {
            InitializeComponent();
            login1.Hide();
            scoreBoard1.Hide();
            mplayer1.Hide();
            splayer1.Hide();

            login1.SetAccountsManager(myAccountsManager);
            mplayer1.SetAccountsManager(myAccountsManager);
        }
        private void PVP_Click(object sender, EventArgs e)
        {
            tableMenuPanel.SendToBack();
            login1.Show();
            login1.BringToFront();
            int Xcoordinate = (mplayer1.Width - login1.Width) / 2;
            int Ycoordinate = (mplayer1.Height - login1.Height) / 2;
            login1.Location = new System.Drawing.Point(Xcoordinate, Ycoordinate);
            mplayer1.Location = new System.Drawing.Point(0,0);
            mplayer1.Show();
        }
        private void Solo_Click(object sender, EventArgs e)
        {
            tableMenuPanel.SendToBack();
            splayer1.Show();
            splayer1.Location = new System.Drawing.Point(0,0);
        }
        private void AC_Click(object sender, EventArgs e)
        {
            tableMenuPanel.SendToBack();
            scoreBoard1.Show();
            scoreBoard1.Location = new System.Drawing.Point(0, 0);
        }
        private void Help_Click(object sender, EventArgs e)
        {
            AccountsManager.HelpLoad();
        }
        private void END_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
