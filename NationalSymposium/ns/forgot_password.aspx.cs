using BllNationalSymposium;
using ModelNationalSymposium;
using NationalSymposium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalSymposium.ns
{
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_OnClick(object sender, EventArgs e)
        {
            string a = BllNS.GetUserLoginByEmailId(txtEmail.Text);
            if (a != "Exist")
            {
                lblMsg.Text = "This email is not registered with us.";
            }
            else
            {
                lblMsg.Text = "Email has forwarded to your registered Email Id to reset the password.";
                var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
                string url = baseUrl+"?e = " + txtEmail.Text;
                Utility.SendHtmlFormattedEmail(txtEmail.Text, "Forgot Password", PopulateBody(txtEmail.Text, url));
                txtEmail.Text = string.Empty;
            }
        }
        private string PopulateBody(string userName, string url)
        {
            string body = string.Empty;
            string path = Server.MapPath("~/forgotpassword.html");
            using (StreamReader reader = new StreamReader(Server.MapPath("~/forgotpassword.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{Url}", url);
            return body;
        }
        //private void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
        //{
        //    using (MailMessage mailMessage = new MailMessage())
        //    {
        //        mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
        //        mailMessage.Subject = subject;
        //        mailMessage.Body = body;
        //        mailMessage.IsBodyHtml = true;
        //        mailMessage.To.Add(new MailAddress(recepientEmail));
        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = ConfigurationManager.AppSettings["Host"];
        //        smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
        //        System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
        //        NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
        //        NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
        //        smtp.UseDefaultCredentials = true;
        //        smtp.Credentials = NetworkCred;
        //        smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
        //        smtp.Send(mailMessage);
        //    }
        //}
    }
}