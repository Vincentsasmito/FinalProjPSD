﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Handler;

namespace Final_Project.Views.Transaction
{
    public partial class TransactionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies.Get("UserData");
            if(cookie == null)
            {
                Response.Redirect("~/Views/Users/Login.aspx");
            }
            else if(cookie["roleid"] == "2")
            {
                Response.Redirect("~/Views/Users/Home.aspx");
            }
            string headerId = "";
            if (!IsPostBack)
            {
                ListBox1.Items.Clear();
                headerId = Request.QueryString["headerId"];
            }

            List<DetailRes> details = TransactionHandler.getDetail(Convert.ToInt32(headerId));
            foreach (var x in details)
            {
                ListBox1.Items.Add("Detail ID: " + x.id + " | Ramen Name: " + x.ramenName + " | Ramen Broth: " + x.broth + " | Ramen Quantity: " + x.quantity + " | Total Price: " + Convert.ToInt32(x.price) * x.quantity);
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}