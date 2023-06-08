﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;

namespace Final_Project.Views
{
    public partial class CreateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int meatid = 0;
            if(RadioButtonList1.SelectedValue != null && RadioButtonList1.SelectedValue != "")
            {
                meatid = Convert.ToInt32(RadioButtonList1.SelectedValue);
            }

            string res = RamenController.CreateRamen(meatid, TextBox1.Text, TextBox2.Text, TextBox3.Text);
            ListBox1.Items.Clear();
            ListBox1.Items.Add(meatid.ToString());
            ListBox1.Items.Add(TextBox1.Text);
            ListBox1.Items.Add(TextBox2.Text);
            ListBox1.Items.Add(TextBox3.Text);
            ListBox1.Items.Add(res);
        }
    }
}