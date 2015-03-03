using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2
{
    public partial class menu : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var DataProvider = new Codes.DataProvider();
            var user = new Codes.CodeHelper().GetCurrentUserInfo();
            var userID = user.UserID;
            lab_draft.Text = DataProvider.CountDraftBox(userID).ToString();
            lab_dust.Text = DataProvider.CountDustBox(userID).ToString();
            int NotRead=DataProvider.CountReciveBox(userID, false);
            lab_NotRead.Text = NotRead.ToString();
            lab_ReadAll.Text = (DataProvider.CountReciveBox(userID, true)+NotRead).ToString();
            lab_Send.Text = DataProvider.CountSendMailBox(userID).ToString();
        }
    }
}