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
    public partial class FrmDriver : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        YueYePlat.BLL.driverinfo bll;
        private int driverId = -1;
        List<YueYePlat.Model.driverinfo> driverList;
        static FrmDriver instance;
        public string tabPageTitle = "";
        public FrmDriver()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.driverinfo();
        }
        public static FrmDriver  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmDriver ();
            }
            return instance;
        }

        private void FrmDriver_Load(object sender, EventArgs e)
        {
            try
            {
                cbxDriverType.Text = "全部";
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                dgvDriver.AutoGenerateColumns = false;
                driverList = bll.GetModelList("");                
                //for (int i = 0; i < driverList.Count; i++)
                //{
                //    driverList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyId='{0}'", driverList[i].CompanyId))[0].CompanyName;
                //}                

                dgvDriver.DataSource = null;
                dgvDriver.DataSource = driverList;
                if (dgvDriver.Rows.Count > 0)
                {
                    dgvDriver.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要新增驾驶员信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmDriverAddOrUpdate add = new LogisPrj.FrmDriverAddOrUpdate();
                add.usersInfo = usersInfo;
                add.Text = "增加驾驶员信息";
                if (add.ShowDialog() == DialogResult.OK)
                {
                    driverList = bll.GetModelList("");
                    //for (int i = 0; i < driverList.Count; i++)
                    //{
                    //    driverList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyId='{0}'", driverList[i].CompanyId))[0].CompanyName;
                    //}

                    dgvDriver.DataSource = null;
                    dgvDriver.DataSource = driverList;
                    if (dgvDriver.Rows.Count > 0)
                    {
                        dgvDriver.Rows[0].Selected = false;
                    }
                }
                driverId = -1;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (driverId != -1)
            {
                if (MessageBox.Show("您确定要修改该驾驶员信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FrmDriverAddOrUpdate modify = new FrmDriverAddOrUpdate();
                    modify.usersInfo = usersInfo;
                    YueYePlat.Model.driverinfo info = driverList.Find(v => v.Id.Equals(driverId));
                    modify.driver = info;
                    modify.Text = "修改驾驶员信息";
                    if (modify.ShowDialog() == DialogResult.OK)
                    {
                        driverList = bll.GetModelList("");
                        //for (int i = 0; i < driverList.Count; i++)
                        //{
                        //    driverList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyId='{0}'", driverList[i].CompanyId))[0].CompanyName;
                        //}

                        dgvDriver.DataSource = null;
                        dgvDriver.DataSource = driverList;
                        if (dgvDriver.Rows.Count > 0)
                        {
                            dgvDriver.Rows[0].Selected = false;
                        }
                    }
                    driverId = -1;
                }
            }
            else
            {
                MessageBox.Show("请选择驾驶员");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (driverId != -1)
            {
                if (MessageBox.Show("您确定要删除该驾驶员信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.driverinfo().Delete(driverId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("该驾驶员已成功删除！");
                        driverList = bll.GetModelList("");
                        //for (int i = 0; i < driverList.Count; i++)
                        //{
                        //    driverList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyId='{0}'", driverList[i].CompanyId))[0].CompanyName;
                        //}
                        dgvDriver.DataSource = null;
                        dgvDriver.DataSource = driverList;
                        if (dgvDriver.Rows.Count > 0)
                        {
                            dgvDriver.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的驾驶员信息！");
            }
        }

        private void dgvDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    driverId = int.Parse (dgvDriver.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    driverId = -1;
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

        private void dgvDriver_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvDriver.Rows[e.RowIndex].Cells["colDriverId"].Value.ToString();
                List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", str));
                YueYePlat.Model.driverinfo driverInfo = driverList.Find(v => v.DriverId.Equals(str));
                FrmDriverAddOrUpdate driver = new FrmDriverAddOrUpdate();
                driver.status = "view";
                driver.usersInfo = usersInfo;
                driver.driver = driverInfo;
                driver.Show();
            }
        }

        private void dgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvDriver.Rows[e.RowIndex].Cells["colDriverId"].Value.ToString();
                List<YueYePlat.Model.driverinfo> driverList = new YueYePlat.BLL.driverinfo().GetModelList(String.Format("DriverId='{0}'", str));
                YueYePlat.Model.driverinfo driverInfo = driverList.Find(v => v.DriverId.Equals(str));
                FrmDriverAddOrUpdate driver = new FrmDriverAddOrUpdate();
                driver.usersInfo = usersInfo;
                driver.driver = driverInfo;
                if (driver.ShowDialog() == DialogResult.OK)
                {
                    driverList = bll.GetModelList("");
                    dgvDriver.DataSource = null;
                    dgvDriver.DataSource = driverList;
                    if (dgvDriver.Rows.Count > 0)
                    {
                        dgvDriver.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbxDriverType.Text != "")
            {
                if (cbxDriverType.Text == "全部")
                {
                    driverList = bll.GetModelList("");
                }
                else
                {
                    driverList = bll.GetModelList(String.Format("Type='{0}'", cbxDriverType.Text));
                }
                dgvDriver.DataSource = null;
                dgvDriver.DataSource = driverList;
                if (dgvDriver.Rows.Count > 0)
                {
                    dgvDriver.Rows[0].Selected = false;
                }
            }
        }
    }
}
