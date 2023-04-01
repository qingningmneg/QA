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

namespace Kuade.WinControls
{
    public partial class ExtAnswer : UserControl
    {
        public ExtAnswer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回答案内容
        /// </summary>
        /// <returns></returns>
        public string eddText()
        {
            var EditTexts = this.extAnalysis1.extOptions1.ExtOptions1.RtfText;//答案
            var addText = this.extAnalysis1.extOptions.ExtOptions1.RtfText;//解析

            var json = JsonConvert.SerializeObject(new { EditTexts = EditTexts, addText = addText });
            return json;
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
