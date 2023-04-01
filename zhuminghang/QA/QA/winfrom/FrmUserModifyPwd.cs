using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinClient;

namespace QA.winfrom
{
    public partial class FrmUserModifyPwd : XtraForm
    {
        private string user_no;
        private string url = "http://utf8.sms.webchinese.cn/?";
        private string strUid = "Uid=";
        private string strKey = "&key=d41d8cd98f00b204e980"; //这里*代表秘钥，由于从长有点麻烦，就不在窗口上输入了
        private string strMob = "&smsMob=";
        private string strContent = "&smsText=";

        public FrmUserModifyPwd()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmUserModifyPwd(string user_no) : this()
        {
            this.user_no = user_no;
            if (user_no != "")
            {
                this.txtUserNo.Text = user_no;
            }
        }
        public string GetHtmlFromUrl(string url)
        {
            string strRet = null;
            if (url == null || url.Trim().ToString() == "")
            {
                return strRet;
            }
            string targeturl = url.Trim().ToString();
            try
            {
                HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
                hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                hr.Method = "GET";
                hr.Timeout = 30 * 60 * 1000;
                WebResponse hs = hr.GetResponse();
                Stream sr = hs.GetResponseStream();
                StreamReader ser = new StreamReader(sr, Encoding.Default);
                strRet = ser.ReadToEnd();
            }
            catch (Exception ex)
            {
                strRet = null;
            }
            return strRet;
        }

        private void btnUserPwd_Click(object sender, EventArgs e)
        {
            if (txtContent.Text.Trim() == "")
            {
                MessageBox.Show("验证码不能为空");
                return;
            }
            var user_code = txtContent.Text.Trim();
            var dt = $"select * from UserInfo where user_no = @user_no and user_code = @user_code".EQ(("@user_no", this.txtUserNo.Text.Trim()), ("@user_code", user_code));
            if (dt != null && dt.Rows.Count > 0)
            {
                this.Hide();
                var frm = new FrmUserPwd();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("验证码错误");
                return;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            var user_code = DateTime.Now.ToString("hhmmss");
            var user_no = this.txtUserNo.Text.Trim();
            if (txtAttnNum.Text.ToString().Trim() != "")
            {
                if (user_no != "")
                {
                    var dt = $"select * from UserInfo where user_no=@user_no and mobile = @mobile".EQ(("@user_no", user_no), ("@mobile", txtAttnNum.Text.ToString().Trim()));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        int dr = Convert.ToInt32(dt.Rows[0]["ruid"]);
                        var det = dr + user_code;
                        $"update UserInfo set user_code = @user_code where user_no = @user_no".EQ(("@user_code", det), ("@user_no", user_no));
                        url = url + strUid + "青桔柠檬" + strKey + strMob + txtAttnNum.Text.Trim() + strContent + "短信验证码:" + det;
                        string Result = GetHtmlFromUrl(url);
                        MessageBox.Show(Result);
                    }
                    else
                    {
                        MessageBox.Show("用户名或者手机号错误");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("用户名不能为空");
                    return;
                }
            }
            else
            {
                MessageBox.Show("手机号不能为空");
                return;
            }
        }

        private void FrmUserModifyPwd_Load(object sender, EventArgs e)
        {
            this.txtUserNo.Text = this.user_no;
        }
    }
}
