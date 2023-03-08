using AZ_Quiz.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace AZ_Quiz
{
    public class GameManager
    {
        AccountsManager myAccountManager = new AccountsManager();

        public int SinglePlayerScore = 0;
        public int Player1Score = 0;
        public int Player2Score = 0;
        public string Answer = "";
        public string Question = "";
        private string[] questions;
        private string[] answers;
        private int question = -1;
        public Random number = new Random();
        public void LoadQuestions()
        {
            //questions = File.ReadAllLines(Qpath);
            questions = Resources.Questions.Split("\n");
        }
        private void LoadAnswers()
        {
            answers = Resources.Answers.Split("\n");
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
    }
}
