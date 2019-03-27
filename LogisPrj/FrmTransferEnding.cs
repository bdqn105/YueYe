using Log;
using Qiniu.IO;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTransferEnding : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        string returnOrderName;
        string clientReturnOrderName;
        string returnOrderPath;
        string clientReturnOrderPath;
        string returnOrderUrl="";
        string clientReturnOrderUrl="";
        static FrmTransferEnding instance;
        public string tabPageTitle = "";
        public string strOrderId = "";
        string strqiniu = "http://p94gz7ls5.bkt.clouddn.com";
        List<YueYePlat.Model.vehicledelivery> vehicleInfo;

        public FrmTransferEnding()
        {
            InitializeComponent();
        }
        public static FrmTransferEnding getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTransferEnding();
            }
            return instance;
        }
        private void txtOrderId_Click(object sender, EventArgs e)
        {

        }
        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "")
            {
                txtOrderId.Text = "请输入订单号";
                txtOrderId.ForeColor = Color.Silver;
            }
        }  

        private void FrmTransferEnding_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            btnSave.Visible = true;
            InitComponent();
            dgvProductList.AutoGenerateColumns = false;
            dgvReturnOrder.AutoGenerateColumns = false;             
            lblClientId.Text = "";
            lblDestionation.Text = "";
            lblOrigin.Text = "";
            lblPayMethod.Text = "";
            lblReceivable.Text = "";
            lblReceiver.Text = "";
            lblSourTransferType.Text = "";
            lblSourTransId.Text = "";
            lblTotalFee.Text = "";                     
            cbxDevice.SelectedValue = "";
            cbxDriver1Id.SelectedValue = "";
            cbxDriver2Id.SelectedValue = "";
            cbxTerminator.SelectedValue = "";
            cbxVehicle.SelectedValue = "";
            cbxAuditor.SelectedValue = usersInfo.UserId;
            if (strOrderId != "")
            {
                btnSearch.Visible = false;
                txtOrderId.Text = strOrderId;            
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", txtOrderId.Text));
                if (orderList.Count == 0)
                {
                    MessageBox.Show("没有该订单的信息，请确认输入正确的订单编号");
                }
                else
                {              
                    lblClientId.Text = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[0].ClientId))[0].ClientName;
                    lblOrigin.Text = orderList[0].Origin;
                    lblDestionation.Text = orderList[0].Destination;
                    lblReceiver.Text = orderList[0].Receiver;
                    lblReceivable.Text = orderList[0].Receivable.ToString();
                    lblPayMethod.Text = orderList[0].PaymentMethod;
                    lblSourTransferType.Text = orderList[0].SourceTransType;
                    lblSourTransId.Text = orderList[0].SourceTransId;
                    lblTotalFee.Text = orderList[0].TotalFee.ToString();
                    txtAmount.Text = orderList[0].Amount.ToString();
                    chkIsChecked.Checked = orderList[0].IsChecked;
                    if (dTArriveTime.Value != null)
                    {
                        dTArriveTime.Text = orderList[0].ArriveTime.ToString();
                    }
                    else
                    {
                        dTArriveTime.Text = DateTime.Now.ToString();
                    }               
                    if (orderList[0].ReturnOrderSrc != "")
                    {
                        returnOrderUrl = orderList[0].ReturnOrderSrc;
                        string strReturnOrderUrl = orderList[0].ReturnOrderSrc;
                        string accUrl = "";
                        if (!strReturnOrderUrl.Contains(strqiniu))
                        {
                            accUrl = strqiniu + "/" + strReturnOrderUrl;
                            picOrder.ImageLocation = @accUrl;
                        }
                        else
                        {
                            picOrder.ImageLocation = @accUrl;
                        }
                    }             
                    if (orderList[0].Terminator != "")
                    {
                        cbxTerminator.SelectedValue = orderList[0].Terminator;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[0].Terminator));
                        if (userList.Count > 0)
                        {
                            cbxTerminator.DataSource = userList;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }
                    else
                    {
                        cbxTerminator.SelectedValue = orderList[0].Terminator;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'",usersInfo.UserId));
                        if (userList.Count > 0)
                        {
                            cbxTerminator.DataSource = userList;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }
                    if (orderList[0].Auditor != "")
                    {
                        cbxAuditor.SelectedValue = orderList[0].Auditor;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> auditorList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[0].Auditor));
                        if (auditorList.Count > 0)
                        {
                            cbxAuditor.DataSource = auditorList;
                            cbxAuditor.SelectedValue = auditorList[0].UserId;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }
                    else
                    {
                        cbxAuditor.SelectedValue = orderList[0].Auditor;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", usersInfo.UserId));
                        if (userList.Count > 0)
                        {
                            cbxAuditor.DataSource = userList;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }
                    //cbxAuditor.SelectedValue = orderList[0].Auditor;
                    if (orderList[0].Signer.ToString().Trim() != "")
                    {
                        txtSigner.Text = orderList[0].Signer;
                    }
                    if (orderList[0].SignerCardID.ToString().Trim() != "")
                    {
                        txtSignerID.Text = orderList[0].SignerCardID;
                    }
                    if (orderList[0].Telephone.Trim() != "")
                    {
                        txtTelephone.Text = orderList[0].Telephone;
                    }
                    if (orderList[0].ReturnOrderSrc != null)
                    {
                       returnOrderUrl= orderList[0].ReturnOrderSrc;
                    }
                    if (orderList[0].ClientReturnOrderSrc != null)
                    {
                        clientReturnOrderUrl = orderList[0].ClientReturnOrderSrc;
                    }
                    vehicleInfo = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'  and ifchargeback=0", txtOrderId.Text.Trim().Substring(0, txtOrderId.Text.Length - 2)));
                    if (vehicleInfo.Count > 0)
                    {
                        if (vehicleInfo[0].VehicleId != null)
                        {
                            cbxVehicle.SelectedValue = vehicleInfo[0].VehicleId;
                            List<YueYePlat.Model.vehicleinfo> vehicle = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleInfo[0].VehicleId));
                            cbxVehicle.DataSource = vehicle;
                        }
                        if (vehicleInfo[0].Driver1Id != null && vehicleInfo[0].Driver1Id != "")
                        {
                            cbxDriver1Id.SelectedValue = vehicleInfo[0].Driver1Id;
                            List<YueYePlat.Model.driverinfo> driver1 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", vehicleInfo[0].Driver1Id));
                            cbxDriver1Id.DataSource = driver1;
                        }
                        if (vehicleInfo[0].Driver2Id != null && vehicleInfo[0].Driver2Id != "")
                        {
                            cbxDriver2Id.SelectedValue = vehicleInfo[0].Driver2Id;
                            List<YueYePlat.Model.driverinfo> driver2 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", vehicleInfo[0].Driver2Id));
                            cbxDriver2Id.DataSource = driver2;
                        }
                    }
                    List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", txtOrderId.Text));
                    for (int i = 0; i < productList.Count; i++)
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }

                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = productList;
                    if (dgvProductList.Rows.Count > 0)
                    {
                        dgvProductList.Rows[0].Selected = false;
                    }

                    List<YueYePlat.Model.clientreturnorder> returnOrderList = new YueYePlat.BLL.clientreturnorder().GetModelList(String.Format ("DeliveryOrderId='{0}'",strOrderId));
                    if (returnOrderList.Count > 0)
                    {
                        for (int i = 0; i < returnOrderList.Count; i++)
                        {
                            returnOrderList[i].ReturnOrderUrl=@returnOrderList[i].ReturnOrderUrl;
                        }
                    }
                    dgvReturnOrder.DataSource = null;
                    dgvReturnOrder.DataSource = returnOrderList;
                    if (dgvReturnOrder.Rows.Count > 0)
                    {                        
                        dgvReturnOrder.Rows[0].Selected = false;
                    }
                    if (orderList[0].IsChecked == true)
                    {                       
                        btnSave.Visible = false;                       
                        btnUploadReturnOrder.Visible = false;
                    }   
                                   

                }
            }


        }

        private void picClient_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitComponent()
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", usersInfo.UserId ));
            cbxAuditor.DisplayMember = "UserName";
            cbxAuditor.ValueMember = "UserId";
            cbxAuditor.DataSource = userList;
            List<YueYePlat .Model .usersinfo > terminator = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            cbxTerminator.DisplayMember = "UserName";
            cbxTerminator.ValueMember = "UserId";
            cbxTerminator.DataSource = terminator;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            List<YueYePlat .Model .vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicle.DisplayMember = "VehicleNumber";
            cbxVehicle.ValueMember = "VehicleId";
            cbxVehicle.DataSource = vehicleList;
            List<YueYePlat .Model .driverinfo> driver1 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type!='离职'"));
            cbxDriver1Id.DisplayMember = "DriverName";
            cbxDriver1Id.ValueMember = "DriverId";
            cbxDriver1Id.DataSource = driver1;
            List<YueYePlat .Model .driverinfo > driver2 = new YueYePlat.BLL.driverinfo().GetModelList("Type!='离职'");
            cbxDriver2Id.DisplayMember = "DriverName";
            cbxDriver2Id.ValueMember = "DriverId";
            cbxDriver2Id.DataSource = driver2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderId.Text.Trim() != "" && txtSigner.Text.Trim() != "" && cbxTerminator.SelectedValue != null)
                {
                    if (chkIsChecked.Checked == true && cbxAuditor.SelectedValue == null)
                    {
                        MessageBox.Show("请录入审核人信息！");
                    }
                    else
                    {
                        if (MessageBox.Show("请审核你要完结的订单信息，确定无误后，请点击“确定”！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {                            
                            bool isEnd = true;
                            List<YueYePlat.Model.deliveryorder> orderInfo = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", txtOrderId.Text));
                            if (orderInfo.Count > 0)
                            {
                                orderInfo[0].IsEnd = true;
                                if (chkIsChecked.Checked == true)
                                {
                                    orderInfo[0].IsChecked = chkIsChecked.Checked;
                                    orderInfo[0].Auditor = cbxAuditor.SelectedValue.ToString();
                                }
                                orderInfo[0].Signer = txtSigner.Text;
                                orderInfo[0].SignerCardID = txtSignerID.Text;
                                orderInfo[0].ReturnOrderSrc = returnOrderUrl;
                                orderInfo[0].ClientReturnOrderSrc = clientReturnOrderUrl;
                                orderInfo[0].ArriveTime = dTArriveTime.Value;
                                orderInfo[0].Telephone = txtTelephone.Text;
                                orderInfo[0].Terminator = cbxTerminator.SelectedValue.ToString();
                                if (new YueYePlat.BLL.deliveryorder().Update(orderInfo[0]))
                                {
                                    if (cbxDriver2Id.SelectedValue != null)
                                    {
                                        vehicleInfo[0].Driver2Id = cbxDriver2Id.SelectedValue.ToString();
                                        new YueYePlat.BLL.vehicledelivery().Update(vehicleInfo[0]);
                                    }
                                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", orderInfo[0].DeliveryId));
                                    for (int i = 0; i < orderList.Count; i++)
                                    {
                                        if (orderList[i].IsEnd == false)
                                        {
                                            isEnd = false;                                           
                                        }
                                    }
                                    if (isEnd == true)
                                    {
                                        List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}' and ifChargeback=0", orderInfo[0].DeliveryId));
                                        deliveryList[0].IfEnd = true;
                                        deliveryList[0].IfChargeback = false;
                                        deliveryList[0].Auditor = usersInfo.UserId;
                                        if (new YueYePlat.BLL.vehicledelivery().Update(deliveryList[0]))
                                        {
                                            MessageBox.Show("该车辆配送全部订单已完结！");
                                        }
                                    }
                                    if (MessageBox.Show("您是否继续完结其他订单？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                    {
                                        btnSearch.Visible = true;
                                        btnSave.Visible = true;
                                        dgvProductList.DataSource = null;
                                        lblClientId.Text = "";
                                        lblDestionation.Text = "";
                                        lblOrigin.Text = "";
                                        lblPayMethod.Text = "";
                                        lblReceivable.Text = "";
                                        lblReceiver.Text = "";
                                        lblSourTransferType.Text = "";
                                        lblSourTransId.Text = "";
                                        lblTotalFee.Text = "";                                      
                                        //cbxAuditor.SelectedValue = "";
                                        cbxDevice.SelectedValue = "";
                                        cbxDriver1Id.SelectedValue = "";
                                        cbxDriver2Id.SelectedValue = "";
                                        cbxTerminator.SelectedValue = "";
                                        cbxVehicle.SelectedValue = "";
                                        txtAmount.Text = "";
                                        txtSigner.Text = "";
                                        txtSignerID.Text = "";
                                        txtTelephone.Text = "";
                                    }
                                    else
                                    {
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (txtOrderId.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入完结的订单号！");
                    }
                    else if (txtSigner.Text.Trim() == "")
                    {
                        MessageBox.Show("请录入签收人信息！");
                    }
                    else if (cbxTerminator.SelectedValue == null)
                    {
                        MessageBox.Show("请录入完结人信息！");
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }



        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format ("DeliveryOrderId='{0}'",txtOrderId.Text ));
            if (orderList.Count == 0)
            {
                MessageBox.Show("没有该订单的信息，请确认输入正确的订单编号");
            }
            else 
            {           
                if (orderList[0].IsChecked == true)
                {
                    MessageBox.Show("该订单已经审核,您可以进行查看");
                    btnSave.Visible = false;
                    cbxTerminator.SelectedValue = orderList[0].Terminator;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format ("userId='{0}'",orderList[0].Terminator));
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    cbxTerminator.DataSource = userList;
                }
                else
                {
                }
                lblClientId.Text = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[0].ClientId))[0].ClientName;
                lblOrigin.Text = orderList[0].Origin;
                lblDestionation.Text = orderList[0].Destination;
                lblReceiver.Text = orderList[0].Receiver;
                lblReceivable.Text = orderList[0].Receivable.ToString();
                lblPayMethod.Text = orderList[0].PaymentMethod;
                lblSourTransferType.Text = orderList[0].SourceTransType;
                lblSourTransId.Text = orderList[0].SourceTransId;
                lblTotalFee.Text = orderList[0].TotalFee.ToString();
                txtAmount.Text = orderList[0].Amount.ToString();
                chkIsChecked.Checked = orderList[0].IsChecked;
                cbxAuditor.SelectedValue = orderList[0].Auditor;
                if (orderList[0].Signer.ToString().Trim() != "")
                {
                    txtSigner.Text = orderList[0].Signer;
                }
                if (orderList[0].SignerCardID.ToString().Trim() != "")
                {
                    txtSignerID.Text = orderList[0].SignerCardID;
                }
                if (orderList[0].Telephone.Trim() != "")
                {
                    txtTelephone.Text = orderList[0].Telephone;
                }
                if (orderList[0].ReturnOrderSrc != null)
                {
                    returnOrderUrl = orderList[0].ReturnOrderSrc;
                }
                if (orderList[0].ClientReturnOrderSrc != null)
                {
                    clientReturnOrderUrl = orderList[0].ClientReturnOrderSrc;
                }
                List<YueYePlat.Model.vehicledelivery> vehicleInfo = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", txtOrderId.Text.Trim().Substring(0, txtOrderId.Text.Length - 2)));
                if (vehicleInfo.Count > 0)
                {
                    for (int i = 0; i < vehicleInfo.Count; i++)
                    {
                        if (vehicleInfo[i].IfChargeback != true)
                        {
                            if (vehicleInfo[0].VehicleId != null)
                            {
                                cbxVehicle.SelectedValue = vehicleInfo[0].VehicleId;
                                List<YueYePlat.Model.vehicleinfo> vehicle = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleInfo[0].VehicleId));
                                cbxVehicle.DataSource = vehicle;
                            }
                            if (vehicleInfo[0].Driver1Id != null && vehicleInfo[0].Driver1Id != "")
                            {
                                cbxDriver1Id.SelectedValue = vehicleInfo[0].Driver1Id;
                                List<YueYePlat.Model.driverinfo> driver1 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", vehicleInfo[0].Driver1Id));
                                cbxDriver1Id.DataSource = driver1;
                            }
                            if (vehicleInfo[0].Driver2Id != null && vehicleInfo[0].Driver2Id != "")
                            {
                                cbxDriver2Id.SelectedValue = vehicleInfo[0].Driver2Id;
                                List<YueYePlat.Model.driverinfo> driver2 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", vehicleInfo[0].Driver2Id));
                                cbxDriver2Id.DataSource = driver2;
                            }
                        }
                    }
                }                

                List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", txtOrderId.Text));
                for (int i = 0; i < productList.Count; i++)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                }

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productList;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }            
            }
        }       
        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "请输入订单号")
            {
                txtOrderId.Text = "";
            }
           
            txtOrderId.ForeColor = Color.Black;
        }

        private void btnUploadReturnOrder_Click(object sender, EventArgs e)
        {
            if (returnOrderPath != null)
            {
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                //Settings.UrlPrefix = "https://portal.qiniu.com/user/key"; 
                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + txtOrderId.Text + "/" + GenerateOrderId(strOrderId);
                //上传路径
                string localFile = returnOrderPath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                returnOrderUrl = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
                YueYePlat.Model.clientreturnorder returnOrder = new YueYePlat.Model.clientreturnorder();
                returnOrder.DeliveryOrderId = txtOrderId.Text;
                returnOrder.ReturnOrderUrl = returnOrderUrl;
                returnOrder.UpLoadTime = DateTime.Now;
                if (new YueYePlat.BLL.clientreturnorder().Add(returnOrder))
                {
                    List<YueYePlat.Model.clientreturnorder> returnOrderList = new YueYePlat.BLL.clientreturnorder().GetModelList(String.Format ("DeliveryOrderId='{0}'",txtOrderId.Text ));
                    dgvReturnOrder.DataSource = null;
                    dgvReturnOrder.DataSource = returnOrderList;
                    if (dgvReturnOrder.Rows.Count > 0)
                    {
                        dgvReturnOrder.Rows[0].Selected = false;
                    }
                }

            }
        }

        private string GenerateOrderId(string deliveryOrderId)
        {
            string str = "Order";
            List<YueYePlat.Model.clientreturnorder> returnOrderList = new YueYePlat.BLL.clientreturnorder().GetModelList(String.Format ("ReturnOrderUrl like '%{0}%' order by ReturnOrderUrl desc ", strOrderId));
            
            if (returnOrderList.Count == 0)
            {
                if (returnOrderUrl == "")
                {
                    return str + "1";
                }
                else
                {
                    string cId = returnOrderUrl.Substring(returnOrderUrl.Length - 1,1);
                    string cidCount = "1" + cId;
                    int count = int.Parse(cidCount) + 1;
                    return str + count.ToString().Substring(1);
                }
                
            }
            else
            {
                try
                {
                    string cId = returnOrderList[0].ReturnOrderUrl.Substring(returnOrderList[0].ReturnOrderUrl.Length - 1);
                    string cidCount = "1" + cId;
                    int count = int.Parse(cidCount) + 1;
                    return str + count.ToString().Substring(1);
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(ex);
                    return "回单";
                }
            }
        }

        private void btnCientReturnOrder_Click(object sender, EventArgs e)
        {
            if (clientReturnOrderUrl!= "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = clientReturnOrderUrl;
                returnOrder.strReturnOrderName = "客户回单";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传客户回单！");
            }
        }

        private void btnUploadClientReturnOrder_Click(object sender, EventArgs e)
        {
            if (clientReturnOrderPath != null)
            {
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";               
                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + txtOrderId.Text + "/" + "Client";
                //上传路径
                string localFile = clientReturnOrderPath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                clientReturnOrderUrl = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            }
        }

        private void cbxVehicle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxVehicle.SelectedValue != null)
            {
                string strVehicleId = cbxVehicle.SelectedValue.ToString();
                List<YueYePlat.Model.deviceuseinfo> deviceList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", strVehicleId));
                if (deviceList.Count > 0)
                {
                    if (deviceList[deviceList.Count - 1].IfBind == true)
                    {
                        //cbxTempDeviceId.SelectedValue = deviceList[deviceList.Count - 1].DeviceId;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.terminaldeviceinfo> deviceInfos = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceList[deviceList.Count - 1].DeviceId));
                        cbxDevice.DisplayMember = "DeviceName";
                        cbxDevice.ValueMember = "DeviceId";
                        cbxDevice.DataSource = deviceInfos;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    }
                    else
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.terminaldeviceinfo> deviceInfo = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo .CompanyId));
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
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
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                    tempdeviceList.Add(deviceinfo[0]);
                                }
                            }
                        }
                        cbxDevice.DataSource = tempdeviceList;
                    }
                }
                else
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    List<YueYePlat.Model.terminaldeviceinfo> deviceInfo = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo. CompanyId));
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
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
                    cbxDevice.DataSource = tempdeviceList;
                }
            }
        }

        private void cbxDevice_Click(object sender, EventArgs e)
        {
            if (cbxVehicle.SelectedValue == null)
            {                
                MessageBox.Show("请先选择车辆信息");
            }           
        }

        private void btnLoadOrderImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                clientReturnOrderName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    clientReturnOrderPath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + clientReturnOrderName;
                    picOrder.Load(clientReturnOrderPath);
                }
                catch (Exception ex)
                {
                    clientReturnOrderPath = "";
                }

            }
        }

        private void picOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (returnOrderUrl!= "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = returnOrderUrl;
                returnOrder.strReturnOrderName = "物流公司回单";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传物流公司回单！");
            }
        }

        private void btnLoadOrderImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                returnOrderName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    returnOrderPath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + returnOrderName;
                    picOrder.Load(returnOrderPath);
                }
                catch (Exception ex)
                {
                    returnOrderPath = "";
                }

            }
        }

        private void picClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (clientReturnOrderUrl != "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = clientReturnOrderUrl;
                returnOrder.strReturnOrderName = "物流公司回单";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传物流公司回单！");
            }
        }     

        private void dgvReturnOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               
                string url= dgvReturnOrder.Rows[e.RowIndex].Cells["colReturnOrderUrl"].Value.ToString();
                if (url != "")
                {
                    FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                    returnOrder.usersInfo = usersInfo;
                    returnOrder.strReturnOrderUrl = url;
                    returnOrder.strReturnOrderName = "物流公司回单";
                    if (returnOrder.ShowDialog() == DialogResult.OK)
                    {

                    }
                }               
            }
        }

        private void dgvReturnOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = dgvReturnOrder.Rows[e.RowIndex].Cells["colReturnOrderUrl"].Value.ToString();
            if (url != null)
            {
                returnOrderUrl = url;
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
                int expireInSeconds = 3600;
                string accUrl = "";
                if (!url.Contains(strqiniu))
                {
                    accUrl = strqiniu + "/" + url;

                }
                else
                {
                    accUrl = DownloadManager.CreateSignedUrl(mac, url, expireInSeconds);
                }
                //图片异步加载完成后的处理事件 
                picOrder.LoadCompleted += new AsyncCompletedEventHandler(picOrder_LoadCompleted);
                //图片加载时，显示等待光标 
                picOrder.UseWaitCursor = true;
                //采用异步加载方式 
                picOrder.WaitOnLoad = false;
                //开始异步加载，图片的地址，请自行更换
                picOrder.LoadAsync(accUrl);

            }


        }

        private void picOrder_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void picOrder_Click(object sender, EventArgs e)
        {

        }
    }
}

