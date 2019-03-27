using Qiniu.Http;
using Qiniu.IO;
using Qiniu.IO.Model;
using Qiniu.RS;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class QiniuManager
    {
        public static void UploadFile(string localFile, string saveKey)
        {
            Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
            // 上传策略
            PutPolicy putPolicy = new PutPolicy();
            // 设置要上传的目标空间
            putPolicy.Scope = QiniuInfo.Bucket;
            // 上传策略的过期时间(单位:秒)
            putPolicy.SetExpires(3600);
            string uploadToken = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
            Console.WriteLine(uploadToken);
            FormUploader upLoader = new FormUploader(false);
            if (localFile != null)
            {
                HttpResult result = upLoader.UploadFile(localFile, saveKey, uploadToken);
                if (result != null)
                {
                    if (result.Code != 200)
                    {
                        if (result.Code != 200)
                        {
                            if (result.ToString().Contains("file exists"))
                            {
                                BucketManager bm = new BucketManager(mac);
                                bm.Delete(QiniuInfo.Bucket, saveKey);                                
                                PutPolicy newputPolicy = new PutPolicy();
                                // 设置要上传的目标空间
                                newputPolicy.Scope = QiniuInfo.Bucket;
                                // 上传策略的过期时间(单位:秒)
                                newputPolicy.SetExpires(3600);
                                string newuploadToken = Auth.CreateUploadToken(mac, newputPolicy.ToJsonString());
                                Console.WriteLine(uploadToken);
                                FormUploader newupLoader = new FormUploader(false);
                                HttpResult newresult = newupLoader.UploadFile(localFile, saveKey, newuploadToken);
                                if (newresult.Code != 200)
                                {
                                    throw new Exception(newresult.RefText);
                                }
                            }                    
                        }
                        else
                        {
                            throw new Exception(result.RefText);
                        }
                    }
                    return;
                }               
            }           
        }
        public static void DownloadFile(string url, string localFileFullName)
        {
            Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
            int expireInSeconds = 3600;
            string accUrl = DownloadManager.CreateSignedUrl(mac, url, expireInSeconds);
            //文件链接地址:http://oio2cxdal.bkt.clouddn.com/1/20170213231810.jpg
            HttpResult result = DownloadManager.Download(accUrl, localFileFullName);
            Console.WriteLine(result);
        }
        public static void DeleteFile(string saveKey)
        {
            Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
            BucketManager bm = new BucketManager(mac);
            bm.Delete(QiniuInfo.Bucket, saveKey);
        }
    }
}
