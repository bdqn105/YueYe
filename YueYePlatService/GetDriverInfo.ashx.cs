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
    /// GetDriverInfo 的摘要说明
    /// </summary>
    public class GetDriverInfo : IHttpHandler, IRequiresSessionState
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
                            List<String> driverList = new List<string>();
                            for (int i = 0; i < olddeliveryList.Count; i++)
                            {
                                if (!driverList.Contains(olddeliveryList[i].Driver1Id) && !olddeliveryList[i].Driver1Id.Equals(""))
                                {
                                    driverList.Add(olddeliveryList[i].Driver1Id);
                                }
                                if (!driverList.Contains(olddeliveryList[i].Driver2Id) && !olddeliveryList[i].Driver2Id.Equals(""))
                                {
                                    driverList.Add(olddeliveryList[i].Driver2Id);
                                }
                            }
                            List<string> useableDriver = new List<string>();
                            List<YueYePlat.Model.driverinfo> drivers = new YueYePlat.BLL.driverinfo().GetModelList("");
                            for (int i = 0; i < drivers.Count; i++)
                            {
                                if (!useableDriver.Contains(drivers[i].DriverId))
                                {
                                    useableDriver.Add(drivers[i].DriverId);
                                }
                            }
                            List<string> driveres = useableDriver.Except<string>(driverList).ToList(); //?
                            List<string> driverNames = new List<string>();
                            for (int i = 0; i < driveres.Count; i++)
                            {
                                driverNames.Add(new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", driveres[i]))[0].DriverName+"("+driveres[i]+")");
                            }
                            driverNames.Remove(curUser.UserName+ "(" +curUser.UserId+")");
                            model.UserData = driverNames;
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