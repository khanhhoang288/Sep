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
                temp.Status = Convert.ToInt32( item.Status);



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
                temp.Status = Convert.ToInt32( item.Status);

                ls.Add(temp);
            }
            return ls;
        }

        public void insertDiskRental(eDiskRental e)
        {
            tbl_DiskRental temp = new tbl_DiskRental();

            temp.RentalID = e.RentalID;
            temp.DiskID = e.DiskID;
            temp.Status = e.Status;
            temp.ReturnDate = e.ReturnDate;

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


        public List<eDiskRental> getDisRentalByStatus(int st)
        {
            List<eDiskRental> ls = new List<eDiskRental>();
            var list = db.tbl_DiskRentals.Where(x => x.Status == st).ToList();
            foreach (tbl_DiskRental item in list)
            {
                eDiskRental e = new eDiskRental();
                e.RentalID = item.RentalID;
                e.DiskID = item.DiskID;
                e.Status = Convert.ToInt32( item.Status);
                e.ReturnDate = Convert.ToDateTime( item.ReturnDate);

                ls.Add(e);
            }
            return ls;
        }
        

        //0 chua tra, 1 tra roi
        public eDiskRental getDiskNoRentalByDiskID(int did)
        {
            eDiskRental e = new eDiskRental();
            var d = db.tbl_DiskRentals.Where(x => x.DiskID == did && x.Status == 0).FirstOrDefault();
            e.RentalID = d.RentalID;
            e.DiskID = d.DiskID;
            e.Status = Convert.ToInt32( d.Status);
            e.ReturnDate = Convert.ToDateTime( d.ReturnDate);

            return e;
        }

        public void updateStatusDiskRental(eDiskRental e,int st)
        {
            var item = db.tbl_DiskRentals.Where(x => x.RentalID == e.RentalID && x.DiskID == e.DiskID).FirstOrDefault();
            item.RentalID = e.RentalID;
            item.DiskID = e.DiskID;
            item.Status = st;
            item.ReturnDate = e.ReturnDate;

            db.SubmitChanges();
        }

    }
}
