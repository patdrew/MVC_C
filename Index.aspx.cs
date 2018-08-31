using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Name"] = User.Identity.Name;
        
        SetupPage();
        //testing
        if (!this.IsPostBack)

{



var db = new ElectronicaEntities();

{

var productType = db.ProductTypes

.Select(x => new {typeId = x.Id,Name = x.Name}).ToList();
    
ddlTypes.DataValueField = "typeId";

ddlTypes.DataTextField = "Name";

ddlTypes.DataSource = productType;

ddlTypes.DataBind();
}

}

}

//the rest of the rest of the code go in the ddlTypes_SelectedIndexChanged 


    protected void ddlTypes_SelectedIndexChanged(object sender, EventArgs e)
    {

        //Get list of products by type

        Prod_Model productModel = new Prod_Model();

        List<Product> products = productModel.GetAlloftheProductsByType(Int32.Parse(ddlTypes.SelectedValue));



        //Make sure product exist in DB

        if (products != null)
        {

            //Create new Panel 

            foreach (Product product in products)
            {

                Panel productPanel = new Panel();

                ImageButton imageButton = new ImageButton();

                Label lblName = new Label();

                Label lblPrice = new Label();
            }
        }
    }

//Set child control properties



//GetProductsByType function looks like this, you insert it in ProductModel

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

/// <summary>
/// ///////////////////////////////////////////////////////////////////////////////////////
/// </summary>
private void SetupPage()
{
    //to show all products in the database..
    Prod_Model prod_model = new Prod_Model();
    List<Product> products = prod_model.GetAlloftheProducts();

    //to make sure the products are in the database as before
    if (products != null)
    {
        //to create a new panel area with 2 labels for price and descrition and an image
        foreach (Product product in products)
        {
            Panel prod_Panel = new Panel();
            ImageButton img_Button = new ImageButton();
            Label lblName = new Label();
            Label lblprice = new Label();

            // properties for childcontrols

            img_Button.ImageUrl = "~/Images/ProductImg/" + product.Image;
            img_Button.CssClass = "prodImg";
            img_Button.PostBackUrl = "~/Pages/Item.aspx?id=" + product.Id;

            lblName.Text = product.Name;
            lblName.CssClass = "prodNme";

            lblprice.Text = "£" + product.Price;
            lblprice.CssClass = "prodPrice";

            //panel child controls
            prod_Panel.Controls.Add(img_Button);
            prod_Panel.Controls.Add(new Literal { Text = "<br/>" });
            prod_Panel.Controls.Add(lblName);
            prod_Panel.Controls.Add(new Literal { Text = "<br/>" });
            prod_Panel.Controls.Add(lblprice);

            //to make panels dynamic

            panlProds.Controls.Add(prod_Panel);

        }
    }

    else
    {
        //in the event no product is found
        panlProds.Controls.Add(new Literal { Text = "No products are available" });
    }
}


    
}

//Michael.W (2014) Asp.net Development. Accessed from: http://codeshedforums.proboards.com/thread/28/create-webshop-asp-net-owin Accessed on: 15/03/2014