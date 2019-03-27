using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
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
        public static object Get(string url, string param)
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

        /// <summary>
        /// 纠偏
        /// </summary>
        /// <param name="ak"></param>
        /// <param name="service_id"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object Getlatestpoint(string ak, string service_id, string param)
        {
            string url = "http://yingyan.baidu.com/api/v3/track/getlatestpoint";
            string strURL = url + '?' + "ak=" + ak + "&&service_id=" + service_id + "&&entity_name=" + param;
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            //request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.ContentType = "application/json; charset=utf-8";
            request.Method = "GET";
            //添加header
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
        }
        /// <summary>
        /// 查询轨迹和纠偏
        /// </summary>
        /// <param name="ak"></param>
        /// <param name="service_id"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object Gettrack(string ak, string service_id, string param, string start_time, string end_time,int page_index)
        {
            string url = "http://yingyan.baidu.com/api/v3/track/gettrack";
            string strURL = url + '?' + "ak=" + ak + "&&service_id=" + service_id + "&&entity_name=" + param + "&&start_time=" + start_time + "&&end_time=" + end_time + "&&is_processed=1&&need_vacuate=1&&need_mapmatch=1&&need_denoise=1&&transport_mode=driving&&radius_threshold=20&&page_size=500" + "&&page_index="+page_index;
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            //request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.ContentType = "application/json; charset=utf-8";
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
        }
        public static object GetStayPoint(string ak, string service_id, string param, string start_time, string end_time)
        {
            string url = "http://yingyan.baidu.com/api/v3/analysis/staypoint";
            string strURL = url + '?' + "ak=" + ak + "&service_id=" + service_id + "&entity_name=" + param + "&start_time=" + start_time + "&end_time=" + end_time + "&stay_time=600&stay_radius=10&need_mapmatch=1&transport_mode=driving";
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            //request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.ContentType = "application/json; charset=utf-8";
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
        }
        public static object GetDrivingbehavior(string ak, string service_id, string param, string start_time, string end_time)
        {
            //ak=YPtpaHFhtN4m891K01wbSD4P1nrtmoe8&service_id=202455&entity_name=SF1807080001&start_time=1531238400&end_time=1531321200
            string url = "http://yingyan.baidu.com/api/v3/analysis/drivingbehavior";
            string strURL = url + '?' + "ak=" + ak + "&service_id=" + service_id + "&entity_name=" + param + "&start_time=" + start_time + "&end_time=" + end_time + "&need_mapmatch=1&transport_mode=driving";
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(strURL);
            //request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.ContentType = "application/json; charset=utf-8";
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
        }
    }
}
