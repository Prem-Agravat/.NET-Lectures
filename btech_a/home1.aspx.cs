using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace btech_a
{
    public partial class home1 : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void REGISTER_BTN_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\btech_a\\App_Data\\Database1.mdf;Integrated Security=True";//replace with your actual connection string
            SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            string query = "insert into register Values('" + NAMETXT.Text + "','" + EMAILTXT.Text + "','" + PASSTXT.Text + "','"+CPASSTXT.Text+ "','" + DropDownList1.SelectedItem.ToString() +"','" + CONTACT_TXT.Text+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Registered Successfully');</script>");



            con.Close();
        }
    }
}