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

namespace Kuade.WinControls.ExtOption
{
    public partial class FrmText : XtraForm
    {
        string text;
        private ExtOptions extOptions;

        public FrmText()
        {
            InitializeComponent();
            //AutoScaleMode = AutoScaleMode.None;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmText(string text, ExtOptions extOptions) : this()
        {
            this.text = text;
            this.extOptions = extOptions;
            if (this.text != null)
            {
                this.ExtOptions1.RtfText = this.text;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            extOptions.ExtOptions1.RtfText = this.ExtOptions1.RtfText;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
