using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_Quiz
{
    public partial class ScoreBoard : UserControl
    {
        AccountsManager myAccountmanager = new AccountsManager();
        

        public ScoreBoard()
        {
            InitializeComponent();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nick = myAccountmanager.nicknames;
            List<string> loadNicks = new List<string>(nick);
            foreach(string stringnick in nick) 
            {
                loadNicks.Add(stringnick);
            }
            dataGridView1.DataSource = new List<string>(loadNicks);
        }
    }
}
