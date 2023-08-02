using Shopee_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopee_Food.Areas.Admin.map
{
    public class mapTaiKhoan
    {
        public Users ChiTiet(string TaiKhoan)
        {
            try
            {
                DBShopeeFoodEntities db = new DBShopeeFoodEntities();
                var data = db.User.SingleOrDefault(m => m.TaiKhoan == TaiKhoan);
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}