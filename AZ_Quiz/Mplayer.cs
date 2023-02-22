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
        GameManager gameManager;

        public Mplayer()
        {
            InitializeComponent();
            this.gameManager = new GameManager();
        }

        internal void SetGlobalGameManager(GameManager myGameManager)
        {
            this.gameManager = myGameManager;
        }

        private void Mplayer_Load(object sender, EventArgs e)
        {
            BackColor= Color.Red;
        }
    }
}
