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
    public partial class Dialog : MaterialForm
    {
        public Dialog()
        {
            InitializeComponent();
        }

        public Dialog(string message)
        {
            InitializeComponent();
            richTextBox1.Text = message;
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
