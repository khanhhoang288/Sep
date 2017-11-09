using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eUser
    {
        private string userName, passWord;

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public eUser()
        {
            this.UserName = "";
            this.PassWord = "";
        }

        public eUser(string un, string pw)
        {
            this.UserName = un;
            this.PassWord = pw;
        }
    }
}
