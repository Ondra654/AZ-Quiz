﻿using AZ_Quiz.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
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
        HexagonButton clickedButton = new HexagonButton();
        Button yesnoButton = new Button();

        public bool BlueTurn = false;
        public bool SameQuestionAnswered = false;

        public string bluePlayer = "";
        public string orangePlayer = "";
        public int blueScore = 0;
        public int orangeScore = 0;

        public string secondPlayer = "";
        public string firstPlayer = "";
        public string gameResult;
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
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Hide();
            GenerateHexagons();
            player1.Text = myAccountsManager.Account1;
            player2.Text = myAccountsManager.Account2;
            bluePlayer = myAccountsManager.Account1;
            orangePlayer = myAccountsManager.Account2;
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

            timerQuestion.Start();
            progressBarQuestion.Show();
            if(clickedButton.BackColor == Color.Black)
            {
                myGameManager.GetBlackQuestion();
                myGameManager.GetBlackAnswer();
                Question.Text = myGameManager.BlackQuestion;
                YesButton.Show();
                NoButton.Show();
            }else{
                myGameManager.NextQuestion();
                myGameManager.GetQuestion();
                myGameManager.GetAnswer();
                Question.Text = myGameManager.Question;
                PlayersAnswer.Text = myGameManager.Answer.Substring(0, 1);
                PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//z netu
            }
        }
        private void PlayersAnswer_Entered(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//z netu
            {
                if (PlayersAnswer.Text == "") {
                    Question.Text = "Select Hexagon first!";
                } else if (PlayersAnswer.Text == myGameManager.Answer) {
                    AnswerWasRight();
                } else{
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
            if(clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }else{
                timerQuestion.Start();
                progressBarQuestion.Show();
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
            if (clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }else{
                DisplayInfo.Text = "Ok, " + secondPlayer + ", it´s your turn";
                this.clickedButton.BackColor = Color.Black;
                this.clickedButton.TextColor = Color.White;
                Question.Text = "";
                PlayersAnswer.Text = "";
                BlueTurn = !BlueTurn;
                SameQuestionAnswered = false;
            }
        }
        private void YesNoAnswer()
        {
            FindPlayers();
            if (myGameManager.BlackAnswer == "ano" && yesnoButton == YesButton){
                AnswerWasRight();
            }else if (myGameManager.BlackAnswer == "ne" && yesnoButton == NoButton){
                AnswerWasRight();
            }else{
                if (BlueTurn == false){
                    orangeScore = orangeScore - 3;
                }else if (BlueTurn == true){
                    blueScore = blueScore - 3;
                }
                scoreBlue.Text = blueScore.ToString();
                scoreOrange.Text = orangeScore.ToString();
                Question.Text = "This answer wasn´t right. Right answer was: " + myGameManager.BlackAnswer;
                DisplayInfo.Text = secondPlayer + ", it´s your turn now.";
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                BlueTurn = !BlueTurn;
            }
        }
        private void AnswerWasRight()
        {
            FindPlayers();
            if (BlueTurn == false) {
                orangeScore = orangeScore + 10;
                this.clickedButton.BackColor = Color.FromArgb(255, 142, 68);
                BlueTurn = true;
            } else if (BlueTurn == true) {
                blueScore = blueScore + 10;
                this.clickedButton.BackColor = Color.FromArgb(0, 162, 232);
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
        }
        private void AnswerWasFalse()
        {
            FindPlayers();
            if (BlueTurn == false) {
                orangeScore = orangeScore - 3;
            }else if (BlueTurn == true) {
                blueScore = blueScore - 3;
            }
            scoreBlue.Text = blueScore.ToString();
            scoreOrange.Text = orangeScore.ToString();
            
            if (SameQuestionAnswered == false){
                if(progressBarQuestion.Value == progressBarQuestion.Maximum){
                    DisplayInfo.Text = "Time for answering expired! " + secondPlayer + ", would you like to answer?";
                }else{
                    DisplayInfo.Text = "This answer wasn´t right, " + secondPlayer + ", would you like to answer?";
                }
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                YesButton.Show();
                NoButton.Show();
            }else{
                timerQuestion.Stop();
                if (progressBarQuestion.Value == progressBarQuestion.Maximum){
                    Question.Text = "Time for answering expired!";
                }else{
                    Question.Text = "This answer also wasn´t right. Right answer was: " + myGameManager.Answer;
                }
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                this.clickedButton.BackColor = Color.Black;
                this.clickedButton.TextColor = Color.White;
                DisplayInfo.Text = secondPlayer + ", it´s your turn";
                PlayersAnswer.Text = "";
                BlueTurn = !BlueTurn;
                SameQuestionAnswered = false;
            }
        }
        private void StartingColor()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 2);
            if (result == 0)
            {
                BlueTurn = false;//orange
            } else if (result == 1) {
                BlueTurn = true;//blue
            }
        }
        private void FindPlayers(){
            if (BlueTurn == false){
                secondPlayer = bluePlayer;
                firstPlayer = orangePlayer;
            } else if (BlueTurn == true){
                secondPlayer = orangePlayer;
                firstPlayer = bluePlayer;
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
                }
                timerQuestion.Stop();
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
            }else if(progressBarQuestion.Value == progressBarQuestion.Maximum){
                DisplayInfo.Text = "Time for answering expired" + secondPlayer + "would you like to answer?";
                AnswerWasFalse();
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
                } else
                    gameResult = orangePlayer + ", congratulations! You won!";
                string caption = "Game Result";
                
                var result = MessageBox.Show(gameResult, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
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

            int buttonNumber = 1;
            for (int row = 0; row < rows; row++)
            {
                int rowX = x - row * (buttonWidth /2);
                int rowY = y + row * buttonHeight - (int)(row * (buttonHeight * yGap));
                for (int i = 0; i <= row; i++)
                {
                    HexagonButton button = new HexagonButton();
                    button.AutoSize= true;
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point(rowX + i * buttonWidth, rowY);
                    button.Text = buttonNumber.ToString();
                    button.Name = button.Name + button.Text;
                    this.Controls.Add(button);  
                    buttonNumber++;
                }
            }
            foreach (HexagonButton butt in this.Controls.OfType<HexagonButton>())
            {
                    butt.Show();
                    butt.BringToFront();
                    butt.BackColor = Color.FromArgb(234, 234, 234);
                    butt.ForeColor = Color.Black;
                    butt.Click += HexagonButton_Click;
            }
        }
        private void back_button_Click(object sender, EventArgs e)
            {
                this.Hide();
            }
    }
}
