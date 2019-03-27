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
    /// GetVehicleInfo 的摘要说明
    /// </summary>
    public class GetVehicleInfo : IHttpHandler, IRequiresSessionState
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
                        string logisID = curUser.CompanyId;
                        List<YueYePlat.Model.deliveryorder> deliveryOrderList = new List<YueYePlat.Model.deliveryorder>();
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            List<YueYePlat.Model.vehicledelivery> olddeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("ifEnd = 0", curUser.UserId));
                            List<String> vehicleList = new List<string>();
                            for (int i = 0; i < olddeliveryList.Count; i++)
                            {
                                if (!vehicleList.Contains(olddeliveryList[i].VehicleId) && !olddeliveryList[i].VehicleId.Equals(""))
                                {
                                    vehicleList.Add(olddeliveryList[i].VehicleId);
                                }
                            }
                            List<string> userVehicleList = new List<string>();
                            List<YueYePlat.Model.deviceuseinfo> devices = new YueYePlat.BLL.deviceuseinfo().GetModelList("IfBind=1");
                            for (int i = 0; i < devices.Count; i++)
                            {
                                if (!userVehicleList.Contains(devices[i].VehicleId))
                                {
                                    userVehicleList.Add(devices[i].VehicleId);
                                }
                            }
                            List<string> vehicles = userVehicleList.Except<string>(vehicleList).ToList();
                            List<string> vehicleNos = new List<string>();
                            for(int i=0;i<vehicles.Count;i++)
                            {
                                vehicleNos.Add(new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicles[i]))[0].VehicleNumber+"("+vehicles[i]+")");
                            }
                            model.UserData = vehicleNos;
                            model.IsSuccess = true;
                            string resJson = JsonConvert.SerializeObject(model);
                            context.Response.ContentType = "text/plain";
                            context.Response.Write(resJson);
                        }
                        else
                        {
                            model.ResultMsg = "物流公司无此员工！";
                            model.IsSuccess = false;
                            string resJson = JsonConvert.SerializeObject(model);
                            context.Response.ContentType = "text/plain";
                            context.Response.Write(resJson);
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

                    LogHelper.WriteLog("GetDeliveryOrderListForDriver", ex);
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