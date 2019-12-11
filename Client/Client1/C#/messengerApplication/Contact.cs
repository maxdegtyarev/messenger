using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerApplication
{
    public class Contact
    {
        public int conTo;
        public int conFrom; //Connection to Hash;

        public Contact(int conFrom, int conTo)
        {
            this.conFrom = conFrom;
            this.conTo = conTo;
        }

        public bool isEmpty()
        {
            return conFrom == -1 && conTo == -1;
        }
    }
}
