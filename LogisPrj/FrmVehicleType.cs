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
    public partial class FrmVehicleType : Form
    {
        List<YueYePlat.Model.vehicletype> vehicleTypeList;
        YueYePlat.BLL.vehicletype bll;
        private int vehicletypeId = -1;
        YueYePlat.Model.vehicletype vehicletype;

        static FrmVehicleType instance;
        public string tabPageTitle = "";
        public FrmVehicleType()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.vehicletype();
        }
        public static FrmVehicleType getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmVehicleType();
            }
            return instance;
        }
        private void FrmVehicleType_Load(object sender, EventArgs e)
        {
            vehicleTypeList = bll.GetModelList("");
            dgvVehicleType.DataSource = vehicleTypeList;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ( txtVehicleTypeName.Text != "")
            {
                if (MessageBox.Show("您确定要增加" + txtVehicleTypeName.Text + "车辆类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.vehicletype vehicleType = new YueYePlat.Model.vehicletype();
                    vehicleType.VehicleTypeID =GenerateVehicleTypeID();
                    vehicleType.VehicleTypeName = txtVehicleTypeName.Text;
                    if (new YueYePlat.BLL.vehicletype().Add(vehicleType))
                    {
                        MessageBox.Show("增加成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        vehicleTypeList = bll.GetModelList("");
                        dgvVehicleType.DataSource = vehicleTypeList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入正确的车辆类型名称");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (vehicletypeId != -1)
            {
                if (MessageBox.Show("您确定要修改" + txtVehicleTypeName.Text + "车辆类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    vehicletype.VehicleTypeName = txtVehicleTypeName.Text;                    
                    if (new YueYePlat.BLL.vehicletype().Update(vehicletype))
                    {
                        MessageBox.Show("修改成功");
                        vehicleTypeList = bll.GetModelList("");
                        dgvVehicleType.DataSource = vehicleTypeList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择修改的车辆类型！");
            }
        }

     

        private void dgvVehicleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    vehicletypeId = int.Parse(dgvVehicleType.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    vehicletypeId = -1;
                }
            }
            YueYePlat.Model.vehicletype  info = vehicleTypeList.Find(v => v.ID.Equals(vehicletypeId));
            vehicletype = info;
            if (vehicletype != null)
            {
                txtVehicleTypeName.Text = vehicletype .VehicleTypeName;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }
        public string GenerateVehicleTypeID( )
        {            
            List<YueYePlat.Model.vehicletype> vehicletype = new YueYePlat.BLL.vehicletype().GetModelList(String.Format("VehicleTypeID order by VehicleTypeID desc"));
            if (vehicletype .Count == 0)
            {
                return  "001";
            }
            else
            {
                string cId = vehicletype [0].VehicleTypeID;
                string cidCount = "1" + cId;
                int count = int.Parse(cidCount) + 1;
                return  count.ToString().Substring(1);
            }
        }

    }
}
