using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class MailBlank : BasePage,SSO.IWithoutLogin
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hid_act.Value=Request["act"];
                switch (Request["act"])
                {
                    case "init":
                        labMessage.Text = "系统正在初始化，预计需要一分时间，请稍等…";
                        labMessage.Font.Size = 30;
                        labMessage.ForeColor = System.Drawing.Color.FromArgb(104, 123, 143);
                        break;
                    case "del":
                        labMessage.Text = "邮件已删除！";
                        break;
                    case "del2":
                        labMessage.Text = "邮件已彻底删除！";
                        break;
                    case "send":
                        labMessage.Text = "邮件发送成功\\(^o^)/！";
                        labMessage.Font.Size = 30;
                        labMessage.ForeColor = System.Drawing.Color.FromArgb(104, 123, 143);
                        break;
                    case "draft":
                        labMessage.Text = "邮件存草稿成功\\(^o^)/！";
                        labMessage.Font.Size = 30;
                        labMessage.ForeColor = System.Drawing.Color.FromArgb(104, 123, 143);
                        break;
                    case "debug":
                        labMessage.Text = "请您将使用中遇到的问题提交至 <span style='color:red'>happyboy.cwj@qq.com</span>，<br/>我们将会尽快为您处理，并将结果反馈给您！";
                        labMessage.Font.Size = 26;
                        labMessage.ForeColor = System.Drawing.Color.Black;
                        labMessage.Font.Bold = false;
                        break;
                    default:
                        labMessage.Text = "邮件预览";
                        break;
                }
            }
        }
    }
}