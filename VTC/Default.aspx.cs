using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                try
                {
                    FileUpload1.SaveAs(Server.MapPath("~/uploads/") +
                         FileUpload1.FileName);
                    FileUploadedLabel.Text = "File name: " +
                         FileUpload1.PostedFile.FileName + "<br>" +
                         FileUpload1.PostedFile.ContentLength + " kb<br>" +
                         "Content type: " + FileUpload1.PostedFile.ContentType;
                }
                catch (Exception ex)
                {
                    FileUploadedLabel.Text = "ERROR: " + ex.Message.ToString();
                }
            else
            {
                FileUploadedLabel.Text = "You have not specified a file.";
            }
        }

        protected void Convert(object sender, EventArgs e)
        {
            Console.WriteLine("Hello Converter");
        }

    }
}