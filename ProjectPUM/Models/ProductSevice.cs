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
        public string InsertProduct(Product product)
        {
            try
            {

                db_MedbayEntities context = new db_MedbayEntities();
                context.Product.Add(product);
                context.SaveChanges();

                return product.Product_Name + " was succesfully inserted";
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
                db_MedbayEntities context = new db_MedbayEntities();

                Product oldProduct = context.Product.Find(id);

                oldProduct.Product_Name = product.Product_Name;
                oldProduct.PriceID = product.PriceID;
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
                Product deleteProduct = context.Product.Find(id);

                context.Product.Attach(deleteProduct);
                context.Product.Remove(deleteProduct);
                context.SaveChanges();

                return deleteProduct.Product_Name + "was succesfully deleted";
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
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    Product product = context.Product.Find(id);
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
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    List<Product> products = (from x in context.Product
                        select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<Product> GetProductsByCategory(int categoryId)
        {
            try
            {
                using (db_MedbayEntities context = new db_MedbayEntities())
                {
                    List<Product> products = (from x in context.Product
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