using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Handler;

namespace Final_Project.Views
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Not accessible to customer
            HttpCookie cookie = Request.Cookies.Get("UserData");
            if (cookie == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else if(cookie["roleid"] == "3")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            List<RamenRes> ramenList = RamenHandler.GetRamen();

            for(int i = 0; i < ramenList.Count(); i++)
            {
                DropDownList1.Items.Add(ramenList[i].name);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = DropDownList1.SelectedIndex;
            int meatid = 0;
            if (RadioButtonList1.SelectedValue != null && RadioButtonList1.SelectedValue != "")
            {
                meatid = Convert.ToInt32(RadioButtonList1.SelectedValue);
            }
            string res = RamenHandler.UpdateRamen(id, meatid, TextBox1.Text, TextBox2.Text, TextBox3.Text);
            ListBox1.Items.Clear();
            ListBox1.Items.Add(res);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}