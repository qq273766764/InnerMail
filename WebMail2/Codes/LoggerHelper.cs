using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public static class LoggerHelper
    {
        static log4net.ILog _sl;
        public static log4net.ILog MailLogger
        {
            get
            {
                if (_sl == null)
                {
                    _sl = log4net.LogManager.GetLogger("maillog");
                }
                return _sl;
            }
        }
    }
}