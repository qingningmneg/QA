using DevExpress.XtraEditors;

using Kuade.WinControls;
using Kuade.WinControls.ExtOption;

using Newtonsoft.Json;

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

using WinClient;

namespace QA.winfrom
{
    public partial class FrmTeacherUserNewQuestions : XtraForm
    {
        #region 全局变量
        public int yearcount;
        public string yearguid;
        #endregion

        public FrmTeacherUserNewQuestions()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmTeacherUserNewQuestions(string year_guid) : this()
        {
            this.year_guid = year_guid;
        }

        private void FrmTeacherUserNewQuestions_Load(object sender, EventArgs e)
        {
            #region 初始化年份 题目类型
            this.txtTypeRefrest();//刷新题目类型
            txttopics.Properties.IsFloatValue = false;
            txttopics.Properties.Increment = 1;
            txttopics.Properties.MinValue = 1;
            txttopics.Properties.MaxValue = 24;
            txttopics.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txttopics.Properties.Mask.EditMask = @"\d{1,2}?";
            #endregion

            this.ClearMemory();
        }

        /// <summary>
        /// 年份guid
        /// </summary>
        private string year_guid;

        private void txttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataFlowLayout();
        }

        private void txttopics_TextChanged(object sender, EventArgs e)
        {
            this.dataFlowLayout();
        }



        private void btnCenCel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("数据将不会保存哦!", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var a = txttype.Text;
                this.txtsubject("");
                this.txttype.Text = "";
                this.txttype.Text = a;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var str_subject_text = this.extOptions1.ExtOptions1.Text;//大题的string类型
            var byte_subject_text = SqlHelper.RtxToBytes(this.extOptions1.ExtOptions1.RtfText.ToString());//大题的byte[]类型

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
                        var dt_ExamSubjectInfo = ClassMethod.lemonSelectExamSubjectInfoExam_guid(year_guid);//判断大题是否存在
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
            MessageBox.Show("添加成功");
            ClearMemory();
            this.Close();
        }


        private void txttype_EditValueChanged(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            this.Count = 0;
            this.txttopics.Value = 1;
            this.dataFlowLayout();
        }

        private void FrmTeacherUserNewQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Clear();
            ClearMemory();

            this.Close();
        }






        #region  方法
        /// <summary>
        /// 添加控件
        /// </summary>
        int Count = 0;

        /// <summary>
        /// 添加控件
        /// </summary>
        public void dataFlowLayout()
        {
            var txttopics_Count = Convert.ToInt32(this.txttopics.Value);
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
                        ExtSinglOptionList.AddOption(4);
                        ExtSinglOptionList.labText(txttopics_Count);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionList = new ExtMulitOptionList();
                        FlowLayout.Controls.Add(ExtMulitOptionList);
                        ExtMulitOptionList.AddOption(4);
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

        /// <summary>
        /// 初始化题目类型方法
        /// </summary>
        void txtTypeRefrest()
        {
            txttype.Properties.Items.Add("多选题");
            txttype.Properties.Items.Add("单选题");
            txttype.Properties.Items.Add("判断题");
            txttype.Properties.Items.Add("问答题");
            txttype.SelectedIndex = 0;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void data()
        {
            this.txttopics.Value = 1;
            var txttopics_Count = Convert.ToInt32(this.txttopics.Value);
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
                }
            }
            if (txttopics_Count < Count)
            {
                for (int i = Count; i > txttopics_Count; i--)
                {
                    if (txttype.Text == "单选题")
                    {
                        ExtSinglOptionList ExtSinglOptionList = new ExtSinglOptionList();
                        FlowLayout.Controls.RemoveAt(i);
                    }
                    if (txttype.Text == "多选题")
                    {
                        ExtMulitOptionList ExtMulitOptionList = new ExtMulitOptionList();
                        FlowLayout.Controls.RemoveAt(i);
                    }
                }
            }
            this.Count = txttopics_Count;
        }

        /// <summary>
        /// 清空控件
        /// </summary>
        /// <param name="a"></param>
        public void txtsubject(string a = "")
        {
            if (a == "")
            {
                this.extOptions1.ExtOptions1.Text = a;
            }
        }
        #endregion
    }
}
