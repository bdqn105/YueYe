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
    public partial class FrmRegionalparkmanage : Form
    {
        YueYePlat.BLL.regionalparkmanage bll;
        public YueYePlat.Model.usersinfo usersInfo;
        static FrmRegionalparkmanage instance;
        public string tabPageTitle = "";
        static string lng = "";
        static string lat = "";
        static string location = "";
        public string strDeliveryId = "";
        int Id = 0;
        List<YueYePlat.Model.regionalparkmanage> regionparkList;
        public FrmRegionalparkmanage()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.regionalparkmanage();
        }
        public static FrmRegionalparkmanage getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmRegionalparkmanage();
            }
            return instance;
        }
        private void FrmRegionalparkmanage_Load(object sender, EventArgs e)
        {
           
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyID='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvRegionalPark.AutoGenerateColumns = false;
            if (regionparkList == null) regionparkList = new List<YueYePlat.Model.regionalparkmanage>();
            if (strDeliveryId != "")
            {
                txtDeliveryId.Text = strDeliveryId;
                regionparkList = new YueYePlat.BLL.regionalparkmanage().GetModelList(String.Format ("DeliveryId='{0}'",txtDeliveryId.Text ));
                if (regionparkList.Count > 0)
                {
                    string str_url = Application.StartupPath + "\\RegionalPark.html";
                    Uri url = new Uri(str_url);
                    webBrowser1.Url = url;
                    webBrowser1.ObjectForScripting = this;
                }
                else
                {
                    if (MessageBox.Show("未给该订单设置停车位置，您是否进行设置？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string str_url = Application.StartupPath + "\\RegionalPark.html";
                        Uri url = new Uri(str_url);
                        webBrowser1.Url = url;
                        webBrowser1.ObjectForScripting = this;
                    }
                }
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<YueYePlat.Model.regionalparkmanage> regionalParkList = new YueYePlat.BLL.regionalparkmanage().GetModelList(String.Format ("DeliveryId='{0}'",txtDeliveryId.Text ));
            if (regionalParkList.Count > 0)
            {
                string str_url = Application.StartupPath + "\\RegionalPark.html";
                Uri url = new Uri(str_url);
                webBrowser1.Url = url;
                webBrowser1.ObjectForScripting = this;
            }
            else
            {
                if (MessageBox.Show("未给该订单设置停车位置，您是否进行设置？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string str_url = Application.StartupPath + "\\RegionalPark.html";
                    Uri url = new Uri(str_url);
                    webBrowser1.Url = url;
                    webBrowser1.ObjectForScripting = this;
                }
            }
     
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            List<YueYePlat.Model.regionalparkmanage> parkList = new YueYePlat.BLL.regionalparkmanage().GetModelList(String.Format ("DeliveryId='{0}'",txtDeliveryId.Text));
            for (int i = 0; i < parkList.Count; i++)
            {
                webBrowser1.Document.InvokeScript("theLocation", new object[] { parkList[i].Longitude, parkList[i].Latitude });
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            YueYePlat.Model.regionalparkmanage parkInfo = new YueYePlat.Model.regionalparkmanage();
            parkInfo.DeliveryId = txtDeliveryId.Text;
            parkInfo.Id = Id;
            try
            {
                parkInfo.Latitude = double.Parse(lat);
            }
            catch (Exception ex)
            {
                parkInfo.Latitude = null;
            }
            try
            {
                parkInfo.Longitude = double.Parse(lng);
            }
            catch (Exception ex)
            {
                parkInfo.Longitude = null;
            }
            parkInfo.Location = location;
            regionparkList.Add(parkInfo);
            dgvRegionalPark.DataSource = null;
            dgvRegionalPark.DataSource = regionparkList;
            if (dgvRegionalPark.Rows.Count > 0)
            {
                dgvRegionalPark.Rows[0].Selected = false;
            }
            Id++;
        }

        public void getLocation(string location)
        {
            lng = getcheck(location)[0].Trim();
            lat = getcheck(location)[1].Trim();
        }
        public void getLocationName(string name)
        {
            location  = name;
            txtLocation.Text = location;         
        }
        public string[] getcheck(String str)
        {
            string[] sArray = str.Split(';');
            return sArray;
        }

        private void dgvRegionalPark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int str = int.Parse(dgvRegionalPark.Rows[e.RowIndex].Cells["colId"].Value.ToString());
            int cid = e.ColumnIndex;
            string strcolName = this.dgvRegionalPark.Columns[cid].DefaultCellStyle.NullValue.ToString();
            if (strcolName == "删除")
            {
                if (str != -1)
                {
                    for (int i = 0; i < regionparkList.Count; i++)
                    {
                        if (regionparkList[i].Id.Equals(str))
                        {
                            YueYePlat.Model.regionalparkmanage model = regionparkList[i];
                            regionparkList.Remove(model);                           
                            break;
                        }
                    }
                    dgvRegionalPark.DataSource = null;
                    dgvRegionalPark.DataSource = regionparkList;
                    if (dgvRegionalPark.Rows.Count > 0)
                    {
                        dgvRegionalPark.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (regionparkList == null) regionparkList = new List<YueYePlat.Model.regionalparkmanage>();
            YueYePlat.Model.regionalparkmanage parkInfo = new YueYePlat.Model.regionalparkmanage();
            for (int i = 0; i < regionparkList.Count; i++)
            {
                parkInfo.DeliveryId = regionparkList[i].DeliveryId;
                parkInfo.Latitude = regionparkList[i].Latitude;
                parkInfo.Longitude = regionparkList[i].Longitude;
                new YueYePlat.BLL.regionalparkmanage().Add(parkInfo );
            }
        }

        private void txtDeliveryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
