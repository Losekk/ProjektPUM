using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ProjectPUM.Models
{
    public class ProductSevice
    {
        public string InsertProduct(Products product)
        {
            try
            {

                db_MedbayEntities context = new db_MedbayEntities();
                context.Products.Add(product);
                context.SaveChanges();

                return product.Product_Name + " was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateProduct(int id, Products product)
        {
            try
            {
                db_MedbayEntities context = new db_MedbayEntities();

                Products oldProduct = context.Products.Find(id);

                oldProduct.Product_Name = product.Product_Name;
                oldProduct.Price = product.Price;
                oldProduct.Product_Description = product.Product_Description;
                oldProduct.PictureFileName = product.PictureFileName;
                oldProduct.CategoryID = product.CategoryID;


                context.SaveChanges();
                return product.Product_Name + " was succesfully updated";

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
                db_MedbayEntities context = new db_MedbayEntities();
                Products deleteProduct = context.Products.Find(id);

                context.Products.Attach(deleteProduct);
                context.Products.Remove(deleteProduct);
                context.SaveChanges();

                return deleteProduct.Product_Name + "was succesfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public Products GetProduct(int id)
        {
            try
            {
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    Products product = context.Products.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Products> GetAllProducts()
        {
            try
            {
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    List<Products> products = (from x in context.Products
                                               select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<Products> GetProductsByCategory(int categoryId)
        {
            try
            {
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    List<Products> products = (from x in context.Products
                                               where x.CategoryID == categoryId
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