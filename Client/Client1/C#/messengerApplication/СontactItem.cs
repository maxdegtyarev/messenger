using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace messengerApplication
{
    public partial class ContactItem : UserControl
    {
        public ContactItem()
        {
            InitializeComponent();
        }

        public ContactItem(Account account)
        {
            InitializeComponent();
            Account = account;
        }
        public Account Account { get; set; }

        private void ContactItem_Load(object sender, EventArgs e)
        {
            if (Account != null)
            {
                this.label_Name.Text = Account.accName;
                this.label_Status.Text = Account.accId.ToString();
            }
            
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(Account);
            userInfo.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            new MessageList(Account.accId, Account.accName, Account.accPassword).Show();
        }
    }
}
