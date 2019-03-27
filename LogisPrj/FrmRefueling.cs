using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmRefueling : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strDeliveryId = "";
        static FrmRefueling instance;
        public string tabPageTitle = "";
        public FrmRefueling()
        {
            InitializeComponent();
        }
        public static FrmRefueling getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmRefueling();
            }
            return instance;
        }
        private void FrmRefueling_Load(object sender, EventArgs e)
        {
            InitComponent();
            dgvRefuel.AutoGenerateColumns = false;
            monStart.Visible = false;
            monEnd.Visible = false;
            cbxDriverId.SelectedValue = "";
            cbxVehicleId.SelectedValue = "";
            if (strDeliveryId != "")
            {
                txtDeliveryId.Text = strDeliveryId;
                List<YueYePlat.Model.refueling> refueling = new YueYePlat.BLL.refueling().GetModelList(String.Format("DeliveryId='{0}'", txtDeliveryId.Text));
                if (refueling.Count > 0)
                {
                    for (int i = 0; i < refueling.Count; i++)
                    {
                        refueling[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", refueling[i].DriverId))[0].DriverName;
                        refueling[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refueling[i].VehicleID))[0].VehicleNumber;
                        if (refueling[i].IfVerifyed == true) refueling[i].IfVerifyedName = "是";
                        else if (refueling[i].IfVerifyed == false) refueling[i].IfVerifyedName = "否";
                        
                    }
                    dgvRefuel.DataSource = null;
                    dgvRefuel.DataSource = refueling;
                    if (dgvRefuel.Rows.Count > 0)
                    {
                        dgvRefuel.Rows[0].Selected = false;
                    }
                }
                else
                {
                    if (MessageBox.Show("没有对应的加油信息,您是否要增加加油费用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        FrmRefuelingInfo info = new FrmRefuelingInfo();
                        info.usersInfo = usersInfo;
                        if (info.ShowDialog() == DialogResult.OK)
                        {
                            List<YueYePlat.Model.refueling> refuelingList = new YueYePlat.BLL.refueling().GetModelList("");
                            for (int i = 0; i < refuelingList.Count; i++)
                            {
                                refuelingList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", refuelingList[i].DriverId))[0].DriverName;
                                refuelingList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refuelingList[i].VehicleID))[0].VehicleNumber;
                                if (refuelingList[i].IfVerifyed == true) refuelingList[i].IfVerifyedName = "是";
                                else if (refuelingList[i].IfVerifyed == false) refuelingList[i].IfVerifyedName = "否";
                            }
                            dgvRefuel.DataSource = null;
                            dgvRefuel.DataSource = refuelingList;
                            if (dgvRefuel.Rows.Count > 0)
                            {
                                dgvRefuel.Rows[0].Selected = false;
                            }
                        }
                    }
                }
            }
            else
            {
                List<YueYePlat.Model.refueling> refuelList = new YueYePlat.BLL.refueling().GetModelList("");
                for (int i = 0; i < refuelList.Count; i++)
                {
                    refuelList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", refuelList[i].DriverId))[0].DriverName;
                    refuelList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refuelList[i].VehicleID))[0].VehicleNumber;
                    if (refuelList[i].IfVerifyed == true) refuelList[i].IfVerifyedName = "是";
                    else if (refuelList[i].IfVerifyed == false) refuelList[i].IfVerifyedName = "否";
                }
                dgvRefuel.DataSource = null;
                dgvRefuel.DataSource = refuelList;
                if (dgvRefuel.Rows.Count > 0)
                {
                    dgvRefuel.Rows[0].Selected = false;
                }
            }

        }

        private void InitComponent()
        {
            //List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            //cbxVehicleId.DisplayMember = "VehicleNumber";
            //cbxVehicleId.ValueMember = "VehicleId";
            //cbxVehicleId.DataSource = vehicleList;
            List<YueYePlat.Model.vehicleinfo> vehicle = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicle;
            List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type !='离职'"));
            cbxDriverId.DisplayMember = "DriverName";
            cbxDriverId.ValueMember = "DriverId";
            cbxDriverId.DataSource = driverList;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要增加加油费用信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmRefuelingInfo info = new FrmRefuelingInfo();
                info.usersInfo = usersInfo;
                if (info.ShowDialog() == DialogResult.OK)
                {
                    List<YueYePlat.Model.refueling> refuelList = new YueYePlat.BLL.refueling().GetModelList("");
                    for (int i = 0; i < refuelList.Count; i++)
                    {
                        refuelList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", refuelList[i].DriverId))[0].DriverName;
                        refuelList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refuelList[i].VehicleID))[0].VehicleNumber;
                        if (refuelList[i].IfVerifyed == true) refuelList[i].IfVerifyedName = "是";
                        else if (refuelList[i].IfVerifyed == false) refuelList[i].IfVerifyedName = "否";
                    }
                    dgvRefuel.DataSource = null;
                    dgvRefuel.DataSource = refuelList;
                    if (dgvRefuel.Rows.Count > 0)
                    {
                        dgvRefuel.Rows[0].Selected = false;
                    }
                }
            } 
        }
        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void dgvRefuel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvRefuel.Rows[e.RowIndex].Cells["colId"].Value.ToString();
                List<YueYePlat.Model.refueling> refueling = new YueYePlat.BLL.refueling().GetModelList(String.Format("ID='{0}'", str));
                YueYePlat.Model.refueling refuelingInfo = refueling.Find(v => v.Id.ToString().Equals(str));
                FrmRefuelingInfo info = new FrmRefuelingInfo();
                info.usersInfo = usersInfo;
                info.refueling = refuelingInfo;
                if (info.ShowDialog() == DialogResult.OK)
                {
                    List<YueYePlat.Model.refueling> refuelList = new YueYePlat.BLL.refueling().GetModelList("");
                    for (int i = 0; i < refuelList.Count; i++)
                    {
                        refueling[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", refueling[i].DriverId))[0].DriverName;
                        refuelList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refuelList[i].VehicleID))[0].VehicleNumber;
                        if (refuelList[i].IfVerifyed == true) refuelList[i].IfVerifyedName = "是";
                        else if (refuelList[i].IfVerifyed == false) refuelList[i].IfVerifyedName = "否";
                    }
                    dgvRefuel.DataSource = null;
                    dgvRefuel.DataSource = refuelList;
                    if (dgvRefuel.Rows.Count > 0)
                    {
                        dgvRefuel.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            strWhere = "1=1";            
            if (txtStart.Text .Trim() != "")
            {
               // strWhere+= String.Format (" and DeliveryId like '%{0}%'",dTRefueling.Value.ToString("yyMMdd").Trim());

                if (txtEnd.Text .Trim () != "")
                {
                    strWhere += String.Format(" and  RefuelTime > '{0}' and RefuelTime<'{1}'", txtStart.Text.Trim(), txtEnd.Text.Trim());
                }
                else
                {
                    strWhere += String.Format(" and RefuelTime> '{0}' ", txtStart.Text.Trim());
                }
            }
            if(cbxVehicleId.SelectedValue!=null)
            {
                strWhere += String.Format(" and VehicleId='{0}'",cbxVehicleId.SelectedValue.ToString ());
            }
            if (cbxDriverId.SelectedValue != null)
            {
                strWhere += String.Format(" and DriverId='{0}'",cbxDriverId.SelectedValue.ToString ());
            }          
            if (txtDeliveryId.Text.Trim() != "")
            {               
                strWhere += String.Format(" and  DeliveryId='{0}'", txtDeliveryId.Text .Trim ());
            }
            if (txtDeliveryId.Text.Trim() != "" || txtStart.Text.Trim() != "" || cbxVehicleId.SelectedValue!=null ||cbxDriverId.SelectedValue!=null)
            {
                List<YueYePlat.Model.refueling> refueling = new YueYePlat.BLL.refueling().GetModelList(strWhere);
                if (refueling.Count > 0)
                {
                    for (int i = 0; i < refueling.Count; i++)
                    {
                        refueling[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("DriverId='{0}'",refueling[i].DriverId))[0].DriverName;
                        refueling[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", refueling[i].VehicleID))[0].VehicleNumber;
                        if (refueling[i].IfVerifyed == true) refueling[i].IfVerifyedName = "是";
                        else if (refueling[i].IfVerifyed == false) refueling[i].IfVerifyedName = "否";
                    }
                    dgvRefuel.DataSource = null;
                    dgvRefuel.DataSource = refueling;
                    if (dgvRefuel.Rows.Count > 0)
                    {
                        dgvRefuel.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("没有对应的加油信息！");
                    dgvRefuel.DataSource = null;
                }
            }
        }

        private void dgvRefuel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvRefuel.Columns[e.ColumnIndex].Name == "colIfVerifyedName")
            {
                if (e.Value.ToString() == "否")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                { }
            }
        }     

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void txtStart_Click(object sender, EventArgs e)
        {
            monStart.Visible = true;
        }

        private void txtEnd_Click(object sender, EventArgs e)
        {
            monEnd.Visible = true;
        }

        private void monStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtStart.Text = monStart.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
            monStart.Visible = false;
        }

        private void monEnd_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtEnd.Text = monEnd.SelectionStart.ToString("yyyy-MM-dd 23:59:59");
            monEnd.Visible = false;
        }
    }
}
