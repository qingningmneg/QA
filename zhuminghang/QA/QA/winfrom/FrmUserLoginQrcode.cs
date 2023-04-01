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
    public partial class FrmUserLoginQrcode : XtraForm
    {
        string barcode;
        public FrmUserLoginQrcode()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        private void time_Tick(object sender, EventArgs e)
        {
            var dt = $"select * from BarCodeInfo where barcode = @barcode".EQ(("@barcode", this.barcode));
            if (dt != null && dt.Rows.Count > 0)
            {
                var dr = dt.Rows[0];
                var user_no = dr["user_no"];
                if (user_no != DBNull.Value)
                {
                    SqlHelper.user_no = Convert.ToString(dr["user_no"]);
                    var dt_UserInfo = $"select * from UserInfo where user_no = @user_no".EQ(("@user_no", user_no));
                    if (dt_UserInfo != null)
                    {
                        var UserInfo_user_type = Convert.ToInt32(dt_UserInfo.Rows[0]["user_type"]);
                        if (UserInfo_user_type == 1)
                        {
                            time.Stop();
                            timer.Stop();
                            this.Hide();
                            $@"delete from BarCodeInfo where barcode = @barcode".ENQ(("@barcode", barcode));
                            var frm = new FrmTeacherUserMainFrom(user_no.ToString());
                            frm.ShowDialog();
                            this.Show();
                            this.LoadBarCode();
                            time.Start();
                            timer.Start();
                        }
                        else
                        {
                            this.timer.Stop();
                            SqlHelper.user_no = Convert.ToString(dr["user_no"]);
                            time.Stop();
                            timer.Stop();
                            this.Hide();
                            $@"delete from BarCodeInfo where barcode = @barcode".ENQ(("@barcode", barcode));
                            var frm = new FrmStudentUserMainFrom(user_no.ToString());
                            frm.ShowDialog();
                            this.Show();
                            this.LoadBarCode();
                            time.Start();
                            timer.Start();
                        }
                    }

                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.LoadBarCode();
        }
        /// <summary>
        /// 刷新二维码
        /// </summary>
        public void LoadBarCode()
        {
            $@"delete from BarCodeInfo where barcode = @barcode ".ENQ(("@barcode", this.barcode));
            var barcode = Guid.NewGuid().ToString();
            this.barCodeControl.Text = barcode;

            this.barcode = barcode;

            $@"insert into BarCodeInfo(barcode) values(@barcode)".ENQ(("@barcode", barcode));
        }

        private void FrmUserLoginQrcode_Load(object sender, EventArgs e)
        {
            this.LoadBarCode();
            this.timer.Start();
            this.time.Start();
        }
    }
}
