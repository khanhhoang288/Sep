using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class AddLateBLL
    {
        VideoRentalDataContext db;
        tbl_Return tblrt;
        public int Add(eLateCharge lcid)
        {
            var lateid = db.tbl_LateCharges.Where(x => x.LateChargeID == lcid.LateChargeID).FirstOrDefault();
            if (lateid != null)
            {
                return 0;
            }
            tbl_LateCharge tmplc = new tbl_LateCharge();
            tmplc.LateChargeID = lateid.LateChargeID;
            tmplc.LateCharge = lateid.LateCharge;
            tmplc.DiskID = lateid.DiskID;
            tmplc.CustomerID = lateid.CustomerID;

            db.tbl_LateCharges.InsertOnSubmit(tmplc);
            db.SubmitChanges();
            return 1;
        }


        /*  public static int Add(int diskId)
         {
             //Check status disk
            DiskRepository diskRepository = new DiskRepository(context);
             Disk disk = diskRepository.Get(diskId);
             if (disk != null)
             {
                 if (disk.Status.Equals(StatusOfDisk.RENTED))
                 {
                     RentalRecordDetail detail = detailRepository.GetLatest(diskId);
                     if (detail != null)
                     {
                         using (TransactionScope transaction = new TransactionScope())
                         {
                             try
                             {
                                 if (DateTime.Now.Date > detail.DateReturn)
                                 {
                                     detail.DateReturnActual = DateTime.Now;
                                     detail.LateCharge = disk.TitleDisk.TypeDisk.LateCharge;
                                     detailRepository.Update(detail);
                                     diskRepository.ModifyStatus(disk, StatusOfDisk.ON_SHELF);
                                     transaction.Complete();
                                     return 1;
                                 }
                             }
                             catch
                             {
                                 transaction.Dispose();
                                 return 0;
                             }
                         }
                     }
                     return -1;
                 }
             }
             return -2;
         }*/
    }
}
