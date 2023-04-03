using DevExpress.XtraEditors;

using QA.file;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinClient;

namespace QA.winfrom
{
    public partial class FrmUserRegister : XtraForm
    {
        byte[] PhotoBytes = null;
        private string card_no;
        public FrmUserRegister()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
            txtUserPwd.Properties.PasswordChar = '*';
            txtReUserPwd.Properties.PasswordChar = '*';
        }

        public FrmUserRegister(string card_no) : this()
        {
            this.card_no = card_no;
            if (this.card_no != null)
            {
                this.txtCardNo.Text = this.card_no;
            }
        }

        /// <summary>
        /// 浏览文件
        /// </summary>
        OpenFileDialog dia = new OpenFileDialog();
        private void btnimage_Click(object sender, EventArgs e)
        {
            if (dia.ShowDialog() == DialogResult.OK)
            {
                if (dia.FileName != null)
                {
                    pictureBox.ImageLocation = dia.FileName;
                    return;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region 设置局部变量
            var user_no = this.txtUserNo.Text.Trim();
            var user_pwd = this.txtUserPwd.Text.Trim();
            var user_re_pwd = this.txtReUserPwd.Text.Trim();
            var user_name = this.txtUserName.Text.Trim();
            var card_no = this.txtCardNo.Text.Trim();
            var img = this.pictureBox.Image;
            #endregion

            if (user_no == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (user_pwd == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (user_pwd != user_re_pwd)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            if (user_name == "")
            {
                MessageBox.Show("用户姓名不能为空");
                return;
            }
            {
                if (card_no != "")
                {
                    if (ClassMethod.lemonSelectCardNo(card_no))
                    {
                        MessageBox.Show("卡号已存在！");
                        return;
                    }
                }
            }
            if (img != null)
            {
                using (var ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Bmp);
                    PhotoBytes = ms.ToArray();
                }
            }
            {
                if (lblUserNos.Text == "正确" && lblUserNames.Text == "正确" && lblReUserPwds.Text == "正确" && lblUserPwds.Text == "正确")
                {
                    if (ClassMethod.lemonSelectUserNo(user_no))
                    {
                        MessageBox.Show("用户名已存在");
                        return;
                    }
                    else
                    {
                        if (ClassMethod.lemonRegister(("@card_no", card_no, typeof(string).FullName), ("@user_no", user_no, typeof(string).FullName), ("@user_pwd", user_pwd, typeof(string).FullName), ("@user_name", user_name, typeof(string).FullName), ("@photo", PhotoBytes, typeof(byte[]).FullName)))
                        {
                            MessageBox.Show("注册成功");

                        }
                        else
                        {
                            MessageBox.Show("注册失败");
                        }
                        this.Close();
                        this.timer.Stop();//关闭计时器
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确格式");
                    return;
                }
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
            this.timer.Stop();//关闭计时器
        }

        private void txtUserNo_EditValueChanged(object sender, EventArgs e)
        {
            string user_no = txtUserNo.Text.Trim();
            if (user_no != "")
            {
                Regex rgx = new Regex("^[A-Z,a-z,0-9]{1,13}$"); //判断数字是否为4位
                if (rgx.IsMatch(user_no) == false)
                {
                    lblUserNos.ForeColor = Color.Red;
                    lblUserNos.Text = "用户名格式错误,请输入0-13位的用户名";
                    return;
                }
                lblUserNos.ForeColor = Color.Green;
                lblUserNos.Text = "正确";
                return;
            }
            else
            {
                lblUserNos.ForeColor = Color.Red;
                lblUserNos.Text = "用户名不能为空";
                return;
            }
        }

        private void txtUserPwd_EditValueChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("^[A-Z,a-z,0-9]{1,13}$"); //判断数字是否为4位
            if (rgx.IsMatch(txtUserPwd.Text.Trim()) == false || txtUserPwd.Text.Trim() == "")
            {
                this.lblUserPwds.ForeColor = Color.Red;
                this.lblUserPwds.Text = "密码格式错误,请输入0-9的6到13位数字";
                return;
            }
            this.lblUserPwds.ForeColor = Color.Green;
            this.lblUserPwds.Text = "正确";
            return;
        }

        private void txtReUserPwd_EditValueChanged(object sender, EventArgs e)
        {
            if (txtReUserPwd.Text.Trim() == txtUserPwd.Text.Trim())
            {
                lblReUserPwds.Text = "正确";
                lblReUserPwds.ForeColor = Color.Green;
                return;
            }
            else
            {
                lblReUserPwds.Text = "两次密码输入不一致";
                lblReUserPwds.ForeColor = Color.Red;
                return;
            }
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("^[A-Z,a-z,0-9]{1,13}$"); //判断数字是否为0-13位

            if (rgx.IsMatch(txtUserName.Text.Trim()) == false || txtUserName.Text.Trim() == "")
            {
                lblUserNames.ForeColor = Color.Red;
                lblUserNames.Text = "请输入1-13位的用户姓名";
                return;
            }
            lblUserNames.ForeColor = Color.Green;
            lblUserNames.Text = "正确";
            return;
        }

        private void FrmUserRegister_Load(object sender, EventArgs e)
        {
            #region 设置pictureBox图片控件为圆的
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox.ClientRectangle);
            Region region = new Region(gp);
            pictureBox.Region = region;
            gp.Dispose();
            region.Dispose();
            #endregion
            this.timer.Start();//开启计时器
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var card_no = CardReader.Read();
            if (card_no != "")
            {
                this.txtCardNo.Text = card_no;//如果用户打卡就将卡号加到card_no中
            }
        }
    }
}
