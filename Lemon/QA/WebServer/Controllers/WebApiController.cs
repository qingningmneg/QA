using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

using Newtonsoft.Json;

namespace WebServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [DisableRequestSizeLimit]
    public class WebApiController : ControllerBase
    {
        #region 测试方法
        /// <summary>
        /// get 测试方法
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult getningmengText()
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();

            Result.Add("空值", "这是一个测试方法");//获取客户端值 ParamsJson.ningmeng

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// post 测试方法
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult postningmengText([FromBody] JsonElement Parameters)
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();


            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            Result.Add("空值", ParamsJson.ningmeng);//获取客户端值 ParamsJson.ningmeng

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        #endregion

        [HttpPost]
        public ActionResult EQ([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var strSql = Convert.ToString(ParamsJson.strSql);

            var Params = (dynamic)ParamsJson.Params;
            List<(string, object, string)> SqlParams = new List<(string, object, string)>();
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Item1 = Convert.ToString(item.Item1);
                    var Item3 = Convert.ToString(item.Item3);
                    object Item2 = null;
                    if (string.IsNullOrEmpty(Item3) == true)
                    {
                        Item2 = Convert.ToString(item.Item2);
                    }
                    else if (Item3 == typeof(byte[]).FullName)
                    {
                        Item2 = (byte[])item.Item2;
                    }
                    else
                    {
                        Item2 = Convert.ToString(item.Item2);
                    }

                    SqlParams.Add((Item1, Item2, Item3));
                }
            }

            Result = SqlHelper.ExecuteQuery(strSql, SqlParams);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        [HttpPost]
        public void ENQ([FromBody] JsonElement Parameters)
        {
            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var strSql = Convert.ToString(ParamsJson.strSql);

            var Params = (dynamic)ParamsJson.Params;
            List<(string, object, string)> SqlParams = new List<(string, object, string)>();
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Item1 = Convert.ToString(item.Item1);
                    var Item3 = Convert.ToString(item.Item3);
                    object Item2 = null;
                    if (string.IsNullOrEmpty(Item3) == true)
                    {
                        Item2 = Convert.ToString(item.Item2);
                    }
                    else if (Item3 == typeof(byte[]).FullName)
                    {
                        Item2 = (byte[])item.Item2;
                    }
                    else
                    {
                        Item2 = Convert.ToString(item.Item2);
                    }

                    SqlParams.Add((Item1, Item2, Item3));
                }
            }

            SqlHelper.ExecuteNonQuery(strSql, SqlParams);
        }

        [HttpPost]
        public ActionResult UploadFile()
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();

            var FormData = Request.Form;
            var Files = FormData.Files;
            if (Files != null)
            {
                foreach (var file in Files)
                {
                    var Key = file.Name;
                    var FileFullName = file.FileName;
                    var fileInfo = new FileInfo(FileFullName);
                    var Extension = fileInfo.Extension;
                    var FileName = fileInfo.Name;

                    var fs = file.OpenReadStream();
                    var vs = new byte[fs.Length];
                    fs.Read(vs, 0, vs.Length);
                    fs.Flush();

                    var SaveAbsolutePath = AppDomain.CurrentDomain.BaseDirectory; //绝对路径
                    var SaveRelativePath = ""; //相对路径
                    var SaveFileName = Guid.NewGuid().ToString() + Extension; //文件名称

                    if (FormData.ContainsKey(Key) == true)
                    {
                        var str = FormData[Key].ToString();
                        var dic = JsonConvert.DeserializeObject<dynamic>(str);

                        var ParamAbsolutePath = Convert.ToString(dic.AbsolutePath);
                        if (string.IsNullOrWhiteSpace(ParamAbsolutePath) == false)
                        {
                            SaveAbsolutePath = ParamAbsolutePath;
                        }

                        var ParamRelativePath = Convert.ToString(dic.RelativePath);
                        if (string.IsNullOrWhiteSpace(ParamRelativePath) == false)
                        {
                            SaveRelativePath = ParamRelativePath;
                        }

                        var ParamFileName = Convert.ToString(dic.FileName);
                        if (string.IsNullOrWhiteSpace(ParamFileName) == false)
                        {
                            SaveFileName = ParamFileName;
                        }
                    }

                    var SaveFileFullName = SaveAbsolutePath + SaveRelativePath + SaveFileName;
                    System.IO.File.WriteAllBytes(SaveFileFullName, vs);
                    Result[Key] = SaveRelativePath + SaveFileName;
                }
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        #region 教师端

        #region 新增
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $"insert into UserInfo(card_no,user_no,user_pwd,user_name,photo) values(@card_no,@user_no,@user_pwd,@user_name,@photo)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增考试类型
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertExamInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var exam_type_guid = ParamsJson.exam_type_guid;
                var exam_time = ParamsJson.exam_time;
                string strSql = $@"insert into ExamInfo(guid,exam_type_guid,exam_time) values('{guid}','{exam_type_guid}','{exam_time}')";
                SqlHelper.ExecuteNonQuery(strSql);
                Result = true;
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增考试题目
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertExamSubjectInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $@"insert into ExamSubjectInfo (subject_content,subject_content2,exam_guid,subject_no,guid) values (@subject_content,@subject_content2,@exam_guid,@subject_no,@guid)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增选择小题
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertChooseSubjectChildInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type)values(@guid,@subject_guid,@subject_child_no,@subject_child_type)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增子题目选项(单选多选)
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertSubjectChildOptionInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $@"insert into SubjectChildOptionInfo(guid,subject_child_guid,option_no,option_content,option_content2,answer)values(@guid,@subject_child_guid,@option_no,@option_content,@option_content2,@answer)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增小题(判断)
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertJudgeSubjectChildInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type,subject_child_answer)values(@guid,@subject_guid,@subject_child_no,@subject_child_type,@subject_child_answer)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增小题(问答)
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertQAASubjectChildInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var strSql = $@"insert into SubjectChildInfo(guid,subject_guid,subject_child_no,subject_child_type,subject_child_answer2)values(@guid,@subject_guid,@subject_child_no,@subject_child_type,@subject_child_answer)";
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

                var Params = (dynamic)ParamsJson.Params;
                List<(string, object, string)> SqlParams = new List<(string, object, string)>();
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        var Item1 = Convert.ToString(item.Item1);
                        var Item3 = Convert.ToString(item.Item3);
                        object Item2 = null;
                        if (string.IsNullOrEmpty(Item3) == true)
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }
                        else if (Item3 == typeof(byte[]).FullName)
                        {
                            Item2 = (byte[])item.Item2;
                        }
                        else
                        {
                            Item2 = Convert.ToString(item.Item2);
                        }

                        SqlParams.Add((Item1, Item2, Item3));
                    }
                }

                SqlHelper.ExecuteNonQuery(strSql, SqlParams);

                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 新增考试科目
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertExamTypeInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var exam_type = ParamsJson.exam_type;
                string strSql = $@"insert into ExamTypeInfo (guid,exam_type) values ('{guid}','{exam_type}')";
                SqlHelper.ExecuteNonQuery(strSql);
                Result = true;
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除年份
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteExamInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var year_guid = ParamsJson.year_guid;

                var dt_ExamInfo = SqlHelper.ExecuteQuery($@"select * from ExamInfo where guid='{year_guid}'");//年份表
                if (dt_ExamInfo != null && dt_ExamInfo.Rows.Count > 0)
                {
                    var ExamInfo_Count = dt_ExamInfo.Rows.Count;
                    for (int ExamInfo = 0; ExamInfo < ExamInfo_Count; ExamInfo++)//ExamInfo 年份表
                    {
                        var ExamInfo_guid = dt_ExamInfo.Rows[ExamInfo]["guid"];
                        var dt_ExamSubjectInfo = SqlHelper.ExecuteQuery($@"select * from ExamSubjectInfo where exam_guid='{ExamInfo_guid}'");//查询大题表
                        if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
                        {
                            var ExamSubjectInfo_Count = dt_ExamSubjectInfo.Rows.Count;
                            for (int ExamSubjectInfo = 0; ExamSubjectInfo < ExamSubjectInfo_Count; ExamSubjectInfo++)//ExamSubjectInfo 大题表
                            {
                                var ExamSubjectInfo_guid = dt_ExamSubjectInfo.Rows[ExamSubjectInfo]["guid"];
                                var dt_SubjectChildInfo = SqlHelper.ExecuteQuery($@"select * from SubjectChildInfo where subject_guid='{ExamSubjectInfo_guid}'");//查询小题表
                                if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                                {
                                    var SubjectChildInfo_Count = dt_SubjectChildInfo.Rows.Count;
                                    for (int SubjectChildInfo = 0; SubjectChildInfo < SubjectChildInfo_Count; SubjectChildInfo++)//SubjectChildInfo小题表
                                    {
                                        var SubjectChildInfo_guid = dt_SubjectChildInfo.Rows[SubjectChildInfo]["guid"];
                                        //SubjectChildOptionInfo 答案表
                                        var dt_SubjectChildOptionInfo = SqlHelper.ExecuteQuery($@"select * from SubjectChildOptionInfo where subject_child_guid='{SubjectChildInfo_guid}'");//答案表
                                        if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                                        {
                                            SqlHelper.ExecuteNonQuery($"delete from SubjectChildOptionInfo where subject_child_guid='{SubjectChildInfo_guid}'");
                                        }
                                    }
                                    //SubjectChildInfo 小题表
                                    SqlHelper.ExecuteNonQuery($"delete from SubjectChildInfo where subject_guid='{ExamSubjectInfo_guid}'");
                                }
                                //ExamSubjectInfo 大题表
                            }
                            SqlHelper.ExecuteNonQuery($"delete from ExamSubjectInfo where exam_guid='{ExamInfo_guid}'");
                        }
                        //ExamInfo 年份表
                    }
                    SqlHelper.ExecuteNonQuery($"delete from ExamInfo where guid='{year_guid}'");
                }
                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteExamTypeInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var exam_type = ParamsJson.exam_type;


                var dt_ExamTypeInfo = SqlHelper.ExecuteQuery($@"select * from ExamTypeInfo where exam_type = '{exam_type}'");//类型
                if (dt_ExamTypeInfo != null && dt_ExamTypeInfo.Rows.Count > 0)
                {
                    var ExamTypeInfo_guid = dt_ExamTypeInfo.Rows[0]["guid"];
                    var dt_ExamInfo = SqlHelper.ExecuteQuery($@"select * from ExamInfo where exam_type_guid = '{ExamTypeInfo_guid}'");//年份表
                    if (dt_ExamInfo != null && dt_ExamInfo.Rows.Count > 0)
                    {
                        var ExamInfo_Count = dt_ExamInfo.Rows.Count;
                        for (int ExamInfo = 0; ExamInfo < ExamInfo_Count; ExamInfo++)//ExamInfo 年份表
                        {
                            var ExamInfo_guid = dt_ExamInfo.Rows[ExamInfo]["guid"];
                            var dt_ExamSubjectInfo = SqlHelper.ExecuteQuery($@"select * from ExamSubjectInfo where exam_guid='{ExamInfo_guid}'");//查询大题表
                            if (dt_ExamSubjectInfo != null && dt_ExamSubjectInfo.Rows.Count > 0)
                            {
                                var ExamSubjectInfo_Count = dt_ExamSubjectInfo.Rows.Count;
                                for (int ExamSubjectInfo = 0; ExamSubjectInfo < ExamSubjectInfo_Count; ExamSubjectInfo++)//ExamSubjectInfo 大题表
                                {
                                    var ExamSubjectInfo_guid = dt_ExamSubjectInfo.Rows[ExamSubjectInfo]["guid"];
                                    var dt_SubjectChildInfo = SqlHelper.ExecuteQuery($@"select * from SubjectChildInfo where subject_guid='{ExamSubjectInfo_guid}'");//查询小题表
                                    if (dt_SubjectChildInfo != null && dt_SubjectChildInfo.Rows.Count > 0)
                                    {
                                        var SubjectChildInfo_Count = dt_SubjectChildInfo.Rows.Count;
                                        for (int SubjectChildInfo = 0; SubjectChildInfo < SubjectChildInfo_Count; SubjectChildInfo++)//SubjectChildInfo小题表
                                        {
                                            var SubjectChildInfo_guid = dt_SubjectChildInfo.Rows[SubjectChildInfo]["guid"];
                                            //SubjectChildOptionInfo 答案表
                                            var dt_SubjectChildOptionInfo = SqlHelper.ExecuteQuery($@"select * from SubjectChildOptionInfo where subject_child_guid='{SubjectChildInfo_guid}'");//答案表
                                            if (dt_SubjectChildOptionInfo != null && dt_SubjectChildOptionInfo.Rows.Count > 0)
                                            {
                                                SqlHelper.ExecuteNonQuery($"delete from SubjectChildOptionInfo where subject_child_guid='{SubjectChildInfo_guid}'");
                                            }
                                        }
                                        //SubjectChildInfo 小题表
                                        SqlHelper.ExecuteNonQuery($"delete from SubjectChildInfo where subject_guid='{ExamSubjectInfo_guid}'");
                                    }
                                    //ExamSubjectInfo 大题表
                                }
                                SqlHelper.ExecuteNonQuery($"delete from ExamSubjectInfo where exam_guid='{ExamInfo_guid}'");
                            }
                            //ExamInfo 年份表
                        }
                        SqlHelper.ExecuteNonQuery($"delete from ExamInfo where exam_type_guid='{ExamTypeInfo_guid}'");
                    }
                    //ExamTypeInfo 类型
                    SqlHelper.ExecuteNonQuery($"delete from ExamTypeInfo where exam_type='{exam_type}'");
                }
                Result = true;
            }
            catch
            {
                Result = false;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改考试类型
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult updateExamInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var startTimeandEndTime = ParamsJson.startTimeandEndTime;
                var year_guid = ParamsJson.year_guid;
                SqlHelper.ExecuteNonQuery($@"update ExamInfo set exam_time ='{startTimeandEndTime}' where guid='{year_guid}'");
                Result = true;
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 修改考试类型
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult updateSubjectChildInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var startTimeandEndTime = ParamsJson.startTimeandEndTime;
                byte[] subject_child_analysis2 = ParamsJson.subject_child_analysis2;
                var guid = ParamsJson.guid;
                SqlHelper.ExecuteNonQuery($@"update SubjectChildInfo set subject_child_analysis2='{subject_child_analysis2}' where guid = '{guid}'");
                Result = true;
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 根据GUID修改考试信息的exam_type字段
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult updateExamTypeInfo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var startTimeandEndTime = ParamsJson.startTimeandEndTime;
                var exam_type = ParamsJson.exam_type;
                var guid = ParamsJson.guid;
                SqlHelper.ExecuteNonQuery($@"update ExamTypeInfo set exam_type='{exam_type}' where guid = '{guid}'");

                Result = true;
            }
            catch { Result = false; }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        #endregion

        #region 查询
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult selelctLogin([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var user_no = ParamsJson.user_no;
            var user_pwd = ParamsJson.user_pwd;

            string strSql = $@"select user_no,user_pwd,user_type from UserInfo where user_no = '{user_no}'and user_pwd = '{user_pwd}'";

            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 判断卡号是否存在
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult selectCardNo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var card_no = ParamsJson.card_no;

            string strSql = $@"select user_no from UserInfo where card_no = '{card_no}'";

            var dt = SqlHelper.ExecuteQuery(strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Result = true;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 判断用户名是否存在
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult selectUserNo([FromBody] JsonElement Parameters)
        {
            bool Result = false;

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var user_no = ParamsJson.user_no;

            string strSql = $@"select user_no from UserInfo where user_no = '{user_no}'";

            var dt = SqlHelper.ExecuteQuery(strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Result = true;
            }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 获取全部年份
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult selectExamTypeInfo()
        {
            DataTable Result = new DataTable();

            Result = SqlHelper.ExecuteQuery($@"select * from ExamTypeInfo");

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 查询指定的考试类型
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult selectExamTypeInfoExamType([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var exam_type = ParamsJson.exam_type;
            string strSql = $@"select * from ExamTypeInfo where exam_type = '{exam_type}'";
            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 查询指定的历年考试信息
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult selectExamInfoExamTypeInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var exam_type_guid = ParamsJson.exam_type_guid;
            string strSql = $@"select * from ExamInfo where exam_type_guid = '{exam_type_guid}'";
            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 根据考试时间和考试类型查询历年考试信息表
        /// </summary>
        /// <param name="exam_time"></param>
        /// <param name="exam_type_guid"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamInfo([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var exam_time = ParamsJson.exam_time;
                var exam_type_guid = ParamsJson.exam_type_guid;
                var strSql = $@"select * from ExamInfo where exam_time = '{exam_time}' and exam_type_guid = '{exam_type_guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);

            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 根据GUID返回考试题目ExamSubjectInfo
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamSubjectInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var strSql = $@"select * from ExamSubjectInfo where guid = '{guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);

            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 根据GUID返回历年考试信息ExamInfo
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var strSql = $@"select * from ExamInfo where guid = '{guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 根据GUID返回历年考试信息ExamInfo
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamSubjectInfoExam_guid([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var exam_guid = ParamsJson.exam_guid;
                var strSql = $@"select * from ExamSubjectInfo where exam_guid = '{exam_guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 根据GUID返回历年考试信息ExamInfo
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamSubjectInfoLIKE([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var exam_guid = ParamsJson.exam_guid;
                var subject_content = ParamsJson.subject_content;
                var strSql = $@"select * from ExamSubjectInfo where exam_guid = '{exam_guid}' and subject_content LIKE '{subject_content}'";
                Result = SqlHelper.ExecuteQuery(strSql);
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        /// <summary>
        /// 根据exam_type_guid返回信息,但是要带上一行删除按钮
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamInfoDelete([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var exam_type_guid = ParamsJson.exam_type_guid;
                var strSql = $@"select*,sc='删除' from ExamInfo where exam_type_guid = '{exam_type_guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 根据科目名称的GUID查询字段
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SelectExamTypeInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var strSql = $@"select * from ExamTypeInfo where guid = '{guid}'";
                Result = SqlHelper.ExecuteQuery(strSql);
            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        #endregion

        #endregion

        #region 学生端

        #region 新增

        #endregion

        #region 删除
        #endregion

        #region 修改
        #endregion

        #region 查询
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult selelctExamInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var guid = ParamsJson.guid;

            string strSql = $@"select b.* from ExamInfo a join ExamSubjectInfo b on a.guid = b.exam_guid where a.exam_type_guid = '{guid}'";

            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult selelctSubjectChildInfoOrderBy([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var subject_guid = ParamsJson.subject_guid;

            string strSql = $@"select * from SubjectChildInfo where subject_guid = '{subject_guid}' Order By ruid asc";

            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult selelctSubjectChildOptionInfoOrderBy([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var subject_child_guid = ParamsJson.subject_child_guid;

            string strSql = $@"select * from SubjectChildOptionInfo where subject_child_guid = '{subject_child_guid}' Order by newid()";

            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult selelctExamSubjectInfoDelete([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());

            var exam_guid = ParamsJson.exam_guid;

            string strSql = $@"select * ,sc='删除' from ExamSubjectInfo where exam_guid = '{exam_guid}' ";

            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
        
        #endregion

        #endregion


    }
}
