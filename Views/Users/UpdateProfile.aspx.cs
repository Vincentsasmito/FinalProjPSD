using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;

namespace Final_Project.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = Request.Cookies.Get("UserData");

            if (cookie != null)
            {
                if(!IsPostBack)
                {
                    TextBox1.Text = cookie["username"];
                    TextBox2.Text = cookie["email"];
                    TextBox3.Text = cookie["gender"];
                    TextBox4.Text = cookie["password"];
                    TextBox5.Text = cookie["password"];
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            string res = UserController.validateUpdate(cookie["id"], TextBox1.Text,
                TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            //Update cookie with new values
            if(res == "Update Success!")
            {
                cookie["username"] = TextBox1.Text;
                cookie["email"] = TextBox2.Text;
                cookie["gender"] = TextBox3.Text;
                cookie["password"] = TextBox4.Text;
            }
            ListBox1.Items.Add(res);

        }
    }
}