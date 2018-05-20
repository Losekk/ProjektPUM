using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;

namespace ProjectPUM.Models
{
    public class CartService
    {

        public string InsertCart(Cart cart)
        {
            try
            {
                db_MedbayEntities db = new db_MedbayEntities();
                db.Cart.Add(cart);
                db.SaveChanges();

                return "Order was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}