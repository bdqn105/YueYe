using Qiniu.Http;
using Qiniu.IO;
using Qiniu.IO.Model;
using Qiniu.RS;
using Qiniu.Util;
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
    public partial class FrmDriverAddOrUpdate : Form
    {
        public string type = "";
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.driverinfo driver = null;
        string driverImagePath;
        string driverImageName;
        public  string status;
        public string vehicleID = "";
        List<YueYePlat.Model.logiscompanyinfo> company;
        public FrmDriverAddOrUpdate()
        {
            InitializeComponent();
        }

        private void FrmDriverAddOrUpdate_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            company = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
            lblDriverImage.Text = "";
            if (driver != null)
            {
                if (status == "view")
                {
                    btnSave.Visible = false;
                }
                txtDriverName.Text = driver.DriverName;
                txtDriverLicense.Text = driver.DriverLicense;
                txtDriverLocation.Text = driver.DriverLocation;
                txtIdNumber.Text = driver.IdNumber;
                txtMobile.Text = driver.Mobile;
                //cbxCompanyId.SelectedValue  = driver.CompanyId;
                cbxDriverSex.Text = driver.DriverSex;
                cbxLicenseType.Text = driver.LicenseType;
                cbxType.Text = driver.Type;
                txtEmergencyContact.Text = driver.EmergencyContact;
                txtEmergencyMobile.Text = driver.EmergencyMobile;
                txtEmergencyRelations.Text = driver.EmergencyRelations;
                txtFamilyAddress.Text = driver.FamilyAddress;
                lblDriverImage.Text = driver.DriverPhoto;
            }
            else
            {
                cbxDriverSex.Text = "男";
                cbxType.Text = "正式";
                cbxLicenseType.Text = "C1";
            }
            if (type == "临时")
            {               
                cbxType.Text = "临时";
                cbxType.DropDownStyle = ComboBoxStyle.Simple;
            }
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDriverName.Text.Trim() != "" && txtMobile.Text.Trim() != "" && txtDriverLicense.Text.Trim() != "")
            {
                if (driver != null)
                {
                    //driver.DriverId = GenerateDriverID(usersInfo .CompanyId );
                    driver.DriverName = txtDriverName.Text;
                    driver.DriverLicense = txtDriverLicense.Text;
                    driver.DriverLocation = txtDriverLocation.Text;
                    driver.IdNumber = txtIdNumber.Text;
                    driver.Mobile = txtMobile.Text;
                    //driver.CompanyId = usersInfo .CompanyId ;
                    driver.DriverSex = cbxDriverSex.Text;
                    driver.LicenseType = cbxLicenseType.Text;
                    driver.Type = cbxType.Text;
                    driver.DriverPhoto = lblDriverImage.Text;
                    driver.EmergencyContact = txtEmergencyContact.Text;
                    driver.EmergencyMobile = txtEmergencyMobile.Text;
                    driver.EmergencyRelations = txtEmergencyRelations.Text;
                    driver.FamilyAddress = txtFamilyAddress.Text;
                    if (new YueYePlat.BLL.driverinfo().Update(driver))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    YueYePlat.Model.driverinfo driver = new YueYePlat.Model.driverinfo();
                    driver.DriverId = GenerateDriverID(usersInfo.CompanyId);
                    driver.DriverName = txtDriverName.Text;
                    driver.DriverLicense = txtDriverLicense.Text;
                    driver.DriverLocation = txtDriverLocation.Text;
                    driver.IdNumber = txtIdNumber.Text;
                    driver.Mobile = txtMobile.Text;
                    driver.CompanyId = usersInfo.CompanyId;
                    driver.DriverSex = cbxDriverSex.Text;
                    driver.LicenseType = cbxLicenseType.Text;
                    driver.DriverPhoto = lblDriverImage.Text;
                    driver.Type = cbxType.Text;
                    driver.EmergencyContact = txtEmergencyContact.Text;
                    driver.EmergencyMobile = txtEmergencyMobile.Text;
                    driver.EmergencyRelations = txtEmergencyRelations.Text;
                    driver.FamilyAddress = txtFamilyAddress.Text;
                    if (txtMobile.Text != "")
                    {
                        YueYePlat.Model.usersinfo info = new YueYePlat.Model.usersinfo();
                        info.UserId = driver.DriverId;
                        info.UserName = txtDriverName.Text;
                        info.UserTypeId = "DriverAPP";
                        info.UserState = 1;
                        info.UserSex = "男";
                        info.UserMobile = txtMobile.Text;
                        info.CompanyId = usersInfo.CompanyId;
                        info.UserPassword = Maticsoft.Common.StringPlus.GetMd5("888888");
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", txtMobile.Text));
                        if (usersList.Count > 0)
                        {
                            MessageBox.Show("该手机号码已被注册，请联系管理员！");
                        }
                        else
                        {
                            if (cbxType.Text == "临时" && vehicleID != "")
                            {
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
                                YueYePlat.Model.tempvehicleinfo tempvehicle = new YueYePlat.Model.tempvehicleinfo();
                                tempvehicle.DriverId = driver.DriverId;
                                tempvehicle.VehicleId = vehicleID;
                                tempvehicle.Time = DateTime.Now;
                                new YueYePlat.BLL.tempvehicleinfo().Add(tempvehicle);
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            }
                            new YueYePlat.BLL.usersinfo().Add(info);
                            YueYePlat.Model.logistouser logistouser = new YueYePlat.Model.logistouser();
                            logistouser.UserID = txtMobile.Text;
                            logistouser.LogisCompanyID = usersInfo.CompanyId;
                            logistouser.CurDate = DateTime.Now;
                            new YueYePlat.BLL.logistouser().Add(logistouser);
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
                            if (new YueYePlat.BLL.driverinfo().Add(driver))
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }                         
            }
            else
            {
                if (txtDriverName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入驾驶员姓名！");
                }
                else if (txtMobile.Text.Trim() == "")
                {
                    MessageBox.Show("请输入驾驶员联系方式！");
                }
                else if (txtDriverLicense.Text.Trim() == "")
                {
                    MessageBox.Show("请输入驾驶证编号！");
                }
            }
        }
        public string GenerateDriverID(string DriverID)
        {
            string str = DriverID;
            List<YueYePlat.Model.driverinfo > driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId like '{0}%' order by DriverId desc", str));
            if (driverList.Count == 0)
            {
                return str + "0001";
            }
            else
            {
                string dId = driverList[0].DriverId ;
                string didCount = "1" + dId.Substring(10);
                int count = int.Parse(didCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }       
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                driverImageName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    driverImagePath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + driverImageName;
                }
                catch (Exception ex)
                {
                    driverImagePath = "";
                }             
            }
            if (driverImagePath != null)
            {
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + "LicensePhoto" + "/" + txtDriverName.Text;
                //上传路径
                string localFile = driverImagePath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                lblDriverImage.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
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

        private void btnOpenLicense_Click(object sender, EventArgs e)
        {
            if (lblDriverImage.Text != "")
            {
                FrmRetrunOrder photo = new FrmRetrunOrder();
                photo.usersInfo = usersInfo;
                photo.Text = "驾驶证照片";
                photo.strReturnOrderUrl = lblDriverImage.Text;
                photo.ShowDialog();
            }
            else
            {
                MessageBox.Show("该驾驶员还没有上传驾驶证照片！");
            }           
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (txtMobile.Text.Trim() != "")
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                if (txtMobile.Text.Trim() != "")
                {
                    List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserMobile='{0}' or UserId='{0}'", txtMobile.Text));
                    if (usersList.Count > 0)
                    {
                        MessageBox.Show("该手机号已经注册！");
                        btnSave.Visible = false;
                    }
                    else
                    {
                        btnSave.Visible = true;
                    }
                }
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
            }
        }
    }
}
