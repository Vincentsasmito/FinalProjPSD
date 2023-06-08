using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.Views
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //idk ini code penting ato ga kali kalo logout ga ke clear text nya
            TBWelcome.Text = "";


            HttpCookie cookie = Request.Cookies.Get("UserData");
            if(cookie == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                switch (Convert.ToInt32(Request.Cookies["UserData"]["roleid"]))
                {
                    
                    case 3:
                        TBWelcome.Text = Request.Cookies["UserData"]["username"] + ", Role: " + Request.Cookies["UserData"]["roleid"];
                        break;

                    default:
                        break;
                }
               
                
            }
        }
    }
}