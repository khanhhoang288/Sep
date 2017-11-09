using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTitle
    {
        private int titleID, rentalPeriod, quantity;
        private string titleName, titleStatus;
        private decimal rentalCharge;

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

        public int RentalPeriod
        {
            get
            {
                return rentalPeriod;
            }

            set
            {
                rentalPeriod = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string TitleName
        {
            get
            {
                return titleName;
            }

            set
            {
                titleName = value;
            }
        }

        public string TitleStatus
        {
            get
            {
                return titleStatus;
            }

            set
            {
                titleStatus = value;
            }
        }

        public decimal RentalCharge
        {
            get
            {
                return rentalCharge;
            }

            set
            {
                rentalCharge = value;
            }
        }

        public eTitle()
        {
            this.TitleID = 0;
            this.TitleName = "";
            this.RentalPeriod = 0;
            this.RentalCharge = 0;
            this.TitleStatus = "";
            this.Quantity = 0;
        }

        public eTitle(int tid, string tname, int rperiod, decimal rcharge, string tstatus, int qtity)
        {
            this.TitleID = tid;
            this.TitleName = tname;
            this.RentalPeriod = rperiod;
            this.RentalCharge = rcharge;
            this.TitleStatus = tstatus;
            this.Quantity = qtity;
        }
    }
}
