using BllNationalSymposium;
using ModelNationalSymposium;
using NationalSymposium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NSSWC
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                // Redirect the authenticated user to the next page
                Response.Redirect(ConstString.AuthUserPage);
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            UserLogin ul = BllNS.GetUserDetails(username,password);
            if (ul != null)
            {
                Session.Add(ConstString.SessionUser, ul);
                if (ul.RoleId == ConstString.Admin)
                {
                   // Session["username"] = txtUserName.Text;
                    Response.Redirect(ConstString.AdminPage, false);
                }
                else if (ul.RoleId == ConstString.User && rememberme.Checked == true)
                {
                    HttpCookie co = new HttpCookie(ul.EmailId, ul.HashPassword);
                    co.Expires = DateTime.Now.AddDays(5);
                    Response.Cookies.Add(co);
                    //Session["username"] = txtUserName.Text;
                    Response.Redirect(ConstString.UserPage, false);
                }
                else if (rememberme.Checked == false)
                {
                    //Session["username"] = txtUserName.Text;
                    Response.Redirect(ConstString.UserPage, false);
                }
            }
            else
            {
                Utility.ShowToastrError(this, "Invalid Login", "Error");
            }
        }
    }


}