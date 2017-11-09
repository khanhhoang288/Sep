using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLateCharge
    {
        private int lateChargeID, customerID, diskID;
        private decimal lateCharge;

        public int LateChargeID
        {
            get
            {
                return lateChargeID;
            }

            set
            {
                lateChargeID = value;
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

        public decimal LateCharge
        {
            get
            {
                return lateCharge;
            }

            set
            {
                lateCharge = value;
            }
        }

        public eLateCharge()
        {
            this.LateChargeID = 0;
            this.CustomerID = 0;
            this.DiskID = 0;
            this.LateCharge = 0;
        }

        public eLateCharge(int lchargeid, int cid, int did, decimal lcharge)
        {
            this.LateChargeID = lchargeid;
            this.CustomerID = cid;
            this.DiskID = did;
            this.LateCharge = lcharge;
        }
    }
}
