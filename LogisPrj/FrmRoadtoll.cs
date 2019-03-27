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
    public partial class FrmRoadtoll : Form
    {
        YueYePlat.BLL.roadtoll  bll;
        List<YueYePlat.Model.roadtoll> roadtollList;
        public YueYePlat.Model.usersinfo usersInfo;
        YueYePlat.Model.roadtoll roadtoll;
        private int roadtollId = -1;
        static FrmRoadtoll instance;
        public string tabPageTitle = "";
        string roadtollImageName="";
        string roadtollImagePath="";
        public string strDeliveryId = "";
        public FrmRoadtoll()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.roadtoll();
        }
        public static FrmRoadtoll getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmRoadtoll();
            }
            return instance;
        }
        private void FrmRoadtoll_Load(object sender, EventArgs e)
        {
            cbxDriverId.SelectedValue = "";
            
            monStart.Visible = false;
            monEnd.Visible = false;
            cbxDriverId.SelectedValue = "";
            InitComponent();
            dgvRoadtoll.AutoGenerateColumns = false;
            if (strDeliveryId != "")
            {
                roadtollList = bll.GetModelList(String.Format ("DeliveryId='{0}'",strDeliveryId));
                if (roadtollList.Count > 0)
                {
                    for (int i = 0; i < roadtollList.Count; i++)
                    {
                        roadtollList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("DriverId='{0}'",roadtollList[i].DriverId))[0].DriverName;
                    }
                    dgvRoadtoll.DataSource = null;
                    dgvRoadtoll.DataSource = roadtollList;
                    if (dgvRoadtoll.Rows.Count > 0)
                    {
                        dgvRoadtoll.Rows[0].Selected = false;
                    }
                }
            }
            else
            {

                roadtollList = bll.GetModelList("");
                for (int i = 0; i < roadtollList.Count; i++)
                {
                    roadtollList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", roadtollList[i].DriverId))[0].DriverName;
                }
                dgvRoadtoll.DataSource = null;
                dgvRoadtoll.DataSource = roadtollList;
                if (dgvRoadtoll.Rows.Count > 0)
                {
                    dgvRoadtoll.Rows[0].Selected = false;
                }
            }            
        }

        private void InitComponent()
        {
            List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format ("Type != '离职'"));
            cbxDriverId.DisplayMember = "DriverName";
            cbxDriverId.ValueMember = "DriverId";
            cbxDriverId.DataSource = driverList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要增加过路费用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmRoadtollInfo roadtoll = new FrmRoadtollInfo();
                roadtoll.usersInfo = usersInfo;
                if (roadtoll.ShowDialog() == DialogResult.OK)
                {
                    roadtollList = bll.GetModelList("");
                    dgvRoadtoll.DataSource = null;
                    dgvRoadtoll.DataSource = roadtollList;
                    if (dgvRoadtoll.Rows.Count > 0)
                    {
                        dgvRoadtoll.Rows[0].Selected = false;
                    }
                }            
              
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(roadtollId!=-1)
            {
                if (MessageBox.Show("您确定要修改过路费用记录？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //roadtoll.DeliveryId = txtDeliveryId.Text;
                    //roadtoll.OrderNumber = int.Parse(txtOrderNumber.Text);
                    //roadtoll.TollStation = txtTollStation.Text;
                    //roadtoll.Money = double.Parse(txtMoney.Text);
                    //roadtoll.TollTime = dTTollTime.Value;
                    //roadtoll.InvoicePhoto = lblInvoicePhoto.Text;
                    //if (new YueYePlat.BLL.roadtoll().Update (roadtoll))
                    //{
                    //    MessageBox.Show("修改成功！");
                    //    roadtollList = bll.GetModelList("");
                    //    dgvRoadtoll.DataSource = roadtollList;
                    //}
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (roadtollId != -1)
            {
                if (MessageBox.Show("您确定要修改该车辆过路费用？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.roadtoll().Delete(roadtollId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                        roadtollList = bll.GetModelList("");
                        dgvRoadtoll.DataSource = roadtollList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择删除的过路费用!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void dgvRoadtoll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    roadtollId = int.Parse(dgvRoadtoll .Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    roadtollId = -1;
                }
            }
            YueYePlat.Model.roadtoll info = roadtollList.Find(v => v.Id.Equals(roadtollId));
            roadtoll = info;
            //if (roadtoll != null)
            //{
            //    txtDeliveryId.Text  = roadtoll.DeliveryId;
            //    txtOrderNumber.Text= roadtoll.OrderNumber.ToString ();
            //    txtTollStation.Text = roadtoll.TollStation;
            //    txtMoney.Text = roadtoll.Money.ToString ();
            //    dTTollTime.Text = roadtoll.TollTime.ToString ();
            //    lblInvoicePhoto.Text = roadtoll.InvoicePhoto;
            //}
        }

        private void txtDeliveryId_Leave(object sender, EventArgs e)
        {
            //List<YueYePlat.Model.roadtoll> roadtoll = new YueYePlat.BLL.roadtoll().GetModelList(String.Format ("DeliveryId='{0}' order by OrderNumber desc",txtDeliveryId.Text ));
            //if (roadtoll.Count > 0)
            //{
            //    string cid = roadtoll[roadtoll.Count - 1].OrderNumber.ToString ();
            //    int count = int.Parse(cid) + 1;
            //    txtOrderNumber.Text = count.ToString ();
            //}
            //else
            //{
            //    txtOrderNumber.Text = "01";
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //FrmRetrunOrder photo = new FrmRetrunOrder();
            //photo.usersInfo = usersInfo;
            //photo.Text = "车辆加油照片";
            //photo.strReturnOrderUrl = lblInvoicePhoto.Text;
            //photo.ShowDialog();
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
            //QiniuInfo.AccessKey = "jUFRoabDbOZY4Y9_D10RW__Yp3ZAdoOG66zA22Or";
            //QiniuInfo.SecretKey = "d3EnzfwNWG-BWTAFt6cWdqXMZbMzq77PH3Pz1x2R";
            //QiniuInfo.Bucket = "yueye";
            ////上传后的名称
            //string saveKey = usersInfo.CompanyId + "/" + "VehicleRefuelingPhoto" + "/" + roadtollImageName;
            ////上传路径
            //string localFile = roadtollImagePath;
            //QiniuManager.UploadFile(localFile, saveKey);
            //MessageBox.Show("上传成功！");
            //lblInvoicePhoto.Text = "http://p94gz7ls5.bkt.clouddn.com/" + saveKey;
        }

        private void dgvRoadtoll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvRoadtoll.Rows[e.RowIndex].Cells["colId"].Value.ToString();
                List<YueYePlat.Model.roadtoll> roadtoll = new YueYePlat.BLL.roadtoll().GetModelList(String.Format("ID='{0}'", str));
                YueYePlat.Model.roadtoll roadtollInfo = roadtoll.Find(v => v.Id.ToString().Equals(str));
                FrmRoadtollInfo info = new FrmRoadtollInfo();
                info.usersInfo = usersInfo;
                info.roadtoll = roadtollInfo;
                if (info.ShowDialog() == DialogResult.OK)
                {
                    List<YueYePlat.Model.roadtoll> roadtollList = new YueYePlat.BLL.roadtoll().GetModelList("");
                    dgvRoadtoll.DataSource = null;
                    dgvRoadtoll.DataSource = roadtollList;
                    if (dgvRoadtoll.Rows.Count > 0)
                    {
                        dgvRoadtoll.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            strWhere = "1=1";
            if (txtStart.Text.Trim()!="")
            {
                // strWhere+= String.Format (" and DeliveryId like '%{0}%'",dTRefueling.Value.ToString("yyMMdd").Trim());

                if (txtEnd.Text .Trim ()!="")
                {
                    strWhere += String.Format(" and  TollTime > '{0}' and TollTime <'{1}'", txtStart.Text, txtEnd.Text);
                }
                else
                {
                    strWhere += String.Format(" and TollTime > '{0}' ", txtEnd.Text);
                }
            }        
            if (cbxDriverId.SelectedValue != null && cbxDriverId.SelectedValue.ToString ()!="")
            {
                strWhere += String.Format(" and DriverId='{0}'", cbxDriverId.SelectedValue.ToString());
            }
            if (txtDeliveryId.Text.Trim() != "")
            {
                strWhere += String.Format(" and  DeliveryId='{0}'", txtDeliveryId.Text.Trim());
            }
            if (txtDeliveryId.Text.Trim() != "" || txtStart.Text.Trim() != "" || cbxDriverId.SelectedValue != null)
            {
                List<YueYePlat.Model.roadtoll> roadtollList = new YueYePlat.BLL.roadtoll().GetModelList(strWhere);
                if (roadtollList.Count > 0)
                {
                    for (int i = 0; i < roadtollList.Count; i++)
                    {
                        roadtollList[i].DriverName = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", roadtollList[i].DriverId))[0].DriverName;
                    }
                    dgvRoadtoll.DataSource = null;
                    dgvRoadtoll.DataSource = roadtollList;
                    if (dgvRoadtoll.Rows.Count > 0)
                    {
                        dgvRoadtoll.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("没有对应的加油信息！");
                    dgvRoadtoll.DataSource = null;
                }
            }
        }

        private void txtDeliveryTimeStart_Click(object sender, EventArgs e)
        {
            monStart.Visible = true;
        }

        private void txtDeliveryTimeEnd_Click(object sender, EventArgs e)
        {
            monEnd.Visible = true;
        }

        private void txtDeliveryTimeStart_Leave(object sender, EventArgs e)
        {
            monStart.Visible = false;
        }

        private void monStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtStart.Text = monStart.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
            monStart.Visible = false;
        }

        private void monEnd_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtEnd.Text = monEnd.SelectionStart.ToString("yyyy-MM-dd 23:59:59");
            monEnd.Visible = false;
        }
    }
}
