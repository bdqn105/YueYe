using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTerminaldevice : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        YueYePlat.BLL.terminaldeviceinfo  bll;
        List<YueYePlat.Model.terminaldeviceinfo> terminalDeviceList;
        private int terminalDeviceId = -1;
        YueYePlat.Model.terminaldeviceinfo terminalDevice = null;
        static FrmTerminaldevice instance;
        public string tabPageTitle = "";
        public FrmTerminaldevice()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.terminaldeviceinfo();
        }
        public static FrmTerminaldevice getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmTerminaldevice();
            }
            return instance;
        }
        private void FrmTerminaldevice_Load(object sender, EventArgs e)
        {
            dgvTermianldevice.AutoGenerateColumns = false;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            terminalDeviceList = bll.GetModelList("");
            dgvTermianldevice.DataSource = null;
            dgvTermianldevice.DataSource = terminalDeviceList;
            if (dgvTermianldevice.Rows.Count > 0)
            {
                dgvTermianldevice.Rows[0].Selected = false;
            }
            List<YueYePlat.Model.companyinfo > companyInfos = new YueYePlat.BLL.companyinfo ().GetModelList("");
            cbxCompanyId .DisplayMember = "CompanyName";
            cbxCompanyId.ValueMember = "CompanyId";
            cbxCompanyId.DataSource = companyInfos;
            string str = ConfigurationManager.AppSettings["deviceType"];          
            cbxDeviceType.DataSource = getcheck(str);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text .Length==2 && txtDeviceName.Text != "")
            {
                if (MessageBox.Show("您确定要添加" +txtDeviceName.Text +"终端设备", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.terminaldeviceinfo terminalDevice = new YueYePlat.Model.terminaldeviceinfo();

                    terminalDevice.DeviceId = GenerateDeviceID(txtDeviceId.Text );
                    terminalDevice.DeviceName = txtDeviceName.Text;                    
                    terminalDevice.DeviceType = cbxDeviceType.SelectedValue.ToString();
                    terminalDevice.CompanyId = cbxCompanyId.SelectedValue.ToString ();
                    if (new YueYePlat.BLL.terminaldeviceinfo().Add(terminalDevice))
                    {
                        MessageBox.Show("添加成功！");
                        terminalDeviceList = bll.GetModelList("");
                        dgvTermianldevice.DataSource = null;
                        dgvTermianldevice.DataSource = terminalDeviceList;
                        if (dgvTermianldevice.Rows.Count > 0)
                        {
                            dgvTermianldevice.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入两位的设备的版本号，以及设备名称！");
            }
        
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (terminalDeviceId != -1)
            {
                if (MessageBox.Show("您确定要修改" + txtDeviceName.Text + "终端设备", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    terminalDevice.DeviceId = txtDeviceId.Text;
                    terminalDevice.DeviceName = txtDeviceName.Text;
                    terminalDevice.DeviceType = cbxDeviceType.SelectedValue.ToString ();
                    terminalDevice.CompanyId = cbxCompanyId.SelectedValue.ToString();
                    if (new YueYePlat.BLL.terminaldeviceinfo().Update(terminalDevice))
                    {
                        MessageBox.Show("修改成功！");
                        terminalDeviceList = bll.GetModelList("");
                        dgvTermianldevice.DataSource = null;
                        dgvTermianldevice.DataSource = terminalDeviceList;
                        if (dgvTermianldevice.Rows.Count > 0)
                        {
                            dgvTermianldevice.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的设备！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (terminalDeviceId != -1)
            {
                if (MessageBox.Show("您确定要删除" + txtDeviceName.Text + "终端设备", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.terminaldeviceinfo().Delete(terminalDeviceId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                        terminalDeviceList = bll.GetModelList("");
                        dgvTermianldevice.DataSource = null;
                        dgvTermianldevice.DataSource = terminalDeviceList;
                        if (dgvTermianldevice.Rows.Count > 0)
                        {
                            dgvTermianldevice.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的设备！");
            }
        }

        private void dgvTermianldevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                try
                {
                    terminalDeviceId = int.Parse(dgvTermianldevice .Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    terminalDeviceId = -1;
                }

            }
            YueYePlat.Model.terminaldeviceinfo info = terminalDeviceList.Find(v => v.Id.Equals(terminalDeviceId));
            terminalDevice = info ;
            if (terminalDevice != null)
            {
                txtDeviceId.Text = terminalDevice.DeviceId;
                txtDeviceName.Text = terminalDevice.DeviceName;
                cbxDeviceType.SelectedValue = terminalDevice.DeviceType;
                cbxCompanyId.SelectedValue = terminalDevice.CompanyId;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }
        public string GenerateDeviceID(string Deviceversion)
        {
            string str = "YY"+ Deviceversion + DateTime.Now.ToString("yyMM");
            List<YueYePlat.Model.terminaldeviceinfo> deviceList = new YueYePlat.BLL.terminaldeviceinfo().GetModelList(String.Format("DeviceId like '{0}%' order by DeviceId desc", str));
            if (deviceList.Count == 0)
            {
                return str + "0001";
            }
            else
            {
                string cId = deviceList[0].DeviceId;
                string cidCount = "1" + cId.Substring(cId.Length-4);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }
        public string[] getcheck(String str)
        {
            string[] sArray = str.Split(';');
            return sArray;
        }
    }

}
