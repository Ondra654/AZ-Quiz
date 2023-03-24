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
    public partial class MyMessageBox : UserControl
    {
        public string message = "";
        public MyMessageBox()
        {
            InitializeComponent();
        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            message1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
