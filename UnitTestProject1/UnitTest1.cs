using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPUM.Database;
using ProjectPUM.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer
            {


                FirstName = "akakka",
                LastName = "akakak",
                UserID = "skasksaksak",
                PhoneNumber = "",
                Email = "",
                Adress = new Adress
                {
                    Street = "",
                    Number = "",
                    City = "",
                    PostalCode = ""
                }


            };

            db_MedbayEntities db = new db_MedbayEntities();
            db.Customer.Add(customer);
        }
    }
}
