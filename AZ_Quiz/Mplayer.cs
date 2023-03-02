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
    public partial class Mplayer : UserControl
    {
        GameManager mygameManager;

        public Mplayer()
        {
            InitializeComponent();
            this.mygameManager = new GameManager();
        }
        internal void SetGlobalGameManager(GameManager myGameManager)
        {
            this.mygameManager = myGameManager;
        }

        private void Mplayer_Load(object sender, EventArgs e){
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
