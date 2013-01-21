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