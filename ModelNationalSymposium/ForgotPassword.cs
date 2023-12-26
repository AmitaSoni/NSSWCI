using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNationalSymposium
{
    public class ForgotPassword
    {
        public int Id { get; set; }
        public string UserLoginId { get; set; }
        public string EmailId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public int RoleId { get; set; }
        public Roles UserRoles { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
