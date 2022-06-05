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
        //string uploadedFile { get;set;}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload(object sender, EventArgs e)
        {
            if (UploadedFile.HasFile)
                try
                {
                    UploadedFile.SaveAs(Server.MapPath("~/uploads/") +
                         UploadedFile.FileName);
                    FileUploadedLabel.Text = "File name: " +
                         UploadedFile.PostedFile.FileName + "<br>" +
                         UploadedFile.PostedFile.ContentLength + " kb<br>" +
                         "Content type: " + UploadedFile.PostedFile.ContentType;

                    Session["uploadedFile"] = "~/uploads/" + UploadedFile.FileName;
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
            if (1 == 1)
                try
                {
                    var fileToConvert = Session["uploadedFile"];
                    Console.WriteLine("Hej");



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

    }
}