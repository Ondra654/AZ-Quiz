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
        const string QuestionsPath = "C:\\Users\\Ondra\\source\\repos\\AZ_Quiz\\Questions.txt";
        const string AnswerPath = "C:\\Users\\Ondra\\source\\repos\\AZ_Quiz\\Answers.txt";

        public string Answer = "";
        public string Question = "";
        private string[] questions;
        private string[] answers;
        private int question = -1;
        public Random number = new Random();

       public void NextQuestion()
       {
            if (questions == null) {
                LoadQuestions(QuestionsPath);
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
                LoadAnswers(AnswerPath);
            }
            
            return Answer = answers[question];
        }
        public string CheckAnswer()
        {
            return string.Empty;
        }
        
        private void LoadQuestions(string Qpath)
        {
            questions = File.ReadAllLines(Qpath);
        }
        private void LoadAnswers(string Apath)
        {
            answers= File.ReadAllLines(Apath);
        }
        internal void LoadData()
        {
           //accounts
        }

        internal void SavedData()
        {
            //accounts
        }
    }
}
