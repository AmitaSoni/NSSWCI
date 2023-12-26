using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNationalSymposium
{
    public class Faqs
    {
        public int Id { get; set; }
        public int FaqId { get; set; }
        public string FaqQuestions { get; set; }
        public string FaqAnswers { get; set; }
        public int Status { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedOn { get; set; }
        public string InsertedFrom { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedFrom { get; set; }
    }
}
