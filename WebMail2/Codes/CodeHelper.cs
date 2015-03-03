using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public class CodeHelper
    {
        private List<UserInfo> Users
        {
            get
            {
                List<UserInfo> datas = new List<UserInfo>();
                datas.Add(new UserInfo() { UserID = "MFD80CBE1F4029FDD", Name = "超管", LoginName = "sa" });
                datas.Add(new UserInfo() { UserID = "M4109983CFF9C444A", Name = "吴江", LoginName = "103200034" });
                datas.Add(new UserInfo() { UserID = "M2873C15FD6DDC78D", Name = "何良如", LoginName = "104300016" });
                
                return datas;
            }
        }
        public UserInfo GetCurrentUserInfo()
        {
            UserInfo user;
            user = Users[1];
            var help = new SSO.Helper();
            user = help.UserID == null ? Users[2] : new UserInfo()
            {
                UserID = help.UserID,
                LoginName = help.LoginName,
                Name = help.Name
            };
            return user;
        }

        public static string ShowSize(decimal data)
        {
            return ShowSize(Convert.ToDouble(data));
        }
        public static string ShowSize(double data)
        {
            if (data < 0) { return "-" + ShowSize(-data); }
            if (data >= 1000 * 1024 * 1024) { return (data / (1024 * 1024 * 1024)).ToString("N") + "GB"; }
            if (data >= 1000 * 1024) { return (data / (1024 * 1024)).ToString("N") + "MB"; }
            if (data >= 1000) { return (data / 1024).ToString("N") + "KB"; }
            return data.ToString("N") + "B";
        }
    }

    public class UserInfo
    {
        public string UserID;
        public string Name;
        public string LoginName;
    }
}