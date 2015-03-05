using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public class DataProvider
    {

        protected Model.mailEntities DataEntity;

        public DataProvider()
        {
            DataEntity = new Model.mailEntities();
        }

        ~DataProvider() {
            DataEntity.Dispose();
            DataEntity = null;
        }

        #region Query
        /// <summary>
        /// 阅读邮件
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Model.MailInfo ReadMailByID(int ID, string uid, bool RefrashStaus = false)
        {
            if (RefrashStaus)
            {
                var mailState = DataEntity.MailState.Where(i => i.MailId == ID && i.Uid == uid).FirstOrDefault();
                if (mailState.IsRead == false) { mailState.IsRead = true; DataEntity.SaveChanges(); }
            }
            var mailInfo = MailInfoCache.GetMailInfo(ID);
            if (mailInfo == null)
            {
                mailInfo = DataEntity.MailInfo.Where(i => i.ID == ID).FirstOrDefault();
                MailInfoCache.AddCache(mailInfo);
            }
            return mailInfo;
        }
        /// <summary>
        /// 取得邮件信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Model.MailInfo QueryMailByID(int ID)
        {
            var mailInfo = MailInfoCache.GetMailInfo(ID);
            if (mailInfo == null)
            {
                mailInfo = DataEntity.MailInfo.Where(i => i.ID == ID).FirstOrDefault();
                MailInfoCache.AddCache(mailInfo);
            }
            return mailInfo;
        }
        /// <summary>
        /// 查询邮件状态
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<Model.MailState> QueryMailStateByMailID(int ID, string uName, int PageIndex, int PageSize, out int Count)
        {
            var Datas = DataEntity.MailState.Where(i => i.MailId == ID);
            if (!string.IsNullOrWhiteSpace(uName)) { Datas = Datas.Where(i => i.UName.Contains(uName)); }
            Count = Datas.Count();
            return Datas.OrderBy(i => i.IsRead).ThenBy(i => i.UName).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
        /// <summary>
        /// 取得邮件附件
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<Model.Attachments> QueryMailAttachmentsByMailID(int ID)
        {
            return DataEntity.Attachments.Where(i => i.MailId == ID).ToList();
        }
        /// <summary>
        /// 发件箱
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="IsDraft"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public List<Model.View_AllMail_NoGUID> QuerySendMailBox(string uid, bool IsDraft, string key, int pageindex, int pagesize, out int Count)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
                .Where(i =>
                    i.SendFromId == uid &&
                    i.IsDraft == IsDraft &&
                    i.Uid == uid &&
                    i.IsDustbinOutbox == false &&
                    i.IsDustbinInbox == false &&
                    i.IsDel == false);

            if (!string.IsNullOrWhiteSpace(key)) { Datas = Datas.Where(i => i.Subject.Contains(key)); }
            Count = Datas.Count();
            var ReturnData = Datas.OrderByDescending(i => i.SendTime).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return ReturnData;
        }
        /// <summary>
        /// 收件箱
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Model.View_AllMail_NoGUID> QueryReciveMailBox(string uid, string key, int pageindex, int pagesize, out int count)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
                .Where(i =>
                    i.Uid == uid &&
                    i.IsDustbinInbox == false &&
                    i.IsDustbinOutbox == false &&
                    i.IsDel == false);
            if (!string.IsNullOrWhiteSpace(key)) { Datas = Datas.Where(i => i.Subject.Contains(key)); }
            Datas = Datas.Where(i => i.SendFromId != uid || i.AddresseeIds.Contains(uid));
            count = Datas.Count();
            return Datas.OrderByDescending(i => i.ID).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }
        /// <summary>
        /// 查询草稿箱
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public List<Model.View_AllMail_NoGUID> QueryDraftMailBox(string uid, string key, int pageindex, int pagesize, out int Count)
        {
            return QuerySendMailBox(uid, true, key, pageindex, pagesize, out Count);
        }
        /// <summary>
        /// 查询垃圾箱内容
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public List<Model.View_AllMail_NoGUID> QueryDustbinBox(string uid, string key, int pageindex, int pagesize, out int Count)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
                .Where(i => i.IsDel == false && ((i.SendFromId == uid && i.IsDustbinOutbox == true) || (i.Uid == uid && i.IsDustbinInbox == true)));
            if (!string.IsNullOrWhiteSpace(key)) { Datas = Datas.Where(i => i.Subject.Contains(key)); }
            Count = Datas.Count();
            return Datas.OrderByDescending(i => i.ID).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }

        /// <summary>
        /// 查询邮件附件
        /// </summary>
        /// <param name="mailid"></param>
        /// <returns></returns>
        public List<Model.Attachments> QueryAttachmentsByMailId(int mailid)
        {
            var Datas = DataEntity.Attachments.Where(i => i.MailId.Value == mailid).ToList();
            return Datas;
        }

        /// <summary>
        /// 查询邮件附件
        /// </summary>
        /// <param name="mailid"></param>
        /// <returns></returns>
        public Model.Attachments QueryAttachmentById(int attaid)
        {
            return DataEntity.Attachments.Where(i => i.ID == attaid).FirstOrDefault();
        }
        #endregion

        #region Count
        /// <summary>
        /// 统计发件箱数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="IsDraft"></param>
        /// <returns></returns>
        public int CountSendMailBox(string uid)
        {

            var Datas = DataEntity.View_AllMail_NoGUID
            .Where(i =>
                i.SendFromId == uid &&
                i.IsDraft == false &&
                i.Uid == uid &&
                i.IsDustbinOutbox == false &&
                i.IsDustbinInbox == false &&
                i.IsDel == false);

            return Datas.Count();
        }
        /// <summary>
        /// 统计收件箱数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="isRead"></param>
        /// <returns></returns>
        public int CountReciveBox(string uid, bool isRead)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
            .Where(i =>
                i.IsRead.Value == isRead &&
                i.Uid == uid &&
                i.IsDustbinInbox == false &&
                i.IsDustbinOutbox == false &&
                i.IsDel == false);
            Datas = Datas.Where(i => i.SendFromId != uid || i.AddresseeIds.Contains(uid));
            return Datas.Count();
        }
        /// <summary>
        /// 统计草稿箱数量
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public int CountDraftBox(string uid)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
            .Where(i =>
                i.SendFromId == uid &&
                i.IsDraft == true &&
                i.IsDustbinOutbox == false &&
                i.IsDustbinInbox == false &&
                i.IsDel == false);

            return Datas.Count();
        }
        /// <summary>
        /// 统计垃圾箱内容
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public int CountDustBox(string uid)
        {
            var Datas = DataEntity.View_AllMail_NoGUID
                  .Where(i => i.IsDel == false && ((i.SendFromId == uid && i.IsDustbinOutbox == true) || (i.Uid == uid && i.IsDustbinInbox == true)));

            return Datas.Count();
        }
        #endregion

        #region Sum
        /// <summary>
        /// 统计邮件容量
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public decimal SumSendAttachSize(string uid)
        {
            var sMgr = new SessionMgr();
            if (sMgr.Get("SumSendAttachSize") == null)
            {
                var AttaSizes = (from mail in DataEntity.View_AllMail_NoGUID
                                 join atta in DataEntity.Attachments
                                 on mail.ID equals atta.MailId
                                 where mail.SendFromId == uid && mail.IsDel == false && mail.Uid == uid
                                 select atta).Distinct().Sum(i => i.FileSize);
                sMgr.Add("SumSendAttachSize", AttaSizes);
            }
            return Convert.ToDecimal(sMgr.Get("SumSendAttachSize"));
        }
        /// <summary>
        /// 统计邮件容量
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public decimal SumReciveAttachSize(string uid)
        {
            var sMgr = new SessionMgr();
            if (sMgr.Get("SumReciveAttachSize") == null)
            {
                var AttaSizes = (from mail in DataEntity.View_AllMail_NoGUID
                                 join atta in DataEntity.Attachments
                                 on mail.ID equals atta.MailId
                                 where mail.Uid == uid && mail.IsDel == false && mail.SendFromId != uid
                                 select atta).Distinct().Sum(i => i.FileSize);
                sMgr.Add("SumReciveAttachSize", AttaSizes);
            }
            return Convert.ToDecimal(sMgr.Get("SumReciveAttachSize"));
        }

        #endregion

        #region Delete
        /// <summary>
        /// 删除发件箱或草稿箱
        /// </summary>
        /// <param name="uid">发送用户</param>
        /// <param name="MailIds"></param>
        public void DeleteSendMailBox(string uid, int[] MailIds, bool isDel)
        {
            var Datas = DataEntity.MailState.Where(i => MailIds.Contains(i.MailId.Value) && i.Uid == uid);
            foreach (var data in Datas)
            {
                if (isDel)
                {
                    data.IsDel = true;
                }
                else
                {
                    data.IsDustbinOutbox = true; data.DustbinTimeOutbox = DateTime.Now;
                }
            }
            DataEntity.SaveChanges();
        }
        /// <summary>
        /// 删除草稿箱内容
        /// </summary>
        /// <param name="uid">发送用户</param>
        /// <param name="MailIds"></param>
        public void DeleteDraftMailBox(string uid, int[] MailIds, bool isDel)
        {
            DeleteSendMailBox(uid, MailIds, isDel);
        }
        /// <summary>
        /// 删除收件箱内容
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="StateIds"></param>
        public void DeleteReciveMailBox(string uid, int[] MailIds, bool isDel)
        {
            var Datas = DataEntity.MailState.Where(i => MailIds.Contains(i.MailId.Value) && i.Uid == uid);
            foreach (var data in Datas)
            {
                if (isDel) { data.IsDel = true; }
                else
                {
                    data.IsDustbinInbox = true; data.DustbinTimeInbox = DateTime.Now;
                }
            }
            DataEntity.SaveChanges();
        }
        /// <summary>
        /// 删除垃圾箱收件内容
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="MailIds"></param>
        public void DeleteDustBinBox(string uid, int[] MailIds)
        {
            var Datas = DataEntity.MailState.Where(i => MailIds.Contains(i.MailId.Value) && i.Uid == uid);
            foreach (var data in Datas) { data.IsDel = true; }
            DataEntity.SaveChanges();
        }
        #endregion

        #region SendMail
        public void SendMail(Model.MailInfo mail, List<Model.Attachments> Attas)
        {
            if (mail.ID == 0)
            {
                DataEntity.MailInfo.AddObject(mail);
                DataEntity.SaveChanges();
                var SenderState = new Model.MailState()
                {
                    DelTime = new DateTime(1990, 1, 1),
                    DustbinTimeInbox = new DateTime(1990, 1, 1),
                    DustbinTimeOutbox = new DateTime(1990, 1, 1),
                    IsDel = false,
                    IsDustbinInbox = false,
                    IsDustbinOutbox = false,
                    IsRead = true,
                    MailId = mail.ID,
                    ReadTime = DateTime.Now,
                    Uid = mail.SendFromId,
                    UName = mail.SendFromName
                };
                DataEntity.MailState.AddObject(SenderState);
                DataEntity.SaveChanges();
            }
            else
            {
                var OldMail = DataEntity.MailInfo.Where(i => i.ID == mail.ID).FirstOrDefault();
                if (OldMail != null)
                {
                    OldMail.AddresseeIds = mail.AddresseeIds;
                    OldMail.AddresseeNames = mail.AddresseeNames;
                    OldMail.Content = mail.Content;
                    OldMail.IsDraft = mail.IsDraft;
                    OldMail.Level = mail.Level;
                    OldMail.SendFromId = mail.SendFromId;
                    OldMail.SendFromName = mail.SendFromName;
                    OldMail.SendTime = mail.SendTime;
                    OldMail.Subject = mail.Subject;
                }
                DataEntity.SaveChanges();
            }
            ///发送收件人信息
            if (!mail.IsDraft.Value)
            {
                Dictionary<string, string> Dic_IDNames = new Dictionary<string, string>();
                string[] UIds = mail.AddresseeIds.Split(',');
                string[] UNames = mail.AddresseeNames.Split(',');
                for (int i = 0; i < UIds.Length; i++)
                {
                    //发送给自己的邮件不要重复添加状态
                    if (UIds[i] == mail.SendFromId) continue;
                    Codes.MailStateQueue.Enqueue(new Model.MailState()
                    {
                        DelTime = new DateTime(1990, 1, 1),
                        DustbinTimeInbox = new DateTime(1990, 1, 1),
                        DustbinTimeOutbox = new DateTime(1990, 1, 1),
                        IsDel = false,
                        IsDustbinInbox = false,
                        IsDustbinOutbox = false,
                        IsRead = false,
                        MailId = mail.ID,
                        ReadTime = DateTime.Now,
                        Uid = UIds[i],
                        UName = UNames[i]
                    });
                }
            }
            ///添加附件信息
            if (mail.ID != 0 && Attas.Count > 0)
            {
                var oldAttas = DataEntity.Attachments.Where(i => i.MailId == mail.ID);
                if (oldAttas.Count() > 0) { foreach (var oldatta in oldAttas) { DataEntity.Attachments.DeleteObject(oldatta); } }
                foreach (var atta in Attas)
                {
                    atta.MailId = mail.ID;
                    DataEntity.Attachments.AddObject(atta);
                }
                DataEntity.SaveChanges();
            }
        }
        #endregion
    }
}