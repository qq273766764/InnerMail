using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public class SessionMgr
    {
        private string SessionKey = "WebMail2.Codes.SessionMgr.";
        public void Add(string key, object value)
        {
            HttpContext.Current.Session.Add(SessionKey + key, value);
        }
        public object Get(string key)
        {
            return HttpContext.Current.Session[SessionKey + key];
        }
    }
}