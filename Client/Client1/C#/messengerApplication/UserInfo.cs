using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace messengerApplication
{
    public partial class UserInfo : MaterialForm
    {
        Account account;

        public UserInfo()
        {
            InitializeComponent();
        }

        public UserInfo(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            label_name.Text = account.accName;
            label_surname.Text = account.accSurname;
            label_id.Text = account.accId.ToString();
        }

        private async void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Contact cont = await Program.clientSystem.writeContact(Program.clientSystem.AuthorizedAccount.accHash, account.accId);

            if (cont == null)
            {
                materialRaisedButton2.Text = "Добавить в контакты";
            } else
            {
                materialRaisedButton2.Text = "Удалить из контактов";
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new MessageList(account.accId, account.accName, account.accSurname).Show();
        }
    }
}
