using static AZ_Quiz.HexagonButton;

namespace AZ_Quiz
{
    public partial class AZQuizGame : UserControl
    {
        MyMessageBox myMessageBox = new MyMessageBox();
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
        public string firstLetter = string.Empty;

        public void SetAccountsManager(AccountsManager accountManager)
        {
            myAccountsManager = accountManager;
        }
        public AZQuizGame()
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
        private void HexagonButton_Click(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            clickedButton = (HexagonButton)sender;
            if (clickedButton == null)
                return;

            foreach (HexagonButton hexagon in buttonList)
            {
                hexagon.Click -= HexagonButton_Click;//learned and implemented from: https://stackoverflow.com/questions/34284232/disable-click-button-event-c-sharp
            }
            timerQuestion.Start();
            progressBarQuestion.Show();
            if (clickedButton.BackColor == Color.Black){
                myGameManager.GetBlackQuestion();
                myGameManager.GetBlackAnswer();
                Question.Text = myGameManager.blackQuestion;
                YesButton.Show();
                NoButton.Show();
            }else{
                myGameManager.GetQuestion();
                myGameManager.GetAnswer();
                Question.Text = myGameManager.question;
                firstLetter = myGameManager.answer.Substring(0, 1);
                PlayersAnswer.Text = firstLetter;
                PlayersAnswer.Focus();//used and implemented from: https://social.msdn.microsoft.com/Forums/en-US/30ebf576-6b11-4cb2-83e0-c76c266d5f27/how-to-put-cursor-in-text-box-automatically-after-button-click-event?forum=winappswithcsharp
                PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//implemented after previous take over in "SinglePlayer - DisplayQuestion method".
            }
        }
        private void PlayersAnswer_BackSpaced(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && PlayersAnswer.Text.Length == 1)
            {
                e.SuppressKeyPress = true;//take over from: https://stackoverflow.com/questions/33172914/textbox-first-seven-characters-cannot-be-delete
            }
        }
        private void PlayersAnswer_Entered(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//learned and used after first take over in "SinglePlayer - SinAnswer_Entered method".
            {
                if (PlayersAnswer.Text == ""){
                    Question.Text = "Select Hexagon first!";
                }else if (PlayersAnswer.Text == myGameManager.answer){
                    AnswerWasRight();
                }else
                    AnswerWasFalse();
                scoreBlue.Text = blueScore.ToString();
                scoreOrange.Text = orangeScore.ToString();
            }
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
            yesnoButton = YesButton;
            PlayersAnswer.KeyUp += PlayersAnswer_Entered;
            if (clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }else{
                timerQuestion.Start();
                progressBarQuestion.Show();
                PlayersAnswer.Focus();
                PlayersAnswer.Text = myGameManager.answer.Substring(0, 1);
                PlayersAnswer.SelectionStart = PlayersAnswer.Text.Length;//implemented after previous take over in "SinglePlayer - DisplayQuestion method".
                SameQuestionAnswered = true;
                BlueTurn = !BlueTurn;//learned and take over from: https://stackoverflow.com/questions/8912353/can-i-invert-a-bool
                DisplayInfo.Text = "Now you can answer: ";
            }
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            YesButton.Hide();
            NoButton.Hide();
            yesnoButton = NoButton;
            PlayersAnswer.KeyUp += PlayersAnswer_Entered;
            if (clickedButton.BackColor == Color.Black)
            {
                YesNoAnswer();
            }else{
                Question.Text = myGameManager.answer;
                DisplayInfo.Text = "Ok, " + secondPlayer + ", it´s your turn";
                clickedButton.BackColor = Color.Black;
                clickedButton.TextColor = Color.White;
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
            }else if (myGameManager.blackAnswer == "ne" && yesnoButton == NoButton){
                AnswerWasRight();
            }
            else
            {
                if (BlueTurn == false)
                {
                    orangeScore = orangeScore - 3;
                    clickedButton.BackColor = customBlue;
                }else if (BlueTurn == true){
                    blueScore = blueScore - 3;
                    clickedButton.BackColor = customOrange;
                }
                clickedButton.Text = "";
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
                clickedButton.BackColor = customOrange;
                BlueTurn = true;
            }else if (BlueTurn == true){
                blueScore = blueScore + 10;
                clickedButton.BackColor = customBlue;
                BlueTurn = false;
            }
            scoreBlue.Text = blueScore.ToString();
            scoreOrange.Text = orangeScore.ToString();
            clickedButton.Text = "";
            timerQuestion.Stop();
            progressBarQuestion.Value = 0;
            progressBarQuestion.Hide();
            Question.Text = "This answer was right, " + firstPlayer + ".";
            DisplayInfo.Text = secondPlayer + ", it´s your turn now.";
            PlayersAnswer.Text = "";
            SameQuestionAnswered = false;
            EnableHexagonClick();

            if (CheckIfGameEnded())
            {
                timerGame.Stop();
                myAccountsManager.acc1score = blueScore;
                myAccountsManager.acc2score = orangeScore;
                myAccountsManager.RewriteScore();
                myMessageBox.SetmyMultiPlayer(this);
                if (clickedButton.BackColor == customOrange)
                {
                    myMessageBox.message = orangePlayer + ", congratulations! You won!";
                }else
                    myMessageBox.message = bluePlayer + ", congratulations! You won!";

                ShowMessageBox();
            }
        }
        private void AnswerWasFalse()
         {
            FindPlayers();
            if (BlueTurn == false)
            {
                orangeScore = orangeScore - 3;
            }else if (BlueTurn == true){
                blueScore = blueScore - 3;
            }
            if (SameQuestionAnswered == false)
            {
                if (progressBarQuestion.Value == progressBarQuestion.Maximum)
                {
                    PlayersAnswer.KeyUp -= PlayersAnswer_Entered;
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
                if (progressBarQuestion.Value == progressBarQuestion.Maximum)
                {
                    Question.Text = "Time for answering expired!";
                }else{
                    Question.Text = "This answer also wasn´t right. Right answer was: " + myGameManager.answer;
                }
                progressBarQuestion.Value = 0;
                progressBarQuestion.Hide();
                clickedButton.BackColor = Color.Black;
                clickedButton.TextColor = Color.White;
                DisplayInfo.Text = secondPlayer + ", it´s your turn";
                PlayersAnswer.Text = "";
                BlueTurn = !BlueTurn;
                SameQuestionAnswered = false;
                EnableHexagonClick();
            }
        }
        private bool CheckIfGameEnded()//1 of 2 methods, which check if someone won. This algoritm was completed with AI help - Chat GPT.
        {
            Color clickedButtonColor = clickedButton.BackColor;

            HexagonPosition connectedSides = new HexagonPosition();
            List<HexagonButton> checkedButtons = new List<HexagonButton>();

            GetConnectedSides(clickedButton, clickedButtonColor, connectedSides, checkedButtons);

            return connectedSides.ConnectsAllSides();
        }
        private void GetConnectedSides(HexagonButton button, Color clickedButtonColor, HexagonPosition connectedSides, List<HexagonButton> checkedButtons)// 2/2 methods, which check if someone won. This algoritm was completed with AI help - Chat GPT.
        {
            connectedSides.leftSide |= button.HexPosition.leftSide;
            connectedSides.rightSide |= button.HexPosition.rightSide;
            connectedSides.bottomSide |= button.HexPosition.bottomSide;

            checkedButtons.Add(button);

            foreach (HexagonButton neighour in button.Neighbours)
            {
                if (connectedSides.ConnectsAllSides()){
                    break;
                }
                if (neighour.BackColor != clickedButtonColor){
                    continue;
                }
                if (checkedButtons.Contains(neighour)){
                    continue;
                }
                GetConnectedSides(neighour, clickedButtonColor, connectedSides, checkedButtons);
            }
        }
        private void StartingColor()
        {
            Random radomnumber = new Random();
            int result = radomnumber.Next(0, 2);
            if (result == 0)
            {
                BlueTurn = false;//orange
            }else if (result == 1){
                BlueTurn = true;//blue
            }
        }
        private void FindPlayers()
        {
            if (BlueTurn == false)
            {
                secondPlayer = bluePlayer;
                firstPlayer = orangePlayer;
            }else if (BlueTurn == true){
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
        private void TimeLimit(object sender, EventArgs e)//both methods - TimeLimit and GameProgressBar were completed with undertook parts from: https://stackoverflow.com/questions/7259511/increase-a-progressbar-with-timer-in-winforms and https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.progressbar.increment?view=windowsdesktop-7.0
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
                    }else if (BlueTurn == true){
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
        private void GameProgressBar(object sender, EventArgs e)
        {
            progressBarGame.Increment(1);
            if (progressBarGame.Value == progressBarGame.Maximum)
            {
                timerGame.Stop();
                myAccountsManager.acc1score = blueScore;
                myAccountsManager.acc2score = orangeScore;
                myAccountsManager.RewriteScore();
                myMessageBox.SetmyMultiPlayer(this);
                DisplayInfo.Text = "Game time expired.";
                if (blueScore > orangeScore)
                {
                    myMessageBox.message = bluePlayer + ", congratulations! You won!";
                }else if(blueScore == orangeScore){
                    myMessageBox.message = "Draw! Well played, both of you.";
                }else
                    myMessageBox.message = orangePlayer + ", congratulations! You won!";

                ShowMessageBox();
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
            for (int row = 0; row < rows; row++)//completed with help/inspiration from:https://www.codeproject.com/Questions/5293567/Dynamically-generate-buttons-Csharp and https://stackoverflow.com/questions/47732560/how-can-i-create-a-button-programmatically-in-c-sharp-window-app
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

                    if (i == 0){
                        hexagon.HexPosition.leftSide = true;
                    }
                    if (i == row){
                        hexagon.HexPosition.rightSide = true;
                    }
                    if (row == rows - 1){
                        hexagon.HexPosition.bottomSide = true;
                    }
                    currentRowButtons.Add(hexagon);
                    buttonList.Add(hexagon);
                }
            }
            for (int row = 0; row < buttonListByRows.Count; row++)//Generate neighbours; after research and asking AI for best option of how to evaluate the game -> using lists and columns to search through neighbours
            {
                List<HexagonButton> rowButtons = buttonListByRows[row];

                for (int column = 0; column < rowButtons.Count; column++)
                {
                    HexagonButton button = rowButtons[column];

                    if (column - 1 >= 0){
                        button.Neighbours.Add(rowButtons[column - 1]);
                    }
                    if (column + 1 < rowButtons.Count){
                        button.Neighbours.Add(rowButtons[column + 1]);
                    }
                    if (row - 1 >= 0){
                        if (column - 1 >= 0){
                            button.Neighbours.Add(buttonListByRows[row - 1][column - 1]);
                        }
                        if (column < buttonListByRows[row - 1].Count){
                            button.Neighbours.Add(buttonListByRows[row - 1][column]);
                        }
                    }
                    if (row + 1 < buttonListByRows.Count){
                        button.Neighbours.Add(buttonListByRows[row + 1][column]);

                        if (column + 1 < buttonListByRows[row + 1].Count){
                            button.Neighbours.Add(buttonListByRows[row + 1][column + 1]);
                        }
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
        private void ShowMessageBox()
        {
            myMessageBox.singlePlayer = true;
            int x = (this.Width - myMessageBox.Width) / 2;
            int y = (this.Height - myMessageBox.Height) / 2;

            this.Parent.Controls.Add(myMessageBox);
            myMessageBox.Location = new System.Drawing.Point(x, y);
            myMessageBox.BringToFront();
        }
        public void ResetAll()
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
            myAccountsManager.acc1score = blueScore;
            myAccountsManager.acc2score = orangeScore;
            myAccountsManager.RewriteScore();
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
            myMessageBox.singlePlayer = false;
            this.Hide();
        }
    }
}
