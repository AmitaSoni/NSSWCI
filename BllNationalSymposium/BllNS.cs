using DalNationalSymposium;
using ModelNationalSymposium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllNationalSymposium
{
    public class BllNS
    {
        #region Roles
        public static List<Roles> GetRoles()
        {
            List<Roles> lstRoles = BindModel.GetRoles(DalNS.GetRoles());
            return lstRoles;
        }
        public static Roles GetRolesById(int id)
        {
            Roles r = BindModel.GetRole(DalNS.GetRolesById(id));
            return r;
        }
        #endregion

        #region States
        public static List<State> GetState()
        {
            List<State> sList = BindModel.GetStates(DalNS.GetState());
            //var dt = DalNS.GetState();
            return sList;
        }

        #endregion

        #region Designations
        public static List<Designation> GetDesignations()
        {
            List<Designation> sList = BindModel.GetDesignations(DalNS.GetDesignations());
            //var dt = DalNS.GetState();
            return sList;
        }

        #endregion

        #region Organizations
        public static List<Organization> GetOrganizations()
        {
            List<Organization> sList = BindModel.GetOrganizations(DalNS.GetOrganizations());
            //var dt = DalNS.GetState();
            return sList;
        }

        #endregion

        #region Registration
        public static int SetUserRegistration(Registrations r)
        {
            return DalNS.SetUserRegistrations(r);
        }
        #endregion

        #region UserLogin
        public static UserLogin GetUserDetails(string userName, string password)
        {
            DataTable dt = DalNS.GetUserDetails(userName, password);
            if (dt == null)
                return null;
            UserLogin ul = BindModel.GetUserLogin(dt);
            if (ul != null)
            {
                return ul;
            }
            return null;
        }

        public static List<UserLogin> GetUserLogin()
        {
            List<UserLogin> lstUserLogin = BindModel.GetUserLogins(DalNS.GetUserLogin());
            return lstUserLogin;
        }
        public static string GetUserLoginByEmailId(string email)
        {
            //UserLogin r = BindModel.GetUserLogin(DalNS.GetUserLoginByEmailId(email));
            return DalNS.Sp_CheckUser(email);
            // return r;
        }
        public static string Sp_ForgotPassword(string email, string password)
        {
            //UserLogin r = BindModel.GetUserLogin(DalNS.GetUserLoginByEmailId(email));
            return DalNS.Sp_ForgotPassword(email, password);
            // return r;
        }
        #endregion
    }
}
