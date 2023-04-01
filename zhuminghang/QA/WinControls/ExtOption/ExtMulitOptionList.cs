using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using WinControls;
using DevExpress.XtraRichEdit.SpellChecker;
using System.Runtime.InteropServices;

namespace Kuade.WinControls.ExtOption
{
    public partial class ExtMulitOptionList : UserControl
    {
        public ExtMulitOptionList()
        {
            InitializeComponent();
        }


        private List<char> Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
        /// <summary>
        /// 初始化用户控件高度
        /// </summary>
        public void heig()
        {
            this.Height = 40 + 176;//40上方按钮高度,176下方解析高度
        }


        #region 选项最大最小
        /// <summary>
        /// 最大选项数
        /// </summary>
        private int _maxItemsCount = 26;

        /// <summary>
        /// 最大选项数
        /// </summary>
        public int MaxItemsCount
        {
            get
            {
                return _maxItemsCount;
            }
            set
            {
                _maxItemsCount = value;
            }
        }

        /// <summary>
        /// 最小选项数
        /// </summary>
        private int _minItemsCount = 4;

        /// <summary>
        /// 最小选项数
        /// </summary>
        public int MinItemsCount
        {
            get
            {
                return _minItemsCount;
            }
            set
            {
                _minItemsCount = value;
            }
        }

        /// <summary>
        /// 默认几个选项
        /// </summary>
        private int _itemsCount = 4;

        /// <summary>
        /// 默认几个选项
        /// </summary>
        public int ItemCout
        {
            get
            {
                return _itemsCount;
            }
            set
            {
                _itemsCount = value;
            }
        }
        #endregion

        /// <summary>
        /// 设置题目内容
        /// </summary>
        /// <param name="a"></param>
        public void labText(int a = 1)
        {

            this.lblText.Text = "第" + a + "题";
        }

        /// <summary>
        /// 添加选项
        /// </summary>
        public void AddOption(int a = 1)
        {
            for (int i = 0; i < a; i++)
            {
                if (FlowLayout.Controls.Count >= _maxItemsCount)
                {
                    XtraMessageBox.Show($"多选题的选项最多只能为:{MaxItemsCount}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ExtOption ExtOptions = new ExtOption();
                using (ExtOptions)
                {
                    this.Height = this.Height += 106;
                    FlowLayout.Height = this.FlowLayout.Height += 106;
                    FlowLayout.Controls.Add(ExtOptions = new ExtOption() { CheekText = Alpha[FlowLayout.Controls.Count].ToString() });
                    var aedExtMulitOptionList = this;
                    ExtOptions.ht(aedExtMulitOptionList);

                    this.extAnalysis1.Size = new Size(1308, 176);
                }
            }
        }

        /// <summary>
        /// 删除选项
        /// </summary>
        public void DeleteOption()
        {
            if (FlowLayout.Controls.Count <= _minItemsCount)
            {
                XtraMessageBox.Show($"多选择至少要保留{_minItemsCount}个选项", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < FlowLayout.Controls.Count; i++)
                {
                    if (FlowLayout.Controls.Count - 1 == i)
                    {
                        FlowLayout.Controls.RemoveAt(i);
                    }
                }
                this.Height = this.Height -= 106;
                FlowLayout.Height = FlowLayout.Height -= 106;
            }
        }

        /// <summary>
        /// 返回答案内容
        /// </summary>
        /// <returns></returns>
        public string eddText()
        {
            var Count = FlowLayout.Controls.Count;
            List<string> Eng = new List<string>();//ABCD
            List<byte[]> bytText = new List<byte[]>();//正确答案
            List<string> strTexts = new List<string>();//正确答案
            List<bool> Enabled = new List<bool>();//答案
            for (int i = 0; i < Count; i++)
            {
                var ExtOption = (FlowLayout.Controls[i] as ExtOption);
                var c = ExtOption.Cheek.Text;
                var co = ExtOption.Cheek.Checked;
                var A = SqlHelper.RtxToBytes(ExtOption.extOptions.ExtOptions1.RtfText);
                strTexts.Add(ExtOption.extOptions.ExtOptions1.Text);
                Eng.Add(c);
                bytText.Add(A);
                Enabled.Add(co);
            }
            var addText = this.extAnalysis1.extOptions.ExtOptions1.RtfText;
            var json = JsonConvert.SerializeObject(new { EngOne = Eng, bytText = bytText, EnabledOne = Enabled, strTexts = strTexts, addText = addText });
            return json;
        }

        /// <summary>
        /// 调用添加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FlowLayout.Controls.Count >= _maxItemsCount)
            {
                XtraMessageBox.Show($"多选题的选项最多只能为:{MaxItemsCount}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExtOption ExtOptions = new ExtOption();
            using (ExtOptions)
            {
                this.Height = this.Height += 106;
                FlowLayout.Height = this.FlowLayout.Height += 106;
                FlowLayout.Controls.Add(ExtOptions = new ExtOption() { CheekText = Alpha[FlowLayout.Controls.Count].ToString() });
                var aedExtMulitOptionList = this;
                ExtOptions.ht(aedExtMulitOptionList);

                this.extAnalysis1.Size = new Size(1308, 176);
            }
        }

        /// <summary>
        /// 调用删除选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DeleteOption();
        }

        /// <summary>
        /// 清空控件
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
        /// 刷新（清空选项后添加新的选项）
        /// </summary>
        public void Data()
        {
            FlowLayout.Controls.Clear();
            this.heig();
            this._itemsCount = 0;
            for (int i = 0; i < 4; i++)
            {
                this.AddOption();
            }
        }

        private void ExtMulitOptionList_Load(object sender, EventArgs e)
        {
            this.heig();
            extAnalysis1.ExtEnabled();
        }
        public void Clear()
        {
            FlowLayout.Controls.Clear();
            this.heig();
        }

        /// <summary>
        /// 获取解析答案刷新
        /// </summary>
        public void Obtain()
        {
            var Count = FlowLayout.Controls.Count;
            var ding = "";
            for (int i = 0; i < Count; i++)
            {
                var ExtOption = (FlowLayout.Controls[i] as ExtOption);
                var c = ExtOption.Cheek.Text;
                var co = ExtOption.Cheek.Checked;
                var A = ExtOption.extOptions.ExtOptions1.RtfText;
                if (co == true)
                {
                    ding += c;
                }
            }
            extAnalysis1.ExtText(ding);
        }

        private void FlowLayout_Click(object sender, EventArgs e)
        {
            this.Obtain();
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
