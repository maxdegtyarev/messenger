using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerApplication
{
    class Message
    {
        public string mSender;
        public string mReceiver;
        public string mText;
        public string mDate;


        public Message(string mSender, string mReceiver, string mText, string mDate="")
        {
            this.mSender = mSender;
            this.mReceiver = mReceiver;
            this.mText = mText;
            this.mDate = mDate;
        }
    }
}
