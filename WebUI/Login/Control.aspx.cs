using DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Login
{
    public partial class Control : System.Web.UI.Page
    {
        Users users = new Users();
            UserDal userDal = new UserDal();
        protected void Page_Load(object sender, EventArgs e)
        { 
        //    if (IsPostBack) return;
        //        if (Session[users.UserEmail].ToString() == users.UserEmail && Session[users.UserPassword].ToString() == users.UserPassword)
        //        {
        //            int Type = userDal.UserLogin(users);
        //            if (Type > 0)
        //            {
        //                Response.Redirect("../UserPanel/default.aspx");
        //            }
        //            else if (Type == 0)
        //            {
        //                Response.Redirect("../AdminPanel/index.aspx");

        //            }
        //            else if (Type == -1)
        //            {
        //                Response.Redirect("../UserPanel/rooms-single.aspx");
        //            }


        //        }

            
            
               
            
        }
    }
}