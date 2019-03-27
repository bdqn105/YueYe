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
    /// GetDeliveryForDriver 的摘要说明
    /// </summary>
    public class GetDeliveryForDriver : IHttpHandler, IRequiresSessionState
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
                        List<YueYePlat.Model.vehicledelivery> deliveryList = new List<YueYePlat.Model.vehicledelivery>();
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", curUser.CompanyId));
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList("ifEnd=0 order by Driver1Id DESC ,DeliveryId ASC");
                            for (int i = 0; i < deliveryList.Count; i++)
                            {
                                if (deliveryList[i].Driver1Id.Equals(curUser.UserId)|| deliveryList[i].Driver2Id.Equals(curUser.UserId))
                                {
                                    YueYePlat.Model.vehicledelivery curDelivery = deliveryList[i];
                                    deliveryList.RemoveAt(i);
                                    deliveryList.Insert(0, curDelivery);
                                    break;
                                }
                            }
                            for(int i=0;i<deliveryList.Count;i++)
                            {
                                if(deliveryList[i].Driver1Id!=null &&!deliveryList[i].Driver1Id.Equals(""))
                                {
                                    List<YueYePlat.Model.driverinfo> drivers = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'",deliveryList[i].Driver1Id));
                                    if(drivers.Count>0)
                                    {
                                        deliveryList[i].Driver1Id = drivers[0].DriverName;
                                    }
                                }
                                if (deliveryList[i].Driver2Id != null && !deliveryList[i].Driver2Id.Equals(""))
                                {
                                    List<YueYePlat.Model.driverinfo> drivers = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id));
                                    if (drivers.Count > 0)
                                    {
                                        deliveryList[i].Driver2Id = drivers[0].DriverName;
                                    }
                                }
                            }
                            
                        }
                        model.UserData = deliveryList;
                        model.IsSuccess = true;
                        model.ResultMsg = "信息获取成功！";
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