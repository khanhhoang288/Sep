using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCustomer
    {
        private int customerID;
        private string customerName, address, phoneNumber;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public eCustomer()
        {
            this.CustomerID = 0;
            this.CustomerName = "";
            this.Address = "";
            this.PhoneNumber = "";
        }

        public eCustomer(int cid, string cname, string caddress, string cphone)
        {
            this.CustomerID = cid;
            this.CustomerName = cname;
            this.Address = caddress;
            this.PhoneNumber = cphone;

        }

    }
}
