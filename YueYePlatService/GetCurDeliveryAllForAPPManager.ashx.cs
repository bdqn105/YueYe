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
    /// GetCurDeliveryAll 的摘要说明
    /// </summary>
    public class GetCurDeliveryAll : IHttpHandler, IRequiresSessionState
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
                        List<YueYePlat.Model.deliveryorder> deliveryOrderList = new List<YueYePlat.Model.deliveryorder>();
                        //查询驾驶员所在的物流公司
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", curUser.CompanyId));
                        List<YueYePlat.Model.deliverycurgpsinfo> curGPSList = new List<YueYePlat.Model.deliverycurgpsinfo>();
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            List<YueYePlat.Model.deliveryorder> deliveryorderList = new List<YueYePlat.Model.deliveryorder>();                                                   
                            deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("isEnd=0"));
                            if (deliveryorderList.Count > 0)
                            {
                                for (int i = 0; i < deliveryorderList.Count; i++)
                                {
                                    List<YueYePlat.Model.vehicledelivery> vehicleDeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", deliveryorderList[i].DeliveryId));
                                    List<YueYePlat.Model.deliverycurgpsinfo> deliveryGPSList = new YueYePlat.BLL.deliverycurgpsinfo().GetModelList(String.Format ("DeliveryId='{0}' order by CurrentTime DESC limit 1",deliveryorderList[i].DeliveryId));
                                    if (deliveryGPSList.Count > 0)
                                    {
                                        if (vehicleDeliveryList[0].VehicleId != null)
                                        {
                                            deliveryGPSList[0].VehicleId = vehicleDeliveryList[0].VehicleId;
                                            deliveryGPSList[0].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleDeliveryList[0].VehicleId))[0].VehicleNumber;
                                        }
                                        if (vehicleDeliveryList[0].Driver1Id != "")
                                        {
                                            deliveryGPSList[0].Driver1Id = new YueYePlat.BLL .driverinfo().GetModelList(String.Format ("DriverId='{0}'", vehicleDeliveryList[0].Driver1Id))[0].DriverName ;
                                        }
                                        if (vehicleDeliveryList[0].Driver2Id != "")
                                        {
                                            deliveryGPSList[0].Driver2Id = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", vehicleDeliveryList[0].Driver2Id))[0].DriverName;
                                        }
                                        curGPSList.Add(deliveryGPSList[0]);
                                    }
                                }
                            }
                        }                      
                        model.UserData =curGPSList ;
                        model.IsSuccess = true;
                        model.ResultMsg = "GPS数据获取成功！";
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

                    LogHelper.WriteLog("GetCurDeliveryAllForAPPManager", ex);
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