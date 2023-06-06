using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;
namespace Final_Project.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CreateAccBtn_Click(object sender, EventArgs e)
        {
            string gender = "";
            if(RadioButtonM.Checked == true)
            {
                gender = "male";
            }
            else if (RadioButtonF.Checked == true)
            {
                gender = "female";
            }
            string resp = UserController.validateUser("3", TBName.Text, TBEmail.Text, gender, TBPw.Text, TBPwC.Text);

            ListBox1.Items.Clear();
            ListBox1.Items.Add(TBName.Text);
            ListBox1.Items.Add(TBEmail.Text);
            ListBox1.Items.Add(gender);
            ListBox1.Items.Add(TBPw.Text);
            ListBox1.Items.Add(TBPwC.Text);
            ListBox1.Items.Add(resp);
        }
    }
}