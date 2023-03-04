﻿using AZ_Quiz.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace AZ_Quiz
{
    internal class GameManager
    {
        public int SinglePlayerScore = 0;
        public string Answer = "";
        public string Question = "";
        private string[] questions;
        private string[] answers;
        private int question = -1;
        public Random number = new Random();
        public void LoadQuestions()
        {
            //questions = File.ReadAllLines(Qpath);
            questions = Resources.Questions.Split("\r\n");
        }
        private void LoadAnswers()
        {
            answers = Resources.Answers.Split("\r\n");
        }
        public void NextQuestion()
       {
            if (questions == null) {
                LoadQuestions();
            }
            question = number.Next(questions.Length);
        }
        public string GetQuestion()
        {
            if (questions == null || question < 0) {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            return Question = questions[question];
        }
        public string GetAnswer()
        {
            if (question < 0) {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            if (answers == null) {
                LoadAnswers();
            }
            return Answer = answers[question];
        }

        public void GenerateHexagons()
        {
            for (int i = 0; i < 28; i++)
            {
                HexagonButton button = new HexagonButton();
                button.Name = i.ToString();
            }
        }
    }
}
