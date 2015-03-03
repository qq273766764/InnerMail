using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebMail2.Codes
{
    /// <summary>
    /// 检查删除邮件线程
    /// </summary>
    public static class MailDeleteThread
    {
        #region Config
        /// <summary>
        /// 邮件删除线程休眠时间
        /// </summary>
        private static int MailDeleteSleepTime { get { return Convert.ToInt32(ConfigurationManager.AppSettings["MailDeleteSleepTime"]); } }

        /// <summary>
        /// 跳过最近的邮件，防止邮件删除与发邮件冲突。造成邮件发送不成功！
        /// </summary>
        private static int NotDeleteMailCount = 200;
        #endregion

        private static Queue<int> _DeleteMailIDQueue;
        private static Queue<int> DeleteMailIDQueue { get { if (_DeleteMailIDQueue == null) { _DeleteMailIDQueue = new Queue<int>(); } return _DeleteMailIDQueue; } }

        public static void Init()
        {
            LoggerHelper.MailLogger.Info("【自动删除线程】邮件删除线程启动成功，初始化开始！");
            _IsInitCheck = true;
            CheckDeleteMail(200,true);
            _IsInitCheck = false;
            LoggerHelper.MailLogger.Info("【自动删除线程】初始化完成！");
        }

        public static void CheckDeleteMail(int delcount,bool CheckMailCount=false)
        {
            try
            {
                using (var DataEntity = new Model.mailEntities())
                {
                    if (DeleteMailIDQueue.Count == 0 && CheckMailCount)
                    {
                        DateTime start = DateTime.Now;
                        /*找出所有要删除的邮件，并添加到删除队列*/
                        //未删除的邮件ID集合
                        var NotDeleteMailIDs = DataEntity.MailState.Where(i => i.IsDel == false).Select(i => i.MailId).Distinct();
                        //应删除的邮件ID集合
                        var MailIDs =
                            DataEntity.MailInfo
                            .Where(i => !NotDeleteMailIDs.Contains(i.ID))
                            .OrderByDescending(i => i.ID)
                            .Skip(NotDeleteMailCount)
                            .Select(i => i.ID);
                        foreach (var mailid in MailIDs) { DeleteMailIDQueue.Enqueue(mailid); }
                        Codes.LoggerHelper.MailLogger.Info(string.Format("【自动删除线程】已找出{0}封待删除邮件，耗时：{1}ms", DeleteMailIDQueue.Count,(DateTime.Now-start).TotalMilliseconds));
                    }
                    if (DeleteMailIDQueue.Count == 0) return;
                    //从队列里取出几条待删除
                    
                    List<int> DelIDs = new List<int>();
                    for (int i = 0; i < delcount; i++) { if (DeleteMailIDQueue.Count > 0) DelIDs.Add(DeleteMailIDQueue.Dequeue()); }
                    if (DelIDs.Count == 0) return;
                    foreach (var mailid in DelIDs)
                    {
                        ///删除状态
                        var StateDatas = DataEntity.MailState.Where(i => i.MailId == mailid);
                        foreach (var state in StateDatas) { DataEntity.MailState.DeleteObject(state); }
                        ///删除附件
                        var MailAttaDatas = DataEntity.Attachments.Where(i => i.MailId == mailid);
                        foreach (var mailatta in MailAttaDatas) { DataEntity.Attachments.DeleteObject(mailatta); }
                        ///删除邮件
                        var MailInfoDatas = DataEntity.MailInfo.Where(i => i.ID == mailid);
                        foreach (var mailinfo in MailInfoDatas) { DataEntity.MailInfo.DeleteObject(mailinfo); }
                    }
                    DateTime delStartTime = DateTime.Now;
                    DataEntity.SaveChanges(System.Data.Objects.SaveOptions.None);
                    Codes.LoggerHelper.MailLogger.Info(string.Format("【自动删除线程】已自动删除{0}封邮件，耗时:{1}ms", DelIDs.Count, (DateTime.Now - delStartTime).TotalMilliseconds.ToString("0")));
                }

            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("【自动删除线程】检查删除邮件出错！", exp);
            }
        }
        private static bool _IsInitCheck;
        public static bool IsInitCheck { get { return _IsInitCheck; } }
    }
}