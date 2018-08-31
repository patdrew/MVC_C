using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Prod_Model
/// </summary>
public class Prod_Model
{
	
		public string InsertProduct(Product product)
        {
            try
            {
ElectronicaEntities db = new ElectronicaEntities();
           db.Products.Add(product);
           db.SaveChanges();

           return product.Name + " was successfully inserted into the database";
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
                ElectronicaEntities db = new ElectronicaEntities();
            
                //Fetch objects from the database

                Product n = db.Products.Find(id);
                n.Name = product.Name;
                n.Price = product.Price;
                n.TypeId = product.TypeId;
                n.Description = product.Description;
                n.Image = product.Image;

                db.SaveChanges();
                return product.Name + "was successfully updated";

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
ElectronicaEntities db = new ElectronicaEntities();
                Product product = db.Products.Find(id);

                db.Products.Attach (product);
                db.Products.Remove (product);
                db.SaveChanges();
               
                return product.Name + " was successfully deleted";
            
            }

            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
            public Product Get_Prod(int id)
        {
            try
            {
                using (ElectronicaEntities db = new ElectronicaEntities())
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
            public List<Product> GetAlloftheProducts()
            {
                try
                {
                    using (ElectronicaEntities db = new ElectronicaEntities())
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

            public List<Product> GetAlloftheProductsByType(int typeId)
            {
                try
                {
                    using (ElectronicaEntities db = new ElectronicaEntities())
                    {
                        List<Product> products = (from x in db.Products
                                                  where x.TypeId == typeId
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