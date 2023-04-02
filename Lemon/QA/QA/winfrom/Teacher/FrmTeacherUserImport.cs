using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using NPOI.XWPF.UserModel;
using QA.winfrom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class FrmTeacherUserImport : XtraForm
    {
        public FrmTeacherUserImport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 导入word文档按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportWord_Click(object sender, EventArgs e)
        {
            CreateFile("16","3","15");
            Refrest();
        }

        /// <summary>
        /// word的内容
        /// </summary>
        StringBuilder sb = new StringBuilder();

        string strText;
        List<string> subject = new List<string>();

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="title">标题格式</param>
        /// <param name="Subtopic">题目格式</param>
        /// <param name="answer">答案格式</param>
        public void CreateFile(string title,string Subtopic,string answer)
        {
            sb.Clear();
            strText = "";
            subject.Clear();
            var dia = new OpenFileDialog();
            using (dia)
            {
                if (dia.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\json"))
                    {
                        DirectoryInfo _d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\json");
                        _d.Delete(true);//删除子目录和文件
                    }
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\json"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\json");
                    }
                    if (dia.FileName != null)
                    {
                        try
                        {
                            using (FileStream stream = File.OpenRead(dia.FileName))
                            {
                                XWPFDocument doc = new XWPFDocument(stream);
                                foreach (var para in doc.Paragraphs)
                                {
                                    string text = para.ParagraphText; //获得文本

                                    var img = para.PictureText; //获得文本

                                    var biao = para.CreateRun();
                                    var cctv = para.Style;
                                    if (text != title)
                                    {
                                        if (cctv == title)
                                        {
                                            text += "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzi";//64个随机符号数字英文避免重复
                                        }
                                        if (cctv == Subtopic || cctv == answer)
                                        {
                                            text += "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste";//64个随机符号数字英文避免重复
                                        }
                                    }
                                    sb.AppendLine(text);
                                }
                                var a = sb.ToString().Split('\n', '\r', '\t').ToList().Where(b => !string.IsNullOrWhiteSpace(b)).ToList();
                                var count = a.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    var text = a[i];
                                    if (Regex.IsMatch(text, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzi+$"))//64个随机符号数字英文避免重复
                                    {
                                        if (subject.Count != 0)
                                        {
                                            var jsons = new { subject = subject };
                                            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/json/" + this.strText + ".json", JsonConvert.SerializeObject(jsons));
                                        }
                                        subject.Clear();

                                        text = text.Remove(text.Length - 63);//大标题
                                        this.strText = text;
                                    }
                                    else
                                    {
                                        if (text != "")
                                        {
                                            subject.Add(text);
                                            var Count = subject.Count();
                                        }
                                    }
                                }
                                var jsonss = new { subject = subject };
                                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/json/" + this.strText + ".json", JsonConvert.SerializeObject(jsonss));
                                subject.Clear();
                            }
                            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\json" + "\\请不要以任何形式删除该文件夹中的文件"))
                            {
                                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\json" + "\\请不要以任何形式删除该文件夹中的文件");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("出现未知错误，可能是您的word文档并没有关闭引起的", "警告");
                            return;
                        }
                    }
                }
            }
        }

        string jsonText;
        /// <summary>
        /// 初始化数据结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacherUserImport_Load(object sender, EventArgs e)
        {
            #region 加载格式示例
            this.txtText.Text = @"格式1示例:
    中级1998年下某某学校考试题库 <==‘标题’格式,不能重复
中级2020年下01  <==‘标题2’格式,不能重复
 题目：......  <==请不要换行
小题答案1  <==每一个答案为一行
A
B
C
......
小题答案2
A
B
C
D
......


格式2示例:
    中级1998年下某某学校考试题库 <==‘标题’格式,不能重复
中级1998年下01  <==‘标题2’格式,不能重复
题目：......  <==请不要换行
答案   <==每一个答案为一行
A
B
C
D
中级1998年下02
A
......
";
            #endregion

            //设置数据结构
            Refrest();
        }

        private void gridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //考题年份 gridColumn
            view.SetRowCellValue(e.RowHandle, view.Columns["考题年份"], jsonText);
        }

        private void btnEmpty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\json"))
            {
                DirectoryInfo _d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\json");
                _d.Delete(true);//删除子目录和文件
            }
            Refrest();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void Refrest()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("txtyear", Type.GetType("System.String"));
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "json"))
            {
                DirectoryInfo TheFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "json");
                //遍历文件
                foreach (global::System.IO.FileInfo NextFile in TheFolder.GetFiles())
                {
                    jsonText = NextFile.Name;
                    jsonText = jsonText.Remove(jsonText.Length - 5);//大标题
                    dt.Rows.Add(jsonText);
                }
            }
            this.gridControl.DataSource = dt;
        }

        private void btnRefrest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refrest();
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            var Row = gridView.GetFocusedDataRow();
            if (Row != null)
            {
                var Textjson = Convert.ToString(Row["txtyear"]);
                var frm = new FrmTeacherUserImportAnswer(Textjson);
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
