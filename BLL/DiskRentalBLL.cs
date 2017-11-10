using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

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
    }
}
