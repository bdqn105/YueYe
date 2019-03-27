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
    public partial class FrmTransferSetOrderId : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string deliveryOrderId="";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmTransferSetOrderId()
        {
            InitializeComponent();
        }

        private void FrmTransferSetOrderId_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            string strdate = DateTime.Now.ToString("yyMMdd");
            lbldate.Text = logiscompanyList[0].CompanyShortCode + strdate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text.Trim() == "")
            {
                MessageBox.Show("请手动输入6位订单编号");
            }
            else
            {
                if (txtOrderId.Text.Trim().Length == 6)
                {

                     deliveryOrderId = lbldate.Text + txtOrderId.Text;
                    List<YueYePlat.Model.deliveryorder> orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryOrderId));
                    if (orderList.Count > 0)
                    {
                        MessageBox.Show("该订单已存在，请重新输入！");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("请输入6位数字！");
                }
            }        
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            
          
        }

        private void txtOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("请输入0-9的数字");
            }
        }
    }
}
