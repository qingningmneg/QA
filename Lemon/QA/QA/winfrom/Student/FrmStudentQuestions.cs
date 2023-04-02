using DevExpress.Printing.Core.PdfExport.Metafile;
using DevExpress.XtraEditors;
using Kuade.WinControls.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class FrmStudentQuestions : XtraForm
    {
        string guid;
        string text;

        public FrmStudentQuestions()
        {
            InitializeComponent();
            //AutoScaleMode = AutoScaleMode.None;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }
        #region 窗体自适应缩放
        private Size m_szInit;//初始窗体大小
        private Dictionary<Control, Rectangle> m_dicSize
            = new Dictionary<Control, Rectangle>();

        protected override void OnLoad(EventArgs e)
        {
            m_szInit = this.Size;//获取初始大小
            this.GetInitSize(this);
            base.OnLoad(e);
        }

        private void GetInitSize(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                m_dicSize.Add(c, new Rectangle(c.Location, c.Size));
                this.GetInitSize(c);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            //计算当前大小和初始大小的比例
            float fx = (float)this.Width / m_szInit.Width;
            float fy = (float)this.Height / m_szInit.Height;
            foreach (var v in m_dicSize)
            {
                v.Key.Left = (int)(v.Value.Left * fx);
                v.Key.Top = (int)(v.Value.Top * fy);
                v.Key.Width = (int)(v.Value.Width * fx);
                v.Key.Height = (int)(v.Value.Height * fy);
            }
            base.OnResize(e);
        }
        #endregion

        public FrmStudentQuestions(string guid, string text) : this()
        {
            this.guid = guid;
            this.text = text;
            Text = "选择模式 科目：" + text;
        }

        private void FrmStudentQuestions_Load(object sender, EventArgs e)
        {
            #region 样式
            btnRandom.FlatStyle = FlatStyle.Flat;//样式
            btnRandom.BackColor = Color.Transparent;//去背景
            btnRandom.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            btnRandom.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下

            btnChoice.FlatStyle = FlatStyle.Flat;//样式
            btnChoice.BackColor = Color.Transparent;//去背景
            btnChoice.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            btnChoice.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下
            #endregion
        }

        #region 样式
        private void btnChoice_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 2;
        }

        private void btnChoice_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btnRandom_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 2;
        }

        private void btnRandom_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }
        #endregion

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var dt = SqlHelper.EQ("select b.* from ExamInfo a join ExamSubjectInfo b on a.guid = b.exam_guid where a.exam_type_guid =@guid", ("@guid", guid));
            if (dt != null && dt.Rows.Count > 0)
            {



                var texts = "科目：" + this.text;
                var pattern = (sender as Button).Text;
                if (guid != "")
                {
                    var frm = new FrmStudentExamination(this.guid, texts, pattern);
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("没有考题");
                    return;
                }
            }
            else
            {
                MessageBox.Show("该科目暂时没有考题");
                return;
            }
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            var frm = new FrmStudentUserchoice(text);
            frm.ShowDialog();
            this.Close();
        }
    }
}
