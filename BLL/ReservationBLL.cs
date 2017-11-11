using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ReservationBLL
    {
        VideoRentalDataContext db;
        public ReservationBLL()
        {
            db = new VideoRentalDataContext();
        }

        public List<eReservation> getAllReservation()
        {
            List<eReservation> ls = new List<eReservation>();

            foreach (tbl_Reservation item in db.tbl_Reservations.ToList())
            {
                eReservation temp = new eReservation();
                temp.ReservationID = item.ReservationID;
                temp.CustomerID = Convert.ToInt32(item.CustomerID);
                temp.ReservationDate = Convert.ToDateTime(item.ReservationDate);

                ls.Add(temp);
            }
            return ls;
        }

        public List<eReservation> getReservationByCustomerID(int cid)
        {
            List<eReservation> ls = new List<eReservation>();

            var list = db.tbl_Reservations.Where(x => x.CustomerID == cid).ToList();
            foreach (tbl_Reservation item in list)
            {
                eReservation temp = new eReservation();
                temp.ReservationID = item.ReservationID;
                temp.ReservationDate = Convert.ToDateTime(item.ReservationDate);
                temp.CustomerID = Convert.ToInt32(item.CustomerID);


                ls.Add(temp);
            }
            return ls;
        }

        public void insertReservation(eReservation e)
        {
            tbl_Reservation temp = new tbl_Reservation();

            temp.ReservationDate = e.ReservationDate;
            temp.CustomerID = e.CustomerID;


            db.tbl_Reservations.InsertOnSubmit(temp);
            db.SubmitChanges();
        }


        public void updateReservation(eReservation e)
        {
            tbl_Reservation temp = db.tbl_Reservations.Where(x => x.ReservationID == e.ReservationID).FirstOrDefault();

            temp.ReservationDate = e.ReservationDate;
            temp.CustomerID = e.CustomerID;

            db.SubmitChanges();
        }

        public bool deleteReservation(int rid)
        {
            tbl_Reservation temp = db.tbl_Reservations.Where(x => x.ReservationID == rid).FirstOrDefault();
            if (temp != null)
            {
                db.tbl_Reservations.DeleteOnSubmit(temp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
