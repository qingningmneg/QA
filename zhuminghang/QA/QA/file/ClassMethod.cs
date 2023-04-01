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
        public static Dictionary<string, object> getningmengText()
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.DownloadString($@"{ServerUrl}/getningmengText");

            Result = JsonConvert.DeserializeObject<Dictionary<string, object>>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 登录
        /// </summary>
        /// <param name="user_no">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <returns></returns>
        public static DataTable lemonLogin(string user_no, string user_pwd)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/Login", JsonConvert.SerializeObject(new { user_no = user_no, user_pwd = user_pwd }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        /// <summary>
        /// post 判断卡号是否存在
        /// </summary>
        /// <param name="card_no">卡号</param>
        public static bool lemonCardNo(string card_no)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/CardNo", JsonConvert.SerializeObject(new { card_no = card_no }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 判断用户名是否存在
        /// </summary>
        /// <param name="card_no">卡号</param>
        public static bool lemonUserNo(string user_no)
        {
            bool Result = false;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/UserNo", JsonConvert.SerializeObject(new { user_no = user_no }));
            Result = JsonConvert.DeserializeObject<bool>(ResultsJson);

            return Result;
        }

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
        /// get 获取所有年份
        /// </summary>
        /// <returns></returns>
        public static DataTable lemonExamTypeInfo()
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.DownloadString($@"{ServerUrl}/ExamTypeInfo");

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 查询指定的考试类型
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static DataTable lemonExamTypeInfoExamType(string exam_type)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/ExamTypeInfoExamType", JsonConvert.SerializeObject(new { exam_type = exam_type }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// post 查询指定的历年考试信息
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static DataTable lemonExamInfoExamTypeInfoGUID(string exam_type_guid)
        {
            DataTable Result = null;

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/ExamInfoExamTypeInfoGUID", JsonConvert.SerializeObject(new { exam_type_guid = exam_type_guid }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

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

        
        public static DataTable lemonSelectExamInfo(string exam_time, string exam_type_guid)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/SelectExamInfo", JsonConvert.SerializeObject(new { exam_time = exam_time, exam_type_guid = exam_type_guid}));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

    }
}
