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
        public Splayer()
        {
            InitializeComponent();
        }
  
        private void Splayer_Load(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            myGameManager.NextQuestion();
            myGameManager.GetQuestion();
            myGameManager.GetAnswer();

            string FirstLetter = myGameManager.Answer.Substring(0, 1);
            SinQuestion.Text = myGameManager.Question;
            SinAnswer.Text = FirstLetter;
            RevealAnswer.Text = "";
            SinAnswer.BackColor = Color.White;
        }
        private void SinAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (myGameManager.Answer == "")
                {
                    RevealAnswer.Text = "Generate new Question first!";
                }else
                    RevealAnswer.Text= myGameManager.Answer;
                if (SinAnswer.Text == myGameManager.Answer)
                {
                    SinAnswer.BackColor= Color.Green;
                }else
                    SinAnswer.BackColor= Color.Red;
            }
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinQuestion.Text = "Press Question button to start";
            SinAnswer.BackColor = Color.White;
            RevealAnswer.Text = "";
        }
    }
}
