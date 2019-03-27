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
    public partial class FrmVehicleJam : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strDeliveryId = "";
        public List<YueYePlat.Model.vehiclejam> jamList;
        public FrmVehicleJam()
        {
            InitializeComponent();
        }

        private void FrmVehicleJam_Load(object sender, EventArgs e)
        {
            dgvJam.AutoGenerateColumns = false;
            if (strDeliveryId != "")
            {
                txtDeliveryId.Text = strDeliveryId;
                List<YueYePlat.Model.vehiclejam> jam = new YueYePlat.BLL.vehiclejam().GetModelList(String.Format("DeliverId='{0}'", strDeliveryId));
                dgvJam.DataSource = null;
                dgvJam.DataSource = jam;
                if (dgvJam.Rows.Count>0)
                {
                    dgvJam.Rows[0].Selected = false;
                }
            }
        }

        private void dgvJam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvJam.Rows[e.RowIndex].Cells["colJamId"].Value.ToString();
                List<YueYePlat.Model.vehiclejam> jamList = new YueYePlat.BLL.vehiclejam().GetModelList(String.Format("JamId='{0}'", str));
                YueYePlat.Model.vehiclejam jamInfo = jamList.Find(v => v.JamId.ToString().Equals(str));
                FrmVehicleJamInfo info = new FrmVehicleJamInfo();
                info.usersInfo = usersInfo;
                info.jamInfo = jamInfo;
                if (info.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtDeliveryId.Text != "")
            {
                List<YueYePlat.Model.vehiclejam> jamList = new YueYePlat.BLL.vehiclejam().GetModelList(String.Format("VehicleId='{0}'",txtDeliveryId.Text ));
                dgvJam.DataSource = null;
                dgvJam.DataSource = jamList;
                if (dgvJam.Rows.Count > 0)
                {
                    dgvJam.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("请输入您要查询的配送编号！");
            }
        }
    }
}
