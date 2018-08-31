using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart_Model
/// </summary>
public class Cart_Model
{
	public string InsertCart(Cart cart)
        {
            try
            {
ElectronicaEntities db = new ElectronicaEntities();
           db.Carts.Add(cart);
           db.SaveChanges();

           return  "was successfully added to the cart";
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
                ElectronicaEntities db = new ElectronicaEntities();
            
                //Fetch objects from the database

                Cart n = db.Carts.Find(id);

                n.DatePurchased = cart.DatePurchased;
                n.ClientID = cart.ClientID;
                n.Amount = cart.Amount;
                n.IsInCart = cart.IsInCart;
                n.ProductID = cart.ProductID;


                db.SaveChanges();
                return cart.DatePurchased + "was successfully updated";

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
ElectronicaEntities db = new ElectronicaEntities();
                Cart cart = db.Carts.Find(id);

                db.Carts.Attach (cart);
                db.Carts.Remove (cart);
                db.SaveChanges();
               
                return cart.DatePurchased  + "was successfully deleted";
            
            }

            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

    public List<Cart> ObtainCartOrders(string userId)
        {
            ElectronicaEntities db = new ElectronicaEntities();
            List<Cart> purchases = (from x in db.Carts
                                 where x.ClientID == userId
                                 && x.IsInCart
                                 orderby x.DatePurchased descending
                                 select x).ToList();
            return purchases;
        }
    public int ObtainAmtofOrders(string userId)
    {
        try
        {
            ElectronicaEntities db = new ElectronicaEntities();
            int billamt = (from x in db.Carts
                          where x.ClientID == userId
                          && x.IsInCart
                          select x.Amount).Sum();

            return billamt;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateCartQuantity(int id, int quantity)
    {
        ElectronicaEntities db = new ElectronicaEntities();
        Cart n = db.Carts.Find(id);
        n.Amount = quantity;

        db.SaveChanges();
    }

    public void RecordOrdersAsPaidfor (List<Cart> carts)
    {
        ElectronicaEntities db = new ElectronicaEntities();

        if (carts != null)
        {
            foreach (Cart cart in carts)
            {
                Cart exCart = db.Carts.Find(cart.ID);
                exCart.DatePurchased = DateTime.Now;
                exCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    
    }
 }