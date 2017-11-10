using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class LateChargeBLL
    {
        VideoRentalDataContext db;

        public LateChargeBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eLateCharge> getAllLateCharge()
        {
            List<eLateCharge> ls = new List<eLateCharge>();

            foreach (tbl_LateCharge item in db.tbl_LateCharges.ToList())
            {
                eLateCharge temp = new eLateCharge();
                temp.LateChargeID = item.LateChargeID;
                temp.CustomerID = Convert.ToInt32( item.CustomerID);
                temp.DiskID =  Convert.ToInt32( item.DiskID);
                temp.LateCharge = Convert.ToDecimal( item.LateCharge);


                ls.Add(temp);
            }

            return ls;
        }

        public List<eLateCharge> getLateChargeByCustomerID(int cid)
        {
            List<eLateCharge> ls = new List<eLateCharge>();
            var lslate = db.tbl_LateCharges.Where(x => x.CustomerID == cid).ToList();
            foreach (tbl_LateCharge item in lslate)
            {
                eLateCharge temp = new eLateCharge();
                temp.LateChargeID = item.LateChargeID;
                temp.CustomerID = Convert.ToInt32(item.CustomerID);
                temp.DiskID = Convert.ToInt32(item.DiskID);
                temp.LateCharge = Convert.ToDecimal(item.LateCharge);


                ls.Add(temp);
            }

            return ls;
        }

        public decimal sumLateChargeByCustomerID(int cid)
        {
            decimal sum = 0;
            var lslate = db.tbl_LateCharges.Where(x => x.CustomerID == cid).ToList();
            foreach (tbl_LateCharge item in lslate)
            {
                sum += Convert.ToDecimal( item.LateCharge);
            }
            return sum;
        }
    }
}
