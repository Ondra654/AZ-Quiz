using AZ_Quiz.Properties;
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
using System.Xml.XPath;
using static System.Formats.Asn1.AsnWriter;

namespace AZ_Quiz
{
    public partial class Mplayer : UserControl
    {
        GameManager myGameManager = new GameManager();
        AccountsManager myAccountsManager;

        public bool BlueTurn = false;
        public bool SameQuestionAnswered = false;

        public string BluePlayer = "";
        public string OrangePlayer = "";
        public int BlueScore = 0;
        public int OrangeScore = 0;

        public string secondPlayer = "";
        public string firstPlayer = "";
        public void SetAccountsManager(AccountsManager accountManager)
        {
            myAccountsManager = accountManager;
        }
        public Mplayer()
        {
            InitializeComponent();
        }
        private void Mplayer_Load(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            GenerateHexagons();
            player1.Text = myAccountsManager.Account1;
            player2.Text = myAccountsManager.Account2;
            BluePlayer = myAccountsManager.Account1;
            OrangePlayer = myAccountsManager.Account2;
            scoreBlue.Text = BlueScore.ToString();
            scoreOrange.Text = OrangeScore.ToString();
            StartingColor();
            StartGameButton.Hide();
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

        }
        private void PlayersAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (PlayersAnswer.Text == ""){
                    RightAnswer.Text = "Select Hexagon first!";
                }else if(PlayersAnswer.Text == myGameManager.Answer){
                    AnswerWasRight();
                }else{
                    AnswerWasFalse();
                }
                scoreBlue.Text = BlueScore.ToString();
                scoreOrange.Text = OrangeScore.ToString();
            }
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
            SameQuestionAnswered = true;
            BlueTurn = !BlueTurn;// z netu
            RightAnswer.Text = "Now you can answer";
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            ResetFuntion();
        }
        private void AnswerWasRight()
        {
            FindPlayersNames();
            if (BlueTurn == false){
                OrangeScore = OrangeScore + 10;
                BlueTurn = true;
            }else if (BlueTurn == true){
                BlueScore = BlueScore + 10;
                BlueTurn = false;
            }
            RightAnswer.Text = "This answer was right, " + firstPlayer;
            ResetFuntion();
        }
        private void AnswerWasFalse() 
        {
            FindPlayersNames();
            if (BlueTurn == false){
                OrangeScore = OrangeScore - 3;
            }else if (BlueTurn == true){
                BlueScore = BlueScore - 3;
            }
            if (SameQuestionAnswered == false){
                RightAnswer.Text = "This answer wasn´t right, " + secondPlayer + ", would you like to answer?";
                YesButton.Show();
                NoButton.Show();
            }else
                RightAnswer.Text = "This answer also wasn´t right. Right answer was: " + myGameManager.Answer;
        }
        private void StartingColor()
        {
            Random rnd = new Random();
            int result = rnd.Next(0,2);
            if(result == 0)
            {
                BlueTurn = false;//orange
            }else if(result == 1) {
                BlueTurn = true;//blue
            }
        }
        private void FindPlayersNames()
        {
            if (BlueTurn == false)
            {
                secondPlayer = BluePlayer;
                firstPlayer = OrangePlayer;
            }else if (BlueTurn == true)
            {
                secondPlayer = OrangePlayer;
                firstPlayer = BluePlayer;
            }
        }
        private void ResetFuntion()
        {
            YesButton.Hide();
            NoButton.Hide();
            Question.Text = "";
            PlayersAnswer.Text = "";
            BlueTurn= !BlueTurn;
        }
        private void GenerateHexagons()
        {
            int Xcoordinate = (Size.Width / 2) - 20;
            int Ycoordinate = (Size.Height / 2) ;
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
                    b.Size = new Size(52, 60);
                    b.Show();
                    b.BackColor = Color.FromArgb(234, 234, 234);
                    b.ForeColor = Color.Black;
                    b.Click += HexagonButton_Click;
                }
            }

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
