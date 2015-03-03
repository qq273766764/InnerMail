using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebMail2.Server
{
    /// <summary>
    /// FileUpload 的摘要说明
    /// </summary>
    public class FileUpload :  IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            //上传配置
            string pathbase = "/FileUpload/";                                                          //保存路径
            int size = 500;                     //文件大小限制,单位mb                                                                                   //文件大小限制，单位KB
            //string[] filetype = { 
            //                        ".gif", ".png", ".jpg", ".jpeg", ".bmp", 
            //                        ".rar", ".7z", ".zip",
            //                        ".doc", ".docx", ".xls", ".xlsx", ".pptx",".pdf",
            //                        ".txt" };                    //文件允许格式
            string[] filetype = ConfigurationManager.AppSettings["AllowUploadFileExt"].Split(',');
            string callback = context.Request["callback"];
            string editorId = context.Request["editorid"];

            //上传图片
            Hashtable info;
            Codes.Uploader up = new Codes.Uploader();
            info = up.upFile(context, pathbase, filetype, size); //获取上传状态
            string json = BuildJson(info);
            context.Response.ContentType = "text/html";
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private string BuildJson(Hashtable info)
        {
            List<string> fields = new List<string>();
            string[] keys = new string[] { "originalName", "name", "url", "size", "state", "type" };
            for (int i = 0; i < keys.Length; i++)
            {
                fields.Add(String.Format("\"{0}\": \"{1}\"", keys[i], info[keys[i]]));
            }
            return "{" + String.Join(",", fields) + "}";
        }
    }
}