using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2.Ctrs
{
    public partial class AttachList : System.Web.UI.UserControl
    {
        public int MailID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && MailID != 0)
            {
                var DataProvider = new Codes.DataProvider();
                Repeater1.DataSource = DataProvider.QueryAttachmentsByMailId(MailID);
                Repeater1.DataBind();
            }
        }

        protected string GetDownLoadLink(string fileid,string filepath)
        {
            if (filepath.StartsWith("%"))
            {
                return SSO.Utilities.CfgHelper.ExpandUrl(filepath);
            }
            else {
                return "/Server/Download.ashx?fid=" + fileid;
            }
        }
    }
}