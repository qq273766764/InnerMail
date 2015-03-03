using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Web;
using System.Data.Entity;

namespace WebMail2.Codes
{
    /// <summary>
    /// 邮件发送队列
    /// </summary>
    public static class MailStateQueue
    {
        #region Config
        /// <summary>
        /// 空队列时休眠时间增加
        /// </summary>
        private static int MailStateSleepTimeAdd;
        /// <summary>
        /// 线程休眠时间
        /// </summary>
        private static int MailStateSleepTime
        {
            get
            {
                int tmp = 100;
                int.TryParse(ConfigurationManager.AppSettings["MailStateSleepTime"], out tmp);
                return tmp;
            }
        }
        /// <summary>
        /// 初始化时检查发送不成功邮件的最大数量
        /// </summary>
        private static int RestartCheckMailCount
        {
            get
            {
                int tmp = 10;
                int.TryParse(ConfigurationManager.AppSettings["RestartCheckMailCount"], out tmp);
                return tmp;
            }
        }
        /// <summary>
        /// 单次存储邮件最大数量
        /// </summary>
        private static int SaveMailCount
        {
            get
            {
                int tmp = 100;
                int.TryParse(ConfigurationManager.AppSettings["SaveMailCount"], out tmp);
                return tmp;
            }
        }
        /// <summary>
        /// 邮件队列最大数量
        /// </summary>
        private static int MailQueueMaxCount
        {
            get
            {
                int tmp = 10000;
                int.TryParse(ConfigurationManager.AppSettings["MailQueueMaxCount"], out tmp);
                return tmp;
            }
        }
        #endregion

        private static Queue<Model.MailState> _StateQueue;
        /// <summary>
        /// 邮件队列
        /// </summary>
        private static Queue<Model.MailState> StateQueue
        {
            get
            {
                if (_StateQueue == null) { _StateQueue = new Queue<Model.MailState>(); }
                return _StateQueue;
            }
        }
        /// <summary>
        /// 向队列中添加邮件
        /// </summary>
        /// <param name="State"></param>
        public static void Enqueue(Model.MailState State)
        {
            if (StateQueue.Count == MailQueueMaxCount) { throw new Exception("邮件队列已达到最大值！"); }
            StateQueue.Enqueue(State);
        }
        /// <summary>
        /// 初始化线程
        /// </summary>
        public static void Init()
        {
            LoggerHelper.MailLogger.Info("【邮件发送线程】邮件发送线程启动成功！");
            MailStateSleepTimeAdd = 0;
            _IsInitCheck = true;
            //初始化检查邮件
            InitCheckMail();
            while (true)
            {
                SaveMailSates();
                _IsInitCheck = false;
                Thread.Sleep((MailStateSleepTime + MailStateSleepTimeAdd)*1000);
            }
        }
        /// <summary>
        /// 存储邮件
        /// </summary>
        private static void SaveMailSates()
        {
            try
            {
                //如果是空队列，休眠时间增量为30秒
                if (StateQueue.Count == 0) { MailStateSleepTimeAdd = 30; return; } else { MailStateSleepTimeAdd = 0;}
                DateTime starttime = DateTime.Now;
                List<Model.MailState> Datas = new List<Model.MailState>();
                int Count = StateQueue.Count > SaveMailCount ? SaveMailCount : StateQueue.Count;
                using (var DataEntity = new Model.mailEntities())
                {
                    for (int i = 0; i < Count; i++)
                    {
                        DataEntity.MailState.AddObject(StateQueue.Dequeue());
                    }
                    DataEntity.SaveChanges(System.Data.Objects.SaveOptions.None);
                }
                Codes.LoggerHelper.MailLogger.Info(
                    string.Format("【邮件发送线程】单次存储邮件状态完成，已存储{0}条，剩余{1}，耗时：{2}ms", Count, StateQueue.Count, (DateTime.Now - starttime).TotalMilliseconds.ToString("0")));
            }
            catch (Exception exp)
            {
                Codes.LoggerHelper.MailLogger.Error("【邮件发送线程】发送邮件队列出错！", exp);
            }
        }
        /// <summary>
        /// 检查上次发送失败邮件
        /// </summary>
        private static void InitCheckMail()
        {
            LoggerHelper.MailLogger.Info("【邮件发送线程】初始化开始…");
            DateTime starttime = DateTime.Now;
            using (var DataEntity = new Model.mailEntities())
            {
                var Mails = DataEntity.MailInfo.OrderByDescending(i => i.ID).Take(RestartCheckMailCount);

                foreach (var mail in Mails)
                {
                    ///记录发送用户
                    var MailAddrs = mail.AddresseeIds.Split(',');
                    var MailAddrNames = mail.AddresseeNames.Split(',');
                    Dictionary<string, string> DicIDNames = new Dictionary<string, string>();
                    for (int i = 0; i < MailAddrs.Length; i++) { if (!string.IsNullOrWhiteSpace(MailAddrs[i]) && MailAddrs[i] != mail.SendFromId)  {  DicIDNames.Add(MailAddrs[i], MailAddrNames[i]); } }
                    var AddrCount = DicIDNames.Count;
                    var MailStates = DataEntity.MailState.Where(i => i.MailId == mail.ID && i.Uid != mail.SendFromId);
                    var StateCont = MailStates.Count();
                    ///如果数量不等，则邮件发送不成功！
                    if (AddrCount > StateCont)
                    {
                        var StateUsers = MailStates.Select(i => i.Uid).ToArray();
                        var ExceptUsers = MailAddrs.Except(StateUsers).Except(new string[]{mail.SendFromId}) ;
                        foreach (var uid in ExceptUsers)
                        {
                            Model.MailState data = new Model.MailState()
                            {
                                DelTime = null,
                                Uid = uid,
                                UName = DicIDNames[uid],
                                MailId = mail.ID,
                                DustbinTimeInbox = null,
                                DustbinTimeOutbox = null,
                                IsDel = false,
                                IsDustbinInbox = false,
                                IsDustbinOutbox = false,
                                IsRead = false,
                                ReadTime = DateTime.Now
                            };
                            Enqueue(data);
                        }
                    }
                }
            }
            LoggerHelper.MailLogger.Info(string.Format("【邮件发送线程】初始化完成，找出{0}封未发送成功邮件，耗时：{1}ms", StateQueue.Count, (DateTime.Now - starttime).TotalMilliseconds.ToString("0")));
        }
        private static bool _IsInitCheck;
        public static bool IsInitCheck { get { return _IsInitCheck; } }
    }
}