using Log;
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
    public partial class FrmVehicleupkeep : Form
    {
        YueYePlat.BLL.vehicleupkeep bll;
        List<YueYePlat.Model.vehicleupkeep> vehicleupkeepList;
        public YueYePlat.Model.usersinfo usersInfo;
        private int vehicliupkeepId = -1;
        YueYePlat.Model.vehicleupkeep vehiclekeep = null;
        List<YueYePlat.Model.logiscompanyinfo> companyList;
        static FrmVehicleupkeep instance;
        public string tabPageTitle = "";
        string keepImageName;
        string keepImagePath;
        public FrmVehicleupkeep()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.vehicleupkeep();
        }
        public static FrmVehicleupkeep getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmVehicleupkeep();
            }
            return instance;
        }
        private void FrmVehicleupkeep_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                companyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                InitComponent();
                this.dtupkeepEnd.Format = DateTimePickerFormat.Custom;
                this.dtupkeepEnd.CustomFormat = " ";
                this.dtupkeepEnd.Checked = false;
                this.dtupkeepStart.Format = DateTimePickerFormat.Custom;
                this.dtupkeepStart.CustomFormat = " ";
                this.dtupkeepStart.Checked = false;
                cbxVehicleId.SelectedValue = "";
                cbxDriverId.SelectedValue = "";

                dgvVehicleKeep.AutoGenerateColumns = false;
                vehicleupkeepList = bll.GetModelList("");
                for (int i = 0; i < vehicleupkeepList.Count; i++)
                {
                    try
                    {
                        vehicleupkeepList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleupkeepList[i].VehicleId))[0].VehicleNumber;
                    }
                    catch (Exception ex)
                    {
                        vehicleupkeepList[i].VehicleNumber = "";
                    }                    
                    if (vehicleupkeepList[i].UpkeepMan != "")
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        vehicleupkeepList[i].KeepManName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", vehicleupkeepList[i].UpkeepMan))[0].UserName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                    }                    
                }
                dgvVehicleKeep.DataSource = null;
                dgvVehicleKeep.DataSource = vehicleupkeepList;
                if (dgvVehicleKeep.Rows.Count > 0)
                {
                    dgvVehicleKeep.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要新增该车辆保养记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmVehicleupkeepInfo vehiclekeep = new FrmVehicleupkeepInfo();
                vehiclekeep.usersInfo = usersInfo;
                if (vehiclekeep.ShowDialog() == DialogResult.OK)
                {
                    vehicleupkeepList = bll.GetModelList("");
                    for (int i = 0; i < vehicleupkeepList.Count; i++)
                    {
                        vehicleupkeepList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleupkeepList[i].VehicleId))[0].VehicleNumber;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        vehicleupkeepList[i].KeepManName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", vehicleupkeepList[i].UpkeepMan))[0].UserName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                    }
                    dgvVehicleKeep.DataSource = null;
                    dgvVehicleKeep.DataSource = vehicleupkeepList;
                    if (dgvVehicleKeep.Rows.Count > 0)
                    {
                        dgvVehicleKeep.Rows[0].Selected = false;
                    }

                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            if (vehicliupkeepId > -1)
            {
                if (MessageBox.Show("您确定要修改该车辆保养记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.vehicleupkeep info = vehicleupkeepList.Find(v => v.Id.Equals(vehicliupkeepId));
                    FrmVehicleupkeepInfo modify = new FrmVehicleupkeepInfo();
                    modify.usersInfo = usersInfo;
                    modify.vehiclekeep = info;
                    modify.Text = "修改车辆保养信息";
                    if (modify.ShowDialog() == DialogResult.OK)
                    {
                        vehicleupkeepList = bll.GetModelList("");
                        for (int i = 0; i < vehicleupkeepList.Count; i++)
                        {
                            vehicleupkeepList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleupkeepList[i].VehicleId))[0].VehicleNumber;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            vehicleupkeepList[i].KeepManName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", vehicleupkeepList[i].UpkeepMan))[0].UserName;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                        }
                        dgvVehicleKeep.DataSource = null;
                        dgvVehicleKeep.DataSource = vehicleupkeepList;
                        if (dgvVehicleKeep.Rows.Count > 0)
                        {
                            dgvVehicleKeep.Rows[0].Selected = false;
                        }
                    }
                    vehicliupkeepId = -1;
                }

            }
            else
            {
                MessageBox.Show("请选择保养记录！");
            }




        }
        private void dgvVehicleKeep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    vehicliupkeepId = int.Parse(dgvVehicleKeep.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    vehicliupkeepId = -1;
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

        private void dgvVehicleKeep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvVehicleKeep.Rows[e.RowIndex].Cells["colId"].Value.ToString();
                List<YueYePlat.Model.vehicleupkeep> vehiclekeepList = new YueYePlat.BLL.vehicleupkeep().GetModelList(String.Format("ID='{0}'", str));
                YueYePlat.Model.vehicleupkeep vehiclekeepInfo = vehiclekeepList.Find(v => v.Id.ToString().Equals(str));
                int cid = e.ColumnIndex;
                FrmVehicleupkeepInfo keepInfo = new FrmVehicleupkeepInfo();
                keepInfo.usersInfo = usersInfo;
                keepInfo.vehiclekeep = vehiclekeepInfo;
                if (keepInfo.ShowDialog() == DialogResult.OK)
                {
                    vehicleupkeepList = bll.GetModelList("");
                    for (int i = 0; i < vehicleupkeepList.Count; i++)
                    {
                        vehicleupkeepList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleupkeepList[i].VehicleId))[0].VehicleNumber;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        vehicleupkeepList[i].KeepManName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", vehicleupkeepList[i].UpkeepMan))[0].UserName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                    }
                    dgvVehicleKeep.DataSource = null;
                    dgvVehicleKeep.DataSource = vehicleupkeepList;
                    if (dgvVehicleKeep.Rows.Count > 0)
                    {
                        dgvVehicleKeep.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            strWhere = "1=1";
            if (cbxVehicleId.SelectedValue != null)
            {
                strWhere += String.Format(" and VehicleId = '{0}'", cbxVehicleId.SelectedValue.ToString());
            }
            if (cbxDriverId.SelectedValue != null)
            {
                strWhere += String.Format(" and UpkeepMan = '{0}'", cbxDriverId.SelectedValue.ToString());
            }
            if (dtupkeepStart.Value!=null)
            {
                if (dtupkeepEnd.Value != null)
                {
                    strWhere += String.Format(" and  UpkeepTime > '{0}' and UpkeepTime<'{1}'", dtupkeepStart.Value .ToString(), dtupkeepEnd.Value .ToString ());
                }
                else
                {
                    strWhere += String.Format(" and UpkeepTime> '{0}' ", dtupkeepStart.Value.ToString());
                }

            }
            if (cbxVehicleId.SelectedValue != null || dtupkeepStart.Value !=null || dtupkeepEnd.Value!=null)
            {
                List<YueYePlat.Model.vehicleupkeep> keepList = new YueYePlat.BLL.vehicleupkeep().GetModelList(String.Format(strWhere));
                if (keepList.Count > 0)
                {
                    for (int i = 0; i < keepList.Count; i++)
                    {
                        keepList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", keepList[i].VehicleId))[0].VehicleNumber;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        keepList[i].KeepManName = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", keepList[i].UpkeepMan))[0].UserName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyList[0].CompanyDBName);
                    }
                    dgvVehicleKeep.DataSource = null;
                    dgvVehicleKeep.DataSource = keepList;
                    if (dgvVehicleKeep.Rows.Count > 0)
                    {
                        dgvVehicleKeep.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("没有查询到对应的信息!");
                    dgvVehicleKeep.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }        
        }

        private void dtupkeepStart_ValueChanged(object sender, EventArgs e)
        {
            this.dtupkeepStart.Format = DateTimePickerFormat.Long;
            this.dtupkeepStart.CustomFormat = null;
        }

        private void dtupkeepEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dtupkeepEnd.Format = DateTimePickerFormat.Long;
            this.dtupkeepEnd.CustomFormat = null;
        }
    }
}
