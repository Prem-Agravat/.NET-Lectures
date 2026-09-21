using System;
using System.IO;

namespace second
{
    public partial class standard_control_demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                // Create Uploads folder if it doesn't exist
                string folderPath = Server.MapPath("~/img/");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, FileUpload2.FileName);

                FileUpload2.SaveAs(filePath);

                Label1.Text = "File uploaded successfully!";
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}