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
    public partial class NotficationControl : UserControl
    {
        public NotficationControl()
        {
            InitializeComponent();
        }

        public NotficationControl(string text)
        {
            InitializeComponent();
            label_info.Text = text;
        }

        private void NotficationControl_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            Visible = false;
        }
    }
}
