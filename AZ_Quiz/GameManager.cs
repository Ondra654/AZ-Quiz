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

        static string GetPath(params string[] segments)//used from Lecture22 from our teacher: https://github.com/redwormik/gymspit-pg4-2022/tree/main/Lecture22
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
            try
            {
                questions = File.ReadAllLines(Qpath);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File 'Questions' is not located in 'data' folder, redownload game or put this file back");
            }
            for (int i = 0; i < questions.Length; i++)///finds out on what row inside data is SPLITTER -> set index number, which is used right after to split data correctly
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
            try
            {
                answers = File.ReadAllLines(Apath).Take(index).ToArray();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File 'Answers' is not located in 'data' folder, redownload game or put this file back");
            }
            blackanswers = File.ReadAllLines(Apath).Skip(index + 1).ToArray();
        }
        public void GetQuestion()///loads a new question
        {
            if (questions == null)
            {
                LoadData();
            }
            if (usedQuestions.Count == questions.Length)
            {
                questionsListFull = true;
            }
            else
            {
                numQuestion = number.Next(questions.Length);
                if (numQuestion < 0)
                {
                    throw new InvalidOperationException("questions/answers data inside 'Questions/Answers' folder are missing/or has been edited, redownload this data or put them back inside this file.");
                }
                else
                    question = questions[numQuestion];

                if (usedQuestions.Contains(question))
                {
                    GetQuestion();
                }
                else
                    usedQuestions.Add(question);
            }
        }
        public string GetAnswer()///loads a new answer for loaded question
        {
            if (answers == null)
            {
                LoadData();
            }
            return answer = answers[numQuestion];
        }
        public void GetBlackQuestion()///loads a new YES/NO question
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
            }
            else
                usedBlackQuestions.Add(blackQuestion);
        }
        public string GetBlackAnswer()///loads a new YES/NO answer for loaded YES/NO question
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
        public void ResetQuestionLists()///clears lists of used questions
        {
            usedQuestions.Clear();
            usedBlackQuestions.Clear();
        }
    }
}
