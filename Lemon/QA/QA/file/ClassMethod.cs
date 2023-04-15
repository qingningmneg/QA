using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using static DevExpress.XtraPrinting.Export.Pdf.PdfImageCache;

namespace QA.file
{
    internal static class ClassMethod
    {
        public static string ServerUrl = "http://127.0.0.1:18800/api/webapi";

        //客户端其他写法 $@"select * from 表名 where guid = @guid".EQ(("@guid", this.guid));//查询
        //客户端其他写法 $@"delete 表名 where guid = @guid".ENQ(("@guid", this.guid));

        //具体可传类型看SqlHelper,能传的东西很多

        /// <summary>
        /// post 测试方法
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, object> postningmengText()
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/postningmengText", JsonConvert.SerializeObject(new { user_no = "这是一个测试POST方法" }));

            Result = JsonConvert.DeserializeObject<Dictionary<string, object>>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// get 测试方法
        /// </summary>
        /// <returns></returns>
        public static void getningmengText()
        {
            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.DownloadString($@"{ServerUrl}/getningmengText");
        }

        #region 教师端

        #region 新增
        /// <summary>
        /// post 注册
        /// </summary>
        /// <param name="Params">string card_no,string user_no,string user_pwd,string user_name,byte[] photo</param>
        /// <returns></returns>
        public static bool lemonRegister(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/Register", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 新增考试类型
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertExamInfo(string guid, string exam_type_guid, string exam_time)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertExamInfo", JsonConvert.SerializeObject(new { guid = guid, exam_type_guid = exam_type_guid, exam_time = exam_time }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 新增考试题目
        /// </summary>
        /// <param name="Params">string card_no,string user_no,string user_pwd,string user_name,byte[] photo</param>
        /// <returns></returns>
        public static bool lemonInsertExamSubjectInfo(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertExamSubjectInfo", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 新增小题
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertChooseSubjectChildInfo(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertChooseSubjectChildInfo", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 新增子题目选项
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertSubjectChildOptionInfo(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertSubjectChildOptionInfo", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 新增小题(判断)
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertJudgeSubjectChildInfo(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertJudgeSubjectChildInfo", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 新增小题(问答)
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertQAASubjectChildInfo(params (string, object, string)[] Params)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertQAASubjectChildInfo", JsonConvert.SerializeObject(new { Params = Params }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 新增考试科目
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static bool lemonInsertExamTypeInfo(string guid, string exam_type)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/InsertExamTypeInfo", JsonConvert.SerializeObject(new { guid = guid, exam_type = exam_type }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除年份
        /// </summary>
        /// <param name="year_guid">年份的guid</param>
        /// <returns></returns>
        public static bool lemonDeleteExamInfo(string year_guid)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/DeleteExamInfo", JsonConvert.SerializeObject(new { year_guid = year_guid }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="exam_type"></param>
        /// <returns></returns>
        public static bool lemonDeleteExamTypeInfo(string exam_type)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/DeleteExamTypeInfo", JsonConvert.SerializeObject(new { exam_type = exam_type }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }
        #endregion

        #region 编辑
        /// <summary>
        /// 修改考试类型使用guid修改开始时间和结束时间
        /// </summary>
        /// <param name="startTimeandEndTime"></param>
        /// <param name="year_guid"></param>
        /// <returns></returns>
        public static bool lemonUpdateExamInfo(string startTimeandEndTime, string year_guid)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/updateExamInfo", JsonConvert.SerializeObject(new { startTimeandEndTime = startTimeandEndTime, year_guid = year_guid }));

            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);
            return Result;
        }

        public static bool lemonUpdateSubjectChildInfo(byte[] subject_child_analysis2, string guid)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/updateSubjectChildInfo", JsonConvert.SerializeObject(new { subject_child_analysis2 = subject_child_analysis2, guid = guid }));

            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);
            return Result;
        }

        public static bool lemonUpdateExamTypeInfo(string exam_type, string guid)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/updateExamTypeInfo", JsonConvert.SerializeObject(new { exam_type = exam_type, guid = guid }));

            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);
            return Result;
        }

        #endregion

