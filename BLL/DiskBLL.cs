using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;
using Entities;


namespace BLL
{
    public class DiskBLL
    {
        VideoRentalDataContext db;
        public DiskBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eDisk> getAllDisk()
        {
            List<eDisk> ls = new List<eDisk>();

            foreach(tbl_Disk item in db.tbl_Disks.ToList())
            {
                eDisk disk = new eDisk();

                disk.DiskID = item.DiskID;
                disk.TitleID = Convert.ToInt32(item.TitleID);
                disk.DiskStatus = item.DiskStatus;
                disk.DiskCode = item.DiskCode;

                ls.Add(disk);
            }
            return ls;
        }


        public List<eDisk> getDiskByTitleID(int titleid)
        {
            List<eDisk> ls = new List<eDisk>();
            var lsdisk = db.tbl_Disks.Where(x => x.TitleID == titleid).ToList();
            foreach(tbl_Disk item in lsdisk)
            {
                eDisk disk = new eDisk();

                disk.DiskID = item.DiskID;
                disk.TitleID = Convert.ToInt32(item.TitleID);
                disk.DiskStatus = item.DiskStatus;
                disk.DiskCode = disk.DiskCode;

                ls.Add(disk);
            }
            return ls;
        }
    }
}
