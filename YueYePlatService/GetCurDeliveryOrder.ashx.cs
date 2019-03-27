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
    /// GetCurProductDelivery 的摘要说明
    /// </summary>
    public class GetCurDeliveryOrder : IHttpHandler, IRequiresSessionState
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
                            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList("ifEnd=0");
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
                                StringBuilder sb = new StringBuilder();
                                sb.Append("明细：");
                                for (int j = 0; j < curOrderList[i].ProductList.Count; j++)
                                {
                                    DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                    List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                                    YueYePlat.Model.productinfo p = productList.Find(s => s.ProductId == curOrderList[i].ProductList[j].ProductId);
                                    curOrderList[i].ProductList[j].ProductId = p != null ? p.ProductName : "";
                                    sb.Append(p.ProductName + "  " + (curOrderList[i].ProductList[j].Quantity == null ? "0" : curOrderList[i].ProductList[j].Quantity.ToString()) + "/" + (curOrderList[i].ProductList[j].Weight == null ? "0" : curOrderList[i].ProductList[j].Weight.ToString()) + "；");
                                    DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                }
                                curOrderList[i].Detail = sb.ToString();
                                //费用
                                if (curOrderList[i].PaymentMethod == "现付")
                                {
                                    StringBuilder sbFee = new StringBuilder();
                                    sbFee.Append("费用：");
                                    decimal totalorderfee = 0;
                                    List<YueYePlat.Model.deliveryorderfee> orderfeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrderList[i].DeliveryOrderId));
                                    for (int j = 0; j < orderfeeList.Count; j++)
                                    {
                                        if (orderfeeList[j].IsShow == true)
                                        {
                                            orderfeeList[j].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[j].FeeTypeId))[0].FeeTypeName;
                                            sbFee.Append(orderfeeList[j].FeetypeName + ":" + orderfeeList[j].Fee + ";");
                                            totalorderfee += orderfeeList[j].Fee;
                                        }
                                    }

                                    sbFee.Append("代收款" + ":" + curOrderList[i].Amount + ";");
                                    totalorderfee = decimal.Parse((totalorderfee + curOrderList[i].Amount).ToString());
                                    sbFee.Append("总费用" + ":" + totalorderfee + ";");
                                    curOrderList[i].Orderfee = sbFee.ToString();
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