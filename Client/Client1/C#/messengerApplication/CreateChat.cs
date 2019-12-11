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
    public partial class CreateChat : MaterialForm
    {
        Account account;

        public CreateChat()
        {
            InitializeComponent();
        }

        public CreateChat(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void CreateChat_Load(object sender, EventArgs e)
        {
        
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (input_chatname.Text.Length > 0)
            {

            }
        }
    }
}
