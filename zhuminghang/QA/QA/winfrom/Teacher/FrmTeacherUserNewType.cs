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
using WinClient;

namespace QA.winfrom
{
    public partial class FrmTeacherUserNewType : XtraForm
    {
        /// <summary>
        /// 科目名称
        /// </summary>
        private string exam_type;
        /// <summary>
        /// 科目guid
        /// </summary>
        private string guid;

        public FrmTeacherUserNewType()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmTeacherUserNewType(string exam_type, string guid) : this()
        {
            this.exam_type = exam_type;
            this.guid = guid;
            if (exam_type != null)
            {
                this.Text = "编辑类型窗体";
                txtusertype.Text = exam_type;
            }
            else
            {
                this.Text = "添加类型窗体";
            }
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (exam_type != null)
            {
                var dt_ExamTypeInfo = $@"select * from ExamTypeInfo where  guid = @guid".EQ(("@guid", this.guid));//类型
                if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                {
                    $@"update ExamTypeInfo set exam_type=@exam_type where guid = @guid".ENQ(("@guid", this.guid), ("@exam_type", txtusertype.Text));
                    MessageBox.Show("编辑成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("类型不存在");
                    return;
                }
            }
            else
            {
                var dt_ExamTypeInfo = $@"select * from ExamTypeInfo where exam_type=@exam_type".EQ(("@exam_type", txtusertype.Text));//类型
                if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                {
                    MessageBox.Show("类型已存在");
                    return;
                }
                else
                {
                    $@"insert into ExamTypeInfo(exam_type)values(@exam_type)".ENQ(("@exam_type", txtusertype.Text));
                    MessageBox.Show("添加成功");
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
