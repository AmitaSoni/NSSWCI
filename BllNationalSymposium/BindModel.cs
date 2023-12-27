using ModelNationalSymposium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllNationalSymposium
{
    public class BindModel
    {
        #region Roles
        public static List<Roles> GetRoles(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<Roles> lstRoles = new List<Roles>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Roles r = new Roles();
                r.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                r.UserType = Convert.ToString(dt.Rows[i]["UserType"]);
                r.CreatedBy = Convert.ToString(dt.Rows[i]["CreatedBy"]);
                r.CreatedOn = Convert.ToDateTime(dt.Rows[i]["CreatedOn"]);
                r.UpdatedBy = Convert.ToString(dt.Rows[i]["UpdatedBy"]);
                r.UpdatedOn = Convert.ToDateTime(dt.Rows[i]["UpdatedOn"]);

                lstRoles.Add(r);
            }
            return lstRoles;
        }
        public static Roles GetRole(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            Roles r = new Roles();
            r.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            r.UserType = Convert.ToString(dt.Rows[0]["UserType"]);
            r.CreatedBy = Convert.ToString(dt.Rows[0]["CreatedBy"]);
            r.CreatedOn = Convert.ToDateTime(dt.Rows[0]["CreatedOn"]);
            r.UpdatedBy = Convert.ToString(dt.Rows[0]["UpdatedBy"]);
            r.UpdatedOn = Convert.ToDateTime(dt.Rows[0]["UpdatedOn"]);
            return r;
        }
        #endregion

        #region State
        public static List<State> GetStates(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<State> lstState = new List<State>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                State s = new State();
                s.StateName = dt.Rows[i]["StateName"].ToString().Trim();
                s.JJM_StateId = Convert.ToInt32(dt.Rows[i]["JJM_StateId"]);
                lstState.Add(s);
            }
            return lstState;
        }
        #endregion

        #region Designation
        public static List<Designation> GetDesignations(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<Designation> lstDesignation = new List<Designation>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Designation s = new Designation();
                s.UserDesignation = dt.Rows[i]["Designation"].ToString().Trim();
                s.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                lstDesignation.Add(s);
            }
            return lstDesignation;
        }
        #endregion

        #region Organization
        public static List<Organization> GetOrganizations(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<Organization> lstOrganization = new List<Organization>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Organization s = new Organization();
                s.OrganizationName = dt.Rows[i]["OrganizationName"].ToString().Trim();
                s.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                lstOrganization.Add(s);
            }
            return lstOrganization;
        }
        #endregion

        #region UserLogin
        public static List<UserLogin> GetUserLogins(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<UserLogin> lstUserLogin = new List<UserLogin>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UserLogin ul = new UserLogin();
                ul.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                ul.Name = Convert.ToString(dt.Rows[i]["Name"]);
                ul.EmailId = Convert.ToString(dt.Rows[i]["EmailId"]);
                ul.Organization = Convert.ToString(dt.Rows[i]["Organization"]);
                ul.HashPassword = Convert.ToString(dt.Rows[i]["HashPassword"]);
                ul.RoleId = Convert.ToInt32(dt.Rows[i]["RoleId"]);
                //ul.UserRoles = BllNS.GetRolesById(ul.RoleId);
                ul.CreatedBy = Convert.ToString(dt.Rows[i]["CreatedBy"]);
                ul.CreatedOn = Convert.ToDateTime(dt.Rows[i]["CreatedOn"]);
                ul.UpdatedBy = Convert.ToString(dt.Rows[i]["UpdatedBy"]);
                ul.UpdatedOn = Convert.ToDateTime(dt.Rows[i]["UpdatedOn"]);

                lstUserLogin.Add(ul);
            }
            return lstUserLogin;
        }
        public static UserLogin GetUserLogin(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            UserLogin ul = new UserLogin();
            ul.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            ul.Name = Convert.ToString(dt.Rows[0]["Name"]);
            ul.EmailId = Convert.ToString(dt.Rows[0]["EmailId"]);
            ul.Organization = Convert.ToString(dt.Rows[0]["Organization"]);
            ul.HashPassword = Convert.ToString(dt.Rows[0]["HashPassword"]);
            ul.RoleId = Convert.ToInt32(dt.Rows[0]["RoleId"]);
            //ul.UserRoles = BllNS.GetRolesById(ul.RoleId);
            ul.CreatedBy = Convert.ToString(dt.Rows[0]["CreatedBy"]);
            ul.CreatedOn = Convert.ToDateTime(dt.Rows[0]["CreatedOn"]);
            ul.UpdatedBy = Convert.ToString(dt.Rows[0]["UpdatedBy"]);
            ul.UpdatedOn = Convert.ToDateTime(dt.Rows[0]["UpdatedOn"]);
            return ul;
        }
        #endregion

        #region Faqs
        public static List<Faqs> GetFaqs(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            List<Faqs> lstFaqs = new List<Faqs>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Faqs r = new Faqs();
                r.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                r.FaqId = Convert.ToInt32(dt.Rows[i]["FaqId"]);
                r.FaqQuestions = Convert.ToString(dt.Rows[i]["FaqQuestions"]);
                r.FaqAnswers = Convert.ToString(dt.Rows[i]["FaqQuestions"]);
                r.Status = Convert.ToInt32(dt.Rows[i]["Status"]);
                r.InsertedBy = Convert.ToString(dt.Rows[i]["InsertedBy"]);
                r.InsertedOn = Convert.ToDateTime(dt.Rows[i]["InsertedOn"]);
                r.InsertedFrom = Convert.ToString(dt.Rows[i]["InsertedFrom"]);
                r.UpdatedBy = Convert.ToString(dt.Rows[i]["UpdatedBy"]);
                r.UpdatedOn = Convert.ToDateTime(dt.Rows[i]["UpdatedOn"]);
                r.UpdatedFrom = Convert.ToString(dt.Rows[i]["UpdatedFrom"]);

                lstFaqs.Add(r);
            }
            return lstFaqs;
        }
        public static Faqs GetFaq(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return null;
            Faqs r = new Faqs();
            r.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            r.FaqId = Convert.ToInt32(dt.Rows[0]["FaqId"]);
            r.FaqQuestions = Convert.ToString(dt.Rows[0]["FaqQuestions"]);
            r.FaqAnswers = Convert.ToString(dt.Rows[0]["FaqQuestions"]);
            r.Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            r.InsertedBy = Convert.ToString(dt.Rows[0]["InsertedBy"]);
            r.InsertedOn = Convert.ToDateTime(dt.Rows[0]["InsertedOn"]);
            r.InsertedFrom = Convert.ToString(dt.Rows[0]["InsertedFrom"]);
            r.UpdatedBy = Convert.ToString(dt.Rows[0]["UpdatedBy"]);
            r.UpdatedOn = Convert.ToDateTime(dt.Rows[0]["UpdatedOn"]);
            r.UpdatedFrom = Convert.ToString(dt.Rows[0]["UpdatedFrom"]);
            return r;
        }
        #endregion
    }
}
