using Qiniu.IO;
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
    public partial class FrmRefuelingInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.refueling refueling=null;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        string refuelImageName;
        string refuelImagePath;
        string refuelUrl="";
        string strqiniu = "http://p94gz7ls5.bkt.clouddn.com";
        public FrmRefuelingInfo()
        {
            InitializeComponent();
        }        
        private void FrmRefuelingInfo_Load(object sender, EventArgs e)
        {
            InitComponent();         
            cbxVerfiel.SelectedValue = "";
            cbxDriverId.SelectedValue = "";
           
            if (refueling != null)
            {
                txtDeliveryId.Text = refueling.DeliveryId;
                cbxVehicleId.SelectedValue = refueling.VehicleID;
                cbxDriverId.SelectedValue = refueling.DriverId;
                dtRefuelTime.Text = refueling.RefuelTime.ToString () ;
                txtMoney.Text = refueling.Money.ToString();
                txtPetrolPostiton.Text = refueling.PetrolStation;
                txtQuantity.Text = refueling.Quantity.ToString ();
                refuelUrl = refueling.InvoicePhoto;           
                //lblRefuelingPhoto.Text = refueling.InvoicePhoto;
                cbxVerfiel.SelectedValue = refueling.VerfielId;
                string url = refuelUrl;
                QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                QiniuInfo.Bucket = "yueye";
                Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
                int expireInSeconds = 3600;
                string accUrl = "";
                if (!url.Contains(strqiniu))
                {
                    accUrl = strqiniu + "/" + url;

                }
                else
                {
                    accUrl = DownloadManager.CreateSignedUrl(mac, url, expireInSeconds);
                }
                //图片异步加载完成后的处理事件 
                picRefueling.LoadCompleted += new AsyncCompletedEventHandler(picRefueling_LoadCompleted);
                //图片加载时，显示等待光标 
                picRefueling.UseWaitCursor = true;
                //采用异步加载方式 
                picRefueling.WaitOnLoad = false;
                //开始异步加载，图片的地址，请自行更换
                picRefueling.LoadAsync(accUrl);
            }
        }

        private void picRefueling_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            picRefueling.UseWaitCursor = false;
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
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.usersinfo> userList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format ("CompanyId='{0}' and  UserState= 1 and UserTypeId not like '%{1}%' ",usersInfo.CompanyId , "APP"));
            cbxVerfiel.DisplayMember = "UserName";
            cbxVerfiel.ValueMember = "UserId";
            cbxVerfiel.DataSource = userList;
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            //if (lblRefuelingPhoto.Text != "")
            //{
            //    FrmRetrunOrder photo = new FrmRetrunOrder();
            //    photo.usersInfo = usersInfo;
            //    photo.Text = "车辆加油照片";
            //    photo.strReturnOrderUrl = lblRefuelingPhoto.Text;
            //    photo.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("还未上传车辆加油照片！");
            //}
          
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    refuelImageName = Path.GetFileName(dialog.FileName);
            //    try
            //    {
            //        refuelImagePath = Path.GetDirectoryName(dialog.FileName) + "\\" + refuelImageName;
            //    }
            //    catch (Exception ex)
            //    {
            //        refuelImagePath = "";
            //    }
            //}
            //if (refuelImagePath != null)
            //{
            //    QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
            //    QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
            //    QiniuInfo.Bucket = "yueye";
            //    //上传后的名称
            //    string saveKey = usersInfo.CompanyId + "/" + "VehicleRefuelingPhoto" + "/" + refuelImageName;
            //    //上传路径
            //    string localFile = refuelImagePath;
            //    QiniuManager.UploadFile(localFile, saveKey);
            //    MessageBox.Show("上传成功！");
            //    //lblRefuelingPhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            //}
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (refueling != null)
            {
                if (MessageBox.Show("请您仔细核实信息，无误后请点击“确定”！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (cbxVerfiel.SelectedValue != null)
                    {
                        refueling.VerfielId = cbxVerfiel.SelectedValue.ToString();
                        refueling.IfVerifyed = true;
                        if (new YueYePlat.BLL.refueling().Update(refueling))
                        {
                            MessageBox.Show("审核成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("您确定增加车辆加油记录信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.refueling refuel = new YueYePlat.Model.refueling();
                    refuel.DeliveryId = txtDeliveryId.Text;
                    try
                    {
                        refuel.Quantity = decimal.Parse(txtQuantity.Text);
                    }
                    catch (Exception ex)
                    {
                        refuel.Quantity = 0;
                        txtQuantity.Text = 0 + "";
                    }                  
                    try
                    {
                        refuel.Money = decimal.Parse(txtMoney.Text);
                    }
                    catch (Exception ex)
                    {
                        refuel.Money = 0;
                        txtMoney.Text = 0 + "";
                    }
                    refuel.PetrolStation = txtPetrolPostiton.Text;
                    refuel.RefuelTime = dtRefuelTime.Value;
                    refuel.VehicleID = cbxVehicleId.SelectedValue.ToString();
                    refuel.DriverId = cbxDriverId.SelectedValue.ToString();                   
                    if (new YueYePlat.BLL.refueling().Add(refuel))
                    {
                        MessageBox.Show("增加成功！");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picRefueling_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (refuelUrl != "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = refuelUrl;
                returnOrder.strReturnOrderName = "加油费发票";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传加油费发票！");
            }
        }

        private void picRefueling_Click(object sender, EventArgs e)
        {

        }
    }
}
