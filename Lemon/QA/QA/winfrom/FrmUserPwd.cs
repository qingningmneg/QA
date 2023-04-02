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
    public partial class FrmUserPwd : XtraForm
    {
        public FrmUserPwd()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
            txtUserPwd.Properties.PasswordChar = '*';
            txtReUserPwd.Properties.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var user_pwd = this.txtUserPwd.Text.Trim();
            var user_re_pwd = this.txtReUserPwd.Text.Trim();
            if (user_pwd == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (user_re_pwd != user_pwd)
            {
                MessageBox.Show("确认密码不能为空");
                return;
            }
            var dt = $"select * from UserInfo where user_no=@user_no".EQ(("@user_no", SqlHelper.user_no));
            if (dt != null && dt.Rows.Count > 0)
            {
                $"update UserInfo set user_pwd = @user_pwd where user_no = @user_no".ENQ(("@user_pwd", user_pwd), ("@user_no", SqlHelper.user_no));
                MessageBox.Show("修改成功");
                this.Close();
            }
        }

        private void btnCenCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
