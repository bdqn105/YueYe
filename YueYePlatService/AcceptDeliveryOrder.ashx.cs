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
    /// AcceptDeliveryOrder 的摘要说明
    /// </summary>
    public class AcceptDeliveryOrder : IHttpHandler, IRequiresSessionState
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
                        YueYePlat.Model.usersinfo curUser = (YueYePlat.Model.usersinfo)model.UserInfo;
                        string[] strData = model.UserData.ToString().Split(';');
                        string orderId = strData[0];
                        string VehicleId = strData[1];
                        string DeviceId = "";
                        string Driver1Id = curUser.UserId;
                        string Driver2Id = "";
                        if (strData.Length > 2)
                            Driver2Id = strData[2];
                        string logisID = curUser.CompanyId;
                        List<YueYePlat.Model.deliveryorder> deliveryOrderList = new List<YueYePlat.Model.deliveryorder>();
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            List<YueYePlat.Model.vehicledelivery> olddeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("driver1id='{0}' and IfEnd=false", curUser.UserId));
                            if (olddeliveryList.Count == 0)
                            {
                                List<YueYePlat.Model.deviceuseinfo> duList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("IfBind=true and VehicleId='{0}'", VehicleId));
                                if (duList.Count > 0)
                                {
                                    DeviceId = duList[0].DeviceId;
                                    List<YueYePlat.Model.vehicledelivery> accpdeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}' and IfEnd=false and ifchargeback=false", orderId.Substring(0, orderId.Length - 2)));
                                    if (accpdeliveryList.Count > 0)
                                    {
                                        YueYePlat.Model.vehicledelivery delivery = accpdeliveryList[0];
                                        if ((delivery.Driver1Id == null || delivery.Driver1Id.Equals("")) && !delivery.IfEnd)
                                        {
                                            delivery.DeviceId = DeviceId;
                                            delivery.VehicleId = VehicleId;
                                            delivery.Driver1Id = Driver1Id;
                                            if (!Driver2Id.Equals(""))
                                            {
                                                delivery.Driver2Id = Driver2Id;
                                            }
                                            if (new YueYePlat.BLL.vehicledelivery().Update(delivery))
                                            {
                                                model.ResultMsg = "订单已接受";
                                                model.UserData = delivery;
                                                model.IsSuccess = true;
                                            }
                                            else
                                            {
                                                model.ResultMsg = "驾驶员接单失败";
                                                model.UserData = null;
                                                model.IsSuccess = false;
                                            }
                                        }
                                        else
                                        {
                                            model.ResultMsg = "此单已被其他驾驶员接单。";
                                            model.UserData = null;
                                            model.IsSuccess = false;
                                        }
                                    }
                                    else
                                    {
                                        model.ResultMsg = "此单已被其他驾驶员接单！";
                                    }
                                }
                                else
                                {
                                    model.ResultMsg = "车辆上未绑定终端设备，请联系客服绑定！";
                                    model.UserData = null;
                                    model.IsSuccess = false;
                                }
                            }
                            else
                            {
                                model.ResultMsg = "此驾驶员还有订单未结束，请结束所有订单！";
                                model.UserData = null;
                                model.IsSuccess = false;
                            }
                        }
                        else
                        {
                            model.ResultMsg = "此物流公司不存在！";
                            model.UserData = null;
                            model.IsSuccess = false;
                        }

                        string resJson = JsonConvert.SerializeObject(model);
                        context.Response.ContentType = "text/plain";
                        context.Response.Write(resJson);
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

                    LogHelper.WriteLog("AcceptDeliveryOrder", ex);
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