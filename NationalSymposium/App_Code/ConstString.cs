using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NationalSymposium
{
    public class ConstString
    {
        public static string SessionUser = "User";

        public static int Active = 1;
        public static int InActive = 0;

        public static int Admin = 1;
        public static int User = 2;
        public static string VsUserEmail = "VsUserEmail";

        public static int Participants = 1;
        public static int Speaker = 0;

        public static string LoginPage = @"Login.aspx";
        public static string AuthUserPage = "~/User_Page.aspx";
        public static string UserPage = "User_Page.aspx";
        public static string AdminPage = "Admin_Page.aspx";
    }
}