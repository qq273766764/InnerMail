using System;
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
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}