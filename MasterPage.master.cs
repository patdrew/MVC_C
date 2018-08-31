using System;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
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




        //////////////////////////////////////////////////////////////////////////
        var loggeduser = Context.User.Identity;
        
        if (loggeduser.IsAuthenticated)

        {
            linklogin.Visible = false;
            linkRegister.Visible = false;

            literalstat.Visible = true;
            btnLinklogout.Visible = true;

            Cart_Model model = new Cart_Model();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            literalstat.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                model.ObtainAmtofOrders(userId));
        }
        else
        {
            linklogin.Visible = true;
            linkRegister.Visible = true;

            literalstat.Visible = false;
            btnLinklogout.Visible = false;
        }
    }

    protected void Linklogout_Click(object sender, EventArgs e)
    {
        var authenManager = HttpContext.Current.GetOwinContext().Authentication;
        authenManager.SignOut();
        Response.Redirect("~/Index.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["searchKey"] = TextBox1.Text;
        Response.Redirect("~/Pages/Search.aspx");
    }
}
