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
    /// ChargeBackDeliveryForDriver 的摘要说明
    /// </summary>
    public class ChargeBackDeliveryForDriver : IHttpHandler, IRequiresSessionState
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
                            List<YueYePlat.Model.vehicledelivery> olddeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("(driver1id='{0}' or driver2id='{0}') and IfEnd=false", curUser.UserId));
                            if (olddeliveryList.Count >0)
                            {
                                YueYePlat.Model.vehicledelivery curDelivery = olddeliveryList[0];
                                curDelivery.IfChargeback = true;
                                curDelivery.IfEnd = true;
                                new YueYePlat.BLL.vehicledelivery().Update(curDelivery);
                                curDelivery.IfChargeback = false;
                                curDelivery.Driver1Id = null;
                                curDelivery.Driver2Id = null;
                                curDelivery.IfEnd = false;
                                if (new YueYePlat.BLL.vehicledelivery().Add(curDelivery))
                                {
                                    model.ResultMsg = "退单成功！";
                                    model.UserData = null;
                                    model.IsSuccess = true;
                                }
                            }
                            else
                            {
                                model.ResultMsg = "此驾驶员没有订单！";
                                model.UserData = null;
                                model.IsSuccess = false;
                            }
                        }
                        else
                        {
                            model.ResultMsg = "此物流公司不存在！";
                            model.UserData = null;
                            model.IsSuccess = false;
                        }

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

                    LogHelper.WriteLog("AcceptDeliveryOrder", ex);
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