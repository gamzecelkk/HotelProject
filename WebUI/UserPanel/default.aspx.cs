using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.NewFolder1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Session["pass"].ToString()=="1234" && Session["user"].ToString() == "admin")
            {
                Response.Redirect("~/UserPanel/default.aspx");
            }
            else
            {
                Response.Redirect("~/UserPanel/index.aspx");
            }
            
        }
    }
}