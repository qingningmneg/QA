using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.SpellChecker;
using Kuade.WinControls;
using Kuade.WinControls.ExtOption;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QA.file;

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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace QA.winfrom
{
    public partial class FrmTeacherUserImportAnswer : XtraForm
    {
        private string textjson;


        public FrmTeacherUserImportAnswer()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmTeacherUserImportAnswer(string textjson) : this()
        {
            this.textjson = textjson;
        }

        List<string> subject = new List<string>();
        private void FrmTeacherUserImportAnswer_Load(object sender, EventArgs e)
        {
            subject.Clear();
            txttype.Properties.Items.Add("多选题");
            txttype.Properties.Items.Add("单选题");
            txttype.Properties.Items.Add("判断题");
            txttype.Properties.Items.Add("问答题");
            txttype.SelectedIndex = 0;
            txttopics.Text = "1";

            Animation.ShowControl(FlowLayout, false, AnchorStyles.Bottom);
            Refrest();
            var Row = gridView.GetFocusedDataRow();
            if (Row == null)
            {
                MessageBox.Show("没有值");
                return;
            }
            this.Textjson = Convert.ToString(Row["txtyear"]);
            Initial();
        }

        /// <summary>
        /// 用户点击后得到的题目集合
        /// </summary>
        List<string> answerText = new List<string>();
        bool a = false;
        string Textjson = "";
        private void gridControl_Click(object sender, EventArgs e)
        {
            Initial();
        }

        /// <summary>
        /// 加载考题
        /// </summary>
        public void Initial()
        {
            #region 初始化数值
            Textjson = "";
            answerText.Clear();
            #endregion

            Animation.ShowControl(FlowLayout, false, AnchorStyles.Bottom);//页面动画

            var Row = gridView.GetFocusedDataRow();
            if (Row != null)
            {
                this.Textjson = Convert.ToString(Row["txtyear"]);
                var Count = subject.Count();
                for (int i = 0; i < Count; i++)
                {
                    var subjectText = subject[i];
                    if (Regex.IsMatch(subjectText, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                    {
                        subjectText = subjectText.Remove(subjectText.Length - 67);//小题
                        if (Textjson == subjectText)
                        {
                            a = true;
                        }
                        else
                        {
                            a = false;
                        }
                    }
                    else
                    {
                        if (a == true)
                        {
                            answerText.Add(subjectText);
                        }
                    }
                }
                var answerTextCount = answerText.Count();

                var textCount = answerTextCount - 1;
                if (textCount < 4)
                {
                    txttopics.Text = "1";
                    Count = 1;
                }
                else
                {
                    var tishu = textCount / 4;
                    txttopics.Text = tishu.ToString();
                    Count = tishu;
                }
                if (txttype.Text == "单选题")
                {
                    ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[0];//单选
                    ExtSinglOptionLists.Clear();
                    for (int i = 0; i < answerTextCount; i++)
                    {
                        if (i == 0)
                        {
                            var answerTexts = answerText[i];//题目
                            extOptions.Text(answerTexts);
                        }
                        else
                        {
                            var answerTexts = answerText[i];//答案
                            ExtSinglOptionLists.AddOption();

                            var ExtOptions = ExtSinglOptionLists.flowText.Controls[i] as ExtOptions;
                            ExtOptions.Text(answerTexts);
                        }
                    }

                }
                if (txttype.Text == "多选题")
                {
                    ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[0];//单选
                    ExtMulitOptionLists.Clear();
                    for (int i = 0; i < answerTextCount; i++)
                    {
                        var a = i - 1;
                        if (i == 0)
                        {
                            var answerTexts = answerText[i];//题目
                            extOptions.Text(answerTexts);
                        }
                        else
                        {
                            var answerTexts = answerText[i];//答案

                            ExtMulitOptionLists.AddOption();
                            var ExtOptions = ExtMulitOptionLists.FlowLayout.Controls[a] as ExtOption;
                            ExtOptions.Text(answerTexts);
                        }
                    }
                }
                if (txttype.Text == "问答题")
                {
                    Kuade.WinControls.ExtAnswer ExtAnswer = (Kuade.WinControls.ExtAnswer)this.FlowLayout.Controls[0];//单选
                    for (int i = 0; i < answerTextCount; i++)
                    {
                        if (i == 0)
                        {
                            var answerTexts = answerText[i];//题目
                            extOptions.Text(answerTexts);
                        }
                        else
                        {
                            var answerTexts = answerText[i];//答案

                        }
                    }
                }
                if (txttype.Text == "判断题")
                {
                    ExtJudge ExtJudge = (ExtJudge)this.FlowLayout.Controls[0];//单选

                    for (int i = 0; i < answerTextCount; i++)
                    {
                        if (i == 0)
                        {
                            var answerTexts = answerText[i];//题目
                            extOptions.Text(answerTexts);
                        }
                        else
                        {
                            var answerTexts = answerText[i];//答案

                        }
                    }
                }
                if (txttype.Text == "")
                {
                    FlowLayout.Controls.Clear();
                }
            }

            Animation.ShowControl(FlowLayout, true, AnchorStyles.Bottom);//页面动画
        }


        int Count = 0;//添加控件

        /// <summary>
        /// 添加控件
        /// </summary>
        public void dataFlowLayouts()
        {
            var txttopics_Count = Convert.ToInt32(this.txttopics.Value);
            if (txttopics_Count == 0)
            {
                return;
            }
            if (txttopics_Count > Count)
            {
                var b = txttopics_Count - Count;
                for (int i = 0; i < b; i++)
                {
                    var edi = this.FlowLayout.Controls.Count;
                    int ed = txttopics_Count - edi;
                    if (txttype.Text == "单选题")
                    {
                        ExtSinglOptionList ExtSinglOptionList = new ExtSinglOptionList();
                        FlowLayout.Controls.Add(ExtSinglOptionList);
                        ExtSinglOptionList.labText(txttopics_Count);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionList = new ExtMulitOptionList();
                        FlowLayout.Controls.Add(ExtMulitOptionList);
                        ExtMulitOptionList.labText(txttopics_Count);
                    }
                    if (txttype.Text == "问答题")
                    {
                        Kuade.WinControls.ExtAnswer ExtAnswer = new Kuade.WinControls.ExtAnswer();
                        FlowLayout.Controls.Add(ExtAnswer);
                    }
                    if (txttype.Text == "判断题")
                    {
                        ExtJudge ExtJudge = new ExtJudge();
                        FlowLayout.Controls.Add(ExtJudge);
                        ExtJudge.extAnalysis1.ExtEnabled();
                    }
                    if (txttype.Text == "")
                    {
                        FlowLayout.Controls.Clear();
                    }
                }
            }
            if (txttopics_Count < Count)
            {
                for (int i = Count; i > txttopics_Count; i--)
                {
                    if (txttype.Text == "单选题")
                    {
                        ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[Count - 1];//单选
                        ExtSinglOptionLists.ClearMemorys();
                        FlowLayout.Controls.Remove(ExtSinglOptionLists);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[Count - 1];//单选
                        ExtMulitOptionLists.ClearMemorys();

                        FlowLayout.Controls.Remove(ExtMulitOptionLists);
                    }
                    if (txttype.Text == "问答题")
                    {
                        Kuade.WinControls.ExtAnswer ExtAnswers = (Kuade.WinControls.ExtAnswer)this.FlowLayout.Controls[Count - 1];//单选
                        ExtAnswers.ClearMemorys();

                        FlowLayout.Controls.Remove(ExtAnswers);
                    }
                    if (txttype.Text == "判断题")
                    {
                        ExtJudge ExtJudges = (ExtJudge)this.FlowLayout.Controls[Count - 1];//单选
                        ExtJudges.ClearMemorys();

                        FlowLayout.Controls.Remove(ExtJudges);
                    }
                    if (txttype.Text == "")
                    {
                        FlowLayout.Controls.Clear();
                    }
                }
            }
            this.Count = txttopics_Count;
        }

        /// <summary>
        /// 添加控件
        /// </summary>
        public void dataFlowLayout()
        {
            var txttopics_count = Convert.ToInt32(this.txttopics.Value);
            if (txttopics_count > Count)
            {
                var b = txttopics_count - Count;
                for (int i = 0; i < b; i++)
                {
                    var edi = this.FlowLayout.Controls.Count;
                    int ed = txttopics_count - edi;
                    if (txttype.Text == "单选题")
                    {
                        ExtSinglOptionList ExtSinglOptionList = new ExtSinglOptionList();
                        FlowLayout.Controls.Add(ExtSinglOptionList);
                        ExtSinglOptionList.AddOption(4);
                        ExtSinglOptionList.labText(txttopics_count);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionList = new ExtMulitOptionList();
                        FlowLayout.Controls.Add(ExtMulitOptionList);
                        ExtMulitOptionList.AddOption(4);
                        ExtMulitOptionList.labText(txttopics_count);
                    }
                    if (txttype.Text == "问答题")
                    {
                        Kuade.WinControls.ExtAnswer ExtAnswer = new Kuade.WinControls.ExtAnswer();
                        FlowLayout.Controls.Add(ExtAnswer);
                    }
                    if (txttype.Text == "判断题")
                    {
                        ExtJudge ExtJudge = new ExtJudge();
                        FlowLayout.Controls.Add(ExtJudge);
                    }
                    if (txttype.Text == "")
                    {
                        FlowLayout.Controls.Clear();
                    }
                }
            }
            if (txttopics_count < Count)
            {

                for (int i = Count; i > txttopics_count; i--)
                {
                    if (txttype.Text == "单选题")
                    {
                        ExtSinglOptionList ExtSinglOptionList = new ExtSinglOptionList();
                        var ades = FlowLayout.Controls[Count - 1];

                        FlowLayout.Controls.RemoveAt(Count - 1);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionList = new ExtMulitOptionList();
                        FlowLayout.Controls.RemoveAt(Count - 1);
                    }
                    if (txttype.Text == "问答题")
                    {
                        Kuade.WinControls.ExtAnswer ExtAnswer = new Kuade.WinControls.ExtAnswer();
                        FlowLayout.Controls.RemoveAt(Count - 1);
                    }
                    if (txttype.Text == "判断题")
                    {
                        ExtJudge ExtJudge = new ExtJudge();
                        FlowLayout.Controls.RemoveAt(Count - 1);
                    }
                    if (txttype.Text == "")
                    {
                        FlowLayout.Controls.Clear();
                    }
                    Count--;
                }
            }
            this.Count = txttopics_count;
        }

        int b = 0;
        int intCount = 2;
        private void txttopics_TextChanged(object sender, EventArgs e)
        {
            txttopics.Properties.MinValue = 1;
            txttopics.Properties.MaxValue = 24;
            intCount++;

            if (this.b > 0)
            {
                this.b = this.b - 1;
                this.dataFlowLayouts();//方法(添加控件)
                return;
            }
            this.dataFlowLayout();//方法(添加控件)
        }

        /// <summary>
        /// 下拉框Text更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttype_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 保存题目按钮
        /// </summary>
        private void btnPreservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            preservation();
        }


        /// <summary>
        /// 修改后的保存题目
        /// </summary>
        List<string> jsonTe = new List<string>();
        int subjectCount = 0;
        int nextquestionCount = 0;
        List<string> lista = new List<string>();
        public void preservation()
        {
            //初始化数据
            lista.Clear();
            subjectCount = 0;
            nextquestionCount = 0;
            jsonTe.Clear();

            //查找考题所在行数
            int Count = subject.Count();
            for (int i = 0; i < Count; i++)
            {
                string subjectText = subject[i];
                if (Regex.IsMatch(subjectText, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                {
                    subjectText = subjectText.Remove(subjectText.Length - 67);//小题
                    if (Textjson == subjectText)
                    {
                        subjectCount = i;
                        a = true;
                    }
                    else
                    {
                        a = false;
                    }
                }
                else
                {
                    if (a == true)
                    {
                        nextquestionCount++;
                        jsonTe.Add(subjectText);
                    }
                }
            }

            //循环删除
            int jsonTeCount = jsonTe.Count;
            for (int i = 0; i < jsonTeCount; i++)
            {
                subject.Remove(jsonTe[i].ToString());
            }

            //将数据添加在数组中之后循环添加在存储题目的数组里
            {
                lista.Add(extOptions.ExtOptions1.Text);

                int FlowLayoutCount = FlowLayout.Controls.Count;
                for (int i = 0; i < FlowLayoutCount; i++)
                {
                    if (txttype.Text == "单选题")//判断是单选还是多选
                    {
                        ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];
                        dynamic json = JsonConvert.DeserializeObject(ExtSinglOptionLists.eddText());
                        var count = json.Eng.Count;
                        for (int b = 0; b < count; b++)
                        {
                            string see = json.strText;
                            lista.Add(see);
                        }
                    }
                    if (txttype.Text == "多选题")//判断是单选还是多选
                    {
                        ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];
                        dynamic json = JsonConvert.DeserializeObject(ExtMulitOptionLists.eddText());
                        var count = json.EngOne.Count;
                        for (int b = 0; b < count; b++)
                        {
                            string see = json.strTexts[b];
                            lista.Add(see);
                        }
                    }
                }
            }
            //设置作用域防止命名重复

            //循环添加在储存题目的list数组中
            {
                int listaCount = lista.Count();
                for (int i = 0; i < listaCount; i++)
                {
                    subjectCount++;
                    string listText = Convert.ToString(lista[i]);
                    subject.Insert(subjectCount, listText);
                }
            }
        }

        /// <summary>
        /// 重新读取word文档的刷新
        /// </summary>
        public void Refrest()
        {
            subject.Clear();
            #region 刷新
            DataTable dt = new DataTable();
            dt.Columns.Add("txtyear", Type.GetType("System.String"));
            using (dt)
            {
                if (textjson != "")
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/json/" + this.textjson + ".json"))
                    {
                        dynamic json = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/json/" + this.textjson + ".json"));

                        string jsonText = Convert.ToString(json.subject ?? "");
                        JArray jsonResponse = JArray.Parse(jsonText);

                        foreach (var item in jsonResponse)
                        {
                            var Text = Convert.ToString(item);
                            subject.Add(Text);


                            if (Regex.IsMatch(Text, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                            {
                                Text = Text.Remove(Text.Length - 67);//大标题
                                dt.Rows.Add(Text);
                            }
                            else
                            {
                            }
                        }
                        this.gridControl.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("遇到错误请及时反馈");
                    this.Close();
                }
            }
            #endregion
        }

        /// <summary>
        /// 仅仅重新读取list数组的刷新
        /// </summary>
        public void Refrests()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("txtyear", Type.GetType("System.String"));
            using (dt)
            {
                var subjectCount = subject.Count;
                for (int i = 0; i < subjectCount; i++)
                {
                    var subjectText = subject[i].ToString();
                    if (Regex.IsMatch(subjectText, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                    {
                        subjectText = subjectText.Remove(subjectText.Length - 67);//小题
                        dt.Rows.Add(subjectText);
                    }
                }
                this.gridControl.DataSource = dt;
            }
        }

        private void btndelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Delete();
            Refrests();
            Initial();
        }

        /// <summary>
        /// 删除考题
        /// </summary>
        public void Delete()
        {
            //初始化数据
            lista.Clear();
            subjectCount = 0;
            nextquestionCount = 0;
            jsonTe.Clear();

            //查找考题所在行数
            int Count = subject.Count();
            for (int i = 0; i < Count; i++)
            {
                string subjectText = subject[i];
                if (Regex.IsMatch(subjectText, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                {
                    subjectText = subjectText.Remove(subjectText.Length - 67);//大标题
                    if (Textjson == subjectText)
                    {
                        subjectCount = i;
                        a = true;
                        jsonTe.Add(subjectText + "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste");
                    }
                    else
                    {
                        a = false;
                    }
                }
                else
                {
                    if (a == true)
                    {
                        nextquestionCount++;
                        jsonTe.Add(subjectText);
                    }
                }
            }

            //循环删除
            int jsonTeCount = jsonTe.Count;
            for (int i = 0; i < jsonTeCount; i++)
            {
                subject.Remove(jsonTe[i].ToString());
            }
        }

        private void btnRefrest_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refrests();
        }

        int textCount = 0;
        private void btnall_ItemClick(object sender, ItemClickEventArgs e)
        {
            textCount = 0;
            if (MessageBox.Show("是否全部提交", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Refrests();
                var frm = new FrmTeachUserEditPosition(textjson);
                var E = frm.ShowDialog();
                if (E == DialogResult.OK)
                {
                    this.Show();
                    if (Program.FrmTeachUserEditPosition_guid != "")
                    {
                        int Count = subject.Count();
                        for (int i = 0; i < Count; i++)
                        {
                            string subjectText = subject[i];
                            if (Regex.IsMatch(subjectText, "husla&a!eiu>hu<hual/lade-i5as9angw==deshiy##gesh￥aishu7id%junzisste+$"))
                            {

                                textCount++;
                            }
                        }

                        textCount++;

                        for (int d = 0; d < textCount; d++)
                        {
                            if (d != 0)
                            {
                                var year_guid = Program.FrmTeachUserEditPosition_guid;

                                var str_subject_text = this.extOptions.ExtOptions1.Text;//大题的string类型
                                var byte_subject_text = SqlHelper.RtxToBytes(this.extOptions.ExtOptions1.RtfText.ToString());//大题的byte[]类型

                                Initial();
                                if (str_subject_text != null)
                                {
                                    var dt_ExamInfo = ClassMethod.lemonSelectExamInfoGUID(year_guid);//判断年份是否存在
                                    if (dt_ExamInfo != null && dt_ExamInfo.Rows.Count > 0)
                                    {
                                        var ExamInfoguid = dt_ExamInfo.Rows[0]["guid"];//获取属性的guid
                                        var a = "1";//大题数量
                                        string ExamInfoGuid = Guid.NewGuid().ToString();//大题guid

                                        $@"insert into ExamSubjectInfo (subject_content,subject_content2,exam_guid,subject_no,guid) values (@subject_content,@subject_content2,@exam_guid,@subject_no,@guid)".ENQ(("@guid", ExamInfoGuid, typeof(string).FullName), ("@subject_no", a, typeof(string).FullName), ("@subject_content", str_subject_text, typeof(string).FullName), ("@subject_content2", byte_subject_text, typeof(byte[]).FullName), ("@exam_guid", ExamInfoguid, typeof(string).FullName));
                                        var FlowLayoutCount = this.FlowLayout.Controls.Count;//控件数量
                                        for (int i = 0; i < FlowLayoutCount; i++)
                                        {
                                            var dt_ExamSubjectInfo = $@"select * from ExamSubjectInfo where exam_guid=@exam_guid".EQ(("@exam_guid", year_guid));//判断大题是否存在
                                            if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
                                            {
                                                string SubjectChildInfoGuid = Guid.NewGuid().ToString();//小题guid

                                                if (txttype.Text == "单选题")
                                                {
                                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 0, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", ExamInfoGuid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));
                                                    ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];
                                                    dynamic json = JsonConvert.DeserializeObject(ExtSinglOptionLists.eddText());
                                                    var strText = json.strText;
                                                    var count = json.Eng.Count;
                                                    var Eng = json.Eng;
                                                    var btyText = json.btyText;
                                                    var Enabled = json.Enabled;
                                                    string addTexts = json.addText;
                                                    for (int b = 0; b < count; b++)
                                                    {
                                                        string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                        $@"insert into SubjectChildOptionInfo(guid,subject_child_guid,option_no,option_content,option_content2,answer)values(@guid,@subject_child_guid,@option_no,@option_content,@option_content2,@answer)".ENQ(("@guid", SubjectChildOptionInfoGuid, typeof(string).FullName), ("@subject_child_guid", SubjectChildInfoGuid, typeof(string).FullName), ("@option_no", Eng[b], typeof(string).FullName), ("@option_content", strText[b], typeof(string).FullName), ("@option_content2", btyText[b], typeof(byte[]).FullName), ("@answer", Enabled[b], typeof(string).FullName));
                                                    }
                                                    var addText = SqlHelper.RtxToBytes(addTexts);
                                                    $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName));
                                                }
                                                if (txttype.Text == "多选题")
                                                {
                                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 1, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", ExamInfoGuid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));
                                                    ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];
                                                    dynamic json = JsonConvert.DeserializeObject(ExtMulitOptionLists.eddText());
                                                    var EngOne = json.EngOne;
                                                    var count = json.EngOne.Count;
                                                    var bytText = json.bytText;
                                                    var EnabledOne = json.EnabledOne;
                                                    var strTexts = json.strTexts;
                                                    string addTexts = json.addText;
                                                    var addText = SqlHelper.RtxToBytes(addTexts);

                                                    for (int b = 0; b < count; b++)
                                                    {
                                                        string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                        $@"insert into SubjectChildOptionInfo(guid,subject_child_guid,option_no,option_content,option_content2,answer)values(@guid,@subject_child_guid,@option_no,@option_content,@option_content2,@answer)".ENQ(("@guid", SubjectChildOptionInfoGuid, typeof(string).FullName), ("@subject_child_guid", SubjectChildInfoGuid, typeof(string).FullName), ("@option_no", EngOne[b], typeof(string).FullName), ("@option_content", strTexts[b], typeof(string).FullName), ("@option_content2", bytText[b], typeof(byte[]).FullName), ("@answer", EnabledOne[b], typeof(string).FullName));
                                                    }
                                                    $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName));
                                                }
                                                if (txttype.Text == "判断题")
                                                {
                                                    ExtJudge ExtJudge = (ExtJudge)this.FlowLayout.Controls[i];
                                                    dynamic json = JsonConvert.DeserializeObject(ExtJudge.eddText());
                                                    var YesorNo = json.YesorNo;
                                                    string addTexts = json.addText;
                                                    var addText = SqlHelper.RtxToBytes(addTexts);
                                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type,subject_child_answer)values(@guid,@subject_guid,@subject_child_no,@subject_child_type,@subject_child_answer)".ENQ(("@subject_child_answer", YesorNo, typeof(string).FullName), ("@subject_child_type", 2, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", ExamInfoGuid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));

                                                    $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName));
                                                }
                                                if (txttype.Text == "问答题")
                                                {
                                                    ExtAnswer ExtAnswer = (ExtAnswer)this.FlowLayout.Controls[i];
                                                    dynamic json = JsonConvert.DeserializeObject(ExtAnswer.eddText());
                                                    string EditTexts = json.EditTexts;//答案
                                                    string addTexts = json.addText;//解析

                                                    var addText = SqlHelper.RtxToBytes(addTexts);//解析
                                                    var EditText = SqlHelper.RtxToBytes(EditTexts);//答案

                                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type,subject_child_answer2)values(@guid,@subject_guid,@subject_child_no,@subject_child_type,@subject_child_answer)".ENQ(("@subject_child_answer", EditText, typeof(byte[]).FullName), ("@subject_child_type", 3, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", ExamInfoGuid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));

                                                    $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName));
                                                }
                                            }
                                        }
                                    }
                                }
                            
                            }
                            Delete();
                            Refrests();
                        }
                        MessageBox.Show("提交完成");
                        ClearMemory();
                        this.Close();
                        //全部提交
                    }
                    else
                    {
                        this.Show();
                        //不操作
                    }
                }
            }
        }

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
    }
}
