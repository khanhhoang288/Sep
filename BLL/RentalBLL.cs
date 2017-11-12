using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class RentalBLL
    {
        VideoRentalDataContext db;

        public RentalBLL()
        {
            db = new VideoRentalDataContext();

        }

        public List<eRental> getAllRental()
        {
            List<eRental> ls = new List<eRental>();

            foreach (tbl_Rental item in db.tbl_Rentals.ToList())
            {
                eRental temp = new eRental();
                temp.RentalID = item.RentalID;
                temp.RentalDate = Convert.ToDateTime(item.RentalDate);
                temp.CustomerID = Convert.ToInt32( item.CustomerID);


                ls.Add(temp);
            }

            return ls;
        }

        public List<eRental> getRentalByCustomerID(int cid)
        {
            List<eRental> ls = new List<eRental>();

            var list = db.tbl_Rentals.Where(x => x.CustomerID == cid).ToList();
            foreach (tbl_Rental item in list)
            {
                eRental temp = new eRental();
                temp.RentalID = item.RentalID;
                temp.RentalDate = Convert.ToDateTime(item.RentalDate);
                temp.CustomerID = Convert.ToInt32(item.CustomerID);


                ls.Add(temp);
            }
            return ls;
        }


        public eRental getOneRental(int rid)
        {
            eRental e = new eRental();
            var item = db.tbl_Rentals.Where(x => x.RentalID == rid).FirstOrDefault();
            e.RentalID = item.RentalID;
            e.RentalDate = Convert.ToDateTime( item.RentalDate);
            e.CustomerID = Convert.ToInt32( item.CustomerID);

            return e;
        }
        public int getCustomerIDByLateChargeID(int lid)
        {
            var temp = db.tbl_Rentals.Where(x => x.RentalID == lid).FirstOrDefault();
            return Convert.ToInt32( temp.CustomerID);
        }
        public void insertRental(eRental e)
        {
            tbl_Rental temp = new tbl_Rental();

            temp.RentalDate = e.RentalDate;
            temp.CustomerID = e.CustomerID;


            db.tbl_Rentals.InsertOnSubmit(temp);
            db.SubmitChanges();
        }

        public void updateRental(eRental e)
        {
            tbl_Rental temp = db.tbl_Rentals.Where(x => x.RentalID == e.RentalID).FirstOrDefault();

            temp.RentalDate = e.RentalDate;
            temp.CustomerID = e.CustomerID;

            db.SubmitChanges();
        }

        public bool deleteRental(int rid)
        {
            tbl_Rental temp = db.tbl_Rentals.Where(x => x.RentalID == rid).FirstOrDefault();
            if (temp != null)
            {
                db.tbl_Rentals.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public int maxRentalID()
        {
            int a = 0;
            foreach (tbl_Rental item in db.tbl_Rentals.ToList())
            {
                if(item.RentalID>a)
                {
                    a = item.RentalID;
                }
            }
            return a;
        }

    }
}
