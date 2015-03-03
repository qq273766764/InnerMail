using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class MailView : BasePage
    {
        protected int MailID { get { return Convert.ToInt32(Request["id"]); } }

        protected bool RefrashStatue { get { bool value = false; bool.TryParse(Request["r"], out value); return !value; } }
        public Codes.EnumMailType DataType { get { return Codes.EnumHelper.GetEnum<Codes.EnumMailType>(Request["t"]); } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindButton();
                BindMail();
            }
        }
        protected void BindMail()
        {
            try
            {
                var user = new Codes.CodeHelper().GetCurrentUserInfo();
                var userID = user.UserID;
                var DataProvider = new Codes.DataProvider();
                var MailView = DataProvider.ReadMailByID(MailID, userID, RefrashStatue);
                if (MailView != null)
                {
                    var MailAttachs = DataProvider.QueryMailAttachmentsByMailID(MailID);
                    labSubject.Text = MailView.Subject;
                    if (MailView.SendTime != null) { labSendTime.Text = MailView.SendTime.Value.ToString("yyyy年MM月dd日（ddd） HH:mm:ss"); }
                    labSender.Text = MailView.SendFromName;
                    ltrAddressName.Text = MailView.AddresseeNames.Length > 50 ?
                        string.Format("{0} … <span class='showaddress' onclick='ShowAddress();' >&nbsp;</span>",
                        MailView.AddresseeNames.Substring(0, 48)) :
                        MailView.AddresseeNames;
                    ltrAddressNameAll.Text = MailView.AddresseeNames;
                    if (MailView.Level != null) { LtrStars.Text = "<span class='stars" + MailView.Level + "'>&nbsp;</span>"; }
                    ltrContext.Text = MailView.Content;
                    AttachList1.MailID = MailID;
                }
            }
            catch (Exception exp)
            {
                var UserInfo = new Codes.CodeHelper().GetCurrentUserInfo();
                Codes.LoggerHelper.MailLogger.Error(
                    string.Format("【邮件预览】加载邮件数据出错，用户：{0}({2} - {1})，邮件ID：{3}",
                    UserInfo.Name,
                    UserInfo.LoginName,
                    UserInfo.UserID,
                    MailID), exp);
            }
        }
        protected void BindButton()
        {
            lnk_Repay.NavigateUrl = "SendMail.aspx?id=" + MailID + "&act=" + Codes.EnumMailAction.Reply.ToString();
            lnk_Repay.Visible = DataType == Codes.EnumMailType.InMail;

            lnk_Forward.NavigateUrl = "SendMail.aspx?id=" + MailID + "&act=" + Codes.EnumMailAction.Forward.ToString();
            lnk_Forward.Visible = DataType == Codes.EnumMailType.InMail || DataType == Codes.EnumMailType.OutMail;

            lnk_Edit.NavigateUrl = "SendMail.aspx?id=" + MailID + "&act=" + Codes.EnumMailAction.Edit.ToString();
            lnk_Edit.Visible = DataType == Codes.EnumMailType.DraftMail;

            lnk_State.Visible = DataType == Codes.EnumMailType.OutMail;
        }
    }
}