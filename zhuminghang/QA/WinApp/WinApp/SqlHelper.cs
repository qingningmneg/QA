using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace WinApp
{
    public static class SqlHelper
    {
        public static string ServerUrl = "http://192.168.0.109:18800/api/webapi";

        public static DataTable EQ(this string strSql, object Params = null)
        {
            DataTable Result = new DataTable();
            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);
            return Result;
        }

        public static DataTable EQ(this string strSql, Dictionary<string, object> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, List<(string, object)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, List<(string, object, string)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, params (string, object)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, params (string, object, string)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static void ENQ(this string strSql, object Params = null)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, Dictionary<string, object> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, List<(string, object)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, List<(string, object, string)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, params (string, object)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, params (string, object, string)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static string UploadFile(this byte[] Bytes, string FileName)
        {
            var hc = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = delegate { return true; } });
            var fd = new MultipartFormDataContent();

            var Key = Guid.NewGuid().ToString();
            fd.Add(new ByteArrayContent(Bytes), Key, FileName);
            fd.Add(new StringContent(JsonConvert.SerializeObject(new
            {
                //AbsolutePath = "",
                //RelativePath = "",
                //FileName = "2.jpg"
            }), Encoding.UTF8), Key);

            var Results = JsonConvert.DeserializeObject<Dictionary<string, object>>(hc.PostAsync($@"{ServerUrl}/UploadFile", fd).Result.Content.ReadAsStringAsync().Result);
            var SavePath = Convert.ToString(Results[Key]);

            return SavePath;
        }

        public static string UploadFile(FileResult Result)
        {
            var stream = Result.OpenReadAsync().Result;

            var FileName = Result.FileName;
            var FileFullName = Result.FullPath;

            #region StreamToBytes
            var Bytes = new byte[stream.Length];
            stream.Read(Bytes, 0, Bytes.Length);
            stream.Flush();

            var SavePath = UploadFile(Bytes, FileName);
            #endregion

            return SavePath;
        }
    }
}
