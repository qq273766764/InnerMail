using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMail2.Ctrs
{
    public partial class Uploadify : System.Web.UI.UserControl
    {
        /// <summary>
        /// 可上传附件类型
        /// </summary>
        public string FileExts { get; set; }
        public void SetFiles(List<UploadifyFile> files)
        {
            hid_files.Value = new JavaScriptSerializer().Serialize(files);
        }

        public List<UploadifyFile> GetFiles()
        {
            if (string.IsNullOrWhiteSpace(hid_files.Value)) { return new List<UploadifyFile>(); }
            var files=new JavaScriptSerializer().Deserialize<UploadifyFile[]>(hid_files.Value).Where(i => i.IsDel == false).ToList();
            return files;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FileExts = string.Join(";", ConfigurationManager.AppSettings["AllowUploadFileExt"].Split(',').Select(i => "*" + i));
        }
    }

    public class UploadifyFile
    {
        public int ID { get; set; }
        private bool _IsDel = false;
        public string FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public double FileSize { get; set; }
        public bool IsDel { get { return _IsDel; } set { _IsDel = value; } }
        public string FileSizeString { get { return Codes.CodeHelper.ShowSize(FileSize); } }
    }
}