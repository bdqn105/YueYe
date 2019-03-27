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
    public partial class FrmTransferManager : Form
    {        
        public YueYePlat.Model.usersinfo usersInfo;      
        static FrmTransferManager instance;
        public string tabPageTitle = "";
        int index = 0;
        string deliveryId = "";
        public string strDeliveryId = "";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmTransferManager()
        {
            InitializeComponent();
        }
        public static FrmTransferManager getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmTransferManager();
            }
            return instance;
        }
        private void FrmTransport_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvDelivery.AutoGenerateColumns = false;
            InitComponent();
            if (strDeliveryId != "")
            {
                //txtDeliveryOrderId.Text = strDeliveryId;
                btnClose.Visible = false;
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
                if (deliveryList.Count > 0)
                {
                    for (int i = 0; i < deliveryList.Count; i++)
                    {
                        try
                        {
                            deliveryList[i].Driver1Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].Driver1Name = "";
                        }

                        if (deliveryList[i].Driver2Id != null && deliveryList[i].Driver2Id != "")
                        {
                            try
                            {
                                deliveryList[i].Driver2Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].Driver2Name = "";
                            }

                        }
                        try
                        {
                            deliveryList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].VehicleNumber = "";
                        }
                        if (deliveryList[i].RecordId != null && deliveryList[i].RecordId != "")
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            try
                            {
                                deliveryList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", deliveryList[i].RecordId))[0].UserName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].RecorderName = "";
                            }
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        }
                        if (deliveryList[i].IfEnd == true) deliveryList[i].IfEndName = "是";
                        else if (deliveryList[i].IfEnd == false) deliveryList[i].IfEndName = "否";
                        if (deliveryList[i].IfChargeback == true) deliveryList[i].IfChargebackName = "是";
                        else if (deliveryList[i].IfChargeback == false) deliveryList[i].IfChargebackName = "否";
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
                    MessageBox.Show("没有对应的配送信息，请仔细核查！");
                }
            }
            else
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("IfEnd=0"));
                if (deliveryList.Count > 0)
                {
                    for (int i = 0; i < deliveryList.Count; i++)
                    {
                        try
                        {
                            deliveryList[i].Driver1Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].Driver1Name = "";
                        }

                        if (deliveryList[i].Driver2Id != null && deliveryList[i].Driver2Id != "")
                        {
                            try
                            {
                                deliveryList[i].Driver2Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].Driver2Name = "";
                            }

                        }
                        try
                        {
                            deliveryList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].VehicleNumber = "";
                        }
                        if (deliveryList[i].RecordId != null && deliveryList[i].RecordId != "")
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            try
                            {
                                deliveryList[i].RecorderName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", deliveryList[i].RecordId))[0].UserName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].RecorderName = "";
                            }
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        }
                        if (deliveryList[i].IfEnd == true) deliveryList[i].IfEndName = "是";
                        else if (deliveryList[i].IfEnd == false) deliveryList[i].IfEndName = "否";
                        if (deliveryList[i].IfChargeback == true) deliveryList[i].IfChargebackName = "是";
                        else if (deliveryList[i].IfChargeback == false) deliveryList[i].IfChargebackName = "否";
                    }
                    dgvDelivery.DataSource = null;
                    dgvDelivery.DataSource = deliveryList;
                    if (dgvDelivery.Rows.Count > 0)
                    {
                        dgvDelivery.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void InitComponent()
        {
            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleList;
            List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxDriver.DisplayMember = "DriverName";
            cbxDriver.ValueMember = "DriverId";
            cbxDriver.DataSource = driverList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTransferOrderInfo info = new FrmTransferOrderInfo();
            info.usersinfo = usersInfo;
            info.operate = "add";           
            info.ShowDialog();
            
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
                if (strcolName == "修改")
                {
                    if (deliveryInfo.IfEnd == true)
                    {
                        MessageBox.Show("该派送单已完结，无法进行修改！");
                    }
                    else
                    {
                        FrmTransferOrderInfo info = new FrmTransferOrderInfo();
                        info.delivery = deliveryInfo;
                        info.usersinfo = usersInfo;
                        info.operate = "modify";
                        info.ShowDialog();
                    }
                }             
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {        
            //FrmTransferEnding transferEnd = FrmTransferEnding.getInstance();
            //transferEnd.usersInfo = usersInfo;
            //if (txtDeliveryOrderId.Text != "")
            //{
            //    transferEnd.strOrderId = txtDeliveryOrderId.Text;
            //}
            //if (transferEnd.ShowDialog() == DialogResult.OK)
            //{
            //    List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList("");
            //    for (int i = 0; i < deliveryList.Count; i++)
            //    {
            //        try
            //        {
            //            deliveryList[i].Driver1Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
            //        }
            //        catch (Exception ex)
            //        {
            //            deliveryList[i].Driver1Name = "";
            //        }

            //        if (deliveryList[i].Driver2Id != null && deliveryList[i].Driver2Id != "")
            //        {
            //            try
            //            {
            //                deliveryList[i].Driver2Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
            //            }
            //            catch (Exception ex)
            //            {
            //                deliveryList[i].Driver2Name = "";
            //            }
            //        }
            //        try
            //        {
            //            deliveryList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
            //        }
            //        catch (Exception ex)
            //        {
            //            deliveryList[i].VehicleNumber = "";
            //        }
            //        if (deliveryList[i].IfEnd == true) deliveryList[i].IfEndName = "是";
            //        else if (deliveryList[i].IfEnd == false) deliveryList[i].IfEndName = "否";
            //    }
            //    dgvDelivery.DataSource = null;
            //    dgvDelivery.DataSource = deliveryList;
            //    if (dgvDelivery.Rows.Count > 0)
            //    {
            //        dgvDelivery.Rows[0].Selected = false;
            //    }
            //}
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            strWhere = "1=1";
            if (txtDeliveryId.Text.Trim() != "")
            {
                List<YueYePlat.Model.deliveryorder> ordersList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format ("DeliveryOrderId='{0}'",txtDeliveryId.Text .Trim ()));
                if (ordersList.Count > 0)
                {
                    if (ordersList[0].DeliveryId == null || ordersList[0].DeliveryId.ToString() != "")
                    {
                        MessageBox.Show("该订单还未被驾驶员接单！");
                    }
                    else
                    {
                        string strDeliveryId = ordersList[0].DeliveryId;
                        if (strDeliveryId != "")
                        {
                            strWhere += String.Format(" and DeliveryId='{0}'", strDeliveryId);
                        }
                    }
                }            
            }
            if (cbxDriver.SelectedValue != null && cbxDriver.SelectedValue.ToString() != "")
            {
                strWhere += String.Format(" and (Driver1Id='{0}' or Driver2Id='{0}')",cbxDriver.SelectedValue.ToString ());
            }
            if (cbxVehicleId.SelectedValue != null && cbxVehicleId.SelectedValue.ToString() != "")
            {
                strWhere += String.Format(" and VehicleId='{0}'",cbxVehicleId.SelectedValue.ToString ());
            }                    
            if (txtDeliveryId.Text.Trim() != ""||cbxDriver.SelectedValue!=null|| cbxVehicleId.SelectedValue!=null)
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(strWhere);
                if (deliveryList.Count > 0)
                {
                    for (int i = 0; i < deliveryList.Count; i++)
                    {
                        try
                        {
                            deliveryList[i].Driver1Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].Driver1Name = "";
                        }
                        if (deliveryList[i].Driver2Id != null && deliveryList[i].Driver2Id != "")
                        {
                            try
                            {
                                deliveryList[i].Driver2Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].Driver2Name = "";
                            }
                        }
                        try
                        {
                            deliveryList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
                        }
                        catch (Exception ex)
                        {
                            deliveryList[i].VehicleNumber = "";
                        }
                        if (deliveryList[i].IfEnd == true) deliveryList[i].IfEndName = "是";
                        else if (deliveryList[i].IfEnd == false) deliveryList[i].IfEndName = "否";
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
                    MessageBox.Show("没有查询到对应的数据！");
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }
        }

        private void dgvDelivery_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvDelivery.Columns[e.ColumnIndex].Name == "colIfEndName")
            {
                if (e.Value.ToString() == "否")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                { }
            }
            if (dgvDelivery.Columns[e.ColumnIndex].Name == "colIfChargebackName")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "是")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        // dgvDelivery.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    { }
                }
            }
        }

        private void TSMenuRefueling_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要查看加油费用记录？", "提示", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                FrmRefueling refueling = new FrmRefueling();
                refueling.usersInfo = usersInfo;
                refueling.strDeliveryId = strDeliveryId;
                refueling.ShowDialog();

            }
        }     
        private void dgvDelivery_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvDelivery.Rows[e.RowIndex].Selected == false)
                    {
                        dgvDelivery.ClearSelection();
                        dgvDelivery.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvDelivery.SelectedRows.Count == 1)
                    {
                        //  dgvOrderList.CurrentCell = dgvOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        strDeliveryId = dgvDelivery.Rows[e.RowIndex].Cells["colDeliveryId"].Value.ToString();

                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void TSMenuRoad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要查看过路费用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmRoadtoll roadtoll = new FrmRoadtoll();
                roadtoll.usersInfo = usersInfo;
                roadtoll.strDeliveryId = strDeliveryId;
                roadtoll.ShowDialog();
            }
        }

        private void btnClientOrder_Click(object sender, EventArgs e)
        {
            FrmClientOrder clientOrder = new FrmClientOrder();
            clientOrder.usersInfo = usersInfo;
            clientOrder.ShowDialog();
        }

        private void TSAddNewOrder_Click(object sender, EventArgs e)
        {
            FrmTransAddNewOrder neworder = new FrmTransAddNewOrder();
            neworder.usersInfo = usersInfo;
            neworder.strDeliveryId = strDeliveryId;
            neworder.ShowDialog();
        }
    }
}
