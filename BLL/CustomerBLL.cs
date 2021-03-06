﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Data.Linq;
using System.Data.Linq.SqlClient;

namespace BLL
{
    public class CustomerBLL
    {
        VideoRentalDataContext DB = new VideoRentalDataContext();
        public List<eCustomer> GetAllCustomer()
        {
            var dsKH = DB.tbl_Customers.ToList();
            List<eCustomer> lkh = new List<eCustomer>();

            foreach (tbl_Customer kh_DAL in dsKH)
            {
                eCustomer ekh = new eCustomer();
                ekh.Address = kh_DAL.Address;
                ekh.CustomerID = kh_DAL.CustomerID;
                ekh.CustomerName = kh_DAL.CustomerName;
                ekh.PhoneNumber = kh_DAL.PhoneNumber;


                lkh.Add(ekh);
            }
            return lkh;
        }

        
        public eCustomer getOneCustomer(int cid)
        {
            eCustomer e = new eCustomer();
            var item = DB.tbl_Customers.Where(x => x.CustomerID == cid).FirstOrDefault();
            e.CustomerID = item.CustomerID;
            e.CustomerName= item.CustomerName;
            e.Address=item.Address;
            e.PhoneNumber=item.PhoneNumber;

            return e;
        }
        public int AddCustomer(eCustomer kh)
        {

            var customerid = DB.tbl_Customers.Where(x => x.CustomerID == kh.CustomerID).FirstOrDefault();
            if (customerid != null)
            {
                return 0;
            }
            tbl_Customer khTmp = new tbl_Customer();
            khTmp.CustomerID = kh.CustomerID;
            khTmp.CustomerName = kh.CustomerName;
            khTmp.Address = kh.Address;
            khTmp.PhoneNumber = kh.PhoneNumber;

            DB.tbl_Customers.InsertOnSubmit(khTmp);
            DB.SubmitChanges();
            return 1;



        }
        public bool Delete(int deleteID)
        {
            try
            {
                tbl_Customer deletekh = DB.tbl_Customers.Single(x => x.CustomerID == deleteID);

                DB.tbl_Customers.DeleteOnSubmit(deletekh);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        public bool Update(eCustomer updatekh)
        {
            try
            {
                tbl_Customer updateKH = DB.tbl_Customers.Single(x => x.CustomerID == updatekh.CustomerID);

                updateKH.CustomerID = updatekh.CustomerID;
                updateKH.CustomerName = updatekh.CustomerName;
                updateKH.Address = updatekh.Address;
                updateKH.PhoneNumber = updatekh.PhoneNumber;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public List<eCustomer> searchCustomer(string cid)
        {
            List<eCustomer> ls = new List<eCustomer>();
            var list = from c in DB.tbl_Customers
                       where SqlMethods.Like(Convert.ToString(c.CustomerID), cid)
                       select c;
            foreach (tbl_Customer item in list)
            {
                eCustomer cus = new eCustomer();
                cus.CustomerID = item.CustomerID;
                cus.CustomerName = item.CustomerName;
                cus.Address = item.Address;
                cus.PhoneNumber = item.PhoneNumber;

                ls.Add(cus);

            }



            //var list = DB.tbl_Customers.Where(x => x.CustomerID.COn ));

            return ls;
        }

    }
}
