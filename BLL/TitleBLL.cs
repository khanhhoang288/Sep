using System;
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
                eTitle title = new eTitle();
                title.TitleID = item.TitleID;
                title.TitleName = item.TitleName;
                title.RentalPeriod = Convert.ToInt32(item.RentalPeriod);
                title.RentalCharge = Convert.ToInt32(item.RentalCharge);
                title.TitleStatus = item.TitleStatus;
                title.Quantity = Convert.ToInt32(item.Quantity);

                ls.Add(title);
            }

            return ls;
        }
        

    }
}
