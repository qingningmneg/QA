using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuade.WinControls
{
    public partial class StudentButt : UserControl
    {
        public StudentButt()
        {
            InitializeComponent();
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

        private void StudentButt_Load(object sender, EventArgs e)
        {
            btnRandom.FlatStyle = FlatStyle.Flat;//样式
            btnRandom.ForeColor = Color.Transparent;//前景：如果不想字体透明就吧这段注释掉
            btnRandom.BackColor = Color.Transparent;//去背景
            btnRandom.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            btnRandom.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下
        }

        public void Text(string text)
        {
            this.btnRandom.Text = text;
        }
    }
}
