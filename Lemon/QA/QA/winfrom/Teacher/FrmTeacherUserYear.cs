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
    public partial class FrmTeacherUserYear : XtraForm
    {
        public FrmTeacherUserYear()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        private void FrmTeacherUserYear_Load(object sender, EventArgs e)
        {
            this.ExamTypeInfo();
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
        /// 刷新时间
        /// </summary>
        public void Databast()
        {
            var user_type = this.txttype.Text.Trim();//类型
            var dt_ExamTypeInfo = ClassMethod.lemonSelectExamTypeInfoExamType(user_type);
            if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
            {
                var ExamTypeInfo_guid = dt_ExamTypeInfo.Rows[0]["guid"];
                var dt = $"select *,sc='删除' from ExamInfo where exam_type_guid = @exam_type_guid".EQ(("exam_type_guid", ExamTypeInfo_guid));
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

        private void txttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Databast();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                        if (ClassMethod.lemonDeleteExamInfo(year_guid))
                        {
                            MessageBox.Show("删除成功");
                            this.Databast();
                        }
                        else
                        {
                            MessageBox.Show("删除失败,报错模块FrmTeacherUserYear.cs,报错行数108,报错内容删除失败"); 
                        }
                    }
                }
            }
            catch { }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var Row = dataGridView.CurrentRow;

                var year_guid = Row.Cells["guid"].Value?.ToString();
                if (year_guid != null)
                {
                    var frm = new FrmTeacherUserSearchQuestions(year_guid);
                    frm.ShowDialog();
                    this.Show();
                    this.Databast();
                }
                else
                {
                    MessageBox.Show("没有考题");

                    return;
                }
            }
            catch
            {
                MessageBox.Show("您的操作过快请稍后再试");
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserEditType();
            frm.ShowDialog();
            this.Show();
            this.ExamTypeInfo();
            this.Databast();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var user_Text = this.txttype.Text.Trim();
            var frm = new FrmTeacherUserNewYear(user_Text);
            frm.ShowDialog();
            this.Show();
            this.Databast();
        }

        /// <summary>
        /// 类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdits_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserNewYear();
            frm.ShowDialog();
            this.Show();
            this.ExamTypeInfo();
            this.Databast();
        }

        /// <summary>
        /// 信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdds_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTeacherUserNewType();
            frm.ShowDialog();
            this.Show();
            this.ExamTypeInfo();
            this.Databast();
        }
    }
}
