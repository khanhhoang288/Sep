using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eRental
    {
        private int rentalID, customerID;
        private DateTime rentalDate;

        public int RentalID
        {
            get
            {
                return rentalID;
            }

            set
            {
                rentalID = value;
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

        public DateTime RentalDate
        {
            get
            {
                return rentalDate;
            }

            set
            {
                rentalDate = value;
            }
        }

        public eRental()
        {
            this.RentalID = 0;
            this.CustomerID = 0;
            this.RentalDate = DateTime.Parse("1/1/2000");
        }

        public eRental(int rid, int cid, DateTime rdate)
        {
            this.RentalID = rid;
            this.CustomerID = cid;
            this.RentalDate = rdate;
        }
    }
}
