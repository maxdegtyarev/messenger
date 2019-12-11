using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerApplication
{
    public class Account
    {
        public int accId;
        public string accName;
        public string accLogin;
        public string accSurname;
        public bool accBlocked;
        public string accBirth;
        public string accPassword;
        public string accHash;

        public Account()
        {
            accId = -1;
        }

        public Account(string accLogin = "", string accName = "", string accSurname = "", string accBirth = "", string accPassword = "", string accHash = "")
        {
            this.accName = accName;
            this.accSurname = accSurname;
            this.accBirth = accBirth;
            this.accPassword = accPassword;
            this.accHash = accHash;
            this.accLogin = accLogin;
        }

        public Account(int accId, string accName = "", string accSurname = "", string accBirth = "")
        {
            this.accId = accId;
            this.accName = accName;
            this.accSurname = accSurname;
            this.accBirth = accBirth;
        }
        public Account(string accLogin, string accPassword)
        {
            this.accLogin = accLogin;
            this.accPassword = accPassword;
        }

        override
        public string ToString()
        {
            return "accId: " + accId.ToString() + "\n" +
                "accName: " + accName + "\n" +
                "accSurname: " + accSurname + "";
        }

    }
}
