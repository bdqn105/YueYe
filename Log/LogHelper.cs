using DotNet.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class LogHelper
    {
        public static string LogServiceIP="118.190.146.251";
       // public static string LogServiceIP = "192.168.31.156";
        public static bool WriteLog(Exception ex)
        {
            LogInfo log = new LogInfo();
            log.Topic = getFileName();
            log.Message = ex.Message;
            log.Extimer = DateTime.Now;
            string strJson = JsonConvert.SerializeObject(log, new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeNonAscii });
            HttpHelper helper = new HttpHelper();
            HttpItem item = new HttpItem();
            item.URL = String.Format("http://{0}/LogService/AddLog.ashx",LogServiceIP);
            item.Method = "post";
            item.Postdata = strJson;

            
            HttpResult result = helper.GetHtml(item);
            if(result.StatusCode==System.Net.HttpStatusCode.OK)
            {
                if (result.Html.Equals("Success"))
                    return true;
                else
                    return false;
            }
            return false;

        }
        public static string  getFileName()
        {
            StackTrace trace = new StackTrace();
            StackFrame frame = trace.GetFrame(2);//1代表上级，2代表上上级，以此类推  
            MethodBase method = frame.GetMethod();
            String className = method.ReflectedType.Name;
            return className + "." + method.ToString();
        }
    }
}
