using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eReservation
    {
        private int reservationID, customerID;
        private DateTime reservationDate;
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public int ReservationID
        {
            get
            {
                return reservationID;
            }

            set
            {
                reservationID = value;
            }
        }

        public DateTime ReservationDate
        {
            get
            {
                return reservationDate;
            }

            set
            {
                reservationDate = value;
            }
        }

        public eReservation()
        {
            this.ReservationID = 0;
            this.CustomerID = 0;
            this.ReservationDate= DateTime.Parse("1/1/2000");
        }

        public eReservation(int rid, int cid,DateTime rdate)
        {
            this.ReservationID = rid;
            this.CustomerID = cid;
            this.ReservationDate = rdate;
        }
    }
}
