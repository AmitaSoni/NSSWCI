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
       // MyConnection db = new MyConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                // Redirect the authenticated user to the next page
                Response.Redirect("~/User_Page.aspx");
            }

            
        }
           
        
        protected void Btn_login_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=10.22.3.161;User Id=adg;Password=adg;Initial Catalog=NSSWCI;Integrated Security=false;");
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            
                try
                {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                        string username = Text_Username.Text.Trim();
                        string password = Text_Password.Text.Trim();
                        SqlCommand command = new SqlCommand("SP_UserLogin", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        command.Parameters.AddWithValue("@pEmailId", username);
                        command.Parameters.AddWithValue("@pHashPassword", password);
                        SqlDataReader rd = command.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Read();
                            if (rd[5].ToString() == ConstString.Admin)
                            {
                            lblmessage.Text = "File uploaded successfully!";
                            Session["username"] = Text_Username.Text;
                           // Session["Organisation"] = Text_Username.Text;



                                Response.Redirect("Admin_Page.aspx", false);
                            }


                            else if (rd[5].ToString() == ConstString.User && rememberme.Checked == true)
                            {
                                HttpCookie co = new HttpCookie(Text_Username.Text, Text_Password.Text);
                                co.Expires = DateTime.Now.AddDays(5);
                                Response.Cookies.Add(co);
                                Session["username"] = Text_Username.Text;
                                Response.Redirect("User_Page.aspx", false);
                            }
                            else if (rememberme.Checked == false)
                            {
                                Session["username"] = Text_Username.Text;
                                Response.Redirect("User_Page.aspx", false);
                            }
                        }

                        else
                        {
                        // Invalid credentials
                        lblmessage.Text = "Invalid username & password";
                        }


                    }
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            

            
        }

        
        protected void Btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void Btn_forgetpassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgot_password.aspx");
        }
    }

    
} 