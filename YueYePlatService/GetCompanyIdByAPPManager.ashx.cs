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
    /// GetCompanyIdByAPPManager 的摘要说明
    /// </summary>
    public class GetCompanyIdByAPPManager : IHttpHandler, IRequiresSessionState
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
                        DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                        List<YueYePlat.Model.logiscompanyinfo> logisList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID = '{0}'", ((YueYePlat.Model.usersinfo)model.UserInfo).CompanyId));
                        if (logisList.Count > 0)
                        {
                            DbHelperMySQL.UpdateConnectionString(logisList[0].CompanyDBName);
                            YueYePlat.Model.usersinfo curUser = (YueYePlat.Model.usersinfo)model.UserInfo;
                            string logisID = curUser.CompanyId;
                            model.UserData = logisID;
                            model.IsSuccess = true;
                            model.ResultMsg = "公司信息获取成功！";
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

                    LogHelper.WriteLog("GetExceptionTypeException", ex);
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