using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace WebMail2.Server
{
    /// <summary>
    /// DataState 的摘要说明
    /// </summary>
    public class DataState : BaseHandler, IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                context.Response.ContentType = "text/plain";
                int req_page = 1;
                int req_rows = 50;
                if (!Int32.TryParse(context.Request["page"], out req_page)) { req_page = 1; };
                if (!Int32.TryParse(context.Request["rows"], out req_rows)) { req_rows = 50; };
                string req_key = context.Request["key"];
                int mailID = Convert.ToInt32(context.Request["id"]);
                int data_count = 0;
                var user = new Codes.CodeHelper().GetCurrentUserInfo();
                var userID = user.UserID;
                var MailStates = new Codes.DataProvider().QueryMailStateByMailID(mailID, req_key, req_page, req_rows, out data_count);
                context.Response.Write("{\"total\":" + data_count + ",\"rows\":" + new JavaScriptSerializer().Serialize(MailStates) + "}");

            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("【收件人列表】加载收件人数据出错，用户：" + new Codes.CodeHelper().GetCurrentUserInfo().LoginName, exp);
                context.Response.Write("Error");
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