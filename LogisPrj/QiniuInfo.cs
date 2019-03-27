using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qiniu.Util;
using Qiniu.Http;

namespace LogisPrj
{
    public class QiniuInfo
    {
        public static string AccessKey = null;
        public static string SecretKey = null;
        public static string Bucket = null;
        public static string UrlPrefix { get; set; }
       
    }
}
