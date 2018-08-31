using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;


public partial class Pages_ContactUs : System.Web.UI.Page
{
    protected void Page_Load(Object sender, EventArgs e)
    {
        Session["Name"] = User.Identity.Name;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try{
           
            if(Page.IsValid)
            
        {
        MailMessage emailmessage = new MailMessage();
        emailmessage.From = new MailAddress("pat.nzediegwu@gmail.com");
        emailmessage.To.Add("patskinks@yahoo.com");
        emailmessage.Subject = txtsubject.Text;
        emailmessage.Body = "<b> Sender Name: <b/>" + txtname.Text + "<br/>"
            + "<b> Sender Email: <b/>" + txtemail.Text + "<br/>"
            + "<b> Comments: <b/>" + txtcomment.Text ;
        emailmessage.IsBodyHtml = true;

        
        SmtpClient smtpClient = new SmtpClient();
        smtpClient.EnableSsl = true;
        smtpClient.Port = 587;
        smtpClient.Host = "smtp.gmail.com";
        smtpClient.Timeout = 20000;
        smtpClient.Credentials = new System.Net.NetworkCredential("pat.nzediegwu@gmail.com"
            , "1nonyelum3");

        smtpClient.Send(emailmessage);

        Label1.ForeColor = System.Drawing.Color.Blue;
        Label1.Text = "Thank You for Contacting Us!";

        txtname.Enabled = false;
        txtemail.Enabled = false;
        txtcomment.Enabled = false;
        txtsubject.Enabled = false;
        btnSubmit.Enabled = false;
    }
            }
    catch (Exception ex)
{
        // log event
    Label1.ForeColor = System.Drawing.Color.Red;
    Label1.Text = "There happens to be a an Unknown Problem, Please try Later";

}
    }
}