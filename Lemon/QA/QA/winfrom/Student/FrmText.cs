using DevExpress.XtraPrinting;
using Kuade.WinControls;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA.winfrom.Student
{
    public partial class FrmText : Form
    {
        public FrmText()
        {
            InitializeComponent();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
            string a = "使用这个数字truetruetrue";
            a = a.Substring(0, a.Length - 4);
            this.labelControl1.Text = a;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        

        ExtAnalysis extAnalysis1 = new ExtAnalysis();
        private void button1_Click(object sender, EventArgs e)
        {
//Regex rgx = new Regex("^[A-Z,a-z,0-9]{1,13}$"); //判断数字是否为4位

            //string pattern = "(?:(?<Test>中级,/d,/d,/d,/d,年下,/d,/d)\\W|(?<Test>中级,/d,/d,/d,/d,年下,/d,/d\\Z))";
            //Regex regex = new Regex(pattern);
            //string input = "中级2020年下01";

            //Match m;

            //for (m = regex.Match(input); m.Success; m = m.NextMatch())
            //{
            //    Console.WriteLine(m.ToString() + " at " + m.Groups[1].Index);
            //}



            //object readOnly = true;
            //object missing = System.Reflection.Missing.Value;
            //object fileName = "E:\\TTTOOo\\1.doc";
            ////初始化word程序
            //ApplicationClass wordapp = new ApplicationClass();
            ////打开指定的doc文件
            //Document doc = wordapp.Documents.Open(ref fileName,
            //ref missing, ref readOnly, ref missing, ref missing, ref missing,
            //ref missing, ref missing, ref missing, ref missing, ref missing,
            //ref missing, ref missing, ref missing, ref missing, ref missing);
            ////读取指定的doc文件文本
            //string text = doc.Content.Text;
            //textBox1.Text = text;
            ////读取指定的doc文件图片
            //InlineShapes ils = doc.InlineShapes;
            //foreach (InlineShape temp in ils)
            //{
            //    //选择图片
            //    temp.Select();
            //    //将图片放入剪贴板
            //    wordapp.Selection.Copy();
            //    //这里可写对图片的处理
            //    System.Drawing.Image img = System.Windows.Forms.Clipboard.GetImage();

            //    pictureBox1.Image = img;
            //}
            ////关闭打开的doc文档
            //doc.Close(ref missing, ref missing, ref missing);
            ////退出word程序
            //wordapp.Quit(ref missing, ref missing, ref missing);


        }


        private void button2_MouseLeave(object sender, EventArgs e)
        {
            WinClient.Animation.ShowControl(extAnalysis1, false);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            FlowLayout.Controls.Add(extAnalysis1);
            WinClient.Animation.ShowControl(extAnalysis1, true, AnchorStyles.Bottom);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = "";
            string str = textBox1.Text;
            //
            //^[\u4E00-\u9FA5]+[\u4E00-\u9FA5]+[\\d{4}]+[\u4E00-\u9FA5]+[\u4E00-\u9FA5]+[\\d{2}]$
            if (Regex.IsMatch(str, "^[\\w]级20+[0-9]{2}年+[\\-\\w]+$"))
            {
                textBox1.Text = "Yes";
            }
            else
            {
                textBox1.Text = "No";
            }
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
