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

using Newtonsoft.Json;

namespace WebServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [DisableRequestSizeLimit]
    public class WebApiController : ControllerBase
    {
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

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns> 
        [HttpPost]
        public ActionResult Login([FromBody] JsonElement Parameters)
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
        public ActionResult CardNo([FromBody] JsonElement Parameters)
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
        public ActionResult UserNo([FromBody] JsonElement Parameters)
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
        /// 获取全部年份
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ExamTypeInfo()
        {
            DataTable Result = new DataTable();

            Result = SqlHelper.ExecuteQuery($@"select * from ExamTypeInfo");

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

        [HttpPost]
        public ActionResult ExamTypeInfoExamType([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var exam_type = ParamsJson.exam_type;
            string strSql = $@"select * from ExamTypeInfo where exam_type = '{exam_type}'";
            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };

        }

        [HttpPost]
        public ActionResult ExamInfoExamTypeInfoGUID([FromBody] JsonElement Parameters)
        {
            DataTable Result = new DataTable();

            var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
            var exam_type_guid = ParamsJson.exam_type_guid;
            string strSql = $@"select * from ExamInfo where exam_type_guid = '{exam_type_guid}'";
            Result = SqlHelper.ExecuteQuery(strSql);

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }

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

        [HttpPost]
        public ActionResult SelectExamInfo([FromBody] JsonElement Parameters)
        {
            DataTable Result = null;

            try
            {
                var ParamsJson = JsonConvert.DeserializeObject<dynamic>(Parameters.ToString());
                var guid = ParamsJson.guid;
                var exam_time = ParamsJson.exam_time;
                var exam_type_guid = ParamsJson.exam_type_guid;
                var strSql = $@"select * from ExamInfo where exam_time = '{exam_time}' and exam_type_guid = '{exam_type_guid}')";
                Result = SqlHelper.ExecuteQuery(strSql);

            }
            catch { }

            return new ContentResult() { Content = JsonConvert.SerializeObject(Result), ContentType = "application/json", StatusCode = 200 };
        }
    }
}
