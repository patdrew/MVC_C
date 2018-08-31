using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Prod_Types
/// </summary>
public class Prod_Types
{
	
		public string InsertProductType(ProductType productType)
        {
            try
            {
ElectronicaEntities db = new ElectronicaEntities();
           db.ProductTypes.Add(productType);
           db.SaveChanges();

           return productType.Name + "was successfully inserted into the database";
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
                ElectronicaEntities db = new ElectronicaEntities();
            
                //Fetch objects from the database

                ProductType n = db.ProductTypes.Find(id);
                n.Name = productType.Name;
               

                db.SaveChanges();
                return productType.Name + "was successfully updated";

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
ElectronicaEntities db = new ElectronicaEntities();
                ProductType productType = db.ProductTypes.Find(id);

                db.ProductTypes.Attach (productType);
                db.ProductTypes.Remove (productType);
                db.SaveChanges();
               
                return productType.Name + "was successfully deleted";
            
            }

            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        }