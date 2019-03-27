using Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTransAddNewOrder : Form
    {
        public string strDeliveryId = "";
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.deliveryorder curOrder;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        List<YueYePlat.Model.productdelivery> productdeliveryList;
        List<YueYePlat.Model.deliveryorderfee> orderFeeList;
        List<YueYePlat.Model.deliveryorderfee> orderTotalFeeList;
        DataTable dt;
        string endLocation = "";
        string endLng = "";
        string endLat = "";
        string newfeetype = "";
        public FrmTransAddNewOrder()
        {
            InitializeComponent();
        }
        private void FrmTransAddNewOrder_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            InitComponent();
            dgvProductList.AutoGenerateColumns = false;
            lblClientTelephone.Text = "";
            lblTotalFee.Text = 0 + "";
            cbxClientCompany.SelectedValue = "";
            cbxClientId.SelectedValue = "";
            cbxSourceTransType.Text = "空运";

            //DataGridViewImageColumn columnDelete = new DataGridViewImageColumn();
            //dgvProductList.Columns.Add(columnDelete);
            //columnDelete.HeaderText = "Image";
            //columnDelete.Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Images\\delete.png");


            if (curOrder != null)
            {
                lblOrderId.Text = curOrder.DeliveryOrderId;
                cbxClientId.SelectedValue = curOrder.ClientId;
                cbxClientCompany.SelectedValue = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", cbxClientId.SelectedValue.ToString()))[0].CompanyId;
                txtOrigin.Text = curOrder.Origin;
                txtDestination.Text = curOrder.Destination;
                txtReceiver.Text = curOrder.Receiver;
                txtReceiverPhone1.Text = curOrder.ReceiverPhone1;
                txtReceiverPhone2.Text = curOrder.ReceiverPhone2;
                txtReceiverPhone3.Text = curOrder.ReceiverPhone3;
                lblTotalFee.Text = curOrder.TotalFee.ToString();
                txtSourceTransId.Text = curOrder.SourceTransId;
                txtAmount.Text = curOrder.Amount.ToString();
                txtReceivable.Text = curOrder.Receivable.ToString();
                txtAirWaybillID.Text = curOrder.AirWaybillID;
                chkIftransfer.Checked = curOrder.IfTransfer;
                txtTransferName.Text = curOrder.TransferName;
                txtTransferFee.Text = curOrder.TransferFee.ToString();
                chkIsDeliver.Checked = curOrder.IsDeliver;
                cbxSourceTransType.Text = curOrder.SourceTransType;
                txtRemark.Text = curOrder.Remark;
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
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string feetype = config.AppSettings.Settings["feeType"].Value;
                string[] feeName = feetype.Split(';');

                


                for (int i = 0; i < feeName.Length; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    {
                        column.HeaderText = feeName[i];
                        List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("FeeTypeName='{0}'", feeName[i]));

                        column.Name = "colufee" + feetypeList[0].Id;
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        column.CellTemplate = new DataGridViewTextBoxCell();
                        column.CellTemplate.Style.BackColor = Color.White;
                        column.DataPropertyName = "colufee" + feetypeList[0].Id;
                    }
                    dgvProductList.Columns.Insert(dgvProductList.Columns.Count - 2, column);
                }
                orderTotalFeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrder.DeliveryOrderId));
                //if (orderTotalFeeList.Count > 0)
                //{
                //    for (int i = 0; i < orderTotalFeeList.Count; i++)
                //    {                       
                //        orderTotalFeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderTotalFeeList[i].FeeTypeId))[0].FeeTypeName;
                //        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                //        {
                //            column.HeaderText = orderTotalFeeList[i].FeetypeName;
                //            column.Name = "colufee" + orderTotalFeeList[i].FeeTypeId;
                //            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //            column.CellTemplate = new DataGridViewTextBoxCell();
                //            column.CellTemplate.Style.BackColor = Color.White;
                //            column.DataPropertyName = "colufee" + orderTotalFeeList[i].FeeTypeId;
                //        }
                //        dgvProductList.Columns.Insert(dgvProductList.Columns.Count - 2, column);
                //    }                   
                //}
                 dt = new DataTable();
                for (int count = 0; count < dgvProductList.Columns.Count; count++)
                {
                    try
                    {
                        DataColumn dc = new DataColumn(dgvProductList.Columns[count].Name.ToString());
                        dt.Columns.Add(dc);
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog(ex);
                    }
                }
                if (productdeliveryList == null) productdeliveryList = new List<YueYePlat.Model.productdelivery>();
                productdeliveryList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", curOrder.DeliveryOrderId));

                if (productdeliveryList.Count > 0)
                {

                    for (int i = 0; i < productdeliveryList.Count; i++)
                    {
                        decimal totalFee = 0; 
                        DataGridViewRow Row = new DataGridViewRow();
                        int index = dgvProductList.Rows.Add(Row);
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        productdeliveryList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productdeliveryList[i].ProductId))[0].ProductName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        dgvProductList.Rows[i].Cells["colProductId"].Value = productdeliveryList[i].ProductId;
                        dgvProductList.Rows[i].Cells["colProductName"].Value = productdeliveryList[i].ProductName;
                        dgvProductList.Rows[i].Cells["colQuantity"].Value = productdeliveryList[i].Quantity;
                        dgvProductList.Rows[i].Cells["colWeight"].Value = productdeliveryList[i].Weight;
                        dgvProductList.Rows[i].Cells["colVolumeDescription"].Value = productdeliveryList[i].VolumeDescription;
                        dgvProductList.Rows[i].Cells["colDelete"].Value = "X";
                        dgvProductList.Columns["colDelete"].DefaultCellStyle.ForeColor = Color.Red;
                        //FileStream fileStream = new FileStream(Application.StartupPath + "\\Images\\delete.png" , FileMode.Open, FileAccess.Read);
                        //int byteLength = (int)fileStream.Length;
                        //byte[] fileBytes = new byte[byteLength];
                        //fileStream.Read(fileBytes, 0, byteLength);
                        ////文件流关闭,文件解除锁定 
                        //fileStream.Close();
                        //this.dgvProductList.Rows[i].Cells["colDelete"].Value = Image.FromStream(new MemoryStream(fileBytes));
                        for (int j = 0; j < orderTotalFeeList.Count; j++)
                        {
                            totalFee += orderTotalFeeList[j].Fee;
                            if (productdeliveryList[i].DeliveryOrderId == orderTotalFeeList[j].DeliveryOrderId && productdeliveryList[i].OrderDetailId == orderTotalFeeList[j].DeliveryOrderDetailID)
                            {
                                if (dgvProductList.Columns.Contains("colufee" + orderTotalFeeList[j].FeeTypeId.ToString()))
                                {
                                    dgvProductList.Rows[i].Cells["colufee" + orderTotalFeeList[j].FeeTypeId].Value = orderTotalFeeList[j].Fee.ToString();
                                }
                            }
                        }
                        dgvProductList.Rows[i].Cells["colfee"].Value = totalFee;
                        for (int count = 0; count < dgvProductList.Rows.Count; count++)
                        {
                            DataRow dr = dt.NewRow();
                            for (int countsub = 0; countsub < dgvProductList.Columns.Count; countsub++)
                            {
                                try
                                {
                                    dr[countsub] = Convert.ToString(dgvProductList.Rows[count].Cells[countsub].Value);
                                }
                                catch (Exception ex)
                                {
                                    LogHelper.WriteLog(ex);
                                }
                            }
                            dt.Rows.Add(dr);
                            
                        }
                        Debug.WriteLine(dt.Rows.Count + "");
                    }
                }
                dgvProductList.DataSource = dt;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = true;
                }               
            }
            else
            {
                lblClientTelephone.Text = "";
                try
                {
                    lblOrderId.Text = GenerateOrderID(logiscompanyList[0].CompanyShortCode);
                }
                catch (Exception ex)
                {
                    btnOrderId.Visible = true;
                    MessageBox.Show("您可以手动设置订单号！");
                }
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string feetype = config.AppSettings.Settings["feeType"].Value;
                string[] feeName = feetype.Split(';');
                for (int i = 0; i < feeName.Length; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    {
                        column.HeaderText = feeName[i];
                        List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("FeeTypeName='{0}'", feeName[i]));
                        column.Name = "colufee" + feetypeList[0].Id;
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        column.CellTemplate = new DataGridViewTextBoxCell();
                        column.CellTemplate.Style.BackColor = Color.White;
                        column.DataPropertyName = "colufee" + feetypeList[0].Id;
                    }
                    dgvProductList.Columns.Insert(dgvProductList.Columns.Count - 2, column);
                }
            }

            string str_url = Application.StartupPath + "\\DeliveryEndPosition.html";
            Uri url = new Uri(str_url);
            webBrowser1.Url = url;
            webBrowser1.ObjectForScripting = this;
        }
        private string GenerateOrderID(string companyShortCode)
        {
            string str = companyShortCode + DateTime.Now.ToString("yyMMdd");
            List<YueYePlat.Model.deliveryorder> deliveryorderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId like '%{0}%' order by DeliveryOrderId desc", str));
            if (deliveryorderList.Count == 0)
            {
                return str + "000001";
            }
            else
            {
                string cId = deliveryorderList[0].DeliveryOrderId;
                string cidCount = "1" + cId.Substring(cId.Length - 6);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }
        private void InitComponent()
        {
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxClientCompany.DisplayMember = "CompanyName";
            cbxClientCompany.ValueMember = "CompanyId";
            cbxClientCompany.DataSource = companyList;
            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            cbxClientId.DisplayMember = "ClientName";
            cbxClientId.ValueMember = "ClientId";
            cbxClientId.DataSource = clientList;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
            DataGridViewComboBoxColumn dgvComboBoxColumn = dgvProductList.Columns["colProductName"] as DataGridViewComboBoxColumn;
            dgvComboBoxColumn.DataPropertyName = "colProductName";
            dgvComboBoxColumn.DataSource = productList;//必须在设置dataGridView1的DataSource的属性前设置
            dgvComboBoxColumn.DisplayMember = "ProductName";
            dgvComboBoxColumn.ValueMember = "ProductName";
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmClientAddOrUpdate client = new FrmClientAddOrUpdate();
            client.usersInfo = usersInfo;
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
        private void cbxClientCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxClientCompany.SelectedValue != null)
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
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
        private void cbxClientId_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbxClientCompany.SelectedValue == null || cbxClientCompany.SelectedValue.ToString() == "")
            {
                MessageBox.Show("请选择客户所在公司！");
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmTranferAddProduct product = new FrmTranferAddProduct();
            product.strOrderId = lblOrderId.Text;
            product.usersInfo = usersInfo;
            product.orderdetail = productdeliveryList;
            if (product.ShowDialog() == DialogResult.OK)
            {
                if (orderFeeList == null) orderFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                orderFeeList = product.feeList;
                orderTotalFeeList.AddRange(orderFeeList);
                if (orderFeeList == null) orderFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                decimal totalorderfee = 0;
                if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < orderTotalFeeList.Count; i++)
                {
                    totalorderfee += orderTotalFeeList[i].Fee;
                }
                lblTotalFee.Text = totalorderfee.ToString();
                if (productdeliveryList == null) productdeliveryList = new List<YueYePlat.Model.productdelivery>();
                try
                {
                    productdeliveryList.AddRange(product.productdeliveryList);
                }
                catch (Exception ex)
                {

                }
                if (product.productdeliveryList == null) product.productdeliveryList = new List<YueYePlat.Model.productdelivery>();

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productdeliveryList;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {           
            try
            {
                bool productIsNull = false;
                for (int i = 0; i < dgvProductList.Rows.Count; i++)
                {
                    if (dgvProductList.Rows[i].Cells["colProductName"].Value == null)
                    {
                        productIsNull = true;
                    }
                }
                if (productIsNull == true)
                {
                    MessageBox.Show("请录入表格中的货品信息!");
                }
                else
                {






                    if (curOrder == null)
                    {
                        if (cbxClientId.SelectedValue != null && txtOrigin.Text.Trim() != "")
                        {
                            if (MessageBox.Show("请仔细核对您将要添加的数据，确认无误后请点击‘确定’按钮", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                List<YueYePlat.Model.deliveryorder> orderIdList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", lblOrderId.Text.Trim()));
                                if (orderIdList.Count > 0)
                                {
                                    lblOrderId.Text = GenerateOrderID(logiscompanyList[0].CompanyShortCode);
                                }
                                YueYePlat.Model.productdelivery productInfo = new YueYePlat.Model.productdelivery();
                                for (int i = 0; i < dgvProductList.Rows.Count; i++)
                                {
                                    productInfo.DeliveryOrderId = lblOrderId.Text;
                                    productInfo.OrderDetailId = lblOrderId.Text.Trim().Substring(lblOrderId.Text.Length - 2) + "0" + (i + 1);
                                    for (int j = 0; j < dgvProductList.Columns.Count; j++)
                                    {
                                        if (dgvProductList.Columns[j].Name.IndexOf("colufee") >= 0)
                                        {
                                            YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                                            feeInfo.DeliveryOrderId = lblOrderId.Text;
                                            feeInfo.IsShow = true;
                                            feeInfo.DeliveryOrderDetailID = productInfo.OrderDetailId;
                                            feeInfo.FeeTypeId = int.Parse(dgvProductList.Columns[j].Name.Substring(7));
                                            if (int.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString()) != 0)
                                            {
                                                try
                                                {
                                                    feeInfo.Fee = decimal.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());
                                                }
                                                catch (Exception ex)
                                                {
                                                    feeInfo.Fee = 0;
                                                }
                                                new YueYePlat.BLL.deliveryorderfee().Add(feeInfo);
                                            }
                                        }
                                    }
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                    List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'", dgvProductList.Rows[i].Cells["colProductName"].Value.ToString()));
                                    if (productList.Count == 0)
                                    {
                                        YueYePlat.Model.productinfo product = new YueYePlat.Model.productinfo();
                                        product.ProductName = dgvProductList.Rows[i].Cells["colProductName"].Value.ToString();
                                        new YueYePlat.BLL.productinfo().Add(product);
                                        List<YueYePlat.Model.productinfo> products = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'", dgvProductList.Rows[i].Cells["colProductName"].Value.ToString()));
                                        productInfo.ProductId = products[0].ProductId;
                                    }
                                    else
                                    {
                                        productInfo.ProductId = productList[0].ProductId;
                                    }
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                    try
                                    {
                                        productInfo.Weight = double.Parse(dgvProductList.Rows[i].Cells["colWeight"].Value.ToString());
                                    }
                                    catch (Exception ex)
                                    {
                                        productInfo.Weight = 0;
                                    }
                                    try
                                    {
                                        productInfo.Quantity = int.Parse(dgvProductList.Rows[i].Cells["colQuantity"].Value.ToString());
                                    }
                                    catch (Exception ex)
                                    {
                                        productInfo.Quantity = 0;
                                    }
                                    try
                                    {
                                        productInfo.VolumeDescription = dgvProductList.Rows[i].Cells["colVolumeDescription"].Value.ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        productInfo.VolumeDescription = "";
                                    }
                                    new YueYePlat.BLL.productdelivery().Add(productInfo);
                                }

                                YueYePlat.Model.deliveryorder orderInfo = new YueYePlat.Model.deliveryorder();
                                orderInfo.DeliveryOrderId = lblOrderId.Text;
                                orderInfo.Origin = txtOrigin.Text;
                                orderInfo.BeginTime = DateTime.Now;
                                orderInfo.Destination = txtDestination.Text;
                                try
                                {
                                    orderInfo.Longitude = double.Parse(endLng);
                                }
                                catch (Exception ex)
                                {
                                    orderInfo.Longitude = null;
                                }
                                try
                                {
                                    orderInfo.Latitude = double.Parse(endLat);
                                }
                                catch (Exception ex)
                                {
                                    orderInfo.Latitude = null;
                                }
                                orderInfo.IfTransfer = chkIftransfer.Checked;
                                orderInfo.TransferName = txtTransferName.Text;
                                try
                                {
                                    orderInfo.TransferFee = decimal.Parse(txtTransferFee.Text);
                                }
                                catch
                                {
                                    txtTransferFee.Text = 0 + "";
                                    orderInfo.TransferFee = decimal.Parse(txtTransferFee.Text);
                                }
                                orderInfo.PredictDeliveryTime = DateTime.Now.AddHours(1);
                                orderInfo.ClientId = cbxClientId.SelectedValue.ToString();
                                orderInfo.Receiver = txtReceiver.Text;
                                orderInfo.ReceiverPhone1 = txtReceiverPhone1.Text;
                                if (txtReceiverPhone2.Text != "")
                                {
                                    orderInfo.ReceiverPhone2 = txtReceiverPhone2.Text;
                                }
                                if (txtReceiverPhone3.Text != "")
                                {
                                    orderInfo.ReceiverPhone3 = txtReceiverPhone3.Text;
                                }
                                try
                                {
                                    orderInfo.Amount = decimal.Parse(txtAmount.Text);
                                }
                                catch (Exception ex)
                                {
                                    orderInfo.Amount = 0;
                                    txtAmount.Text = 0 + "";
                                }
                                try
                                {
                                    orderInfo.Receivable = decimal.Parse(txtReceivable.Text);
                                    if (txtReceivable.Text == "0")
                                    {
                                        orderInfo.IsBackFee = false;
                                    }
                                    else
                                    {
                                        orderInfo.IsBackFee = true;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    orderInfo.Receivable = 0;
                                    txtReceivable.Text = 0 + "";
                                }
                                orderInfo.AirWaybillID = txtAirWaybillID.Text;
                                orderInfo.SourceTransType = cbxSourceTransType.Text;
                                orderInfo.SourceTransId = txtSourceTransId.Text;
                                orderInfo.IsDeliver = chkIsDeliver.Checked;
                                orderInfo.LogisCompanyID = usersInfo.CompanyId;
                                orderInfo.LogisCompanyShortName = logiscompanyList[0].CompanyShortName;
                                orderInfo.Remark = txtRemark.Text;
                                orderInfo.RecorderID = usersInfo.UserId;
                                if (rBtnCashPay.Checked == true)
                                {
                                    orderInfo.PaymentMethod = rBtnCashPay.Text;
                                }
                                if (rBtnForwardPay.Checked == true)
                                {
                                    orderInfo.PaymentMethod = rBtnForwardPay.Text;
                                }
                                if (rBtnMonthPay.Checked == true)
                                {
                                    orderInfo.PaymentMethod = rBtnMonthPay.Text;
                                }
                                orderInfo.IsEnd = false;
                                orderInfo.IsChecked = false;
                                orderInfo.TotalFee = decimal.Parse(lblTotalFee.Text);
                                //if (productdeliveryList == null) productdeliveryList = new List<YueYePlat.Model.productdelivery>();
                                //for (int i = 0; i < productdeliveryList.Count; i++)
                                //{
                                //    new YueYePlat.BLL.productdelivery().Add(productdeliveryList[i]);
                                //}
                                //if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                                //for (int i = 0; i < orderTotalFeeList.Count; i++)
                                //{
                                //    new YueYePlat.BLL.deliveryorderfee().Add(orderTotalFeeList[i]);
                                //}
                                if (new YueYePlat.BLL.deliveryorder().Add(orderInfo))
                                {
                                    if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        FrmTransferOrderReport report = new FrmTransferOrderReport();
                                        report.strDetailFee = "detailFee";
                                        report.deliveryOrderId = lblOrderId.Text;
                                        report.usersInfo = usersInfo;
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
                                        report.usersInfo = usersInfo;
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
                            if (cbxClientId.SelectedValue == null)
                            {
                                MessageBox.Show("请录入客户信息！");
                            }
                            else if (txtOrigin.Text.Trim() == "")
                            {
                                MessageBox.Show("请录入始发站信息！");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("您确定要修改该订单信息吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            List<YueYePlat.Model.deliveryorderfee> feeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderID='{0}'", lblOrderId.Text.Trim()));
                            for (int k = 0; k < feeList.Count; k++)
                            {
                                new YueYePlat.BLL.deliveryorderfee().Delete(feeList[k].Id);
                            }
                            List<YueYePlat.Model.productdelivery> newProductDeliveryList = new List<YueYePlat.Model.productdelivery>();
                            for (int i = 0; i < dgvProductList.Rows.Count; i++)
                            {
                                YueYePlat.Model.productdelivery productInfo = new YueYePlat.Model.productdelivery();
                                productInfo.DeliveryOrderId = lblOrderId.Text;
                                string OrderDetailId = lblOrderId.Text.Trim().Substring(lblOrderId.Text.Length - 2) + "0" + (i + 1);
                                productInfo.OrderDetailId = OrderDetailId;
                                for (int j = 0; j < dgvProductList.Columns.Count; j++)
                                {
                                    if (dgvProductList.Columns[j].Name.IndexOf("colufee") >= 0)
                                    {
                                        YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                                        feeInfo.DeliveryOrderId = lblOrderId.Text;
                                        feeInfo.IsShow = true;
                                        feeInfo.DeliveryOrderDetailID = OrderDetailId;
                                        feeInfo.FeeTypeId = int.Parse(dgvProductList.Columns[j].Name.Substring(7));
                                        //if (int.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString()) != 0)
                                        //{
                                        //    try
                                        //    {
                                        //        feeInfo.Fee = decimal.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());
                                        //    }
                                        //    catch (Exception ex)
                                        //    {
                                        //        feeInfo.Fee = 0;
                                        //    }
                                        //    new YueYePlat.BLL.deliveryorderfee().Add(feeInfo);
                                        //}
                                        try
                                        {
                                            feeInfo.Fee = decimal.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());
                                        }
                                        catch (Exception ex)
                                        {
                                            feeInfo.Fee = 0;
                                        }
                                        new YueYePlat.BLL.deliveryorderfee().Add(feeInfo);

                                        //for (int k = 0; k < orderTotalFeeList.Count; k++)
                                        //{
                                        //    if (productdeliveryList[i].DeliveryOrderId == orderTotalFeeList[k].DeliveryOrderId && productdeliveryList[i].OrderDetailId == orderTotalFeeList[k].DeliveryOrderDetailID)
                                        //    {

                                        //        YueYePlat.Model.deliveryorderfee feeInfo = orderTotalFeeList[k];
                                        //        //feeInfo.DeliveryOrderId = lblOrderId.Text;
                                        //        feeInfo.IsShow = true;
                                        //        //feeInfo.DeliveryOrderDetailID = productInfo.OrderDetailId;
                                        //        feeInfo.FeeTypeId = int.Parse(dgvProductList.Columns[j].Name.Substring(7));
                                        //        try
                                        //        {
                                        //            feeInfo.Fee = decimal.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());
                                        //        }
                                        //        catch (Exception ex)
                                        //        {
                                        //            feeInfo.Fee = 0;
                                        //        }
                                        //        new YueYePlat.BLL.deliveryorderfee().Update(feeInfo);
                                        //    }
                                        //}                                   

                                    }
                                }
                                try
                                {
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                    List<YueYePlat.Model.productinfo> productsList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'", dgvProductList.Rows[i].Cells["colProductName"].Value.ToString()));
                                    if (productsList.Count == 0)
                                    {
                                        YueYePlat.Model.productinfo product = new YueYePlat.Model.productinfo();
                                        product.ProductName = dgvProductList.Rows[i].Cells["colProductName"].Value.ToString();
                                        new YueYePlat.BLL.productinfo().Add(product);
                                        List<YueYePlat.Model.productinfo> products = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'", dgvProductList.Rows[i].Cells["colProductName"].Value.ToString()));
                                        productInfo.ProductId = products[0].ProductId;
                                    }
                                    else
                                    {
                                        productInfo.ProductId = productsList[0].ProductId;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                try
                                {
                                    productInfo.Weight = double.Parse(dgvProductList.Rows[i].Cells["colWeight"].Value.ToString());
                                }
                                catch (Exception ex)
                                {
                                    productInfo.Weight = 0;
                                }
                                try
                                {
                                    productInfo.Quantity = int.Parse(dgvProductList.Rows[i].Cells["colQuantity"].Value.ToString());
                                }
                                catch (Exception ex)
                                {
                                    productInfo.Quantity = 0;
                                }
                                try
                                {
                                    productInfo.VolumeDescription = dgvProductList.Rows[i].Cells["colVolumeDescription"].Value.ToString();
                                }
                                catch (Exception ex)
                                {
                                    productInfo.VolumeDescription = "";
                                }
                                newProductDeliveryList.Add(productInfo);
                            }
                            List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", lblOrderId.Text));

                            var update = newProductDeliveryList.Where(a => productList.Exists(t => a.ProductId.Contains(t.ProductId))).ToList();
                            {
                                for (int j = 0; j < update.Count; j++)
                                {
                                    new YueYePlat.BLL.productdelivery().Update(update[j]);
                                }

                            }
                            var delete = productList.Where(a => !newProductDeliveryList.Exists(t => a.ProductId.Contains(t.ProductId))).ToList();
                            {
                                for (int j = 0; j < delete.Count; j++)
                                {
                                    new YueYePlat.BLL.productdelivery().Delete(delete[j].Id);
                                }
                            }
                            var add = newProductDeliveryList.Where(a => !productList.Exists(t => a.ProductId.Contains(t.ProductId))).ToList();
                            {
                                for (int j = 0; j < add.Count; j++)
                                {
                                    new YueYePlat.BLL.productdelivery().Add(add[j]);
                                }
                            }










                            //  curOrder.DeliveryOrderId = lblOrderId.Text;
                            curOrder.Origin = txtOrigin.Text;
                            //curOrder.BeginTime = DateTime.Now;
                            curOrder.Destination = txtDestination.Text;
                            try
                            {
                                curOrder.Longitude = double.Parse(endLng);
                            }
                            catch (Exception ex)
                            {
                                curOrder.Longitude = null;
                            }
                            try
                            {
                                curOrder.Latitude = double.Parse(endLat);
                            }
                            catch (Exception ex)
                            {
                                curOrder.Latitude = null;
                            }
                            curOrder.IfTransfer = chkIftransfer.Checked;
                            curOrder.TransferName = txtTransferName.Text;
                            try
                            {
                                curOrder.TransferFee = decimal.Parse(txtTransferFee.Text);
                            }
                            catch
                            {
                                txtTransferFee.Text = 0 + "";
                                curOrder.TransferFee = decimal.Parse(txtTransferFee.Text);
                            }
                            // curOrder.PredictDeliveryTime = DateTime.Now.AddHours(1);
                            curOrder.ClientId = cbxClientId.SelectedValue.ToString();
                            curOrder.Receiver = txtReceiver.Text;
                            curOrder.ReceiverPhone1 = txtReceiverPhone1.Text;
                            if (txtReceiverPhone2.Text != "")
                            {
                                curOrder.ReceiverPhone2 = txtReceiverPhone2.Text;
                            }
                            if (txtReceiverPhone3.Text != "")
                            {
                                curOrder.ReceiverPhone3 = txtReceiverPhone3.Text;
                            }
                            try
                            {
                                curOrder.Amount = decimal.Parse(txtAmount.Text);
                            }
                            catch (Exception ex)
                            {
                                curOrder.Amount = 0;
                                txtAmount.Text = 0 + "";
                            }
                            try
                            {
                                curOrder.Receivable = decimal.Parse(txtReceivable.Text);
                                if (txtReceivable.Text == "0")
                                {
                                    curOrder.IsBackFee = false;
                                }
                                else
                                {
                                    curOrder.IsBackFee = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                curOrder.Receivable = 0;
                                txtReceivable.Text = 0 + "";
                            }
                            curOrder.AirWaybillID = txtAirWaybillID.Text;
                            curOrder.SourceTransType = cbxSourceTransType.Text;
                            curOrder.SourceTransId = txtSourceTransId.Text;
                            curOrder.IsDeliver = chkIsDeliver.Checked;
                            curOrder.LogisCompanyID = usersInfo.CompanyId;
                            curOrder.LogisCompanyShortName = logiscompanyList[0].CompanyShortName;
                            curOrder.Remark = txtRemark.Text;

                            if (rBtnCashPay.Checked == true)
                            {
                                curOrder.PaymentMethod = rBtnCashPay.Text;
                            }
                            if (rBtnForwardPay.Checked == true)
                            {
                                curOrder.PaymentMethod = rBtnForwardPay.Text;
                            }
                            if (rBtnMonthPay.Checked == true)
                            {
                                curOrder.PaymentMethod = rBtnMonthPay.Text;
                            }
                            //curOrder.IsEnd = false;
                            // curOrder.IsChecked = false;
                            curOrder.TotalFee = decimal.Parse(lblTotalFee.Text);

                            //List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", lblOrderId.Text));

                            //var update = productdeliveryList.Where(a => productList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                            //{
                            //    for (int j = 0; j < update.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.productdelivery().Update(update[j]);
                            //    }

                            //}
                            //var delete = productList.Where(a => !productdeliveryList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                            //{
                            //    for (int j = 0; j < delete.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.productdelivery().Delete(delete[j].Id);
                            //    }
                            //}
                            //var add = productdeliveryList.Where(a => !productList.Exists(t => a.OrderDetailId.Contains(t.OrderDetailId))).ToList();
                            //{
                            //    for (int j = 0; j < add.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.productdelivery().Add(add[j]);
                            //    }
                            //}

                            //List<YueYePlat.Model.deliveryorderfee> orderFeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", lblOrderId.Text));

                            //var updateFee = orderTotalFeeList.Where(a => orderFeeList.Exists(t => a.Id.ToString().Contains(t.Id.ToString()))).ToList();
                            //{
                            //    for (int j = 0; j < updateFee.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.deliveryorderfee().Update(updateFee[j]);
                            //    }
                            //}
                            //var deleteFee = orderFeeList.Where(a => !orderTotalFeeList.Exists(t => a.Id.ToString().Contains(t.Id.ToString()))).ToList();
                            //{
                            //    for (int j = 0; j < deleteFee.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.deliveryorderfee().Delete(deleteFee[j].Id);
                            //    }
                            //}
                            //var addFee = orderTotalFeeList.Where(a => !orderFeeList.Exists(t => a.Id.ToString().Contains(t.Id.ToString()))).ToList();
                            //{
                            //    for (int j = 0; j < addFee.Count; j++)
                            //    {
                            //        new YueYePlat.BLL.deliveryorderfee().Add(addFee[j]);
                            //    }
                            //}                        

                            if (new YueYePlat.BLL.deliveryorder().Update(curOrder))
                            {
                                if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    FrmTransferOrderReport report = new FrmTransferOrderReport();
                                    report.strDetailFee = "detailFee";
                                    report.deliveryOrderId = lblOrderId.Text;
                                    report.usersInfo = usersInfo;
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
                                    report.usersInfo = usersInfo;
                                    if (report.ShowDialog() == DialogResult.OK)
                                    {
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
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

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvProductList.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                string detailOrderId = dgvProductList.Rows[e.RowIndex].Cells["colOrderDetailId"].Value.ToString();

                //点击品名时，将当前货品的费用单独拉出，传给货品明细窗口，并且从总的费用中去除                
                orderFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                List<YueYePlat.Model.deliveryorderfee> totalFeeList = new List<YueYePlat.Model.deliveryorderfee>();

                if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                totalFeeList.AddRange(orderTotalFeeList);
                if (orderTotalFeeList.Count > 0)
                {
                    for (int i = 0; i < orderTotalFeeList.Count; i++)
                    {
                        if (orderTotalFeeList[i].DeliveryOrderDetailID == detailOrderId)
                        {
                            orderFeeList.Add(orderTotalFeeList[i]);
                            totalFeeList.Remove(orderTotalFeeList[i]);
                        }
                    }
                }
                orderTotalFeeList = totalFeeList;
                for (int i = 0; i < productdeliveryList.Count; i++)
                {
                    if (productdeliveryList[i].ProductId.ToString().Equals(str))
                    {
                        FrmTranferAddProduct product = new FrmTranferAddProduct();
                        product.usersInfo = usersInfo;
                        product.productInfo = productdeliveryList[i];
                        product.feeList = orderFeeList;
                        if (product.ShowDialog() == DialogResult.OK)
                        {
                            orderFeeList = product.feeList;
                            orderTotalFeeList.AddRange(orderFeeList);
                            decimal totalorderfee = 0;
                            if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                            for (int j = 0; j < orderTotalFeeList.Count; j++)
                            {
                                totalorderfee += orderTotalFeeList[j].Fee;
                            }
                            lblTotalFee.Text = totalorderfee.ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           



            //if (e.RowIndex > -1)
            //{
            //    try
            //    {
            //        int cid = e.ColumnIndex;
            //        string strProductId = dgvProductList.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
            //        string strOrderDetailId = dgvProductList.Rows[e.RowIndex].Cells["colOrderDetailId"].Value.ToString();
            //        string strcolName = this.dgvProductList.Columns[cid].DefaultCellStyle.NullValue.ToString();
            //        if (strcolName == "删除")
            //        {
            //            for (int i = 0; i < productdeliveryList.Count; i++)
            //            {
            //                if (productdeliveryList[i].ProductId.Equals(strProductId))
            //                {
            //                    YueYePlat.Model.productdelivery model = productdeliveryList[i];
            //                    if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
            //                    List<YueYePlat.Model.deliveryorderfee> feeList = new List<YueYePlat.Model.deliveryorderfee>();
            //                    feeList.AddRange(orderTotalFeeList);
            //                    for (int j = 0; j < feeList.Count; j++)
            //                    {
            //                        if (feeList[j].DeliveryOrderDetailID.Equals(model.OrderDetailId))
            //                        {
            //                            orderTotalFeeList.Remove(feeList[j]);
            //                        }
            //                    }
            //                    productdeliveryList.Remove(model);
            //                    break;
            //                }

            //            }
            //            dgvProductList.DataSource = null;
            //            dgvProductList.DataSource = productdeliveryList;
            //            if (dgvProductList.Rows.Count > 0)
            //            {
            //                dgvProductList.Rows[0].Selected = false;
            //            }

            //            decimal totalorderfee = 0;
            //            for (int k = 0; k < orderTotalFeeList.Count; k++)
            //            {
            //                totalorderfee += orderTotalFeeList[k].Fee;
            //            }
            //            lblTotalFee.Text = totalorderfee.ToString();

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        LogHelper.WriteLog(ex);
            //    }
            //}
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (endLocation != "")
            {
                webBrowser1.Document.InvokeScript("getLocatin", new object[] { endLocation });
            }
        }
        public void getLocation(string location)
        {
            string[] sArray = location.Split(';');
            endLng = sArray[0].Trim();
            endLat = sArray[1].Trim();
        }
        private void btnFee_Click(object sender, EventArgs e)
        {
            FrmTransferFeeInfo feeInfo = new FrmTransferFeeInfo();
            feeInfo.usersInfo = usersInfo;
            if (orderTotalFeeList == null) orderTotalFeeList = new List<YueYePlat.Model.deliveryorderfee>();
            feeInfo.totalfeeList = orderTotalFeeList;
            feeInfo.ShowDialog();
        }
        private void btnOrderId_Click(object sender, EventArgs e)
        {
            FrmTransferSetOrderId orderId = new FrmTransferSetOrderId();
            orderId.usersInfo = usersInfo;
            if (orderId.ShowDialog() == DialogResult.OK)
            {
                lblOrderId.Text = orderId.deliveryOrderId;
            }
        }
        private void cbxClientId_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxClientId.SelectedValue != null)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
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
        private void txtReceivable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }

            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtReceivable.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtReceivable.Text, out oldf);
                    b2 = float.TryParse(txtReceivable.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtAmount.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtAmount.Text, out oldf);
                    b2 = float.TryParse(txtAmount.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        private void txtTransferFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtTransferFee.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtTransferFee.Text, out oldf);
                    b2 = float.TryParse(txtTransferFee.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        private void txtDestination_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDestination.Text.Trim() != "")
                {
                    endLocation = txtDestination.Text;
                    string str_url = Application.StartupPath + "\\DeliveryEndPosition.html";
                    Uri url = new Uri(str_url);
                    webBrowser1.Url = url;
                    webBrowser1.ObjectForScripting = this;
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
        private void txtDestination_Leave(object sender, EventArgs e)
        {
            if (txtDestination.Text.Trim() != "")
            {
                endLocation = txtDestination.Text;
                string str_url = Application.StartupPath + "\\DeliveryEndPosition.html";
                Uri url = new Uri(str_url);
                webBrowser1.Url = url;
                webBrowser1.ObjectForScripting = this;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnFeeType_Click(object sender, EventArgs e)
        {
            FrmTransferFeeType feeType = new FrmTransferFeeType();
            feeType.usersInfo = usersInfo;
            if (feeType.ShowDialog() == DialogResult.OK)
            {
                newfeetype = feeType.strCollected;
                string[] feeName = newfeetype.Split(';');
                for (int i = 0; i < feeName.Length; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    {
                        column.HeaderText = feeName[i];
                        List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("FeeTypeName='{0}'", feeName[i]));
                        column.Name = "colufee" + feetypeList[0].Id;
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        column.CellTemplate = new DataGridViewTextBoxCell();
                        column.CellTemplate.Style.BackColor = Color.White;
                        column.DataPropertyName = "colufee" + feetypeList[0].Id;
                    }
                    dgvProductList.Columns.Insert(dgvProductList.Columns.Count - 2, column);

                }
            }
        }
        private void dgvProductList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }
        private void dgvProductList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                try
                {
                    double price = Convert.ToDouble(dgvProductList.Rows[e.RowIndex].Cells[10].Value);
                    double weight = Convert.ToDouble(dgvProductList.Rows[e.RowIndex].Cells[8].Value);
                    double total = Math.Round(price * weight, MidpointRounding.AwayFromZero);
                    dgvProductList.Rows[e.RowIndex].Cells[13].Value = total;
                    dgvProductList.Rows[e.RowIndex].Cells[13].Value = total;
                }
                catch
                {
                    return;
                }
            }
            else if (e.ColumnIndex == 8)
            {
                try
                {
                    double price = 0.35;
                    double weight = Convert.ToDouble(dgvProductList.Rows[e.RowIndex].Cells[8].Value);
                    double total = Math.Round(price * weight, MidpointRounding.AwayFromZero);
                    dgvProductList.Rows[e.RowIndex].Cells[14].Value = total;
                }
                catch
                {
                    return;
                }
            }
            try
            {
                double totalFee = 0;
                for (int j = 0; j < dgvProductList.Columns.Count; j++)
                {
                    if (dgvProductList.Columns[j].Name.IndexOf("colufee") >= 0)
                    {
                        if (dgvProductList.Rows[e.RowIndex].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString() != "")
                        {
                            totalFee += double.Parse(dgvProductList.Rows[e.RowIndex].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());
                        }
                        else
                        {
                            dgvProductList.Rows[e.RowIndex].Cells[dgvProductList.Columns[j].Name.ToString()].Value = 0;
                        }
                    }
                }
                dgvProductList.Rows[e.RowIndex].Cells["colfee"].Value = totalFee.ToString();
                double fee = 0;
                for (int i = 0; i < dgvProductList.Rows.Count; i++)
                {
                    fee += double.Parse(dgvProductList.Rows[i].Cells["colfee"].Value.ToString());
                }
                lblTotalFee.Text = fee.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YueYePlat.Model.productdelivery productInfo = new YueYePlat.Model.productdelivery();
            for (int i = 0; i < dgvProductList.Rows.Count - 1; i++)
            {
                productInfo.DeliveryOrderId = lblOrderId.Text;
                productInfo.OrderDetailId = lblOrderId.Text.Trim().Substring(lblOrderId.Text.Length - 2) + "0" + (i + 1);
                for (int j = 0; j < dgvProductList.Columns.Count; j++)
                {

                    if (dgvProductList.Columns[j].Name.IndexOf("colufee") >= 0)
                    {
                        YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                        feeInfo.DeliveryOrderId = lblOrderId.Text;
                        feeInfo.DeliveryOrderDetailID = productInfo.OrderDetailId;
                        feeInfo.FeeTypeId = int.Parse(dgvProductList.Columns[j].Name.Substring(7));
                        try
                        {
                            feeInfo.Fee = decimal.Parse(dgvProductList.Rows[i].Cells[dgvProductList.Columns[j].Name.ToString()].Value.ToString());

                        }
                        catch (Exception ex)
                        {
                            feeInfo.Fee = 0;
                        }
                        new YueYePlat.BLL.deliveryorderfee().Add(feeInfo);
                    }

                }

                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'", dgvProductList.Rows[i].Cells["colProductName"].Value.ToString()));
                if (productList.Count == 0)
                {
                    YueYePlat.Model.productinfo product = new YueYePlat.Model.productinfo();
                    product.ProductName = dgvProductList.Rows[i].Cells["colProductName"].Value.ToString();
                    new YueYePlat.BLL.productinfo().Add(product);
                }
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                productInfo.Weight = double.Parse(dgvProductList.Rows[i].Cells["colWeight"].Value.ToString());
                productInfo.Quantity = int.Parse(dgvProductList.Rows[i].Cells["colQuantity"].Value.ToString());
                productInfo.VolumeDescription = dgvProductList.Rows[i].Cells["colVolumeDescription"].Value.ToString();
                new YueYePlat.BLL.productdelivery().Add(productInfo);
            }
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (curOrder != null)
            {
                DataRow dr1 = dt.NewRow();
                dt.Rows.Add(dr1);
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = dt;
            }
            else
            {
                DataGridViewRow Row = new DataGridViewRow();
                int index = dgvProductList.Rows.Add(Row);
                for (int i = 0; i < dgvProductList.Columns.Count; i++)
                {
                    if (dgvProductList.Columns[i].Name.IndexOf("colufee") >= 0)
                    {
                        dgvProductList.Rows[index].Cells[dgvProductList.Columns[i].Name.ToString()].Value = 0;
                    }
                }
                dgvProductList.Rows[index].Cells["colProductName"].Selected = true;
            }
        }
        private void cbxClientCompany_MouseClick(object sender, MouseEventArgs e)
        {
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxClientCompany.DisplayMember = "CompanyName";
            cbxClientCompany.ValueMember = "CompanyId";
            cbxClientCompany.DataSource = companyList;
        }   
        private void dgvProductList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProductList.CurrentCellAddress.X == dgvProductList.Columns["colProductName"].Index)
            {
                ComboBox cbo = e.Control as ComboBox;
                if (cbo != null)
                {
                    cbo.DropDownStyle = ComboBoxStyle.DropDown;
                    cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
            }
        }
        private void dgvProductList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (dgvProductList.CurrentCellAddress.X == dgvProductList.Columns["colProductName"].Index)
            //{
            //    //问题出在这里.如果你输入的是ValueMember的值的话就没问题.但你如果输入的是DisplayMember的值的话就不会选中.
            //    //如ValueMember="MAN" DisplayMember="管理部",如果你在此单元格输入MAN就没问题,但输入管理部就不会选中.但用户就应该是输入管理部
            //    //而不是输入MAN.
            //    dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = e.FormattedValue;

            //}
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < this.dgvProductList.Rows.Count; j++)
            {
                if (this.dgvProductList.SelectedRows.Count > 0)
                {
                    DataRowView drv = this.dgvProductList.SelectedRows[0].DataBoundItem as DataRowView;
                    drv.Delete();
                }
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvProductList.Rows[e.RowIndex].Cells[1].Selected)
                {
                    if (MessageBox.Show("您是否要删除当前行数据？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        dgvProductList.Rows.Remove(dgvProductList.Rows[e.RowIndex]);
                    }
                }
            }
        }

        private void dgvProductList_Leave(object sender, EventArgs e)
        {

        }
    }
}
