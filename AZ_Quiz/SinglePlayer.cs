namespace AZ_Quiz
{
    public partial class SinglePlayer : UserControl
    {
        MyMessageBox myMessagebox = new MyMessageBox();
        GameManager myGameManager = new GameManager();

        int singlePlayerScore = 0;

        public SinglePlayer(){
            InitializeComponent();
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            DisplayQuestion();
        }
        private void SinAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))//for KeyChar exception I inspired my self from: https://stackoverflow.com/questions/12318164/enter-key-press-in-c-sharp and adapted this part.
            {
                if (SinAnswer.Text == "")
                {
                    RevealAnswer.Text = "You need to generete new question first!";
                }else
                CountScore();
                DisplayQuestion();
            }
        }
        public void DisplayQuestion()
        {
            myGameManager.LoadData();
            myGameManager.GetQuestion();
            myMessagebox.SetmySinglePlayer(this);
            if(myGameManager.questionsListFull == true)
            {
                int x = (this.Width - myMessagebox.Width) / 2;
                int y = (this.Height - myMessagebox.Height) / 2;
                myMessagebox.message = "You went through all questions, program needs to reset your progress";
                this.Parent.Controls.Add(myMessagebox);//made with AI bot help - Chat GPT. I let AI explain me how to use "this.Parent." and with his help I implement it.
                myMessagebox.Location = new System.Drawing.Point(x, y);
                myMessagebox.BringToFront();
                button1.Enabled = false;
                SinAnswer.Enabled = false;
            }else{
                myGameManager.GetAnswer();

                SinQuestion.Text = myGameManager.question;
                string FirstLetter = myGameManager.answer.Substring(0, 1);//Adopted from: https://codelikeadev.com/blog/get-first-character-of-string-c-sharp
                SinAnswer.Text = FirstLetter;
                SinAnswer.SelectionStart = SinAnswer.Text.Length;//Adopted from: https://stackoverflow.com/questions/8206723/change-cursor-position-in-textbox-in-c-sharp-windows
            }
        }
        public void CountScore() 
        {
            if (SinAnswer.Text == myGameManager.answer){
                singlePlayerScore = singlePlayerScore + 10;
                RevealAnswer.BackColor = Color.Green;
            }else {
                singlePlayerScore = singlePlayerScore - 3;
                RevealAnswer.BackColor = Color.Red;
            }
                score.Text = "score: " + singlePlayerScore.ToString();
                RevealAnswer.Text = "Right answer was: " + myGameManager.answer;
        }
        public void ResetAll()
        {
            button1.Enabled = true;
            SinAnswer.Enabled = true;
            SinQuestion.Text = "Press Question button to start";
            SinAnswer.Text = "";
            RevealAnswer.Text = "";
            RevealAnswer.BackColor = Color.CadetBlue;
            singlePlayerScore = 0;
            score.Text = "score: " + singlePlayerScore;
            myGameManager.questionsListFull = false;
            myGameManager.ResetQuestionLists();
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myMessagebox.SendToBack();
            ResetAll();
        }
    }
}
