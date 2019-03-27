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
    /// GetCurDeliveryOrderForDriver 的摘要说明
    /// </summary>
    public class GetCurDeliveryOrderForDriver : IHttpHandler, IRequiresSessionState
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
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("ifEnd=0 and (Driver1Id='{0}' or Driver2Id='{0}')", curUser.UserId));
                            
                            foreach (YueYePlat.Model.vehicledelivery t in deliveryList)
                            {
                                List<YueYePlat.Model.deliveryorder> curOrderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId ='{0}'", t.DeliveryId));
                                
                                for (int i = 0; i < curOrderList.Count; i++)
                                {
                                    
                                    curOrderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrderList[i].DeliveryOrderId));
                                    curOrderList[i].VehicleName = t.VehicleId;
                                    curOrderList[i].Driver1Id = t.Driver1Id;
                                    curOrderList[i].Driver2Id = t.Driver2Id;
                                    for (int j = 0; j < curOrderList[i].ProductList.Count; j++)
                                    {
                                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                        List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                                        YueYePlat.Model.productinfo p = productList.Find(s => s.ProductId == curOrderList[i].ProductList[j].ProductId);
                                        curOrderList[i].ProductList[j].ProductId = p != null ? p.ProductName : "";
                                        DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                    }
                                }
                                deliveryOrderList.AddRange(curOrderList);
                            }
                        }

                        model.UserData = deliveryOrderList;
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

                    LogHelper.WriteLog("GetCurDeliveryOrderForDriver", ex);
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