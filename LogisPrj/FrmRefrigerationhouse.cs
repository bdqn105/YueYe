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
    public partial class FrmRefrigerationhouse : Form
    {
        YueYePlat.BLL.refrigerationhouseinfo bll;
        List<YueYePlat.Model.refrigerationhouseinfo> houseList;
        private int houseId = -1;
        YueYePlat.Model.refrigerationhouseinfo house = null;
        static FrmRefrigerationhouse  instance;
        public string tabPageTitle = "";
        public FrmRefrigerationhouse()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.refrigerationhouseinfo();
        }
        public static FrmRefrigerationhouse getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmRefrigerationhouse();
            }
            return instance;
        }
        private void FrmRefrigerationhouse_Load(object sender, EventArgs e)
        {
            houseList = bll.GetModelList("");
            dgvHouse.DataSource = houseList;
            List<YueYePlat.Model.companyinfo> companyInfos = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxCompanyId.DisplayMember = "CompanyName";
            cbxCompanyId.ValueMember = "CompanyID";
            cbxCompanyId.DataSource = companyInfos;
            List<YueYePlat.Model.companyinfo> house = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxHouseId.DisplayMember = "CompanyName";
            cbxHouseId.ValueMember = "CompanyID";
            cbxHouseId.DataSource = house;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxHouseId.Text != "" && txtHouseName.Text != "" && txtHouseLocation.Text != "")
            {
                if (MessageBox.Show("您确定要增加" + txtHouseName.Text + "冷库？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.refrigerationhouseinfo house = new YueYePlat.Model.refrigerationhouseinfo();
                    house.HouseId = GenerateHouseID(cbxHouseId.SelectedValue.ToString ());
                    house.CompanyId = cbxCompanyId.SelectedValue.ToString();
                    house.HouseName = txtHouseName.Text;
                    house.HouseLocation = txtHouseLocation.Text;
                    if (new YueYePlat.BLL.refrigerationhouseinfo().Add(house))
                    {
                        MessageBox.Show("增加成功");
                        houseList = bll.GetModelList("");
                        dgvHouse.DataSource = houseList;

                    }
                }
            }
            else
            {
                MessageBox.Show("请将冷库信息完善！");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (houseId != -1)
            {
                if (MessageBox.Show("您确定要修改"+house.HouseName+"冷库信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //house.HouseId = cbxHouseId.Text;
                    house.CompanyId = cbxCompanyId.SelectedValue.ToString();
                    house.HouseName = txtHouseName.Text;
                    house.HouseLocation = txtHouseLocation.Text;
                    if (new YueYePlat.BLL.refrigerationhouseinfo().Update(house))
                    {
                        MessageBox.Show("修改成功");
                        houseList = bll.GetModelList("");
                        dgvHouse.DataSource = houseList;
                    }
                }

            }
            else
            {
                MessageBox.Show("请选择冷库信息！");
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
                    
            if (houseId != -1)
            {
                if (MessageBox.Show("您确定要删除" + house.HouseName + "冷库吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.refrigerationhouseinfo().Delete(houseId );
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                        houseList = bll.GetModelList("");
                        dgvHouse.DataSource = houseList;
                    }
                }
            }
        }

        private void dgvHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    houseId = int.Parse(dgvHouse.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch(Exception ex)
                {
                    houseId = -1;
                }
            }
            YueYePlat.Model.refrigerationhouseinfo refrigerationhouse = houseList.Find(v=>v.Id .Equals (houseId));
            house = refrigerationhouse;
            if (house != null)
            {
                cbxHouseId.Text = house.HouseId;
                cbxCompanyId.SelectedValue = house.CompanyId;
                txtHouseName.Text = house.HouseName;
                txtHouseLocation.Text = house.HouseLocation;
            }
        }
        public string GenerateHouseID(string HouseID)
        {
            string str = HouseID;
            List<YueYePlat.Model.refrigerationhouseinfo > houseList = new YueYePlat.BLL.refrigerationhouseinfo().GetModelList(String.Format("HouseID like '{0}%' order by HouseID desc", str));
            if (houseList.Count == 0)
            {
                return str + "01";
            }
            else
            {
                string dId = houseList[0].HouseId;
                string didCount = "1" + dId.Substring(10);
                int count = int.Parse(didCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }
    }
}
