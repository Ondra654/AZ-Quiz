using AZ_Quiz.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.Design;
using static System.Windows.Forms.LinkLabel;

namespace AZ_Quiz
{
    public class GameManager
    {
        List<string> usedQuestions = new List<string>();
        List<string> usedBlackQuestions = new List<string>();
        public bool questionsListFull = false;

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

        static string GetPath(params string[] segments)
        {
            string path = Directory.GetCurrentDirectory();

            path = Path.Combine(path);

            for (int i = 0; i < segments.Length; i += 1)
            {
                path = Path.Combine(path, segments[i]);
            }
            return path;
        }
        internal void LoadData()
        {
            string Qpath = GetPath("data", "Questions.txt");
            string Apath = GetPath("data", "Answers.txt");
            int index = 0;
            try{
                questions = File.ReadAllLines(Qpath);
            }catch (FileNotFoundException){
                throw new FileNotFoundException ("File 'Questions' is not located in 'data' folder, redownload game or put this file back");
            }
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
            try{
                answers = File.ReadAllLines(Apath).Take(index).ToArray();
            }catch(FileNotFoundException){
                throw new FileNotFoundException("File 'Answers' is not located in 'data' folder, redownload game or put this file back");
            }
            blackanswers = File.ReadAllLines(Apath).Skip(index + 1).ToArray();
        }
        public void GetQuestion()
        {
            if( numQuestion < 0){
                throw new InvalidOperationException("questions/answers data inside 'Questions/Answers' folder are missing/or has been edited, redownload this data or put them back inside this file.");
            }
            if (questions == null)
            {
                LoadData();
            }
            if(usedQuestions.Count == questions.Length)
            {
                questionsListFull = true;
            }
            else
            {
                numQuestion = number.Next(questions.Length);
                question = questions[numQuestion];

                if (usedQuestions.Contains(question))
                {
                    GetQuestion();
                }else
                    usedQuestions.Add(question);
            }
        }
        public string GetAnswer()
        {
            if (answers == null) {
                LoadData();
            }
            return answer = answers[numQuestion];
        }
        public void GetBlackQuestion()
        {
            if (blackQuestion == null)
            {
                LoadData();
            }
            
            numBlackQuestion = number.Next(blackquestions.Length);
            blackQuestion = blackquestions[numBlackQuestion];
            
            if (usedBlackQuestions.Contains(blackQuestion))
            {
                GetBlackQuestion();
            }else
                usedBlackQuestions.Add(blackQuestion);            
        }
        public string GetBlackAnswer()
        {
            if (numBlackQuestion < 0)
            {
                GetBlackQuestion();
            }
            if (blackanswers == null)
            {
                LoadData();
            }
            return blackAnswer = blackanswers[numBlackQuestion];
        }
        public void ResetQuestionLists()
        {
            usedQuestions.Clear();
            usedBlackQuestions.Clear();
        }
    }
}
