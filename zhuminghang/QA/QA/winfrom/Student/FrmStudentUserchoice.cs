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

namespace QA
{
    public partial class FrmStudentUserchoice : XtraForm
    {
        string text;
        public FrmStudentUserchoice()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;

            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmStudentUserchoice(string text) : this()
        {
            this.text = text;
        }

        /// <summary>
        /// 存储类型数组
        /// </summary>
        List<string> persons = new List<string>();

        /// <summary>
        /// 存储类型数组
        /// </summary>
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
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStudentUserchoice_Load(object sender, EventArgs e)
        {
            this.txtYearRefrest();
            this.person.Clear();
            var dt = $"select * from ExamTypeInfo".EQ();
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
            if (this.text != null)
            {
                txtUseryear.EditValue = this.text;
                txtUseryear.Enabled = false;
            }
            this.timer.Start();
        }

        /// <summary>
        /// 下拉框值改变出发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUseryear_EditValueChanged(object sender, EventArgs e)
        {
            {
                var user_type = this.txtUseryear.EditValue.ToString() ?? "";//类型
                var dt = $"select * from ExamTypeInfo where exam_type = @user_type".EQ(("@user_type", user_type));
                if (dt != null && dt.Rows.Count > 0)//当等于空后就等于没有类型
                {
                    ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUser.Edit).Items.Clear();
                    var guid = dt.Rows[0]["guid"];
                    this.typeGuid = guid.ToString();
                    var dr = $"select * from ExamInfo where exam_type_guid = @guid".EQ(("@guid", guid));
                    if (dr != null && dr.Rows.Count > 0)
                    {
                        this.dataGridView.DataSource = dr;

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
        }

        /// <summary>
        /// 自动刷新类型,有道云笔记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            {
                this.persons.Clear();
                var dt = $"select * from ExamTypeInfo".EQ();
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
                var dt = $"select * from ExamTypeInfo".EQ();
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

        private void txtUser_EditValueChanged(object sender, EventArgs e)
        {
            var user_year = this.txtUser.EditValue.ToString() ?? "";
            if (user_year != "目前没有考题" && user_year != "")
            {
                var dr = $"select * from ExamInfo where exam_time = @exam_time and exam_type_guid =@guid".EQ(("@exam_time", user_year), ("@guid", typeGuid));
                if (dr != null && dr.Rows.Count > 0)
                {
                    this.yearguid = dr.Rows[0]["guid"].ToString();

                    var dt = $"select * ,sc='删除' from ExamSubjectInfo where exam_guid = @exam_guid ".EQ(("@exam_guid", this.yearguid));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        this.dataGridView.DataSource = dt;
                    }
                }
            }
            else
            {
                this.dataGridView.DataSource = "";
            }
        }

        /// <summary>
        /// 开始考试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetinto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var guid = dataGridView.CurrentRow.Cells["guid"].Value?.ToString();//获取年份guid
            if (guid != null)
            {
                var texts = "";
                var pattern = "选择考题";
                var frm = new FrmStudentExamination(guid, texts, pattern);//考试窗体
                this.timer.Stop();//timer刷新类型
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("没有考题");

                return;
            }
        }

        /// <summary>
        /// 切换类型后执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                var user_type = this.txtUseryear.EditValue.ToString() ?? "";//类型
                var dt = $"select * from ExamTypeInfo where exam_type = @user_type".EQ(("@user_type", user_type));//获取科目
                if (dt != null && dt.Rows.Count > 0)
                {
                    ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUser.Edit).Items.Clear();//清空下拉框值
                    var guid = dt.Rows[0]["guid"];
                    this.typeGuid = guid.ToString();
                    var dr = $"select * from ExamInfo where exam_type_guid = @guid".EQ(("@guid", guid));
                    if (dr != null && dr.Rows.Count > 0)
                    {
                        this.dataGridView.DataSource = dr;//为dataGridView绑定值

                    }
                    else
                    {
                        this.dataGridView.DataSource = "";
                        this.dataGridView.DataSource = null;
                        DataGridViewRow row = new DataGridViewRow();

                        int index = dataGridView.Rows.Add(row);
                        dataGridView.Rows[index].Cells[0].Value = "目前没有考题";//dataGridView显示目前没有考题，有道云笔记
                    }
                }
                else
                {
                    MessageBox.Show("类型不存在");
                    return;
                }
            }
        }

        /// <summary>
        /// dataGridView点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var year_guid = dataGridView.CurrentRow.Cells["guid"].Value?.ToString();//获取大题guid
            if (year_guid != null)
            {
                var Texts = txtUseryear.EditValue.ToString();//科目
                var pattern = "选择考题";//考试模式
                var frm = new FrmStudentExamination(year_guid, Texts, pattern);//前往考试窗体 传值，guid ,科目，考试模式
                this.timer.Stop();//计时器负责自动刷新类型
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("没有考题");
                return;
            }
        }


        /// <summary>
        /// 刷新年份
        /// </summary>
        void txtYearRefrest()
        {
            var dt = $"select * from ExamTypeInfo".EQ();//获取科目
            if (dt != null && dt.Rows.Count > 0)
            {
                ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUseryear.Edit).Items.Clear();//清空下拉框
                var dr = dt.Rows.Count;
                for (int i = 0; i < dr; i++)
                {
                    var SelectedIndex = dt.Rows[i]["exam_type"];

                    ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUseryear.Edit).Items.Add(SelectedIndex.ToString());//下拉框赋值

                }
                txtUseryear.EditValue = ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUseryear.Edit).Items[0];//默认第一个
            }
            else
            {
                ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)txtUseryear.Edit).Items.Clear();//清空下拉框
                this.txtUseryear.EditValue = "";//下拉框显示值为空
            }
        }
    }
}
