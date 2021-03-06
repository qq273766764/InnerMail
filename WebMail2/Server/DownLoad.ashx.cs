﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebMail2.Server
{
    /// <summary>
    /// DownLoad 的摘要说明
    /// </summary>
    public class DownLoad : IHttpHandler
    {

        #region Url参数
        /// <summary>
        /// 文件ID
        /// </summary>
        public int FileID
        {
            get
            {
                return Convert.ToInt32(HttpContext.Current.Request["fid"]);
            }
        }

        #endregion

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "Application/octet-stream";
            context.Response.Charset = "utf-8";

            try
            {
                if (FileID != 0)
                {
                    var file = new Codes.DataProvider().QueryAttachmentById(FileID);
                    if (file == null)
                    {
                        throw new Exception("附件已被删除！");
                    }
                    if (!File.Exists(HttpContext.Current.Server.MapPath(file.FilePath)))
                    {
                        throw new Exception(string.Format("服务器中找不到附件：“{0}”，可能文件已被删除！", file.FileName));
                    }
                    string filename = HttpUtility.UrlEncode(file.FileName.Replace(' ', '_'), System.Text.Encoding.UTF8);
                    context.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
                    context.Response.WriteFile(file.FilePath);
                }
            }
            catch (Exception exp)
            {
                context.Response.ContentType = "text/html, application/xhtml+xml, */*";
                context.Response.Write(string.Format("<script type='text/javascript'>alert('{0}');</script>", exp.Message.Replace("'", "‘")));
            }
            finally{
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        protected void DownLoadLargeFile(string fileName, string filePath)
        {
            System.IO.Stream iStream = null;
            // Buffer to read 10K bytes in chunk:
            byte[] buffer = new Byte[10000];
            // Length of the file:
            int length;
            // Total bytes to read.
            long dataToRead;
            try
            {
                // Open the file.
                iStream = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                // Total bytes to read.
                dataToRead = iStream.Length;
                HttpContext.Current.Response.ContentType = "text/plain"; // Set the file type
                HttpContext.Current.Response.AddHeader("Content-Length", dataToRead.ToString());
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
                // Read the bytes.
                while (dataToRead > 0)
                {
                    // Verify that the client is connected.
                    if (HttpContext.Current.Response.IsClientConnected)
                    {
                        // Read the data in buffer.
                        length = iStream.Read(buffer, 0, 10000);
                        // Write the data to the current output stream.
                        HttpContext.Current.Response.OutputStream.Write(buffer, 0, length);
                        // Flush the data to the HTML output.
                        HttpContext.Current.Response.Flush();
                        buffer = new Byte[10000];
                        dataToRead = dataToRead - length;
                    }
                    else
                    {
                        // Prevent infinite loop if user disconnects
                        dataToRead = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Trap the error, if any.
                HttpContext.Current.Response.Write("Error : " + ex.Message);
            }
            finally
            {
                if (iStream != null)
                {
                    //Close the file.
                    iStream.Close();
                }
                HttpContext.Current.Response.End();
            }
        }
    }
}