using DevExpress.Printing.Core.PdfExport.Metafile;
using DevExpress.XtraEditors;
using Kuade.WinControls.ExtOption;
using Kuade.WinControls;
using Kuade.WinControls.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;
using QA.file;

namespace QA
{
    public partial class FrmStudentExamination : XtraForm
    {
        /// <summary>
        /// 本窗体的guid
        /// </summary>
        string answer_guid;

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        public FrmStudentExamination()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
        }

        public FrmStudentExamination(string guid, string texts, string pattern) : this()
        {
            this.guid = guid;
            this.texts = texts;
            this.pattern = pattern;
            if (texts != null)
            {
                lblUserText.Text = texts;
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStudentExamination_Load(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            Randomload();
            #region 随机大题
            RandomNextQuestions();
            if (intCount == 1)
            {
                btnLast.Enabled = false;
            }
            this.studentExtOptions.Height = 36;
            studentExtOptions.ExtOptions.VerticalScrollValue = 9000000000000000000;
            var adetss = studentExtOptions.ExtOptions.VerticalScrollValue;
            studentExtOptions.Height += (int)adetss;
            studentExtOptions.ExtOptions.Text = "";
            RandomNextQuestions();
            RandomNextQuestion();
            #endregion

            lblCount.Text = intCount.ToString() + "/" + AllanswerCount.ToString();
            studentExtOptions.Enabled = false;
        }

        /// <summary>
        /// 上一题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            FlowLayout.Controls.Clear();
            #region 上一题
            this.RandomLastQuestion();
            this.RandomLastQuestions();
            #endregion
            #region 加载答案
            #endregion
            if (intCount == 1)
            {
                btnLast.Enabled = false;
            }
            DataTabe();
        }

        /// <summary>
        /// 第几题
        /// </summary>
        int intCount = 0;


        bool ade = true;

        int StudentExtSinglOptionListCount;
        /// <summary>
        /// 下一题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlower_Click(object sender, EventArgs e)
        {
            StudentExtSinglOptionListCount = 0;
            if (lblload.Text == "单选题" || lblload.Text == "多选题")
            {
                var Count = this.FlowLayout.Controls.Count;
                for (int i = 0; i < Count; i++)
                {
                    StudentExtSinglOptionList StudentExtSinglOptionList = (StudentExtSinglOptionList)this.FlowLayout.Controls[i];
                    this.StudentExtSinglOptionListCount += StudentExtSinglOptionList.answer;
                }
                if (this.answerCount != StudentExtSinglOptionListCount)
                {
                    if (btnWrongquestionbank.Checked == false)
                    {
                        if (MessageBox.Show("答案是错误的,是否计入错题目", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                        }
                    }
                }
            }


            btnLast.Enabled = true;
            #region 随机大题
            RandomNextQuestions();
            RandomNextQuestion();
            lblCount.Text = intCount.ToString() + "/" + AllanswerCount.ToString();
            #endregion

        }

        /// <summary>
        /// 随机后的大题表
        /// </summary>
        DataTable data = new DataTable();
        string texts;
        public string guid;
        public string pattern;

        #region 方法
        /// <summary>
        /// 随机考题上一题(无)
        /// </summary>
        public void RandomLastQuestions()
        {
            if (intCount > 0)
            {
                //var a = intCount ;
                if (intCount > 0)
                {
                    var b = intCount - 1;
                    #region 加载数据
                    var subject_content2 = data.Rows[b]["subject_content2"];
                    studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题

                    this.answer_guid = Convert.ToString(data.Rows[b]["guid"]);
                    #endregion
                    FlowLayout.Controls.Clear();
                }

                lblCount.Text = intCount.ToString() + "/" + AllanswerCount.ToString();
            }
        }

        /// <summary>
        /// 随机考题上一题(减)
        /// </summary>
        public void RandomLastQuestion()
        {
            if (intCount > 0)
            {
                var a = intCount - 1;
                if (a > 0)
                {
                    intCount--;
                    var b = intCount - 1;
                    #region 加载数据
                    var subject_content2 = data.Rows[b]["subject_content2"];
                    studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题
                    #endregion
                    this.studentExtOptions.Height = 36;
                    studentExtOptions.ExtOptions.VerticalScrollValue = 9000000000000000000;
                    var adetss = studentExtOptions.ExtOptions.VerticalScrollValue;
                    studentExtOptions.Height += (int)adetss;
                    studentExtOptions.ExtOptions.Text = "";
                }


                lblCount.Text = intCount.ToString() + "/" + AllanswerCount.ToString();
            }
        }

        int AllanswerCount;
        /// <summary>
        /// (随机)加载考题
        /// </summary>
        DataTable dataTable = new DataTable();
        public void Randomload()
        {
            data.Columns.Add("ruid");
            data.Columns.Add("guid");
            data.Columns.Add("exam_guid");
            data.Columns.Add("subject_no");
            data.Columns.Add("subject_content");
            data.Columns.Add("subject_content2");
            if (pattern == "随机考题")
            {
                var dt = ClassMethod.lemonSelelctExamInfoGUID(guid);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataTable = dt;
                }
                else
                {
                    MessageBox.Show("该科目没有考题");
                    this.Close();
                }
            }
            if (pattern == "选择考题")
            {
                var dt = ClassMethod.lemonSelectExamSubjectInfoGUID(guid);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataTable = dt;
                }
                else
                {
                    MessageBox.Show("该科目没有考题");
                    this.Close();
                }
            }
            this.AllanswerCount = dataTable.Rows.Count;
        }

