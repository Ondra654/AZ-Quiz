
namespace AZ_Quiz
{
    public partial class MyMessageBox : UserControl
    {
        SinglePlayer mySinglePlayer;
        AZQuizGame myMultiPlayer;

        public string message = "";
        public bool singlePlayer = false;
        public bool errorMsg = false;
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public void SetmySinglePlayer(SinglePlayer singleplayer)
        {
            mySinglePlayer = singleplayer;
        }
        public void SetmyMultiPlayer(AZQuizGame multiplayer)
        {
            myMultiPlayer = multiplayer;
        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            message1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (singlePlayer == false){
                mySinglePlayer.ResetAll();
            }else
                myMultiPlayer.ResetAll();

            this.SendToBack();
        }
    }
}
