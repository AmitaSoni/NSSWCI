using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelNationalSymposium;

namespace DalNationalSymposium
{ 
    public class DalFaqs
    {
    public static readonly string NSConnectionString = ConfigurationManager.ConnectionStrings["NSSWCIConnectionString"].ConnectionString;
  
        public static DataTable GetFaqs()
        {
            SqlConnection con = new SqlConnection(NSConnectionString);
            const string sqlCmd = "GetFaqs";
            SqlCommand cmd = new SqlCommand(sqlCmd, con) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }        
        public static DataTable GetFaqsById(int id)
        {
            SqlConnection con = new SqlConnection(NSConnectionString);
            const string sqlCmd = "GetFaqsById";
            SqlCommand cmd = new SqlCommand(sqlCmd, con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@faqId", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static int SetFaqs(Faqs f)
        {
            SqlConnection con = new SqlConnection(NSConnectionString);
            const string sqlCmd = "SetFaqs";
            SqlCommand cmd = new SqlCommand(sqlCmd, con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@faqQuestions", f.FaqQuestions);
            cmd.Parameters.AddWithValue("@faqAnswers", f.FaqAnswers);
            cmd.Parameters.AddWithValue("@status", f.Status);
            cmd.Parameters.AddWithValue("@insertedBy", f.InsertedBy);
            cmd.Parameters.AddWithValue("@insertedOn", f.InsertedOn);
            cmd.Parameters.AddWithValue("@insertedFrom", f.InsertedFrom);
            cmd.Parameters.AddWithValue("@updatedBy", f.UpdatedBy);
            cmd.Parameters.AddWithValue("@updatedOn", f.UpdatedOn);
            cmd.Parameters.AddWithValue("@updatedFrom", f.UpdatedFrom);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public static void DeleteFaqs(Faqs f)
        {
            SqlConnection con = new SqlConnection(NSConnectionString);
            const string sqlCmd = "DeleteFaqs";
            SqlCommand cmd = new SqlCommand(sqlCmd, con) { CommandType = CommandType.StoredProcedure };
            con.Open();
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@faqId", f.FaqId);
            cmd.Parameters.AddWithValue("@status", f.Status);
            cmd.Parameters.AddWithValue("@updatedBy", f.UpdatedBy);
            cmd.Parameters.AddWithValue("@updatedOn", f.UpdatedOn);
            cmd.Parameters.AddWithValue("@updatedFrom", f.UpdatedFrom);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateFaqs(Faqs f)
        {
            SqlConnection con = new SqlConnection(NSConnectionString);
            const string sqlCmd = "UpdateFaqs";
            SqlCommand cmd = new SqlCommand(sqlCmd, con) { CommandType = CommandType.StoredProcedure };
            con.Open();
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@faqId", f.FaqId);
            cmd.Parameters.AddWithValue("@faqQuestions", f.FaqQuestions);
            cmd.Parameters.AddWithValue("@faqAnswers", f.FaqAnswers);
            cmd.Parameters.AddWithValue("@updatedBy", f.UpdatedBy);
            cmd.Parameters.AddWithValue("@updatedOn", f.UpdatedOn);
            cmd.Parameters.AddWithValue("@updatedFrom", f.UpdatedFrom);
            cmd.ExecuteNonQuery();
        }

    }
}
