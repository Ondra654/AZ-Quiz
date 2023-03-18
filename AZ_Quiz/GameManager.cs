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
        List<string> usedQuestions = new List<string>();
        List<string> usedBlackQuestions = new List<string>();

        string Qpath = QuestionPath ("data", "Questions.txt");
        string Apath = AnswersPath ("data", "Answers.txt");

        private string[] questions;
        private string[] answers;
        private string[] blackquestions;
        private string[] blackanswers;
        
        public Random number = new Random();

        public string answer = "";
        public string question = "";
        public string blackQuestion = "";
        public string blackAnswer = "";

        private int numQuestion = -1;
        private int numBlackQuestion = -1;

        static string QuestionPath(params string[] segments)
        {
            string Qpath = Directory.GetCurrentDirectory();

            Qpath = Path.Combine(Qpath);

            for (int i = 0; i < segments.Length; i += 1)
            {
                Qpath = Path.Combine(Qpath, segments[i]);
            }
            return Qpath;
        }
        static string AnswersPath(params string[] segments)
        {
            string Apath = Directory.GetCurrentDirectory();

            Apath = Path.Combine(Apath);

            for (int i = 0; i < segments.Length; i += 1)
            {
                Apath = Path.Combine(Apath, segments[i]);
            }
            return Apath;
        }
        internal void LoadData()
        {
            int index = 0;
            questions = File.ReadAllLines(Qpath);
            for (int i = 0; i < questions.Length; i++)
            {
                string row = questions[i];
                if (row == "SPLITTER")
                {
                    index = i;
                    break;
                }
            }
            questions = File.ReadAllLines(Qpath).Take(index).ToArray();
            blackquestions = File.ReadAllLines(Qpath).Skip(index + 1).ToArray();
            answers = File.ReadAllLines(Apath).Take(index).ToArray();
            blackanswers = File.ReadAllLines(Apath).Skip(index + 1).ToArray();
        }
        public void NextQuestion()
        {
            if (questions == null) {
                LoadData();
            }
            numQuestion = number.Next(questions.Length);
            numBlackQuestion = number.Next(blackquestions.Length);
            if(usedQuestions.Contains(numQuestion.ToString()) || usedBlackQuestions.Contains(numBlackQuestion.ToString()))
            {
                numQuestion = number.Next(questions.Length);
                numBlackQuestion = number.Next(blackquestions.Length);
            }
            usedQuestions.Add(numQuestion.ToString());
            //usedBlackQuestions.Add(numBlackQuestion.ToString());
        }
        public string GetQuestion()
        {
            if (questions == null || numQuestion < 0){
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            return question = questions[numQuestion];
        }
        public string GetAnswer()
        {
            if (numQuestion < 0) {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            if (answers == null) {
                LoadData();
            }
            return answer = answers[numQuestion];
        }
        public string GetBlackQuestion()
        {
            if (blackquestions == null || numBlackQuestion < 0)
            {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            return blackQuestion = blackquestions[numBlackQuestion];
        }
        public string GetBlackAnswer()
        {
            if (numBlackQuestion < 0)
            {
                throw new InvalidOperationException("Call NextQuestion first!");
            }
            if (blackanswers == null)
            {
                LoadData();
            }
            return blackAnswer = blackanswers[numBlackQuestion];
        }
    }
}
