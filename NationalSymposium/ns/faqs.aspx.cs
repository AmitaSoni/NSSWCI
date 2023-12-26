using BllNationalSymposium;
using ModelNationalSymposium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalSymposium.ns
{
    public partial class faqs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {
            List<Faqs> lstFaq = BllFaqs.GetFaqs();
            gvFaq.DataSource = lstFaq;
            gvFaq.DataBind();
        }

        protected void gvFaq_PreRender(object sender, EventArgs e)
        {
            gvFaq.UseAccessibleHeader = true;
            if (gvFaq.HeaderRow != null)
            {
                gvFaq.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}