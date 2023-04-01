using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinClient;

namespace QA.winfrom
{
    public partial class FrmUserEditModify : XtraForm
    {
        public FrmUserEditModify()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }



        OpenFileDialog dic = new OpenFileDialog();

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (dic.ShowDialog() == DialogResult.OK)
            {
                var dt = $"select * from UserInfo where user_no =@user_no".EQ(("@user_no", SqlHelper.user_no));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var photo = File.ReadAllBytes(dic.FileName);
                    $"update UserInfo set photo=@photo where user_no=@user_no".ENQ(("@photo", photo, typeof(byte[]).FullName), ("@user_no", SqlHelper.user_no, typeof(string).FullName));
                    Refrest();
                }
            }
        }

        OpenFileDialog dia = new OpenFileDialog();
        private void lblbackground_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dia.ShowDialog() == DialogResult.OK)
            {
                var dt = $"select * from UserInfo where user_no =@user_no".EQ(("@user_no", SqlHelper.user_no));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var background = File.ReadAllBytes(dia.FileName);
                    $"update UserInfo set background=@background where user_no=@user_no".ENQ(("@background", background, typeof(byte[]).FullName), ("@user_no", SqlHelper.user_no, typeof(string).FullName));
                    this.Refrest();
                }
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        public void Refrest()
        {
            var dt = $"select * from UserInfo where user_no =@user_no".EQ(("@user_no", SqlHelper.user_no));
            if (dt != null && dt.Rows.Count > 0)
            {

                {
                    var dr = dt.Rows[0];
                    var background = dr["background"];
                    if (background != null && background != DBNull.Value)
                    {
                        var backgroundByte = Convert.FromBase64String(background.ToString());
                        this.picbackground.Image = Image.FromStream(new MemoryStream(backgroundByte));
                    }
                    else
                    {
                        this.picbackground.Image = QA.Properties.Resources.images;
                    }
                }
                this.lblUserNo.Text = SqlHelper.user_name;
                {
                    var dr = dt.Rows[0];
                    var photo = dr["Photo"];
                    if (photo != null && photo != DBNull.Value)
                    {
                        var photoByte = Convert.FromBase64String(photo.ToString());
                        this.pictureBox.Image = Image.FromStream(new MemoryStream(photoByte));
                        return;
                    }
                    else
                    {
                        this.pictureBox.Image = QA.Properties.Resources._default;
                    }
                }
            }
            else
            {
                MessageBox.Show("获取参数错误");
                this.Close();
            }
        }
        public void LoadData()
        {
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
                this.labUserNo.Text = SqlHelper.user_no;
                this.txtTelephone.Text = mobile;
                this.lblYear.Text = user_year;
                this.lblSex.Text = user_sex;
                this.lblAge.Text = user_Age;
                this.lblUserNo.Text = SqlHelper.user_name;
            }
        }

        private void FrmUserEditModify_Load(object sender, EventArgs e)
        {
            this.Refrest();

            #region 设置label控件背景颜色
            lblUserNo.BackColor = Color.Transparent;//透明
            lblbackground.BackColor = Color.Transparent;
            lblimages.BackColor = Color.Transparent;
            lblimage.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;

            panel3.Parent = picbackground;
            this.panel3.BackColor = Color.FromArgb(10 * 10, 255, 255, 255);
            lblUserNo.Parent = panel3;//绑定图片
            lblbackground.Parent = picbackground;

            lblimage.Size = new Size(55, 14);
            lblUserEdit.Size = new Size(55, 14);
            #endregion

            #region 设置pictureBox图片控件为圆的
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox.ClientRectangle);
            Region region = new Region(gp);
            pictureBox.Region = region;
            gp.Dispose();
            region.Dispose();
            #endregion

            #region 设置用户基本信息
            this.LoadData();//刷新
            #endregion

            #region 设置图片
            var deet = SqlHelper.EQ("select * from UserInfo where user_no = @user_no", ("user_no", SqlHelper.user_no));
            if (deet != null && deet.Rows.Count > 0)
            {
                var det_guid = deet.Rows[0]["guid"];
                var dt = $"select * from UserImage where user_no = @user_no".EQ(("@user_no", det_guid));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var Count = dt.Rows.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        var dr = dt.Rows[i]["UserImage"];

                        if (i == 0)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox1.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 1)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox2.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 2)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox3.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 3)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox4.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                    }
                }
            }
            #endregion

            this.Refrest();
        }

        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        private void lblimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var photo = OpenFileDialog.FileName;
                var photos = File.ReadAllBytes(photo);
                var det = SqlHelper.EQ("select * from UserInfo where user_no = @user_no", ("user_no", SqlHelper.user_no));
                if (det != null && det.Rows.Count > 0)
                {
                    var det_guid = det.Rows[0]["guid"];
                    $"insert into UserInfos (user_no,user_nos)values('{"136"}','{"185"}')".ENQ();
                    var a = $"select * from UserInfos where user_no = 136".EQ();
                    $"insert into UserImage(UserImage,user_no)values(@UserImage,@user_no)".ENQ(("@UserImage", photos, typeof(byte[]).FullName), ("@user_no", det_guid, typeof(string).FullName));
                }
            }
            #region 设置图片
            var deet = SqlHelper.EQ("select * from UserInfo where user_no = @user_no", ("user_no", SqlHelper.user_no));
            if (deet != null && deet.Rows.Count > 0)
            {
                var det_guid = deet.Rows[0]["guid"];
                var dt = $"select * from UserImage where user_no = @user_no".EQ(("@user_no", det_guid));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var Count = dt.Rows.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        var dr = dt.Rows[i]["UserImage"];

                        if (i == 0)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox1.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 1)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox2.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 2)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox3.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                        if (i == 3)
                        {
                            var photoByte = Convert.FromBase64String(dr.ToString());
                            this.pictureBox4.Image = Image.FromStream(new MemoryStream(photoByte));
                        }
                    }
                }
            }
            #endregion
        }

        private void lblUserEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FrmUserEdit();
            frm.ShowDialog();
            this.Show();
            this.LoadData();
        }
    }
}
