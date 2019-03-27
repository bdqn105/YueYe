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
    /// GetDeliveryOrderListForDriver 的摘要说明
    /// </summary>
    public class GetDeliveryOrderListForDriver : IHttpHandler, IRequiresSessionState
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
                       if(logisList.Count>0)
                        {                           
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            List<YueYePlat.Model.vehicledelivery> olddeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("ifEnd = 0 and (Driver1Id='{0}' or Driver2Id='{0}')",curUser.UserId));
                            if (olddeliveryList.Count == 0)
                            {
                                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList("ifEnd=0 and (Driver1Id is null or Driver1Id='') ");
                                foreach (YueYePlat.Model.vehicledelivery delivery in deliveryList)
                                {
                                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", delivery.DeliveryId));
                                    deliveryOrderList.AddRange(orderList);
                                }
                                model.ResultMsg = "信息获取成功！";
                            }
                            else
                            {
                                model.ResultMsg = "此驾驶员有订单未完结！";
                            }
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