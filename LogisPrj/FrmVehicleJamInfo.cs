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
    public partial class FrmVehicleJamInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strDeliveryId;
        public YueYePlat.Model.vehiclejam jamInfo;
        string jamImageName;
        string jamImagePath;
        string strqiniu = "http://p94gz7ls5.bkt.clouddn.com";
        string jamUrl="";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmVehicleJamInfo()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //if (lblJamPhoto.Text != "")
            //{
            //    FrmRetrunOrder photo = new FrmRetrunOrder();
            //    photo.usersInfo = usersInfo;
            //    photo.Text = "车辆堵车照片";
            //    photo.strReturnOrderUrl = lblJamPhoto.Text;
            //    photo.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("请先上传堵车照片！");
            //}
            
        }

        private void FrmVehicleJamInfo_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            if (jamInfo != null)
            {
                txtDeliveryId.Text = jamInfo.DeliverId;
                txtJamLocation.Text = jamInfo.JamLocation;
                dtJamTime.Value = DateTime.Parse(jamInfo.JamTime.ToString ());
                if (jamInfo.JamUrl != null && jamInfo.JamUrl != "")
                {
                    jamUrl = jamInfo.JamUrl;
                    QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
                    QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
                    QiniuInfo.Bucket = "yueye";
                    Mac mac = new Mac(QiniuInfo.AccessKey, QiniuInfo.SecretKey);
                    int expireInSeconds = 3600;
                    string accUrl = "";
                    if (!jamUrl.Contains(strqiniu))
                    {
                        accUrl = strqiniu + "/" + jamUrl;

                    }
                    else
                    {
                        accUrl = DownloadManager.CreateSignedUrl(mac, jamUrl, expireInSeconds);
                    }
                    //图片异步加载完成后的处理事件 
                    pictureBox1.LoadCompleted += new AsyncCompletedEventHandler(pictureBox1_LoadCompleted);
                    //图片加载时，显示等待光标 
                    pictureBox1.UseWaitCursor = true;
                    //采用异步加载方式 
                    pictureBox1.WaitOnLoad = false;
                    //开始异步加载，图片的地址，请自行更换
                    pictureBox1.LoadAsync(accUrl);
                }
            }           
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    jamImageName = Path.GetFileName(dialog.FileName);
            //    try
            //    {
            //        jamImagePath = Path.GetDirectoryName(dialog.FileName) + "\\" + jamImageName;
            //    }
            //    catch (Exception ex)
            //    {
            //        jamImagePath = "";
            //    }
            //}
            //QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
            //QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
            //QiniuInfo.Bucket = "yueye";
            ////上传后的名称
            //string saveKey = usersInfo.CompanyId + "/" + "VehicleRefuelingPhoto" + "/" + jamImageName;
            ////上传路径
            //string localFile = jamImagePath;
            //QiniuManager.UploadFile(localFile, saveKey);
            //MessageBox.Show("上传成功！");
            //lblJamPhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.UseWaitCursor = false;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (jamUrl != "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = jamUrl;
                returnOrder.strReturnOrderName = "堵车照片";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传堵车照片！");
            }
        }
    }
}
