using DevExpress.XtraEditors.ColorPick.Picker;
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
using System.IO;
using Newtonsoft.Json;
using WinControls;

namespace Kuade.WinControls.ExtOption
{
    public partial class ExtSinglOptionList : UserControl
    {
        private List<char> Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();//数组
        int _itemsCount = 0;//控件数量
        int __MaxCount = 26;
        int _MinCount = 4;

        public ExtSinglOptionList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化控件高度
        /// </summary>
        public void heig()
        {
            this.Height = 60 + 176;//60初始高度,176解析高度
            this.panel.Height = 0;
        }

        /// <summary>
        /// 为文本控件添加text值
        /// </summary>
        /// <param name="a"></param>
        public void labText(int a = 1)
        {
            this.lblText.Text = "第" + a + "题";
        }

        /// <summary>
        /// 为选项排序ABCD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtMulitOptionListSingle_Load(object sender, EventArgs e)
        {
            this.heig();
            //this.AddOption(4);
            var Count = flowOption.Controls.Count;
            for (int i = 0; i < Count; i++)
            {
                (flowOption.Controls[i] as RadioButton).Text = Alpha[i].ToString();
            }
            extAnalysis1.ExtEnabled();
        }

        /// <summary>
        /// 返回答案内容
        /// </summary>
        /// <returns></returns>
        public string eddText()
        {
            var Count = flowOption.Controls.Count;
            List<string> Eng = new List<string>();//ABCD
            List<byte[]> btyText = new List<byte[]>();//正确答案
            List<bool> Enabled = new List<bool>();//答案
            List<string> strText = new List<string>();//答案
            for (int i = 0; i < Count; i++)
            {
                var c = SqlHelper.RtxToBytes((flowText.Controls[i] as ExtOptions).ExtOptions1.RtfText);
                var Text = (flowText.Controls[i] as ExtOptions).ExtOptions1.Text;
                var co = (flowOption.Controls[i] as RadioButton).Checked;
                var A = (flowOption.Controls[i] as RadioButton).Text;
                Eng.Add(A);
                btyText.Add(c);
                Enabled.Add(co);
                strText.Add(Text);
            }
            var addText = this.extAnalysis1.extOptions.ExtOptions1.RtfText;
            var json = JsonConvert.SerializeObject(new { Eng = Eng, btyText = btyText, Enabled = Enabled, strText = strText, addText = addText });
            return json;
        }

        /// <summary>
        /// 添加选项
        /// </summary>
        public void AddOption(int b = 1)
        {
            for (int ab = 0; ab < b; ab++)
            {
                this.Height = this.Height += 105;
                panel.Height = this.panel.Height += 105;
                extAnalysis1.Size = new Size(1151, 176);
                if (_itemsCount <= __MaxCount - 1)
                {
                    RadioButton dia = new RadioButton();//初始化控件
                    ExtOptions ext = new ExtOptions();

                    dia.Click += new EventHandler(dia_Click);
                    dia.Font = new System.Drawing.Font("宋体", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    dia.Text = Alpha[2].ToString();
                    dia.Size = new Size(78, 98);//单选控件大小
                    flowOption.Controls.Add(dia);
                    ext.Size = new Size(960, 82);//内容控件大小
                    flowText.Controls.Add(ext);//窗体添加控件


                    var a = flowOption.Controls.Count;//控件数量
                    for (int i = 0; i < a; i++)
                    {
                        (flowOption.Controls[i] as RadioButton).Text = Alpha[i].ToString();
                    }
                    _itemsCount++;
                }
                else
                {
                    MessageBox.Show("最多只能添加" + __MaxCount + "个选项");
                    return;
                }
            }
        }

        /// <summary>
        /// dia点击触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dia_Click(object sender, EventArgs e)
        {
            this.Obtain();
        }

        /// <summary>
        /// 删除选项
        /// </summary>
        public void DeleteOption()
        {
            if (_itemsCount >= _MinCount + 1)
            {
                for (int i = 0; i < flowOption.Controls.Count; i++)
                {
                    if (flowOption.Controls.Count - 1 == i)
                    {
                        flowOption.Controls.RemoveAt(i);
                    }
                }
                for (int i = 0; i < flowText.Controls.Count; i++)
                {
                    if (flowText.Controls.Count - 1 == i)
                    {
                        flowText.Controls.RemoveAt(i);
                    }
                }
                _itemsCount--;
                this.Height = this.Height -= 105;
                panel.Height = this.panel.Height -= 105;
            }
            else
            {
                MessageBox.Show("最少保留4个选项");
                return;
            }
        }

        /// <summary>
        /// 控件滚动条事件,让两边的滚动条一起动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            //try{}catch{}原因：可能会超出索引
            try
            {
                int a = e.NewValue;
                if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                {
                    flowOption.VerticalScroll.Value = a;
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 控件滚动条事件,让两边的滚动条一起动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel2_Scroll(object sender, ScrollEventArgs e)
        {
            //try{}catch{}原因：可能会超出索引
            try
            {
                int a = e.NewValue;
                if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                {
                    flowText.VerticalScroll.Value = a;

                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 添加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddOption();
        }

        /// <summary>
        /// 删除选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DeleteOption();
        }

        /// <summary>
        /// 刷新控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCencel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("数据不会保存哦", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Data();
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void Data()
        {
            flowOption.Controls.Clear();
            flowText.Controls.Clear();
            this._itemsCount = 0;
            this.heig();
            for (int i = 0; i < 4; i++)
            {
                this.AddOption();
            }
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        public void Clear()
        {
            flowText.Controls.Clear();
            flowOption.Controls.Clear();
            this.heig();
        }

        /// <summary>
        /// 获取答案
        /// </summary>
        public void Obtain()
        {
            var Count = flowOption.Controls.Count;
            var ding = "";
            for (int i = 0; i < Count; i++)
            {
                var c = (flowText.Controls[i] as ExtOptions).ExtOptions1.RtfText;
                var Text = (flowText.Controls[i] as ExtOptions).ExtOptions1.Text;
                var co = (flowOption.Controls[i] as RadioButton).Checked;
                var A = (flowOption.Controls[i] as RadioButton).Text;

                if (co == true)
                {
                    ding += A;
                }
            }
            extAnalysis1.ExtText(ding);
        }
        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        /// <summary>
        /// 删除
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

        private void btnObtains_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Obtain();
        }
    }
}
