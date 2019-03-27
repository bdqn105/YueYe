using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YueYePlatService
{
    /// <summary>
    /// LoginByPwdForAPPManager 的摘要说明
    /// </summary>
    public class LoginByPwdForAPPManager : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType.ToLower().Equals("post"))
            {
                try
                {
                    context.Response.Cache.SetNoStore();
                    context.Response.Clear();
                    Stream stream = context.Request.InputStream;
                    StreamReader reader = new StreamReader(stream);
                    string strJson = reader.ReadLine();
                    HandleModel model = JsonConvert.DeserializeObject<HandleModel>(strJson);
                    int versionCode = 0;
                    try
                    {
                        versionCode = int.Parse(model.UserData.ToString());
                    }
                    catch (Exception ex)
                    { }
                    YueYePlat.Model.usersinfo usersinfo = JsonConvert.DeserializeObject<YueYePlat.Model.usersinfo>(model.UserInfo.ToString());
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueYePlatDB");
                    List<YueYePlat.Model.usersinfo> userlist = new YueYePlat.BLL.usersinfo().GetModelList(usersinfo.UserId, usersinfo.UserPassword);
                    if (userlist.Count > 0)
                    {
                        usersinfo = userlist[0];
                        List<YueYePlat.Model.userstypeinfo> utypelist = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", usersinfo.UserTypeId));

                        if (utypelist.Count > 0 && utypelist[0].UserTypeName.Equals("APP管理员"))
                        {
                            model.UserInfo = usersinfo;
                            context.Session["userinfo"] = usersinfo;
                            context.Session["deviceid"] = model.DeviceId;
                            YueYePlat.Model.usertoken token;
                            List<YueYePlat.Model.usertoken> tokenList = new YueYePlat.BLL.usertoken().GetModelList(String.Format("userId='{0}' and deviceId='{1}'", usersinfo.UserId, model.DeviceId));
                            if (tokenList.Count > 0)
                            {
                                token = tokenList[0];
                                token.SessionId = context.Session.SessionID;
                                token.LastLoginTime = DateTime.Now;
                                token.SoftVersion = versionCode;
                                new YueYePlat.BLL.usertoken().Update(token);
                            }
                            else
                            {
                                token = new YueYePlat.Model.usertoken();
                                token.DeviceId = model.DeviceId;
                                token.UserId = usersinfo.UserId;
                                token.SessionId = context.Session.SessionID;
                                token.CreateDate = DateTime.Now;
                                token.LastLoginTime = DateTime.Now;
                                token.SoftVersion = versionCode;
                                new YueYePlat.BLL.usertoken().Add(token);
                            }
                            List<YueYePlat.Model.logistouser> logistuserList = new YueYePlat.BLL.logistouser().GetModelList(String.Format("UserId='{0}'", usersinfo.UserId));
                            model.UserData = logistuserList;
                            context.Session["Token"] = token;
                            model.IsSuccess = true;
                            model.ResultMsg = "登录成功！";
                        }
                        else
                        {
                            model.IsSuccess = false;
                            model.ResultMsg = "请检查用户名后，重新登录！";
                        }
                    }
                    else
                    {
                        model.IsSuccess = false;
                        model.ResultMsg = "用户名或者密码出错，请重新登录！";
                    }
                    context.Response.Write(JsonConvert.SerializeObject(model));

                }
                catch (Exception ex)
                {

                    LogHelper.WriteLog("LoginByPwdForAPPManager", ex);
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