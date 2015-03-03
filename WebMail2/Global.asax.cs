using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebMail2
{
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// 检查发送邮箱的线程
        /// </summary>
        private static Thread MailStateQueueThread;

        /// <summary>
        /// 检查邮件删除线程
        /// </summary>
        private static Thread MailDeleteThread;

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                Codes.LoggerHelper.MailLogger.Info("----------------- 系统启动 -----------------");
                if (MailStateQueueThread == null)
                {
                    MailStateQueueThread = new Thread(new ThreadStart(Codes.MailStateQueue.Init));
                    MailStateQueueThread.Start();
                }
                if (MailDeleteThread == null)
                {
                    MailDeleteThread = new Thread(new ThreadStart(Codes.MailDeleteThread.Init));
                    MailDeleteThread.Start();
                }
            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("启动线程出错！", exp);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Path.GetExtension(HttpContext.Current.Request.CurrentExecutionFilePath) != ".aspx") { return; }
            if (Path.GetFileName(HttpContext.Current.Request.CurrentExecutionFilePath) == "MailBlank.aspx") { return; }
            if (Codes.MailStateQueue.IsInitCheck || Codes.MailDeleteThread.IsInitCheck)
            {
                Server.Transfer("MailBlank.aspx?act=init");
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (MailStateQueueThread != null) { MailStateQueueThread.Abort(); }
            if (MailDeleteThread != null) { MailDeleteThread.Abort(); }
            Codes.LoggerHelper.MailLogger.Info("----------------- 系统终止 -----------------");
        }
    }
}