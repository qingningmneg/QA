using DevExpress.XtraEditors;
using QA.winfrom;
using QA.winfrom.Student;
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

namespace QA
{
    public partial class FrmStudentUserMainFrom : XtraForm
    {
        private string user_no;

        public FrmStudentUserMainFrom()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmStudentUserMainFrom(string user_no) : this()
        {
            this.user_no = user_no;
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改用户基础信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserModifys_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmUserEditModify();
            frm.ShowDialog();
            this.Show();
        }

        private void btnUserModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmUserEditModify();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAdd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmStudentUserchoice).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmStudentUserchoice();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        private void btncencel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var json = new { user_no = "", user_pwd = "", zidong = false, jizhu = false }.ToJsonString();
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "zi.json", json);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 窗体加载事件,加载欢迎页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStudentUserMainFrom_Load(object sender, EventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmStudentHello).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmStudentHello();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        private void btnWrong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmText).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmText();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }
    }
}
