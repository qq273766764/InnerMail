using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class SendMail : BasePage
    {
        protected int MailID
        {
            get
            {
                int id = 0;
                int.TryParse(Request["id"], out id);
                return id;
            }
        }
        protected Codes.EnumMailAction MailAction { get { return Codes.EnumHelper.GetEnum<Codes.EnumMailAction>(Request["act"]); } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPage();
                Bind();
            }
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text)) { new Codes.MessageBox(this).Show("请输入邮件主题").Send(); return; }
            if (string.IsNullOrWhiteSpace(hid_UserIDs.Value)) { new Codes.MessageBox(this).Show("请选择收件人").Send(); return; }
            if (SaveEmail(false)) { Response.Redirect("MailBlank.aspx?act=send"); }
        }
        /// <summary>
        /// 存草稿
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text)) { new Codes.MessageBox(this).Show("请输入邮件主题").Send(); return; }
            if (SaveEmail(true)) { Response.Redirect("MailBlank.aspx?act=draft"); }
        }

        protected bool SaveEmail(bool isDraft)
        {
            try
            {
                var user = new Codes.CodeHelper().GetCurrentUserInfo();
                Model.MailInfo Mail = new Model.MailInfo()
                    {
                        AddresseeIds = hid_UserIDs.Value,
                        AddresseeNames = hid_UserNames.Value,
                        Content = hid_Content.Value,
                        IsDraft = isDraft,
                        Level = Convert.ToInt32(hid_Stars.Value),
                        SendFromId = user.UserID,
                        SendFromName = user.Name,
                        SendTime = DateTime.Now,
                        Subject = txtSubject.Text
                    };
                if (MailAction == Codes.EnumMailAction.Edit) { Mail.ID = MailID; }
                var Attas = Uploadify1.GetFiles().Select(i => new Model.Attachments()
                {
                    FileId = i.FileId,
                    FileName = i.FileName,
                    FilePath = i.FilePath,
                    FileSize = i.FileSize
                }).ToList();
                new Codes.DataProvider().SendMail(Mail, Attas);
                return true;

            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("【发送邮件】发送邮件错误！", exp);
                new Codes.MessageBox(this).Show("邮件发送失败，错误："+exp.Message).Send();
                return false;
            }
        }

        protected void Bind()
        {
            Model.MailInfo MailInfo;
            Codes.DataProvider DataProvider = new Codes.DataProvider(); ;
            switch (MailAction)
            {
                case Codes.EnumMailAction.Send:
                    break;
                case Codes.EnumMailAction.Edit: //草稿箱编辑邮件
                    MailInfo = DataProvider.QueryMailByID(MailID);
                    if (MailInfo != null)
                    {
                        txtSubject.Text = MailInfo.Subject;
                        ltr_Content.Text = MailInfo.Content;
                        txt_UserNames.Text =
                            hid_UserNames.Value = MailInfo.AddresseeNames;
                        hid_UserIDs.Value = MailInfo.AddresseeIds;
                    }
                    Uploadify1.SetFiles(DataProvider.QueryAttachmentsByMailId(MailID).Select(i => new Ctrs.UploadifyFile
                    {
                        ID = i.ID,
                        FileId = i.FileId,
                        FileName = i.FileName,
                        FilePath = i.FilePath,
                        FileSize = i.FileSize.Value
                    }).ToList());
                    break;

                case Codes.EnumMailAction.Forward: //转发邮件
                    MailInfo = DataProvider.QueryMailByID(MailID);
                    if (MailInfo != null)
                    {
                        txtSubject.Text = "转发： " + MailInfo.Subject;
                        ltr_Content.Text = string.Format(
@"<br/><br/><br/>------------------ 原始邮件 ------------------<br/>
<div style='FONT-SIZE: 12px; BACKGROUND: #efefef; PADDING-BOTTOM: 8px; PADDING-TOP: 8px; PADDING-LEFT: 8px; PADDING-RIGHT: 8px'>
<b>发件人：</b>{0}<br/>
<b>发送时间：</b>{1}<br/>
<b>收件人：</b>{2}<br/>
<b>主题：</b>{3}<br/>
</div>
{4}
<br/>",
                        MailInfo.SendFromName,
                        MailInfo.SendTime.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                        ShortAddresName(MailInfo.AddresseeNames, 140), txtSubject.Text,
                        MailInfo.Content);
                    }
                    Uploadify1.SetFiles(DataProvider.QueryAttachmentsByMailId(MailID).Select(i => new Ctrs.UploadifyFile
                    {
                        ID = i.ID,
                        FileId = i.FileId,
                        FileName = i.FileName,
                        FilePath = i.FilePath,
                        FileSize = i.FileSize.Value
                    }).ToList());
                    break;

                case Codes.EnumMailAction.Reply: //回复邮件
                    MailInfo = DataProvider.QueryMailByID(MailID);
                    if (MailInfo != null)
                    {
                        txtSubject.Text = "回复： " + MailInfo.Subject;
                        ltr_Content.Text = string.Format(
@"<br/><br/><br/>------------------ 原始邮件 ------------------<br/>
<div style='FONT-SIZE: 12px; BACKGROUND: #efefef; PADDING-BOTTOM: 8px; PADDING-TOP: 8px; PADDING-LEFT: 8px; PADDING-RIGHT: 8px'>
<b>发件人：</b>{0}<br/>
<b>发送时间：</b>{1}<br/>
<b>收件人：</b>{2}<br/>
<b>主题：</b>{3}<br/>
</div>
{4}
<br/>",
                        MailInfo.SendFromName,
                        MailInfo.SendTime.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                        ShortAddresName(MailInfo.AddresseeNames, 140), txtSubject.Text,
                        MailInfo.Content);
                        hid_UserIDs.Value = MailInfo.SendFromId;
                        hid_UserNames.Value = MailInfo.SendFromName;
                        txt_UserNames.Text = MailInfo.SendFromName;
                    }
                    break;
            }
        }
        protected void BindPage()
        {
            var user = new Codes.CodeHelper().GetCurrentUserInfo();
            lab_SendName.Text = string.Format("发件人：{0}&lt{1}&gt - [{2:yyyy年MM月dd日（ddd） HH:mm}]", user.Name, user.LoginName, DateTime.Now);
        }

        protected string ShortAddresName(string names, int length)
        {
            if (names.Length > length) { return names.Substring(0, length) + " …"; }
            return names;
        }
    }
}