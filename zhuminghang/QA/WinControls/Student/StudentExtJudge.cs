using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuade.WinControls.Student
{
    public partial class StudentExtJudge : UserControl
    {
        public StudentExtJudge()
        {
            InitializeComponent();
        }
        public void aedd(string a = "true")
        {
            if (a == "true")
            {
                CkYes.Checked = true;
                return;
            }
            if (a == "false")
            {
                CkNo.Checked = true;
                return;
            }
            MessageBox.Show("没有选项");
            return;
        }
    }
}
