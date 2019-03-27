using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YueYePlatService
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                int i = Int32.Parse("123a");
            }
            catch (Exception ex)
            {

                LogHelper.WriteLog("testError", ex);
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}