using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;



public partial class Pages_Trolley : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Name"] = User.Identity.Name;
        if (!Request.IsSecureConnection)
        {
            string url = "https:"
                + ConfigurationManager.AppSettings["SecureAppPath"]
                + "Trolley.aspx";
            Response.Redirect(url);
        }
        //To see if user is logged
        string userId = User.Identity.GetUserId();

        //Show users cart
        PullallSalestoTrolley(userId);
    }

    private void PullallSalestoTrolley(string userId)
    {
        //create page for each item in orderlist
        Cart_Model type = new Cart_Model();
        double AmtTotal = 0;

        List<Cart> orderList = type.ObtainCartOrders(userId);
        OrganiseCartWindow(orderList, out  AmtTotal);

        //add amtTotal to page .. remember sumtotal is the total amt..
       // AmtTotal is just an amout for The item
        double tax = AmtTotal * 0.2;
        double sumTotal = AmtTotal + tax + 20;

        //show total amt with a literal
        literaltot.Text = "£" + AmtTotal;
        literalVat.Text = "£" + tax;
        literalTotAmt.Text = "£" + sumTotal;
    }

    private void OrganiseCartWindow(List<Cart>orderList, out double AmtTotal)
    {
        AmtTotal = new Double();
        Prod_Model type = new Prod_Model();

        foreach (Cart cart in orderList)
        {
            //get databse data o fill page
            Product product = type.Get_Prod(cart.ProductID);
           
            //for the item image
            ImageButton buttonImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/ProductImg/{0}", product.Image),
                PostBackUrl = string.Format("~/Pages/Item.aspx?id={0}", product.Id)
            };

            // delete cart items
            LinkButton linkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/Trolley.aspx?productId={0}", cart.ID),
                Text = "Remove Item",
                ID = "no" + cart.ID,
            };

            //onclick events

            linkDelete.Click += Remove_Product;

            //Make a dropdownlist
            //list from numbers 1-20
            int[] itemamount = Enumerable.Range(1, 20).ToArray();
            DropDownList dropdownlistAmnt = new DropDownList
            {
                DataSource = itemamount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.ID.ToString()
            };
            dropdownlistAmnt.DataBind();
            dropdownlistAmnt.SelectedValue = cart.Amount.ToString();
            dropdownlistAmnt.SelectedIndexChanged += dropdownlistAmnt_SelectdIndxChang;


            //populate cart details table with data
            //this is for table with 2 rows.. called lane
            Table datawindow = new Table { CssClass = "CartWindow" };
            TableRow laneA = new TableRow();
            TableRow laneB = new TableRow();

            //create a six celled row for the first row.. called pane
            TableCell pane1 = new TableCell { RowSpan = 2, Width = 51 };
            TableCell pane2 = new TableCell
            {
                Text = string.Format("<h4>{0}</h4><br />{1}<br/>Item In Stock",
                    product.Name, "Product No:" + product.Id),
                HorizontalAlign = HorizontalAlign.Left,
                Width = 351,
            };
            TableCell pane3 = new TableCell { Text = "Price per Unit<hr/>" };
            TableCell pane4 = new TableCell { Text = "Quantity<hr/>" };
            TableCell pane5 = new TableCell { Text = "Item *Total<hr/>" };
            TableCell pane6 = new TableCell();

            //to create a six celled row for the second row.. called panea..z
            TableCell panea1 = new TableCell();
            TableCell paneb2 = new TableCell { Text = "£ " + product.Price };
            TableCell panec3 = new TableCell();
            TableCell paned4 = new TableCell { Text = "£ " + Math.Round((cart.Amount  * (double)product.Price)) };
            TableCell panee5 = new TableCell();
            TableCell panef6 = new TableCell();

            //Set customized controls
            pane1.Controls.Add(buttonImage);
            pane6.Controls.Add(linkDelete);
            panec3.Controls.Add(dropdownlistAmnt);

            //make some rows & cells to table
            laneA.Cells.Add(pane1);
            laneA.Cells.Add(pane2);
            laneA.Cells.Add(pane3);
            laneA.Cells.Add(pane4);
            laneA.Cells.Add(pane5);
            laneA.Cells.Add(pane6);

            laneB.Cells.Add(panea1);
            laneB.Cells.Add(paneb2);
            laneB.Cells.Add(panec3);
            laneB.Cells.Add(paned4);
            laneB.Cells.Add(panee5);
            laneB.Cells.Add(panef6);

            

            //create rows
            datawindow.Rows.Add(laneA);
            datawindow.Rows.Add(laneB);

            //display created table in panel
            paneltrolley.Controls.Add(datawindow);

            //Add total of current purchased item to subtotal
            AmtTotal += (cart.Amount * (double)product.Price);
            
         }

        //Add the utems to session
        Session[User.Identity.GetUserId()] = orderList;
    }

    private void Remove_Product(object sender, EventArgs e)
    {
        LinkButton highlightedLink = (LinkButton)sender;
        string link = highlightedLink.ID.Replace("no", "");
        int cartId = Convert.ToInt32(link);

        Cart_Model removemodel = new Cart_Model();
        removemodel.DeleteCart(cartId);
        
        Response.Redirect("~/Pages/Trolley.aspx");
    }

    private void dropdownlistAmnt_SelectdIndxChang(object sender, EventArgs e)
    {
        //id of item that has quantity changed in ddl list
        DropDownList quantityList = (DropDownList)sender;
        int cartId = Convert.ToInt32(quantityList.ID);
        int cartquantity = Convert.ToInt32(quantityList.SelectedValue);

        //Update purchase with new quantity and refresh page
        Cart_Model updatecart = new Cart_Model();
        updatecart.UpdateCartQuantity(cartId, cartquantity);
        Response.Redirect("~/Pages/Trolley.aspx");
    }

 

}