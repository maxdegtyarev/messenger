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
    public partial class UserMessage : UserControl
    {
        int accId;
        string accName;
        string accSurname;

        public UserMessage()
        {
            InitializeComponent();
        }

        public UserMessage(int accId, string accName, string accSurname)
        {
            InitializeComponent();
            this.accId = accId;
            this.accName = accName;
            this.accSurname = accSurname;

        }


        private void UserMessage_Load(object sender, EventArgs e)
        {
            label_name.Text = accName;
            label_surname.Text = accSurname;

        }

        private void UserMessage_Click(object sender, EventArgs e)
        {
            new MessageList(accId,accName,accSurname).Show();
        }

        private void UserMessage_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void UserMessage_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }
    }
}
