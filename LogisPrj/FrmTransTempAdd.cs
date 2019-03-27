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
    public partial class FrmTransTempAdd : Form
    {
        public string strDeliveryId = "";
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.deliverycurtempinfo tempInfo; 
        public FrmTransTempAdd()
        {
            InitializeComponent();
        }    

        private void FrmTransTempAdd_Load(object sender, EventArgs e)
        {
            if(strDeliveryId!="")
            {
                List<YueYePlat.Model.vehicledelivery> deliveryList = new YueYePlat.BLL.vehicledelivery().GetModelList(String.Format ("DeliveryId='{0}'",strDeliveryId));
                if(deliveryList.Count>0)
                {
                    if (deliveryList[0].DeviceId == "")
                    {
                        this.Close();
                        MessageBox.Show("该订单没有录入终端设备信息，请先录入！");
                    }
                    else
                    {
                        txtDeviceId.Text = deliveryList[0].DeviceId;
                    }
                }
            }
            if (tempInfo != null)
            {
                txtDeviceId.Text = tempInfo.DeliveryId;
                txtTemp1.Text = tempInfo.Temperature1.ToString();
                txtTemp2.Text = tempInfo.Temperature2.ToString();
                txtTemp3.Text = tempInfo.Temperature3.ToString();
                dTGetTime.Value = DateTime.Parse ( tempInfo.CurrentTime.ToString ());

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tempInfo == null)
            {
                if (txtDeviceId.Text.Trim() != "")
                {
                    YueYePlat.Model.deliverycurtempinfo tempInfo = new YueYePlat.Model.deliverycurtempinfo();
                    tempInfo.DeliveryId = strDeliveryId;
                    try
                    {
                        tempInfo.Temperature1 = double.Parse(txtTemp1.Text);
                    }
                    catch
                    {
                        txtTemp1.Text = 0 + "";
                        tempInfo.Temperature1 = 0;
                    }
                    try
                    {
                        tempInfo.Temperature2 = double.Parse(txtTemp2.Text);
                    }
                    catch
                    {
                        txtTemp2.Text = 0 + "";
                        tempInfo.Temperature2 = 0;
                    }
                    try
                    {
                        tempInfo.Temperature3 = double.Parse(txtTemp3.Text);
                    }
                    catch
                    {
                        txtTemp3.Text = 0 + "";
                        tempInfo.Temperature3 = 0;
                    }
                    tempInfo.CurrentTime = DateTime.Parse(dTGetTime.Text);
                    if (new YueYePlat.BLL.deliverycurtempinfo().Add(tempInfo))
                    {
                        if (chkGet.Checked == true)
                        {
                            DateTime dtGet = DateTime.Parse(dTGetTime.Text);
                            dtGet = dtGet.AddMinutes(5);
                            dTGetTime.Text = dtGet.ToString();
                        }
                        if (chkUpload.Checked == true)
                        {
                            DateTime dtUpload = DateTime.Parse(dTUploadTime.Text);
                            dtUpload = dtUpload.AddMinutes(5);
                            dTUploadTime.Text = dtUpload.ToString();
                        }
                    }
                }
            }
            else
            {
                try
                {
                    tempInfo.Temperature1 = double.Parse(txtTemp1.Text);
                }
                catch
                {
                    txtTemp1.Text = 0+"";
                    tempInfo.Temperature1 = 0;
                }
                try
                {
                    tempInfo.Temperature2 = double.Parse(txtTemp2.Text);
                }
                catch
                {
                    txtTemp2.Text = 0 + "";
                    tempInfo.Temperature2 = 0;
                }
                try
                {
                    tempInfo.Temperature3 = double.Parse(txtTemp3.Text);
                }
                catch
                {
                    txtTemp3.Text = 0 + "";
                    tempInfo.Temperature3 = 0;
                }
                if (new YueYePlat.BLL.deliverycurtempinfo().Update(tempInfo))
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void txtTemp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtTemp1.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtTemp1.Text, out oldf);
                    b2 = float.TryParse(txtTemp1.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtTemp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtTemp2.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtTemp2.Text, out oldf);
                    b2 = float.TryParse(txtTemp2.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        private void txtTemp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtTemp3.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtTemp3.Text, out oldf);
                    b2 = float.TryParse(txtTemp3.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
    }
}
