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

    public partial class FrmTransferOrderInfo : Form
    {
        List<YueYePlat.Model.deliveryorderfee> feeList;
        public string operate = "";
        public string lng = "";
        public string lat = "";
        public string destionation = "";
        public YueYePlat.Model.vehicledelivery delivery;
        public YueYePlat.Model.productdelivery curProduct;
        public YueYePlat.Model.deliveryorder curOrder;
        public YueYePlat.Model.usersinfo usersinfo;
        private string deliveryId = "";
        private int orderId = -1;
        static FrmTransferOrderInfo instance;
        public string tabPageTitle = "";
        //private int coldeliveryId = 1;
        //private int colorderId = 1;      
        private YueYePlat.Model.logiscompanyinfo info;
        public YueYePlat.Model.deliveryorder clientOrder;
        public List<YueYePlat.Model.deliveryorder> deliveryorderList;
        List<YueYePlat.Model.productdelivery> productList;
        List<YueYePlat.Model.productdelivery> productsList;//用于比较
        List<YueYePlat.Model.deliveryorderfee> orderTotalFeeList;
        int top = 0;
        int left = 0;
        int height = 0;
        int width1 = 0;
        public FrmTransferOrderInfo()
        {
            InitializeComponent();
        }
        public static FrmTransferOrderInfo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTransferOrderInfo();
            }
            return instance;
        }
        private void FrmTransferOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueyePlatdb");
                List<YueYePlat.Model.logiscompanyinfo> companyshortCode = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersinfo.CompanyId));
                info = companyshortCode.Find(v => v.CompanyID.Equals(usersinfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                dgvOrderList.AutoGenerateColumns = false;
                dgvProductList.AutoGenerateColumns = false;
                InitComponent();
                cbxDriver2Id.SelectedValue = "";
                cbxDriver1Id.SelectedValue = "";
                cbxVehicleId.SelectedValue = "";
                cbxTempDeviceId.SelectedValue = "";
                cbxAuditor.SelectedValue = "";
                cbxTerminator.SelectedValue = "";
                if (clientOrder != null)
                {
                    cbxClientId.SelectedValue = clientOrder.ClientId;
                    txtOrigin.Text = clientOrder.Origin;
                    txtReceiver.Text = clientOrder.Receiver;
                    txtReceiverPhone1.Text = clientOrder.ReceiverPhone1;
                    txtDestination.Text = clientOrder.Destination;
                    cbxSourceTransType.Text = clientOrder.SourceTransType;
                    txtSourceTransId.Text = clientOrder.SourceTransId;
                    txtAirWaybillID.Text = clientOrder.AirWaybillID;
                    txtRemark.Text = clientOrder.Remark;
                    chkIsDeliver.Checked = clientOrder.IsChecked;
                   
                    lblLat.Text = "";
                    lblLng.Text = "";
                }
                else
                {
                    lblClientPhone.Text = "";
                    lblClientTelephone.Text = "";               
                    cbxClientId.SelectedValue = "";
                    cbxClientCompany.SelectedValue = "";
                    lblClientPhone.Text = "";
                    lblClientTelephone.Text = "";
                    lblLat.Text = "";
                    lblLng.Text = "";
                    cbxSourceTransType.Text = "空运";
                }               
                rBtnMonthPay.Checked = true;               
                cbxVehicleId.Focus();               
                if (operate == "view")
                {
                    dgvOrderList.Columns["colAddProduct"].Visible = false;
                    dgvProductList.Columns["colModify"].Visible = false;
                    dgvProductList.Columns["colDelete"].Visible = false;
                    //btnSave.Visible = false;
                    btnAdd.Visible = false;
                    //btnModify.Visible = false;
                    btnDel.Visible = false;
                }
                if (delivery != null)
                {
                    if (operate == "view" || operate == "modify")
                    {
                        // txtDeliveryId.ReadOnly = true;
                        lblDeliveryId.Text = delivery.DeliveryId;
                    }
                    if (operate == "modify")
                    {
                        lblOrderId.Text = GenerateOrderID(lblDeliveryId.Text).ToString();
                    }
                    List<YueYePlat.Model.vehicleinfo> vehicleInfo = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", delivery.VehicleId));
                    cbxVehicleId.DisplayMember = "VehicleNumber";
                    cbxVehicleId.SelectedValue = "VehicleId";
                    cbxVehicleId.DataSource = vehicleInfo;
                    //txtDeliveryId.Text = delivery.DeliveryId;
                    cbxVehicleId.SelectedValue = delivery.VehicleId;
                    //cbxVehicleId.Text = delivery.VehicleId;
                    cbxDriver1Id.SelectedValue = delivery.Driver1Id;
                    if (delivery.Driver2Id.ToString() != "" && delivery.Driver2Id != null)
                    {
                        cbxDriver2Id.SelectedValue = delivery.Driver2Id;
                    }
                    cbxTempDeviceId.SelectedValue = delivery.DeviceId;
                    txtMaxTempThreshold.Text = delivery.MaxTempThreshold.ToString();
                    txtMinTempThreshold.Text = delivery.MinTempThreshold.ToString();
                    txtMaxHumThreshold.Text = delivery.MaxHumThreshold.ToString();
                    txtMinHumThreshold.Text = delivery.MinHumThreshold.ToString();
                    //chkIfEnd.Checked = delivery.IfEnd;
                    //cbxAuditor.SelectedValue = delivery.Auditor;               
                    deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", delivery.DeliveryId));
                    for (int i = 0; i < deliveryorderList.Count; i++)
                    {
                        deliveryorderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryorderList[i].DeliveryOrderId));
                        deliveryorderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", deliveryorderList[i].ClientId))[0].ClientName;
                        if (deliveryorderList[i].IsDeliver == true) deliveryorderList[i].IsDeliverName = "是";
                        else if (deliveryorderList[i].IsDeliver == false) deliveryorderList[i].IsDeliverName = "否";
                    }
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = deliveryorderList;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }
                }
                else
                {
                    lblDeliveryId.Text = GenerateDeliveryID(info.CompanyShortCode);
                    lblOrderId.Text = GenerateOrderID(lblDeliveryId.Text).ToString();
                    deliveryorderList = new List<YueYePlat.Model.deliveryorder>();
                    //string deliveryId = txtDeliveryId.Text;
                }
                if (curOrder != null)
                {
                    btnAdd.Visible = false;
                    btnModify.Visible = true;
                    btnDel.Visible = false;
                    btnSave.Visible = true;
                    lblOrderId.Text = curOrder.DeliveryOrderId;
                    cbxClientId.SelectedValue = curOrder.ClientId;
                    txtOrigin.Text = curOrder.Origin;
                    txtDestination.Text = curOrder.Destination;
                    if (curOrder.Latitude.ToString() != "")
                    {
                        lblLat.Text = curOrder.Latitude.ToString();
                    }
                    if (curOrder.Longitude.ToString() != "")
                    {
                        lblLng.Text = curOrder.Longitude.ToString();
                    }
                    txtReceiver.Text = curOrder.Receiver;
                    txtReceiverPhone1.Text = curOrder.ReceiverPhone1;
                    txtReceiverPhone2.Text = curOrder.ReceiverPhone2;
                    txtReceiverPhone3.Text = curOrder.ReceiverPhone3;
                    lblTotalFee.Text = curOrder.TotalFee.ToString();
                    txtSourceTransId.Text = curOrder.SourceTransId;
                    txtAmount.Text = curOrder.Amount.ToString();
                    //  chkIsBackFee.Checked = curOrder.IsBackFee;
                    txtAirWaybillID.Text = curOrder.AirWaybillID;
                    chkIsDeliver.Checked = curOrder.IsDeliver;
                    if (curOrder.IsChecked == true)
                    {
                        MessageBox.Show("该订单已审核，只允许进行查看！");
                        cbxAuditor.SelectedValue = curOrder.Auditor;
                        //审核过得订单不给修改
                        btnModify.Visible = false;
                        btnSave.Visible = false;
                    }                 
                    if (curOrder.Terminator != null&&curOrder.Terminator!="")
                    {                        
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", curOrder.Terminator));
                        if (userList.Count > 0)
                        {                           
                            cbxTerminator.DisplayMember = "UserName";
                            cbxTerminator.ValueMember = "UserId";
                            cbxTerminator.DataSource = userList;
                            cbxTerminator.SelectedValue = userList[0].UserId;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info .CompanyDBName);
                    }
                    if (curOrder.Auditor != null&& curOrder.Auditor!="")
                    {                       
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> auditorList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", curOrder.Auditor));
                        if (auditorList.Count > 0)
                        {
                            cbxAuditor.DisplayMember = "UserName";
                            cbxAuditor.ValueMember = "UserId";
                            cbxAuditor.DataSource = auditorList;
                            cbxAuditor.SelectedValue = auditorList[0].UserId;
                          
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                    }             
                    if (curOrder.PaymentMethod == rBtnCashPay.Text)
                    {
                        rBtnCashPay.Checked = true;
                    }
                    else if (curOrder.PaymentMethod == rBtnForwardPay.Text)
                    {
                        rBtnForwardPay.Checked = true;
                    }
                    else if (curOrder.PaymentMethod == rBtnMonthPay.Text)
                    {
                        rBtnMonthPay.Checked = true;
                    }
                    deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrder.DeliveryOrderId));
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = deliveryorderList;
                    dgvOrderList.Rows[0].Selected = true;
                    List<YueYePlat.Model.vehicledelivery> deliveryInfo = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", curOrder.DeliveryId));
                    delivery = deliveryInfo.Find(v => v.DeliveryId.Equals(curOrder.DeliveryId));
                    if (deliveryInfo.Count > 0)
                    {
                        lblDeliveryId.Text = deliveryInfo[0].DeliveryId;
                        List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");
                        cbxVehicleId.DisplayMember = "VehicleNumber";
                        cbxVehicleId.ValueMember = "VehicleId";
                        cbxVehicleId.DataSource = vehicleInfos;
                        cbxVehicleId.SelectedValue = deliveryInfo[0].VehicleId;
                        cbxDriver1Id.SelectedValue = deliveryInfo[0].Driver1Id;
                        if (deliveryInfo[0].Driver2Id.ToString() != "" && deliveryInfo[0].Driver2Id != null)
                        {
                            cbxDriver2Id.SelectedValue = deliveryInfo[0].Driver2Id;
                        }
                        cbxTempDeviceId.SelectedValue = deliveryInfo[0].DeviceId;
                        txtMaxTempThreshold.Text = deliveryInfo[0].MaxTempThreshold.ToString();
                        txtMinTempThreshold.Text = deliveryInfo[0].MinTempThreshold.ToString();
                        txtMaxHumThreshold.Text = deliveryInfo[0].MaxHumThreshold.ToString();
                        txtMinHumThreshold.Text = deliveryInfo[0].MinHumThreshold.ToString();
                    }
                    orderTotalFeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrder.DeliveryOrderId));
                    if (orderTotalFeeList.Count > 0)
                    {
                        for (int i = 0; i < orderTotalFeeList.Count; i++)
                        {
                            orderTotalFeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderTotalFeeList[i].FeeTypeId))[0].FeeTypeName;
                        }
                    }
                    //dgvOrderfee.DataSource = null;
                    //dgvOrderfee.DataSource = feeList;
                    //if (dgvOrderfee.Rows.Count > 0)
                    //{
                    //    dgvOrderfee.Rows[0].Selected = false;
                    //}
                    if (productList == null) productList = new List<YueYePlat.Model.productdelivery>();
                    productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrder.DeliveryOrderId));
                    if (productList.Count > 0)
                    {
                        for (int i = 0; i < productList.Count; i++)
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                            List<YueYePlat.Model.deliveryorderfee> orderfeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}' and  DeliveryOrderDetailId='{1}' and FeetypeId='{2}'", productList[i].DeliveryOrderId, productList[i].OrderDetailId, productList[i].Feetype));
                            if (orderfeeList.Count > 0)
                            {
                                for (int j = 0; j < orderfeeList.Count; j++)
                                {
                                    orderfeeList[i].ProductCount = productList[i].Quantity.ToString();
                                    orderfeeList[i].ProductId = productList[i].ProductId;
                                }
                                productList[i].Feetype = orderfeeList[0].FeeTypeId.ToString();
                                productList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[0].FeeTypeId))[0].FeeTypeName;
                                productList[i].Fee = orderfeeList[0].Fee;
                            }
                        }
                    }
                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = productList;
                    if (dgvProductList.Rows.Count > 0)
                    {
                        dgvProductList.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
        private void InitComponent()
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
            List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            List<YueYePlat.Model.vehicleinfo> vehicleInfo = new List<YueYePlat.Model.vehicleinfo>();
            for (int i = 0; i < vehicleInfos.Count; i++)
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("VehicleId='{0}' ", vehicleInfos[i].VehicleId));
                if (deliveryList.Count == 0)
                {
                    vehicleInfo.Add(vehicleInfos[i]);
                }
                else
                {
                    if (deliveryList[deliveryList.Count - 1].IfEnd == true)
                    {
                        vehicleInfo.Add(vehicleInfos[i]);
                    }
                }
            }
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleInfo;
            List<YueYePlat.Model.driverinfo> driver1 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type !='离职'"));
            List<YueYePlat.Model.vehicledelivery> delivery = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format (" IfEnd =0"));
            for (int i = 0; i < driver1.Count; i++)
            {
                for (int j = 0; j < delivery.Count; j++)
                {
                    if (driver1[i].DriverId == delivery[j].Driver1Id || driver1[i].DriverId == delivery[j].Driver2Id)
                    {
                        driver1.Remove(driver1[i]);
                    }
                }
            }
            cbxDriver1Id.DisplayMember = "DriverName";
            cbxDriver1Id.ValueMember = "DriverId";
            cbxDriver1Id.DataSource = driver1;
            List<YueYePlat.Model.driverinfo> driver2 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("Type !='离职'"));
            List<YueYePlat.Model.vehicledelivery> delivery2 = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format(" IfEnd =false"));
            for (int i = 0; i < driver2.Count; i++)
            {
                for (int j = 0; j < delivery2.Count; j++)
                {
                    if (driver2[i].DriverId == delivery2[j].Driver1Id || driver2[i].DriverId == delivery2[j].Driver2Id)
                    {
                        driver2.Remove(driver2[i]);
                    }
                }
            }
            cbxDriver2Id.DisplayMember = "DriverName";
            cbxDriver2Id.ValueMember = "DriverId";
            cbxDriver2Id.DataSource = driver2;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxClientCompany.DisplayMember = "CompanyName";
            cbxClientCompany.ValueMember = "CompanyId";
            cbxClientCompany.DataSource = companyList;
            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            cbxClientId.DisplayMember = "ClientName";
            cbxClientId.ValueMember = "ClientId";
            cbxClientId.DataSource = clientList;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueyePlatdb");
            List<YueYePlat.Model.terminaldeviceinfo> deviceInfos = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyID='{0}'", usersinfo.CompanyId));
            cbxTempDeviceId.DisplayMember = "DeviceName";
            cbxTempDeviceId.ValueMember = "DeviceId";
            cbxTempDeviceId.DataSource = deviceInfos;
            //List<YueYePlat.Model.usersinfo> auditor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format ("CompanyID='{0}' and  UserTypeId='WL01'",usersinfo .CompanyId ));
            //cbxAuditor.DisplayMember = "UserName";
            //cbxAuditor.ValueMember = "UserId";
            //cbxAuditor.DataSource = auditor;
            //List<YueYePlat.Model.usersinfo> terminator = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyID='{0}' and  (UserTypeId ='WL01' OR UserTypeId='DriverAPP')", usersinfo.CompanyId));
            //cbxTerminator.DisplayMember = "UserName";
            //cbxTerminator.ValueMember = "UserId";
            //cbxTerminator.DataSource = terminator;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);          
        }

        private void btnDeliveryID_Click(object sender, EventArgs e)
        {
            //List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersinfo.CompanyId));
            //YueYePlat.Model.logiscompanyinfo logiscompanyInfo = logiscompanyList.Find(v => v.CompanyID.Equals(usersinfo.CompanyId));
            //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
            //txtDeliveryId.Text = GenerateDeliveryID(info.CompanyShortCode);
        }
        private string GenerateDeliveryID(string CompanyShortCode)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
            string str = CompanyShortCode + DateTime.Now.ToString("yyMMdd");
            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId like '{0}%' order by DeliveryId desc", str));
            if (deliveryList.Count == 0)
            {
                return str + "0001";
            }
            else
            {
                string cId = deliveryList[0].DeliveryId;
                string cidCount = "1" + cId.Substring(cId.Length - 4);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

        private string GenerateOrderID(string deliveryID)
        {
            string str = deliveryID;
            if (deliveryorderList == null)
            {
                deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId like '{0}%' order by DeliveryOrderId desc", str));
            }

            if (deliveryorderList.Count == 0)
            {
                return str + "01";
            }
            else
            {
                //string cId = deliveryorderList[deliveryorderList.Count - 1].DeliveryOrderId;
                string cId = deliveryorderList[0].DeliveryOrderId;
                string cidCount = "1" + cId.Substring(cId.Length - 2);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderId_Click(object sender, EventArgs e)
        {
            if (lblDeliveryId.Text == "")
            {
                MessageBox.Show("请先创建配送编号！");
            }
            else
            {
                string deliveryId = lblDeliveryId.Text;
                lblOrderId.Text = GenerateOrderID(lblDeliveryId.Text).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxClientId.SelectedValue != null && txtOrigin.Text.Trim() != "" && txtDestination.Text.Trim() != ""&& txtReceiver.Text.Trim() != ""&& txtReceiverPhone1.Text .Trim ()!="")
            {
                YueYePlat.Model.deliveryorder delivery = new YueYePlat.Model.deliveryorder();
                delivery.DeliveryOrderId = lblOrderId.Text;
                delivery.DeliveryId = lblDeliveryId.Text;
                delivery.Origin = txtOrigin.Text;
                delivery.BeginTime =DateTime.Now;
                delivery.Destination = txtDestination.Text;
                          
                try
                {
                    delivery.Longitude = double.Parse(lblLng.Text);
                }
                catch (Exception ex)
                {
                    delivery.Longitude = null;
                    lblLng.Text = "";
                }
                try
                {
                    delivery.Latitude = double.Parse(lblLat.Text);
                }
                catch (Exception ex)
                {
                    delivery.Latitude = null;
                    lblLat.Text = "";
                }
                delivery.PredictDeliveryTime = DateTime.Now.AddHours(1);
                //delivery.DeliveryTime = dTDeliveryTime.Value;
                delivery.ClientId = cbxClientId.SelectedValue.ToString();
                delivery.Receiver = txtReceiver.Text;
                delivery.ReceiverPhone1 = txtReceiverPhone1.Text;
                if (txtReceiverPhone2.Text != "")
                {
                    delivery.ReceiverPhone2 = txtReceiverPhone2.Text;
                }
                if (txtReceiverPhone3.Text != "")
                {
                    delivery.ReceiverPhone3 = txtReceiverPhone3.Text;
                }
                //delivery.Signer = txtSigner.Text;
                //delivery.Telephone = txtTelephone.Text;        
                //delivery.IsBackFee = chkIsBackFee.Checked;
                try
                {
                    delivery.Amount = decimal.Parse(txtAmount.Text);
                }
                catch (Exception ex)
                {
                    delivery.Amount = 0;
                    txtAmount.Text = 0 + "";
                }
                try
                {
                    delivery.Receivable = decimal.Parse(txtReceivable.Text);
                    if (txtReceivable.Text == "0")
                    {
                        delivery.IsBackFee = false;
                    }
                    else
                    {
                        delivery.IsBackFee = true;
                    }
                }
                catch (Exception ex)
                {
                    delivery.Receivable = 0;
                    txtReceivable.Text = 0 + "";
                }
                delivery.AirWaybillID = txtAirWaybillID.Text;
                delivery.SourceTransType = cbxSourceTransType.Text;
                delivery.SourceTransId = txtSourceTransId.Text;
                delivery.IsDeliver = chkIsDeliver.Checked;
                delivery.LogisCompanyID = usersinfo.CompanyId;
                delivery.LogisCompanyShortName = info.CompanyShortName;
                //delivery.PaymentMethod = cbxPaymentMethod.SelectedValue.ToString();
                delivery.Remark = txtRemark.Text;

                if (rBtnCashPay.Checked == true)
                {
                    delivery.PaymentMethod = rBtnCashPay.Text;
                }
                if (rBtnForwardPay.Checked == true)
                {
                    delivery.PaymentMethod = rBtnForwardPay.Text;
                }
                if (rBtnMonthPay.Checked == true)
                {
                    delivery.PaymentMethod = rBtnMonthPay.Text;
                }
                delivery.IsEnd = false;
                delivery.IsChecked = false;
                delivery.TotalFee = decimal.Parse(lblTotalFee.Text);
                if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < feeList.Count; i++)
                {
                    if (feeList[i].DeliveryOrderId.Equals(lblOrderId.Text))
                    {
                        //feeList[i].DeliveryOrderId = lblOrderId.Text; //防止增加的订单号是所选中的订单
                        orderTotalFeeList.Add(feeList[i]);
                    }
                  
                }
                if (deliveryorderList.Count == 0)
                {
                    deliveryorderList.Insert(0, delivery);
                    feeList = new List<YueYePlat.Model.deliveryorderfee>();         
                    for (int i = 0; i < deliveryorderList.Count; i++)
                    {
                        deliveryorderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", deliveryorderList[i].ClientId))[0].ClientName;
                        //deliveryorderList[i].ProductList = productList;
                    }
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = deliveryorderList;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }                   
                    lblOrderId.Text = GenerateOrderID(lblDeliveryId.Text).ToString();
                    txtAmount.Text = 0 + "";
                    txtDestination.Text = "";
                    lblLat.Text = "";
                    lblLng.Text = "";
                    txtOrigin.Text = "";
                    txtReceiver.Text = "";
                    txtReceiverPhone1.Text = "";
                    txtReceiverPhone2.Text = "";
                    txtReceiverPhone3.Text = "";
                    lblTotalFee.Text = 0 + "";
                    deliveryId = "";
                    dgvProductList.DataSource = null;                    
                }
                else
                {
                    for (int j = 0; j < deliveryorderList.Count; j++)
                    {
                        if (!deliveryorderList[j].DeliveryOrderId.Equals(delivery.DeliveryOrderId))
                        {
                            deliveryorderList.Insert(0, delivery);
                            feeList = new List<YueYePlat.Model.deliveryorderfee>();
                            for (int k = 0; k < deliveryorderList.Count; k++)
                            {
                                deliveryorderList[k].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", deliveryorderList[k].ClientId))[0].ClientName;                  
                            }
                            dgvOrderList.DataSource = null;
                            dgvOrderList.DataSource = deliveryorderList;
                            if (dgvOrderList.Rows.Count > 0)
                            {
                                dgvOrderList.Rows[0].Selected = false;
                            }                           
                            lblOrderId.Text = GenerateOrderID(lblDeliveryId.Text).ToString();
                            txtAmount.Text = 0 + "";
                            txtDestination.Text = "";
                            lblLat.Text = "";
                            lblLng.Text = "";
                            txtOrigin.Text = "";
                            txtReceiver.Text = "";
                            txtReceiverPhone1.Text = "";
                            txtReceiverPhone2.Text = "";
                            txtReceiverPhone3.Text = "";
                            lblTotalFee.Text = 0 + "";
                            deliveryId = "";
                            dgvProductList.DataSource = null;                           
                            if (dgvOrderList.Rows.Count > 0)
                            {
                                dgvOrderList.Rows[0].Selected = false;
                            }
                            break;
                        }
                    }
                }

            }
            else
            {
                if (cbxClientId.SelectedValue == null)
                {
                    MessageBox.Show("请录入客户信息！");
                }
                else if (txtReceiver.Text.Trim() == "")
                {
                    MessageBox.Show("请录入收货人信息！");
                }
                else if (txtOrigin.Text.Trim() == "")
                {
                    MessageBox.Show("请录入始发站信息！");
                }
                else if (txtDestination.Text.Trim() == "")
                {
                    MessageBox.Show("请录入送达地址信息！");
                }
                else if (txtReceiverPhone1.Text == "")
                {
                    MessageBox.Show("请录入收货人联系方式！");
                }


            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (deliveryId != "")
            {
                for (int i = 0; i < deliveryorderList.Count; i++)
                {
                    if (deliveryorderList[i].DeliveryOrderId.Equals(deliveryId))
                    {
                        // deliveryorderList[i].DeliveryOrderId = txtOrderId.Text;
                        //deliveryorderList[i].DeliveryId = txtDeliveryId.Text;
                        deliveryorderList[i].Origin = txtOrigin.Text;
                        deliveryorderList[i].BeginTime = DateTime.Now;
                        deliveryorderList[i].Destination = txtDestination.Text;
                        deliveryorderList[i].Remark = txtRemark.Text;
                        try
                        {
                            deliveryorderList[i].Longitude = double.Parse(lblLng.Text);
                        }
                        catch (Exception ex)
                        {
                            deliveryorderList[i].Longitude = 0;
                            lblLng.Text = "";
                        }
                        try
                        {
                            deliveryorderList[i].Latitude = double.Parse(lblLat.Text);
                        }
                        catch (Exception ex)
                        {
                            deliveryorderList[i].Latitude = 0;
                            lblLat.Text = "";
                        }
                        deliveryorderList[i].PredictDeliveryTime = DateTime.Now .AddHours(1);
                        //deliveryorderList[i].DeliveryTime = dTDeliveryTime.Value;
                        deliveryorderList[i].ClientId = cbxClientId.SelectedValue.ToString();
                        deliveryorderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", deliveryorderList[i].ClientId))[0].ClientName;
                        //deliveryorderList[i].Signer = txtSigner.Text;
                        //deliveryorderList[i].Telephone = txtTelephone.Text;
                        deliveryorderList[i].Receiver = txtReceiver.Text;
                        deliveryorderList[i].ReceiverPhone1 = txtReceiverPhone1.Text;
                        deliveryorderList[i].ReceiverPhone2 = txtReceiverPhone2.Text;
                        deliveryorderList[i].ReceiverPhone3 = txtReceiverPhone3.Text;
                        //deliveryorderList[i].Remark = txtRemark.Text;
                        //deliveryorderList[i].PaymentMethod = cbxPaymentMethod.SelectedValue.ToString();
                        if (rBtnCashPay.Checked == true)
                        {
                            deliveryorderList[i].PaymentMethod = rBtnCashPay.Text;
                        }
                        if (rBtnForwardPay.Checked == true)
                        {
                            deliveryorderList[i].PaymentMethod = rBtnForwardPay.Text;
                        }
                        if (rBtnMonthPay.Checked == true)
                        {
                            deliveryorderList[i].PaymentMethod = rBtnMonthPay.Text;
                        }

                        deliveryorderList[i].TotalFee = decimal.Parse(lblTotalFee.Text);
                        deliveryorderList[i].IsEnd = false;
                        deliveryorderList[i].IsChecked = false;
                        deliveryorderList[i].AirWaybillID = txtAirWaybillID.Text;
                      //deliveryorderList[i].IsBackFee = chkIsBackFee.Checked;
                        try
                        {
                            deliveryorderList[i].Amount = decimal.Parse(txtAmount.Text);
                        }
                        catch (Exception ex)
                        {
                            deliveryorderList[i].Amount = 0;
                            txtAmount.Text = 0 + "";
                        }
                        try
                        {
                            deliveryorderList[i].Receivable = decimal.Parse(txtReceivable.Text);
                        }
                        catch (Exception ex)
                        {
                            deliveryorderList[i].Receivable = 0;
                            txtReceivable.Text = 0 + "";
                        }
                        deliveryorderList[i].SourceTransType = cbxSourceTransType.Text;
                        deliveryorderList[i].SourceTransId = txtSourceTransId.Text;
                        deliveryorderList[i].IsDeliver = chkIsDeliver.Checked;
                        deliveryorderList[i].LogisCompanyID = usersinfo.CompanyId;
                        deliveryorderList[i].LogisCompanyShortName = info.CompanyShortName;
                        //break;
                    }

                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = deliveryorderList;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }
                }
            }
            else
            {

                MessageBox.Show("请选择物品信息");
            }
        }

        private void dgvProductDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string strdeliveryId = "";
            if (e.RowIndex > -1)
            {
                try
                {
                    deliveryId = dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryorderId"].Value.ToString();

                }
                catch (Exception ex)
                {
                    deliveryId = "";
                }
            }
            YueYePlat.Model.deliveryorder orderInfo = deliveryorderList.Find(v => v.DeliveryOrderId.Equals(deliveryId));
            if (orderInfo != null)
            {
                if (operate == "view")
                {
                    lblOrderId.Text = orderInfo.DeliveryOrderId;
                }
                //txtOrderId.Text = orderInfo.DeliveryOrderId;
                txtAmount.Text = orderInfo.Amount.ToString();
                txtOrigin.Text = orderInfo.Origin;
                txtDestination.Text = orderInfo.Destination;
                lblLat.Text = orderInfo.Latitude.ToString();
                lblLng.Text = orderInfo.Longitude.ToString();
                //txtSigner.Text = orderInfo.Signer;
                //txtTelephone.Text = orderInfo.Telephone;
                lblTotalFee.Text = orderInfo.TotalFee.ToString();
                //cbxPaymentMethod.SelectedValue = orderInfo.PaymentMethod;
                if (orderInfo.PaymentMethod != null)
                {
                    if (orderInfo.PaymentMethod.ToString() == rBtnCashPay.Text)
                    {
                        rBtnCashPay.Checked = true;
                    }
                    else if (orderInfo.PaymentMethod.ToString() == rBtnForwardPay.Text)
                    {
                        rBtnForwardPay.Checked = true;
                    }
                    else if (orderInfo.PaymentMethod.ToString() == rBtnMonthPay.Text)
                    {
                        rBtnMonthPay.Checked = true;
                    }
                }
                txtReceiver.Text = orderInfo.Receiver;
                txtReceiverPhone1.Text = orderInfo.ReceiverPhone1;
                txtReceiverPhone2.Text = orderInfo.ReceiverPhone2;
                txtReceiverPhone3.Text = orderInfo.ReceiverPhone3;
                cbxSourceTransType.Text = orderInfo.SourceTransType;
                txtSourceTransId.Text = orderInfo.SourceTransId;
                txtReceivable.Text = orderInfo.Receivable.ToString();
                txtAirWaybillID.Text = orderInfo.AirWaybillID;
                txtRemark.Text = orderInfo.Remark;                
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderInfo.ClientId));
                cbxClientCompany.SelectedValue = clientList[0].CompanyId;
                cbxClientId.SelectedValue = orderInfo.ClientId;

                //chkIsBackFee.Checked = orderInfo.IsBackFee;
                //dTBeginTime.Text = orderInfo.BeginTime.ToString();
                //dTDeliveryTime.Text = orderInfo.DeliveryTime.ToString();
                //datePredictDeliveryTime.Text = orderInfo.PredictDeliveryTime.ToString();
                chkIsDeliver.Checked = orderInfo.IsDeliver;
                string orderfee = "";
                List<YueYePlat.Model.deliveryorderfee> orderfeeInfo = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", orderInfo.DeliveryOrderId));
                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                try
                {
                    feeList = orderfeeInfo;
                }
                catch (Exception ex)
                {
                    feeList = new List<YueYePlat.Model.deliveryorderfee>();
                }
                for (int i = 0; i < orderfeeInfo.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeInfo[i].FeeTypeId));
                    if (feetype[0].isDetail == false)
                    {
                        orderfee += orderfeeInfo[i].FeeTypeId.ToString() + ":" + orderfeeInfo[i].Fee.ToString() + ";  ";
                    }
                    else
                    {
                        List<YueYePlat.Model.productdelivery> productInfo = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}' and  OrderDetailId='{1}'", orderInfo.DeliveryOrderId, orderfeeInfo[i].DeliveryOrderDetailID));
                        for (int j = 0; j < productInfo.Count; j++)
                        {
                            orderfee += orderfeeInfo[i].FeeTypeId.ToString() + ":" + orderfeeInfo[i].Fee.ToString() + "*" + productInfo[j].Quantity.ToString() + "(数量)";
                        }

                    }
                }
                //lblFeeInfo .Text= orderfee;                
                //cbxlogiscompany.SelectedValue = orderInfo.LogisCompanyShortName;  
                List<YueYePlat.Model.productdelivery> productdeliveryList = new List<YueYePlat.Model.productdelivery>();             
                //productList = orderInfo.ProductList;
                if (productList != null)
                {
                    for (int i = 0; i < productList.Count; i++)
                    {
                        if (productList[i].DeliveryOrderId.Equals(orderInfo.DeliveryOrderId))
                        {
                            productdeliveryList.Add(productList[i]);                          
                        }
                    }
                }
                if (productdeliveryList != null)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    for (int i = 0; i < productdeliveryList.Count; i++)
                    {
                        productdeliveryList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productdeliveryList[i].ProductId))[0].ProductName;
                        // productList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Id='{0}'",productList[i].Feetype))[0].FeeTypeName;
                    }
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                }
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productdeliveryList;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if (deliveryId != "")
            //{
            //    for (int i = 0; i < deliveryorderList.Count; i++)
            //    {
            //        if (deliveryorderList[i].DeliveryOrderId.Equals(deliveryId))
            //        {
            //            YueYePlat.Model.deliveryorder model = deliveryorderList[i];
            //            deliveryorderList.Remove(model);
            //            break;
            //        }
            //    }
            //    dgvOrderList.DataSource = null;
            //    dgvOrderList.DataSource = deliveryorderList;
            //    if (dgvOrderList.Rows.Count > 0)
            //    {
            //        dgvOrderList.Rows[0].Selected = false;
            //    }
            //    deliveryId = "";
            //}
            //else
            //{
            //    MessageBox.Show("请选择订单信息！");
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.DataSource == null)
            {
                MessageBox.Show("请先增加要保存的数据！");
            }
            else
            {
                if (operate == "add")
                {
                    if (MessageBox.Show("请仔细核对您将要添加的数据，确认无误后请点击‘确定’按钮", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (lblDeliveryId .Text !="")
                        {
                            if (cbxVehicleId.SelectedValue != null && cbxDriver1Id.SelectedValue != null && cbxTempDeviceId.SelectedValue != null)
                            {
                                //MessageBox.Show();
                            }
                            YueYePlat.Model.vehicledelivery vehicledelivery = new YueYePlat.Model.vehicledelivery();
                            vehicledelivery.DeliveryId = lblDeliveryId.Text;
                            if (cbxVehicleId.SelectedValue != null && cbxVehicleId.SelectedValue.ToString () != "")
                            {
                                vehicledelivery.VehicleId = cbxVehicleId.SelectedValue.ToString();
                            }
                            if (cbxTempDeviceId.SelectedValue != null && cbxTempDeviceId.SelectedValue.ToString () !="")
                            {
                                vehicledelivery.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                                List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", cbxTempDeviceId.SelectedValue));
                                if (deviceuseList.Count == 0)
                                {
                                    YueYePlat.Model.deviceuseinfo deviceuseInfo = new YueYePlat.Model.deviceuseinfo();
                                    deviceuseInfo.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                    deviceuseInfo.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                                    deviceuseInfo.IfBind = true;
                                    deviceuseInfo.BindTime = DateTime.Now;
                                    new YueYePlat.BLL.deviceuseinfo().Add(deviceuseInfo);
                                }
                                else
                                {
                                    if (deviceuseList[deviceuseList.Count - 1].IfBind == false)
                                    {
                                        YueYePlat.Model.deviceuseinfo deviceuseInfo = new YueYePlat.Model.deviceuseinfo();
                                        deviceuseInfo.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                        deviceuseInfo.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                                        deviceuseInfo.IfBind = true;
                                        deviceuseInfo.BindTime = DateTime.Now;
                                        new YueYePlat.BLL.deviceuseinfo().Add(deviceuseInfo);
                                    }
                                }
                            }                          

                            if (cbxDriver1Id.SelectedValue != null && cbxDriver1Id.SelectedValue.ToString() != "")
                            {
                                vehicledelivery.Driver1Id = cbxDriver1Id.SelectedValue.ToString();
                            }

                            if (cbxDriver2Id.SelectedValue != null && cbxDriver2Id.SelectedValue.ToString() != "")
                            {
                                vehicledelivery.Driver2Id = cbxDriver2Id.SelectedValue.ToString();
                            }

                            vehicledelivery.RecordId = usersinfo.UserId;
                            //if (cbxAuditor.SelectedValue != null)
                            //{
                            //    vehicledelivery.Auditor = cbxAuditor.SelectedValue.ToString();
                            //}
                            //vehicledelivery.IfEnd = chkIfEnd.Checked;
                            vehicledelivery.IfEnd = false;
                            vehicledelivery.IfChargeback = false;                         
                            try
                            {
                                vehicledelivery.MaxTempThreshold = double.Parse(txtMaxTempThreshold.Text);
                            }
                            catch (Exception ex)
                            {
                                vehicledelivery.MaxTempThreshold = null;
                                txtMaxTempThreshold.Text = "";
                            }
                            try
                            {
                                vehicledelivery.MinTempThreshold = double.Parse(txtMinTempThreshold.Text);
                            }
                            catch (Exception ex)
                            {
                                vehicledelivery.MinTempThreshold = null;
                                txtMinTempThreshold.Text = "";
                            }
                            try
                            {
                                vehicledelivery.MaxHumThreshold = double.Parse(txtMaxHumThreshold.Text);
                            }
                            catch (Exception ex)
                            {
                                vehicledelivery.MaxHumThreshold = null;
                                txtMaxHumThreshold.Text = "";
                            }
                            try
                            {
                                vehicledelivery.MinHumThreshold = double.Parse(txtMinHumThreshold.Text);
                            }
                            catch (Exception ex)
                            {
                                vehicledelivery.MinHumThreshold = null;
                                txtMinHumThreshold.Text = "";
                            }
                            vehicledelivery.BeginTime = DateTime.Now;                            
                            vehicledelivery.Origin = txtOrigin.Text;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                            List<YueYePlat.Model.vehicledelivery> vehicledeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", lblDeliveryId.Text));
                            if (vehicledeliveryList.Count > 0)
                            {
                                MessageBox.Show("该配送单号已经存在，请重新增加！");
                            }
                            else
                            {                                
                                YueYePlat.Model.deliveryorder deliveryorder = new YueYePlat.Model.deliveryorder();
                                for (int i = 0; i < deliveryorderList.Count; i++)
                                {
                                    if (deliveryorderList[i].Id == 0)
                                    {
                                        new YueYePlat.BLL.deliveryorder().Add(deliveryorderList[i]);
                                        for (int k = 0; k < orderTotalFeeList.Count; k++)
                                        {
                                            if (orderTotalFeeList[k].DeliveryOrderId == deliveryorderList[i].DeliveryOrderId)
                                            {
                                                YueYePlat.Model.deliveryorderfee orderfee = new YueYePlat.Model.deliveryorderfee();
                                                orderfee.DeliveryOrderId = orderTotalFeeList[k].DeliveryOrderId;
                                                orderfee.DeliveryOrderDetailID = orderTotalFeeList[k].DeliveryOrderDetailID;
                                                orderfee.IsShow = orderTotalFeeList[k].IsShow;
                                                orderfee.FeeTypeId = orderTotalFeeList[k].FeeTypeId;
                                                orderfee.Fee = orderTotalFeeList[k].Fee;
                                                orderfee.Remark = orderTotalFeeList[k].Remark;
                                                new YueYePlat.BLL.deliveryorderfee().Add(orderfee);
                                            }
                                        }
                                     
                                        if (productList == null) productList = new List<YueYePlat.Model.productdelivery>();

                                        for (int j = 0; j < productList.Count; j++)
                                        {

                                            if (productList[j].DeliveryOrderId == deliveryorderList[i].DeliveryOrderId)
                                            {
                                                if (productList[j].Id == 0)
                                                {
                                                    new YueYePlat.BLL.productdelivery().Add(productList[j]);
                                                }
                                                else
                                                {
                                                    new YueYePlat.BLL.productdelivery().Update(productList[j]);
                                                }

                                            }                                           
                                        }

                                    }
                                    else
                                    {
                                        new YueYePlat.BLL.deliveryorder().Update(deliveryorderList[i]);
                                        for (int k = 0; k < orderTotalFeeList.Count; k++)
                                        {
                                            if (orderTotalFeeList[k].DeliveryOrderId == deliveryorderList[i].DeliveryOrderId)
                                            {
                                                YueYePlat.Model.deliveryorderfee orderfee = new YueYePlat.Model.deliveryorderfee();
                                                orderfee.DeliveryOrderId = orderTotalFeeList[k].DeliveryOrderId;
                                                orderfee.DeliveryOrderDetailID = orderTotalFeeList[k].DeliveryOrderDetailID;
                                                orderfee.IsShow = orderTotalFeeList[k].IsShow;
                                                orderfee.FeeTypeId = orderTotalFeeList[k].FeeTypeId;
                                                orderfee.Fee = orderTotalFeeList[k].Fee;
                                                orderfee.Remark = orderTotalFeeList[k].Remark;
                                                new YueYePlat.BLL.deliveryorderfee().Add(orderfee);
                                            }
                                        }
                                        //for (int j = 0; j < deliveryorderList[i].ProductList.Count; j++)
                                        //{
                                        //    if (deliveryorderList[i].ProductList[j].Id == 0)
                                        //    {
                                        //        new YueYePlat.BLL.productdelivery().Add(deliveryorderList[i].ProductList[j]);
                                        //    }
                                        //    else
                                        //    {
                                        //        new YueYePlat.BLL.productdelivery().Update(deliveryorderList[i].ProductList[j]);
                                        //    }
                                        //}
                                        for (int j = 0; j < productList.Count; j++)
                                        {

                                            if (productList[j].DeliveryOrderId == deliveryorderList[i].DeliveryOrderId)
                                            {
                                                if (productList[j].Id == 0)
                                                {
                                                    new YueYePlat.BLL.productdelivery().Add(productList[j]);
                                                }
                                                else
                                                {
                                                    new YueYePlat.BLL.productdelivery().Update(productList[j]);
                                                }
                                            }
                                        }
                                    }
                                }
                                if (new YueYePlat.BLL.vehicledelivery().Add(vehicledelivery))
                                {

                                    if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                    {
                                        FrmTransferOrderReport report = new FrmTransferOrderReport();
                                        report.strDetailFee = "detailFee";
                                        report.deliveryOrderId = lblOrderId.Text ;
                                        report.usersInfo = usersinfo;
                                        if (report.ShowDialog() == DialogResult.OK)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        FrmTransferOrderReport report = new FrmTransferOrderReport();
                                        report.strDetailFee = "nodetailFee";
                                        report.deliveryOrderId = lblOrderId.Text;
                                        report.usersInfo = usersinfo;
                                        if (report.ShowDialog() == DialogResult.OK)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }                                   
                                }                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("请将车辆信息,设备信息,驾驶员信息完善！");
                        }
                    }
                }
                if (operate == "modify")
                {
                    if (MessageBox.Show("请仔细核对您将要修改的数据，确认无误后请点击‘确定’按钮", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (delivery == null) delivery = new YueYePlat.Model.vehicledelivery();
                        if (cbxVehicleId.SelectedValue != null && cbxVehicleId.SelectedValue.ToString ()!="" )
                        {
                            delivery.VehicleId = cbxVehicleId.SelectedValue.ToString();                            
                        }
                        if (cbxTempDeviceId.SelectedValue != null && cbxTempDeviceId.SelectedValue.ToString() != "")
                        {
                            delivery.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                            List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", cbxTempDeviceId.SelectedValue));
                            if (deviceuseList.Count == 0)
                            {
                                YueYePlat.Model.deviceuseinfo deviceuseInfo = new YueYePlat.Model.deviceuseinfo();
                                deviceuseInfo.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                deviceuseInfo.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                                deviceuseInfo.IfBind = true;
                                deviceuseInfo.BindTime = DateTime.Now;
                                new YueYePlat.BLL.deviceuseinfo().Add(deviceuseInfo);
                            }
                            else
                            {
                                if (deviceuseList[deviceuseList.Count - 1].IfBind == false)
                                {
                                    YueYePlat.Model.deviceuseinfo deviceuseInfo = new YueYePlat.Model.deviceuseinfo();
                                    deviceuseInfo.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                    deviceuseInfo.DeviceId = cbxTempDeviceId.SelectedValue.ToString();
                                    deviceuseInfo.IfBind = true;
                                    deviceuseInfo.BindTime = DateTime.Now;
                                    new YueYePlat.BLL.deviceuseinfo().Add(deviceuseInfo);
                                }
                            }
                        }
                        if (cbxDriver1Id.SelectedValue != null)
                        {
                            delivery.Driver1Id = cbxDriver1Id.SelectedValue.ToString();
                        }
                        if (cbxDriver2Id.SelectedValue != null)
                        {
                            delivery.Driver2Id = cbxDriver2Id.SelectedValue.ToString();
                        }
                        delivery.Origin = txtOrigin.Text;
                        //delivery.RecordId = usersinfo.UserId;                        
                        //delivery.IfEnd = false;
                        //delivery.BeginTime = DateTime.Now ;                                              
                        try
                        {
                            delivery.MaxTempThreshold = double.Parse(txtMaxTempThreshold.Text);
                        }
                        catch (Exception ex)
                        {
                            delivery.MaxTempThreshold = null;
                            txtMaxTempThreshold.Text = "";
                        }
                        try
                        {
                            delivery.MinTempThreshold = double.Parse(txtMinTempThreshold.Text);
                        }
                        catch (Exception ex)
                        {
                            delivery.MinTempThreshold = null;
                            txtMinTempThreshold.Text = "";
                        }
                        try
                        {
                            delivery.MaxHumThreshold = double.Parse(txtMaxHumThreshold.Text);
                        }
                        catch (Exception ex)
                        {
                            delivery.MaxHumThreshold = null;
                            txtMaxHumThreshold.Text = "";
                        }
                        try
                        {
                            delivery.MinHumThreshold = double.Parse(txtMinHumThreshold.Text);
                        }
                        catch (Exception ex)
                        {
                            delivery.MinHumThreshold = null;
                            txtMinHumThreshold.Text = "";
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                        new YueYePlat.BLL.vehicledelivery().Update(delivery);
                        YueYePlat.Model.deliveryorder deliveryorder = new YueYePlat.Model.deliveryorder();
                        for (int i = 0; i < deliveryorderList.Count; i++)
                        {
                            if (deliveryorderList[i].Id == 0)
                            {
                                new YueYePlat.BLL.deliveryorder().Add(deliveryorderList[i]);
                                for (int j = 0; j < productList.Count; j++)
                                {
                                    if (productList[j].DeliveryOrderId == deliveryorderList[i].DeliveryOrderId)
                                    {
                                        if (productList[j].Id == 0)
                                        {
                                            new YueYePlat.BLL.productdelivery().Add(productList[j]);
                                        }
                                        else
                                        {
                                            new YueYePlat.BLL.productdelivery().Update(productList[j]);
                                        }
                                    }
                                }                    
                            }
                            else
                            {
                                new YueYePlat.BLL.deliveryorder().Update(deliveryorderList[i]);                                
                                if (productList == null) productList = new List<YueYePlat.Model.productdelivery>();                               
                                productsList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format ("DeliveryOrderId='{0}'", deliveryorderList[i].DeliveryOrderId));
                                var update = productList.Where(a => productsList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                                {
                                    for (int j = 0; j < update.Count; j++)
                                    {
                                        new YueYePlat.BLL.productdelivery().Update(update[j]);
                                    }                                    
                                }
                                var delete = productsList.Where(a => !productList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                                {
                                    for (int j = 0; j < delete.Count; j++)
                                    {
                                        new YueYePlat.BLL.productdelivery().Delete(delete[j].Id);
                                    }
                                }
                                var add = productList.Where(a => !productsList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                                {
                                    for (int j = 0; j < add.Count; j++)
                                    {
                                        new YueYePlat.BLL.productdelivery().Add (add[j]);
                                    }
                                }                            
                                List<YueYePlat.Model.deliveryorderfee> orderFeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryorderList[i].DeliveryOrderId));
                                var updateFee = feeList.Where(a => orderFeeList.Exists(t => a.FeeTypeId.ToString().Contains(t.FeeTypeId.ToString()))).ToList();
                                {
                                    for (int j = 0; j < updateFee.Count; j++)
                                    {
                                        for (int k = 0; k < orderFeeList.Count; k++)
                                        {
                                            if (updateFee[j].FeeTypeId.Equals(orderFeeList[k].FeeTypeId))
                                            {
                                                updateFee[j].Id = orderFeeList[k].Id;
                                                new YueYePlat.BLL.deliveryorderfee().Update(updateFee[j]);
                                                break;
                                            }
                                        }                                        
                                    }
                                }                            
                                var deleteFee = orderFeeList.Where(a => !feeList.Exists(t => a.FeeTypeId.ToString().Contains(t.FeeTypeId.ToString()))).ToList();
                                {
                                    for (int j = 0; j < deleteFee.Count; j++)
                                    {
                                        new YueYePlat.BLL.deliveryorderfee().Delete(deleteFee[j].Id);
                                    }
                                }
                                var addFee = feeList.Where(a => !orderFeeList.Exists(t => a.FeeTypeId.ToString().Contains(t.FeeTypeId.ToString()))).ToList();
                                {
                                    for (int j = 0; j < addFee.Count; j++)
                                    {
                                        new YueYePlat.BLL.deliveryorderfee().Add(addFee[j]);
                                    }
                                }                                
                            }
                        }
                    }
                    if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        FrmTransferOrderReport report = new FrmTransferOrderReport();
                        report.strDetailFee = "detailFee";
                        report.deliveryOrderId = lblOrderId.Text;
                        report.usersInfo = usersinfo;
                        if (report.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        FrmTransferOrderReport report = new FrmTransferOrderReport();
                        report.strDetailFee = "nodetailFee";
                        report.deliveryOrderId = lblOrderId.Text;
                        report.usersInfo = usersinfo;
                        if (report.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }                   
                }
            }
        }

        private void btnOpenMap_Click(object sender, EventArgs e)
        {
            FrmBaiduMap map = new FrmBaiduMap();
            map.Text = "地图展示";
            if (map.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = FrmBaiduMap.destionation;
                lblLat.Text = FrmBaiduMap.lat;
                lblLng.Text = FrmBaiduMap.lng;
            }
        }

        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            FrmTransferOrderReport orderReport = new FrmTransferOrderReport();
            orderReport.Show();
        }

        private void dTDeliveryTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxVehicleId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxVehicleId.SelectedValue != null)
            {
                string strVehicleId = cbxVehicleId.SelectedValue.ToString();

                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format ("vehicleId='{0}'",strVehicleId));
                if (vehicleList[0].IFBelongsto == true)
                {
                    List<YueYePlat.Model.deviceuseinfo> deviceList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", strVehicleId));
                    if (deviceList.Count > 0)
                    {
                        if (deviceList[deviceList.Count - 1].IfBind == true)
                        {
                            //cbxTempDeviceId.SelectedValue = deviceList[deviceList.Count - 1].DeviceId;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            List<YueYePlat.Model.terminaldeviceinfo> deviceInfos = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceList[deviceList.Count - 1].DeviceId));
                            cbxTempDeviceId.DisplayMember = "DeviceName";
                            cbxTempDeviceId.ValueMember = "DeviceId";
                            cbxTempDeviceId.DataSource = deviceInfos;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                        }
                        else
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            List<YueYePlat.Model.terminaldeviceinfo> deviceInfo = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyId='{0}'", usersinfo.CompanyId));
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                            List<YueYePlat.Model.terminaldeviceinfo> tempdeviceList = new List<YueYePlat.Model.terminaldeviceinfo>();
                            for (int i = 0; i < deviceInfo.Count; i++)
                            {
                                List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", deviceInfo[i].DeviceId));

                                if (deviceuseList.Count == 0)
                                {
                                    tempdeviceList.Add(deviceInfo[i]);
                                }
                                else
                                {
                                    if (deviceuseList[deviceuseList.Count - 1].IfBind == false)
                                    {
                                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                        List<YueYePlat.Model.terminaldeviceinfo> deviceinfo = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[deviceuseList.Count - 1].DeviceId));
                                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                                        tempdeviceList.Add(deviceinfo[0]);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            cbxTempDeviceId.DataSource = tempdeviceList;
                            if (tempdeviceList.Count == 0)
                            {
                                cbxTempDeviceId.Text = "";
                            }
                        }
                    }
                    else
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.terminaldeviceinfo> deviceInfo = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyId='{0}'", usersinfo.CompanyId));
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                        List<YueYePlat.Model.terminaldeviceinfo> tempdeviceList = new List<YueYePlat.Model.terminaldeviceinfo>();
                        for (int i = 0; i < deviceInfo.Count; i++)
                        {
                            List<YueYePlat.Model.deviceuseinfo> useList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", deviceInfo[i].DeviceId));
                            //List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", deviceInfo[i].DeviceId));
                            if (useList.Count > 0)
                            {
                                if (useList[useList.Count - 1].IfBind == false)
                                {
                                    tempdeviceList.Add(deviceInfo[i]);
                                }
                            }
                            else
                            {
                                tempdeviceList.Add(deviceInfo[i]);
                            }

                        }
                        cbxTempDeviceId.DataSource = tempdeviceList;
                        if (tempdeviceList.Count == 0)
                        {
                            cbxTempDeviceId.Text = "";
                        }
                    }
                }
                else
                {
                    cbxTempDeviceId.DataSource = null;
                    List<YueYePlat.Model.driverinfo> tempdriver = new List<YueYePlat.Model.driverinfo>();
                    List<YueYePlat.Model.tempvehicleinfo> tempVehicle = new YueYePlat.BLL.tempvehicleinfo().GetModelList(String.Format ("VehicleId='{0}'",strVehicleId));
                    if (tempVehicle.Count > 0)
                    {
                        for (int i = 0; i < tempVehicle.Count; i++)
                        {
                            List<YueYePlat.Model.driverinfo> driverInfo = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", tempVehicle[i].DriverId));
                            tempdriver.Add(driverInfo[0]);
                        }
                        cbxDriver1Id.DisplayMember = "DriverName";
                        cbxDriver1Id.ValueMember = "DriverId";
                        cbxDriver1Id.DataSource = tempdriver;
                    }
                    else
                    {
                        MessageBox.Show("请务必增加驾驶员信息！");
                    }
                }


            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    orderId = int.Parse(dgvProductList.Rows[e.RowIndex].Cells["columnID"].Value.ToString());
                }
                catch (Exception ex)
                {
                    orderId = -1;
                }
            }
        }
        private void dgvProductDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryorderId"].Value.ToString();
                int cid = e.ColumnIndex;
                string strcolName = this.dgvOrderList.Columns[cid].DefaultCellStyle.NullValue.ToString();
                if (strcolName == "删除")
                {
                    if (deliveryId != "")
                    {
                        for (int i = 0; i < deliveryorderList.Count; i++)
                        {
                            if (deliveryorderList[i].DeliveryOrderId.Equals(deliveryId))
                            {
                                for (int j = 0; j < productList.Count; j++)
                                {
                                    if (productList[j].DeliveryOrderId.Equals(deliveryId))
                                    {
                                        YueYePlat.Model.productdelivery product = productList[j];
                                        productList.Remove(product);
                                    }
                                }
                                for (int j = 0; j < orderTotalFeeList.Count; j++)
                                {
                                    if (orderTotalFeeList[j].DeliveryOrderId.Equals(deliveryId))
                                    {
                                        YueYePlat.Model.deliveryorderfee fee = orderTotalFeeList[j];
                                        orderTotalFeeList.Remove(fee);
                                    }
                                }
                                YueYePlat.Model.deliveryorder model = deliveryorderList[i];
                                deliveryorderList.Remove(model);
                                break;
                            }
                        }
                        dgvProductList.DataSource = null;
                        dgvOrderList.DataSource = null;
                        dgvOrderList.DataSource = deliveryorderList;
                        if (dgvOrderList.Rows.Count > 0)
                        {
                            dgvOrderList.Rows[0].Selected = false;
                        }
                        deliveryId = "";
                    }
                    else
                    {
                        MessageBox.Show("请选择订单信息！");
                    }
                }
                //if (strcolName == "增加货品")
                //{
                //    FrmTranferAddProduct product = new FrmTranferAddProduct();
                //    product.strOrderId = str;
                //    product.usersInfo = usersinfo;
                //    product.orderdetail = feeList;
                //    if (product.ShowDialog() == DialogResult.OK)
                //    {
                //        if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                //        for (int i = 0; i < product.feeList.Count; i++)
                //        {
                //            feeList.Add(product.feeList[i]);
                //            orderTotalFeeList.Add(product.feeList[i]);
                //        }
                //        decimal totalorderfee = 0;
                //        for (int i = 0; i < feeList.Count; i++)
                //        {
                //            List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                //            if (feetype[0].isDetail == false)
                //            {
                //                totalorderfee += feeList[i].Fee;
                //            }
                //            else
                //            {
                //                totalorderfee = totalorderfee + feeList[i].Fee * decimal.Parse(feeList[i].ProductCount);
                //            }
                //        }
                //        lblTotalFee.Text = totalorderfee.ToString();
                //        //lblTotalFee.Text = (decimal.Parse(lblTotalFee.Text) + product.productFee).ToString();
                //        //deliveryorderList[deliveryorderList.Count - 1].TotalFee = totalorderfee;
                //        deliveryorderList[0].TotalFee = totalorderfee;
                //        YueYePlat.Model.deliveryorder orderModel = deliveryorderList.Find(order => order.DeliveryOrderId.Equals(str));
                //        if (orderModel.ProductList == null) orderModel.ProductList = new List<YueYePlat.Model.productdelivery>();
                //        orderModel.ProductList.Add(product.productInfo);
                //        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                //        for (int i = 0; i < orderModel.ProductList.Count; i++)
                //        {
                //            orderModel.ProductList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", orderModel.ProductList[i].ProductId))[0].ProductName;
                //        }
                //        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                //        dgvProductList.DataSource = null;
                //        dgvProductList.DataSource = orderModel.ProductList;
                //        productList = orderModel.ProductList;
                //        if (dgvProductList.Rows.Count > 0)
                //        {
                //            dgvProductList.Rows[0].Selected = false;
                //        }
                //        if (dgvOrderList.Rows.Count > 0)
                //        {
                //            dgvOrderList.Rows[0].Selected = false;
                //        }
                //    }
                //}
            }
        }
        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    int cid = e.ColumnIndex;
                    string strProductId = dgvProductList.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                    string strOrderDetailId = dgvProductList.Rows[e.RowIndex].Cells["colOrderDetailId"].Value.ToString();
                    string strcolName = this.dgvProductList.Columns[cid].DefaultCellStyle.NullValue.ToString();

                    if (strcolName == "增加")
                    {
                        FrmTranferAddProduct product = new FrmTranferAddProduct();
                        product.usersInfo = usersinfo;
                    }
                    if (strcolName == "修改")
                    {

                        for (int j = 0; j < productList.Count; j++)
                        {
                            if (productList[j].ProductId.ToString().Equals(strProductId))
                            {
                                //订单选中如果修改
                                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                                List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                                if (feeList.Count == 0)
                                {
                                    for (int k = 0; k < orderTotalFeeList.Count; k++)
                                    {
                                        if (orderTotalFeeList[k].DeliveryOrderDetailID != null && orderTotalFeeList[k].DeliveryOrderDetailID != "")
                                        {
                                            if (orderTotalFeeList[k].DeliveryOrderId.Equals(productList[j].DeliveryOrderId) && orderTotalFeeList[k].DeliveryOrderDetailID.Equals(productList[k].OrderDetailId))
                                            {
                                                feeList.Add(orderTotalFeeList[k]);
                                            }
                                        }
                                        else
                                        {
                                            orderfeeList.Add(orderTotalFeeList[k]);
                                        }
                                    }
                                }

                                FrmTranferAddProduct productinfo = new FrmTranferAddProduct();
                                productinfo.usersInfo = usersinfo;
                                productinfo.strOrderId = productList[j].DeliveryOrderId;
                                productinfo.productInfo = productList[j];
                                productinfo.feeList = feeList;
                                if (productinfo.ShowDialog() == DialogResult.OK)
                                {
                                    feeList = productinfo.feeList;
                                    decimal totalfee = 0;
                                    for (int n = 0; n < feeList.Count; n++)
                                    {
                                        if (feeList[n].DeliveryOrderDetailID.Equals(strOrderDetailId))
                                        {
                                            totalfee += feeList[n].Fee;
                                            productList[j].Totalfee = totalfee;
                                        }
                                        else
                                        {
                                            productList[j].Totalfee = 0;
                                        }
                                    }
                                    for (int k = 0; k < productList.Count; k++)
                                    {
                                        if (productList[k].ProductId.ToString().Equals(strProductId))
                                        {
                                            productList[k].OrderDetailId = productinfo.productInfo.OrderDetailId;
                                            productList[k].ProductId = productinfo.productInfo.ProductId;
                                            productList[k].Quantity = productinfo.productInfo.Quantity;
                                            productList[k].ProductName = productinfo.productInfo.ProductName;
                                            productList[k].Remark = productinfo.productInfo.Remark;
                                            productList[k].Weight = productinfo.productInfo.Weight;
                                            productList[k].VolumeDescription = productinfo.productInfo.VolumeDescription;
                                        }
                                    }
                                    ////筛选显示
                                    //List<YueYePlat.Model.productdelivery> productDeliveryList = new List<YueYePlat.Model.productdelivery>();
                                    //for (int k = 0; k < productList.Count; k++)
                                    //{
                                    //    if (productList[k].DeliveryOrderId.Equals(deliveryId))
                                    //    {
                                    //        productDeliveryList.Add(productList[k]);
                                    //    }
                                    //}
                                    //dgvProductList.DataSource = null;
                                    //dgvProductList.DataSource = productDeliveryList;
                                    //if (dgvProductList.Rows.Count > 0)
                                    //{
                                    //    dgvProductList.Rows[0].Selected = false;
                                    //}
                                    decimal totalorderfee = 0;
                                    for (int k = 0; k < feeList.Count; k++)
                                    {
                                        totalorderfee += feeList[k].Fee;
                                    }
                                    lblTotalFee.Text = totalorderfee.ToString();
                                }
                                break;
                            }
                        }

                    }
                    if (strcolName == "删除")
                    {
                        if (orderId != -1)
                        {
                            for (int i = 0; i < productList.Count; i++)
                            {
                                if (productList[i].ProductId.Equals(strProductId))
                                {
                                    YueYePlat.Model.productdelivery model = productList[i];
                                    if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                                    if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                                    for (int j = 0; j < orderTotalFeeList.Count; j++)
                                    {
                                        if (orderTotalFeeList[j].DeliveryOrderId.Equals(productList[i].DeliveryOrderId) && orderTotalFeeList[j].DeliveryOrderDetailID.Equals(productList[i].OrderDetailId))
                                        {
                                            //feeList.Add(orderTotalFeeList[j]);
                                        }
                                    }
                                    for (int j = 0; j < feeList.Count; j++)
                                    {
                                        if (feeList[j].DeliveryOrderDetailID != null)
                                        {
                                            if (feeList[j].DeliveryOrderDetailID.Equals(model.OrderDetailId))
                                            {
                                                feeList.Remove(feeList[j]);
                                            }
                                        }

                                    }
                                    productList.Remove(model);
                                    break;
                                }
                            }

                            dgvProductList.DataSource = null;
                            dgvProductList.DataSource = productList;
                            if (dgvProductList.Rows.Count > 0)
                            {
                                dgvProductList.Rows[0].Selected = false;
                            }

                            decimal totalorderfee = 0;
                            for (int k = 0; k < feeList.Count; k++)
                            {
                                List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[k].FeeTypeId));
                                if (feetype[0].isDetail == false)
                                {
                                    totalorderfee += feeList[k].Fee;
                                }
                                else
                                {
                                    totalorderfee += feeList[k].Fee;
                                }
                            }
                            lblTotalFee.Text = totalorderfee.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(ex);
                }
            }
        }
        private void btnFee_Click(object sender, EventArgs e)
        {           
            FrmTransferFee fee = new FrmTransferFee();
            if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
            if (curOrder != null)
            {
                List<YueYePlat.Model.deliveryorderfee> orderFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < orderTotalFeeList.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id= '{0}'", orderTotalFeeList[i].FeeTypeId));
                    if (feetypeList[0].isDetail == false)
                    {
                        orderFeeList.Add(orderTotalFeeList[i]);
                    }
                }
                fee.feeList = orderFeeList;
            }
            else
            {
                fee.feeList = feeList;
            }            
            if (deliveryId == "")
            {
                fee.deliveryOrderId = lblOrderId.Text;
            }
            else
            {
                fee.deliveryOrderId = deliveryId;
            }
            //fee.strFeeInfo = lblFeeInfo.Text;                
            if (fee.ShowDialog() == DialogResult.OK)
            {              
                feeList = fee.feeList;
                decimal totalorderfee = 0;
                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < feeList.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                    if (feetype[0].isDetail == false)
                    {
                        totalorderfee += feeList[i].Fee;
                    }
                    else
                    {
                        totalorderfee += feeList[i].Fee;
                    }
                }
                lblTotalFee.Text = totalorderfee.ToString ();
                ////lblFeeInfo.Text = feeList;
                //for (int i = 0; i < feeList.Count; i++)
                //{
                //    lblTotalFee.Text =(decimal.Parse( lblTotalFee.Text) + feeList[i].Fee).ToString ();                    
                //}
            }
        }

        private void btnFee_MouseEnter(object sender, EventArgs e)
        {
            //lblFeeInfo.Visible = true;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmClientAddOrUpdate client = new FrmClientAddOrUpdate();
            client.usersInfo = usersinfo;
            if (client.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
                cbxClientId.DisplayMember = "ClientName";
                cbxClientId.ValueMember = "ClientId";
                cbxClientId.DataSource = clientList;
                cbxClientId.SelectedValue = clientList[clientList.Count - 1].ClientId;

                List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
                cbxClientCompany.DisplayMember = "CompanyName";
                cbxClientCompany.ValueMember = "CompanyId";
                cbxClientCompany.DataSource = companyList;
                cbxClientCompany.SelectedValue = companyList[companyList.Count - 1].CompanyID;
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            FrmVehicleAddOrUpdate vehicle = new FrmVehicleAddOrUpdate();
            vehicle.usersInfo = usersinfo;
            if (vehicle.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
                List<YueYePlat.Model.vehicleinfo> vehicleInfo = new List<YueYePlat.Model.vehicleinfo>();
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("VehicleId='{0}'", vehicleList[i].VehicleId));
                    if (deliveryList.Count == 0)
                    {
                        vehicleInfo.Add(vehicleList[i]);
                    }
                    else
                    {
                        if (deliveryList[deliveryList.Count - 1].IfEnd == true)
                        {
                            vehicleInfo.Add(vehicleList[i]);
                        }
                    }
                }
                cbxVehicleId.DisplayMember = "VehicleNumber";
                cbxVehicleId.ValueMember = "VehicleId";
                cbxVehicleId.DataSource = vehicleInfo;
                cbxVehicleId.SelectedValue = vehicleInfo[vehicleInfo.Count - 1].VehicleId;
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            FrmDriverAddOrUpdate driver = new FrmDriverAddOrUpdate();
            driver.usersInfo = usersinfo;
            if (driver.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("Type='{0} or Type='{1}''", "正式", "临时"));
                cbxDriver1Id.DisplayMember = "DriverName";
                cbxDriver1Id.ValueMember = "DriverId";
                cbxDriver1Id.DataSource = driverList;
                cbxDriver1Id.SelectedValue = driverList[driverList.Count - 1].DriverId;
            }
        }

        private void cbxClientId_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxClientId.SelectedValue != null)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                    List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", cbxClientId.SelectedValue.ToString()));
                    if (clientList.Count > 0)
                    {
                        cbxClientCompany.SelectedValue = clientList[0].CompanyId;
                        lblClientTelephone.Text = clientList[0].Mobile.ToString();
                        if (clientList[0].Mobile.ToString() != "")
                        {
                            if (clientList[0].Telephone.ToString() != "")
                            {
                                lblClientTelephone.Text += "/" + clientList[0].Telephone.ToString();
                            }
                        }
                        else
                        {
                            if (clientList[0].Telephone.ToString() != "")
                            {
                                lblClientTelephone.Text += clientList[0].Telephone.ToString();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
        private void cbxClientCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxClientCompany.SelectedValue != null)
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("CompanyId='{0}'", cbxClientCompany.SelectedValue.ToString()));
                cbxClientId.DisplayMember = "ClientName";
                cbxClientId.ValueMember = "ClientId";
                cbxClientId.DataSource = clientList;
            }
            if (cbxClientCompany.SelectedValue == null || cbxClientCompany.SelectedValue.ToString() == "")
            {
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format(""));
                cbxClientId.DisplayMember = "ClientName";
                cbxClientId.ValueMember = "ClientId";
                cbxClientId.DataSource = clientList;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int productId = 0;
            FrmTranferAddProduct product = new FrmTranferAddProduct();
            if (deliveryId != "")
            {
                product.strOrderId = deliveryId;
            }
            else
            {
                product.strOrderId = lblOrderId.Text;
            }           
            product.usersInfo = usersinfo;
            product.productId = productId;
            product.orderdetail = productList;
            if (product.ShowDialog() == DialogResult.OK)
            {
               
                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < product.feeList.Count; i++)
                {
                    feeList.Add(product.feeList[i]);                  
                }
                decimal totalorderfee = 0;
                for (int i = 0; i < feeList.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                    if (feetype[0].isDetail == false)
                    {
                        totalorderfee += feeList[i].Fee;
                    }
                    else
                    {
                        totalorderfee += feeList[i].Fee;
                    }
                }
                lblTotalFee.Text = totalorderfee.ToString();
                //YueYePlat.Model.deliveryorder orderModel = deliveryorderList.Find(order => order.DeliveryOrderId.Equals(lblOrderId));
                if (productList == null) productList = new List<YueYePlat.Model.productdelivery>();
                for (int i = 0; i < product.productdeliveryList.Count; i++)
                {
                    product.productdeliveryList[i].Id = productId;
                    productList.Add(product.productdeliveryList[i]);
                   
                }             
                List<YueYePlat.Model.productdelivery> productdelivery = new List<YueYePlat.Model.productdelivery>();
                for (int i = 0; i < productList.Count; i++)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(info.CompanyDBName);
                    if (productList[i].Feetype != null)
                    {
                        productList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", productList[i].Feetype))[0].FeeTypeName;
                    }
                    if (deliveryId != "")
                    {
                        if (productList[i].DeliveryOrderId.Equals(deliveryId))
                        {
                            productdelivery.Add(productList[i]);
                        }
                    }
                    else
                    {
                        if (productList[i].DeliveryOrderId.Equals(lblOrderId.Text))
                        {
                            productdelivery.Add(productList[i]);
                        }
                    }         
                   
                }
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productdelivery;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }
            }
        }

        private void btnFeeInfo_Click(object sender, EventArgs e)
        {
            FrmTransferFeeInfo feeInfo = new FrmTransferFeeInfo();
            feeInfo.totalfeeList = feeList;
            feeInfo.Show();

        }

        private void dgvProductList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //DataGridView dgv = (DataGridView)(sender);
            //if (e.RowIndex == -1 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
            //{
            //    //e.CellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            //    //e.CellStyle.WrapMode = DataGridViewTriState.True;
            //    if (e.ColumnIndex == 0)
            //    {
            //        top = e.CellBounds.Top;
            //        left = e.CellBounds.Left;
            //        height = e.CellBounds.Height;
            //        width1 = e.CellBounds.Width;
            //    }

            //    int width2 = this.dgvProductList.Columns[1].Width;

            //    Rectangle rect = new Rectangle(left, top, width1 + width2, e.CellBounds.Height);
            //    using (Brush backColorBrush = new SolidBrush(e.CellStyle.BackColor))
            //    {
            //        //抹去原来的cell背景
            //        e.Graphics.FillRectangle(backColorBrush, rect);
            //    }

            //    using (Pen gridLinePen = new Pen(dgv.GridColor))
            //    {
            //        //e.Graphics.DrawLine(gridLinePen, left, top, left + width1 + width2, top);
            //        //e.Graphics.DrawLine(gridLinePen, left, top + height / 2, left + width1 + width2, top + height / 2);
            //        //e.Graphics.DrawLine(gridLinePen, left + width1, top + height / 2, left + width1, top + height);

            //        //计算绘制字符串的位置
            //        string columnValue = "操作";
            //        SizeF sf = e.Graphics.MeasureString(columnValue, e.CellStyle.Font);
            //        float lstr = (width1 + width2 - sf.Width)/2 ;
            //        float rstr = (height  - sf.Height) /2;
            //        //画出文本框
            //        if (columnValue != "")
            //        {
            //            e.Graphics.DrawString(columnValue, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor),
            //             left + lstr,
            //             top + rstr,
            //             StringFormat.GenericDefault);
            //        }

            //        ////计算绘制字符串的位置
            //        //columnValue = "局网台资产额";
            //        //sf = e.Graphics.MeasureString(columnValue, e.CellStyle.Font);
            //        //lstr = (width1 - sf.Width) / 2;
            //        //rstr = (height / 2 - sf.Height) / 2;
            //        ////画出文本框
            //        //if (columnValue != "")
            //        //{
            //        //    e.Graphics.DrawString(columnValue, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor),
            //        //   left + lstr,
            //        //    top + height / 2 + rstr,
            //        //    StringFormat.GenericDefault);
            //        //}

            //        ////计算绘制字符串的位置
            //        //columnValue = "网络资产额";
            //        //sf = e.Graphics.MeasureString(columnValue, e.CellStyle.Font);
            //        //lstr = (width2 - sf.Width) / 2;
            //        //rstr = (height / 2 - sf.Height) / 2;
            //        ////画出文本框
            //        //if (columnValue != "")
            //        //{
            //        //    e.Graphics.DrawString(columnValue, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor),
            //        //   left + width1 + lstr,
            //        //   top + height / 2 + rstr,
            //        //    StringFormat.GenericDefault);
            //        //}
            //        //    }
            //        e.Handled = true;
            //    }
            //}
        }  
      
        private void dgvProductList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvProductList.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductId.ToString().Equals(str))
                    {
                        FrmTranferAddProduct product = new FrmTranferAddProduct();
                        product.usersInfo = usersinfo;
                        product.productInfo = productList[i];
                        List<YueYePlat.Model.deliveryorderfee> productFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                        List<YueYePlat.Model.deliveryorderfee> orderFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                        if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                        for (int j = 0; j < feeList.Count; j++)
                        {
                            if (feeList[j].DeliveryOrderDetailID != "")
                            {
                                if (feeList[j].DeliveryOrderDetailID.Equals(productList[i].OrderDetailId))
                                {
                                    productFeeList.Add(feeList[j]);
                                }
                            }
                            else
                            {
                                orderFeeList.Add(feeList[j]);
                            }
                        }
                        product.feeList = productFeeList;
                        if (product.ShowDialog() == DialogResult.OK)
                        {
                            feeList = product.feeList;
                            //加上订单费用
                            for (int j = 0; j < orderFeeList.Count; j++)
                            {
                                feeList.Add(orderFeeList[j]);
                            }
                            decimal totalorderfee = 0;
                            if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                            for (int j = 0; j < feeList.Count; j++)
                            {
                                totalorderfee += feeList[j].Fee;
                            }
                            lblTotalFee.Text = totalorderfee.ToString();
                            break;
                        }

                    }
                }
            }

        }

        private void cbxSourceTransType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxSourceTransType.Text.ToString() != "")
            {
                if (cbxSourceTransType.Text.ToString() == "空运")
                {
                    lblSourceTransId.Text = "航班号";
                }
                else if (cbxSourceTransType.Text.ToString() == "铁路")
                {
                    lblSourceTransId.Text = "列车号";
                }
                else if (cbxSourceTransType.Text.ToString() == "海运")
                {
                    lblSourceTransId.Text = "航次号";
                }
                else if (cbxSourceTransType.Text.ToString() == "汽运")
                {
                    lblSourceTransId.Text = "司机电话";
                }
            }
        }

        private void btnDeviceBind_Click(object sender, EventArgs e)
        {
            if (cbxVehicleId.SelectedValue != null)
            {
                FrmDeviceUse use = new FrmDeviceUse();
                use.usersInfo = usersinfo;
                use.strVehicleId = cbxVehicleId.SelectedValue.ToString ();
                if (use.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请选择你要解除绑定的车辆！");
            }

           

        }

        private void cbxTempDeviceId_Click(object sender, EventArgs e)
        {
            if ( cbxVehicleId.SelectedValue == null)
            {
                MessageBox.Show("请先选择车辆信息！");
            }
        }

        private void txtReceiver_Click(object sender, EventArgs e)
        {
            //if (txtOrigin.Text == "")
            //{
            //    MessageBox.Show("请先输入起点信息！");
            //}
        }

        private void txtReceiverPhone1_Enter(object sender, EventArgs e)
        {
       
        }

        private void cbxClientId_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbxClientCompany.SelectedValue == null || cbxClientCompany.SelectedValue.ToString() == "")
            {
                MessageBox.Show("请选择客户所在公司！");
            }
        }
    }
    
}
