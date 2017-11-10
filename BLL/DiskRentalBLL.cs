using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data.Linq;

namespace BLL
{
    public class DiskRentalBLL
    {
        VideoRentalDataContext db;

        public DiskRentalBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eDiskRental> getAllDiskRental()
        {
            List<eDiskRental> ls = new List<eDiskRental>();

            foreach (tbl_DiskRental item in db.tbl_DiskRentals.ToList())
            {
                eDiskRental temp = new eDiskRental();
                temp.RentalID = item.RentalID;
                temp.DiskID = item.DiskID;



                ls.Add(temp);
            }

            return ls;
        }

        public List<eDiskRental> getAllDiskRentalByRentalID(int rentalid)
        {
            List<eDiskRental> ls = new List<eDiskRental>();
            var lsdrental = db.tbl_DiskRentals.Where(x => x.RentalID == rentalid).ToList();
            foreach (tbl_DiskRental item in lsdrental)
            {
                eDiskRental temp = new eDiskRental();
                temp.RentalID = item.RentalID;
                temp.DiskID = item.DiskID;

                ls.Add(temp);
            }
            return ls;
        }

        public void insertDiskRental(eDiskRental e)
        {
            tbl_DiskRental temp = new tbl_DiskRental();

            temp.RentalID = e.RentalID;
            temp.DiskID = e.DiskID;

            db.tbl_DiskRentals.InsertOnSubmit(temp);
            db.SubmitChanges();
        }

        public bool deleteDiskRental(int rid, int did)
        {
            //var qr = from d in db.tbl_DiskRentals
            //                      where (d.RentalID==rid) && (d.DiskID==did)
            //                      select d;

            tbl_DiskRental temp = db.tbl_DiskRentals.Where(x => x.RentalID==rid && x.DiskID==did).FirstOrDefault();

            if (temp != null)
            {
                db.tbl_DiskRentals.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
