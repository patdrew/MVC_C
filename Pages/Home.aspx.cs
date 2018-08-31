using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Pages_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Name"] = User.Identity.Name;
        if (!IsPostBack)
        {
            SetImageUrl();
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {


        SetImageUrl();
    }

    private void SetImageUrl()
    {
        if (ViewState["ImageDisplayed"] == null)
        {
            Image1.ImageUrl = "~/Images/SShow/1.jpg";
            ViewState["ImageDisplayed"] = 1;
            Label1.Text = "Displaying Image - 1";
        }
        else
        {
            int i = (int)ViewState["ImageDisplayed"];
            if (i == 5)
            {
                Image1.ImageUrl = "~/Images/SShow/1.jpg";
                ViewState["ImageDisplayed"] = 1;
                Label1.Text = "Displaying Image - 1";
            }
            else
            {
                i = i + 1;
                Image1.ImageUrl = "~/Images/SShow/" + i.ToString() + ".jpg";
                ViewState["ImageDisplayed"] = i;
                Label1.Text = "Displaying Image - " + i.ToString();
            }
        }

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        // If timer is enabled, disable timer and change 
        // the text on the button control accordingly
        if (Timer1.Enabled)
        {
            Timer1.Enabled = false;
            Button1.Text = "Start Slideshow";
        }
        // If timer is disabled, enable timer and change 
        // the text on the button control accordingly
        else
        {
            Timer1.Enabled = true;
            Button1.Text = "Stop Slideshow";
        }
    }
    
}