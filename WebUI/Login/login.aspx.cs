using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Entities.Concrete;

namespace WebUI.Login
{
    public partial class login : System.Web.UI.Page
    {
        Users users = new Users();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("userEmail", textUser.Text);
            Session.Add("userPass", textPassword.Text);
            Response.Redirect("~/userpanel/Default.aspx");
        }
    }
}