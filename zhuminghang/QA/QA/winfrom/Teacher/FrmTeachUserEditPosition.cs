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

namespace QA.winfrom
{
    public partial class FrmTeachUserEditPosition : XtraForm
    {
        private string textjson;

        public FrmTeachUserEditPosition()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmTeachUserEditPosition(string textjson) : this()
        {
            this.textjson = textjson;
        }

        private void FrmTeachUserEditPosition_Load(object sender, EventArgs e)
        {
            this.txtYearRefrest();
            if (textjson != null)
            {
                txtyearText.Text = textjson;
                radYes.Checked = true;
            }
            else
            {
                radNo.Checked = true;
            }
        }

        /// <summary>
        /// 刷新年份
        /// </summary>
        void txtYearRefrest()
        {
            var dt = ClassMethod.lemonExamTypeInfo();
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

        private void lbladd_Click(object sender, EventArgs e)
        {
            var frm = new FrmTeacherUserNewType();
            frm.ShowDialog();
            this.Show();
            this.txtYearRefrest();
        }

        private string yearguid = "";
        private string typeGuid = "";
        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            Animation.ShowControl(this.txtyear, true, AnchorStyles.Bottom);
            {
                var exam_type = this.txttype.Text.Trim();//类型
                var dt = ClassMethod.lemonExamTypeInfoExamType(exam_type);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.txtyear.Properties.Items.Clear();
                    var exam_type_guid = dt.Rows[0]["guid"];
                    this.typeGuid = exam_type_guid.ToString();
                    var dr = ClassMethod.lemonExamInfoExamTypeInfoGUID(typeGuid);
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
                    MessageBox.Show("请先添加类型");
                    return;
                }
            }
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            Animation.ShowControl(this.txtyear, false, AnchorStyles.Bottom);
        }

        private void btnnextstep_Click(object sender, EventArgs e)
        {
            if (radYes.Checked == true)
            {
                var exam_type = this.txttype.Text.Trim();//类型

                var dt = ClassMethod.lemonExamTypeInfoExamType(exam_type);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string ExamInfoGuid = Guid.NewGuid().ToString();//大题guid

                    var guid = dt.Rows[0]["guid"];

                    bool ResultInsertExamInfo = ClassMethod.lemonInsertExamInfo(ExamInfoGuid, guid.ToString(), txtyearText.Text);
                    if (ResultInsertExamInfo == true)
                    {
                        this.DialogResult = DialogResult.OK;
                        Program.FrmTeachUserEditPosition_guid = ExamInfoGuid;
                    }
                    else
                    {
                        MessageBox.Show("错误 FrmTeachUserEditPosition 文件,145行. ClassMethod.lemonInsertExamInfo 方法错误,服务端 InsertExamInfo 方法错误");
                        return;
                    }
                }
            }
            else
            {
                var user_year = this.txtyear.Text.Trim();
                var dr = ClassMethod.lemonSelectExamInfo(user_year, typeGuid);

                if (dr != null && dr.Rows.Count > 0)
                {
                    this.yearguid = dr.Rows[0]["guid"].ToString();
                    this.DialogResult = DialogResult.OK;
                    Program.FrmTeachUserEditPosition_guid = yearguid;
                }
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
