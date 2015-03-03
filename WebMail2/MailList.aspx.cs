using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class List_RightLeft : BasePage
    {
        public string DataType { get { if (string.IsNullOrEmpty(Request["t"])) { return "1"; } return Request["t"]; } }
        public new string Title
        {
            get
            {
                switch (Codes.EnumHelper.GetEnum<Codes.EnumMailType>(DataType))
                {
                    case Codes.EnumMailType.DraftMail:
                        return "草稿箱";
                    case Codes.EnumMailType.DustMail:
                        return "垃圾箱";
                    case Codes.EnumMailType.InMail:
                        return "收件箱";
                    case Codes.EnumMailType.OutMail:
                        return "发件箱";
                    default:
                        return "邮件列表";
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}