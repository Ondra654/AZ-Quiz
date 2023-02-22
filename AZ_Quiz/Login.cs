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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string LogName = textBox1.Text;
            string LogPassword = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string RegName = textBox2.Text;
            string RegPassword = textBox2.Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
