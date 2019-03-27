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
    /// UpdateDeliveryOrderForDriver 的摘要说明
    /// </summary>
    public class UpdateDeliveryOrderForDriver : IHttpHandler, IRequiresSessionState
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
                        string orderId = "";
                        string logisID = "";
                        string orderJson = "";
                        if (strData.Length >= 3)
                        {
                            orderId = strData[0];
                            logisID = strData[1];
                            orderJson = strData[2];                           
                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                            List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                            if (logisList.Count > 0)
                            {
                                DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'and IfChargeBack=false", orderId.Substring(0, orderId.Length - 2)));
                                if (deliveryList.Count > 0 && deliveryList[0].IfEnd == false)
                                {
                                    try
                                    {
                                        YueYePlat.Model.deliveryorder order = JsonConvert.DeserializeObject<YueYePlat.Model.deliveryorder>(orderJson, new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeNonAscii });
                                        if (order.DeliveryOrderId.Equals(orderId))
                                        {
                                            if (new YueYePlat.BLL.deliveryorder().UpdateByOrderId(order))
                                            {
                                                #region 判断运单中是否所有订单都完结
                                                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'",order.DeliveryId));
                                                bool needModify = true;
                                                for (int i=0;i<orderList.Count;i++)
                                                {
                                                    if(!orderList[i].IsEnd)
                                                    {
                                                        needModify = false;
                                                        break;
                                                    }
                                                }
                                                if(needModify)
                                                {
                                                    List<YueYePlat.Model.vehicledelivery> curdeliverylist = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}' and IfChargeBack=false", order.DeliveryId));
                                                    if(curdeliverylist.Count>0)
                                                    {
                                                        YueYePlat.Model.vehicledelivery delivery = curdeliverylist[0];
                                                        delivery.IfEnd = true;                                                        
                                                        new YueYePlat.BLL.vehicledelivery().Update(delivery);
                                                    }
                                                }
                                                #endregion
                                                List<YueYePlat.Model.vehicledelivery> deliverylist = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}' and IfChargeBack=false", order.DeliveryId));
                                               
                                                model = new HandleModel();
                                                if (deliveryList.Count > 0)
                                                    model.UserData = JsonConvert.SerializeObject(deliverylist[0]);
                                                model.ResultMsg = "订单更新数据成功";
                                                model.IsSuccess = true;
                                                string resJson = JsonConvert.SerializeObject(model);
                                                context.Response.ContentType = "text/plain";
                                                context.Response.Write(resJson);
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        LogHelper.WriteLog("UpdateDeliveryOrderForDriverException", ex);
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

                    LogHelper.WriteLog("UpdateDeliveryOrderForDriverException", ex);
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