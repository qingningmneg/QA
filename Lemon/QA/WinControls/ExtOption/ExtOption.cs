using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControls;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kuade.WinControls.ExtOption
{
    public partial class ExtOption : UserControl
    {
        ExtMulitOptionList aedExtMulitOptionList;
        private string _CheekText = "A";
        public string CheekText
        {
            get
            {
                return _CheekText;
            }
            set
            {
                _CheekText = value;
                this.Cheek.Text = " " + value;
            }
        }

        public ExtOption()
        {
            InitializeComponent();
        }
        public void ExtText(byte[] a)
        {
            extOptions.ExtText(a);
        }

        public void Text(string a)
        {
            extOptions.Text(a);
        }

        private void Cheek_CheckedChanged(object sender, EventArgs e)
        {
            aedExtMulitOptionList.Obtain();
        }

        internal void ht(ExtMulitOptionList aedExtMulitOptionList)
        {
            this.aedExtMulitOptionList = aedExtMulitOptionList;
        }

        public void barCli()
        {
            extOptions.barCli();
        }
    }
}
