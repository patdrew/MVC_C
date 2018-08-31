using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System.Web.UI.HtmlControls;
public partial class Pages_Item : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblShare.Text = "<a name=\"fb_share\" type=\"button\"></a>" +
                    "<script " +
                    "src=\"http://static.ak.fbcdn.net/connect.php/js/FB.Share\" " +
                    "type=\"text/javascript\"></script>";
        HtmlMeta tag = new HtmlMeta();
        tag.Name = "title";
        tag.Content = "This is the page title";
        Page.Header.Controls.Add(tag);
        HtmlMeta tag1 = new HtmlMeta();
        tag.Name = "description";
        tag.Content = "This is a page description.";
        Page.Header.Controls.Add(tag1);           
        setPage();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
             string userID = Context.User.Identity.GetUserId();

            if (userID != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
            int amount = Convert.ToInt32(ddlAmt.SelectedValue);

            Cart cart = new Cart
                    
            {
                Amount = amount,
                ClientID = userID,
                DatePurchased = DateTime.Now,
                IsInCart = true,
                ProductID = id
            };

            Cart_Model type = new Cart_Model();
            lblResults.Text = type.InsertCart(cart);
        }
           else
	              {
            lblResults.Text = "Please log in to continue to order items";
	              }
        }
    }

    private void setPage()
    {
        //get the current product details
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Prod_Model prod_item = new Prod_Model();
            Product product = prod_item.Get_Prod(id);

            //setup cuurent page
            lblPrice.Text = "Unit price: <br/>£ " + product.Price;
            lblTitle.Text = product.Name;
            lblDesc.Text = product.Description;
            lblIDno.Text = product.Id.ToString();
            imgProd.ImageUrl = "~/Images/ProductImg/" + product.Image;

            //to fill the amout ddl box with  amt of nos. from 1-20
            int[] noofitems = Enumerable.Range(1, 20).ToArray();
            ddlAmt.DataSource = noofitems;
            ddlAmt.AppendDataBoundItems = true;
            ddlAmt.DataBind();

        }
    }
   
}