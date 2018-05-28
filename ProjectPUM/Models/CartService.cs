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

        public string DeleteCart(int id)
        {
            try
            {
                db_MedbayEntities db = new db_MedbayEntities();
                Cart cart = db.Cart.Find(id);

                db.Cart.Attach(cart);
                db.Cart.Remove(cart);
                db.SaveChanges();

                return "Cart was succesfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateCart(int id, Cart cart)
        {
            try
            {
                db_MedbayEntities db = new db_MedbayEntities();

                //Fetch object from db
                Cart p = db.Cart.Find(id);

                
                p.CustomerID = cart.CustomerID;
                p.Quantity = cart.Quantity;
                p.ProductID = cart.ProductID;
                p.Products = cart.Products;
                db.SaveChanges();
                return "Cart was succesfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            db_MedbayEntities db = new db_MedbayEntities();
            Cart p = db.Cart.Find(id);
            p.Quantity = quantity;

            db.SaveChanges();
        }

        public List<Cart> GetOrdersInCart(string clientId)
        {
            db_MedbayEntities db = new db_MedbayEntities();
            List<Cart> orders = (from x in db.Cart
                                 where x.CustomerID == clientId
                                 select x).ToList();
            return orders;
        }



    }
}