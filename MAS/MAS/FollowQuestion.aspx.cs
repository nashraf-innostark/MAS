using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAS
{
    public partial class FollowQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal ltrlpagetitle = (Literal)this.Master.FindControl("ltrlpageTitle");
            ltrlpagetitle.Text = "Follow Query";
            Label lblpageTitle = (Label)this.Master.FindControl("lblpageheader");
            lblpageTitle.Text = "Follow Query";
            BindGridview();
        }

        public void BindGridview()
        {
            List<string[]> list = new List<string[]>();
            string[] temp = { "1", "Sample Question", "10 Jan 2013" };
            string[] temp1 = { "2", "Sample Question 1", "12 Jan 2013" };
            list.Add(temp);
            list.Add(temp1);
            list.Add(temp);
            gvComments.DataSource = list;
            gvComments.DataBind();

            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuestionList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuestionList.aspx");
        }
    }
}