using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ReservationTitleBLL
    {
        VideoRentalDataContext db;
        public ReservationTitleBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eReservationTitle> getAllReservationTitle()
        {
            List<eReservationTitle> ls = new List<eReservationTitle>();

            foreach (tbl_ReservationTitle item in db.tbl_ReservationTitles.ToList())
            {
                eReservationTitle temp = new eReservationTitle();
                temp.ReservationID = item.ReservationID;
                temp.TitleID = item.TitleID;



                ls.Add(temp);
            }

            return ls;
        }

        public List<eReservationTitle> getAllRTbyReservationID(int rid)
        {
            List<eReservationTitle> ls = new List<eReservationTitle>();
            var list = db.tbl_ReservationTitles.Where(x => x.ReservationID == rid).ToList();
            foreach (tbl_ReservationTitle item in list)
            {
                eReservationTitle temp = new eReservationTitle();
                temp.ReservationID = item.ReservationID;
                temp.TitleID = item.TitleID;

                ls.Add(temp);
            }
            return ls;
        }

        public void insertReservationTitle(eReservationTitle e)
        {
            tbl_ReservationTitle temp = new tbl_ReservationTitle();

            temp.ReservationID = e.ReservationID;
            temp.TitleID = e.TitleID;

            db.tbl_ReservationTitles.InsertOnSubmit(temp);
            db.SubmitChanges();
        }

        public bool deleteReservationTitle(int rid, int tid)
        {
            //var qr = from d in db.tbl_DiskRentals
            //                      where (d.RentalID==rid) && (d.DiskID==did)
            //                      select d;

            tbl_ReservationTitle temp = db.tbl_ReservationTitles.Where(x => x.ReservationID == rid && x.TitleID == tid).FirstOrDefault();

            if (temp != null)
            {
                db.tbl_ReservationTitles.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void updateReservationTitle(eReservationTitle e)
        {
            tbl_ReservationTitle temp = db.tbl_ReservationTitles.Where(x => x.ReservationID == e.ReservationID).FirstOrDefault();

            temp.ReservationID = e.ReservationID;
            temp.TitleID = e.TitleID;


            db.SubmitChanges();
        }
    }
}
