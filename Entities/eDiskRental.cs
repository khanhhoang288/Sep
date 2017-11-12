using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDiskRental
    {
        private int rentalID, diskID, status;
        DateTime returnDate;
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

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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

        public eDiskRental()
        {
            this.DiskID = 0;
            this.RentalID = 0;
            this.status = 0;
            this.ReturnDate = Convert.ToDateTime("1/1/2000");
        }

        public eDiskRental(int did, int rid, int st, DateTime rd)
        {
            this.DiskID = did;
            this.RentalID = rid;
            this.Status = st;
            this.ReturnDate = rd;
        }
    }
}
