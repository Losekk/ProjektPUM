using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ProjectPUM.Models
{
    public class CustomerService
    {
        public Customer GetUserInformation(string userID)
        {
            db_MedbayEntities db = new db_MedbayEntities();
            var info = (from x in db.Customer
                where x.UserID == userID
                select x).FirstOrDefault();
            return info;
        }
        public void InsertCustomer(Customer customer)
        {
            db_MedbayEntities db = new db_MedbayEntities();
            db.Customer.Add(customer);
            db.SaveChanges();
        }

    }
}