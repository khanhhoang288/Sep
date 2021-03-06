﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data.Linq;

namespace BLL
{
    public class TitleBLL
    {
        VideoRentalDataContext db;

        public TitleBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eTitle> getAllTitle()
        {
            List<eTitle> ls = new List<eTitle>();

            foreach(tbl_Title item in db.tbl_Titles.ToList())
            {
                eTitle temp = new eTitle();
                temp.TitleID = item.TitleID;
                temp.TitleName = item.TitleName;
                temp.RentalPeriod = Convert.ToInt32(item.RentalPeriod);
                temp.RentalCharge = Convert.ToInt32(item.RentalCharge);
                temp.TitleStatus = item.TitleStatus;
                temp.Quantity = Convert.ToInt32(item.Quantity);

                ls.Add(temp);
            }

            return ls;
        }

        public eTitle getOneTitle(int tid)
        {
            var item = db.tbl_Titles.Where(x => x.TitleID == tid).FirstOrDefault();

            eTitle temp = new eTitle();
            temp.TitleID = tid;
            temp.TitleName = item.TitleName;
            temp.RentalPeriod = Convert.ToInt32(item.RentalPeriod);
            temp.RentalCharge = Convert.ToInt32(item.RentalCharge);
            temp.TitleStatus = item.TitleStatus;
            temp.Quantity = Convert.ToInt32(item.Quantity);

            return temp;
        }

        public eTitle getTitleByID(int id)
        {
            eTitle t = new eTitle();
            var temp = db.tbl_Titles.Where(x => x.TitleID == id).FirstOrDefault();
            t.TitleID = temp.TitleID;
            t.TitleName = temp.TitleName;
            t.RentalPeriod = Convert.ToInt32(temp.RentalPeriod);
            t.RentalCharge = Convert.ToInt32(temp.RentalCharge);
            t.TitleStatus = temp.TitleStatus;
            t.Quantity = Convert.ToInt32(temp.Quantity);

            return t;
        }

        public void insertTitle(eTitle title)
        {
            tbl_Title temp = new tbl_Title();

            temp.TitleName = title.TitleName;
            temp.RentalPeriod = title.RentalPeriod;
            temp.RentalCharge = title.RentalCharge;
            temp.TitleStatus = title.TitleStatus;
            temp.Quantity = title.Quantity;

            db.tbl_Titles.InsertOnSubmit(temp);
            db.SubmitChanges();
        }


        public void updateTitle(eTitle title)
        {
            tbl_Title temp = db.tbl_Titles.Where(x => x.TitleID == title.TitleID).FirstOrDefault();

            temp.TitleName = title.TitleName;
            temp.RentalPeriod = title.RentalPeriod;
            temp.RentalCharge = title.RentalCharge;
            temp.TitleStatus = title.TitleStatus;
            temp.Quantity = title.Quantity;

            db.SubmitChanges();
        }

        public bool deleteTitle(int titleid)
        {
            tbl_Title temp = db.tbl_Titles.Where(x => x.TitleID == titleid).FirstOrDefault();
            if (temp!=null)
            {
                db.tbl_Titles.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public decimal getRentalCharge(int tid)
        {
            var item = db.tbl_Titles.Where(x => x.TitleID == tid).FirstOrDefault();
            return Convert.ToDecimal(item.RentalCharge);
        }

    }
}
