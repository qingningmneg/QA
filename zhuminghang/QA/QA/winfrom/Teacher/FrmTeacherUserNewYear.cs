using DevExpress.Utils;
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
    public partial class FrmTeacherUserNewYear : XtraForm
    {
        private string user_Text;

        public FrmTeacherUserNewYear()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="user_Text"></param>
        public FrmTeacherUserNewYear(string user_Text) : this()
        {
            this.user_Text = user_Text;
            if (user_Text != "")
            {
                lbltypeText.Text = user_Text;//考试类型
            }
        }

        private void FrmTeacherUserNewYear_Load(object sender, EventArgs e)
        {
            this.ExamTypeInfo();
            
            this.Databast();
            #region 初始化 dateEdit控件
            txtStartTime.Properties.VistaDisplayMode = DefaultBoolean.True;
            txtStartTime.Properties.VistaEditTime = DefaultBoolean.True;
            this.txtStartTime.Properties.DisplayFormat.FormatString = "yyyy年MM月dd HH:mm";
            this.txtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartTime.Properties.EditFormat.FormatString = "yyyy年MM月dd HH:mm";
            this.txtStartTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartTime.Properties.Mask.EditMask = "yyyy年MM月dd HH:mm";

            txtEndTime.Properties.VistaDisplayMode = DefaultBoolean.True;
            txtEndTime.Properties.VistaEditTime = DefaultBoolean.True;
            this.txtEndTime.Properties.DisplayFormat.FormatString = "yyyy年MM月dd HH:mm";
            this.txtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndTime.Properties.EditFormat.FormatString = "yyyy年MM月dd HH:mm";
            this.txtEndTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndTime.Properties.Mask.EditMask = "yyyy年MM月dd HH:mm";
            #endregion

            txtStartTime.EditValue = "请选择时间";
            txtEndTime.EditValue = "请选择时间";

        }

        /// <summary>
        /// 刷新题目类型 exam_type题目
        /// </summary>
        void ExamTypeInfo()
        {
            var dt = $"select * from ExamTypeInfo ".EQ();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.lbltypeText.Properties.Items.Clear();
                var dr = dt.Rows.Count;
                for (int i = 0; i < dr; i++)
                {
                    var SelectedIndexCount = dt.Rows[i];
                    var SelectedIndex = SelectedIndexCount["exam_type"];
                    this.lbltypeText.Properties.Items.Add(SelectedIndex.ToString());
                }
                if (lbltypeText.Text == "")
                {
                    this.lbltypeText.SelectedIndex = 0;
                }
            }
            else
            {
                this.lbltypeText.Properties.Items.Clear();
                this.lbltypeText.Text = "";
            }
        }

        /// <summary>
        /// 刷新时间
        /// </summary>
        public void Databast()
        {
            var user_type = this.lbltypeText.Text.Trim();//类型
            var dt_ExamTypeInfo = $"select * from ExamTypeInfo where exam_type = @exam_type".EQ(("exam_type", user_type));
            if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
            {
                var ExamTypeInfo_guid = dt_ExamTypeInfo.Rows[0]["guid"];
                var dt = $"select *,sc='删除' from ExamInfo where exam_type_guid = @exam_type_guid ".EQ(("exam_type_guid", ExamTypeInfo_guid));
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dataGridView.DataSource = dt;
                    
                }
                else
                {
                    this.dataGridView.DataSource = "";
                    this.dataGridView.DataSource = null;
                    DataGridViewRow row = new DataGridViewRow();

                    int index = dataGridView.Rows.Add(row);
                    dataGridView.Rows[index].Cells[0].Value = "目前没有考题";
                }
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbltypeText_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Databast();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStartTime.Text == "请选择时间" || txtEndTime.Text == "请选择时间")
            {
                MessageBox.Show("请输入开始时间");
                return;
            }
            var startTime = this.txtStartTime.DateTime.ToString("f");//开始时间
            var EndTime = this.txtEndTime.DateTime.ToString("f"); ;//结束时间

            if (startTime == "")
            {
                XtraMessageBox.Show("请输入开始时间");
                return;
            }
            if (EndTime == "")
            {
                XtraMessageBox.Show("请输入结束时间");
                return;
            }

            var dt = $@"select * from ExamTypeInfo where exam_type = @exam_type".EQ(("@exam_type", lbltypeText.Text));
            if (dt != null && dt.Rows.Count > 0)
            {
                var ExamTypeInfoguid = dt.Rows[0]["guid"];//获取属性的guid
                var barcodess = Guid.NewGuid().ToString();//主键
                $@"insert into ExamInfo(exam_type_guid,exam_time,guid)values(@exam_type_guid,@exam_time,@guid)".ENQ(("@exam_type_guid", ExamTypeInfoguid), ("@exam_time", startTime + " -- " + EndTime), ("guid", barcodess));
                MessageBox.Show("添加成功");
                this.Databast();
                this.ExamTypeInfo();
            }
            else
            {
                MessageBox.Show("请选择考试类型");
                return;
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrefrest_Click(object sender, EventArgs e)
        {
            this.Databast();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdityear_Click(object sender, EventArgs e)
        {
            var Row = dataGridView.CurrentRow;
            if (Row != null)
            {
                var year_guid = Row.Cells["guid"].Value?.ToString();
                var frm = new FrmTeacherUserEditYear(year_guid);
                frm.ShowDialog();
                this.Show();
                this.Databast();
            }
            else
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
        }

        /// <summary>
        /// 查看点击删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                var row = dataGridView.Columns[e.ColumnIndex].Name;
                if (row == "delete")
                {
                    var Row = dataGridView.CurrentRow;
                    if (MessageBox.Show("删除年份后里面的考题也会一起删除而且不可复原!", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var year_guid = Row.Cells["guid"].Value?.ToString();

                        var dt_ExamInfo = $@"select * from ExamInfo where guid=@guid".EQ(("@guid", year_guid));//年份表
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
                            $"delete from ExamInfo where guid=@guid".ENQ(("@guid", year_guid));
                            MessageBox.Show("删除成功");
                            this.Databast();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStartTime_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStartTime.Text == "")
            {
                txtStartTime.EditValue = "请选择时间";
            }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEndTime_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEndTime.Text == "")
            {
                txtEndTime.EditValue = "请选择时间";
            }
        }

        /// <summary>
        /// 点击搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 搜索年份方法
        /// </summary>
        /// <param name="strSelect"></param>
        /// <returns></returns>
        public DataTable LemonYearSelect(string strSelect)
        { 
            DataTable dt = new DataTable();



            return dt;
        }
    }
}
