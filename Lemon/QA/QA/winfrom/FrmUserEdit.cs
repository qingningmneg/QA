using DevExpress.XtraEditors;
using QA.winfrom;
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

namespace QA
{
    public partial class FrmUserEdit : XtraForm
    {
        public FrmUserEdit()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        private void btnPreservation_Click(object sender, EventArgs e)
        {
            var user_Age = this.txtUserAge.Text.Trim();//性别
            var sex = this.txtUserSex.Text.Trim();//年龄
            var user_year = this.txtUserYear.Text.Trim();//年份
            var mobile = this.txtTelephone.Text.Trim();//电话
            var user_name = this.txtUserName.Text.Trim();//用户姓名
            $@"update UserInfo set user_name=@user_name,user_Age = @user_Age,user_year = @user_year,sex = @sex,mobile = @mobile where user_no = @user_no".ENQ(("@user_name", user_name), ("@user_Age", user_Age), ("@sex", sex == "男" ? 0 : 1), ("@user_year", user_year), ("@mobile", mobile), ("@user_no", SqlHelper.user_no));
            MessageBox.Show("保存成功");
            this.LoadData();
            this.Close();//关闭窗体
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void LoadData()
        {
            lblUserNo.Text = SqlHelper.user_no;
            var dt = $"select * from UserInfo where user_no = @user_no".EQ(("@user_no", SqlHelper.user_no));
            if (dt != null && dt.Rows.Count > 0)
            {
                var dr = dt.Rows[0];
                var user_name = Convert.ToString(dr["user_name"]);
                var user_Age = Convert.ToString(dr["user_Age"]);
                var user_sex = Convert.ToInt32(dr["sex"]) == 0 ? "男" : "女";
                var user_year = Convert.ToString(dr["user_year"]);
                var mobile = Convert.ToString(dr["mobile"]);
                SqlHelper.user_name = user_name;
                this.txtTelephone.Text = mobile;
                this.txtUserYear.Text = user_year;
                this.txtUserSex.Text = user_sex;
                this.txtUserAge.Text = user_Age;
                this.txtUserName.Text = SqlHelper.user_name;
            }
        }

        private void btnCenCel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void lblUserPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FrmUserEditPwd();
            frm.ShowDialog();
            this.Show();
        }
    }
}
