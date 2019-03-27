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
    public partial class FrmTransferTempInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.vehicledelivery vehicleDeliveryInfo = null;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public string strDeliveryId = "";
        public FrmTransferTempInfo()
        {
            InitializeComponent();
        }
        private void FrmTransferTempInfo_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvTempInfo.AutoGenerateColumns = false;
            if (strDeliveryId != "")
            {
                txtDeliveryId.Text = strDeliveryId;
                List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format ("DeliveryId='{0}'",strDeliveryId));
                dgvTempInfo.DataSource = null;
                dgvTempInfo.DataSource = tempList;
                if (dgvTempInfo.Rows.Count > 0)
                {
                    dgvTempInfo.Rows[0].Selected = false;
                }
            }
        }

        private void dgvTempInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvTempInfo.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                List<YueYePlat.Model.deliverycurtempinfo> tempList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("Id='{0}'", str));
                YueYePlat.Model.deliverycurtempinfo tempInfo = tempList.Find(v => v.Id.Equals(int.Parse (str)));
                int cid = e.ColumnIndex;
                FrmTransTempAdd temp = new FrmTransTempAdd();
                temp.usersInfo = usersInfo;
                temp.tempInfo = tempInfo;
                if (temp.ShowDialog() == DialogResult.OK)
                {
                    List<YueYePlat.Model.deliverycurtempinfo> tempsList = new YueYePlat.BLL.deliverycurtempinfo().GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
                    dgvTempInfo.DataSource = null;
                    dgvTempInfo.DataSource = tempsList;
                    if (dgvTempInfo.Rows.Count > 0)
                    {
                        dgvTempInfo.Rows[0].Selected = false;
                    }
                }
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtDeliveryId.Text != "")
            {
                
            }
        }
    }
}
