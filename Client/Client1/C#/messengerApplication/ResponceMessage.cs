using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerApplication
{
    class ResponceMessage
    {
        public int id;
        public string message;

        public ResponceMessage()
        {

        }

        public ResponceMessage(int id, string message)
        {
            this.id = id;
            this.message = message;
        }
    }
}
