using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControls;

namespace Kuade.WinControls.Student
{
    public partial class StudentExtOptions : UserControl
    {
        public StudentExtOptions()
        {
            InitializeComponent();
        }
        public string str = "";
        public void ExtText(byte[] a)
        {
            ExtOptions.RtfText = SqlHelper.RtxBytesToString(a);
        }

        public void RExtTexts()
        {
            this.str = ExtOptions.RtfText;
        }
        public void cold()
        {
            ExtOptions.BackColor = Color.Red;
        }

        private void StudentExtOptions_Load(object sender, EventArgs e)
        {
            System.Drawing.ColorConverter cc = new System.Drawing.ColorConverter();
            System.Drawing.Color c = (System.Drawing.Color)cc.ConvertFromString("#F0F0F0");
            ExtOptions.ActiveView.BackColor = c;//txtEdit1为RichEditControl的一个实例，注意 背景色设置一定要在loaded事件里，否则会报错
            //ExtOptions.ActiveView. = FlatStyle.Flat;
            //btnRandom.FlatStyle = FlatStyle.Flat;//样式
            ExtOptions.Enabled = false;
        }
    }
}
