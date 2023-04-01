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
    public partial class FrmUserEditPwd : XtraForm
    {
        public FrmUserEditPwd()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
            txtUserPwd.Properties.PasswordChar = '*';
            txtReUserPwd.Properties.PasswordChar = '*';
            txtPwd.Properties.PasswordChar = '*';
        }

        private void btnPreservation_Click(object sender, EventArgs e)
        {
            var pwd = this.txtPwd.Text.Trim();
            var user_pwd = this.txtUserPwd.Text.Trim();
            var user_re_pwd = this.txtReUserPwd.Text.Trim();
            if (pwd == "")
            {
                MessageBox.Show("旧密码不能为空");
                return;
            }
            if (user_pwd == "")
            {
                MessageBox.Show("新密码不能为空");
                return;
            }
            if (user_re_pwd != user_pwd)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            var dt = $"select * from UserInfo where user_no = @user_no".EQ(("@user_no", SqlHelper.user_no));
            if (dt != null && dt.Rows.Count > 0)
            {
                var dr = $"select * from UserInfo where user_no = @user_no and user_pwd = @user_pwd".EQ(("@user_no", SqlHelper.user_no), ("@user_pwd", pwd));
                if (dr != null && dt.Rows.Count > 0)
                {
                    $"update UserInfo set user_pwd = @user_pwd where user_no = @user_no".ENQ(("@user_no", SqlHelper.user_no), ("@user_pwd", pwd));
                    MessageBox.Show("修改成功");
                    return;
                }
            }
            else
            {
                MessageBox.Show("参数错误,请重新登录");
                return;
            }
        }

        private void btnCenCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRePwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frm = new FrmUserModifyPwd();
            var a = frm.ShowDialog();
            if (a != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
