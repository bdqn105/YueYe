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
    public partial class FrmVehicleinfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        YueYePlat.BLL.vehicleinfo bll;
        private  int  vehicleId =-1;
        List<YueYePlat.Model.vehicleinfo> vehicleList;
        static FrmVehicleinfo instance;
        public string tabPageTitle = "";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmVehicleinfo()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.vehicleinfo();
        }
        public static FrmVehicleinfo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmVehicleinfo();
            }
            return instance;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要新增车辆信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {                
                FrmVehicleAddOrUpdate add = new LogisPrj.FrmVehicleAddOrUpdate();
                add.usersInfo = usersInfo;
                add.Text = "增加车辆信息";
                if (add.ShowDialog() == DialogResult.OK)
                {
                    vehicleList = bll.GetModelList("");                   
                    for (int i = 0; i < vehicleList.Count; i++)
                    {        
                        vehicleList[i].CompanyId = new YueYePlat.BLL.companyinfo ().GetModelList(String.Format("CompanyId='{0}'", vehicleList[i].CompanyId))[0].CompanyName;      
                        vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                        if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                        else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                    }
                    dgvVehicle.DataSource = null;
                    dgvVehicle.DataSource = vehicleList;
                    if (dgvVehicle.Rows.Count > 0)
                    {
                        dgvVehicle.Rows[0].Selected = false;
                    }
                }
                vehicleId = -1;
            } 
        }

        private void FrmVehicleinfo_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvVehicle.AutoGenerateColumns = false;
            cbxVehicleStatus.Text = "全部";         
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该车辆信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (vehicleId != -1)
                {
                    bool isSuccess = new YueYePlat.BLL.vehicleinfo().Delete(vehicleId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                    }
                    vehicleList = bll.GetModelList("");
                    for (int i = 0; i < vehicleList.Count; i++)
                    {
                        vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                        if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                        else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                    }
                    dgvVehicle.DataSource = null;
                    dgvVehicle.DataSource = vehicleList;
                    if (dgvVehicle.Rows.Count > 0)
                    {
                        dgvVehicle.Rows[0].Selected = false;
                    }
                  
                }
            }
                           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicleId != -1)
                {
                    if (MessageBox.Show("您确定要修改该车辆信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        FrmVehicleAddOrUpdate modify = new LogisPrj.FrmVehicleAddOrUpdate();
                        YueYePlat.Model.vehicleinfo info = vehicleList.Find(v => v.Id.Equals(vehicleId));
                        modify.vehicle = info;
                        modify.usersInfo = usersInfo;
                        modify.Text = "修改车辆信息";
                        if (modify.ShowDialog() == DialogResult.OK)
                        {
                            List<YueYePlat.Model.vehicleinfo> vehicleList = bll.GetModelList("");
                            for (int i = 0; i < vehicleList.Count; i++)
                            {
                                vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                                if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                                else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                            }
                            dgvVehicle.DataSource = null;
                            dgvVehicle.DataSource = vehicleList;
                            if (dgvVehicle.Rows.Count > 0)
                            {
                                dgvVehicle.Rows[0].Selected = false;
                            }
                            vehicleId = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择车辆");
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }              
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >-1)
            {
                try
                {
                  
                    vehicleId = int.Parse (dgvVehicle.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch(Exception ex)
                {
                    vehicleId  = -1;
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

        private void dgvVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvVehicle.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                if (str != "")
                {
                    List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("Id='{0}'", str));
                    YueYePlat.Model.vehicleinfo vehicleInfo = vehicleList.Find(v => v.Id.Equals(int.Parse(str)));
                    FrmVehicleAddOrUpdate vehicle = new FrmVehicleAddOrUpdate();
                    vehicle.usersInfo = usersInfo;
                    vehicle.vehicle = vehicleInfo;
                    if (vehicle.ShowDialog() == DialogResult.OK)
                    {
                        vehicleList = bll.GetModelList("");
                        for (int i = 0; i < vehicleList.Count; i++)
                        {
                            vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                            if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                            else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                        }
                        dgvVehicle.DataSource = null;
                        dgvVehicle.DataSource = vehicleList;
                        if (dgvVehicle.Rows.Count > 0)
                        {
                            dgvVehicle.Rows[0].Selected = false;
                        }
                    }

                }
            }
        }

        private void btnTempVehicle_Click(object sender, EventArgs e)
        {
            FrmTempvehicle tempVehicle = new FrmTempvehicle();
            tempVehicle.usersInfo = usersInfo;
            if (tempVehicle.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbxVehicleStatus.Text == "全部")
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList("");
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                    if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                    else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                }
                dgvVehicle.DataSource = null;
                dgvVehicle.DataSource = vehicleList;
                if (dgvVehicle.Rows.Count > 0)
                {
                    dgvVehicle.Rows[0].Selected = false;
                }
            }
            else if (cbxVehicleStatus.Text == "公司车辆")
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("IFBelongsto=true"));
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                    if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                    else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                }
                dgvVehicle.DataSource = null;
                dgvVehicle.DataSource = vehicleList;
                if (dgvVehicle.Rows.Count > 0)
                {
                    dgvVehicle.Rows[0].Selected = false;
                }
            }
            else if (cbxVehicleStatus.Text == "临时车辆")
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("IFBelongsto=false"));
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehicleList[i].VehicletypeName = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeId='{0}'", vehicleList[i].VehicleType))[0].VehicleTypeName;
                    if (vehicleList[i].IFBelongsto == true) vehicleList[i].IsBelongstoName = "是";
                    else if (vehicleList[i].IFBelongsto == false) vehicleList[i].IsBelongstoName = "否";
                }
                dgvVehicle.DataSource = null;
                dgvVehicle.DataSource = vehicleList;
                if (dgvVehicle.Rows.Count > 0)
                {
                    dgvVehicle.Rows[0].Selected = false;
                }
            }
        }
    }
}
