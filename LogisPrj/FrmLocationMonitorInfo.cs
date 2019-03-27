using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogisPrj
{
    public partial class FrmLocationMonitorInfo : Form
    {
        YingYanElem elem;
        YingyanStaypoint stayPoint;
        YingyanDrivingbehavior behavior;
        double end_lng;
        double end_lat;
        double start_lng;
        double start_lat;
        double lastLng=0;
        double lastLat=0;
        List<YueYePlat.Model.deliverycurgpsinfo> lastGpsList;
        public string strDeliverId;
        public YueYePlat.Model.usersinfo usersInfo;       
        static FrmLocationMonitorInfo instance;
        public string tabPageTitle = "";     
        public FrmLocationMonitorInfo()
        {
            InitializeComponent();
        }
        public static FrmLocationMonitorInfo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmLocationMonitorInfo();
            }
            return instance;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void FrmLocationMonitor_Load(object sender, EventArgs e)
        {
            if (strDeliverId != "")
            {
                txtDeliveryId.Text = strDeliverId;
            }
            //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            //List<YueYePlat.Model.logiscompanyinfo> companyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyID='{0}'",usersInfo.CompanyId));
            //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
            InitComponent();
              
        }

        private void InitComponent()
        {
            
        }
        public void LoadPoint(object obj)
        {
            PointParams p = (PointParams)obj;
            loadDelegate loadde = new loadDelegate(LoadElem);
            loadde.Invoke(p.funcName, p.point, p.nextPoint);
        }
        public delegate void loadDelegate(string funName, YingYanPoint point, YingYanPoint nextPoint);
        public void LoadElem(string funName,YingYanPoint point, YingYanPoint nextPoint)
        {
            webBrowser1.Document.InvokeScript(funName, new object[] { point.longitude, point.latitude, nextPoint.longitude, nextPoint.latitude });
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {           
            if (elem.points.Count > 0)
            {
                YingYanPoint[] strPoints = elem.points.ToArray();
                int count = elem.points.Count;
                int page=elem.total %count==0?elem.total/count:elem.total /count+1;
                webBrowser1.Document.InvokeScript("GetEndPoint", new object[] { end_lng, end_lat });
                webBrowser1.Document.InvokeScript("GetStartPoint", new object[] { start_lng, start_lat });
              //  webBrowser1.Document.InvokeScript("GetPoints2", new object[] { strPoints });
                webBrowser1.Document.InvokeScript("GetPointsTotallCount", new object[] { count });
                for (int i = 0; i < elem.points.Count; i++)
                {
                    string loc_time = GetTime(elem.points[i].loc_time.ToString()).ToString();
                    string speed = elem.points[i].speed.ToString("f1");
                    //webBrowser1.Document.InvokeScript("GetPoints", new object[] { elem.points[i].longitude, elem.points[i].latitude });
                    webBrowser1.Document.InvokeScript("theLocation", new object[] { strDeliverId, elem.points[i].longitude, elem.points[i].latitude, speed, loc_time });
                    //if (i < elem.points.Count - 1)
                    //{
                    //    //Thread th=new Thread(new ParameterizedThreadStart(LoadPoint));
                    //    //PointParams p = new PointParams("DrawLine",elem.points[i],elem.points[i+1]);
                    //    //th.Start(p);
                    //    //webBrowser1.Document.InvokeScript("DrawLine", new object[] { elem.points[i].longitude, elem.points[i].latitude, elem.points[i + 1].longitude, elem.points[i + 1].latitude });
                    //}
                    //if (elem.points.Count % 500 == 0)
                    //{
                    //    Thread.Sleep(2000);
                    //}
                }
                //int pointCount = 0;
                //for (int pageIndex = 1; pageIndex <= page; pageIndex++)
                //{
                //    for (int i = pointCount; i < elem.points.Count*pageIndex; i++)
                //    {                        
                //        string loc_time = GetTime(elem.points[i].loc_time.ToString()).ToString();
                //        string speed = elem.points[i].speed.ToString("f1");
                //        webBrowser1.Document.InvokeScript("GetPoints", new object[] { elem.points[i].longitude, elem.points[i].latitude });
                //        webBrowser1.Document.InvokeScript("theLocation", new object[] { strDeliverId, elem.points[i].longitude, elem.points[i].latitude, speed, loc_time });
                //        webBrowser1.Document.InvokeScript("GetPointsTotallCount", new object[] { count });
                //        if (i < elem.points.Count - 1)
                //        {
                //            webBrowser1.Document.InvokeScript("DrawLine", new object[] { elem.points[i].longitude, elem.points[i].latitude, elem.points[i + 1].longitude, elem.points[i + 1].latitude });
                //        }
                //        pointCount++;
                //    }                    
                //}               
            }
            if (stayPoint.staypoint_num > 0)
            {
                for (int i = 0; i < stayPoint.staypoint_num; i++)
                {
                    webBrowser1.Document.InvokeScript("GetStayTime", new object[] { stayPoint.stay_points[i].Start_time, stayPoint.stay_points[i].End_time, stayPoint.stay_points[i].Duration, stayPoint.stay_points[i].stay_point.longitude, stayPoint.stay_points[i].stay_point.latitude });
                }
            }
            if (behavior.speeding_num > 0)
            {
                for (int i = 0; i < behavior.speeding_num; i++)
                {
                    webBrowser1.Document.InvokeScript("GetSpeeding", new object[] { behavior.speeding[i].speeding_points.longitude, behavior.speeding[i].speeding_points.latitude, behavior.speeding[i].speeding_points.loc_time, behavior.speeding[i].speeding_points.actual_speed, behavior.speeding[i].speeding_points.limit_speed });
                }
            }
            if (behavior.harsh_breaking_num > 0)
            {
                for (int i = 0; i < behavior.harsh_breaking_num; i++)
                {
                    webBrowser1.Document.InvokeScript("GetBreaking", new object[] { behavior.harsh_breaking[i].longitude, behavior.harsh_breaking[i].latitude, behavior.harsh_breaking[i].loc_time, behavior.harsh_breaking[i].initial_speed, behavior.harsh_breaking[i].end_speed });
                }
            }
            if (behavior.harsh_acceleration_num > 0)
            {
                for (int i = 0; i < behavior.harsh_acceleration_num; i++)
                {
                    webBrowser1.Document.InvokeScript("GetAcceleration", new object[] { behavior.harsh_acceleration[i].longitude, behavior.harsh_acceleration[i].latitude, behavior.harsh_acceleration[i].loc_time, behavior.harsh_acceleration[i].initial_speed, behavior.harsh_acceleration[i].end_speed });
                }
            }
            if (behavior.harsh_steering_num > 0)
            {
                for (int i = 0; i < behavior.harsh_steering_num; i++)
                {
                    webBrowser1.Document.InvokeScript("GetSteering", new object[] { behavior.harsh_steering[i].longitude, behavior.harsh_steering[i].latitude, behavior.harsh_steering[i].loc_time, behavior.harsh_steering[i].turn_type, behavior.harsh_steering[i].speed });
                }
            }

            if (lastLng != 0 && lastLat != 0&&lastGpsList!=null)
            {
                webBrowser1.Document.InvokeScript("GetLastPoint",new object[] {strDeliverId, lastLng,lastLat,lastGpsList[0].CurrentTime,lastGpsList[0].Speed });
            }

        }
        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式</returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
        /// <summary>
        /// 时间戳转换成时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string orderStartTime = "";
            string orderEndTime = "";   
            if (txtDeliveryId.Text .Trim() != "" &&    dTEndTime.Value > dTStartTime.Value )
            {
                List<YueYePlat.Model.deliverycurgpsinfo> gpsList = new YueYePlat.BLL.deliverycurgpsinfo().GetModelList(String.Format ("DeliveryId='{0}' order by currentTime ASC LIMIT 1",strDeliverId));
                if(gpsList.Count>0)
                {
                    orderStartTime = gpsList[0].CurrentTime.ToString();
                }
                List<YueYePlat.Model.deliverycurgpsinfo> gps2List = new YueYePlat.BLL.deliverycurgpsinfo().GetModelList(String.Format("DeliveryId='{0}' order by currentTime DESC LIMIT 1", strDeliverId));
                if (gps2List.Count > 0)
                {
                    orderEndTime = gps2List[0].CurrentTime.ToString();
                }
                string ak = "YPtpaHFhtN4m891K01wbSD4P1nrtmoe8";
                string service_id = "202455";
                string entity_name = strDeliverId;
                DateTime dtstart = dTStartTime.Value;
                DateTime dtEnd = dTEndTime.Value;
                int pageIndex = 1;
                string startTime = ConvertDateTimeInt(dtstart).ToString ();
                string endTime = ConvertDateTimeInt( dtEnd).ToString();
                string result = BDYingYanAPIHelper.Gettrack(ak, service_id, entity_name, startTime, endTime,pageIndex).ToString();             
                elem = JsonConvert.DeserializeObject<YingYanElem>(result);
                if (elem.end_point != null)
                {
                    end_lng = elem.end_point.longitude;
                    end_lat = elem.end_point.latitude;
                }
                if (elem.start_point != null)
                {
                    start_lat = elem.start_point.latitude;
                    start_lng = elem.start_point.longitude;
                }
                if (elem.status == 0)
                {
                    if (elem.points.Count > 0)
                    {
                        //判断分几页
                        int page = elem.total % elem.size == 0 ? elem.total / elem.size : elem.total / elem.size + 1;
                        if (page > 1)
                        {
                            pageIndex++;
                            for (int i = pageIndex; i <= page; i++)
                            {
                                string strResult = BDYingYanAPIHelper.Gettrack(ak, service_id, entity_name, startTime, endTime, i).ToString();
                                YingYanElem addelem = JsonConvert.DeserializeObject<YingYanElem>(strResult);
                                for (int j = 0; j < addelem.points.Count; j++)
                                {
                                    elem.points.Add(addelem.points[j]);
                                }
                            }
                        }
                        string strstayPoint = BDYingYanAPIHelper.GetStayPoint(ak, service_id, entity_name, startTime, endTime).ToString();
                        stayPoint = JsonConvert.DeserializeObject<YingyanStaypoint>(strstayPoint);
                        Debug.WriteLine(stayPoint.message);
                        string strDrivingBehavior = BDYingYanAPIHelper.GetDrivingbehavior(ak, service_id, entity_name, startTime, endTime).ToString();
                        behavior = JsonConvert.DeserializeObject<YingyanDrivingbehavior>(strDrivingBehavior);
                        Debug.WriteLine(behavior.message);
                        //MessageBox.Show("该车辆配送过程中，从" + behavior.start_point.address + "到" + behavior.end_point.address + ",超速:" + behavior.harsh_breaking_num + "次；急停车：" + behavior.harsh_breaking_num + "次；急加速：" + behavior.harsh_acceleration_num + "次；急转弯：" + behavior.harsh_steering_num + "次");
                        string str_url = Application.StartupPath + "\\LocationMonitor.html";
                        Uri url = new Uri(str_url);
                        webBrowser1.Url = url;
                        webBrowser1.ObjectForScripting = this;                                                 
                    }
                    else
                    {
                        if (MessageBox.Show("该订单在当前时间范围没有对应的历史轨迹，请核查！") == DialogResult.OK)
                        {
                            if (orderStartTime != "" && orderEndTime != "")
                            {                               
                                MessageBox.Show(" 您可以在" + orderStartTime + " - " + orderEndTime+"时间内进行查询!");
                            }
                        }                     
                    }                    
                }
                else
                {
                    if (elem.message.Contains("entity_name"))
                    {
                        MessageBox.Show("没有查询到该订单的轨迹信息，请核查！");
                    }
                    else if (elem.status == 2)
                    {
                        MessageBox.Show("请设置合理的时间范围，起始和结束时间必须在24小时之内");
                    }
                }               
            }
            else
            {
                if (txtDeliveryId.Text.Trim() == "")
                {
                    MessageBox.Show("请输入你要查询的配送编号！");
                }
                else if (dTStartTime.Value > dTEndTime.Value)
                {
                    MessageBox.Show("起始时间不能超过结束时间！");
                }              
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            
            lastGpsList = new YueYePlat.BLL.deliverycurgpsinfo().GetModelList(String.Format("DeliveryId='{0}' order by currentTime DESC LIMIT 1", strDeliverId));
            if (lastGpsList.Count > 0)
            {
                lastLng = double.Parse ( lastGpsList[0].Longitude.ToString ());
                lastLat = double.Parse(lastGpsList[0].Latitude.ToString());
                string str_url = Application.StartupPath + "\\LocationMonitor.html";
                Uri url = new Uri(str_url);
                webBrowser1.Url = url;
                webBrowser1.ObjectForScripting = this;
            }
        }
    }
}
