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
    /// UploadRefuelingInfo 的摘要说明
    /// </summary>
    public class UploadRefuelingInfo : IHttpHandler, IRequiresSessionState
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
                        string refueJson = "";
                        if (strData.Length >= 3)
                        {
                            deliveryId = strData[0];
                            logisID = strData[1];
                            refueJson = strData[2];

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
                                        YueYePlat.Model.refueling refuel = JsonConvert.DeserializeObject<YueYePlat.Model.refueling>(refueJson, new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeNonAscii });
                                        if (refuel.DeliveryId.Equals(deliveryId))
                                        {
                                            refuel.VehicleID = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", refuel.DeliveryId))[0].VehicleId;
                                            if (new YueYePlat.BLL.refueling().Add(refuel))
                                            {
                                                model = new HandleModel();
                                                model.ResultMsg = "加油信息上传成功";
                                                model.IsSuccess = true;
                                                string resJson = JsonConvert.SerializeObject(model);
                                                context.Response.ContentType = "text/plain";
                                                context.Response.Write(resJson);
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        LogHelper.WriteLog("UploadRefuelingInfoException", ex);
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