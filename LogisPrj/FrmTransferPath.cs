using Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTransferPath : Form
    {

        static FrmTransferPath instance;
        public string tabPageTitle = "";
        public string strDeliveryId = "";
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public string strOrigin = "";
        public string strDestionation = "";
        string point = "";
        List<YueYePlat.Model.deliverypath> pathList;
        public static string lng = "";
        public static string lat = "";
        public static string destionation = "";
        bool ifHasVia = false;
        List<YueYePlat.Model.deliverypath> deliveryPathList;
        //private string lng;
        //private string lat;
        public FrmTransferPath()
        {
            InitializeComponent();
        }
        public static FrmTransferPath getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmTransferPath();
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

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            FrmBaiduMap map = new FrmBaiduMap();
            map.Text = "地图展示";
            if (map.ShowDialog() == DialogResult.OK)
            {
                txtOrigin.Text = FrmBaiduMap.destionation;
                lblOriginLng.Text = FrmBaiduMap.lng;
                lblOriginLat.Text = FrmBaiduMap.lat;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FrmBaiduMap map = new FrmBaiduMap();
            map.Text = "地图展示";
            if (map.ShowDialog() == DialogResult.OK)
            {
                txtDestional.Text = FrmBaiduMap.destionation;
                lblDestinationLng.Text = FrmBaiduMap.lng;
                lblDestionationLat.Text = FrmBaiduMap.lat;
            }
        }
        private void btnSetPath_Click(object sender, EventArgs e)
        {

            if (txtOrigin.Text.Trim() != "" && txtDestional.Text.Trim() != "")
            {
                pathList = new List<YueYePlat.Model.deliverypath>();
                if (txtOrigin.Text.Trim() != "")
                {
                    YueYePlat.Model.deliverypath path = new YueYePlat.Model.deliverypath();
                    path.LocationSign = "起点";
                    path.DeliverId = txtDeliveryId.Text.Trim().Substring(0, txtDeliveryId.Text.Trim().Length - 2);
                    path.OrderNumber = int.Parse(txtDeliveryId.Text.Trim().Substring(txtDeliveryId.Text.Trim().Length - 2));
                    path.Latitude = double.Parse(lblOriginLat.Text);
                    path.Longitude = double.Parse(lblOriginLng.Text);
                    path.LocationName = txtOrigin.Text;
                    pathList.Add(path);
                }
                if (txtDestional.Text.Trim() != "")
                {
                    YueYePlat.Model.deliverypath path = new YueYePlat.Model.deliverypath();
                    path.LocationSign = "终点";
                    path.DeliverId = txtDeliveryId.Text.Trim().Substring(0, txtDeliveryId.Text.Trim().Length - 2);
                    path.OrderNumber = int.Parse(txtDeliveryId.Text.Trim().Substring(txtDeliveryId.Text.Trim().Length - 2));
                    path.Latitude = double.Parse(lblDestionationLat.Text);
                    path.Longitude = double.Parse(lblDestinationLng.Text);
                    path.LocationName = txtDestional.Text;
                    pathList.Add(path);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pathList;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = false;
                }
                MessageBox.Show("您可以拖动路线进行路线设置！");
                string str_url = Application.StartupPath + "\\DeliveryPath.html";
                Uri url = new Uri(str_url);
                webBrowser1.Url = url;
                webBrowser1.ObjectForScripting = this;
            }
            else
            {
                MessageBox.Show("请先输入起点和终点信息！");
            }

            //if (txtOrigin.Text != "" && txtDestional.Text != "")
            //{
            //    string str_url = Application.StartupPath + "\\DeliveryPath.html";
            //    Uri url = new Uri(str_url);
            //    webBrowser1.Url = url;
            //    webBrowser1.ObjectForScripting = this;
            //}
            //else
            //{
            //    MessageBox.Show("请设置起点和终点！");
            //}

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Document.InvokeScript("GetStartlnglat",new object[] { txtOrigin.Text });
            //webBrowser1.Document.InvokeScript("GetEndlnglat",new object[] { txtDestional.Text });
            if (deliveryPathList == null) deliveryPathList = new List<YueYePlat.Model.deliverypath>();
            if (deliveryPathList.Count > 0)
            {
                for (int i = 0; i < deliveryPathList.Count; i++)
                {
                    if (deliveryPathList[i].LocationSign.ToString() == "起点")
                    {          
                        webBrowser1.Document.InvokeScript("theOrigin", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude });
                    }
                    else if (deliveryPathList[i].LocationSign.ToString() == "终点")
                    {                      
                      
                        webBrowser1.Document.InvokeScript("theDestination", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude ,ifHasVia});
                    }
                    else if (deliveryPathList[i].LocationSign.ToString() == "途经点")
                    {
                        webBrowser1.Document.InvokeScript("theViaLocation", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude });
                    }
                }
            }
            else
            {                
                webBrowser1.Document.InvokeScript("theLocation", new object[] { lblOriginLng.Text, lblOriginLat.Text, lblDestinationLng.Text, lblDestionationLat.Text });
            }
           
        }

        private void FrmTransferPath_Load(object sender, EventArgs e)
        {
            try
            {
                
                lblDestinationLng.Text = "";
                lblDestionationLat.Text = "";
                lblOriginLat.Text = "";
                lblOriginLng.Text = "";
                lblViaLat.Text = "";
                lblViaLng.Text = "";
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                dataGridView1.AutoGenerateColumns = false;
                if (strDeliveryId != "")
                {
                    txtDeliveryId.Text = strDeliveryId;
                    List<YueYePlat.Model.vehicledelivery> deliveryPathList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", txtDeliveryId.Text.Substring(0, txtDeliveryId.Text.Trim().Length - 2)));
                    if (deliveryPathList.Count > 0)
                    {
                        txtOrigin.Text = deliveryPathList[0].Origin;
                        string str_url = Application.StartupPath + "\\DeliveryPath.html";
                        Uri url = new Uri(str_url);
                        webBrowser1.Url = url;
                        webBrowser1.ObjectForScripting = this;
                    }

                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
        public void getMarker(string marker)
        {
            // txtMark.Text = marker;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            deliveryPathList = new YueYePlat.BLL.deliverypath().GetModelList(String.Format("DeliverId='{0}'&& OrderNumber='{1}'", txtDeliveryId.Text.Substring(0, txtDeliveryId.Text.Trim().Length - 2), txtDeliveryId.Text.Substring(txtDeliveryId.Text.Trim().Length - 2)));
            if (deliveryPathList.Count > 0)
            {                
                for (int i = 0; i < deliveryPathList.Count; i++)
                {
                    if (deliveryPathList[i].LocationSign.ToString() == "起点")
                    {
                        txtOrigin.Text = deliveryPathList[i].LocationName;
                        lblOriginLat.Text = deliveryPathList[i].Latitude.ToString();
                        lblOriginLng.Text = deliveryPathList[i].Longitude.ToString();
                        //webBrowser1.Document.InvokeScript("theOrigin", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude });
                    }
                    else if (deliveryPathList[i].LocationSign.ToString() == "终点")
                    {
                        txtDestional.Text = deliveryPathList[i].LocationName;
                        lblDestionationLat.Text = deliveryPathList[i].Latitude.ToString();
                        lblDestinationLng.Text = deliveryPathList[i].Longitude.ToString();
                       // webBrowser1.Document.InvokeScript("theDestination", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude });
                    }
                    else if (deliveryPathList[i].LocationSign.ToString() == "途经点")
                    {
                        ifHasVia = true;
                        //webBrowser1.Document.InvokeScript("theViaLocation", new object[] { deliveryPathList[i].Longitude, deliveryPathList[i].Latitude });
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = deliveryPathList;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = false;
                }
                string str_url = Application.StartupPath + "\\DeliveryPathGet.html";
                Uri url = new Uri(str_url);
                webBrowser1.Url = url;
                webBrowser1.ObjectForScripting = this;
                //string str_url = Application.StartupPath + "\\DeliveryPath.html";
                //Uri url = new Uri(str_url);
                //webBrowser1.Url = url;
                //webBrowser1.ObjectForScripting = this;

            }
            else
            {
                if (MessageBox.Show("未给该订单设置停车位置，您是否进行设置？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("请先分别设置起点和终点信息！");
                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format ("DeliveryOrderId='{0}'",txtDeliveryId.Text ));
                    if (orderList.Count > 0)
                    {
                        txtOrigin .Text = orderList[0].Origin;
                        txtDestional.Text = orderList[0].Destination;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (point == "")
            {
                if (pathList == null) pathList = new List<YueYePlat.Model.deliverypath>();
                if (pathList.Count > 0)
                {
                    for (int i = 0; i < pathList.Count; i++)
                    {
                        if (new YueYePlat.BLL.deliverypath().Add(pathList[i]))
                        {
                            
                        }
                    }
                    MessageBox.Show("设置完成！");
                }
                else
                {
                    MessageBox.Show("请设置起点和终点！");
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            YueYePlat.Model.deliverypath path = new YueYePlat.Model.deliverypath();
            path.LocationSign = "途经点";
            path.DeliverId = txtDeliveryId.Text.Trim().Substring(0, txtDeliveryId.Text.Trim().Length - 2);
            path.OrderNumber = int.Parse(txtDeliveryId.Text.Trim().Substring(txtDeliveryId.Text.Trim().Length - 2));
            path.Latitude = double.Parse(lblViaLat.Text);
            path.Longitude = double.Parse(lblViaLng.Text);
            path.LocationName = txtViaLocation.Text;
            pathList.Add(path);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pathList;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
        }


        public void getLocation(string location)
        {
            lng = getcheck(location)[0].Trim();
            lat = getcheck(location)[1].Trim();
            lblViaLat.Text = lat;
            lblViaLng.Text = lng;
        }
        public void getLocationName(string name)
        {
            destionation = name;
            txtViaLocation.Text = destionation;
            //this.DialogResult= DialogResult.OK;
            //this.Close();
        }
        public void getViaLocation(string location, string name)
        {
            string  viaLng = getcheck(location)[0].Trim();
            string  viaLat = getcheck(location)[1].Trim();
            string viaLocation = name;
            if (viaLat != "" && viaLng != "" && viaLocation != "")
            {
                if (pathList == null) pathList = new List<YueYePlat.Model.deliverypath>();
                YueYePlat.Model.deliverypath path = new YueYePlat.Model.deliverypath();
                path.LocationSign = "途经点";
                path.DeliverId = txtDeliveryId.Text.Trim().Substring(0, txtDeliveryId.Text.Trim().Length - 2);
                path.OrderNumber = int.Parse(txtDeliveryId.Text.Trim().Substring(txtDeliveryId.Text.Trim().Length - 2));
                path.Latitude = double.Parse(viaLat);
                path.Longitude = double.Parse(viaLng);
                path.LocationName =viaLocation;
                pathList.Add(path);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pathList;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = false;
                }
            }
        }
        public string[] getcheck(String str)
        {
            string[] sArray = str.Split(';');
            return sArray;
        }

        private void txtOrigin_Leave(object sender, EventArgs e)
        {
            //string str_url = Application.StartupPath + "\\DeliveryPath.html";
            //Uri url = new Uri(str_url);
            //webBrowser1.Url = url;
            //webBrowser1.ObjectForScripting = this;
        }

        private void txtDestional_Leave(object sender, EventArgs e)
        {
            //webBrowser1.ObjectForScripting = this;
        }
    }
}
