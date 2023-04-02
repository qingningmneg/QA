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
        public FrmTeacherUserEditType()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        private void btnAddtype_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserNewType();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
            this.Refrest();
        }

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

                        var dt_ExamTypeInfo = ClassMethod.lemonExamTypeInfoExamType(exam_type);//类型
                        if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                        {
                            var ExamTypeInfo_guid = dt_ExamTypeInfo.Rows[0]["guid"];
                            var dt_ExamInfo = ClassMethod.lemonExamInfoExamTypeInfoGUID(ExamTypeInfo_guid.ToString());//年份表
                            if (dt_ExamInfo != null && dt_ExamInfo.Rows.Count > 0)
                            {
                                var ExamInfo_Count = dt_ExamInfo.Rows.Count;
                                for (int ExamInfo = 0; ExamInfo < ExamInfo_Count; ExamInfo++)//ExamInfo 年份表
                                {
                                    var ExamInfo_guid = dt_ExamInfo.Rows[ExamInfo]["guid"];
                                    var dt_ExamSubjectInfo = $@"select * from ExamSubjectInfo where exam_guid=@exam_guid".EQ(("@exam_guid", ExamInfo_guid));//查询大题表
                                    if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
                                    {
                                        var ExamSubjectInfo_Count = dt_ExamSubjectInfo.Rows.Count;
                                        for (int ExamSubjectInfo = 0; ExamSubjectInfo < ExamSubjectInfo_Count; ExamSubjectInfo++)//ExamSubjectInfo 大题表
                                        {
                                            var ExamSubjectInfo_guid = dt_ExamSubjectInfo.Rows[ExamSubjectInfo]["guid"];
                                            var dt_SubjectChildInfo = $@"select * from SubjectChildInfo where subject_guid=@subject_guid".EQ(("@subject_guid", ExamSubjectInfo_guid));//查询小题表
                                            if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                                            {
                                                var SubjectChildInfo_Count = dt_SubjectChildInfo.Rows.Count;
                                                for (int SubjectChildInfo = 0; SubjectChildInfo < SubjectChildInfo_Count; SubjectChildInfo++)//SubjectChildInfo小题表
                                                {
                                                    var SubjectChildInfo_guid = dt_SubjectChildInfo.Rows[SubjectChildInfo]["guid"];
                                                    //SubjectChildOptionInfo 答案表
                                                    var dt_SubjectChildOptionInfo = $@"select * from SubjectChildOptionInfo where subject_child_guid=@subject_child_guid".EQ(("@subject_child_guid", SubjectChildInfo_guid));//答案表
                                                    if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                                                    {
                                                        $"delete from SubjectChildOptionInfo where subject_child_guid=@subject_child_guid".ENQ(("@subject_child_guid", SubjectChildInfo_guid));
                                                    }
                                                }
                                                //SubjectChildInfo 小题表
                                                $"delete from SubjectChildInfo where subject_guid=@subject_guid".ENQ(("@subject_guid", ExamSubjectInfo_guid));
                                            }
                                            //ExamSubjectInfo 大题表
                                        }
                                        $"delete from ExamSubjectInfo where exam_guid=@exam_guid".ENQ(("@exam_guid", ExamInfo_guid));
                                    }
                                    //ExamInfo 年份表
                                }
                                $"delete from ExamInfo where exam_type_guid=@exam_type_guid".ENQ(("@exam_type_guid", ExamTypeInfo_guid));
                            }
                            //ExamTypeInfo 类型
                            $"delete from ExamTypeInfo where exam_type=@exam_type".ENQ(("@exam_type", exam_type));
                            MessageBox.Show("删除成功");
                            this.Refrest();
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

        private void FrmTeacherUserEditType_Load(object sender, EventArgs e)
        {
            this.Refrest();
        }

        private void FrmTeacherUserEditType_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
