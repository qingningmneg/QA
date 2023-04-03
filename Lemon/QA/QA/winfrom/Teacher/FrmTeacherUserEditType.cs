using DevExpress.XtraEditors;

using QA.file;

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
    public partial class FrmTeacherUserEditType : XtraForm
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmTeacherUserEditType()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        /// <summary>
        /// 添加类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddtype_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserNewType();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
            this.Refrest();
        }

        /// <summary>
        /// 编辑类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdittype_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Row = dataGridView.CurrentRow;
            if (Row != null)
            {
                var exam_type = Row.Cells["exam_type"].Value.ToString().Trim();//类型名称
                var guid = Row.Cells["guid"].Value.ToString().Trim();//类型名称
                var frm = new FrmTeacherUserNewType(exam_type, guid);
                frm.ShowDialog();
                frm.Dispose();
                this.Show();

                this.Refrest();
            }
        }

        /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletetype_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Row = dataGridView.CurrentRow;
                if (Row != null)
                {
                    if (MessageBox.Show("删除类型会连同里面的题目年份一起删除!", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var exam_type = Row.Cells["exam_type"].Value.ToString().Trim();//类型名称

                        var dt_ExamTypeInfo = ClassMethod.lemonSelectExamTypeInfoExamType(exam_type);//类型
                        if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                        {
                            if (ClassMethod.lemonDeleteExamTypeInfo(dt_ExamTypeInfo.ToString()))
                            {
                                MessageBox.Show("删除成功");
                                this.Refrest();
                            }
                            else
                            {
                                MessageBox.Show("删除类型模块出错,报错模块FrmTeacherUserEditType.cs,行数76,使用方法lemonDeleteExamTypeInfo,服务端方法DeleteExamTypeInfo,原因返回false");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("类型不存在");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择类型");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("删除错误，请重新登陆后重试");
            }
            this.Refrest();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Refrest();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        void Refrest()
        {
            try
            {
                var dt_ExamTypeInfo = ClassMethod.lemonSelectExamTypeInfo();//类型
                if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                {
                    this.dataGridView.DataSource = dt_ExamTypeInfo;
                }
            }
            catch { }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacherUserEditType_Load(object sender, EventArgs e)
        {
            this.Refrest();
        }

        /// <summary>
        /// 窗体关闭时调用GC将内存释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacherUserEditType_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
