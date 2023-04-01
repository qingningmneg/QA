using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kuade.WinControls.ExtOption
{
    public partial class ExtJudge : UserControl
    {
        public ExtJudge()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回答案内容
        /// </summary>
        /// <returns></returns>
        public string eddText()
        {
            var a = "";

            if (CkYes.Checked == true)
            {
                a = "true";
            }
            if (CkNo.Checked == true)
            {
                a = "false";
            }
            var addText = this.extAnalysis1.extOptions.ExtOptions1.RtfText;

            var json = JsonConvert.SerializeObject(new { YesorNo = a, addText = addText });
            return json;
        }

        public void aedd(string a = "true")
        {
            if (a == "true")
            {
                CkYes.Checked = true;
                return;
            }
            if (a == "false")
            {
                CkNo.Checked = true;
                return;
            }
            MessageBox.Show("没有选项");
            return;
        }

        private void CkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (CkYes.Checked == true)
            {
                extAnalysis1.ExtText("正确");
            }
        }

        private void CkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (CkNo.Checked == true)
            {
                extAnalysis1.ExtText("错误");
            }
        }

        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        
        public void ClearMemorys()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion
    }
}