        /// <summary>
        /// 随机考题下一题(加)
        /// </summary>
        public void RandomNextQuestion()
        {
            if (data.Rows.Count - intCount > 0)
            {
                this.studentExtOptions.Height = 36;
                studentExtOptions.ExtOptions.VerticalScrollValue = 9000000000000000000;
                var adetss = studentExtOptions.ExtOptions.VerticalScrollValue;
                studentExtOptions.Height += (int)adetss;
                studentExtOptions.ExtOptions.Text = "";

                #region 加载数据
                var subject_content2 = data.Rows[intCount]["subject_content2"];
                studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题

                this.answer_guid = Convert.ToString(data.Rows[intCount]["guid"]);
                #endregion

                intCount++;
                if (ade != false)
                {
                    this.DataTabe();
                }
            }
            else
            {
                var Count = dataTable.Rows.Count;

                Random Random = new Random();

                var count = Random.Next(Count);
                var dataTableCount = dataTable.Rows.Count;
                if (dataTableCount > 0)
                {
                    this.studentExtOptions.Height = 36;
                    studentExtOptions.ExtOptions.VerticalScrollValue = 9000000000000000000;
                    var adetss = studentExtOptions.ExtOptions.VerticalScrollValue;
                    studentExtOptions.Height += (int)adetss;
                    studentExtOptions.ExtOptions.Text = "";

                    #region 加载数据
                    var biao = dataTable.Rows[count];
                    var subject_content2 = dataTable.Rows[count]["subject_content2"];
                    studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题
                    data.Rows.Add(biao.ItemArray);
                    dataTable.Rows.Remove(dataTable.Rows[count]);

                    this.answer_guid = Convert.ToString(data.Rows[intCount]["guid"]);
                    #endregion

                    intCount++;
                    if (ade != false)
                    {
                        this.DataTabe();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 随机考题下一题(无)
        /// </summary>
        public void RandomNextQuestions()
        {
            if (data.Rows.Count - intCount > 0)
            {
                var subject_content2 = data.Rows[intCount]["subject_content2"];
                studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题
                FlowLayout.Controls.Clear();
            }
            else
            {
                var Count = dataTable.Rows.Count;

                Random Random = new Random();

                var count = Random.Next(Count);
                var dataTableCount = dataTable.Rows.Count;
                if (dataTableCount > 0)
                {
                    var biao = dataTable.Rows[count];
                    var subject_content2 = dataTable.Rows[count]["subject_content2"];
                    studentExtOptions.ExtOptions.RtfText = SqlHelper.RtxBytesToString(Convert.FromBase64String(subject_content2.ToString()));//显示大题

                    data.Rows.Add(biao.ItemArray);
                    dataTable.Rows.Remove(dataTable.Rows[count]);
                    FlowLayout.Controls.Clear();
                }
                else
                {
                    if (MessageBox.Show("考题已经全部做完是否确认退出", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        ade = false;
                    }
                    if (ade == false)
                    {
                        FlowLayout.Controls.Clear();
                        return;
                    }
                }
            }

        }
        #endregion


        /// <summary>
        /// 正确答案数量
        /// </summary>
        int answerCount = 0;

        /// <summary>
        /// 添加答案
        /// </summary>
        public void DataTabe()
        {
            answerCount = 0;
            btnlower.Enabled = false;
            btnLast.Enabled = false;
            this.lblload.Hide();
            var dt_SubjectChildInfo = ClassMethod.lemonSelelctSubjectChildInfoOrderBy(answer_guid);//小题数量
            if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
            {
                var count_SubjectChildInfo = dt_SubjectChildInfo.Rows.Count;//答案总个数

                for (int i = 0; i < count_SubjectChildInfo; i++)
                {
                    var guid_SubjectChildInfo = dt_SubjectChildInfo.Rows[i]["guid"];
                    //this.txttopicsbool = true;
                    //小题数量
                    var subject_child_type = Convert.ToInt32(dt_SubjectChildInfo.Rows[0]["subject_child_type"]);//题目类型

                    if (subject_child_type == 0)//判断是单选还是多选
                    {

                        lblload.Text = "单选题";
                        StudentExtSinglOptionList StudentExtSinglOptionLists = new StudentExtSinglOptionList();
                        FlowLayout.Controls.Add(StudentExtSinglOptionLists);
                        StudentExtSinglOptionLists.strSubject("单选题");
                        StudentExtSinglOptionLists.heig();
                    }
                    if (subject_child_type == 1)//判断是单选还是多选
                    {
                        lblload.Text = "多选题";
                        StudentExtSinglOptionList StudentExtSinglOptionLists = new StudentExtSinglOptionList();
                        FlowLayout.Controls.Add(StudentExtSinglOptionLists);
                        StudentExtSinglOptionLists.strSubject("多选题");
                        StudentExtSinglOptionLists.heig();
                    }

                    if (subject_child_type == 2)
                    {
                        lblload.Text = "判断题";
                        StudentExtJudge StudentExtJudge = new StudentExtJudge();
                        FlowLayout.Controls.Add(StudentExtJudge);
                    }
                    if (subject_child_type == 3)
                    {
                        lblload.Text = "问答题";
                        StudentExtAnswer StudentExtAnswer = new StudentExtAnswer();
                        FlowLayout.Controls.Add(StudentExtAnswer);
                    }

                    if (subject_child_type == 2)//判断
                    {
                        var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];
                        var subject_child_answer = dt_SubjectChildInfo.Rows[i]["subject_child_answer"];

                        StudentExtJudge ExtJudge = (StudentExtJudge)this.FlowLayout.Controls[i];
                        //ExtJudge.extAnalysis1.ExtTexts(Convert.FromBase64String(subject_child_analysis2.ToString()));

                        ExtJudge.aedd(subject_child_answer.ToString());
                    }
                    if (subject_child_type == 3)//问答
                    {

                        var subject_child_answer2 = dt_SubjectChildInfo.Rows[i]["subject_child_answer2"];//答案
                        var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];//解析
                        StudentExtAnswer ExtAnswer = (StudentExtAnswer)this.FlowLayout.Controls[i];

                        ExtAnswer.ExtOptions1.RtfText = SqlHelper.RtxBytesToString((Convert.FromBase64String(subject_child_answer2.ToString())));
                    }

                    var dt_SubjectChildOptionInfo = ClassMethod. lemonSelelctSubjectChildOptionInfoOrderBy( guid_SubjectChildInfo.ToString());//答案
                    if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                    {
                        var count_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows.Count;

                        for (int b = 0; b < count_SubjectChildOptionInfo; b++)
                        {
                            //答案
                            if (subject_child_type == 0 || subject_child_type == 1)
                            {

                                StudentExtSinglOptionList StudentExtSinglOptionLists = (StudentExtSinglOptionList)this.FlowLayout.Controls[i];

                                var subject_child_analysis2 = dt_SubjectChildInfo.Rows[i]["subject_child_analysis2"];

                                var byte_SubjectChildOptionInfo = dt_SubjectChildOptionInfo.Rows[b]["option_content2"];//答案内容
                                var SubjectChildOptionInfoByte = Convert.FromBase64String(byte_SubjectChildOptionInfo.ToString());//答案内容byte[]
                                var answer = Convert.ToString(dt_SubjectChildOptionInfo.Rows[b]["answer"]);//是否答案


                                StudentExtSinglOptionLists.AddOption();

                                var StudentExtOptions = StudentExtSinglOptionLists.flowText.Controls[b] as StudentExtOptions;
                                StudentExtOptions.ExtText(SubjectChildOptionInfoByte);
                                if (answer == "True")
                                {
                                    var CheckBox = StudentExtSinglOptionLists.flowOption.Controls[b] as CheckBox;
                                    CheckBox.Tag = true;
                                    answerCount += 1;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("大题不存在");
            }
            btnlower.Enabled = true;

            if (intCount == 1)
            {
                btnLast.Enabled = false;
                return;
            }
            btnLast.Enabled = true;
        }
    }
}
