using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eReturn
    {
        private int customerID, diskID;
        private DateTime returnDate;

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

        public int DiskID
        {
            get
            {
                return diskID;
            }

            set
            {
                diskID = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }

        public eReturn()
        {
            this.CustomerID = 0;
            this.DiskID = 0;
            this.ReturnDate = DateTime.Parse("1/1/2000");
        }

        public eReturn(int cid, int did, DateTime rdate)
        {
            this.CustomerID = cid;
            this.DiskID = did;
            this.ReturnDate = rdate;
        }
    }
}
