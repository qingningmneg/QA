using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kuade.WinControls
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtRichEdit : RichEditControl
    {
        public ExtRichEdit()
        {
            //隐藏水平标尺
            Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            //隐藏竖直标尺
            Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden;
            //隐藏水平滚动条
            Options.HorizontalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden;
            //修改版式
            ActiveViewType = RichEditViewType.Simple;
            //背景颜色
            //ActiveView.BackColor = this.BackColor;
            //加载ePub
            //this.richEditControl.LoadDocument(htmlPath, DocumentFormat.ePub);
            //加载Html（背景需要修改html属性）
            //this.richEditControl1.LoadDocument(htmlPath, DocumentFormat.Html);
            Text = "";
        }
        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion

        #region 内存回收
        /// <summary>
        /// 释放内存
        /// </summary>
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

    public class XForm : XtraForm
    {
        public XForm()
        {
            //居中显示
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //dpi
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            //禁止调整窗口大小
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
    }
}
