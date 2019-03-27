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
    public partial class FrmRoadtollInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strDeliveryId="";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        string roadtollImageName="";
        string roadtollImagePath="";
        string roadtollUrl;
        string strqiniu = "http://p94gz7ls5.bkt.clouddn.com";
        public YueYePlat.Model.roadtoll roadtoll=null;

        public FrmRoadtollInfo()
        {
            InitializeComponent();
        }

        private void FrmRoadtollInfo_Load(object sender, EventArgs e)
        {          
            if (roadtoll != null)
            {
                txtDeliveryId.Text = roadtoll.DeliveryId;
                txtOrderNumber.Text = roadtoll.OrderNumber.ToString();
                txtTollStation.Text = roadtoll.TollStation;
                txtMoney.Text = roadtoll.Money.ToString();
                dTTollTime.Text = roadtoll.TollTime.ToString();
                roadtollUrl = roadtoll.InvoicePhoto;
                string url = roadtollUrl;
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
                picRoadtall.LoadCompleted += new AsyncCompletedEventHandler(picRoadtall_LoadCompleted);
                //图片加载时，显示等待光标 
                picRoadtall.UseWaitCursor = true;
                //采用异步加载方式 
                picRoadtall.WaitOnLoad = false;
                //开始异步加载，图片的地址，请自行更换
                picRoadtall.LoadAsync(accUrl);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    roadtollImageName = Path.GetFileName(dialog.FileName);
            //    try
            //    {
            //        roadtollImagePath = Path.GetDirectoryName(dialog.FileName) + "\\" + roadtollImageName;
            //    }
            //    catch (Exception ex)
            //    {
            //        roadtollImagePath = "";
            //    }
            //}
            //if (roadtollImagePath != null)
            //{
            //    QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
            //    QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
            //    QiniuInfo.Bucket = "yueye";
            //    //上传后的名称
            //    string saveKey = usersInfo.CompanyId + "/" + "VehicleRefuelingPhoto" + "/" + roadtollImageName;
            //    //上传路径
            //    string localFile = roadtollImagePath;
            //    QiniuManager.UploadFile(localFile, saveKey);
            //    MessageBox.Show("上传成功！");
            //    lblInvoicePhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //if (lblInvoicePhoto.Text != "")
            //{
            //    FrmRetrunOrder photo = new FrmRetrunOrder();
            //    photo.usersInfo = usersInfo;
            //    photo.Text = "过路费用照片";
            //    photo.strReturnOrderUrl = lblInvoicePhoto.Text;
            //    photo.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("未上传过路费用照片！");
            //}
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (roadtoll != null)
            {

            }
            else
            {
                if (MessageBox.Show("您确定要增加过路费用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.roadtoll roadtoll = new YueYePlat.Model.roadtoll();
                    roadtoll.DeliveryId = txtDeliveryId.Text;
                    roadtoll.OrderNumber = int.Parse(txtOrderNumber.Text);
                    roadtoll.TollStation = txtTollStation.Text;
                    try
                    {
                        roadtoll.Money = double.Parse(txtMoney.Text);
                    }
                    catch
                    {
                        roadtoll.Money = 0;
                        txtMoney.Text = 0 + "";
                    }

                    roadtoll.TollTime = dTTollTime.Value;                   
                    if (new YueYePlat.BLL.roadtoll().Add(roadtoll))
                    {
                        MessageBox.Show("过路费用增加成功！");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void txtDeliveryId_Leave(object sender, EventArgs e)
        {
            List<YueYePlat.Model.roadtoll> roadtoll = new YueYePlat.BLL.roadtoll().GetModelList(String.Format("DeliveryId='{0}' order by OrderNumber desc", txtDeliveryId.Text));
            if (roadtoll.Count > 0)
            {
                string cid = roadtoll[roadtoll.Count - 1].OrderNumber.ToString();
                int count = int.Parse(cid) + 1;
                txtOrderNumber.Text = count.ToString();
            }
            else
            {
                txtOrderNumber.Text = "01";
            }
        }

        private void picRoadtall_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            picRoadtall.UseWaitCursor = false;
        }

        private void picRoadtall_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (roadtollUrl != "")
            {
                FrmRetrunOrder returnOrder = new FrmRetrunOrder();
                returnOrder.usersInfo = usersInfo;
                returnOrder.strReturnOrderUrl = roadtollUrl;
                returnOrder.strReturnOrderName = "过路费发票";
                if (returnOrder.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("请先上传过路费发票！");
            }
        }
    }
}
