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
    public partial class FrmReportManager : Form
    {
        static FrmReportManager instance;
        public YueYePlat.Model.usersinfo usersInfo;
        public string tabPageTitle = "";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmReportManager()
        {
            InitializeComponent();
        }
        public static FrmReportManager getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmReportManager();
            }
            return instance;
        }
        private void FrmReportManager_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            InitComponent();
            dgvDelivery.AutoGenerateColumns = false;
            cbxDriverId.Text = "";
            cbxVehicleId.Text = "";
        }

        private void InitComponent()
        {
            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleList;
            List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxDriverId.DisplayMember = "DriverName";
            cbxDriverId.ValueMember = "DriverId";
            cbxDriverId.DataSource = driverList;             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            string strWhere = "";
            strWhere = "1=1";
            if (cbxDriverId.Text.Trim() != "" && cbxDriverId.SelectedValue != null)
            {
                strWhere += String.Format(" and driver1Id = '{0}'", cbxDriverId.SelectedValue.ToString().Trim());
            }
            if (cbxVehicleId.Text != "" && cbxVehicleId.SelectedValue != null)
            {
                strWhere += String.Format(" and VehicleId = '{0}'", cbxVehicleId.SelectedValue.ToString());
            }
            //if (dTDeliveryTime.Value != null)
            //{
            //    strWhere += String.Format(" and deliveryId like '%{0}%'", dTDeliveryTime.Value.ToString("yyMMdd")).Trim() ;
            //}
            if (cbxDriverId.Text.Trim() == "" && cbxDriverId.SelectedValue == null && cbxVehicleId.Text== "" && cbxVehicleId.SelectedValue == null)
            {
                strWhere = String.Format("   deliveryId like '%{0}%'", dTDeliveryTime.Value.ToString("yyMMdd")).Trim();
            }
            else
            {
                strWhere += String.Format("  and deliveryId like '%{0}%'", dTDeliveryTime.Value.ToString("yyMMdd"));
            }
            if (dTDeliveryTime.Value!=null  )
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format(strWhere));
                if (deliveryList.Count > 0)
                {
                    for (int i = 0; i < deliveryList.Count; i++)
                    {
                        if (deliveryList[i].IfEnd == true) deliveryList[i].IfEndName = "是";
                        else if (deliveryList[i].IfEnd == false) deliveryList[i].IfEndName = "否";
                        if (deliveryList[i].Driver1Id != "" && deliveryList[i].Driver1Id != null)
                        {
                            try
                            {
                                deliveryList[i].Driver1Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver1Id))[0].DriverName;
                            }
                            catch (Exception ex)
                            {
                                deliveryList[i].Driver1Name = "";
                            }
                        }
                        if (deliveryList[i].Driver2Id != "" && deliveryList[i].Driver2Id != null)
                        {
                            deliveryList[i].Driver2Name = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", deliveryList[i].Driver2Id))[0].DriverName;
                        }
                        if (deliveryList[i].VehicleId != "" && deliveryList[i].VehicleId != null)
                        {
                            deliveryList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deliveryList[i].VehicleId))[0].VehicleNumber;
                        }
                        if (deliveryList[i].Auditor != null && deliveryList[i].Auditor != "")
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            deliveryList[i].Auditor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", deliveryList[i].Auditor))[0].UserName;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        }
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
                    dgvDelivery.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >-1)
            { 
            string str = dgvDelivery.Rows[e.RowIndex].Cells["coldeliveryId"].Value.ToString();
            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("deliveryId='{0}'", str));
            YueYePlat.Model.vehicledelivery deliveryInfo = deliveryList.Find(v => v.DeliveryId.Equals(str));
            int cid = e.ColumnIndex;
            string strcolName = this.dgvDelivery.Columns[cid].DefaultCellStyle.NullValue.ToString();

                if (strcolName == "打印报表")
                {
                    if (deliveryInfo.DeliveryId != "")
                    {
                        if (MessageBox.Show("是否打印明细费用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            FrmTransferOrderReport report = new FrmTransferOrderReport();
                            report.strDetailFee = "detailFee";
                            
                            //report.deliveryId = deliveryInfo.DeliveryId;
                            report.usersInfo = usersInfo;
                            report.ShowDialog();
                        }
                        else
                        {
                            FrmTransferOrderReport report = new FrmTransferOrderReport();
                            report.strDetailFee = "nodetailFee";
                           // report.deliveryId = deliveryInfo.DeliveryId;
                            report.usersInfo = usersInfo;
                            report.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选中要打印报表的订单！");
                    }
                }
            }
        }
    }
}
