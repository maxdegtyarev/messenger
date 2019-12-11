using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messengerApplication
{
    public partial class MyMessage : UserControl
    {
        public MyMessage()
        {
            InitializeComponent();
        }

        public MyMessage(string senderName, string message, string time = "")
        {
            InitializeComponent();

            label_sender.Text = senderName;
            label_message.Text = message;
            label_time.Text = time;
        }

        private void MyMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
