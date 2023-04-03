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
    public partial class FrmTeacherUserEditSearch : XtraForm
    {
        List<string> persons = new List<string>();
        List<string> person = new List<string>();

        /// <summary>
        /// 类型guid
        /// </summary>
        string typeGuid;

        /// <summary>
        /// 时间guid
        /// </summary>
        string yearguid;

        /// <summary>
        /// 大题目guid
        /// </summary>
        string ExamSubjectInfoguid;//类型guid
        private string user_Text;

        public FrmTeacherUserEditSearch()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmTeacherUserEditSearch(string user_Text) : this()
        {
            this.user_Text = user_Text;
            if (user_Text != null)
            {
                txttype.Text = user_Text;
            }
        }

        private void FrmTeacherUserEditSearch_Load(object sender, EventArgs e)
        {
            this.txtYearRefrest();
            this.person.Clear();
            var dt = ClassMethod.lemonSelectExamTypeInfo();
            if (dt != null && dt.Rows.Count > 0)
            {
                var dr = dt.Rows.Count;
                for (int i = 0; i < dr; i++)
                {
                    var SelectedIndexCount = dt.Rows[i];
                    var SelectedIndex = SelectedIndexCount["exam_type"].ToString();
                    this.person.Add(SelectedIndex);
                }
            }
            this.ExamTypeInfo();
            this.timer.Start();
            if (user_Text == "")
            {
                this.txttype.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 刷新年份
        /// </summary>
        void txtYearRefrest()
        {
            var dt = ClassMethod.lemonSelectExamTypeInfo();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.txttype.Properties.Items.Clear();
                var dr = dt.Rows.Count;
                for (int i = 0; i < dr; i++)
                {
                    var SelectedIndexCount = dt.Rows[i];
                    var SelectedIndex = SelectedIndexCount["exam_type"];
                    this.txttype.Properties.Items.Add(SelectedIndex.ToString());
                }
                this.txttype.SelectedIndex = 0;
            }
            else
            {
                this.txttype.Properties.Items.Clear();
                this.txttype.Text = "";
            }
        }

        /// <summary>
        /// 刷新题目类型 exam_type题目
        /// </summary>
        void ExamTypeInfo()
        {
            var dt = ClassMethod.lemonSelectExamTypeInfo();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.txttype.Properties.Items.Clear();
                var dr = dt.Rows.Count;
                for (int i = 0; i < dr; i++)
                {
                    var SelectedIndexCount = dt.Rows[i];
                    var SelectedIndex = SelectedIndexCount["exam_type"];
                    this.txttype.Properties.Items.Add(SelectedIndex.ToString());
                }
                this.txttype.SelectedIndex = 0;
            }
            else
            {
                this.txttype.Properties.Items.Clear();
                this.txttype.Text = "";
            }
        }

        /// <summary>
        /// 启动time,当当前结果和服务器上查询得不一致时自动刷新列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            {
                this.persons.Clear();
                var dt = ClassMethod.lemonSelectExamTypeInfo();
                if (dt != null && dt.Rows.Count > 0)
                {
                    var dr = dt.Rows.Count;
                    for (int i = 0; i < dr; i++)
                    {
                        var SelectedIndexCount = dt.Rows[i];
                        var SelectedIndex = SelectedIndexCount["exam_type"].ToString();
                        persons.Add(SelectedIndex);
                    }
                }
            }
            var b = person.Count();
            if (this.persons.Count == this.person.Count)
            {
                for (int i = 0; i < b; i++)
                {
                    if (this.persons[i] != this.person[i])
                    {
                        this.txtYearRefrest();
                    }
                }
            }
            else
            {
                this.txtYearRefrest();
            }
            {
                this.person.Clear();
                var dt = ClassMethod.lemonSelectExamTypeInfo();
                if (dt != null && dt.Rows.Count > 0)
                {
                    var dr = dt.Rows.Count;
                    for (int i = 0; i < dr; i++)
                    {
                        var SelectedIndexCount = dt.Rows[i];
                        var SelectedIndex = SelectedIndexCount["exam_type"].ToString();
                        this.person.Add(SelectedIndex);
                    }
                }
            }
        }

        /// <summary>
        /// 关闭窗体时停止time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacherUserEditSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer.Stop();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var user_text = this.txtUserText.Text.Trim();//内容
            var subject_content = "%" + user_text + "%";
            new Task(() =>
            {
                if (user_text != "")
                {
                    var dt = $"select * ,sc='删除' from ExamSubjectInfo where subject_content LIKE @subject_content".EQ(("@subject_content", subject_content));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.dataGridView.DataSource = dt;
                            this.btnSelect.Enabled = true;
                        }));//返回主线程
                    }
                }
                else
                {
                    var user_year = this.txtyear.Text.Trim();
                    if (user_year != "没有找到考题" && user_year != "")
                    {
                        var dr = ClassMethod.lemonSelectExamInfo(user_year, typeGuid);
                        if (dr != null && dr.Rows.Count > 0)
                        {
                            this.yearguid = dr.Rows[0]["guid"].ToString();

                            var dt = $"select * ,sc='删除' from ExamSubjectInfo where exam_guid = @exam_guid ".EQ(("@exam_guid", this.yearguid));
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.dataGridView.DataSource = dt;
                                    this.btnSelect.Enabled = true;
                                    this.txtyear.Enabled = true;
                                }));//返回主线程
                            }
                        }
                    }
                }
            }, TaskCreationOptions.LongRunning).Start();//创建线程
        }

        private void txttype_Click(object sender, EventArgs e)
        {
            {
                var user_type = this.txttype.Text.Trim();//类型
                var dt = ClassMethod.lemonSelectExamTypeInfoExamType(user_type);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.txtyear.Properties.Items.Clear();
                    var guid = dt.Rows[0]["guid"];
                    this.typeGuid = guid.ToString();
                    var dr = ClassMethod.lemonSelectExamInfoExamTypeInfoGUID(guid.ToString());
                    if (dr != null && dr.Rows.Count > 0)
                    {
                        var count = dr.Rows.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var type = dr.Rows[i]["exam_time"];
                            this.txtyear.Properties.Items.Add(type);
                        }
                        this.txtyear.SelectedIndex = 0;
                    }
                    else
                    {
                        this.txtyear.Text = "没有找到考题";
                    }
                }
                else
                {
                    MessageBox.Show("类型不存在");
                    return;
                }
            }
            {
                new Task(() =>
                {
                    var user_year = this.txtyear.Text.Trim();
                    if (user_year != "没有找到考题" && user_year != "")
                    {
                        var dr = $"select * ,sc='delete' from ExamInfo where exam_time = @exam_time and exam_type_guid =@guid".EQ(("@exam_time", user_year), ("@guid", typeGuid));
                        if (dr != null && dr.Rows.Count > 0)
                        {
                            this.yearguid = dr.Rows[0]["guid"].ToString();

                            var dt = $"select * ,sc='删除' from ExamSubjectInfo where exam_guid = @exam_guid ".EQ(("@exam_guid", this.yearguid));
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.dataGridView.DataSource = dt;
                                }));//返回主线程
                            }
                        }
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.dataGridView.DataSource = "";
                        }));//返回主线程
                    }
                }, TaskCreationOptions.LongRunning).Start();//创建线程
            }
        }

        private void txtyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user_year = this.txtyear.Text.Trim();
            if (user_year != "没有找到考题" && user_year != "")
            {
                var dr = ClassMethod.lemonSelectExamInfo(user_year, typeGuid);
                if (dr != null && dr.Rows.Count > 0)
                {
                    this.yearguid = dr.Rows[0]["guid"].ToString();

                    var dt = $"select * ,sc='删除' from ExamSubjectInfo where exam_guid = @exam_guid ".EQ(("@exam_guid", this.yearguid));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.dataGridView.DataSource = dt;
                        }));//返回主线程
                    }
                }
            }
            else
            {
                this.dataGridView.DataSource = "";
            }
        }

        private void btnCenCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = dataGridView.Columns[e.ColumnIndex].Name;
            if (row == "delete")
            {
                var Row = dataGridView.CurrentRow;
                if (MessageBox.Show("是否确认删除", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //var user_no = Row.Cells["user_no"].Value?.ToString();
                    //$"delete from UserInfo where user_no = '{user_no}'".ENQ();
                    //MessageBox.Show("删除成功");
                }
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridView.CurrentRow;
            if (Row != null)
            {
                var txttype = this.txttype.Text;
                var txtyear = this.txtyear.Text;
                this.ExamSubjectInfoguid = Row.Cells["guid"].Value.ToString().Trim();
                this.timer.Stop();
                var frm = new FrmTeacherUserEditQuestions(ExamSubjectInfoguid, txttype, txtyear);
                frm.ShowDialog();
                this.Show();
                this.timer.Start();
            }
        }

        private void txttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                var user_type = this.txttype.Text.Trim();//类型
                var dt = ClassMethod.lemonSelectExamTypeInfoExamType(user_type);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.txtyear.Properties.Items.Clear();
                    var guid = dt.Rows[0]["guid"];
                    this.typeGuid = guid.ToString();
                    var dr = ClassMethod.lemonSelectExamInfoExamTypeInfoGUID(guid.ToString());
                    if (dr != null && dr.Rows.Count > 0)
                    {
                        var count = dr.Rows.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var type = dr.Rows[i]["exam_time"];
                            this.txtyear.Properties.Items.Add(type);
                        }
                        this.txtyear.SelectedIndex = 0;
                    }
                    else
                    {
                        this.txtyear.Text = "没有找到考题";
                    }
                }
                else
                {
                    MessageBox.Show("类型不存在");
                    return;
                }
            }
            {
                new Task(() =>
                {
                    var user_year = this.txtyear.Text.Trim();
                    if (user_year != "没有找到考题" && user_year != "")
                    {
                        var dr = $"select * ,sc='delete' from ExamInfo where exam_time = @exam_time and exam_type_guid =@guid".EQ(("@exam_time", user_year), ("@guid", typeGuid));
                        if (dr != null && dr.Rows.Count > 0)
                        {
                            this.yearguid = dr.Rows[0]["guid"].ToString();

                            var dt = $"select * ,sc='删除' from ExamSubjectInfo where exam_guid = @exam_guid ".EQ(("@exam_guid", this.yearguid));
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.dataGridView.DataSource = dt;
                                }));//返回主线程
                            }
                        }
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.dataGridView.DataSource = "";
                        }));//返回主线程
                    }
                }, TaskCreationOptions.LongRunning).Start();//创建线程
            }
        }
    }
}
