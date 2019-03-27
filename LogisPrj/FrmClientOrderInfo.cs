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
    public partial class FrmClientOrderInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public YueYePlat.Model.clientorder clientorderInfo;
        public FrmClientOrderInfo()
        {
            InitializeComponent();
        }

        private void FrmClientOrderInfo_Load(object sender, EventArgs e)
        {
            if (clientorderInfo != null)
            {
                txtClientOrderId.Text = clientorderInfo.ClientOrderId;
                txtAirWaybillID.Text = clientorderInfo.AirWaybillID;
                txtClientAddress.Text = clientorderInfo.ClientAddress;
                cbxClientId.SelectedValue = clientorderInfo.ClientId;
                txtClientPhone.Text = clientorderInfo.ClientPhone;
                txtListnumber.Text = clientorderInfo.Listnumber;
                txtProductId.Text = clientorderInfo.ProductId;
                txtQuantity.Text = clientorderInfo.Quantity.ToString ();
                txtWeight.Text =  clientorderInfo.Weight.ToString ();
                txtReceiver.Text = clientorderInfo.Receiver;
                txtReceiverPhone.Text = clientorderInfo.Receiver;
                txtRemark.Text = clientorderInfo.Remark;
                txtReceiverAddress.Text = clientorderInfo.ReceiverAddress;
                txtSourceTransId.Text = clientorderInfo.SourceTransId;
                cbxSourTransType.Text = clientorderInfo.SourTransType;
                chkIsDelivery.Checked = clientorderInfo.IsDeliver;
            }
        }

        private void cbxSourTransType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
