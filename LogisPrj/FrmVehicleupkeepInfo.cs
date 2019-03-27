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
    public partial class FrmVehicleupkeepInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.vehicleupkeep vehiclekeep=null;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        string keepImageName;
        string keepImagePath;
        public FrmVehicleupkeepInfo()
        {
            InitializeComponent();
        }
        private void FrmVehicleupkeepInfo_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            lblKeepPhoto.Text = "";     
            List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleNumber";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleInfos;
            List<YueYePlat.Model.driverinfo> driverInfos = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxUpkeepMan.DisplayMember = "DriverName";
            cbxUpkeepMan.ValueMember = "DriverId";
            cbxUpkeepMan.DataSource = driverInfos;
            if (vehiclekeep != null)
            {
                cbxVehicleId.Text = vehiclekeep.VehicleId;
                cbxUpkeepMan.SelectedValue = vehiclekeep.UpkeepMan;
                dateUpkeepTime.Text = vehiclekeep.UpkeepTime.ToString();
                txtUpkeepLocation.Text = vehiclekeep.UpkeepLocation;
                txtUpkeepDescribe.Text = vehiclekeep.UpkeepDescribe;
                txtUpkeepMoneys.Text = vehiclekeep.UpkeepMoneys;
                txtKilometres.Text = vehiclekeep.Kilometres;
                lblKeepPhoto.Text = vehiclekeep.InvoicePhoto;
            }
           
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                keepImageName = Path.GetFileName(dialog.FileName);
                try
                {
                    keepImagePath = Path.GetDirectoryName(dialog.FileName) + "\\" + keepImageName;
                }
                catch (Exception ex)
                {
                    keepImagePath = "";
                }
            }
            if (keepImagePath != null)
            {

                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                //上传后的名称
                string saveKey = usersInfo.CompanyId + "/" + "VehilceupkeepPhoto" + "/" + keepImageName;
                //上传路径
                string localFile = keepImagePath;
                QiniuManager.UploadFile(localFile, saveKey);
                MessageBox.Show("上传成功！");
                lblKeepPhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (lblKeepPhoto.Text != "")
            {
                FrmRetrunOrder photo = new FrmRetrunOrder();
                photo.usersInfo = usersInfo;
                photo.Text = "车辆保养照片";
                photo.strReturnOrderUrl = lblKeepPhoto.Text;
                photo.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先上传车辆保养照片！");
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxUpkeepMan.SelectedValue != null && txtUpkeepMoneys.Text != "" && lblKeepPhoto.Text != ""&& txtUpkeepLocation.Text .Trim()!="")
            {

                if (vehiclekeep != null)
                {
                    if (MessageBox.Show("您确定要修改该车辆保养记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {                      
                        vehiclekeep.VehicleId = cbxVehicleId.SelectedValue.ToString();
                        vehiclekeep.UpkeepMan = cbxUpkeepMan.SelectedValue.ToString();
                        vehiclekeep.UpkeepTime = dateUpkeepTime.Value;
                        vehiclekeep.UpkeepLocation = txtUpkeepLocation.Text;
                        vehiclekeep.UpkeepDescribe = txtUpkeepDescribe.Text;
                        vehiclekeep.UpkeepMoneys = txtUpkeepMoneys.Text;
                        vehiclekeep.Kilometres = txtKilometres.Text;
                        vehiclekeep.InvoicePhoto = lblKeepPhoto.Text;
                        if (new YueYePlat.BLL.vehicleupkeep().Update(vehiclekeep))
                        {
                            MessageBox.Show("修改成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("您确定要新增该车辆保养记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        YueYePlat.Model.vehicleupkeep vehiclekeep = new YueYePlat.Model.vehicleupkeep();
                        vehiclekeep.VehicleId = cbxVehicleId.SelectedValue.ToString();
                        vehiclekeep.UpkeepMan = cbxUpkeepMan.SelectedValue.ToString();
                        vehiclekeep.UpkeepTime = dateUpkeepTime.Value;
                        vehiclekeep.UpkeepLocation = txtUpkeepLocation.Text;
                        vehiclekeep.UpkeepDescribe = txtUpkeepDescribe.Text;
                        vehiclekeep.UpkeepMoneys = txtUpkeepMoneys.Text;
                        vehiclekeep.Kilometres = txtKilometres.Text;
                        vehiclekeep.InvoicePhoto = lblKeepPhoto.Text;

                        if (new YueYePlat.BLL.vehicleupkeep().Add(vehiclekeep))
                        {
                            MessageBox.Show("增加成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }              
            }
            else
            {
                if (cbxUpkeepMan.SelectedValue == null || cbxUpkeepMan.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("请选择保养人！");
                }
                else if (txtUpkeepMoneys.Text.Trim() == "")
                {
                    MessageBox.Show("请输入保养金额！");
                }
                else if (txtUpkeepLocation.Text.Trim() == "")
                {
                    MessageBox.Show("请输入保养地点！");
                }                
            }          
        }
    }
}
