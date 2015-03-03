using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebMail2.Codes
{
    public class MessageBox
    {
        private string _JavascriptMessage;

        protected Page p { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p"></param>
        public MessageBox(Page p)
        {
            this.p = p;
        }
        /// <summary>
        /// 在前台页面显示消息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public MessageBox Show(string msg)
        {
            msg = msg.Replace("'", "‘").Replace("\"", "“").Replace("\\","\\ ");
            return javascriptTag("alert('" + msg + "');");
        }
        /// <summary>
        /// 在前台页面显示消息并关闭窗口
        /// </summary>
        /// <param name="s"></param>
        public MessageBox ShowThenClose(string msg)
        {
            msg = msg.Replace("'", "‘").Replace("\"", "“");
            return javascriptTag("alert('" + msg + "');window.opener=null;window.close();");
        }
        /// <summary>
        /// 关闭前台窗口
        /// </summary>
        public MessageBox CloseWindow()
        {
            return javascriptTag("window.opener=null;window.close();");
        }
        /// <summary>
        /// 在前台页面注册JavaScript脚本
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public MessageBox JavaScript(string javascript)
        {
            return javascriptTag(javascript);
        }
        /// <summary>
        /// 刷新父窗口
        /// </summary>
        /// <returns></returns>
        public MessageBox RefrashParent()
        {
            return javascriptTag("window.parent.location.href=window.parent.location.href;");
        }
        /// <summary>
        /// 刷新打开此窗口的窗口
        /// </summary>
        /// <returns></returns>
        public MessageBox RefrashOpener()
        {
            return javascriptTag("window.opener.location.href=window.opener.location.href;");
        }
        /// <summary>
        /// 设置新打开窗口返回值变量，如果是字符串则写：'xxx'，否则写的会被认为是变量名。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public MessageBox SetReturnValue(string var)
        {
            return javascriptTag("window.returnValue=" + var);
        }
        /// <summary>
        /// 转向链接
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public MessageBox NavigateToUrl(string url)
        {
            return javascriptTag("window.location.href='" + url + "';");
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <returns></returns>
        public MessageBox Back()
        {
            return javascriptTag("window.history.back();");
        }
        /// <summary>
        /// 添加注册脚本
        /// </summary>
        /// <param name="s"></param>
        private MessageBox javascriptTag(string javascript)
        {
            _JavascriptMessage += javascript;
            return this;
        }
        /// <summary>
        /// 将代码显示到前台页面
        /// </summary>
        public void Send()
        {
            if (!string.IsNullOrEmpty(_JavascriptMessage))
            {
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(p, p.GetType(), "MessageBoxScript", _JavascriptMessage, true);
            }
        }
    }
}