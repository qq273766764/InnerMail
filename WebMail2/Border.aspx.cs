using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class Border : BasePage
    {
        protected int CountSend;
        protected int CountRecive;
        protected int CountNotRead;
        protected int CountDraft;
        protected int CountDust;

        protected decimal SumSendAttachs;
        protected decimal SumReciveAttachs;
        protected decimal SumTotalAttachs;
        protected decimal SumLastAttachs;

        protected string SumSendAttachsStr;
        protected string SumReciveAttachsStr;
        protected string SumLastAttachsStr;
        protected string SumTotalAttachsStr;

        protected decimal TotalSize
        {
            get
            {
                int Size=0;
                if (!int.TryParse(ConfigurationManager.AppSettings["AttachMaxSize"], out Size)) {
                    Size = 500;
                }
                return Size * 1024 * 1024;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var DataProvider = new Codes.DataProvider();
            var user = new Codes.CodeHelper().GetCurrentUserInfo();
            var userID = user.UserID;
            lab_UserName.Text = user.Name;

            CountDraft = DataProvider.CountDraftBox(userID);
            CountDust = DataProvider.CountDustBox(userID);
            CountNotRead = DataProvider.CountReciveBox(userID, false);
            CountRecive = DataProvider.CountReciveBox(userID, true) + CountNotRead;
            CountSend = DataProvider.CountSendMailBox(userID);

            SumSendAttachs = DataProvider.SumSendAttachSize(userID);
            SumReciveAttachs = DataProvider.SumReciveAttachSize(userID);
            SumTotalAttachs = SumSendAttachs + SumReciveAttachs;
            SumLastAttachs = TotalSize - SumTotalAttachs;

            SumSendAttachsStr = Codes.CodeHelper.ShowSize(SumSendAttachs);
            SumReciveAttachsStr = Codes.CodeHelper.ShowSize(SumReciveAttachs);
            SumTotalAttachsStr = Codes.CodeHelper.ShowSize(SumTotalAttachs);
            SumLastAttachsStr = Codes.CodeHelper.ShowSize(SumLastAttachs);
        }
    }
}