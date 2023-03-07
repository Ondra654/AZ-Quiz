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
using static System.Formats.Asn1.AsnWriter;

namespace AZ_Quiz
{
    public partial class Mplayer : UserControl
    {
        GameManager myGameManager = new GameManager();
        AccountsManager myAccountManager = new AccountsManager();

        private bool ButtonClicked = false;
        public Mplayer()
        {
            InitializeComponent();
        }
        private void Mplayer_Load(object sender, EventArgs e){
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void HexagonButton_Click(object sender, EventArgs e)
        {
            myGameManager.NextQuestion();
            myGameManager.GetQuestion();
            myGameManager.GetAnswer();
            Question.Text = myGameManager.Question;
            PlayersAnswer.Text = myGameManager.Answer.Substring(0, 1);
            PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//z netu

            HexagonButton clickedButton = (HexagonButton)sender;
            RightAnswer.Text = clickedButton.Text;

            foreach (HexagonButton b in this.Controls.OfType<HexagonButton>())
            {
                b.BackColor = Color.Blue;
            }
        }
        private void PlayersAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (PlayersAnswer.Text == "")
                {
                    RightAnswer.Text = "You need to generete new question first!";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            player1.Text = myAccountManager.Account1;
            player2.Text = myAccountManager.Account2;
            int Xcoordinate = 600;
            int Ycoordinate = 330;
            int buttonName = 1;
            //button size vždy 40,46, mezera mezi buttony 6; první button má lokaci 600,330
            for (int i = 1; i <= 7; i++)
            {
                if (i % 2 == 1) //liché řádky
                {
                    HexagonButton b = new HexagonButton();
                    b.Location = new Point(Xcoordinate, Ycoordinate + (int)79.4 * (i / 2)); //prostřední sloupec buttonů
                    b.Text = buttonName.ToString(); //nastav si sám
                    buttonName++;
                    this.Controls.Add(b);

                    int buttonNumber = i / 2; //celočíselné dělení, kolik buttonů vykreslit na každou stranu od toho prostřdního
                    for (int j = 0; j < buttonNumber; j++)
                    {
                        HexagonButton b1 = new HexagonButton();
                        b1.Location = new Point(Xcoordinate + 46 * (j + 1), Ycoordinate + (int)79.4 * (i / 2));
                        b1.Text = buttonName.ToString(); //nastav si sám
                        buttonName++;
                        this.Controls.Add(b1);
                        HexagonButton b2 = new HexagonButton();
                        b2.Location = new Point(Xcoordinate - 46 * (j + 1), Ycoordinate + (int)79.4 * (i / 2));
                        b2.Text = buttonName.ToString(); //nastav si
                        buttonName++;
                        this.Controls.Add(b2);
                    }
                }
                else //sudé řádky
                {
                    HexagonButton bRight = new HexagonButton();
                    bRight.Location = new Point(Xcoordinate + 23, Ycoordinate + (int)37.5 + (int)(79.4 * (i / 3)));
                    bRight.Text = buttonName.ToString();
                    buttonName++;
                    this.Controls.Add(bRight);
                    HexagonButton bLeft = new HexagonButton();
                    bLeft.Location = new Point(Xcoordinate - 23, Ycoordinate + (int)37.5 + (int)(79.4 * (i / 3)));
                    bLeft.Text = buttonName.ToString();
                    buttonName++;
                    this.Controls.Add(bLeft);
                    if (i == 4)
                    {
                        HexagonButton br1 = new HexagonButton();
                        br1.Location = new Point(Xcoordinate + 23 + 46, Ycoordinate + (int)116.9);
                        br1.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br1);
                        HexagonButton bl1 = new HexagonButton();
                        bl1.Location = new Point(Xcoordinate - 23 - 46, Ycoordinate + (int)116.9);
                        bl1.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl1);
                    }
                    if (i == 6)
                    {
                        HexagonButton br1 = new HexagonButton();
                        br1.Location = new Point(Xcoordinate + 23 + 46, Ycoordinate + (int)196.3);
                        br1.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br1);
                        HexagonButton br2 = new HexagonButton();
                        br2.Location = new Point(Xcoordinate + 23 + 2 * 46, Ycoordinate + (int)196.3);
                        br2.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(br2);
                        HexagonButton bl1 = new HexagonButton();
                        bl1.Location = new Point(Xcoordinate - 23 - 46, Ycoordinate + (int)196.3);
                        bl1.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl1);
                        HexagonButton bl2 = new HexagonButton();
                        bl2.Location = new Point(Xcoordinate - 23 - 2 * 46, Ycoordinate + (int)196.3);
                        bl2.Text = buttonName.ToString();
                        buttonName++;
                        this.Controls.Add(bl2);
                    }
                }
                foreach (HexagonButton b in this.Controls.OfType<HexagonButton>())
                {
                    b.Size = new Size(40, 46); //50,58?
                    b.Show();
                    b.BackColor = Color.Purple; //...
                    b.Click += HexagonButton_Click;
                }
            }
        }
    }
}
