using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net.Mail;
using BllNationalSymposium;
using ModelNationalSymposium;
using System.Configuration.Provider;
using System.Configuration;
using System.Security.Policy;


namespace NationalSymposium.ns
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            Utility.BindStates(ddlStates);
            Utility.BindDesignation(ddlDesignation);
            Utility.BindOrganisation(ddlOrganization);
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Registrations registrations = new Registrations();
            registrations.Name = txtName.Text;
            registrations.EmailId = txtemail.Text;
            registrations.HashPassword = txtpassword.Text;
            registrations.Organization = Convert.ToInt32(ddlOrganization.SelectedValue);
            registrations.CreatedOn = DateTime.Now;
            registrations.UpdatedOn = Utility.GetMinDate();
            registrations.MobileNo = Convert.ToInt64(txtMobile.Text);
            registrations.Participants = Convert.ToInt32(rdbParticipants.SelectedValue);
            registrations.Designation = Convert.ToInt32(ddlDesignation.SelectedValue);
            registrations.State = Convert.ToInt32(ddlStates.SelectedValue);
            int i = BllNS.SetUserRegistration(registrations);
            int radioButtonValue = registrations.Participants;
            if (i > 0)
            {
                if (radioButtonValue == ConstString.Speaker)
                {
                    Utility.SendHtmlFormattedEmail(txtemail.Text, "Registration Successful", PopulateBody(txtName.Text, txtemail.Text, txtpassword.Text));
                    Response.Redirect("Login.aspx");
                }
                else
                    Utility.ShowToastrSuccess(this, "Registration Successful", "Success");

            }
            else
            {
                Utility.ShowToastrError(this, "Register Not Success", "Error");
            }
            Clear();

        }
        public void Clear()
        {
            txtName.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtMobile.Text = string.Empty;
            ddlStates.SelectedIndex = -1;
            ddlOrganization.SelectedIndex = -1;
            ddlDesignation.SelectedIndex = -1;
            rdbParticipants.SelectedIndex = -1;
        }

        private string PopulateBody(string userName, string email, string password)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/register_success.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{EmailId}", email);
            body = body.Replace("{Password}", password);
            return body;
        }
    }
}