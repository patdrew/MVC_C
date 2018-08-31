using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Management_Manage_TypeProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
      Prod_Types model = new Prod_Types();
      ProductType prdtyp = CreateProductType();

        lbl_Results.Text = model.InsertProductType(prdtyp);

    }
    private ProductType CreateProductType()
    {
    ProductType n = new ProductType();
    n.Name = txt_Name.Text;

    return n;
    }
}
