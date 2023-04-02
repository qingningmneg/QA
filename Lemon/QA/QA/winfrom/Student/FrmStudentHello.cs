using DevExpress.XtraEditors;

using Kuade.WinControls;

using QA.file;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class FrmStudentHello : XtraForm
    {
        string guid;
        public FrmStudentHello()
        {
            InitializeComponent();
        }

        private void FrmStudentHello_Load(object sender, EventArgs e)
        {
            FlowLayout.WrapContents = false;
            var dt = ClassMethod.lemonSelectExamTypeInfo();
            if (dt != null && dt.Rows.Count > 0)
            {
                var dt_Count = dt.Rows.Count;
                for (int i = 0; i < dt_Count; i++)
                {
                    string Text = dt.Rows[i]["exam_type"].ToString();
                    guid = dt.Rows[i]["guid"].ToString();
                    StudentButt StudentButt = new StudentButt();
                    FlowLayout.Controls.Add(StudentButt);
                    StudentButt.Text(Text);
                    StudentButt.btnRandom.Click += new EventHandler(StudentButt_Click);
                }
            }
            else
            {

            }
        }

        /// <summary>
        /// dia点击触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void StudentButt_Click(object sender, EventArgs e)
        {
            var text = (sender as Button).Text.ToString();
            if (text != null)
            {
                var dt = ClassMethod.lemonExamTypeInfoExamType(text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    guid = dt.Rows[0]["guid"].ToString();

                    var frm = new FrmStudentQuestions(guid, text);
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("科目不存在");
                return;
            }
        }
        private void FrmStudentHello_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
