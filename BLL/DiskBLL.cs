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

            foreach (tbl_Disk item in db.tbl_Disks.ToList())
            {
                eDisk disk = new eDisk();

                disk.DiskID = item.DiskID;
                disk.TitleID = Convert.ToInt32( item.TitleID);
                disk.DiskStatus = item.DiskStatus;
                disk.DiskCode = item.DiskCode;

                ls.Add(disk);
            }
            return ls;
        }



        public List<eDisk> getAllDisl()
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

        public eDisk getOneDisk(int did)
        {
            eDisk d = new eDisk();
            var item = db.tbl_Disks.Where(x => x.DiskID == did).FirstOrDefault();
            d.DiskID = item.DiskID;
            d.TitleID = Convert.ToInt32( item.TitleID);
            d.DiskStatus = item.DiskStatus;
            d.DiskCode = item.DiskCode;

            return d;
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

        public void insertDisk(eDisk disk)
        {
            tbl_Disk temp = new tbl_Disk();

            temp.TitleID = disk.TitleID;
            temp.DiskStatus = disk.DiskStatus;
            temp.DiskCode = disk.DiskCode;

            

            db.tbl_Disks.InsertOnSubmit(temp);
            db.SubmitChanges();
        }

        public bool deleteDisk(int diskid)
        {
            tbl_Disk temp = db.tbl_Disks.Where(x => x.DiskID == diskid).FirstOrDefault();
            if (temp != null)
            {
                db.tbl_Disks.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void updateDisk(eDisk disk)
        {
            tbl_Disk temp = db.tbl_Disks.Where(x => x.DiskID == disk.DiskID).FirstOrDefault();

            temp.TitleID = disk.TitleID;
            temp.DiskStatus = disk.DiskStatus;
            temp.DiskCode = disk.DiskCode;


            db.SubmitChanges();
        }

        public int getTitleIDByDiskID(int did)
        {
            eDisk d = new eDisk();
            var item = db.tbl_Disks.Where(x => x.DiskID == did).FirstOrDefault();
            
            return d.TitleID;
        }


    }
}
