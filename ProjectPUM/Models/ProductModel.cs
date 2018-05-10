﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;

namespace ProjectPUM.Models
{
    public class ProductModel
    {
        public string InsertProduct(Product product)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();
                db.Products.Add(product);
                db.SaveChanges();

                return product.Name + " was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateProduct(int id, Product product)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();

                //Fetch object from db
                Product p = db.Products.Find(id);

                p.Name = product.Name;
                p.Price = product.Price;
                p.TypeID = product.TypeID;
                p.Description = product.Description;
                p.Image = product.Image;

                db.SaveChanges();
                return product.Name + " was succesfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProduct(int id)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();
                Product product = db.Products.Find(id);

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.Name + " was succesfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                using (MedShopEntities db = new MedShopEntities())
                {
                    Product product = db.Products.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (MedShopEntities db = new MedShopEntities())
                {
                    List<Product> products = (from x in db.Products
                                              select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetProductsByType(int typeId)
        {
            try
            {
                using (MedShopEntities db = new MedShopEntities())
                {
                    List<Product> products = (from x in db.Products
                                              where x.TypeID == typeId
                                              select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}