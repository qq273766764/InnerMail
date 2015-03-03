using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public class MailInfoCache
    {
        protected static int MailCacheMaxCount = 100;

        protected static List<Model.MailInfo> CacheData;

        public static void AddCache(Model.MailInfo mail)
        {
            if (CacheData == null) { CacheData = new List<Model.MailInfo>(); }
            ///需要移除缓存的邮件数量
            if (CacheData.Count >= MailCacheMaxCount) { CacheData.RemoveAt(0); }
            CacheData.Add(mail);
        }

        public static Model.MailInfo GetMailInfo(int Id)
        {
            if (CacheData == null) return null;
            return CacheData.Where(i => i.ID == Id).FirstOrDefault();
        }
    }
}