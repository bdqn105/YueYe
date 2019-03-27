using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTempvehicle : Form
    {
        YueYePlat.BLL.tempvehicleinfo bll;
        public YueYePlat.Model.tempvehicleinfo tempVehicle = null;
        List<YueYePlat.Model .tempvehicleinfo> tempVehicleList;
        public YueYePlat.Model.usersinfo usersInfo;
        private int tempVehicleId = -1;
        static FrmTempvehicle  instance;
        public string tabPageTitle = "";
        string strVehicleId = "";
        string strDriverId = "";      

        public FrmTempvehicle()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.tempvehicleinfo();
        }
        public static FrmTempvehicle  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmTempvehicle();
            }
            return instance;
        }
        private void FrmTempvehicle_Load(object sender, EventArgs e)
        {
            dgvTempVehicle.AutoGenerateColumns = false;
            InitComponent();
            tempVehicleList = bll.GetModelList("");
            for (int i = 0; i < tempVehicleList.Count; i++)
            {
                tempVehicleList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format ("VehicleId='{0}'",tempVehicleList[i].VehicleId))[0].VehicleNumber;
                tempVehicleList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("DriverId='{0}'",tempVehicleList[i].DriverId))[0].DriverName;
            }
            dgvTempVehicle.DataSource = null;
            dgvTempVehicle.DataSource = tempVehicleList;
            if (dgvTempVehicle.Rows.Count > 0)
            {
                dgvTempVehicle.Rows[0].Selected = false;
            }
          
        }

        [DllImport("user32.dll")]
        public static extern int MessageBoxTimeoutA(IntPtr hWnd, string msg, string Caps, int type, int Id, int time);//引用DLL

     



        private void InitComponent()
        {
            List<YueYePlat.Model.driverinfo> driverInfos = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type='临时'"));
            cbxDriverId.DisplayMember = "DriverName";
            cbxDriverId.ValueMember = "DriverId";
            cbxDriverId.DataSource = driverInfos;
            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format ("IFBelongsto=false"));
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxVehicleId.SelectedValue != null && cbxDriverId.SelectedValue.ToString() != "")
            {
                if (MessageBox.Show("您确定要增加临时车辆记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.tempvehicleinfo tempVehicle = new YueYePlat.Model.tempvehicleinfo();
                    tempVehicle.VehicleId = cbxVehicleId.SelectedValue.ToString ();
                    tempVehicle.DriverId = cbxDriverId.SelectedValue.ToString();
                    tempVehicle.Time = DateTime.Now;
                    tempVehicle.Coments = txtComents.Text;
                    if (new YueYePlat.BLL.tempvehicleinfo().Add(tempVehicle))
                    {
                        MessageBox.Show("增加成功");
                        tempVehicleList = bll.GetModelList("");
                        for (int i = 0; i < tempVehicleList.Count; i++)
                        {
                            tempVehicleList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", tempVehicleList[i].VehicleId))[0].VehicleNumber;
                            tempVehicleList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", tempVehicleList[i].DriverId))[0].DriverName;
                        }
                        dgvTempVehicle.DataSource = null;
                        dgvTempVehicle.DataSource = tempVehicleList;
                        if (dgvTempVehicle.Rows.Count > 0)
                        {
                            dgvTempVehicle.Rows[0].Selected = false;
                        }
                    }

                }  

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tempVehicleId != -1)
            {
                if (MessageBox.Show("您确定要修改临时车辆？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tempVehicle.VehicleId = cbxVehicleId.SelectedValue.ToString ();
                    tempVehicle.DriverId = cbxDriverId.SelectedValue.ToString();
                    tempVehicle.Time = DateTime.Now;
                    tempVehicle.Coments = txtComents.Text;
                    if (new YueYePlat.BLL.tempvehicleinfo().Update(tempVehicle))
                    {
                        MessageBox.Show("修改成功");
                        tempVehicleList = bll.GetModelList("");
                        dgvTempVehicle.DataSource = null;
                        dgvTempVehicle.DataSource = tempVehicleList;
                        if (dgvTempVehicle.Rows.Count > 0)
                        {
                            dgvTempVehicle.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的车辆！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tempVehicleId != -1)
            {
                if (MessageBox.Show("您确定要删除临时车辆记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.tempvehicleinfo().Delete(tempVehicleId);
                    if (isSuccess == true)
                    {
                        if (MessageBox.Show("该条记录已成功删除,是否删除临时车辆和临时驾驶员信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            tempVehicleList = bll.GetModelList("");
                            for (int i = 0; i < tempVehicleList.Count; i++)
                            {
                                tempVehicleList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", tempVehicleList[i].VehicleId))[0].VehicleNumber;
                                tempVehicleList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", tempVehicleList[i].DriverId))[0].DriverName;
                            }
                            dgvTempVehicle.DataSource = null;
                            dgvTempVehicle.DataSource = tempVehicleList;
                            if (dgvTempVehicle.Rows.Count > 0)
                            {
                                dgvTempVehicle.Rows[0].Selected = false;
                            }
                        }
                        else
                        {
                            if (strVehicleId != "")
                            {
                                List<YueYePlat.Model.vehicleinfo> vehicle = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", strVehicleId));
                                if (new YueYePlat.BLL.vehicleinfo().Delete(vehicle[0].Id))
                                {
                                    MessageBoxTimeoutA((IntPtr)0, "临时车辆已成功删除！", "消息框", 0, 0, 2000);// 直接调用  3秒后自动关闭 父窗口句柄没有直接用0代替
                                }
                            }
                            if (strDriverId != "")
                            {
                                List<YueYePlat.Model.driverinfo> driver = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("DriverId='{0}'",strDriverId));
                                if (new YueYePlat.BLL.driverinfo().Delete(driver[0].Id))
                                {
                                    MessageBoxTimeoutA((IntPtr)0, "临时驾驶员已成功删除！", "消息框", 0, 0, 2000);// 直接调用  3秒后自动关闭 父窗口句柄没有直接用0代替
                                  
                                }
                            }
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的车辆！");
            }
        }

        private void dgvTempVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    tempVehicleId = int.Parse(dgvTempVehicle.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                    strVehicleId = dgvTempVehicle.Rows[e.RowIndex].Cells["colVehicleId"].Value.ToString();
                    strDriverId = dgvTempVehicle.Rows[e.RowIndex].Cells["colDriverId"].Value.ToString();
                }
                catch (Exception ex)
                {
                    tempVehicleId = -1;
                }
            }
            YueYePlat.Model.tempvehicleinfo info = tempVehicleList.Find(v=>v.Id .Equals (tempVehicleId));
            tempVehicle = info;
            if (tempVehicle != null)
            {
                cbxVehicleId.SelectedValue = tempVehicle.VehicleId;
                txtComents.Text = tempVehicle.Coments;
                cbxDriverId.SelectedValue = tempVehicle.DriverId;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnAddtempDriver_Click(object sender, EventArgs e)
        {
            FrmDriverAddOrUpdate driver = new FrmDriverAddOrUpdate();
            driver.usersInfo = usersInfo;
            driver.type = "临时";
            if (driver.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type='临时'"));
                cbxDriverId.DisplayMember = "DriverName";
                cbxDriverId.ValueMember = "DriverId";
                cbxDriverId.DataSource = driverList;
                cbxDriverId.SelectedValue = driverList[driverList.Count - 1].DriverId;
            }
        }

        private void btnAddTempVehicle_Click(object sender, EventArgs e)
        {
            FrmVehicleAddOrUpdate vehicle = new FrmVehicleAddOrUpdate();
            vehicle.usersInfo = usersInfo;
            if (vehicle.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("IFBelongsto=false"));
                cbxVehicleId.DisplayMember = "VehicleNumber";
                cbxVehicleId.ValueMember = "VehicleId";
                cbxVehicleId.DataSource = vehicleList;
                cbxVehicleId.SelectedValue = vehicleList[vehicleList.Count - 1].VehicleId;
                List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type=临时"));
                cbxDriverId.DisplayMember = "DriverName";
                cbxDriverId.ValueMember = "DriverId";
                cbxDriverId.DataSource = driverList;
                cbxDriverId.SelectedValue = driverList[driverList.Count - 1].DriverId;
             
            }
        }
    }
}
