using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebMail2.Server
{
    /// <summary>
    /// DataDelete 的摘要说明
    /// </summary>
    public class DataDelete : BaseHandler, IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                context.Response.ContentType = "text/plain";
                Codes.EnumMailType MailType = Codes.EnumHelper.GetEnum<Codes.EnumMailType>(context.Request["t"]);
                var MailIds = context.Request["ids"].Split(',').Select(i => { if (!string.IsNullOrWhiteSpace(i)) return Convert.ToInt32(i); else return 0; }).ToArray();
                bool IsDel = Convert.ToBoolean(context.Request["isdel"]);
                var user = new Codes.CodeHelper().GetCurrentUserInfo();
                var userID = user.UserID;
                switch (MailType)
                {
                    case Codes.EnumMailType.DraftMail:
                        new Codes.DataProvider().DeleteDraftMailBox(userID, MailIds, IsDel);
                        break;
                    case Codes.EnumMailType.DustMail:
                        new Codes.DataProvider().DeleteDustBinBox(userID, MailIds);
                        break;
                    case Codes.EnumMailType.InMail:
                        new Codes.DataProvider().DeleteReciveMailBox(userID, MailIds, IsDel);
                        break;
                    case Codes.EnumMailType.OutMail:
                        new Codes.DataProvider().DeleteSendMailBox(userID, MailIds, IsDel);
                        break;
                }
                context.Response.Write("OK");
            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("【删除邮件】删除邮件出错！", exp);
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