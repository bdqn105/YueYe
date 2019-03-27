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
    /// GetTempsForDriver 的摘要说明
    /// </summary>
    public class GetTempsForDriver : IHttpHandler, IRequiresSessionState
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
                        string logisName = "";
                        string vehicleCode = "";
                        string pNames = "";
                        YueYePlat.Model.usersinfo curUser = (YueYePlat.Model.usersinfo)model.UserInfo;
                        string logisID = curUser.CompanyId;

                        string[] strData = model.UserData.ToString().Split(';');
                        string deliveryId = "";
                        string startTime,endTime = "";
                        if (strData.Length >=3)
                        {
                            deliveryId = strData[0];
                            startTime = strData[1];
                            endTime = strData[2];
                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                            List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                           
                            List<YueYePlat.Model.deliverycurtempinfo> tempList = new List<YueYePlat.Model.deliverycurtempinfo>();
                            if (logisList.Count > 0)
                            {
                                DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                List<YueYePlat.Model.vehicledelivery> deliverys = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}' and IfChargeback=false", deliveryId));
                                
                                if (deliverys.Count > 0)
                                {
                                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", deliverys[0].DeliveryId));
                                    StringBuilder sbpName = new StringBuilder();
                                        sbpName.Append("品名：");
                                    for (int i = 0; i < orderList.Count; i++)
                                    {

                                        orderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", orderList[i].DeliveryOrderId));
                                        orderList[i].VehicleName = deliverys[0].VehicleId;
                                        orderList[i].Driver1Id = deliverys[0].Driver1Id;
                                        orderList[i].Driver2Id = deliverys[0].Driver2Id;
                                        
                                        for (int j = 0; j < orderList[i].ProductList.Count; j++)
                                        {

                                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                            List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                                            YueYePlat.Model.productinfo p = productList.Find(s => s.ProductId == orderList[i].ProductList[j].ProductId);
                                            orderList[i].ProductList[j].ProductId = p != null ? p.ProductName : "";
                                            sbpName.Append(p.ProductName+ " ");
                                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                        }                                       
                                    }
                                    pNames = sbpName.ToString();
                                    List<YueYePlat.Model.vehicleinfo> vehicles = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliverys[0].VehicleId));
                                    if (vehicles.Count > 0)
                                    {
                                        vehicleCode = vehicles[0].VehicleNumber;
                                    }
                                }
                                logisName = logisList[0].CompanyName;
                                tempList.AddRange(new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("deliveryid='{0}' AND CurrentTime BETWEEN '{1}' AND '{2}'",deliveryId,startTime,endTime)));

                            }
                            
                           
                            StringBuilder sb = new StringBuilder();
                            sb.Append("\r\n\r\n");
                            sb.Append(logisName+"\r\n\r\n");
                            sb.Append("车牌号："+vehicleCode + "\r\n");
                            sb.Append(pNames+"\r\n");
                            sb.Append("冷链运输 车载温度\r\n");
                            sb.Append("开始时间：" + startTime + "\r\n");
                            sb.Append("结束时间：" + endTime + "\r\n");
                            sb.Append("\r\n");
                            for(int i=0;i<tempList.Count;i++)
                            {
                                sb.Append(tempList[i].CurrentTime.Value.ToString("MM-dd hh:mm:ss")+ String.Format("{0,6:##.#}", tempList[i].Temperature1)+  String.Format("{0,6:##.#}", tempList[i].Temperature2)+  String.Format("{0,6:##.#}", tempList[i].Temperature3)+"\r\n");
                            }
                            sb.Append("\r\n\r\n");
                            sb.Append("签单人：\r\n\r\n");
                            sb.Append("\r\n\r\n");
                            model.UserData = sb.ToString();
                            model.IsSuccess = true;
                            model.ResultMsg = "获取数据成功！";
                            string resJson = JsonConvert.SerializeObject(model);
                            context.Response.ContentType = "text/plain";
                            context.Response.Write(resJson);
                        }
                        else
                        {
                            model = new HandleModel();
                            model.IsSuccess = false;
                            model.ResultMsg = "提供的参数不正确";
                            string resJson = JsonConvert.SerializeObject(model);
                            context.Response.ContentType = "text/plain";
                            context.Response.Write(resJson);
                        }
                    }
                    else
                    {
                        model = new HandleModel();
                        model.IsSuccess = false;
                        model.ResultMsg = "登录异常！";
                        string resJson = JsonConvert.SerializeObject(model);
                        context.Response.ContentType = "text/plain";
                        context.Response.Write(resJson);
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog("GetTempForDriver",ex);
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