using Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LogisPrj
{
    public partial class FrmDataExport : Form
    {
        public  YueYePlat.Model.usersinfo usersInfo;
        static FrmDataExport instance;
        public string tabPageTitle = "";
        int pageSize = 25;//每页个数
        int pageIndex = 1;//页索引
        string strWhere = "";
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        List<YueYePlat.Model.deliveryorder> listStaffs;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        List<YueYePlat.Model.deliveryorderfee> orderTotalFeeList;
        public FrmDataExport()
        {
            InitializeComponent();
        }
        public static FrmDataExport getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDataExport();
            }
            return instance;
        }
        private void FrmDataExport_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvOrderList.AutoGenerateColumns = false;
            DateTime dtStartTime = DateTime.Parse( DateTime.Now.AddDays(-9).ToShortDateString());
            txtDeliveryTimeStart.Text = dtStartTime.ToString("yyyy-MM-dd 00:00:00");
            txtDeliveryTimeEnd.Text = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);            
            strWhere = "1=1";          
            if (txtDeliveryTimeStart.Text.Trim() != "")
            {
                if (txtDeliveryTimeEnd.Text.Trim() != "")
                {
                    strWhere += String.Format(" and  BeginTime > '{0}' and BeginTime<'{1}'", txtDeliveryTimeStart.Text, txtDeliveryTimeEnd.Text);
                }
                else
                {
                    strWhere += String.Format(" and BeginTime> '{0}' ", txtDeliveryTimeStart.Text);
                }
            }
            if (txtDeliveryTimeStart.Text.Trim() != "" && txtDeliveryTimeEnd.Text.Trim() != "")
            {
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList( strWhere);
                totalCount = new YueYePlat.BLL.deliveryorder().GetRecordCount(strWhere);
                lbltotalCount.Text = totalCount.ToString();
                lblPre.Text = 1 + "";
                pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
                lbltotalPage.Text = pageCount.ToString();
                if (orderList.Count == 0)
                {
                    MessageBox.Show("此次查询没有找到对应的信息！");
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = orderList;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }
                }
                else
                {

                    Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string product = config.AppSettings.Settings["productInfo"].Value;
                    string[] productInfo = product.Split(';');
                    for (int i = 0; i < productInfo.Length; i = i + 2)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        {
                            column.HeaderText = productInfo[i];
                            column.Name = "col" + productInfo[i + 1];
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            column.CellTemplate = new DataGridViewTextBoxCell();
                            column.CellTemplate.Style.BackColor = Color.White;
                            column.DataPropertyName = "col" + productInfo[i + 1];
                        }
                        dgvOrderList.Columns.Add(column);
                    }
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
                        dgvOrderList.Columns.Add(column);
                    }
                    DataTable dt = new DataTable();
                    for (int count = 0; count < dgvOrderList.Columns.Count; count++)
                    {
                        try
                        {
                            DataColumn dc = new DataColumn(dgvOrderList.Columns[count].Name.ToString());
                            dt.Columns.Add(dc);
                        }
                        catch (Exception ex)
                        {
                            LogHelper.WriteLog(ex);
                        }
                    }

                    for (int i = 0; i < orderList.Count; i++)
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        int index = dgvOrderList.Rows.Add(Row);
                        try
                        {
                            orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                        }
                        catch (Exception ex)
                        {

                        }
                        
                        if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                        else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                        if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                        else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                        if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                        else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                        dgvOrderList.Rows[i].Cells["colDeliveryOrderId"].Value = orderList[i].DeliveryOrderId;
                        dgvOrderList.Rows[i].Cells["colClientName"].Value = orderList[i].ClientName;
                        dgvOrderList.Rows[i].Cells["colSourTransType"].Value = orderList[i].SourceTransType;
                        dgvOrderList.Rows[i].Cells["colSourTransId"].Value = orderList[i].SourceTransId;
                        dgvOrderList.Rows[i].Cells["colAirWaybill"].Value = orderList[i].AirWaybillID;
                        dgvOrderList.Rows[i].Cells["colDestination"].Value = orderList[i].Destination;
                        dgvOrderList.Rows[i].Cells["colAmount"].Value = orderList[i].Amount;
                        dgvOrderList.Rows[i].Cells["colReceivable"].Value = orderList[i].Receivable;
                        dgvOrderList.Rows[i].Cells["colIsDeliveryName"].Value = orderList[i].IsDeliverName;
                        dgvOrderList.Rows[i].Cells["colPaymentMethod"].Value = orderList[i].PaymentMethod;
                        dgvOrderList.Rows[i].Cells["colIfEndName"].Value = orderList[i].IfEndName; 
                        dgvOrderList.Rows[i].Cells["colTotalFee"].Value = orderList[i].TotalFee;
                        dgvOrderList.Rows[i].Cells["colRecorderName"].Value = orderList[i].RecorderName;
                        orderList[i].ProductList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format ("DeliveryOrderId='{0}'",orderList[i].DeliveryOrderId));
                        for (int j = 0; j < orderList[i].ProductList.Count; j++)
                        {
                            
                            try
                            {
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                orderList[i].ProductList[j].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", orderList[i].ProductList[j].ProductId))[0].ProductName;
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                dgvOrderList.Rows[i].Cells["colProductName"].Value = orderList[i].ProductList[j].ProductName;
                                dgvOrderList.Rows[i].Cells["colQuantity"].Value = orderList[i].ProductList[j].Quantity;
                                dgvOrderList.Rows[i].Cells["colWeight"].Value = orderList[i].ProductList[j].Weight;
                                orderList[i].OrderfeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", orderList[i].DeliveryOrderId));
                                for (int k = 0; k < orderList[i].OrderfeeList.Count; k++)
                                {

                                    if (orderList[i].ProductList[j].DeliveryOrderId == orderList[i].OrderfeeList[k].DeliveryOrderId && orderList[i].ProductList[j].OrderDetailId == orderList[i].OrderfeeList[k].DeliveryOrderDetailID)
                                    {
                                        if (dgvOrderList.Columns.Contains("colufee" + orderList[i].OrderfeeList[k].FeeTypeId.ToString()))
                                        {
                                            dgvOrderList.Rows[i].Cells["colufee" + orderList[i].OrderfeeList[k].FeeTypeId].Value = orderList[i].OrderfeeList[k].Fee.ToString();
                                        }
                                        else
                                        {
                                            orderList[i].OrderfeeList[k].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderList[i].OrderfeeList[k].FeeTypeId))[0].FeeTypeName;
                                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                                            {
                                                column.HeaderText = orderList[i].OrderfeeList[k].FeetypeName;
                                                column.Name = "colufee" + orderList[i].OrderfeeList[k].FeeTypeId;
                                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                                column.CellTemplate = new DataGridViewTextBoxCell();
                                                column.CellTemplate.Style.BackColor = Color.White;
                                                column.DataPropertyName = "colufee" + orderList[i].OrderfeeList[k].FeeTypeId;
                                            }
                                            dgvOrderList.Columns.Add(column);
                                            dgvOrderList.Rows[i].Cells["colufee" + orderList[i].OrderfeeList[k].FeeTypeId].Value = orderList[i].OrderfeeList[k].Fee.ToString();
                                        }
                                    }
                                }
                            }
                            catch(Exception ex)
                            {

                            }                            
                        }                      
                    }
                    for (int count = 0; count < dgvOrderList.Rows.Count; count++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int countsub = 0; countsub < dgvOrderList.Columns.Count; countsub++)
                        {
                            try
                            {
                                dr[countsub] = Convert.ToString(dgvOrderList.Rows[count].Cells[countsub].Value);
                            }
                            catch (Exception ex)
                            {
                                LogHelper.WriteLog(ex);
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                    Debug.WriteLine(dt.Rows.Count + "");
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = dt;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }
                }
            }
            else
            {
                if (txtDeliveryTimeStart.Text == "")
                {
                    MessageBox.Show("请输入要查询的开始日期！");
                }
                else if (txtDeliveryTimeEnd.Text == "")
                {
                    MessageBox.Show("请输入要查询的结束日期!");
                }
            }
        }

        private void txtDeliveryTimeStart_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void txtDeliveryTimeEnd_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDeliveryTimeStart.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDeliveryTimeEnd.Text = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd 23:59:59");
            monthCalendar2.Visible = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.DataSource == null)
            {
                MessageBox.Show("请先点击查询，再点击导出！");
            }
            else
            {
                ExportToExcel d = new ExportToExcel();
                d.OutputAsExcelFile(dgvOrderList);
            } 
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = 1;
                lblPre.Text = pageIndex.ToString();
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                for (int i = 0; i < orderList.Count; i++)
                {
                    orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    try
                    {
                        orderList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].RecorderID))[0].UserName;
                    }
                    catch (Exception ex)
                    {
                        orderList[i].RecorderName = "";
                    }
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                    else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                    if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                    else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                    if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                    else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                    if (orderList[i].DeliveryId != "") orderList[i].DeliveryStatus = "已派送";
                    else orderList[i].DeliveryStatus = "未派送";
                }
                listStaffs = orderList;
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = orderList;
                if (dgvOrderList.Rows.Count > 0)
                {
                    dgvOrderList.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是首页！");
            }
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = pageIndex - 1;
                lblPre.Text = pageIndex.ToString();
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                for (int i = 0; i < orderList.Count; i++)
                {
                    orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    try
                    {
                        orderList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].RecorderID))[0].UserName;
                    }
                    catch (Exception ex)
                    {
                        orderList[i].RecorderName = "";
                    }
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                    else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                    if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                    else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                    if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                    else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                    if (orderList[i].DeliveryId != "") orderList[i].DeliveryStatus = "已派送";
                    else orderList[i].DeliveryStatus = "未派送";
                }
                listStaffs = orderList;
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = orderList;
                if (dgvOrderList.Rows.Count > 0)
                {
                    dgvOrderList.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是第一页！");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageIndex + 1;
                lblPre.Text = pageIndex.ToString();
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                for (int i = 0; i < orderList.Count; i++)
                {
                    orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    try
                    {
                        orderList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].RecorderID))[0].UserName;
                    }
                    catch (Exception ex)
                    {
                        orderList[i].RecorderName = "";
                    }
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                    else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                    if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                    else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                    if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                    else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                    if (orderList[i].DeliveryId != "") orderList[i].DeliveryStatus = "已派送";
                    else orderList[i].DeliveryStatus = "未派送";
                }
                listStaffs = orderList;
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = listStaffs;
                if (dgvOrderList.Rows.Count > 0)
                {
                    dgvOrderList.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是末页！");
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageCount;
                lblPre.Text = pageIndex.ToString();
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                for (int i = 0; i < orderList.Count; i++)
                {
                    orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    try
                    {
                        orderList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].RecorderID))[0].UserName;
                    }
                    catch (Exception ex)
                    {
                        orderList[i].RecorderName = "";
                    }
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                    if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                    else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                    if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                    else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                    if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                    else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                    if (orderList[i].DeliveryId != "") orderList[i].DeliveryStatus = "已派送";
                    else orderList[i].DeliveryStatus = "未派送";
                }
                listStaffs = orderList;
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = orderList;
                if (dgvOrderList.Rows.Count > 0)
                {
                    dgvOrderList.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是末页！");
            }
        }

        private void btnGoPage_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPage.Text.Trim(), "^\\d+$"))
            {
                int pageNum = int.Parse(txtPage.Text.Trim());
                if (pageNum >= 1 && pageNum <= pageCount)
                {
                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageNum, strWhere);
                    for (int i = 0; i < orderList.Count; i++)
                    {
                        orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        try
                        {
                            orderList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].RecorderID))[0].UserName;
                        }
                        catch (Exception ex)
                        {
                            orderList[i].RecorderName = "";
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                        else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                        if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                        else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                        if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                        else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                        if (orderList[i].DeliveryId != "") orderList[i].DeliveryStatus = "已派送";
                        else orderList[i].DeliveryStatus = "未派送";
                    }
                    listStaffs = orderList;
                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = orderList;
                    if (dgvOrderList.Rows.Count > 0)
                    {
                        dgvOrderList.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("请输入合理的页数！");
                }

            }
            else
            {
                MessageBox.Show("请输入正确的页数！");
            }
        }
    }
}
