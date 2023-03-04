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
        Form form1 = new Form();
        GameManager myGameManager = new GameManager();
        public GameMenu()
        {
            InitializeComponent();
            scoreBoard1.Hide();
            mplayer1.Hide();
            splayer1.Hide();
            login1.Hide();
        }
        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1250, 750);
        }
        private void PVP_Click(object sender, EventArgs e)
        {
            tableMenuPanel.SendToBack();
            mplayer1.Show();
            mplayer1.Location = new System.Drawing.Point(0,0);
            login1.Show();
            login1.BringToFront();
            login1.Location = new System.Drawing.Point(45, 70);
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
        private void help_Click(object sender, EventArgs e)// z netu
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Users\Ondra\source\repos\AZ_Quiz\rules.html";
            info.UseShellExecute = true;
            Process.Start(info);
        }
        private void END_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
