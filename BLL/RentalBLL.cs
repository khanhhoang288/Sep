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

            var lsrental = db.tbl_Rentals.Where(x => x.CustomerID == cid).ToList();
            foreach (tbl_Rental item in lsrental)
            {
                eRental temp = new eRental();
                temp.RentalID = item.RentalID;
                temp.RentalDate = Convert.ToDateTime(item.RentalDate);
                temp.CustomerID = Convert.ToInt32(item.CustomerID);


                ls.Add(temp);
            }
            return ls;
        }
    }
}
