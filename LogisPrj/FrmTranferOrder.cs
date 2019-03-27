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
    public partial class FrmTranferOrder : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        static FrmTranferOrder instance;
        public string tabPageTitle = "";
        string strDeliveryOrderId="";
        string strDeliveryId = "";
        bool asc = false;
        bool cbxDelete = false;
        List<YueYePlat.Model.deliveryorder> listStaffs;
        int pageSize=25;//每页个数
        int pageIndex = 1;//页索引
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        string strWhere = "";
        List<YueYePlat.Model.deliveryorder> deleteList;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmTranferOrder()
        {
            InitializeComponent();
        }
        public static FrmTranferOrder getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTranferOrder();
            }
            return instance;
        }
        private void FrmTranferOrder_Load(object sender, EventArgs e)
        {            
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo .CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            cbxSelect.Text = "全部";
            DateTime dtNow = DateTime.Parse ( DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));            
            txtDeliveryTimeStart.Text = dtNow.AddDays(-3).ToString ("yyyy-MM-dd 00:00:00");
            txtDeliveryTimeEnd.Text = dtNow.ToString("yyyy-MM-dd 23:59:59");  
            try
            {
                dgvOrderList.AutoGenerateColumns = false;
                InitComponent();
                monthCalendar1.Visible = false;
                monthCalendar2.Visible = false;
                cbxClient.SelectedValue = "";                
               
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
        private void InitComponent()
        {         
            //List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            //cbxClient.DisplayMember = "ClientName";
            //cbxClient.ValueMember = "ClientId";
            //cbxClient.DataSource = clientList;          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void dgvDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTransferOrderInfo info = new FrmTransferOrderInfo();
            info.usersinfo = usersInfo;
            info.Show();
            info.operate = "add";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName); 
            strWhere = "1=1";
            if (cbxSelect.Text != "")
            {
                if (cbxSelect.Text == "已审核")
                {
                    strWhere += String.Format(" and IsChecked=true");
                }
                else if (cbxSelect.Text == "待审核")
                {
                    strWhere += String.Format(" and IsChecked=false");
                }
                else if (cbxSelect.Text == "中转")
                {
                    strWhere += String.Format(" and IfTransfer=true");
                }
                else if (cbxSelect.Text == "已派送")
                {
                    strWhere += String.Format(" and DeliveryId!=''");
                }
                else if (cbxSelect.Text == "未派送")
                {
                    strWhere += String.Format(" and (DeliveryId='' or DeliveryId IS NULL)");
                }
            }    
            if (txtDeliveryTimeStart.Text.Trim() != "" )
            {
                if (txtDeliveryTimeEnd.Text.Trim() != "")
                {
                    strWhere += String.Format(" and  BeginTime > '{0}' and BeginTime<'{1}'", txtDeliveryTimeStart.Text, txtDeliveryTimeEnd.Text);
                }
                else
                {
                    strWhere += String.Format(" and BeginTime> '{0}' ",txtDeliveryTimeStart.Text );
                }               
            }
            if (cbxClient.SelectedValue != null && cbxClient.SelectedValue.ToString() != "")
            {
                strWhere+= String.Format(" and ClientId = '{0}'", cbxClient.SelectedValue.ToString());
            }
            if (txtSourTransId.Text != "")
            {
                strWhere += String.Format(" and SourceTransId='{0}'", txtSourTransId.Text);
            }
            if (txtDeliveryOrderId.Text.Trim() != "")
            {               
                strWhere += String.Format(" and  DeliveryOrderId='{0}'", txtDeliveryOrderId.Text);
            }
            if (txtInvoiceId.Text.Trim() != "")
            {
                strWhere += String.Format(" and AirWaybillID like '%{0}%'",txtInvoiceId.Text );
            }
            if (cbxSelect.Text !=""|| txtInvoiceId.Text .Trim ()!="" || txtDeliveryTimeStart .Text .Trim() != "" || cbxClient.SelectedValue != null || txtSourTransId.Text .Trim()!=""|| txtDeliveryOrderId.Text .Trim ()!="" || txtInvoiceId.Text.Trim()!="")
            {
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize,pageIndex,strWhere);
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
                        if (orderList[i].DeliveryId != "")
                        {
                             orderList[i].DeliveryStatus = "已派送";
                            //string driver = "";
                            //List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", orderList[i].DeliveryId));
                            //if (deliveryList[0].Driver1Id != "")
                            //{
                            //    string driver1 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[0].Driver1Id))[0].DriverName;
                            //    driver = driver1;
                            //}
                            //else if (deliveryList[0].Driver2Id != "")
                            //{
                            //    string  driver2 = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[0].Driver1Id))[0].DriverName;
                            //    driver = driver + ";" + driver2;
                            //}
                            //orderList[i].DeliveryStatus = driver;
                        }
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
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
                dgvOrderList.DataSource = null;
            }                   
        }   

        private void txtDeliveryId_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDeliveryTimeStart.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
            monthCalendar1.Visible = false;
        }

        private void txtDeliveryId_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void txtDeliveryTimeEnd_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void txtDeliveryTimeEnd_Leave(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDeliveryTimeEnd.Text = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd 23:59:59");
            monthCalendar2.Visible = false;
        }

        private void dgvOrderList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryorderId"].Value.ToString();
                List<YueYePlat.Model.deliveryorder> deliveryList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", str));
                YueYePlat.Model.deliveryorder deliveryInfo = deliveryList.Find(v => v.DeliveryOrderId.Equals(str));
                int cid = e.ColumnIndex;
                FrmTransAddNewOrder orderInfo = new FrmTransAddNewOrder();
                orderInfo.usersInfo = usersInfo;          
                orderInfo.curOrder = deliveryInfo;
                orderInfo.Show();
            }
        }
        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            if (e.RowIndex > -1)
            {
                if (index == 0)
                {
                    string selected = dgvOrderList.Rows[e.RowIndex].Cells["colCbxDelete"].EditedFormattedValue.ToString();
                    if (selected == "True")
                    {
                        dgvOrderList.Rows[e.RowIndex].Cells["colCbxDelete"].Value = false;
                        if (deleteList == null) deleteList = new List<YueYePlat.Model.deliveryorder>();
                        int id = int.Parse(dgvOrderList.Rows[e.RowIndex].Cells["coluId"].Value.ToString());
                        if (deleteList.Count > 0)
                        {
                            for (int i = 0; i < deleteList.Count; i++)
                            {
                                if (deleteList[i].Id == id)
                                {
                                    deleteList.Remove(deleteList[i]);
                                }
                            }
                        }
                    }
                    else if (selected == "False")
                    {
                        if (deleteList == null) deleteList = new List<YueYePlat.Model.deliveryorder>();
                        dgvOrderList.Rows[e.RowIndex].Cells["colCbxDelete"].Value = true;
                        List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("Id={0}", int.Parse(dgvOrderList.Rows[e.RowIndex].Cells["coluId"].Value.ToString())));
                        deleteList.AddRange(orderList);
                    }
                }
                //string str = dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryorderId"].Value.ToString();
                //int cid = e.ColumnIndex;
                //string strcolName = this.dgvOrderList.Columns[cid].DefaultCellStyle.NullValue.ToString();
                //if (strcolName == "删除")
                //{
                //    if (MessageBox.Show("您确定要删除该订单吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //    {
                //        List<YueYePlat.Model.deliveryorder> orderInfo = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", str));
                //        if (orderInfo.Count > 0)
                //        {
                //            List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(string.Format("DeliveryOrderId='{0}'", orderInfo[0].DeliveryOrderId));
                //            if (productList.Count > 0)
                //            {
                //                for (int i = 0; i < productList.Count; i++)
                //                {
                //                    new YueYePlat.BLL.productdelivery().Delete(productList[i].Id);
                //                }
                //            }
                //            List<YueYePlat.Model.deliveryorderfee> orderfeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(string.Format("DeliveryOrderId='{0}'", orderInfo[0].DeliveryOrderId));
                //            if (orderfeeList.Count > 0)
                //            {
                //                for (int i = 0; i < orderfeeList.Count; i++)
                //                {
                //                    new YueYePlat.BLL.deliveryorderfee().Delete(orderfeeList[i].Id);
                //                }
                //            }
                //            List<YueYePlat.Model.vehicledelivery> vehicleDeliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", orderInfo[0].DeliveryId));
                //            if (vehicleDeliveryList.Count > 0)
                //            {
                //                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryId='{0}'", vehicleDeliveryList[0].DeliveryId));
                //                if (orderList.Count > 0)
                //                {
                //                    if (orderList.Count == 1 && orderList[0].DeliveryOrderId == orderInfo[0].DeliveryOrderId)
                //                    {
                //                        new YueYePlat.BLL.vehicledelivery().Delete(vehicleDeliveryList[0].Id);
                //                    }
                //                }
                //            }
                //            if (new YueYePlat.BLL.deliveryorder().Delete(orderInfo[0].Id))
                //            {
                //                MessageBox.Show("该订单已成功删除！");
                //                dgvOrderList.DataSource = null;
                //            }
                //        }
                //    }
                //}
                //else  
                //{
                //    if (cbxDelete == false)
                //    {
                //        string selected= dgvOrderList.Rows[e.RowIndex].Cells["colCbxDelete"].EditedFormattedValue.ToString ();
                //        dgvOrderList.Rows[e.RowIndex].Columns[cid].DefaultCellStyle.NullValue = true;
                //        cbxDelete = true;
                //    }
                //    else
                //    {
                //        dgvOrderList.Columns[cid].DefaultCellStyle.NullValue = false;
                //        cbxDelete = false;
                //    }
                //}              
            }
            else
            {
                if(dgvOrderList.Rows.Count>0)
                {
                    dgvOrderList.Rows[0].Selected = false;
                }
            }
        }        
        private void dgvOrderList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvOrderList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvOrderList.ClearSelection();
                        dgvOrderList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvOrderList.SelectedRows.Count == 1)
                    {
                      //  dgvOrderList.CurrentCell = dgvOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        strDeliveryOrderId = dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryorderId"].Value.ToString();
                        strDeliveryId= dgvOrderList.Rows[e.RowIndex].Cells["colDeliveryId"].Value.ToString();
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        private void TSMenuMap_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmLocationMonitorInfo map = new FrmLocationMonitorInfo();                
                map.strDeliverId = strDeliveryId;
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }
        private void TSMenuTemp_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmTempMonitor temp = new FrmTempMonitor();                
                temp.strDeliveryId = strDeliveryId;
                temp.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }
        private void TSMenuException_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmException exception = new FrmException();
                exception.usersInfo = usersInfo;               
                exception.strDeliveryId = strDeliveryId;
                exception.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }

        private void TSMenuPark_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmRegionalparkmanage park = new FrmRegionalparkmanage();
                park.usersInfo = usersInfo;              
                park.strDeliveryId = strDeliveryId;
                park.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }

        private void TSMenuPath_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmTransferPath path = new FrmTransferPath();
                path.usersInfo = usersInfo;              
                path.strDeliveryId = strDeliveryId;
                path.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }

        private void TSMenuEnd_Click(object sender, EventArgs e)
        {
            List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'",strDeliveryOrderId));
            if (orderList.Count > 0)
            {
                if (orderList[0].DeliveryId != "")
                {
                    if (orderList[0].IsChecked == true)
                    {
                        if (MessageBox.Show("该订单已审核通过，您可以继续查看！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            FrmTransferEnding end = new FrmTransferEnding();
                            end.usersInfo = usersInfo;
                            end.strOrderId = strDeliveryOrderId;
                            end.ShowDialog();
                        }
                    }
                    else
                    {
                        FrmTransferEnding end = new FrmTransferEnding();
                        end.usersInfo = usersInfo;
                        end.strOrderId = strDeliveryOrderId;
                        end.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("");
                } 
            }           
        }

        private void TSMenuOrderId_Click(object sender, EventArgs e)
        {
            // string cellText = (dgvOrderList.CurrentCell.Value == DBNull.Value ? " " :strDeliveryOrderId);
            if (strDeliveryOrderId != "")
            {
                string cellText = strDeliveryOrderId;
                Clipboard.SetText(cellText);
                MessageBox.Show("复制成功！");
            }
          
        }

        private void dgvOrderList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (dgvOrderList.Columns[e.ColumnIndex].Name == "colIfCheckedName")
                {
                    if (e.Value.ToString() == "待审核")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    { }
                }
                if (dgvOrderList.Columns[e.ColumnIndex].Name == "coldeliveryStatus")
                {
                    if (e.Value.ToString() == "未派送")
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TSmenuProduct_Click(object sender, EventArgs e)
        {
            if (strDeliveryOrderId != "")
            {
                FrmTransferProductInfo product = new FrmTransferProductInfo();
                product.usersInfo = usersInfo;
                product.strOrderId = strDeliveryOrderId;
                product.ShowDialog();
            }
        }

        private void TSMenuFee_Click(object sender, EventArgs e)
        {
            if (strDeliveryOrderId != "")
            {
                FrmTransferProductInfo product = new FrmTransferProductInfo();
                product.usersInfo = usersInfo;
                product.strOrderId = strDeliveryOrderId;
                product.ShowDialog();
            }
        }

        private void BtnRenewUpload_Click(object sender, EventArgs e)
        {
           
            if (cbxSelect.Text != "" || txtInvoiceId.Text.Trim() != "" || txtDeliveryTimeStart.Text.Trim() != "" || cbxClient.SelectedValue != null || txtSourTransId.Text.Trim() != "" || txtDeliveryOrderId.Text.Trim() != "" || txtInvoiceId.Text.Trim() != "")
            {
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize,pageIndex,strWhere);
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
                //List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList("");
                //for (int i = 0; i < orderList.Count; i++)
                //{
                //    orderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderList[i].ClientId))[0].ClientName;
                //    if (orderList[i].Terminator != null && orderList[i].Terminator != "")
                //    {
                //        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                //        orderList[i].TerminatorName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].Terminator))[0].UserName;

                //    }
                //    if (orderList[i].Auditor != null && orderList[i].Auditor != "")
                //    {
                //        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                //        orderList[i].AuditorName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", orderList[i].Auditor))[0].UserName;
                //    }
                //    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                //    if (orderList[i].IsEnd == true) orderList[i].IfEndName = "是";
                //    else if (orderList[i].IsEnd == false) orderList[i].IfEndName = "否";
                //    if (orderList[i].IsDeliver == true) orderList[i].IsDeliverName = "是";
                //    else if (orderList[i].IsDeliver == false) orderList[i].IsDeliverName = "否";
                //    if (orderList[i].IsChecked == true) orderList[i].IfCheckedName = "通过";
                //    else if (orderList[i].IsChecked == false) orderList[i].IfCheckedName = "待审核";
                //}
                //dgvOrderList.DataSource = null;
                //dgvOrderList.DataSource = orderList;
                //if (dgvOrderList.Rows.Count > 0)
                //{
                //    dgvOrderList.Rows[0].Selected = false;
                //}
            }
        }

        private void TSMenuData_Click(object sender, EventArgs e)
        {
           // string strData = dgvOrderList.Rows[dgvOrderList.CurrentCellAddress.Y].Value.ToString();
            Clipboard.SetDataObject(this.dgvOrderList.GetClipboardContent());
            //string cellText = (dgvOrderList.CurrentCell.Value == DBNull.Value ? " " : dgvOrderList.CurrentCell.Value.ToString().Trim());
            //Clipboard.SetText(cellText);
            MessageBox.Show("当前行数据复制成功，请直接粘贴");
        }

        private void TSMenuReport_Click(object sender, EventArgs e)
        {
            string strDeliveryId = strDeliveryOrderId.Substring(0, strDeliveryOrderId.Length - 2);            
            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("deliveryId='{0}'", strDeliveryId));
            YueYePlat.Model.vehicledelivery deliveryInfo = deliveryList.Find(v => v.DeliveryId.Equals(strDeliveryId));
            if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FrmTransferOrderReport report = new FrmTransferOrderReport();
                report.strDetailFee = "detailFee";
                //report.deliveryId = deliveryInfo.DeliveryId;
                report.deliveryOrderId = strDeliveryOrderId;
                report.usersInfo = usersInfo;
                report.Show();
            }
            else
            {
                FrmTransferOrderReport report = new FrmTransferOrderReport();
                report.strDetailFee = "nodetailFee";
                //report.deliveryId = deliveryInfo.DeliveryId;
                report.deliveryOrderId = strDeliveryOrderId;
                report.usersInfo = usersInfo;
                report.Show();
            }
        }

        private void TSMenuDelivery_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmTransferManager transfer = new FrmTransferManager();
                transfer.usersInfo = usersInfo;
                transfer.strDeliveryId = strDeliveryId;
                transfer.ShowDialog();
            }
            else
            {
                List<YueYePlat.Model.chargebackinfo> chargebackList = new YueYePlat.BLL.chargebackinfo().GetModelList(String.Format ("DeliveryOrderId='{0}'",strDeliveryOrderId));
                if (chargebackList.Count == 0)
                {
                    MessageBox.Show("该订单没有被驾驶员接单！");
                }
                else
                {

                }               
            }
        }

        private void TSMenuJam_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                List<YueYePlat.Model.vehiclejam> jamList = new YueYePlat.BLL.vehiclejam().GetModelList(String.Format("DeliverId='{0}'", strDeliveryId));
                if (jamList.Count > 0)
                {
                    FrmVehicleJam jam = new FrmVehicleJam();
                    jam.usersInfo = usersInfo;
                    jam.strDeliveryId = strDeliveryId;
                    jam.ShowDialog();
                }
                else
                {
                    MessageBox.Show("该订单没有堵车照片！");
                }
            }
        }

        private void TSMenuFee_Click_1(object sender, EventArgs e)
        {
            if (strDeliveryOrderId != "")
            {
                List<YueYePlat.Model.deliveryorderfee> feeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", strDeliveryOrderId));
                if (feeList.Count > 0)
                {
                    FrmTransferFeeInfo fee = new FrmTransferFeeInfo();
                    fee.usersInfo = usersInfo;
                    fee.strDeliveryOrderID = strDeliveryOrderId;
                    fee.ShowDialog();
                }
                else
                {
                    MessageBox.Show("该订单没有查询到费用信息！");
                }
            }
        }

        private void TSMenuTempManager_Click(object sender, EventArgs e)
        {
            if (strDeliveryId != "")
            {
                FrmTransTempAdd temp = new FrmTransTempAdd();
                temp.usersInfo = usersInfo;
                temp.strDeliveryId = strDeliveryId;
                temp.ShowDialog();
            }
            else
            {
                MessageBox.Show("请核查该订单是否被驾驶员接单！");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "";
                string saveFileName = "";
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xlsx";
                saveDialog.Filter = "Excel文件|*.xlsx";
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                    return;
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook =
                            workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet =
                            (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                             //写入标题             
                for (int i = 0; i < dgvOrderList.ColumnCount; i++)
                { worksheet.Cells[1, i + 1] = dgvOrderList.Columns[i].HeaderText; }
                //写入数值
                for (int r = 0; r < dgvOrderList.Rows.Count; r++)
                {
                    for (int i = 0; i < dgvOrderList.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = dgvOrderList.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
                MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                    }
                    catch (Exception ex)
                    {//fileSaved = false;                      
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                xlApp.Quit();
                GC.Collect();//强行销毁      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmTransAddNewOrder order = new FrmTransAddNewOrder();
            order.usersInfo = usersInfo;
            order.ShowDialog();
        }

        private void dgvOrderList_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvOrderList_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetRowIndexAt(e.Y) == -1)
            {              
                dgvOrderList.CurrentCell = null;
            }
        }
        public int GetRowIndexAt(int mouseLocation_Y)
        {
            if (dgvOrderList.FirstDisplayedScrollingRowIndex < 0)
            {
                return -1;
            }
            if (dgvOrderList.ColumnHeadersVisible == true && mouseLocation_Y <= dgvOrderList.ColumnHeadersHeight)
            {
                return -1;
            }
            int index = dgvOrderList.FirstDisplayedScrollingRowIndex;
            int displayedCount = dgvOrderList.DisplayedRowCount(true);
            for (int k = 1; k <= displayedCount;)
            {
                if (dgvOrderList.Rows[index].Visible == true)
                {
                    Rectangle rect = dgvOrderList.GetRowDisplayRectangle(index, true);  // 取该区域的显示部分区域   
                    if (rect.Top <= mouseLocation_Y && mouseLocation_Y < rect.Bottom)
                    {
                        return index;
                    }
                    k++;
                }
                index++;
            }
            return -1;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            FrmTransferEnding transferEnd = FrmTransferEnding.getInstance();
            transferEnd.usersInfo = usersInfo;            
            if (transferEnd.ShowDialog() == DialogResult.OK)
            {
                   
            }
        }

        private void TSTempInfo_Click(object sender, EventArgs e)
        {
            if (strDeliveryId == "")
            {
                MessageBox.Show("该订单没有配送信息，请及时联系驾驶员！");
            }
            else
            {
                FrmTransferTempInfo info = new FrmTransferTempInfo();
                info.usersInfo = usersInfo;
                info.strDeliveryId = strDeliveryId;
                if (info.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageIndex>1)
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageIndex + 1;
                lblPre.Text = pageIndex.ToString();
                List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize,pageIndex,strWhere);
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

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageCount;
                lblPre.Text = pageIndex.ToString ();
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
                int pageNum = int.Parse (txtPage.Text.Trim());
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

        private void dgvOrderList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            int index = e.ColumnIndex;
            if (listStaffs != null)
            {
                if (asc)
                {
                    switch (index)
                    {
                        case 3:
                            listStaffs = listStaffs.OrderByDescending(w => w.DeliveryOrderId).ToList();
                            break;
                    }
                    asc = false;
                }
                else
                {
                    switch (index)
                    {
                        case 3:
                            listStaffs = listStaffs.OrderBy(w => w.DeliveryOrderId).ToList();
                            break;
                    }
                    asc = true;
                }
                dgvOrderList.DataSource = listStaffs;
            }
            if (index == 0)
            {
                if (deleteList == null) deleteList = new List<YueYePlat.Model.deliveryorder>();
                if (deleteList.Count > 0)
                {
                    if (MessageBox.Show("您是否要删除选中的订单？", "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        for (int i = 0; i < deleteList.Count; i++)
                        {

                            List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                            for (int j = 0; j < productList.Count; j++)
                            {
                                new YueYePlat.BLL.productdelivery().Delete(productList[j].Id);
                            }
                            List<YueYePlat.Model.deliveryorderfee> feeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                            for (int j = 0; j < feeList.Count; j++)
                            {
                                new YueYePlat.BLL.deliveryorderfee().Delete(feeList[j].Id);
                            }
                            List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                            if (orderList.Count >0)
                            {
                                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", deleteList[i].DeliveryId));
                                if (deleteList.Count > 0)
                                {
                                    List<YueYePlat.Model.deliveryorder> otherOrderList = new YueYePlat.BLL.deliveryorder().GetModelList(String .Format ("DeliveryId='{0}'",deleteList[i].DeliveryId));
                                    if (otherOrderList.Count == 1)
                                    {
                                        new YueYePlat.BLL.vehicledelivery().Delete(deleteList[0].Id);
                                    }
                                    else
                                    {
                                        bool isEnd = true;
                                        for (int k = 0; k < otherOrderList.Count; k++)
                                        {
                                            if (otherOrderList[k].IsEnd == false)
                                            {
                                                isEnd = false;
                                            }
                                        }
                                        if (isEnd == true )                                        
                                        {
                                            deliveryList[0].IfEnd = true;
                                            new YueYePlat.BLL.vehicledelivery().Update(deliveryList[0]);
                                        }
                                    }
                                   
                                }
                            }
                            if (new YueYePlat.BLL.deliveryorder().Delete(deleteList[i].Id))
                            {                               
                               
                            }
                        }
                        MessageBox.Show("删除成功！");
                        pageIndex = 1;
                        List<YueYePlat.Model.deliveryorder> ordersList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                        totalCount = new YueYePlat.BLL.deliveryorder().GetRecordCount(strWhere);
                        lbltotalCount.Text = totalCount.ToString();
                        lblPre.Text = 1 + "";
                        pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
                        lbltotalPage.Text = pageCount.ToString();
                        if (ordersList.Count == 0)
                        {
                            MessageBox.Show("此次查询没有找到对应的信息！");
                            dgvOrderList.DataSource = null;
                            dgvOrderList.DataSource = ordersList;
                            if (dgvOrderList.Rows.Count > 0)
                            {
                                dgvOrderList.Rows[0].Selected = false;
                            }
                        }
                        else
                        {
                            for (int k = 0; k < ordersList.Count; k++)
                            {
                                ordersList[k].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", ordersList[k].ClientId))[0].ClientName;
                                if (ordersList[k].RecorderID != "")
                                {
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                    try
                                    {
                                        ordersList[k].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", ordersList[k].RecorderID))[0].UserName;
                                    }
                                    catch (Exception ex)
                                    {
                                        ordersList[k].RecorderName = "";
                                    }
                                }
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                if (ordersList[k].IsEnd == true) ordersList[k].IfEndName = "是";
                                else if (ordersList[k].IsEnd == false) ordersList[k].IfEndName = "否";
                                if (ordersList[k].IsDeliver == true) ordersList[k].IsDeliverName = "是";
                                else if (ordersList[k].IsDeliver == false) ordersList[k].IsDeliverName = "否";
                                if (ordersList[k].IsChecked == true) ordersList[k].IfCheckedName = "通过";
                                else if (ordersList[k].IsChecked == false) ordersList[k].IfCheckedName = "待审核";
                                if (ordersList[k].DeliveryId != "") ordersList[k].DeliveryStatus = "已派送";
                                else ordersList[k].DeliveryStatus = "未派送";
                            }
                            listStaffs = ordersList;
                            dgvOrderList.DataSource = null;
                            dgvOrderList.DataSource = ordersList;
                            if (dgvOrderList.Rows.Count > 0)
                            {
                                dgvOrderList.Rows[0].Selected = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选中要删除的订单！");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (deleteList == null) deleteList = new List<YueYePlat.Model.deliveryorder>();
            if (deleteList.Count > 0)
            {
                if (MessageBox.Show("您是否要删除选中的订单？", "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < deleteList.Count; i++)
                    {

                        List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                        for (int j = 0; i < productList.Count; j++)
                        {
                            new YueYePlat.BLL.productdelivery().Delete(productList[j].Id);
                        }
                        List<YueYePlat.Model.deliveryorderfee> feeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                        for (int j = 0; j < feeList.Count; j++)
                        {
                            new YueYePlat.BLL.deliveryorderfee().Delete(feeList[j].Id);
                        }
                        List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", deleteList[i].DeliveryOrderId));
                        if (orderList.Count == 1)
                        {
                            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", deleteList[i].DeliveryId));
                            if (deleteList.Count == 1)
                            {
                                new YueYePlat.BLL.vehicledelivery().Delete(deleteList[0].Id);
                            }
                        }
                        if (new YueYePlat.BLL.deliveryorder().Delete(deleteList[i].Id))
                        {
                            MessageBox.Show("删除成功！");
                            pageIndex = 1;
                            List<YueYePlat.Model.deliveryorder> ordersList = new YueYePlat.BLL.deliveryorder().GetModelList(pageSize, pageIndex, strWhere);
                            totalCount = new YueYePlat.BLL.deliveryorder().GetRecordCount(strWhere);
                            lbltotalCount.Text = totalCount.ToString();
                            lblPre.Text = 1 + "";
                            pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
                            lbltotalPage.Text = pageCount.ToString();
                            if (ordersList.Count == 0)
                            {
                                MessageBox.Show("此次查询没有找到对应的信息！");
                                dgvOrderList.DataSource = null;
                                dgvOrderList.DataSource = ordersList;
                                if (dgvOrderList.Rows.Count > 0)
                                {
                                    dgvOrderList.Rows[0].Selected = false;
                                }
                            }
                            else
                            {
                                for (int k = 0; k < ordersList.Count; k++)
                                {
                                    ordersList[k].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", ordersList[k].ClientId))[0].ClientName;
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
                                    if (ordersList[k].IsEnd == true) ordersList[k].IfEndName = "是";
                                    else if (ordersList[k].IsEnd == false) ordersList[k].IfEndName = "否";
                                    if (ordersList[k].IsDeliver == true) ordersList[k].IsDeliverName = "是";
                                    else if (ordersList[k].IsDeliver == false) ordersList[k].IsDeliverName = "否";
                                    if (ordersList[k].IsChecked == true) ordersList[k].IfCheckedName = "通过";
                                    else if (ordersList[k].IsChecked == false) ordersList[k].IfCheckedName = "待审核";
                                    if (ordersList[k].DeliveryId != "") ordersList[k].DeliveryStatus = "已派送";
                                    else ordersList[k].DeliveryStatus = "未派送";
                                }
                                listStaffs = ordersList;
                                dgvOrderList.DataSource = null;
                                dgvOrderList.DataSource = ordersList;
                                if (dgvOrderList.Rows.Count > 0)
                                {
                                    dgvOrderList.Rows[0].Selected = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选中要删除的订单！");
            }
        }
        private void dgvOrderList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void cbxClient_MouseClick(object sender, MouseEventArgs e)
        {
            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            cbxClient.DisplayMember = "ClientName";
            cbxClient.ValueMember = "ClientId";
            cbxClient.DataSource = clientList;
        }
    }
   
}
