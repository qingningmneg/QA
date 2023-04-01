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
    public partial class FrmTeacherUserMainFrom : XtraForm
    {
        private string user_no;

        public FrmTeacherUserMainFrom()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmTeacherUserMainFrom(string user_no) : this()
        {
            this.user_no = user_no;
        }

        /// <summary>
        /// 年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnyears_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmTeacherUserNewYear).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmTeacherUserNewYear();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        /// <summary>
        /// 类型编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntypes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmTeacherUserEditType).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmTeacherUserEditType();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        /// <summary>
        /// 查看考题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmTeacherUserYear).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmTeacherUserYear();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        /// <summary>
        /// 编辑考题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barQuestionsEdit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmTeacherUserEditSearch).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmTeacherUserEditSearch();
            frmmmm.MdiParent = this;
            frmmmm.Show();
        }

        private void btnUserModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmUserEditModify();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCencel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var json = new { user_no = "", user_pwd = "", zidong = false, Remember = false }.ToJsonString();
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "zi.json", json);
            this.DialogResult = DialogResult.OK;
        }

        private void btnImport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (var frmChild in this.MdiChildren)
            {
                if (frmChild.GetType().FullName == typeof(FrmTeacherUserImport).FullName)
                {
                    frmChild.Activate();
                    return;
                }
            }
            var frmmmm = new FrmTeacherUserImport();
            frmmmm.MdiParent = this;
            frmmmm.Show();

        }
    }
}
