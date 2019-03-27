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
    public partial class FrmLocationMonitor : Form
    {
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;             
        public string strdeliveryId;
        static FrmLocationMonitor instance;
        public string tabPageTitle = "";
        public YueYePlat.Model.usersinfo usersInfo;
        public FrmLocationMonitor()
        {
            InitializeComponent();
        }
        public static FrmLocationMonitor getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmLocationMonitor();
            }
            return instance;
        }
        private void FrmLocationMonitor_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleList;
            List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxDriverId.DisplayMember = "DriverName";
            cbxDriverId.ValueMember = "DriverId";
            cbxDriverId.DataSource = driverList;
            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            cbxClientId.DisplayMember = "ClientName";
            cbxClientId.ValueMember = "ClientId";
            cbxClientId.DataSource = clientList;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format ("ProductId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvDelivery.AutoGenerateColumns = false;
            cbxClientId.SelectedValue = "";
            cbxDriverId.SelectedValue = "";
            cbxVehicleId.SelectedValue = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            strWhere = "1=1";
            if (txtDeliveryTime.Text.Trim() != "")
            {
                string strDeliveryTime = "";
                DateTime dt = DateTime.Parse(txtDeliveryTime.Text);
                strDeliveryTime = dt.ToString("yyMMdd");
                strWhere += String.Format(" and DeliveryId like  '%{0}%'", strDeliveryTime);
            }
            if (cbxDriverId.Text.Trim() != "" && cbxDriverId.SelectedValue != null)
            {
                strWhere += String.Format(" and driver1Id = '{0}'", cbxDriverId.SelectedValue.ToString().Trim());

            }
            if (txtDeliveryOrderId.Text.Trim() != "")
            {
                if (txtDeliveryOrderId.Text.Length == 13)
                {
                    strdeliveryId = txtDeliveryOrderId.Text .Trim ().Substring (0,txtDeliveryOrderId.Text .Trim ().Length-2);
                    strWhere += String.Format(" and DeliveryId = '{0}'", strdeliveryId);
                }
            }
            if (cbxVehicleId.Text != "" && cbxVehicleId.SelectedValue != null)
            {
                strWhere += String.Format(" and VehicleId = '{0}'", cbxVehicleId.SelectedValue.ToString());
            }
            if (cbxDriverId.SelectedValue != null || cbxVehicleId.SelectedValue != null || txtDeliveryTime.Text != "" || cbxClientId.SelectedValue != null)
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format(strWhere));
                List<YueYePlat.Model.vehicledelivery> deliveryInfo = new List<YueYePlat.Model.vehicledelivery>();
                if (cbxClientId.Text != "" && cbxClientId.SelectedValue != null)
                {
                    for (int i = 0; i < deliveryList.Count; i++)
                    {
                        List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", deliveryList[i].DeliveryId));
                        //strWhere = String.Format("clientId='{0}'", cbxClient.SelectedValue.ToString().Trim());
                        for (int j = 0; j < orderList.Count; j++)
                        {
                            //strWhere = "1=1";
                            //if (cbxClientId.Text.Trim() != "" && cbxClientId.SelectedValue != null)
                            //{
                            //    strWhere += String.Format(" and ClientId = '{0}'", cbxDriverId.SelectedValue.ToString().Trim());
                            //}
                            //if (cbxProductId.Text != "" && cbxProductId.SelectedValue != null)
                            //{
                            //    strWhere += String.Format(" and ProductId = '{0}'", cbxVehicleId.SelectedValue.ToString());
                            //}
                            //List<YueYePlat.Model.deliveryorder> deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format(strWhere));
                            //List<YueYePlat.Model.vehicledelivery> vehicledeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format ("deliveryId='{0}'",deliveryorderList[0].DeliveryId));
                            if (orderList[j].ClientId.Equals(cbxClientId.SelectedValue.ToString()))
                            {
                                deliveryInfo.Add(deliveryList[i]);
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < deliveryInfo.Count; i++)
                    {
                        deliveryInfo[i].Driver1Id = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryInfo[i].Driver1Id))[0].DriverName;
                        if (deliveryInfo[i].Driver2Id != null&& deliveryInfo[i].Driver2Id!="")
                        {
                            deliveryInfo[i].Driver2Id = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryInfo[i].Driver2Id))[0].DriverName;
                        }
                        deliveryInfo[i].VehicleId = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryInfo[i].VehicleId))[0].VehicleNumber;
                    }
                    dgvDelivery.DataSource = null;
                    dgvDelivery.DataSource = deliveryInfo;
                    if (dgvDelivery.Rows.Count > 0)
                    {
                        dgvDelivery.Rows[0].Selected = false;
                    }
                }
                else
                {
                    if (deliveryList.Count > 0)
                    {
                        for (int i = 0; i < deliveryList.Count; i++)
                        {
                            try
                            {
                                deliveryList[i].Driver1Id = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
                                if (deliveryList[i].Driver2Id != null && deliveryList[i].Driver2Id != "")
                                {
                                    deliveryList[i].Driver2Id = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
                                }
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].Driver1Id = "";
                                deliveryList[i].Driver2Id = "";
                            }
                            deliveryList[i].VehicleId = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
                        }
                        dgvDelivery.DataSource = null;
                        dgvDelivery.DataSource = deliveryList;
                        if (dgvDelivery.Rows.Count > 0)
                        {
                            dgvDelivery.Rows[0].Selected = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有对应的配送记录，请确认查询条件！");
                    }
                }                
                monthCalendar1.Visible = false;
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
                //    if (cbxClientId.SelectedValue == null)
                //    {
                //        MessageBox.Show("请输入查询条件！");
                //    }
                //    else
                //    {
                //        List<YueYePlat.Model.vehicledelivery> deliveryList = new List<YueYePlat.Model.vehicledelivery>();
                //        List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format ("ClientId='{0}'",cbxClientId.SelectedValue.ToString ()));
                //        for (int i = 0; i < orderList.Count; i++)
                //        {
                //            List<YueYePlat.Model.vehicledelivery> deliveryInfo = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format ("DeliveryId='{0}'",orderList[i].DeliveryId));
                //            deliveryList.Add(deliveryInfo[0]);                        
                //        }
                //        dgvDelivery.DataSource = deliveryList;
                //    }
                //}
            }
        }
        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvDelivery.Rows[e.RowIndex].Cells["coldeliveryId"].Value.ToString();
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("deliveryId='{0}'", str));
                YueYePlat.Model.vehicledelivery deliveryInfo = deliveryList.Find(v => v.DeliveryId.Equals(str));
                int cid = e.ColumnIndex;
                string strcolName = this.dgvDelivery.Columns[cid].DefaultCellStyle.NullValue.ToString();
                if (strcolName == "位置监控")
                {
                    FrmLocationMonitorInfo info = new FrmLocationMonitorInfo();
                    info.strDeliverId = deliveryInfo.DeliveryId;
                    info.usersInfo = usersInfo;
                    info.Show();
                }
                if (strcolName == "温湿度历史监控")
                {
                    FrmTempMonitor info = new FrmTempMonitor();
                    info.strDeliveryId = deliveryInfo.DeliveryId;
                    info.usersInfo = usersInfo;
                    info.Show();
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
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDeliveryTime.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            monthCalendar1.Visible = false;
        } 

        private void txtDeliveryTime_Click(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = true ;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
