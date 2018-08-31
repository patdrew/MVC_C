using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;



public partial class Pages_AccountManagement_RegisterUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        UserStore<IdentityUser> storeusers = new UserStore<IdentityUser>();

        storeusers.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.
            ConnectionStrings["ElectronicaConnectionString"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(storeusers);

        //to create new users
        IdentityUser newuser = new IdentityUser();
        newuser.UserName = txtuser_name.Text;

        if (txt_pass.Text == txtconfirm.Text)
        {
            try
            {
                //develop user object 
                IdentityResult outcome = manager.Create(newuser, txt_pass.Text);

                if(outcome.Succeeded)

                {
                    UserSpecific info = new UserSpecific
                    {
                        Address = textaddress.Text,
                        FirstName = textfirstname.Text,
                        LastName = textlastname.Text,
                        PostCode = textpostcode.Text,
                        DGK = newuser.Id,
                        Email = txtemail.Text
                        
                    };

                    UserDetailInfo typemodel = new UserDetailInfo();
                    typemodel.ToInsertUserSpecifics(info);
                    //user to enter db
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                    //user to login with cookies
                    var userIdentity = manager.CreateIdentity(newuser, DefaultAuthenticationTypes.ApplicationCookie);

                  //  login user and direct to  shop
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("~/Index.aspx");
                    
                }
                else
                {
                    literalstat.Text = outcome.Errors.FirstOrDefault();

                }

            }
            catch (Exception except)
            {

                literalstat.Text = except.ToString();

            }
        }

        else
        {
            literalstat.Text = "Passwords must match to continue";
        }
    }
}