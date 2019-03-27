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
    /// GetCurDeliveryGPSTempData 的摘要说明
    /// </summary>
    public class GetDeliveryGPSTempData : IHttpHandler, IRequiresSessionState
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
                                    List<YueYePlat.Model.deliverycurgpsinfo> gpsList = new YueYePlat.BLL.deliverycurgpsinfo().GetModelList(String.Format("DeliveryId='{0}' order by Id desc", productdeliveryList[0].DeliveryId));
                                    List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}' order by  Id desc", productdeliveryList[0].DeliveryId));

                                    List<YueYePlat.Model.deliverycurgyroinfo> gyrList = new YueYePlat.BLL.deliverycurgyroinfo().GetModelList(String.Format("DeliveryId='{0}' order by  Id desc", productdeliveryList[0].DeliveryId));
                                    List<YueYePlat.Model.vehiclepointoff> onoffList = new YueYePlat.BLL.vehiclepointoff().GetModelList(String.Format("DeliveryId='{0}' order by  Id desc", productdeliveryList[0].DeliveryId));
                                    List<YueYePlat.Model.vehicledoors> doorsList = new YueYePlat.BLL.vehicledoors().GetModelList(String.Format("DeliveryId='{0}' order by  Id desc", productdeliveryList[0].DeliveryId));
                                    //if(gpsList.Count>0)
                                    //{
                                    string strGpsList = JsonConvert.SerializeObject(gpsList);
                                    string strTempList = JsonConvert.SerializeObject(tempList);
                                    //string strHumiList = JsonConvert.SerializeObject(humiList);
                                    string strGyrList = JsonConvert.SerializeObject(gyrList);
                                    string strOnOffList = JsonConvert.SerializeObject(onoffList);
                                    string strDoorsList = JsonConvert.SerializeObject(doorsList);
                                    ht.Add("GPSinfo", strGpsList);
                                    ht.Add("TempInfo", strTempList);
                                    ht.Add("GyrInfo", strGyrList);
                                    ht.Add("OnOffInfo", strOnOffList);
                                    ht.Add("DoorsInfo", strDoorsList);
                                    //}
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