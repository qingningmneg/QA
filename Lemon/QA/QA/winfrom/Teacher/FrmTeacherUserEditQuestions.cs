using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.SpellChecker;
using Kuade.WinControls;
using Kuade.WinControls.ExtOption;
using Newtonsoft.Json;
using QA.file;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace QA.winfrom
{
    public partial class FrmTeacherUserEditQuestions : XtraForm
    {
        bool txttopicsbool = false;

        /// <summary>
        /// 大题guid
        /// </summary>
        private string examInfo_guid;

        public FrmTeacherUserEditQuestions()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmTeacherUserEditQuestions(string examInfo_guid) : this()
        {
            this.examInfo_guid = examInfo_guid;
        }

        public FrmTeacherUserEditQuestions(string examInfo_guid, string txttype, string txtyear) : this(examInfo_guid)
        {
            this.txttype1 = txttype;
            this.txtyear = txtyear;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var guid_SubjectChildOptionInfoss = "";
                var dt_ExamSubjectInfo = ClassMethod.lemonSelectExamSubjectInfoGUID(examInfo_guid);//大题
                if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
                {
                    // 大题编辑
                    var subject = SqlHelper.RtxToBytes(this.extOptions.ExtOptions1.RtfText);
                    var strsubject = this.extOptions.ExtOptions1.Text.ToString();
                    $@"update ExamSubjectInfo set subject_content2 = @subject_content2,subject_content = @subject_content where guid = @guid".ENQ(("@guid", examInfo_guid, typeof(string).FullName), ("@subject_content2", subject, typeof(byte[]).FullName), ("@subject_content", strsubject, typeof(string).FullName));

                    var guid_ExamSubjectInfo = dt_ExamSubjectInfo.Rows[0]["guid"];
                    // 删除或添加小题
                    var dt_SubjectChildInfo = $@"select * from SubjectChildInfo where subject_guid = @subject_guid Order By ruid desc".EQ(("@subject_guid", guid_ExamSubjectInfo));//小题数量
                    if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                    {
                        var FlowLayoutCount = this.FlowLayout.Controls.Count;//控件数量
                        var count_SubjectChildInfo = dt_SubjectChildInfo.Rows.Count;//数据库小题数量
                        if (count_SubjectChildInfo > FlowLayoutCount)
                        {
                            //减少
                            var count = count_SubjectChildInfo - FlowLayoutCount;
                            for (int i = 0; i < count; i++)
                            {
                                //删除答案
                                var guid_SubjectChildInfos = dt_SubjectChildInfo.Rows[i]["guid"];
                                $@"delete from SubjectChildOptionInfo where subject_child_guid = @subject_child_guid".ENQ(("@subject_child_guid", guid_SubjectChildInfos));
                                $@"delete from SubjectChildInfo where guid = @guid".ENQ(("@guid", guid_SubjectChildInfos));
                            }
                        }
                        else
                        {
                            //添加
                            var count = FlowLayoutCount - count_SubjectChildInfo;
                            for (int i = 0; i < count; i++)
                            {
                                string SubjectChildInfoGuid = Guid.NewGuid().ToString();//小题guid
                                string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid

                                if (txttype.Text == "单选题")
                                {
                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 0, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", examInfo_guid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));//0单选
                                    $"insert into SubjectChildOptionInfo(subject_child_guid,guid)values(@subject_child_guid,@guid)".ENQ(("@subject_child_guid", SubjectChildInfoGuid), ("@guid", SubjectChildOptionInfoGuid));
                                    guid_SubjectChildOptionInfoss = SubjectChildOptionInfoGuid;
                                }
                                if (txttype.Text == "多选题")
                                {
                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 1, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", examInfo_guid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));//1多选
                                    $"insert into SubjectChildOptionInfo(subject_child_guid,guid)values(@subject_child_guid,@guid)".ENQ(("@subject_child_guid", SubjectChildInfoGuid), ("@guid", SubjectChildOptionInfoGuid));
                                    guid_SubjectChildOptionInfoss = SubjectChildOptionInfoGuid;
                                }
                                if (txttype.Text == "判断题")
                                {
                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 2, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", examInfo_guid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));//1多选

                                }
                                if (txttype.Text == "问答题")
                                {
                                    $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)".ENQ(("@subject_child_type", 3, typeof(int).FullName), ("@guid", SubjectChildInfoGuid, typeof(string).FullName), ("@subject_guid", examInfo_guid, typeof(string).FullName), ("@subject_child_no", i, typeof(int).FullName));//1多选
                                }
                            }
                        }
                    }

                    // 删除或添加答案
                    {
                        var dt_SubjectChildInfos = $@"select * from SubjectChildInfo where subject_guid = @subject_guid Order By ruid asc".EQ(("@subject_guid", guid_ExamSubjectInfo));//小题数量
                        if (dt_SubjectChildInfos != null && dt_SubjectChildInfos.Rows.Count > 0)
                        {
                            var count_SubjectChildInfos = dt_SubjectChildInfos.Rows.Count;//数据库小题数量
                            var FlowLayoutCount = this.FlowLayout.Controls.Count;//控件数量

                            if (count_SubjectChildInfos == FlowLayoutCount)
                            {
                                for (int i = 0; i < count_SubjectChildInfos; i++)
                                {
                                    var guid_SubjectChildInfos = dt_SubjectChildInfos.Rows[i]["guid"];
                                    var dt_SubjectChildOptionInfo = $@"select * from SubjectChildOptionInfo where subject_child_guid = @subject_child_guid Order By ruid desc".EQ(("@subject_child_guid", guid_SubjectChildInfos));//答案数量
                                    if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                                    {
                                        var count_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows.Count;//答案数量
                                        if (txttype.Text == "单选题")//判断是单选还是多选
                                        {
                                            ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];
                                            dynamic json = JsonConvert.DeserializeObject(ExtSinglOptionLists.eddText());
                                            var count = json.Eng.Count;
                                            if (count != count_SubjectChildOptionInfo)
                                            {
                                                if (count > count_SubjectChildOptionInfo)
                                                {
                                                    var min = count - count_SubjectChildOptionInfo;

                                                    for (int d = 0; d < min; d++)
                                                    {
                                                        string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                        var guid_SubjectChildInfoss = dt_SubjectChildInfos.Rows[i]["guid"];
                                                        $"insert into SubjectChildOptionInfo(subject_child_guid,guid)values(@subject_child_guid,@guid)".ENQ(("@subject_child_guid", guid_SubjectChildInfoss), ("@guid", SubjectChildOptionInfoGuid));
                                                    }
                                                    //添加
                                                }
                                                else
                                                {
                                                    var max = count_SubjectChildOptionInfo - count;
                                                    for (int d = 0; d < max; d++)
                                                    {
                                                        var guid = dt_SubjectChildOptionInfo.Rows[d]["guid"];
                                                        $@"delete from SubjectChildOptionInfo where guid=@guid".ENQ(("@guid", guid));
                                                    }
                                                    //删除
                                                }
                                            }
                                        }
                                        if (txttype.Text == "多选题")//判断是单选还是多选
                                        {

                                            ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];
                                            dynamic json = JsonConvert.DeserializeObject(ExtMulitOptionLists.eddText());
                                            var count = json.EngOne.Count;
                                            if (count != count_SubjectChildOptionInfo)
                                            {
                                                if (count > count_SubjectChildOptionInfo)
                                                {
                                                    var min = count - count_SubjectChildOptionInfo;
                                                    for (int d = 0; d < min; d++)
                                                    {
                                                        string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                        var guid_SubjectChildInfoss = dt_SubjectChildInfos.Rows[i]["guid"];
                                                        $"insert into SubjectChildOptionInfo(subject_child_guid,guid)values(@subject_child_guid,@guid)".ENQ(("@subject_child_guid", guid_SubjectChildInfoss), ("@guid", SubjectChildOptionInfoGuid));
                                                    }
                                                    //添加
                                                }
                                                else
                                                {
                                                    var max = count_SubjectChildOptionInfo - count;
                                                    for (int d = 0; d < max; d++)
                                                    {
                                                        var guid = dt_SubjectChildOptionInfo.Rows[d]["guid"];
                                                        $@"delete from SubjectChildOptionInfo where guid=@guid".ENQ(("@guid", guid));
                                                    }
                                                    //删除
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("数据更改错误");
                                return;
                            }
                        }
                    }

                    // 编辑答案
                    var dt_SubjectChildInfoss = $@"select * from SubjectChildInfo where subject_guid = @subject_guid Order By ruid asc".EQ(("@subject_guid", guid_ExamSubjectInfo));//小题数量
                    if (dt_SubjectChildInfoss != null && dt_SubjectChildInfoss.Rows.Count > 0)
                    {
                        var count_SubjectChildInfos = dt_SubjectChildInfoss.Rows.Count;//数据库小题数量
                        var FlowLayoutCount = this.FlowLayout.Controls.Count;//控件数量

                        if (count_SubjectChildInfos == FlowLayoutCount)
                        {
                            for (int i = 0; i < FlowLayoutCount; i++)//循环控件数量
                            {
                                {
                                    //查询出答案表 5-feeb-4033-a3c0-6da1b6978850 2d274b0c-db28-41c2-981f-4d9db1522921
                                    var guid_SubjectChildInfos = dt_SubjectChildInfoss.Rows[i]["guid"];


                                    if (txttype.Text == "判断题")
                                    {
                                        ExtJudge ExtJudge = (ExtJudge)this.FlowLayout.Controls[i];
                                        dynamic json = JsonConvert.DeserializeObject(ExtJudge.eddText());
                                        var YesorNo = json.YesorNo;
                                        string addTexts = json.addText;
                                        var addText = SqlHelper.RtxToBytes(addTexts);

                                        $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));//解析
                                        $@"update SubjectChildInfo set subject_child_answer=@subject_child_answer where guid = @guid".ENQ(("@subject_child_answer", YesorNo, typeof(string).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));//答案
                                    }
                                    if (txttype.Text == "问答题")
                                    {
                                        Kuade.WinControls.ExtAnswer ExtAnswer = (Kuade.WinControls.ExtAnswer)this.FlowLayout.Controls[i];
                                        dynamic json = JsonConvert.DeserializeObject(ExtAnswer.eddText());
                                        string EditTexts = json.EditTexts;//答案
                                        string addTexts = json.addText;//解析

                                        var addText = SqlHelper.RtxToBytes(addTexts);//解析
                                        var EditText = SqlHelper.RtxToBytes(EditTexts);//答案
                                        $@"update SubjectChildInfo set subject_child_answer2=@subject_child_answer2 where guid = @guid".ENQ(("@subject_child_answer2", EditText, typeof(byte[]).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));//解析
                                        $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));//答案
                                    }

                                    var dt_SubjectChildOptionInfo = $@"select * from SubjectChildOptionInfo where subject_child_guid = @subject_child_guid Order By ruid asc".EQ(("@subject_child_guid", guid_SubjectChildInfos));//答案数量
                                    if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                                    //for循环修改数据库
                                    {
                                        int aCount = 0;
                                        //单选 
                                        if (txttype.Text == "单选题")//判断是单选还是多选
                                        {
                                            //拿到guid

                                            ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];//获取到单选控件
                                            dynamic json = JsonConvert.DeserializeObject(ExtSinglOptionLists.eddText());
                                            var strText = json.strText;//str类型答案内容
                                            var count = json.Eng.Count;//数量
                                            aCount = count;
                                            var Eng = json.Eng;//ABCD
                                            var btyText = json.btyText;//答案byte[]内容
                                            var Enabled = json.Enabled;//是否答案
                                            string addTexts = json.addText;//解析
                                            for (int c = 0; c < count; c++)
                                            {
                                                var guid_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows[c]["guid"];//答案guid
                                                                                                                            //string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                $@"update SubjectChildOptionInfo set option_no=@option_no,option_content=@option_content,option_content2=@option_content2,answer=@answer where guid=@guid".ENQ(("@guid", guid_SubjectChildOptionInfo, typeof(string).FullName), ("@option_no", Eng[c], typeof(string).FullName), ("@option_content", strText[c], typeof(string).FullName), ("@option_content2", btyText[c], typeof(byte[]).FullName), ("@answer", Enabled[c], typeof(string).FullName));
                                            }
                                            var addText = SqlHelper.RtxToBytes(addTexts);

                                            $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));
                                        }
                                        //多选
                                        if (txttype.Text == "多选题")//判断是单选还是多选
                                        {
                                            //拿到guid

                                            ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];//获取多选控件
                                            dynamic json = JsonConvert.DeserializeObject(ExtMulitOptionLists.eddText());
                                            var EngOne = json.EngOne;//ABCD
                                            var count = json.EngOne.Count;//数量
                                            aCount = count;
                                            var bytText = json.bytText;//答案内容(不需要转换)
                                            var EnabledOne = json.EnabledOne;//是否答案
                                            var strTexts = json.strTexts;//str类型答案内容
                                            string addTexts = json.addText;//解析

                                            for (int c = 0; c < count; c++)
                                            {
                                                var guid_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows[c]["guid"];//答案guid
                                                                                                                            //string SubjectChildOptionInfoGuid = Guid.NewGuid().ToString();//答案guid SubjectChildInfoGuid
                                                $@"update SubjectChildOptionInfo set option_no=@option_no,option_content=@option_content,option_content2=@option_content2,answer=@answer where guid=@guid".ENQ(("@guid", guid_SubjectChildOptionInfo, typeof(string).FullName), ("@option_no", EngOne[c], typeof(string).FullName), ("@option_content", strTexts[c], typeof(string).FullName), ("@option_content2", bytText[c], typeof(byte[]).FullName), ("@answer", EnabledOne[c], typeof(string).FullName));
                                            }
                                            var addText = SqlHelper.RtxToBytes(addTexts);
                                            $@"update SubjectChildInfo set subject_child_analysis2=@subject_child_analysis2 where guid = @guid".ENQ(("@subject_child_analysis2", addText, typeof(byte[]).FullName), ("@guid", guid_SubjectChildInfos, typeof(string).FullName));
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("编辑错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("题目不存在");
                    }
                }
                MessageBox.Show("编辑成功");
                this.Close();
            }
            catch
            {
                MessageBox.Show("编辑失败");
            }
        }

        private void btnCenCel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认取消修改!", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();//关闭窗体
            }
        }

        private void FrmTeacherUserEditQuestions_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1404, 731);
            timer1.Start();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            #region 初始化年份 题目类型 初始化窗体内容
            this.txtTypeRefrest();//刷新题目类型
            txttopics.Properties.IsFloatValue = false;
            txttopics.Properties.Increment = 1;

            txttopics.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txttopics.Properties.Mask.EditMask = @"\d{1,2}?";
            #endregion
            this.DataTabe();
            timer.Stop();
        }

        int b = 0;
        private string txttype1;
        private string txtyear;

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

        private void FrmTeacherUserEditQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer.Stop();
            GC.Collect();
            ClearMemory();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClearMemory();
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
            var dt_ExamSubjectInfo = ClassMethod.lemonSelectExamSubjectInfoGUID(examInfo_guid);//大题
            if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
            {
                var guid_ExamSubjectInfo = dt_ExamSubjectInfo.Rows[0]["guid"];
                var dt_SubjectChildInfo = $@"select * from SubjectChildInfo where subject_guid = @subject_guid Order By ruid asc".EQ(("@subject_guid", guid_ExamSubjectInfo));//小题数量
                if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                {
                    var count_SubjectChildInfo = dt_SubjectChildInfo.Rows.Count;
                    this.b = count_SubjectChildInfo;
                    for (int i = 0; i < count_SubjectChildInfo; i++)
                    {
                        var subject_child_type = Convert.ToInt32(dt_SubjectChildInfo.Rows[0]["subject_child_type"]);//题目类型

                        if (subject_child_type == 0)//判断是单选还是多选
                        {
                            txttype.Text = "单选题";
                        }
                        if (subject_child_type == 1)//判断是单选还是多选
                        {
                            txttype.Text = "多选题";
                        }
                        if (subject_child_type == 2)
                        {
                            txttype.Text = "判断题";
                        }
                        if (subject_child_type == 3)
                        {
                            txttype.Text = "问答题";
                        }
                    }
                }
            }
        }

        #region 内存回收
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
        #endregion

        #region 添加控件 dataFlowLayouts初始时不会加载答案, dataFlowLayout初始时会加载答案
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
        /// 刷新(加载考题)
        /// </summary>
        public void DataTabe()
        {
            var dt_ExamSubjectInfo = ClassMethod.lemonSelectExamSubjectInfoGUID(examInfo_guid);//ExamSubjectInfo 题目表
            if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
            {
                var image = dt_ExamSubjectInfo.Rows[0]["subject_content2"];
                var photoByte = Convert.FromBase64String(image.ToString());
                extOptions.ExtOptions1.RtfText = SqlHelper.RtxBytesToString(photoByte);
                //ExamSubjectInfo 题目表
                var guid_ExamSubjectInfo = dt_ExamSubjectInfo.Rows[0]["guid"];
                var dt_SubjectChildInfo = $@"select * from SubjectChildInfo where subject_guid = @subject_guid Order By ruid asc".EQ(("@subject_guid", guid_ExamSubjectInfo));//小题数量
                if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                {

                    var count_SubjectChildInfo = dt_SubjectChildInfo.Rows.Count;//答案总个数

                    this.b = count_SubjectChildInfo;
                    for (int i = 0; i < count_SubjectChildInfo; i++)
                    {
                        var guid_SubjectChildInfo = dt_SubjectChildInfo.Rows[i]["guid"];
                        //this.txttopicsbool = true;
                        //小题数量
                        var subject_child_type = Convert.ToInt32(dt_SubjectChildInfo.Rows[0]["subject_child_type"]);//题目类型

                        if (subject_child_type == 0)//判断是单选还是多选
                        {
                            txttype.Text = "单选题";
                            txttopics.Value += 1;
                            ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];//单选
                            ExtSinglOptionLists.Clear();
                        }
                        if (subject_child_type == 1)//判断是单选还是多选
                        {
                            txttype.Text = "多选题";
                            txttopics.Value += 1;
                            ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];//多选
                            ExtMulitOptionLists.Clear();
                        }

                        if (subject_child_type == 2)
                        {
                            txttype.Text = "判断题";
                            txttopics.Value += 1;
                            ExtJudge ExtJudge = (ExtJudge)this.FlowLayout.Controls[i];
                        }
                        if (subject_child_type == 3)
                        {
                            txttype.Text = "问答题";
                            txttopics.Value += 1;
                            Kuade.WinControls.ExtAnswer ExtAnswer = (Kuade.WinControls.ExtAnswer)this.FlowLayout.Controls[i];
                        }

                        if (subject_child_type == 2)//判断
                        {
                            var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];
                            var subject_child_answer = dt_SubjectChildInfo.Rows[i]["subject_child_answer"];

                            ExtJudge ExtJudge = (ExtJudge)this.FlowLayout.Controls[i];
                            ExtJudge.extAnalysis1.ExtTexts(Convert.FromBase64String(subject_child_analysis2.ToString()));

                            ExtJudge.aedd(subject_child_answer.ToString());
                        }
                        if (subject_child_type == 3)//问答
                        {
                            var subject_child_answer2 = dt_SubjectChildInfo.Rows[i]["subject_child_answer2"];//答案
                            var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];//解析
                            Kuade.WinControls.ExtAnswer ExtAnswer = (Kuade.WinControls.ExtAnswer)this.FlowLayout.Controls[i];

                            ExtAnswer.extAnalysis1.ExtTextss(Convert.FromBase64String(subject_child_answer2.ToString()));
                            ExtAnswer.extAnalysis1.ExtTexts(Convert.FromBase64String(subject_child_analysis2.ToString()));
                        }

                        var dt_SubjectChildOptionInfo = $@"select * from SubjectChildOptionInfo where subject_child_guid = @subject_child_guid Order By ruid asc".EQ(("@subject_child_guid", guid_SubjectChildInfo));//答案
                        if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                        {
                            var count_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows.Count;

                            for (int b = 0; b < count_SubjectChildOptionInfo; b++)
                            {
                                //答案
                                if (subject_child_type == 0)
                                {
                                    var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];

                                    var byte_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows[b]["option_content2"];//答案内容
                                    var SubjectChildOptionInfoByte = Convert.FromBase64String(byte_SubjectChildOptionInfo.ToString());//答案内容byte[]
                                    var answer = Convert.ToString(dt_SubjectChildOptionInfo.Rows[b]["answer"]);//是否答案

                                    ExtSinglOptionList ExtSinglOptionLists = (ExtSinglOptionList)this.FlowLayout.Controls[i];//单选
                                    ExtSinglOptionLists.AddOption();

                                    var ExtOptions = ExtSinglOptionLists.flowText.Controls[b] as ExtOptions;
                                    ExtOptions.ExtText(SubjectChildOptionInfoByte);
                                    if (answer == "True")
                                    {
                                        var RadioButton = ExtSinglOptionLists.flowOption.Controls[b] as RadioButton;
                                        RadioButton.Checked = true;
                                    }
                                    ExtSinglOptionLists.extAnalysis1.ExtTexts(Convert.FromBase64String(subject_child_analysis2.ToString()));
                                }
                                if (subject_child_type == 1)
                                {
                                    var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];

                                    var byte_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows[b]["option_content2"];//答案内容
                                    var SubjectChildOptionInfoByte = Convert.FromBase64String(byte_SubjectChildOptionInfo.ToString());//答案内容byte[]
                                    var answer = Convert.ToString(dt_SubjectChildOptionInfo.Rows[b]["answer"]);//是否答案

                                    ExtMulitOptionList ExtMulitOptionLists = (ExtMulitOptionList)this.FlowLayout.Controls[i];//多选
                                    ExtMulitOptionLists.AddOption();


                                    var ExtOptions = ExtMulitOptionLists.FlowLayout.Controls[b] as ExtOption;
                                    ExtOptions.ExtText(SubjectChildOptionInfoByte);
                                    if (answer == "True")
                                    {
                                        ExtOptions.Cheek.Checked = true;
                                    }
                                    ExtMulitOptionLists.extAnalysis1.ExtTexts(Convert.FromBase64String(subject_child_analysis2.ToString()));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("大题不存在");
                return;
            }
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
                }
            }
            this.Count = txttopics_count;
        }
        #endregion

    }
}
