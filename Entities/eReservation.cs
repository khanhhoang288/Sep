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

        public eReservation()
        {
            this.ReservationID = 0;
            this.CustomerID = 0;
        }

        public eReservation(int rid, int cid)
        {
            this.ReservationID = rid;
            this.CustomerID = cid;
        }
    }
}
