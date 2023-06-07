﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;
using Final_Project.Model;

namespace Final_Project.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie uCook = Request.Cookies.Get("UserData");
            if(uCook != null)
            {
                TextBox1.Text = uCook["username"];
                TextBox2.Text = uCook["password"];
                Remember.Checked = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            User x = UserController.userLogin(username, password);
            ListBox1.Items.Clear();
            if(x == null)
            {
                ListBox1.Items.Add("Wrong Username or Password!");
            }
            else
            {
                HttpCookie uCook = new HttpCookie("UserData");
                uCook["id"] = x.id.ToString();
                uCook["roleid"] = x.Roleid.ToString();
                uCook["username"] = x.Username;
                uCook["password"] = x.Password;
                Session["password"] = x.Password;

                switch (x.Roleid)
                {
                    case 3:
                        Response.Redirect("CustomerHome.aspx");
                        break;

                    default:
                        break;
                }
            }

            

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Remember.Checked == true)
            {
                Remember.Checked = false;
            }
            else
            {
                Remember.Checked = true;
            }


        }
    }
}