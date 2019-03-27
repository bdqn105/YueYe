using Maticsoft.DBUtility;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YueYePlatService
{
    /// <summary>
    /// GetExceptionByOrderID 的摘要说明
    /// </summary>
    public class GetExceptionByOrderID : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType.ToLower().Equals("post"))
            {
                context.Response.Cache.SetNoStore();
                context.Response.Clear();
                try
                {
                    HandleModel model = Common.ValidateToken(context);
                    if (model != null)
                    {
                        string[] strData = model.UserData.ToString().Split(';');
                        string orderId = "";
                        string logisID = "";
                        if (strData.Length >= 2)
                        {
                            orderId = strData[0];
                            logisID = strData[1];
                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                            List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                            if (logisList.Count > 0)
                            {
                                Hashtable ht = new Hashtable();

                                DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                List<YueYePlat.Model.deliveryorder> productdeliveryList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", orderId));
                                if (productdeliveryList.Count > 0)
                                {
                                    List<YueYePlat.Model.exceptioninfo> exList = new YueYePlat.BLL.exceptioninfo().GetModelList(String.Format("DeliverId='{0}' order by Id desc", productdeliveryList[0].DeliveryId));
                                    for (int i = 0; i < exList.Count; i++)
                                    {
                                        YueYePlat.Model.exceptiontype extype = new YueYePlat.BLL.exceptiontype().GetModel(int.Parse(exList[i].ExceptionType));
                                        exList[i].ExceptionType = extype.Typename;
                                    }
                                    if (exList.Count > 0)
                                    {
                                        string strExList = JsonConvert.SerializeObject(exList);
                                        ht.Add("Exinfo", strExList);
                                    }
                                }
                                model.UserData = ht;
                            }

                        }
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
                catch(Exception ex)
                {
                    LogHelper.WriteLog("GetExceptionByOrderId",ex);
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