using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA.winfrom
{
    public partial class FrmTeacherUserEditYear : XtraForm
    {
        private string year_guid;

        public FrmTeacherUserEditYear()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmTeacherUserEditYear(string year_guid) : this()
        {
            this.year_guid = year_guid;
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnpreservation_Click(object sender, EventArgs e)
        {
            var startTime = this.txtStartTime.DateTime.ToString("f");//开始时间
            var EndTime = this.txtEndTime.DateTime.ToString("f"); ;//结束时间

            if (this.year_guid != null)
            {
                var dt = $@"select * from ExamInfo where guid = @guid".EQ(("@guid", year_guid));
                if (dt != null && dt.Rows.Count > 0)
                {
                    $@"update ExamInfo set exam_time =@exam_time where guid=@guid".ENQ(("@exam_time", startTime + " -- " + EndTime), ("@guid", year_guid));
                    MessageBox.Show("编辑成功");
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void RefRest()
        {
            if (this.year_guid != null)
            {
                var dt = $@"select * from ExamInfo where guid = @guid".EQ(("@guid", year_guid));
                if (dt != null && dt.Rows.Count > 0)
                {
                    try
                    {
                        var a = dt.Rows[0]["exam_time"].ToString();

                        string[] after = a.Split(new char[] { '-' });
                        var count = after.Count();
                        for (int i = 0; i < count; i++)
                        {
                            var strafter = after[i];
                            if (i == 0)
                            {
                                txtStartTime.Text = strafter;
                            }
                            if (i == 2)
                            {
                                txtEndTime.Text = strafter;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("参数错误");
                        this.Close();
                        this.Dispose();
                    }
                    finally
                    {
                        dt.Dispose();
                    }
                }
            }

        }

        private void FrmTeacherUserEditYear_Load(object sender, EventArgs e)
        {
            this.RefRest();
        }
    }
}
