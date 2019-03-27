using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace YueYePlatService
{
    public class Common
    {
        public static HandleModel ValidateToken(HttpContext context)
        {
            if (context.Session["userinfo"] != null)
            {
                YueYePlat.Model.usersinfo confirmUser = (YueYePlat.Model.usersinfo)context.Session["userinfo"];
                string deviceId = context.Session["deviceid"].ToString();
                YueYePlat.Model.usertoken token = (YueYePlat.Model.usertoken)context.Session["Token"];
                token.LastLoginTime= DateTime.Now;
                new YueYePlat.BLL.usertoken().Update(token);
                context.Session["Token"] = token;
                
                Stream stream = context.Request.InputStream;
                StreamReader reader = new StreamReader(stream);
                string req = reader.ReadLine();

                HandleModel model = JsonConvert.DeserializeObject<HandleModel>(req);
                YueYePlat.Model.usersinfo userInfo = JsonConvert.DeserializeObject<YueYePlat.Model.usersinfo>(model.UserInfo.ToString());          
                string curDeviceId = model.DeviceId;
                if (confirmUser != null && userInfo.UserId.ToLower().Equals(confirmUser.UserId.ToLower()))
                {
                    model.UserInfo = confirmUser;
                    return model;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// 发送请求  
        /// </summary>  
        /// <param name="url">请求地址</param>  
        /// <param name="sendData">参数格式 “name=王武&pass=123456”</param>  
        /// <returns></returns>  
        public static string RequestWebAPI(string url, string sendData)
        {
            string backMsg = "";
            try
            {
                System.Net.WebRequest httpRquest = System.Net.HttpWebRequest.Create(url);
                httpRquest.Method = "POST";
                //这行代码很关键，不设置ContentType将导致后台参数获取不到值  
                httpRquest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
                byte[] dataArray = System.Text.Encoding.UTF8.GetBytes(sendData);
                //httpRquest.ContentLength = dataArray.Length;  
                System.IO.Stream requestStream = null;
                if (string.IsNullOrWhiteSpace(sendData) == false)
                {
                    requestStream = httpRquest.GetRequestStream();
                    requestStream.Write(dataArray, 0, dataArray.Length);
                    requestStream.Close();
                }
                System.Net.WebResponse response = httpRquest.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(responseStream, System.Text.Encoding.UTF8);
                backMsg = reader.ReadToEnd();


                reader.Close();
                reader.Dispose();


                requestStream.Dispose();
                responseStream.Close();
                responseStream.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return backMsg;
        }

        public static string HttpPost(string url, string body)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
        public static string HttpPostData(string url, NameValueCollection stringDict)
        {
            string responseContent;
            var memStream = new MemoryStream();
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            // 边界符
            var boundary = "--------------------------" + DateTime.Now.Ticks.ToString();
            // 边界符
            var beginBoundary = Encoding.ASCII.GetBytes("--" + boundary + "\r\n");
            //var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // 最后的结束符
            var endBoundary = Encoding.ASCII.GetBytes("--" + boundary + "--\r\n");


            // 设置属性
            webRequest.Method = "POST";
            webRequest.Accept = "*/*";
            webRequest.Headers.Add("accept-encoding", "gzip, deflate");
            webRequest.Headers.Add("cache-control", "no-cache");
            //webRequest.Timeout = timeOut;          
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;


            //// 写入文件
            //const string filePartHeader =
            //    "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
            //     "Content-Type: application/octet-stream\r\n\r\n";
            //var header = string.Format(filePartHeader, fileKeyName, filePath);
            //var headerbytes = Encoding.UTF8.GetBytes(header);
            //memStream.Write(beginBoundary, 0, beginBoundary.Length);
            //memStream.Write(headerbytes, 0, headerbytes.Length);
            //var buffer = new byte[1024];
            //int bytesRead; // =0
            //while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            //{
            //    memStream.Write(buffer, 0, bytesRead);
            //}


            // 写入字符串的Key
            var stringKeyHeader = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"" + "\r\n{1}\r\n";
            foreach (byte[] formitembytes in from string key in stringDict.Keys select string.Format(stringKeyHeader, key, stringDict[key]) into formitem select Encoding.UTF8.GetBytes(formitem))
            {
                memStream.Write(formitembytes, 0, formitembytes.Length);
            }


            // 写入最后的结束边界符
            memStream.Write(endBoundary, 0, endBoundary.Length);


            webRequest.ContentLength = memStream.Length;


            var requestStream = webRequest.GetRequestStream();


            memStream.Position = 0;
            var tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer, 0, tempBuffer.Length);
            memStream.Close();


            requestStream.Write(tempBuffer, 0, tempBuffer.Length);
            requestStream.Close();


            var httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
            //Stream stm = new GZipStream(httpWebResponse.GetResponseStream(), CompressionMode.Decompress);

            using (var httpStreamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("utf-8")))
            {
                responseContent = httpStreamReader.ReadToEnd();
            }

            //fileStream.Close();
            httpWebResponse.Close();
            webRequest.Abort();

            return responseContent;
        }
       


    }
}