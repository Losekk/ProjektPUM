using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;

namespace ProjectPUM.Models
{
    public class UserDetailModel
    {
        public UserDetail GetUserInformation(string guId)
        {
            MedShopEntities db = new MedShopEntities);
            var info = (from x in db.UserDetails
                        where x.Guid == guId
                        select x).FirstOrDefault();
            return info;
        }

        public void InsertUserDetail(UserDetail userDetail)
        {
            MedShopEntities db = new MedShopEntities();
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
        }
    }
}