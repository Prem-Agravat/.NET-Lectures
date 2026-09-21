using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace second
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "selected Date: " + Calendar1.SelectedDate.ToString("dd-MM-yyyy");
            Label2.Text = "Day of Week: " + Calendar1.SelectedDate.DayOfWeek.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(male_btn.Checked)
            {
                Label3.Text = "Male";
            }else if (female_btn.Checked)
            {
                Label3.Text = "Female";
            }
            else
            {
                Label3.Text = "Select Gender";
            }
        }  

        protected void Button2_Click(object sender, EventArgs e)
        {
            int TOTAL = 0;

            if (C.Checked)
            {
                TOTAL += 1000;
            }
            if (C2.Checked)
            {
                TOTAL += 2000;
            }
            if (java.Checked)
            {
                TOTAL += 3000;
            }
            Label4.Text = "Total Amount = " + TOTAL;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach(int i in Items)
            {
                Response.Write(i + "<br>");
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Label5.Text = "Hello";
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}