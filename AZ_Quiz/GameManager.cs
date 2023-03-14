using AZ_Quiz.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.LinkLabel;

namespace AZ_Quiz
{
    public class GameManager
    {
        AccountsManager myAccountManager = new AccountsManager();
        List<string> usedQuestions = new List<string>();

        string Qpath = QuestionPath ("data", "Questions.txt");
        string Apath = AnswersPath ("data", "Answers.txt");

        public int SinglePlayerScore = 0;
        public int Player1Score = 0;
        public int Player2Score = 0;
        public string Answer = "";
        public string Question = "";
        public string BlackQuestion = "";
        public string BlackAnswer = "";
        private string[] questions;
        private string[] answers;
        private string[] blackquestions;
        private string[] blackanswers;
        private int question = -1;
        private int blackquestion = -1;
        public Random number = new Random();
        static string QuestionPath(params string[] segments)
        {
            //questions = Resources.Questions.Split("\n");
            string Qpath = Directory.GetCurrentDirectory();

            Qpath = Path.Combine(Qpath, "..", "AZ_Quiz");

            for (int i = 0; i < segments.Length; i += 1)
            {
                Qpath = Path.Combine(Qpath, segments[i]);
            }
            return Qpath;
        }
        static string AnswersPath(params string[] segments)
        {
            //answers = Resources.Answers.Split("\n");
            string Apath = Directory.GetCurrentDirectory();

            Apath = Path.Combine(Apath, "..", "AZ_Quiz");

            for (int i = 0; i < segments.Length; i += 1)
            {
                Apath = Path.Combine(Apath, segments[i]);
            }
            return Apath;
        }
        internal void LoadData()
        {
            questions = File.ReadAllLines(Qpath).Take(74).ToArray();
            blackquestions = File.ReadAllLines(Qpath).Skip(74).ToArray();
            answers = File.ReadAllLines(Apath).Take(74).ToArray();
            blackanswers = File.ReadAllLines(Apath).Skip(74).ToArray();
        }
        public void NextQuestion()
        {
            if (questions == null) {
                LoadData();
            }
            question = number.Next(questions.Length);
            blackquestion = number.Next(blackquestions.Length);
            if(usedQuestions.Contains(question.ToString()))
            {
                question = number.Next(questions.Length);
                blackquestion = number.Next(blackquestions.Length);
            }
            usedQuestions.Add(question.ToString());
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
                LoadData();
            }
            return Answer = answers[question];
        }
        public string GetBlackQuestion()
        {
            if (blackquestions == null || blackquestion < 0)
            {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            return BlackQuestion = blackquestions[blackquestion];
        }
        public string GetBlackAnswer()
        {
            if (blackquestion < 0)
            {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            if (blackanswers == null)
            {
                LoadData();
            }
            return BlackAnswer = blackanswers[blackquestion];
        }
    }
}
