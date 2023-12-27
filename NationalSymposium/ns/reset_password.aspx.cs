using BllNationalSymposium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalSymposium.ns
{
    public partial class reset_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {
            if (Request.QueryString["e"] != null)
            {
                ViewState[ConstString.VsUserEmail] = Guid.Parse(Request.QueryString["e"]);
            }
        }
        protected void btnReset_OnClick(object sender, EventArgs e)
        {
            string a = BllNS.Sp_ForgotPassword(Convert.ToString(ViewState[ConstString.VsUserEmail]), txtNewPassword.Text);
            if (a != "Success")
            {
                //lblMsg.Text = "Not Success";
                Utility.ShowToastrError(this, "Not Success", "Error");
            }
            else
            {
                lblMsg.Text = $"Password Changed Successfully. <a href={ConstString.LoginPage}>Click Here</a> to login";
            }
        }
    }
}