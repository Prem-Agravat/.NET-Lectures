using System;

namespace second
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Rebind the AdRotator so it selects another ad
            AdRotator1.DataBind();
        }
    }
}