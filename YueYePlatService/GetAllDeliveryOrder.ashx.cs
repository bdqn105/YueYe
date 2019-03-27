using Maticsoft.DBUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YueYePlatService
{
    /// <summary>
    /// GetAllDeliveryOrder 的摘要说明
    /// </summary>
    public class GetAllDeliveryOrder : IHttpHandler, IRequiresSessionState
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
                        string months = ConfigurationManager.AppSettings["his_months"].ToString();
                        List<YueYePlat.Model.deliveryorder> deliveryOrderList = new List<YueYePlat.Model.deliveryorder>();
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logistouser> logistouserlist = new YueYePlat.BLL.logistouser().GetModelList(String.Format("UserID='{0}'", ((YueYePlat.Model.usersinfo)model.UserInfo).UserId));
                        string logises = "";
                        foreach (YueYePlat.Model.logistouser t in logistouserlist)
                        {
                            logises += String.Format(",'{0}'", t.LogisCompanyID);
                        }
                        if (logises.Length > 0) logises = logises.Substring(1);
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID in ({0})", logises));
                        foreach (YueYePlat.Model.logiscompanyinfo m in logisList)
                        {
                            DbHelperMySQL.UpdateConnectionString(m.CompanyDBName);
                            //查询未完结的运输配送单号
                            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("BeginTime>DATE_ADD(NOW(),INTERVAL -{0} MONTH)", months));
                            string deliveries = "";
                            foreach (YueYePlat.Model.vehicledelivery t in deliveryList)
                            {
                                deliveries += String.Format(",'{0}'", t.DeliveryId);
                            }
                            if (deliveries.Length > 0) deliveries = deliveries.Substring(1);
                            else deliveries = "''";
                            List<YueYePlat.Model.deliveryorder> curOrderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("clientID='{0}' and DeliveryId in ({1})", ((YueYePlat.Model.usersinfo)model.UserInfo).UserId, deliveries));
                            for (int i = 0; i < curOrderList.Count; i++)
                            {
                                DbHelperMySQL.UpdateConnectionString(m.CompanyDBName);
                                curOrderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrderList[i].DeliveryOrderId));
                                for (int j = 0; j < curOrderList[i].ProductList.Count; j++)
                                {
                                    DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                    List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                                    YueYePlat.Model.productinfo p = productList.Find(s => s.ProductId == curOrderList[i].ProductList[j].ProductId);
                                    curOrderList[i].ProductList[j].ProductId = p != null ? p.ProductName : "";
                                }
                            }
                            deliveryOrderList.AddRange(curOrderList);
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
                    LogHelper.WriteLog("GetHisDeliveryOrder", ex);
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