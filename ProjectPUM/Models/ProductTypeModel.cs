using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPUM.Database;

namespace ProjectPUM.Models
{
    public class ProductTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();
                db.ProductTypes.Add(productType);
                db.SaveChanges();

                return productType.Name + "was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateProductType(int id, ProductType productType)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();

                //Fetch object from db
                ProductType p = db.ProductTypes.Find(id);

                p.Name = productType.Name;

                db.SaveChanges();
                return productType.Name + "was succesfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProductType(int id)
        {
            try
            {
                MedShopEntities db = new MedShopEntities();
                ProductType productType = db.ProductTypes.Find(id);

                db.ProductTypes.Attach(productType);
                db.ProductTypes.Remove(productType);
                db.SaveChanges();

                return productType.Name + "was succesfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}