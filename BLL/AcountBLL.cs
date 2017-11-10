using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class AcountBLL
    {
        VideoRentalDataContext DB = new VideoRentalDataContext();
        public List<eUser> GetAllTaiKhoan()
        {
            var tmp = DB.tbl_Users.ToList();
            List<eUser> lstk = new List<eUser>();
            foreach (tbl_User user in tmp)
            {
                eUser us = new eUser();
                us.UserName = user.Username;
                us.PassWord = user.Password;
              
                lstk.Add(us);
            }
            return lstk;
        }
        public int KiemTraDangNhap(string id, string pass)
        {
            var tmp = DB.tbl_Users.Where(x => x.Username == id && x.Password == pass).FirstOrDefault();
            if (tmp == null)
                return 0;
            else
            {
                return 1;
            }
        }
    }
}
