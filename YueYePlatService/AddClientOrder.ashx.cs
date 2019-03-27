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
    /// AddClientOrder 的摘要说明
    /// </summary>
    public class AddClientOrder : IHttpHandler, IRequiresSessionState
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
                        string[] strData = model.UserData.ToString().Split(';');
                        string logisID = "";
                        string strJson = "";
                        if (strData.Length >= 2)
                        {
                            logisID = strData[0];
                            strJson = strData[1];
                            DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                            List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", logisID));
                            if (logisList.Count > 0)
                            {
                                DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                                try
                                {
                                    YueYePlat.Model.clientorder order = JsonConvert.DeserializeObject<YueYePlat.Model.clientorder>(strJson);
                                    List<YueYePlat.Model.clientorder> orderList = new YueYePlat.BLL.clientorder().GetModelList(String.Format("clientorderid like '{0}%' order by clientorderid desc", "C" + DateTime.Now.ToString("yyMMdd")));
                                    if (orderList.Count == 0)
                                    {
                                        order.ClientOrderId = "C" + DateTime.Now.ToString("yyMMdd") + "0001";
                                    }
                                    else
                                    {
                                        string orderId = "1" + orderList[0].ClientOrderId.Substring(7, 4);
                                        order.ClientOrderId = "C" + DateTime.Now.ToString("yyMMdd") + (int.Parse(orderId) + 1).ToString().Substring(1);
                                    }
                                    if (new YueYePlat.BLL.clientorder().Add(order))
                                    {
                                        model = new HandleModel();
                                        model.IsSuccess = true;
                                        model.ResultMsg = "添加成功";
                                        string resJson = JsonConvert.SerializeObject(model);
                                        context.Response.ContentType = "text/plain";
                                        context.Response.Write(resJson);
                                    }
                                    else
                                    {
                                        model = new HandleModel();
                                        model.IsSuccess = false;
                                        model.ResultMsg = "添加失败";
                                        string resJson = JsonConvert.SerializeObject(model);
                                        context.Response.ContentType = "text/plain";
                                        context.Response.Write(resJson);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    model = new HandleModel();
                                    model.IsSuccess = false;
                                    model.ResultMsg = "出现异常！";
                                    string resJson = JsonConvert.SerializeObject(model);
                                    context.Response.ContentType = "text/plain";
                                    context.Response.Write(resJson);
                                }                                
                            }
                            else
                            {
                                model.IsSuccess = false;
                                model.ResultMsg = "您未在物流公司注册";
                                string resJson = JsonConvert.SerializeObject(model);
                                context.Response.ContentType = "text/plain";
                                context.Response.Write(resJson);
                            }
                        }
                        else
                        {
                            model.IsSuccess = false;
                            model.ResultMsg = "你提供的参数有误！";
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
                    LogHelper.WriteLog("GetDeliveryGPSTempData", ex);
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