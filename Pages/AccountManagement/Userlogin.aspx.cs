using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

public partial class Pages_AccountManagement_Userlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        UserStore<IdentityUser> storeusers = new UserStore<IdentityUser>();

        storeusers.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.
            ConnectionStrings["ElectronicaConnectionString"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(storeusers);

        var newuser = manager.Find(txtuser_name.Text, txt_pass.Text);
        if (storeusers != null)
        {
            //to call the own database
            var authenmanager = HttpContext.Current.GetOwinContext().Authentication;
            var newuserId = manager.CreateIdentity(newuser, DefaultAuthenticationTypes.ApplicationCookie);

            //to sign in a genuine user
            authenmanager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = false
                }
                , newuserId)
                ;
            //redirect logged in users to shop
            Response.Redirect("~/Index.aspx");
        }
        else
	{
            Literalstat.Text= "Incorrect username or password entered";
	}
    }
}