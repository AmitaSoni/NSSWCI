using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModelNationalSymposium
{
    public class Registrations
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string EmailId { get; set; }

        public string HashPassword { get; set; }

        public int? Organization { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public string UpdatedBy { get; set; }=  string.Empty;

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public long MobileNo { get; set; }

        public int Participants { get; set; }

        public int? Designation { get; set; }

        public int? State { get; set; }

    }
}
