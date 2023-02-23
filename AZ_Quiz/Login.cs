using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_Quiz
{
    public partial class Login : UserControl
    {
        AccountsManager myAccountsManager = new AccountsManager();
        public Login(){
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e){
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            myAccountsManager.LoadData();
            TESTLABEL.Text = myAccountsManager.existingNicknames;
        }
    }
}
