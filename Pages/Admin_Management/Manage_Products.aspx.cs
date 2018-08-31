using System;
using System.Collections;
using System.IO;


public partial class Pages_Admin_Management_Manage_Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CollectImages();
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"])) 
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                SetPage(id);
            }
        }
}

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Prod_Model prod_model = new Prod_Model();
        Product product = CreatePrpduct();

        //to check if url contains an id
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            //when an ID exists-- update certain row
            int id = Convert.ToInt32(Request.QueryString["id"]);
            lblResult.Text = prod_model.UpdateProduct(id, product);     
        }
        else 
        {
            //here id does noot exist.. create a new row
            lblResult.Text = prod_model.InsertProduct(product);

        }


    }

    private void SetPage(int id)
    {
        //to get the selected product from the database
        Prod_Model prod_model = new Prod_Model();
        Product product = prod_model.Get_Prod(id);

        // fill all the textboxes
        txtDescription.Text = product.Description;
        txtName.Text = product.Name;
        txtPrice.Text = product.Price.ToString();

        // to set the values of the dropdown list
        ddlImage.SelectedValue = product.Image;
        ddlTypes.SelectedValue = product.TypeId.ToString();

    }

    private void CollectImages()
    {
        try
            {
            // to get the filepaths of images
                string[] prod_Images = Directory.GetFiles(Server.MapPath("~/Images/ProductImg/"));

            //Get all filenames before adding them to arraylist
            ArrayList ListofImages = new ArrayList();
            foreach (string image in prod_Images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                ListofImages.Add(imageName);
            }
            // to set arraylist as a dropdownlist that can be refreshed
            ddlImage.DataSource = ListofImages;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();
        }
        catch (Exception e)
        {
            lblResult.Text = e.ToString();
        }

    }
    private Product CreatePrpduct()
    {
        Product product = new Product();

        product.Name = txtName.Text;
        product.Price = Convert.ToInt32(txtPrice.Text);
        product.TypeId = Convert.ToInt32(ddlTypes.SelectedValue);
        product.Description = txtDescription.Text;
        product.Image = ddlImage.SelectedValue;

        return product;
    }
    

}