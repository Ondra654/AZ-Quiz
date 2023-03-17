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
    public partial class Splayer : UserControl
    {
        GameManager myGameManager = new GameManager();
        public Splayer(){
            InitializeComponent();
        }
        private void Splayer_Load(object sender, EventArgs e){
        }
        public void DisplayQuestion()
        {
            myGameManager.NextQuestion();
            myGameManager.GetQuestion();
            myGameManager.GetAnswer();

            SinQuestion.Text = myGameManager.question;
            string FirstLetter = myGameManager.answer.Substring(0, 1);
            SinAnswer.Text = FirstLetter;
            SinAnswer.SelectionStart = SinAnswer.Text.Length;//z netu
            SinAnswer.BackColor = Color.White;
        }
        public void CountScore() 
        {
            if (SinAnswer.Text == myGameManager.answer){
                myGameManager.singlePlayerScore = myGameManager.singlePlayerScore + 10;
                RevealAnswer.BackColor = Color.Green;
            }else {
                myGameManager.singlePlayerScore = myGameManager.singlePlayerScore - 3;
                RevealAnswer.BackColor = Color.Red;
            }
                score.Text = "score: " + myGameManager.singlePlayerScore.ToString();
                RevealAnswer.Text = "Right answer was: " + myGameManager.answer;
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            DisplayQuestion();
        }
        private void SinAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (SinAnswer.Text == "")
                {
                    RevealAnswer.Text = "You need to generete new question first!";
                }else
                CountScore();
                DisplayQuestion();
            }
        }
        public void ResetAll()
        {
            SinQuestion.Text = "Press Question button to start";
            SinAnswer.BackColor = Color.BurlyWood;
            SinAnswer.Text = "";
            RevealAnswer.Text = "";
            RevealAnswer.BackColor = Color.CadetBlue;
            myGameManager.singlePlayerScore = 0;
            score.Text = "score: " + myGameManager.singlePlayerScore;
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetAll();
        }
    }
}
