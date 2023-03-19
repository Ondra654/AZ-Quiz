using AZ_Quiz.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using static AZ_Quiz.HexagonButton;
using static System.Formats.Asn1.AsnWriter;

namespace AZ_Quiz
{
    public partial class Mplayer : UserControl
    {
        GameManager myGameManager = new GameManager();
        AccountsManager myAccountsManager;
        HexagonButton clickedButton = new HexagonButton();
        Button yesnoButton = new Button();
        List<HexagonButton> buttonList = new List<HexagonButton>();

        public bool BlueTurn = false;
        public bool SameQuestionAnswered = false;

        Color customOrange = Color.FromArgb(255, 142, 68);
        Color customBlue = Color.FromArgb(0, 162, 232);

        public string bluePlayer = "";
        public string orangePlayer = "";
        public int blueScore = 0;
        public int orangeScore = 0;

        public string firstPlayer = "";
        public string secondPlayer = "";
        public string gameResult;
        string caption = "Game Result";
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
            progressBarQuestion.Hide();
            DisplayInfo.Text = "Press StartButton to start game.";
            GenerateHexagons();
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            foreach (HexagonButton hexagon in buttonList)
            {
                hexagon.Show();
                hexagon.BringToFront();
            }
            StartGameButton.Hide();
            player1.Text = myAccountsManager.account1;
            player2.Text = myAccountsManager.account2;
            bluePlayer = myAccountsManager.account1;
            orangePlayer = myAccountsManager.account2;
            scoreBlue.Text = blueScore.ToString();
            scoreOrange.Text = orangeScore.ToString();
            StartingColor();
            FindPlayers();
            timerGame.Start();
            DisplayInfo.Text = "Great, " + firstPlayer + ", it´s your turn!";
        }
        private void HexagonButton_Click(object sender, EventArgs e)
        {
            clickedButton = (HexagonButton)sender;
            foreach (HexagonButton hexagon in buttonList)
            {
                hexagon.Click -= HexagonButton_Click;
            }
            timerQuestion.Start();
            progressBarQuestion.Show();
            if (clickedButton.BackColor == Color.Black)
            {
                myGameManager.GetBlackQuestion();
                myGameManager.GetBlackAnswer();
                Question.Text = myGameManager.blackQuestion;
                YesButton.Show();
                NoButton.Show();
            }else{
                myGameManager.GetQuestion();
                myGameManager.GetAnswer();
                Question.Text = myGameManager.question;
                PlayersAnswer.Text = myGameManager.answer.Substring(0, 1);
                PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//z netu
            }
        }
        private void PlayersAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (PlayersAnswer.Text == "")
                {
                    Question.Text = "Select Hexagon first!";
                }
                else if (PlayersAnswer.Text == myGameManager.answer)
                {
                    AnswerWasRight();
                }
                else
                {
                    AnswerWasFalse();
                }
                scoreBlue.Text = blueScore.ToString();
                scoreOrange.Text = orangeScore.ToString();
            }
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
            yesnoButton = YesButton;
            PlayersAnswer.KeyPress += PlayersAnswer_Entered;
            if (clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }
            else
            {
                timerQuestion.Start();
                progressBarQuestion.Show();
                PlayersAnswer.Text = myGameManager.answer.Substring(0, 1);
                PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//z netu
                SameQuestionAnswered = true;
                BlueTurn = !BlueTurn;// z netu
                DisplayInfo.Text = "Now you can answer: ";
            }
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
            yesnoButton = NoButton;
            PlayersAnswer.KeyPress += PlayersAnswer_Entered;
            if (clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }
            else
            {
                Question.Text = myGameManager.answer;
                DisplayInfo.Text = "Ok, " + secondPlayer + ", it´s your turn";
                this.clickedButton.BackColor = Color.Black;
                this.clickedButton.TextColor = Color.White;
                PlayersAnswer.Text = "";
                BlueTurn = !BlueTurn;
                SameQuestionAnswered = false;
                EnableHexagonClick();
            }
        }
        private void YesNoAnswer()
        {
            FindPlayers();
            if (myGameManager.blackAnswer == "ano" && yesnoButton == YesButton)
            {
                AnswerWasRight();
            }
            else if (myGameManager.blackAnswer == "ne" && yesnoButton == NoButton)
            {
                AnswerWasRight();
            }
            else
            {
                if (BlueTurn == false)
                {
                    orangeScore = orangeScore - 3;
                }
                else if (BlueTurn == true)
                {
                    blueScore = blueScore - 3;
                }
                scoreBlue.Text = blueScore.ToString();
                scoreOrange.Text = orangeScore.ToString();
                Question.Text = "This answer wasn´t right. Right answer was: " + myGameManager.blackAnswer;
                DisplayInfo.Text = secondPlayer + ", it´s your turn now.";
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                BlueTurn = !BlueTurn;
                EnableHexagonClick();
            }
        }
        private void AnswerWasRight()
        {
            FindPlayers();
            if (BlueTurn == false)
            {
                orangeScore = orangeScore + 10;
                this.clickedButton.BackColor = customOrange;
                BlueTurn = true;
            }
            else if (BlueTurn == true)
            {
                blueScore = blueScore + 10;
                this.clickedButton.BackColor = customBlue;
                BlueTurn = false;
            }
            scoreBlue.Text = blueScore.ToString();
            scoreOrange.Text = orangeScore.ToString();
            this.clickedButton.Text = "";
            timerQuestion.Stop();
            progressBarQuestion.Value = 0;
            progressBarQuestion.Hide();
            Question.Text = "This answer was right, " + firstPlayer + ".";
            DisplayInfo.Text = secondPlayer + ", it´s your turn now.";
            PlayersAnswer.Text = "";
            SameQuestionAnswered = false;
            EnableHexagonClick();

            if (CheckIfGameEnded())
            {// konec hry
                timerGame.Stop();
                myAccountsManager.acc1score = blueScore;
                myAccountsManager.acc2score = orangeScore;
                myAccountsManager.RewriteScore();
                if (clickedButton.BackColor == customOrange)
                {
                    gameResult = orangePlayer + ", congratulations! You won!";
                }
                else
                    gameResult = bluePlayer + ", congratulations! You won!";
                var result = MessageBox.Show(gameResult, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);        
                if (result == DialogResult.OK)
                {
                    ResetAll();
                    this.Hide();
                }
            }
        }
        private void AnswerWasFalse()
        {
            FindPlayers();
            if (BlueTurn == false)
            {
                orangeScore = orangeScore - 3;
            }
            else if (BlueTurn == true)
            {
                blueScore = blueScore - 3;
            }
            scoreBlue.Text = blueScore.ToString();
            scoreOrange.Text = orangeScore.ToString();

            if (SameQuestionAnswered == false)
            {
                if (progressBarQuestion.Value == progressBarQuestion.Maximum)
                {
                    PlayersAnswer.KeyPress -= PlayersAnswer_Entered;
                    DisplayInfo.Text = "Time for answering expired! " + secondPlayer + ", would you like to answer?";
                }
                else
                {
                    DisplayInfo.Text = "This answer wasn´t right, " + secondPlayer + ", would you like to answer?";
                }
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                YesButton.Show();
                NoButton.Show();
            }
            else
            {
                timerQuestion.Stop();
                if (progressBarQuestion.Value == progressBarQuestion.Maximum)
                {
                    Question.Text = "Time for answering expired!";
                }
                else
                {
                    Question.Text = "This answer also wasn´t right. Right answer was: " + myGameManager.answer;
                }
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                this.clickedButton.BackColor = Color.Black;
                this.clickedButton.TextColor = Color.White;
                DisplayInfo.Text = secondPlayer + ", it´s your turn";
                PlayersAnswer.Text = "";
                BlueTurn = !BlueTurn;
                SameQuestionAnswered = false;
                EnableHexagonClick();
            }
        }
        private bool CheckIfGameEnded()
        {
            Color clickedButtonColor = clickedButton.BackColor;

            HexagonPosition connectedSides = new HexagonPosition();
            List<HexagonButton> checkedButtons = new List<HexagonButton>();

            GetConnectedSides(clickedButton, clickedButtonColor, connectedSides, checkedButtons);

            return connectedSides.ConnectsAllSides();
        }
        private void GetConnectedSides(HexagonButton button, Color clickedButtonColor, HexagonPosition connectedSides, List<HexagonButton> checkedButtons)
        {
            connectedSides.leftSide |= button.HexPosition.leftSide;
            connectedSides.rightSide |= button.HexPosition.rightSide;
            connectedSides.bottomSide |= button.HexPosition.bottomSide;

            checkedButtons.Add(button);

            foreach (HexagonButton neighour in button.Neighbours)
            {
                if (connectedSides.ConnectsAllSides())
                    break;

                if (neighour.BackColor != clickedButtonColor)
                    continue;

                if (checkedButtons.Contains(neighour))
                    continue;

                GetConnectedSides(neighour, clickedButtonColor, connectedSides, checkedButtons);
            }
        }
        private void StartingColor()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 2);
            if (result == 0)
            {
                BlueTurn = false;//orange
            }
            else if (result == 1)
            {
                BlueTurn = true;//blue
            }
        }
        private void FindPlayers()
        {
            if (BlueTurn == false)
            {
                secondPlayer = bluePlayer;
                firstPlayer = orangePlayer;
            }
            else if (BlueTurn == true)
            {
                secondPlayer = orangePlayer;
                firstPlayer = bluePlayer;
            }
        }
        private void EnableHexagonClick()
        {
            foreach (HexagonButton hexagon in buttonList){
                if(hexagon.BackColor == customBlue || hexagon.BackColor == customOrange){
                    continue;
                }else
                    hexagon.Click += HexagonButton_Click;
            }
        }
        private void TimeLimit(object sender, EventArgs e)
        {
            progressBarQuestion.Increment(1);
            if (progressBarQuestion.Value == progressBarQuestion.Maximum)
            {
                if (progressBarQuestion.Value == progressBarQuestion.Maximum && clickedButton.BackColor == Color.Black)
                {
                    FindPlayers();
                    if (BlueTurn == false)
                    {
                        orangeScore = orangeScore - 3;
                    }
                    else if (BlueTurn == true)
                    {
                        blueScore = blueScore - 3;
                    }
                    timerQuestion.Stop();
                    Question.Text = "Time for answering expired!";
                    YesButton.Hide();
                    NoButton.Hide();
                    scoreBlue.Text = blueScore.ToString();
                    scoreOrange.Text = orangeScore.ToString();
                    BlueTurn = !BlueTurn;
                    DisplayInfo.Text = secondPlayer + ", it´s your turn now.";
                }else{
                    AnswerWasFalse();
                }
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
            }
        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBarGame.Increment(1);
            if (progressBarGame.Value == progressBarGame.Maximum)
            {
                timerGame.Stop();
                DisplayInfo.Text = "Game time expired.";
                if (blueScore > orangeScore)
                {
                    gameResult = bluePlayer + ", congratulations! You won!";
                }
                else
                    gameResult = orangePlayer + ", congratulations! You won!";

                var result = MessageBox.Show(gameResult, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ResetAll();
                    this.Hide();
                }
            }
        }
        private void GenerateHexagons()
        {
            int x = (Size.Width / 2) - 26;
            int y = (Size.Height / 2) - 60;
            double width = Size.Width / 24.08;
            int buttonWidth = Convert.ToInt32(width);
            double height = Size.Height / 11.58;
            int buttonHeight = Convert.ToInt32(height);
            int rows = 7;
            double yGap = 0.15;

            List<List<HexagonButton>> buttonListByRows = new List<List<HexagonButton>>();

            int buttonNumber = 1;
            for (int row = 0; row < rows; row++)
            {
                List<HexagonButton> currentRowButtons = new List<HexagonButton>();
                buttonListByRows.Add(currentRowButtons);

                int rowX = x - row * (buttonWidth / 2);
                int rowY = y + row * buttonHeight - (int)(row * (buttonHeight * yGap));
                for (int i = 0; i <= row; i++)
                {
                    HexagonButton hexagon = new HexagonButton();
                    hexagon.AutoSize = true;
                    hexagon.Size = new Size(buttonWidth, buttonHeight);
                    hexagon.Location = new Point(rowX + i * buttonWidth, rowY);
                    hexagon.Text = buttonNumber.ToString();
                    hexagon.Name = hexagon.Text;
                    this.Controls.Add(hexagon);
                    buttonNumber++;

                    if (i == 0)
                        hexagon.HexPosition.leftSide = true;

                    if (i == row)
                        hexagon.HexPosition.rightSide = true;

                    if (row == rows - 1)
                        hexagon.HexPosition.bottomSide = true;

                    currentRowButtons.Add(hexagon);
                    buttonList.Add(hexagon);
                }
            }
            // Generate neighbours
            for (int row = 0; row < buttonListByRows.Count; row++)
            {
                List<HexagonButton> rowButtons = buttonListByRows[row];

                for (int column = 0; column < rowButtons.Count; column++)
                {
                    HexagonButton button = rowButtons[column];

                    if (column - 1 >= 0)
                        button.Neighbours.Add(rowButtons[column - 1]);

                    if (column + 1 < rowButtons.Count)
                        button.Neighbours.Add(rowButtons[column + 1]);

                    if (row - 1 >= 0)
                    {
                        if (column - 1 >= 0)
                            button.Neighbours.Add(buttonListByRows[row - 1][column - 1]);

                        if (column < buttonListByRows[row - 1].Count)
                            button.Neighbours.Add(buttonListByRows[row - 1][column]);
                    }

                    if (row + 1 < buttonListByRows.Count)
                    {
                        button.Neighbours.Add(buttonListByRows[row + 1][column]);

                        if (column + 1 < buttonListByRows[row + 1].Count)
                            button.Neighbours.Add(buttonListByRows[row + 1][column + 1]);
                    }
                }
            }
            foreach (HexagonButton hexagon in buttonList)
            {
                hexagon.BackColor = Color.FromArgb(234, 234, 234);
                hexagon.ForeColor = Color.Black;
                hexagon.Click += HexagonButton_Click;
            }
        }
        private void ResetAll()
        {
            foreach (HexagonButton hexagon in buttonList)
            {
                hexagon.Hide();
                hexagon.BackColor = Color.FromArgb(234, 234, 234);
                hexagon.ForeColor = Color.Black;
                hexagon.Text = hexagon.Name;
                hexagon.HexPosition.leftSide = default;
                hexagon.HexPosition.rightSide = default;
                hexagon.HexPosition.bottomSide = default;
            }
            myGameManager.ResetQuestionLists();
            YesButton.Hide();
            NoButton.Hide();
            timerGame.Stop();
            timerQuestion.Stop();
            progressBarGame.Value = default;
            progressBarQuestion.Value = default;
            progressBarQuestion.Hide();
            Question.Text = default;
            PlayersAnswer.Text = default;
            DisplayInfo.Text = "Press StartButton to start game.";
            StartGameButton.Show();
            firstPlayer = "";
            secondPlayer = "";
            bluePlayer = "";
            orangePlayer = "";
            blueScore = 0;
            orangeScore = 0;
            myAccountsManager.account1 = "";
            myAccountsManager.account2 = "";
            player1.Text = "";
            player2.Text = "";
            scoreBlue.Text = "0";
            scoreOrange.Text = "0";
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            ResetAll();
            this.Hide();
        }
    }
}
