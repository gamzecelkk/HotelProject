using DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.UserPanel
{
    public partial class _default : System.Web.UI.Page
    {
        Users users = new Users();
        UserDal userDal = new UserDal();
        int donenDeger;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (IsPostBack) return;
            if (Session["userEmail"].ToString() !=null && Session["userPass"].ToString() !=null)
            {
                users.UserEmail = Session["userEmail"].ToString();
                users.UserPassword = Session["userPass"].ToString();

                donenDeger = userDal.UserLogin(users);
           
               
                if (donenDeger > 0)
                {
                    Response.Redirect("../UserPanel/default.aspx");
                }
                else if (donenDeger == 0)
                {
                    Response.Redirect("../AdminPanel/index.aspx");

                }
                else if (donenDeger == -1)
                {
                    Response.Redirect("../UserPanel/rooms-single.aspx");
                }


            }
        }
    }
}