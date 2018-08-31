using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Management_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gridProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //get the row selected
        GridViewRow row = grdProducts.Rows[e.NewEditIndex];

        // get the ID of the selected product
        int rowId = Convert.ToInt32(row.Cells[1].Text);

        //redirect all users to the manageproducts page along with the selected rowID
        Response.Redirect("~/Pages/Admin/Manage_Products.aspx?id=" + rowId);
    }
}