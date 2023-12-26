using BllNationalSymposium;
using ModelNationalSymposium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalSymposium
{
    public class Utility
    {
        public static string GetIpAddress()
        {
            HttpContext context = HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ipAddress))
                return context.Request.ServerVariables["REMOTE_ADDR"];
            string[] ipArray = ipAddress.Split(',');
            return ipArray[0];
        }
        public static DateTime GetMinDate()
        {
            return new DateTime(1753, 1, 1);
        }
        public static void ShowToastrSuccess(Page page, string message, string title, string subTitle = "", string type = "")
        {
            string s = "toastr.options = {'closeButton': false,'debug': false,'newestOnTop': true,'progressBar': true, 'positionClass': 'toast-top-right',   'preventDuplicates': false,  'onclick': null,  'showDuration': '800',  'hideDuration': '1000',  'timeOut': '8000', 'extendedTimeOut': '1000',  'showEasing': 'swing',  'hideEasing': 'linear',  'showMethod': 'fadeIn',  'hideMethod': 'fadeOut'}";
            ScriptManager.RegisterStartupScript(page, typeof(Page), "Alert" + title, $"<script>{s}; toastr.success('{message}', '{title}'," + " {timeOut: 5000})</script>", false);
        }
        public static void ShowToastrError(Page page, string message, string title, string subTitle = "", string type = "")
        {
            string s = "toastr.options = {'closeButton': false,'debug': false,'newestOnTop': true,'progressBar': true, 'positionClass': 'toast-top-right',   'preventDuplicates': false,  'onclick': null,  'showDuration': '800',  'hideDuration': '1000',  'timeOut': '8000', 'extendedTimeOut': '1000',  'showEasing': 'swing',  'hideEasing': 'linear',  'showMethod': 'fadeIn',  'hideMethod': 'fadeOut'}";
            ScriptManager.RegisterStartupScript(page, typeof(Page), "Alert" + title, $"<script>{s};toastr.error('{message}', '{title}'," + " {timeOut: 5000})</script>", false);
        }
        public static void ShowToastrWarning(Page page, string message, string title, string subTitle = "", string type = "")
        {
            string s = "toastr.options = {'closeButton': false,'debug': false,'newestOnTop': true,'progressBar': true, 'positionClass': 'toast-top-right',   'preventDuplicates': false,  'onclick': null,  'showDuration': '800',  'hideDuration': '1000',  'timeOut': '8000', 'extendedTimeOut': '1000',  'showEasing': 'swing',  'hideEasing': 'linear',  'showMethod': 'fadeIn',  'hideMethod': 'fadeOut'}";
            ScriptManager.RegisterStartupScript(page, typeof(Page), "Alert" + title, $"<script>{s};toastr.warning('{message}', '{title}'," + " {timeOut: 5000})</script>", false);
        }
        public static void ShowToastrInfo(Page page, string message, string title, string subTitle = "", string type = "")
        {
            string s = "toastr.options = {'closeButton': false,'debug': false,'newestOnTop': true,'progressBar': true, 'positionClass': 'toast-top-right',   'preventDuplicates': false,  'onclick': null,  'showDuration': '800',  'hideDuration': '1000',  'timeOut': '8000', 'extendedTimeOut': '1000',  'showEasing': 'swing',  'hideEasing': 'linear',  'showMethod': 'fadeIn',  'hideMethod': 'fadeOut'}";
            ScriptManager.RegisterStartupScript(page, typeof(Page), "Alert" + title, $"<script>{s};toastr.info('{message}', '{title}'," + " {timeOut: 5000})</script>", false);
        }

        public static void BindStates(DropDownList d)
        {
            List<State> lst = BllNS.GetState();
            d.Items.Clear();
            d.DataSource = lst;
            d.DataTextField = "StateName"; // Column name to display
            d.DataValueField = "JJM_StateId"; // Column name to use as the value
            d.DataBind();
            d.Items.Insert(0, new ListItem("Please select State", "0"));
        }

        public static void BindDesignation(DropDownList d)
        {
            List<Designation> lst = BllNS.GetDesignations();
            d.Items.Clear();
            d.DataSource = lst;
            d.DataTextField = "UserDesignation"; // Column name to display
            d.DataValueField = "Id"; // Column name to use as the value
            d.DataBind();
            d.Items.Insert(0, new ListItem("Please select Designation", "0"));
        }
        public static void BindOrganisation(DropDownList d)
        {
            List<Organization> lst = BllNS.GetOrganizations();
            d.Items.Clear();
            d.DataSource = lst;
            d.DataTextField = "OrganizationName"; // Column name to display
            d.DataValueField = "Id"; // Column name to use as the value
            d.DataBind();
            d.Items.Insert(0, new ListItem("Please select Organization", "0"));
        }
        public static void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;
               // mailMessage.Priority = 1;
                mailMessage.To.Add(new MailAddress(recepientEmail));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["Host"];
                smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
                NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
                smtp.Send(mailMessage);
            }
        }
    }
}