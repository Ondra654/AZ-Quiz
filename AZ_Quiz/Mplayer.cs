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
        public void CreatHexagon()
        {

        }
        private void Mplayer_Load(object sender, EventArgs e){
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int buttonName = 1;
            //button size vždy 40,46, mezera mezi buttony 6; první button má lokaci 250,146
            for (int i = 1; i <= 7; i++)
            {
                if (i % 2 == 1) //liché řádky
                {
                    HexagonButton b = new HexagonButton();
                    b.Location = new Point(250, 146 + (int)79.4 * (i / 2)); //prostřední sloupec buttonů
                    b.Name = "button" + buttonName.ToString(); //nastav si sám
                    buttonName++;
                    this.Controls.Add(b);

                    int buttonNumber = i / 2; //celočíselné dělení, kolik buttonů vykreslit na každou stranu od toho prostřdního
                    for (int j = 0; j < buttonNumber; j++)
                    {
                        HexagonButton b1 = new HexagonButton();
                        b1.Location = new Point(250 + 46 * (j + 1), 146 + (int)79.4 * (i / 2));
                        b1.Name = "button" + buttonName.ToString(); //nastav si sám
                        buttonName++;
                        this.Controls.Add(b1);
                        HexagonButton b2 = new HexagonButton();
                        b2.Location = new Point(250 - 46 * (j + 1), 146 + (int)79.4 * (i / 2));
                        b2.Name = "button" + buttonName.ToString(); //nastav si
                        buttonName++;
                        this.Controls.Add(b2);
                    }
                }
                else //sudé řádky
                {
                    HexagonButton bRight = new HexagonButton();
                    bRight.Location = new Point(250 + 23, 146 + (int)37.5 + (int)(79.4 * (i / 3)));
                    bRight.Name = "button" + buttonName.ToString();
                    buttonName++;
                    this.Controls.Add(bRight);
                    HexagonButton bLeft = new HexagonButton();
                    bLeft.Location = new Point(250 - 23, 146 + (int)37.5 + (int)(79.4 * (i / 3)));
                    bLeft.Name = "button" + buttonName.ToString();
                    buttonName++;
                    this.Controls.Add(bLeft);
                    if (i == 4)
                    {
                        HexagonButton br1 = new HexagonButton();
                        br1.Location = new Point(250 + 23 + 46, 146 + (int)116.9);
                        br1.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br1);
                        HexagonButton bl1 = new HexagonButton();
                        bl1.Location = new Point(250 - 23 - 46, 146 + (int)116.9);
                        bl1.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl1);
                    }
                    if (i == 6)
                    {
                        HexagonButton br1 = new HexagonButton();
                        br1.Location = new Point(250 + 23 + 46, 146 + (int)196.3);
                        br1.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br1);
                        HexagonButton br2 = new HexagonButton();
                        br2.Location = new Point(250 + 23 + 2 * 46, 146 + (int)196.3);
                        br2.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br2);
                        HexagonButton bl1 = new HexagonButton();
                        bl1.Location = new Point(250 - 23 - 46, 146 + (int)196.3);
                        bl1.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl1);
                        HexagonButton bl2 = new HexagonButton();
                        bl2.Location = new Point(250 - 23 - 2 * 46, 146 + (int)196.3);
                        bl2.Name = "button" + buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl2);
                    }
                }
                foreach (HexagonButton b in this.Controls.OfType<HexagonButton>())
                {
                    b.Size = new Size(40, 46);
                    b.Show();
                    b.BackColor = Color.Yellow; //...
                }
            }
        }
    }
}
