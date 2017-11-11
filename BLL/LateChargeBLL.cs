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

        public void updateLatecharFee(int lid)
        {
            var item = db.tbl_LateCharges.Where(x => x.LateChargeID == lid).FirstOrDefault();
            item.LateCharge = 0;
            db.SubmitChanges();
        }


        public void updateLatecharFeePart(int cid, decimal l)
        {
            var ls = db.tbl_LateCharges.Where(x => x.CustomerID == cid).ToList();          
            foreach (tbl_LateCharge item in ls)
            {

                if (l > item.LateCharge)
                {
                    l = l - Convert.ToDecimal(item.LateCharge);
                    item.LateCharge = 0;
                    db.SubmitChanges();
                    
                }
                else
                {
                    item.LateCharge = item.LateCharge - l;
                    db.SubmitChanges();
                    break;
                }
            }

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

        public eLateCharge getLateChargeByDiskID(int did)
        {
            eLateCharge lc = new eLateCharge();
            var temp = db.tbl_LateCharges.Where(x => x.DiskID == did).FirstOrDefault();
            lc.LateChargeID = Convert.ToInt32(temp.LateChargeID);
            lc.CustomerID = Convert.ToInt32(temp.CustomerID);
            lc.DiskID = Convert.ToInt32(temp.DiskID);
            lc.LateCharge = Convert.ToInt32(temp.LateCharge);

            return lc;

        }
    }
}
