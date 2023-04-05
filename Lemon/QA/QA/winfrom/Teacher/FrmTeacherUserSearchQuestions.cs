using DevExpress.XtraEditors;

using QA.file;

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

using WinClient;

namespace QA.winfrom
{
    public partial class FrmTeacherUserSearchQuestions : XtraForm
    {
        /// <summary>
        /// 考试科目guid
        /// </summary>
        private string year_guid;

        public FrmTeacherUserSearchQuestions()
        {
            InitializeComponent();
            this.dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmTeacherUserSearchQuestions(string year_guid) : this()
        {
            this.year_guid = year_guid;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserNewQuestions(year_guid);
            timer.Stop();//timer清除内存
            frm.ShowDialog();
            this.Show();
            timer.Start();
            this.data();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Row = dataGridView.CurrentRow;
            if (Row != null)
            {
                var ExamInfo_guid = Row.Cells["guid"].Value?.ToString();
                var frm = new FrmTeacherUserEditQuestions(ExamInfo_guid);
                timer.Stop();//timer清除内存
                frm.ShowDialog();
                this.Show();
                timer.Start();
                this.data();
            }
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Row = dataGridView.CurrentRow;
                if (MessageBox.Show("删除年份后里面的考题也会一起删除而且不可复原!", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var ExamInfo_guid = Row.Cells["guid"].Value?.ToString();

                    if (ClassMethod.lemonDeleteExamInfo(ExamInfo_guid))
                    {
                        MessageBox.Show("删除成功");
                        this.data();//刷新
                    }
                    else
                    {
                        MessageBox.Show("删除失败,返回值false,报错模块FrmStudentQuestions.cs,客户端报错方法 btndelete_ItemClick ,使用服务端方法DeleteExamInfo");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("删除失败,程序报错,报错片段69-88行");
                return;
            }
        }

        private void btnRefrest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.data();
        }

        private void FrmTeacherUserSearchQuestions_Load(object sender, EventArgs e)
        {
            this.Size = new Size(984, 553);
            this.data();
            timer.Start();
        }

        /// <summary>
        /// 刷新方法
        /// </summary>
        public void data()
        {
            var dt_ExamSubjectInfo = ClassMethod.lemonSelectExamSubjectInfoExam_guid(year_guid);//查询大题表
            if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
            {
                dataGridView.DataSource = dt_ExamSubjectInfo;
            }
            else
            {
                dataGridView.DataSource = "";
            }
        }

        private void btnPreservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var user_text = this.txtUserText.EditValue.ToString();//内容
                var subject_content = "%" + user_text + "%";
                var dt = ClassMethod.lemonSelectExamSubjectInfoLIKE(year_guid, subject_content);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("考题不存在");
                }
            }
            catch
            {
                MessageBox.Show("请输入要搜索的值");
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridView.CurrentRow;
            if (Row != null)
            {
                var ExamInfo_guid = Row.Cells["guid"].Value?.ToString();
                var frm = new FrmTeacherUserEditQuestions(ExamInfo_guid);
                timer.Stop();
                frm.ShowDialog();
                this.Show();
                timer.Start();
            }
        }

        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacherUserSearchQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();

            ClearMemory();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClearMemory();
        }
    }
}
