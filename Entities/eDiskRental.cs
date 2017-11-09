using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDiskRental
    {
        private int rentalID, diskID;

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

        public eDiskRental()
        {
            this.DiskID = 0;
            this.RentalID = 0;
        }

        public eDiskRental(int did, int rid)
        {
            this.DiskID = did;
            this.RentalID = rid;
        }
    }
}
