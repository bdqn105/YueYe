using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace YueYePlatService
{
    /// <summary>
    /// 百度鹰眼调用帮助类
    /// </summary>
    public class BDYingYanAPIHelper
    {


        /// <summary>
        /// 发送HttpPost请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数。（参数1=值1&参数2=值2&参数3=值3。。。。。。。）</param>
        /// <returns>请求结果(json对象)</returns>
        public static string Post(string url, string param)
        {
            string strURL = url;
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded";
            string paraUrlCoded = param;
            byte[] payload;
            payload = Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            using (Stream writer = request.GetRequestStream())
            {
                writer.Write(payload, 0, payload.Length);
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                Stream s;
                s = response.GetResponseStream();
                string StrDate = "";
                string strValue = "";
                using (StreamReader Reader = new StreamReader(s, Encoding.UTF8))
                {
                    while ((StrDate = Reader.ReadLine()) != null)
                    {
                        strValue += StrDate + "\r\n";
                    }
                    //JavaScriptSerializer js = new JavaScriptSerializer();
                    return strValue;
                }
            }


            //示例调用
            //string url = "http://apis.baidu.com/idl_baidu/baiduocrpay/idlocrpaid";
            //string param = "参数1=值1&参数2=值2&参数3=值3。。。。。。。";
            //string result = Post(url, param);
        }

        /// <summary>
        /// 发送HttpGet请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数</param>
        /// <param name="apikey">开发者apikey</param>
        /// <returns>请求结果(json对象)</returns>
        public static string Get(string url, string param)
        {
            string strURL = url + '?' + param;
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.ContentType = "application/json; charset=utf-8";
            request.Method = "GET";
            // 添加header
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            using (StreamReader Reader = new StreamReader(s, Encoding.UTF8))
            {
                while ((StrDate = Reader.ReadLine()) != null)
                {
                    strValue += StrDate + "\r\n";
                }
               
                return strValue;
            }
            //示例调用
            //string url = "http://apis.baidu.com/idl_baidu/baiduocrpay/idlocrpaid";
            //string param = "参数1=值1&参数2=值2&参数3=值3。。。。。。。";
            //string result = Get(url, param);
        }

    }   
}