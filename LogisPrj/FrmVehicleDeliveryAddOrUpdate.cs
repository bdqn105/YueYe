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
    public partial class FrmVehicleDeliveryAddOrUpdate : Form
    {
        public YueYePlat.Model.vehicledelivery delivery = null;
        public FrmVehicleDeliveryAddOrUpdate()
        {
            InitializeComponent();
        }

        private void FrmDeliveryAddOrUpdate_Load(object sender, EventArgs e)
        {
            List<YueYePlat.Model.companyinfo> companyInfos = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxDeliveryId.DisplayMember = "CompanyName";
            cbxDeliveryId.ValueMember = "CompanyID";
            cbxDeliveryId.DataSource = companyInfos;
            List<YueYePlat.Model.vehicleinfo> vehicle = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId .DisplayMember = "VehicleName";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicle;
            List<YueYePlat.Model.terminaldeviceinfo> deviceInfos = new YueYePlat.BLL.terminaldeviceinfo().GetModelList("");
            cbxDeviceId.DisplayMember = "DeviceName";
            cbxDeviceId.ValueMember = "DeviceId";
            cbxDeviceId.DataSource = deviceInfos;
            List<YueYePlat.Model.vehicleinfo> vehicleInfos = new YueYePlat.BLL.vehicleinfo().GetModelList("");
            cbxVehicleId.DisplayMember = "VehicleName";
            cbxVehicleId.ValueMember = "VehicleId";
            cbxVehicleId.DataSource = vehicleInfos;
            List<YueYePlat.Model.driverinfo > driver1 = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxDriver1Id.DisplayMember = "DriverName";
            cbxDriver1Id.ValueMember = "DriverId";
            cbxDriver1Id.DataSource = driver1;
            List<YueYePlat.Model.driverinfo> driver2 = new YueYePlat.BLL.driverinfo().GetModelList("");
            cbxDriver2Id.DisplayMember = "DriverName";
            cbxDriver2Id.ValueMember = "DriverId";
            cbxDriver2Id.DataSource = driver2;
            List<YueYePlat.Model.usersinfo> recordId = new YueYePlat.BLL.usersinfo().GetModelList("");
            cbxRecordId.DisplayMember = "UserName";
            cbxRecordId.ValueMember = "UserId";
            cbxRecordId.DataSource = recordId;
            List<YueYePlat.Model.usersinfo> auditor = new YueYePlat.BLL.usersinfo().GetModelList("");
            cbxAuditor.DisplayMember = "UserName";
            cbxAuditor.ValueMember = "UserId";
            cbxAuditor.DataSource = auditor;
            List<ListItem> items = new List<ListItem>();
            items.Add(new ListItem("true", "是"));
            items.Add(new ListItem("false", "否"));
            cbxIfEnd.DisplayMember = "Value";
            cbxIfEnd.ValueMember = "Key";
            cbxIfEnd.DataSource = items;

            if (delivery != null)
            {
                cbxDeliveryId.SelectedText = delivery.DeliveryId;
                cbxDeviceId.SelectedValue = delivery.DeviceId;
                cbxDriver1Id.SelectedValue = delivery.Driver1Id;
                cbxDriver2Id.SelectedValue = delivery.Driver2Id;
                cbxVehicleId.SelectedValue = delivery.VehicleId;
                txtOrigin.Text = delivery.Origin;
                dateBeginTime.Text = delivery.BeginTime.ToString();
                txtMinTempThreshold.Text = delivery.MinTempThreshold.ToString ();
                txtMaxTempThreshold.Text = delivery.MaxTempThreshold.ToString();
                txtMinHumThreshold.Text = delivery.MinHumThreshold.ToString();
                txtMaxHumThreshold.Text = delivery.MaxHumThreshold.ToString();
                cbxIfEnd.SelectedText=delivery.IfEnd.ToString ();
                cbxAuditor.SelectedValue = delivery.Auditor;
                cbxRecordId.SelectedValue = delivery.RecordId;

            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (delivery != null)
            {
               // delivery.DeliveryId = cbxDeliveryId.Text;
                delivery.DeviceId = cbxDeviceId.SelectedValue.ToString();
                delivery.VehicleId = cbxVehicleId.SelectedValue.ToString();
                delivery.Driver1Id = cbxDriver1Id.SelectedValue.ToString();
                delivery.Driver2Id = cbxDriver2Id.SelectedValue.ToString();
                delivery.Origin = txtOrigin.Text;
                delivery.BeginTime = dateBeginTime.Value;
                delivery.MinTempThreshold = double.Parse(txtMinTempThreshold.Text);
                delivery.MaxTempThreshold = double.Parse(txtMaxTempThreshold.Text);
                delivery.MinHumThreshold = double.Parse(txtMinHumThreshold.Text);
                delivery.MaxHumThreshold = double.Parse(txtMaxHumThreshold.Text);
                delivery.IfEnd = bool.Parse (cbxIfEnd.SelectedValue.ToString ());
                delivery.Auditor = cbxAuditor.SelectedValue.ToString();
                delivery.RecordId = cbxRecordId.SelectedValue.ToString();
                if (new YueYePlat.BLL.vehicledelivery().Update(delivery))
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                
                YueYePlat.Model.vehicledelivery delivery = new YueYePlat.Model.vehicledelivery();
                delivery.DeliveryId = GenerateDeliveryID(cbxDeliveryId.SelectedValue.ToString().Substring(0,10));
                delivery.VehicleId = cbxVehicleId.SelectedValue.ToString();
                delivery.DeviceId = cbxDeviceId.SelectedValue.ToString ();
                delivery.Driver1Id = cbxDriver1Id.SelectedValue.ToString ();
                delivery.Driver2Id = cbxDriver2Id.SelectedValue.ToString();
                delivery.Origin = txtOrigin.Text;
                delivery.BeginTime = dateBeginTime.Value;
                delivery.MinTempThreshold = double.Parse (txtMinTempThreshold.Text);
                delivery.MaxTempThreshold = double.Parse (txtMaxTempThreshold.Text);
                delivery.MinHumThreshold= double .Parse ( txtMinHumThreshold.Text);
                delivery.MaxHumThreshold =double .Parse ( txtMaxHumThreshold.Text);
                delivery.IfEnd = bool.Parse (cbxIfEnd.SelectedValue.ToString());
                delivery.Auditor = cbxAuditor.SelectedValue.ToString();
                delivery.RecordId = cbxRecordId.SelectedValue.ToString();
                if (new YueYePlat.BLL.vehicledelivery().Add(delivery))
                {
                    MessageBox.Show("增加成功！");
                    this.DialogResult  = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string GenerateDeliveryID(string companyID)
        {
            string str = companyID + DateTime.Now.ToString("yyMMdd");
            List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format("DeliveryId like '{0}%' order by DeliveryId desc", str));
            if (deliveryList.Count == 0)
            {
                return str + "0001";
            }
            else
            {
                string cId = deliveryList[0].DeliveryId ;
                string cidCount = "1" + cId.Substring(16,4);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

       
    }
}
