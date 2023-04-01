using DevExpress.XtraBars;
using Kuade.WinControls.ExtOption;
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
using WinControls;

namespace Kuade.WinControls
{
    public partial class ExtOptions : UserControl
    {

        public string str = "";
        public ExtOptions()
        {
            InitializeComponent();
        }

        public void ExtText(byte[] a)
        {
            ExtOptions1.RtfText = SqlHelper.RtxBytesToString(a);
        }
        public void Text(string a)
        {
            ExtOptions1.Text = a;
        }


        public void cold()
        {
            ExtOptions1.BackColor = Color.Red;
        }

        public void barCli()
        {
            //barManager1.GetController().Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Text = this.ExtOptions1.RtfText;
            var frm = new FrmText(Text, this);
            frm.ShowDialog();
            this.Show();
        }
    }
}
