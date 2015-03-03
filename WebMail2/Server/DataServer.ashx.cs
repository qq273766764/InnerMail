using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.Script.Serialization;

namespace WebMail2.Server
{
    /// <summary>
    /// DataServer 的摘要说明
    /// </summary>
    public class DataServer : BaseHandler, IHttpHandler
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
                Codes.EnumMailType MailType = Codes.EnumHelper.GetEnum<Codes.EnumMailType>(context.Request["t"]);
                string req_key = context.Request["key"];
                int data_count = 0;
                var user = new Codes.CodeHelper().GetCurrentUserInfo();
                var userID = user.UserID;
                switch (MailType)
                {
                    case Codes.EnumMailType.InMail://收件箱
                        var InMailData = new Codes.DataProvider().QueryReciveMailBox(userID, req_key, req_page, req_rows, out data_count);
                        context.Response.Write(WriteJsonData(data_count, InMailData));
                        break;
                    case Codes.EnumMailType.OutMail://发件箱
                        var OutMailDatas = new Codes.DataProvider().QuerySendMailBox(userID, false, req_key, req_page, req_rows, out data_count);
                        context.Response.Write(WriteJsonData(data_count, OutMailDatas));
                        break;

                    case Codes.EnumMailType.DraftMail://草稿箱
                        var DraftMailDatas = new Codes.DataProvider().QuerySendMailBox(userID, true, req_key, req_page, req_rows, out data_count);
                        context.Response.Write(WriteJsonData(data_count, DraftMailDatas));
                        break;
                    case Codes.EnumMailType.DustMail://垃圾箱(发件箱)
                        var DustMailDatas = new Codes.DataProvider().QueryDustbinBox(userID, req_key, req_page, req_rows, out data_count);
                        context.Response.Write(WriteJsonData(data_count, DustMailDatas));
                        break;
                }
            }
            catch (Exception exp)
            {
                var UserInfo = new Codes.CodeHelper().GetCurrentUserInfo();
                Codes.LoggerHelper.MailLogger.Error(
                    string.Format("【邮件列表】加载邮件数据出错，用户：{0}({2} - {1})", 
                    UserInfo.Name, 
                    UserInfo.LoginName, 
                    UserInfo.UserID), exp);
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

        private string WriteJsonData(int cnt, IEnumerable<Model.View_AllMail_NoGUID> MailViews)
        {
            var datas = from mail in MailViews
                        select new
                        {
                            mail.ID,
                            mail.Level,
                            mail.Subject,
                            mail.SendFromName,
                            mail.SendTime,
                            mail.IsRead
                        };
            return "{\"total\":" + cnt + ",\"rows\":" + new JavaScriptSerializer().Serialize(datas) + "}";
        }
    }
}