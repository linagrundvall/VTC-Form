﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                    Session["uploadedFilePath"] = "~/uploads/" + UploadedFile.FileName;
                    Session["uploadedFileName"] = UploadedFile.FileName;
                    Session["pathUploads"] = Server.MapPath("~/uploads/");
                    Session["pathConverted"] = Server.MapPath("~/converted/");

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

                    // Start the child process.
                    Process p = new Process();
                    // Redirect the output stream of the child process.
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.FileName = "cmd.exe";

                    string replaceWith = "\\";
                    replaceWith += "\u0022";
                    Session["pathUploads"] = Session["pathUploads"].ToString().Replace("\\", replaceWith);


                    string Arguments = "/C ffmpeg -i " + Session["pathUploads"] + "traffic.mp4" + Session["pathConverted"] + "\\traffic.avi";
                    //"/C ffmpeg -i " + "source\\repos\\VTC\\VTC Form\\VTC\\uploads\\" +
                    //"uploadedFileName" + " source\\repos\\VTC\\VTC Form\\VTC\\converted";

                    FileConvertedLabel.Text = Arguments;


                    p.StartInfo.Arguments = Arguments;
                    //"/C ffmpeg -i videos\\copy.mp4 converted\\copy.avi";
                    p.Start();
                    p.WaitForExit();
                    //p.StartInfo.Arguments = "/C Del videos\\copy.mp4";
                    //p.Start();
                    //p.WaitForExit();


                    // Read the output stream first and then wait.
                    string output = p.StandardOutput.ReadToEnd();
                    FileConvertedLabel.Text = output;


                    FileConvertedLabel.Text = "You have converted a file.";
                    string output2 = p.StandardError.ReadToEnd();
                    FileConvertedLabel.Text = output2;


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