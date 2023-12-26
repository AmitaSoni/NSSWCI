using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace NSSWC
{
    
    public partial class User_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call the method to fetch data from the database
                FetchDataFromDatabase();
                BindDropDown();
                BindDropDown1();
                BindDropDown2();
            }
            if (CheckAuthentication())
            {
                sUser.InnerText= Convert.ToString(Session["username"]);

            }
            

        }
        private void BindDropDown()
        {
            // Replace "YourConnectionString" with your actual connection string
           // SqlConnection conn = new SqlConnection("Data Source=10.22.3.161;User Id=adg;Password=adg;Initial Catalog=NSSWCI;Integrated Security=false;");
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_States]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtCategories = new DataTable();
                    conn.Open();
                    // connection.Open();
                    dtCategories.Load(cmd.ExecuteReader());

                    ddlCategories.DataSource = dtCategories;
                    ddlCategories.DataTextField = "StateName"; // Column name to display
                    ddlCategories.DataValueField = "JJM_StateId"; // Column name to use as the value
                    ddlCategories.DataBind();
                }
            }

        }

        private void BindDropDown1()
        {
            // Replace "YourConnectionString" with your actual connection string
            //SqlConnection conn = new SqlConnection("Data Source=10.22.3.161;User Id=adg;Password=adg;Initial Catalog=NSSWCI;Integrated Security=false;");
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Designations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtCategories = new DataTable();

                    conn.Open();
                    dtCategories.Load(cmd.ExecuteReader());

                    ddlCategories1.DataSource = dtCategories;
                    ddlCategories1.DataTextField = "Designation"; // Column name to display
                    ddlCategories1.DataValueField = "Id"; // Column name to use as the value
                    ddlCategories1.DataBind();
                }
            }

        }

        private void BindDropDown2()
        {
            // Replace "YourConnectionString" with your actual connection string
            //SqlConnection conn = new SqlConnection("Data Source=10.22.3.161;User Id=adg;Password=adg;Initial Catalog=NSSWCI;Integrated Security=false;");
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Organizations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtCategories = new DataTable();

                    conn.Open();
                    dtCategories.Load(cmd.ExecuteReader());

                    ddlCategories2.DataSource = dtCategories;
                    ddlCategories2.DataTextField = "OrganizationName"; // Column name to display
                    ddlCategories2.DataValueField = "Id"; // Column name to use as the value
                    ddlCategories2.DataBind();
                }
            }

        }

        public bool CheckAuthentication()
        {
            if (Session["username"] != null)
            {
                return true;
            }
            else
            {
                FormsAuthentication.SignOut();
                Response.Redirect("Login.aspx");
                return false;
            }

        }

        private void FetchDataFromDatabase()
        {
            // Connection string
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("Sp_ViewUserDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Open the connection
                    connection.Open();
                    command.Parameters.AddWithValue("@pEmailId", Convert.ToString(Session["username"]));

                    // Execute the command and read data
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Populate TextBox
                        txtName.Text = reader["Name"].ToString();
                        

                        // Populate DropDownList
                        ddlCategories1.Items.Add(reader["Designation"].ToString());
                        txtMobile.Text = reader["MobileNo"].ToString();
                    }
                    txtemail.Text = Convert.ToString(Session["username"]);
                    // Close the reader and connection
                    reader.Close();
                    connection.Close();
                }
            }

            // Freeze DropDownList values
            ddlCategories2.Enabled = false;
            ddlCategories.Enabled = false;
            txtemail.Enabled = false;
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");

        }

        protected void DownloadFile(object sender, EventArgs e)
        {
            //File to be downloaded.
            string fileName = "JJM_Template.pptx";

            //Path of the File to be downloaded.
            string filePath = Server.MapPath(string.Format("~/Download/JJM_Template.pptx", fileName));

            //Content Type and Header.
            Response.ContentType = "application/pptx";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

            //Writing the File to Response Stream.
            Response.WriteFile(filePath);

            //Flushing the Response.
            Response.Flush();
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=10.22.3.161;User Id=adg;Password=adg;Initial Catalog=NSSWCI;Integrated Security=false;");
            string connectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;

            
                if (FileUpload1.HasFile)
            {
                //    //try
                //    //{
                //        // Specify the path where you want to save the uploaded file
                //        string uploadFolderPath = Server.MapPath("~/Upload/");
                //        string fileName = Path.GetFileName(FileUpload1.FileName);
                //        string filePath = Path.Combine(uploadFolderPath, fileName);

                //        // Save the file to the specified path
                //        FileUpload1 .SaveAs(filePath);
                //        SqlCommand command = new SqlCommand("Sp_FileDetails", conn);
                //        command.CommandType = CommandType.StoredProcedure;
                //        conn.Open();
                //        command.Parameters.AddWithValue("@pEmailId", Session["username"]);
                //        command.Parameters.AddWithValue("@pFileName", fileName);
                //        command.Parameters.AddWithValue("@pFilePath", filePath);
                //        command.Parameters.AddWithValue("@pName", txtName.Text);
                //        command.Parameters.AddWithValue("@pState", ddlCategories.SelectedValue);
                //        command.Parameters.AddWithValue("@pDesignation", ddlCategories1.SelectedValue);
                //        command.Parameters.AddWithValue("@pMobileNo",Convert.ToInt32(txtMobile.Text));
                //        command.ExecuteNonQuery();
                //        lblmessage.Text = "File uploaded successfully!";
                //    //}
                //    //catch (Exception ex)
                //    //{
                //      //  lblmessage.Text = "Error: " + ex.Message;
                //    //}
                //}
                //else
                //{
                //    lblmessage.Text = "Please select a file to upload.";
                //}

                // Get the file extension
                string fileExtension = Path.GetExtension(FileUpload1.FileName).ToLower();

                // Get the MIME type based on the file extension
                //string mimeType = MimeMapping.GetMimeMapping(FileUpload1.FileName);

                // Specify allowed MIME types (e.g., "image/jpeg", "image/png", "application/pdf")
                string[] allowedMimeTypes = { ".pptx", ".pptm", ".ppt" };

                // Check if the MIME type is allowed
                if (Array.IndexOf(allowedMimeTypes, fileExtension) != -1)
                {
                    // Process the file (e.g., save it to the server)
                    string filePath = Server.MapPath("~/Upload") + "/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(filePath);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    { 
                        conn.Open();
                    SqlCommand command = new SqlCommand("Sp_FileDetails", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmailId", Session["username"]);
                    command.Parameters.AddWithValue("@pFileName", fileExtension);
                    command.Parameters.AddWithValue("@pFilePath", filePath);
                    command.Parameters.AddWithValue("@pName", txtName.Text);
                    command.Parameters.AddWithValue("@pState", ddlCategories.SelectedValue);
                    command.Parameters.AddWithValue("@pDesignation", ddlCategories1.SelectedValue);
                    command.Parameters.AddWithValue("@pMobileNo", Convert.ToInt32(txtMobile.Text));
                    command.ExecuteNonQuery();
                }
                    
                    // Display a success message
                   // lblmessage.Text = "File uploaded successfully!";
                }
                else
                {
                    // Display an error message for unsupported MIME type
                   // lblmessage.Text = "Unsupported file format. Please upload a file with ppt format";
                }
            }
            else
            {
                // Display an error message if no file is selected
                //lblmessage.Text = "Please select a file to upload.";
            }
        }
    }
    
}