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
            mplayer1.Hide();
            mplayer1.SetGlobalGameManager(myGameManager);
            splayer1.Hide();
            login1.Hide();

            myGameManager.LoadData();
        }
        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 600);
        }

        private void PVP_Click(object sender, EventArgs e)
        {
            mplayer1.Show();
            login1.Show();
        }

        private void Solo_Click(object sender, EventArgs e)
        {
            splayer1.Show();
            splayer1.Location = new System.Drawing.Point(0,0);
        }

        private void AC_Click(object sender, EventArgs e)
        {
     
        }

        private void help_Click(object sender, EventArgs e)// z netu
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Users\Ondra\source\repos\AZ_Quiz\rules.html";//your file path
            info.UseShellExecute = true;
            Process.Start(info);
        }
        private void END_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
