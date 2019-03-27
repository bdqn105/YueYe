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
    public partial class FrmVehicleAddOrUpdate : Form
    {
        public YueYePlat.Model.vehicleinfo vehicle ;
        public YueYePlat.Model.usersinfo usersInfo;  
        string licensePhotoName;
        string licensePhotoPath;
        string vehiclePhotoName;
        string vehiclePhotoPath;
        public FrmVehicleAddOrUpdate()
        {
            InitializeComponent();
        }          
        private void button1_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                vehicle.VehicleName = txtVehicleName.Text;
                vehicle.VehicleNumber = txtVehicleNumber.Text;
                vehicle.VehicleType = cbxVehicleTypeId.SelectedValue.ToString();                
                vehicle.IFBelongsto = chkIFBelongsto.Checked;
                if (chkIFBelongsto.Checked == true)
                {
                    vehicle.CompanyId = usersInfo.CompanyId;
                }
                else
                {
                    vehicle.CompanyId = cbxCompanyID.SelectedValue.ToString();
                }
                vehicle.LoadCapacity = txtLoadCapacity.Text;
                if (new YueYePlat.BLL.vehicleinfo().Update(vehicle))
                {
                    MessageBox.Show("修改成功!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (txtVehicleNumber.Text!=""&& cbxVehicleTypeId.SelectedValue!=null && cbxVehicleTypeId.SelectedValue.ToString()!="")
                {
                    YueYePlat.Model.vehicleinfo info = new YueYePlat.Model.vehicleinfo();
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    List<YueYePlat.Model.logiscompanyinfo> companyShortName = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyShortName[0].CompanyDBName);
                    //companyShortName [0].CompanyID = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", companyShortName[0].CompanyID))[0].CompanyShortName;
                    info.VehicleId = GenerateVehicleID(companyShortName[0].CompanyShortCode, cbxVehicleTypeId.SelectedValue.ToString());
                    info.VehicleName = txtVehicleName.Text;
                    info.VehicleNumber = txtVehicleNumber.Text;
                    info.VehicleType = cbxVehicleTypeId.SelectedValue.ToString();                                     
                    info.IFBelongsto = chkIFBelongsto.Checked;
                    if (chkIFBelongsto.Checked == true)
                    {
                        info.CompanyId = usersInfo.CompanyId;
                    }
                    else
                    {
                        info.CompanyId = cbxCompanyID.SelectedValue.ToString();                        
                    }
                    info.LoadCapacity = txtLoadCapacity.Text;
                    info.VehiclePhoto = lblVehiclePhoto.Text;
                    info.LicensePhoto = lblLicensePhoto.Text;
                    if (chkIFBelongsto.Checked == false)
                    {
                        if (MessageBox.Show("是否需要增加临时驾驶员信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            FrmDriverAddOrUpdate driver = new FrmDriverAddOrUpdate();
                            driver.type = "临时";
                            driver.usersInfo = usersInfo;
                            driver.vehicleID = info.VehicleId;
                            if (driver.ShowDialog() == DialogResult.OK)
                            {
                                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleNumber='{0}'", txtVehicleNumber.Text));
                                if (vehicleList.Count == 0)
                                {
                                    if (new YueYePlat.BLL.vehicleinfo().Add(info))
                                    {                                     
                                        MessageBox.Show("车辆增加成功！");
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该车辆已经存在！");
                                }
                            }
                        }
                        else
                        {
                            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleNumber='{0}'", txtVehicleNumber.Text));
                            if (vehicleList.Count == 0)
                            {
                                if (new YueYePlat.BLL.vehicleinfo().Add(info))
                                {
                                    MessageBox.Show("车辆增加成功！");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("该车辆已经存在！");
                            }
                        }

                    }
                    else
                    {
                        List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleNumber='{0}'", txtVehicleNumber.Text));
                        if (vehicleList.Count == 0)
                        {
                            if (new YueYePlat.BLL.vehicleinfo().Add(info))
                            {
                                MessageBox.Show("数据插入成功！");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("该车辆已经存在！");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请将车牌号、类型等信息完善！");
                }
            }
        }

        private void FrmVehicleAddOrUpdate_Load(object sender, EventArgs e)
        {           
            List<YueYePlat.Model.vehicletype> vehicletypeInfos = new YueYePlat.BLL.vehicletype().GetModelList("");
            cbxVehicleTypeId.DisplayMember = "VehicleTypeName";
            cbxVehicleTypeId.ValueMember = "VehicleTypeId";
            cbxVehicleTypeId.DataSource = vehicletypeInfos;
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxCompanyID.ValueMember = "CompanyID";
            cbxCompanyID.DisplayMember = "CompanyName";
            cbxCompanyID.DataSource = companyList;
            cbxCompanyID.SelectedValue = usersInfo.CompanyId;            
            if (vehicle != null)
            {                
                txtVehicleName.Text = vehicle.VehicleName;
                txtVehicleNumber.Text = vehicle.VehicleNumber;
                cbxVehicleTypeId.SelectedValue  = vehicle.VehicleType;
                chkIFBelongsto .Checked = vehicle.IFBelongsto;                
                txtLoadCapacity.Text  = vehicle.LoadCapacity;                    
            }
            lblLicensePhoto.Text = "";
            lblVehiclePhoto.Text = "";       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string GenerateVehicleID(string companyID,string vehicleTypeID)
        {              
            string str = companyID + vehicleTypeID;
            List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format("VehicleId like '{0}%' order by VehicleId desc", str));
            if (vehicleList.Count == 0)
            {
                return str + "0001";
            }
            else
            {
                string cId = vehicleList[0].VehicleId;
                string cidCount = "1" + cId.Substring(cId.Length -4);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

        private void btnAddVehilceType_Click(object sender, EventArgs e)
        {
            FrmVehicleType type = new FrmVehicleType();
            if (type.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.vehicletype> vehicletypeInfos = new YueYePlat.BLL.vehicletype().GetModelList("");
                cbxVehicleTypeId.DisplayMember = "VehicleTypeName";
                cbxVehicleTypeId.ValueMember = "VehicleTypeId";
                cbxVehicleTypeId.DataSource = vehicletypeInfos;
            }
        }

        private void btnLoadLicense_Click(object sender, EventArgs e)
        {
            if (lblLicensePhoto.Text != "")
            {
                FrmRetrunOrder photo = new FrmRetrunOrder();
                photo.usersInfo = usersInfo;
                photo.Text = "驾证照片";
                photo.strReturnOrderUrl = lblLicensePhoto.Text;
                photo.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先上传驾证照片！");
            }
            
        }

        private void btnLoadVehiclePhoto_Click(object sender, EventArgs e)
        {
            if (lblVehiclePhoto.Text != "")
            {
                FrmRetrunOrder photo = new FrmRetrunOrder();
                photo.usersInfo = usersInfo;
                photo.Text = "车辆照片";
                photo.strReturnOrderUrl = lblVehiclePhoto.Text;
                photo.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先上传车辆照片！");
            }
        }

        private void btnUploadLicense_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                licensePhotoName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    licensePhotoPath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + licensePhotoName;
                }
                catch (Exception ex)
                {
                    licensePhotoPath = "";
                }

            }
            if (licensePhotoPath != null)
            {
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                // Settings.UrlPrefix = "https://portal.qiniu.com/user/key"; 

                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + "LicensePhoto" + "/" + licensePhotoName;
                //上传路径
                string localFile = licensePhotoPath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                lblLicensePhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            }
          
        }

        private void btnUploadVehicle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vehiclePhotoName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    vehiclePhotoPath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + vehiclePhotoName;
                }
                catch (Exception ex)
                {
                    vehiclePhotoPath = "";
                }                
            }
            if (vehiclePhotoPath != null)
            {
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + "VehiclePhoto" + "/" + vehiclePhotoName;
                //上传路径
                string localFile = vehiclePhotoPath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                lblVehiclePhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            }
            
        }

        private void cbxVehicleTypeId_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtVehicleNumber.Text == "")
            {
                MessageBox.Show("请输入车牌号！");
            }
        }

        private void txtVehicleNumber_Leave(object sender, EventArgs e)
        {
            if (txtVehicleNumber.Text != "")
            {
                List<YueYePlat.Model.vehicleinfo> vehicleList = new YueYePlat.BLL.vehicleinfo().GetModelList(String.Format ("VehicleNumber='{0}'",txtVehicleNumber.Text));
                if (vehicleList.Count > 0)
                {
                    MessageBox.Show("该车牌号已经存在！");
                }
                txtVehicleName.Text = txtVehicleNumber.Text;
            }
        }

        private void chkIFBelongsto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIFBelongsto.Checked == true)
            {
                lblBelong.Visible = false;
                cbxCompanyID.Visible = false;
            }
            else
            {
                lblBelong.Visible = true;
                cbxCompanyID.Visible = true;
            }
        }
    }
}
