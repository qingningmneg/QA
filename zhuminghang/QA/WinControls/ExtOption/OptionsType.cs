using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuade.WinControls.ExtOption
{
    /// <summary>
    /// 题目类型
    /// </summary>
    public enum OptionsType
    {
        /// <summary>
        /// 单选 SingleChoice
        /// </summary>
        单选题=0,

        /// <summary>
        /// 多选 MultipleChoice
        /// </summary>
        多选题=1,

        /// <summary>
        /// 判断 Judge
        /// </summary>
        判断题 = 2,

        /// <summary>
        /// 填空 Completion
        /// </summary>
        填空题 = 3,

        /// <summary>
        /// 问答 QuestionsAndAnswers
        /// </summary>
        问答题 =4,
    }
}
