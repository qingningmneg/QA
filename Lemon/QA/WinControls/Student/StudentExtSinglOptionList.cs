using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuade.WinControls.Student
{
    public partial class StudentExtSinglOptionList : UserControl
    {
        public StudentExtSinglOptionList()
        {
            InitializeComponent();
        }
        private List<char> Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();//数组
        int _itemsCount = 0;//控件数量
        int __MaxCount = 26;
        int _MinCount = 4;
        string subject = "";

        /// <summary>
        /// 添加选项
        /// </summary>
        public void AddOption(int b = 1)
        {
            for (int ab = 0; ab < b; ab++)
            {
                this.Height = this.Height += 105;
                panel.Height = this.panel.Height += 105;
                //extAnalysis1.Size = new Size(1151, 176);
                if (_itemsCount <= __MaxCount - 1)
                {
                    CheckBox CheckBox = new CheckBox();//初始化控件
                    StudentExtOptions ext = new StudentExtOptions();

                    CheckBox.Click += new EventHandler(dia_Click);
                    CheckBox.Font = new System.Drawing.Font("宋体", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    CheckBox.Text = Alpha[2].ToString();
                    CheckBox.Size = new Size(78, 98);//单选控件大小
                    flowOption.Controls.Add(CheckBox);
                    ext.Size = new Size(960, 82);//内容控件大小
                    flowText.Controls.Add(ext);//窗体添加控件


                    var a = flowOption.Controls.Count;//控件数量
                    for (int i = 0; i < a; i++)
                    {
                        (flowOption.Controls[i] as CheckBox).Text = Alpha[i].ToString();
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

        public int answer = 0;

        /// <summary>
        /// dia点击触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dia_Click(object sender, EventArgs e)
        {
            var a = sender as CheckBox;
            if (subject == "单选题")
            {
                if (a.Checked == true)
                {
                    var Count = flowOption.Controls.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        (flowOption.Controls[i] as CheckBox).Checked = false;
                    }
                    a.Checked = true;
                }
            }

            if (a.Checked == true)
            {
                if (Convert.ToBoolean(a.Tag) == true)
                {
                    this.answer += 1;
                }
                if (Convert.ToBoolean(a.Tag) == false)
                {
                    this.answer -= 1;

                }
                //如果是对的时候就加一，如果是错的话就减一，真正对的话由正确答案数量和answer数量相等时就是对的
            }
            if (a.Checked == false)
            {
                if (Convert.ToBoolean(a.Tag) == true)
                {
                    this.answer -= 1;
                }
                if (Convert.ToBoolean(a.Tag) == false)
                {
                    this.answer += 1;
                }
                //如果取消按钮时是正确答案就减一,不是的话就反之加一,真正对的话由正确答案数量和answer数量相等时就是对的
            }
            this.Obtain();
        }

        /// <summary>
        /// 获取答案
        /// </summary>
        public void Obtain()
        {
            var Count = flowOption.Controls.Count;
            var ding = "";//用户选择的答案
            for (int i = 0; i < Count; i++)
            {
                var c = (flowText.Controls[i] as StudentExtOptions).ExtOptions.RtfText;
                var Text = (flowText.Controls[i] as StudentExtOptions).ExtOptions.Text;
                var co = (flowOption.Controls[i] as CheckBox).Checked;
                var A = (flowOption.Controls[i] as CheckBox).Text;

                if (co == true)
                {
                    ding += A;
                }
            }
            //extAnalysis1.ExtText(ding);
        }

        /// <summary>
        /// 获取是否单选
        /// </summary>
        /// <param name="a"></param>
        public void strSubject(string a = "")
        {
            if (a != null)
            {
                this.subject = a;
            }
            else
            {
                MessageBox.Show("请传值");
                return;
            }
        }

        /// <summary>
        /// 初始化控件高度
        /// </summary>
        public void heig()
        {
            this.panel.Height = 0;
            this.Height = 0;
            flowText.Controls.Clear();
            flowOption.Controls.Clear();
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
    }
}
