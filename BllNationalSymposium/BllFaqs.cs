using DalNationalSymposium;
using ModelNationalSymposium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllNationalSymposium
{
    public class BllFaqs
    {
        public static List<Faqs> GetFaqs()
        {
            List<Faqs> l = BindModel.GetFaqs(DalFaqs.GetFaqs());
            return l;
        }
        public static Faqs GetFaqsById(int id)
        {
            Faqs r = BindModel.GetFaq(DalFaqs.GetFaqsById(id));
            return r;
        }

        public static int SetFaqs(Faqs f)
        {
            return DalFaqs.SetFaqs(f);
        }
        public static void UpdateFaqs(Faqs f)
        {
            DalFaqs.UpdateFaqs(f);
        }
        public static void DeleteFaqs(Faqs f)
        {
            DalFaqs.DeleteFaqs(f);
        }
    }
}
