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
    public partial class a_faqs : System.Web.UI.Page
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

        protected void bEdit_Click(object sender, EventArgs e)
        {

        }

        protected void bAddFaq_Click(object sender, EventArgs e)
        {
            paddFaq.Visible = true;
        }

        protected void bDelete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow gridViewRow = (GridViewRow)(button.Parent.Parent);
            int faqId = Convert.ToInt32(button.CommandArgument);
            if (faqId != 0)
            {
                Faqs f = new Faqs();
                f.FaqId = faqId;
                f.UpdatedBy = "";
                f.UpdatedFrom = "";
                f.UpdatedOn = DateTime.Now;
                BllFaqs.DeleteFaqs(f);
                Utility.ShowToastrSuccess(this, "FAQs has been deleted successfully.", "Success");
                paddFaq.Visible = false;
            }
            else
            {
                Utility.ShowToastrError(this, "", "Error");
            }
            List<Faqs> lstFaq = BllFaqs.GetFaqs();
            gvFaq.DataSource = lstFaq;
            gvFaq.DataBind();
        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                    Faqs f = new Faqs();
                    f.FaqQuestions = txtQuestion.Text;
                    f.FaqAnswers = txtAnswers.Text;
                f.InsertedBy = string.Empty;
                f.InsertedOn = DateTime.Now;
                f.InsertedFrom = Utility.GetIpAddress();
                f.UpdatedBy = string.Empty;
                    f.UpdatedOn = DateTime.Now;
                    f.UpdatedFrom = Utility.GetIpAddress();
                    f.Status = ConstString.Active;
                    BllFaqs.SetFaqs(f);
                    Utility.ShowToastrSuccess(this, "FAQs has been added successfully.", "Success");
                    Clear();
                    List<Faqs> lstFaq = BllFaqs.GetFaqs();
                    gvFaq.DataSource = lstFaq;
                    gvFaq.DataBind();
                
            }
        }
        protected void bViewAll_Click(object sender, EventArgs e)
        {
            paddFaq.Visible = false;
            Clear();
        }
        public void Clear()
        {
            txtQuestion.Text = string.Empty;
            txtAnswers.Text = string.Empty;
        }
    }
}