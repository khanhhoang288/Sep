using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
     public class ReturnDiskBLL
    {
        VideoRentalDataContext DB;
        LateChargeBLL LCBll;
        tbl_Return tblrt;


        public List<eReturn> getallreturn()
        {
            var listtd = DB.tbl_Returns.ToList();
            List<eReturn> ls = new List<eReturn>();
            foreach (tbl_Return td in listtd)
            {
                eReturn ert = new eReturn();
                ert.DiskID = td.DiskID;
                ert.CustomerID = td.CustomerID;
                ert.ReturnDate = Convert.ToDateTime(td.ReturnDate);
            }
            return ls;

        }
        public int ReturnDisk(eReturn disk)
        {
            if (disk != null)
            {
                DB = new VideoRentalDataContext();
                tblrt = new tbl_Return();
                eReturn ert = new eReturn();
                LCBll = new LateChargeBLL();

                if (ert != null)
                {
                    if (DateTime.Now.Date > ert.ReturnDate.Date)
                    {
                        AddLateBLL al = new AddLateBLL();
                        int result = al.Add(LCBll.getLateChargeByDiskID(disk.DiskID));
                        if(result >= 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }

               
            }
            return -1;
        }
    }
}
