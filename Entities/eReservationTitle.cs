using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eReservationTitle
    {
        private int reservationID, titleID;

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

        public int TitleID
        {
            get
            {
                return titleID;
            }

            set
            {
                titleID = value;
            }
        }

        public eReservationTitle()
        {
            this.ReservationID = 0;
            this.TitleID = 0;
        }

        public eReservationTitle(int rid, int tid)
        {
            this.ReservationID = rid;
            this.TitleID = tid;
        }
    }
}
