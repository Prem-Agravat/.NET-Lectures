using System;

namespace second
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}