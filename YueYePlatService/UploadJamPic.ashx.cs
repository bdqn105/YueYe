using Maticsoft.DBUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YueYePlatService
{
    /// <summary>
    /// UploadJamPic 的摘要说明
    /// </summary>
    public class UploadJamPic : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType.ToLower().Equals("post"))
            {
                try
                {
                    context.Response.Cache.SetNoStore();
                    context.Response.Clear();
                    HandleModel model = Common.ValidateToken(context);
                    if (model != null)
                    {
                        string[] strData = model.UserData.ToString().Split(';');
                        string deliveryId = "";
                        string logisID = "";
                        string jamJson = "";
                        if (strData.Length >= 3)
                        {
                            deliveryId = strData[0];
                            logisID = strData[1];
                            jamJson = strData[2];

                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                            List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                            if (logisList.Count > 0)
                            {
                                DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", deliveryId));
                                if (deliveryList.Count > 0 && deliveryList[0].IfEnd == false)
                                {
                                    try
                                    {
                                        YueYePlat.Model.vehiclejam jam = JsonConvert.DeserializeObject<YueYePlat.Model.vehiclejam>(jamJson, new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeNonAscii });
                                        if (jam.DeliverId.Equals(deliveryId))
                                        {
                                            if (new YueYePlat.BLL.vehiclejam().Add(jam))
                                            {
                                                model = new HandleModel();
                                                model.ResultMsg = "堵车信息上传成功";
                                                model.IsSuccess = true;
                                                string resJson = JsonConvert.SerializeObject(model);
                                                context.Response.ContentType = "text/plain";
                                                context.Response.Write(resJson);
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        LogHelper.WriteLog("UploadJamPicException", ex);
                                        model = new HandleModel();
                                        model.ResultMsg = "Json文档转换对象失败";
                                        model.IsSuccess = false;
                                        string resJson = JsonConvert.SerializeObject(model);
                                        context.Response.ContentType = "text/plain";
                                        context.Response.Write(resJson);
                                    }
                                }
                                else
                                {
                                    model = new HandleModel();
                                    model.ResultMsg = "此订单已经结束！";
                                    model.IsSuccess = false;
                                    string resJson = JsonConvert.SerializeObject(model);
                                    context.Response.ContentType = "text/plain";
                                    context.Response.Write(resJson);
                                }
                            }
                        }
                    }
                    else
                    {
                        model = new HandleModel();
                        model.ResultMsg = "登录异常 ";
                        model.IsSuccess = false;
                        string resJson = JsonConvert.SerializeObject(model);
                        context.Response.ContentType = "text/plain";
                        context.Response.Write(resJson);
                    }
                }
                catch (Exception ex)
                {

                    LogHelper.WriteLog("GetCurDeliveryOrder", ex);
                }

            }

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