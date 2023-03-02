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

        public class TriangleHexButtonsControl : UserControl
        {
            private const int ButtonSize = 50;
            private const int ButtonHeight = 60;
            private const int NumRows = 7;

            public TriangleHexButtonsControl()
            {
                this.Size = new Size(NumRows * ButtonSize, NumRows * ButtonHeight);
                this.BackColor = Color.White;

                for (int row = 0; row < NumRows; row++)
                {
                    int numButtons = NumRows - row;
                    int offset = row / 2 * ButtonSize;
                    int y = row * ButtonHeight;

                    for (int col = 0; col < numButtons; col++)
                    {
                        int x = offset + col * ButtonSize;

                        HexagonButton button = new HexagonButton();
                        button.Location = new Point(x, y);
                        button.Size = new Size(ButtonSize, ButtonHeight);
                        button.BackColor = Color.Yellow;
                        button.Text = $"({row},{col})";
                        this.Controls.Add(button);
                    }
                }
            }
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
