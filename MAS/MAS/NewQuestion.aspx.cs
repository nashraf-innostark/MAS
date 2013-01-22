using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAS
{
    public partial class NewQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Literal ltrlpagetitle = (Literal)this.Master.FindControl("ltrlpageTitle");
            ltrlpagetitle.Text = "New Query";
            Label lblpageTitle = (Label)this.Master.FindControl("lblpageheader");
            lblpageTitle.Text = "New Query";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuestionList.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuestionList.aspx");
=======

>>>>>>> 9ff15ba212fd40473ce1190608860d9a030073f0
        }
    }
}