        #region 查询
        /// <summary>
        /// post 登录
        /// </summary>
        /// <param name="user_no">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <returns></returns>
        public static DataTable lemonSelectLogin(string user_no, string user_pwd)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selelctLogin", JsonConvert.SerializeObject(new { user_no = user_no, user_pwd = user_pwd }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        /// <summary>
        /// post 判断卡号是否存在
        /// </summary>
        /// <param name="card_no">卡号</param>
        public static bool lemonSelectCardNo(string card_no)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selectCardNo", JsonConvert.SerializeObject(new { card_no = card_no }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 判断用户名是否存在
        /// </summary>
        /// <param name="card_no">卡号</param>
        public static bool lemonSelectUserNo(string user_no)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selectUserNo", JsonConvert.SerializeObject(new { user_no = user_no }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// get 获取所有年份
        /// </summary>
        /// <returns></returns>
        public static DataTable lemonSelectExamTypeInfo()
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.DownloadString($@"{ServerUrl}/selectExamTypeInfo");

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 查询指定的考试类型
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static DataTable lemonSelectExamTypeInfoExamType(string exam_type)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selectExamTypeInfoExamType", JsonConvert.SerializeObject(new { exam_type = exam_type }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 查询指定的历年考试信息
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static DataTable lemonSelectExamInfoExamTypeInfoGUID(string exam_type_guid)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selectExamInfoExamTypeInfoGUID", JsonConvert.SerializeObject(new { exam_type_guid = exam_type_guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 根据考试时间和考试类型查询历年考试信息表
        /// </summary>
        /// <param name="exam_time"></param>
        /// <param name="exam_type_guid"></param>
        /// <returns></returns>
        public static DataTable lemonSelectExamInfo(string exam_time, string exam_type_guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamInfo", JsonConvert.SerializeObject(new { exam_time = exam_time, exam_type_guid = exam_type_guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// 根据GUID返回考试题目ExamSubjectInfo
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static DataTable lemonSelectExamSubjectInfoGUID(string guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamSubjectInfoGUID", JsonConvert.SerializeObject(new { guid = guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable lemonSelectExamInfoGUID(string guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamInfoGUID", JsonConvert.SerializeObject(new { guid = guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable lemonSelectExamSubjectInfoExam_guid(string exam_guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamSubjectInfoExam_guid", JsonConvert.SerializeObject(new { exam_guid = exam_guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable lemonSelectExamSubjectInfoLIKE(string exam_guid, string subject_content)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamSubjectInfoExam_guid", JsonConvert.SerializeObject(new { exam_guid = exam_guid, subject_content = subject_content }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable lemonSelectExamInfoDelete(string exam_type_guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamInfoDelete", JsonConvert.SerializeObject(new { exam_type_guid = exam_type_guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable lemonSelectExamTypeInfoGUID(string guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamTypeInfoGUID", JsonConvert.SerializeObject(new { guid = guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }
        #endregion

        #endregion

        #region 学生组


        #region 新增

        #endregion

        #region 删除
        #endregion

        #region 编辑
        #endregion

        #region 查询
        /// <summary>
        /// post 根据GUID查询 ExamInfo
        /// </summary>
        /// <param name="user_no">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <returns></returns>
        public static DataTable lemonSelelctExamInfoGUID(string guid)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selelctExamInfoGUID", JsonConvert.SerializeObject(new { guid = guid }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        public static DataTable lemonSelelctSubjectChildInfoOrderBy(string subject_guid) {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selelctSubjectChildInfoOrderBy", JsonConvert.SerializeObject(new { subject_guid = subject_guid }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        public static DataTable lemonSelelctSubjectChildOptionInfoOrderBy(string subject_child_guid)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selelctSubjectChildOptionInfoOrderBy", JsonConvert.SerializeObject(new { subject_child_guid = subject_child_guid }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        public static DataTable lemonSelelctExamSubjectInfoDelete(string exam_guid)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/selelctExamSubjectInfoDelete", JsonConvert.SerializeObject(new { exam_guid = exam_guid }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }
        
        #endregion

        #endregion
    }
}
