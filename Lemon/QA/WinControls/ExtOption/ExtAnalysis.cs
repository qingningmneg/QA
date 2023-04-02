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
using WinControls;

namespace Kuade.WinControls
{
    public partial class ExtAnalysis : UserControl
    {
        public ExtAnalysis()
        {
            InitializeComponent();
        }

        public void ExtText(string Text)
        {
            extOptions1.ExtOptions1.Text = Text;
        }

        public void ExtEnabled()
        {
            extOptions1.ExtOptions1.Enabled = false;
            extOptions1.cold();
        }

        /// <summary>
        /// 解析
        /// </summary>
        /// <param name="Text"></param>
        public void ExtTexts(byte[] Text)
        {
            extOptions.ExtOptions1.RtfText = SqlHelper.RtxBytesToString(Text);//解析
        }

        /// <summary>
        /// 答案
        /// </summary>
        /// <param name="Text"></param>
        public void ExtTextss(byte[] Text)
        {
            extOptions1.ExtOptions1.RtfText = SqlHelper.RtxBytesToString(Text);//答案
        }
    }
}
