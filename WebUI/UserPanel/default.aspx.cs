using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Entities.Concrete;

namespace WebUI.UserPanel
{
    public partial class _default : System.Web.UI.Page
    {
        Users users = new Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session[users.UserName].ToString() == users.UserName)
            {
                Response.Redirect("~/UserPanel/default.aspx");
            }
            else
            {
                Response.Redirect("~/AdminPanel/index.aspx");
                
            }
        }
    }
}