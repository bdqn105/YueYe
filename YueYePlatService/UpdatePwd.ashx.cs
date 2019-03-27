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
    /// UpdatePwd 的摘要说明
    /// </summary>
    public class UpdatePwd : IHttpHandler, IRequiresSessionState
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
                        string oldPwd = "";
                        string newPwd = "";
                        if (strData.Length >= 2)
                        {
                            oldPwd = strData[0];
                            newPwd = strData[1];
                            YueYePlat.Model.usersinfo curUser = (YueYePlat.Model.usersinfo)model.UserInfo;
                            if (oldPwd.Equals(curUser.UserPassword))
                            {
                                DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                                curUser.UserPassword = newPwd;
                                if(new YueYePlat.BLL.usersinfo().Update(curUser))
                                {
                                    model = new HandleModel();
                                    model.ResultMsg = "密码更新成功！";
                                    model.IsSuccess = true;
                                    string resJson = JsonConvert.SerializeObject(model);
                                    context.Response.ContentType = "text/plain";
                                    context.Response.Write(resJson);
                                }
                                else
                                {
                                    model = new HandleModel();
                                    model.ResultMsg = "密码更新失败！";
                                    model.IsSuccess = false;
                                    string resJson = JsonConvert.SerializeObject(model);
                                    context.Response.ContentType = "text/plain";
                                    context.Response.Write(resJson);
                                }
                            }
                            else
                            {
                                model = new HandleModel();
                                model.ResultMsg = "原密码不正确。";
                                model.IsSuccess = false;
                                string resJson = JsonConvert.SerializeObject(model);
                                context.Response.ContentType = "text/plain";
                                context.Response.Write(resJson);
                            }
                        }
                        else
                        {
                            model = new HandleModel();
                            model.ResultMsg = "传递到服务器的参数有误！";
                            model.IsSuccess = false;
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