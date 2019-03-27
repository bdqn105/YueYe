using Maticsoft.DBUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace YueYePlatService
{
    /// <summary>
    /// GetDeliveryOrderByDeliveryIDAll 的摘要说明
    /// </summary>
    public class GetDeliveryOrderByDeliveryIDAll : IHttpHandler, IRequiresSessionState
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
                        string deliveryID = model.UserData.ToString();

                        YueYePlat.Model.usersinfo curUser = (YueYePlat.Model.usersinfo)model.UserInfo;
                        string logisID = curUser.CompanyId;
                        List<YueYePlat.Model.deliveryorder> deliveryOrderList = new List<YueYePlat.Model.deliveryorder>();
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);

                            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("ifEnd=0 and DeliveryId='{0}'", deliveryID));
                            foreach (YueYePlat.Model.vehicledelivery delivery in deliveryList)
                            {
                                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", delivery.DeliveryId));
                                for (int i = 0; i < orderList.Count; i++)
                                {

                                    orderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", orderList[i].DeliveryOrderId));
                                    orderList[i].VehicleName = delivery.VehicleId;
                                    orderList[i].Driver1Id = delivery.Driver1Id;
                                    orderList[i].Driver2Id = delivery.Driver2Id;
                                    StringBuilder sb = new StringBuilder();
                                    sb.Append("明细：");
                                    for (int j = 0; j < orderList[i].ProductList.Count; j++)
                                    {
                                        
                                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                        List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                                        YueYePlat.Model.productinfo p = productList.Find(s => s.ProductId == orderList[i].ProductList[j].ProductId);
                                        orderList[i].ProductList[j].ProductId = p != null ? p.ProductName : "";
                                        sb.Append(p.ProductName+"  "+(orderList[i].ProductList[j].Quantity==null?"0": orderList[i].ProductList[j].Quantity.ToString())+ "/"+ (orderList[i].ProductList[j].Weight==null?"0":orderList[i].ProductList[j].Weight.ToString())+"；");
                                        DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                    }
                                    StringBuilder sbFee = new StringBuilder();
                                    sbFee.Append("费用：");
                                    orderList[i].Detail = sb.ToString();
                                    decimal totalorderfee = 0;
                                    if (orderList[i].PaymentMethod == "现付")
                                    {                                                                         
                                        List<YueYePlat.Model.deliveryorderfee> orderfeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", orderList[i].DeliveryOrderId));
                                        for (int j = 0; j < orderfeeList.Count; j++)
                                        {
                                            if (orderfeeList[j].IsShow == true)
                                            {
                                                orderfeeList[j].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[j].FeeTypeId))[0].FeeTypeName;
                                                sbFee.Append(orderfeeList[j].FeetypeName + ":" + orderfeeList[j].Fee + ";");
                                                totalorderfee += orderfeeList[j].Fee;
                                            }
                                        }                                       
                                    }
                                    sbFee.Append("代收款" + ":" + orderList[i].Amount + ";");
                                    totalorderfee = decimal.Parse((totalorderfee + orderList[i].Amount).ToString());
                                    sbFee.Append("总费用" + ":" + totalorderfee + ";");
                                    orderList[i].Orderfee = sbFee.ToString();
                                }
                                deliveryOrderList.AddRange(orderList);
                               
                            }
                            model.ResultMsg = "信息获取成功！";

                        }
                        model.UserData = deliveryOrderList;
                        model.IsSuccess = true;
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

                    LogHelper.WriteLog("GetDeliveryOrderByDeliveryIDAll", ex);
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