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
    public partial class FrmDeviceUse : Form
    {
        YueYePlat.Model.logiscompanyinfo logiscompanyInfo;
        YueYePlat.BLL.deviceuseinfo bll;
        public YueYePlat.Model.usersinfo usersInfo;
        public string strVehicleId;
        List<YueYePlat.Model.deviceuseinfo> deviceuseList;
        private int deviceuseId = -1;
        YueYePlat.Model.deviceuseinfo deviceuse = null;
        static FrmDeviceUse instance;
        public string tabPageTitle = "";
        public FrmDeviceUse()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.deviceuseinfo();
        }
        public static FrmDeviceUse getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmDeviceUse();
            }
            return instance;
        }

        private void FrmDeviceUse_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
            logiscompanyInfo = logiscompanyList.Find(v => v.CompanyID.Equals(usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
            dgvDeviceUse.AutoGenerateColumns = false;
            InitComponent();            
            deviceuseList = bll.GetModelList("");
            for (int i = 0; i < deviceuseList.Count; i++)
            {
                deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
             }
            dgvDeviceUse.DataSource = null;
            dgvDeviceUse.DataSource = deviceuseList;
            if (dgvDeviceUse.Rows.Count > 0)
            {
                dgvDeviceUse.Rows[0].Selected = false;
            }       
            this.dateUnbindTime .Format = DateTimePickerFormat.Custom;
            this.dateUnbindTime.CustomFormat = " ";
            this.dateUnbindTime.Checked = false;
            if (strVehicleId != "" && strVehicleId!=null)
            {
                cbxVehicleId.SelectedValue = strVehicleId;
                cbxDeviceId.SelectedValue = "";
            }
            else
            {
                cbxDeviceId.SelectedValue = "";
                cbxVehicleId.SelectedValue = "";
            }
        }

        private void InitComponent()
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.terminaldeviceinfo> deviceInfos = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
            cbxDeviceId.DisplayMember = "DeviceName";
            cbxDeviceId.ValueMember = "DeviceId";
            cbxDeviceId.DataSource = deviceInfos;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
            List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleInfos;
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
            List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format ("DeviceId='{0}'",cbxDeviceId.SelectedValue));
            List<YueYePlat.Model.deviceuseinfo> vehicleList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", cbxVehicleId.SelectedValue));
            if (deviceuseList.Count == 0)
            {                
                if (vehicleList.Count == 0)
                {
                    if (MessageBox.Show("您确定要添加设备使用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        YueYePlat.Model.deviceuseinfo deviceuse = new YueYePlat.Model.deviceuseinfo();
                        deviceuse.DeviceId = cbxDeviceId.SelectedValue.ToString();
                        deviceuse.VehicleId = cbxVehicleId.SelectedValue.ToString();
                        deviceuse.IfBind = true;
                        deviceuse.BindTime = dateBindTime.Value;
                        deviceuse.UnbindTime = null;
                        deviceuse.Comment = txtComment.Text;
                        if (new YueYePlat.BLL.deviceuseinfo().Add(deviceuse))
                        {
                            MessageBox.Show("设备使用记录增加成功！");
                            deviceuseList = bll.GetModelList("");
                            for (int i = 0; i < deviceuseList.Count; i++)
                            {
                                deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                                else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                            }
                            dgvDeviceUse.DataSource = null;
                            dgvDeviceUse.DataSource = deviceuseList;
                            if (dgvDeviceUse.Rows.Count > 0)
                            {
                                dgvDeviceUse.Rows[0].Selected = false;
                            }
                        }
                    }
                }
                if (vehicleList.Count > 0)
                {
                    if (vehicleList[vehicleList.Count - 1].IfBind == true)
                    {
                        MessageBox.Show("该车辆已经绑定过其他设备，请先解除绑定！");
                    }
                    else
                    {
                        if (MessageBox.Show("您确定要添加设备使用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            YueYePlat.Model.deviceuseinfo deviceuse = new YueYePlat.Model.deviceuseinfo();
                            deviceuse.DeviceId = cbxDeviceId.SelectedValue.ToString();
                            deviceuse.VehicleId = cbxVehicleId.SelectedValue.ToString();
                            deviceuse.IfBind = true;
                            deviceuse.BindTime = dateBindTime.Value;
                            deviceuse.UnbindTime = null;
                            deviceuse.Comment = txtComment.Text;
                            if (new YueYePlat.BLL.deviceuseinfo().Add(deviceuse))
                            {
                                MessageBox.Show("设备使用记录增加成功！");
                                deviceuseList = bll.GetModelList("");
                                for (int i = 0; i < deviceuseList.Count; i++)
                                {
                                    deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                    deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                    if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                                    else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                                }
                                dgvDeviceUse.DataSource = null;
                                dgvDeviceUse.DataSource = deviceuseList;
                                if (dgvDeviceUse.Rows.Count > 0)
                                {
                                    dgvDeviceUse.Rows[0].Selected = false;
                                }
                                //for (int i = 0; i < deviceuseList.Count; i++)
                                //{
                                //    deviceuseList[i].VehicleId = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                //    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                //    deviceuseList[i].DeviceId = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                //    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                //}
                            }
                        }
                    }
                }
               
            }
            else
            {
                if (deviceuseList[deviceuseList.Count - 1].IfBind == true)
                {
                    MessageBox.Show("该设备已经被绑定，请先解除绑定！");
                }
                else
                {
                    if (vehicleList.Count == 0)
                    {
                        if (cbxDeviceId.SelectedValue.ToString() != "" && cbxVehicleId.SelectedValue.ToString() != "")
                        {
                            if (MessageBox.Show("您确定要添加设备使用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                YueYePlat.Model.deviceuseinfo deviceuse = new YueYePlat.Model.deviceuseinfo();
                                deviceuse.DeviceId = cbxDeviceId.SelectedValue.ToString();
                                deviceuse.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                deviceuse.IfBind = true;
                                deviceuse.BindTime = dateBindTime.Value;
                                deviceuse.UnbindTime = null;
                                deviceuse.Comment = txtComment.Text;
                                if (new YueYePlat.BLL.deviceuseinfo().Add(deviceuse))
                                {
                                    MessageBox.Show("添加成功！");
                                    deviceuseList = bll.GetModelList("");
                                    for (int i = 0; i < deviceuseList.Count; i++)
                                    {
                                        deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                        deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                        if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                                        else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                                    }
                                    dgvDeviceUse.DataSource = null;
                                    dgvDeviceUse.DataSource = deviceuseList;
                                    if (dgvDeviceUse.Rows.Count > 0)
                                    {
                                        dgvDeviceUse.Rows[0].Selected = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (vehicleList[vehicleList.Count - 1].IfBind == true)
                        {
                            MessageBox.Show("该车辆已经绑定过其他设备，请先解除绑定！");
                        }
                        else
                        {
                            if (cbxDeviceId.SelectedValue.ToString() != "" && cbxVehicleId.SelectedValue.ToString() != "")
                            {
                                if (MessageBox.Show("您确定要添加设备使用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    YueYePlat.Model.deviceuseinfo deviceuse = new YueYePlat.Model.deviceuseinfo();
                                    deviceuse.DeviceId = cbxDeviceId.SelectedValue.ToString();
                                    deviceuse.VehicleId = cbxVehicleId.SelectedValue.ToString();
                                    deviceuse.IfBind = true;
                                    deviceuse.BindTime = dateBindTime.Value;
                                    deviceuse.UnbindTime = null;
                                    deviceuse.Comment = txtComment.Text;
                                    if (new YueYePlat.BLL.deviceuseinfo().Add(deviceuse))
                                    {
                                        MessageBox.Show("添加成功！");
                                        deviceuseList = bll.GetModelList("");
                                        for (int i = 0; i < deviceuseList.Count; i++)
                                        {
                                            deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                            deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                            if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                                            else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                                        }
                                        dgvDeviceUse.DataSource = null;
                                        dgvDeviceUse.DataSource = deviceuseList;
                                        if (dgvDeviceUse.Rows.Count > 0)
                                        {
                                            dgvDeviceUse.Rows[0].Selected = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (deviceuseId != -1)
            {
                if (MessageBox.Show("您确定要修改该设备记录记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deviceuse.DeviceId = cbxDeviceId.SelectedValue.ToString();
                    deviceuse.VehicleId = cbxVehicleId.SelectedValue.ToString();                          
                    deviceuse.IfBind = false ;
                    deviceuse.UnbindTime = DateTime.Now;                                 
                    deviceuse.Comment = txtComment.Text;
                    if (dateUnbindTime.Value != null)
                    {
                        if (new YueYePlat.BLL.deviceuseinfo().Update(deviceuse))
                        {
                            MessageBox.Show("修改成功！");
                            deviceuseList = bll.GetModelList("");
                            
                            for (int i = 0; i < deviceuseList.Count; i++)
                            {
                                deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                                if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                                else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                            }
                            dgvDeviceUse.DataSource = null;
                            dgvDeviceUse.DataSource = deviceuseList;
                            if (dgvDeviceUse.Rows.Count > 0)
                            {
                                dgvDeviceUse.Rows[0].Selected = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请设置解绑时间！");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的设备使用记录！");
            }
        }

        private void dgvDeviceUse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                try
                {
                    deviceuseId = int.Parse(dgvDeviceUse.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    deviceuseId = -1;
                }

            }
            YueYePlat.Model.deviceuseinfo info = deviceuseList.Find(v => v.Id.Equals(deviceuseId));
            deviceuse = info;
            if (deviceuse != null)
            {
                cbxDeviceId.SelectedValue  = deviceuse.DeviceId;
                cbxVehicleId.SelectedValue = deviceuse.VehicleId;
                chkIfBind.Checked  = deviceuse.IfBind;
                if (deviceuse.IfBind == true)
                {
                    dateUnbindTime.CustomFormat = " ";
                }
                else
                {
                    dateUnbindTime.Text = deviceuse.UnbindTime.ToString();
                }
                dateBindTime.Text = deviceuse.BindTime.ToString();                         
                txtComment.Text = deviceuse.Comment;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxDeviceId.SelectedValue != null)
            {
                string strDeviceId = cbxDeviceId.SelectedValue.ToString();
                List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'", strDeviceId));
                for (int i = 0; i < deviceuseList.Count; i++)
                {
                    deviceuseList[i].VehicleNumber = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[i].VehicleId))[0].VehicleNumber;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    deviceuseList[i].DeviceName = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId='{0}'", deviceuseList[i].DeviceId))[0].DeviceName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                    if (deviceuseList[i].IfBind == true) deviceuseList[i].IfbindName = "是";
                    else if (deviceuseList[i].IfBind == false) deviceuseList[i].IfbindName = "否";
                }
                dgvDeviceUse.DataSource = null;
                dgvDeviceUse.DataSource = deviceuseList;
                if (dgvDeviceUse.Rows.Count > 0)
                {
                    dgvDeviceUse.Rows[0].Selected = false;
                }
            }           
        }

        private void dateUnbindTime_ValueChanged(object sender, EventArgs e)
        {
            this.dateUnbindTime.Format = DateTimePickerFormat.Custom;
            this.dateUnbindTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateBindTime_ValueChanged(object sender, EventArgs e)
        {            
            
        }

        private void cbxDeviceId_SelectedValueChanged(object sender, EventArgs e)
        {        
            if (cbxDeviceId.SelectedValue != null && cbxDeviceId.SelectedValue.ToString () !="")
            {
                string strDeviceId = cbxDeviceId.SelectedValue.ToString();
                List<YueYePlat.Model.deviceuseinfo> useList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("DeviceId='{0}'",strDeviceId));
                if (useList.Count > 0)
                {
                    if (useList[useList.Count - 1].IfBind == true)
                    {
                        List<YueYePlat.Model.vehicleinfo> vehicleInfo = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format ("VehicleId='{0}'",useList[useList.Count-1].VehicleId));
                        cbxVehicleId.ValueMember = "VehicleId";
                        cbxVehicleId.DisplayMember = "VehicleNumber";
                        cbxVehicleId.DataSource = vehicleInfo;
                       
                    }
                    else
                    {
                        //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo ().GetModelList("");
                        //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                        List<YueYePlat.Model.vehicleinfo> vehicleList = new List<YueYePlat.Model.vehicleinfo>();
                        for (int i = 0; i < vehicleInfos.Count; i++)
                        {
                            List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleInfos[i].VehicleId));
                            
                            if (deviceuseList.Count > 0)
                            {
                                if (deviceuseList[deviceuseList.Count - 1].IfBind == false)
                                {
                                    List<YueYePlat.Model.vehicleinfo> vehicleInfo = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", deviceuseList[deviceuseList.Count - 1].VehicleId));
                                    vehicleList.Add(vehicleInfo[0]);
                                    
                                }
                            }
                            else
                            {
                                List<YueYePlat.Model.vehicleinfo> vehicleInfo = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleInfos[i].VehicleId));
                                vehicleList.Add(vehicleInfo[0]);
                            }
                            
                        }
                        cbxVehicleId.DataSource = vehicleList;
                    }
                }
                else
                {
                 
                    List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");              
                    List<YueYePlat.Model.vehicleinfo > vehicleList = new List<YueYePlat.Model.vehicleinfo >();
                    for (int i = 0; i < vehicleInfos.Count; i++)
                    {
                        List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", vehicleInfos[i].VehicleId));                      
                        if (deviceuseList.Count > 0)
                        {
                            if (deviceuseList[deviceuseList.Count - 1].IfBind == false)
                            {
                                vehicleList.Add(vehicleInfos[i]);
                            }
                        }
                        else
                        {
                            vehicleList.Add(vehicleInfos[i]);
                        }

                    }
                    cbxVehicleId.DataSource = vehicleList;
                }
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void cbxVehicleId_Click(object sender, EventArgs e)
        {
            if (cbxDeviceId.SelectedValue == null)
            {
                MessageBox.Show("请先选择设备信息！");
            }
        }

        private void cbxVehicleId_SelectedValueChanged(object sender, EventArgs e)
        {
            List<YueYePlat.Model.deviceuseinfo> deviceuseList = new YueYePlat.BLL.deviceuseinfo().GetModelList(String.Format("VehicleId='{0}'", strVehicleId));
            if (deviceuseList.Count > 0)
            {
                if (deviceuseList[deviceuseList.Count - 1].IfBind == true)
                {
                    cbxDeviceId.SelectedValue = deviceuseList[deviceuseList.Count - 1].DeviceId;
                }
                else
                {
                    cbxDeviceId.SelectedValue = "";
                    MessageBox.Show("该车辆没有和终端设备进行绑定！");
                }
            }
        }
    }
}
