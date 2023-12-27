using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNationalSymposium
{
    public class UserLogin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string EmailId { get; set; }

        public string Organization { get; set; }

        public string HashPassword { get; set; }

        public int? RoleId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string UserStatus { get; set; }

        public int? LoginAttempts { get; set; }

        public string CreatedByIP { get; set; }

        public string UpdatedByIP { get; set; }

        public string IsLocked { get; set; }

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string EmailId { get; set; }
        //public string Organization { get; set; }
        //public string HashPassword { get; set; }
        //public int RoleId { get; set; }
        //public Roles UserRoles { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public string UpdatedBy { get; set; }
        //public DateTime UpdatedOn { get; set; }
    }
}
