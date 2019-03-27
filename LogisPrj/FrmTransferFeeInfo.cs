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
    public partial class FrmTransferFeeInfo : Form
    {
        public List<YueYePlat.Model.deliveryorderfee> totalfeeList;
        public string strDeliveryOrderID = "";
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmTransferFeeInfo()
        {
            InitializeComponent();
        }

        private void FrmTransferFeeInfo_Load(object sender, EventArgs e)
        {
            dgvOrderfee.AutoGenerateColumns = false;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            if (strDeliveryOrderID != "")
            {
                List<YueYePlat.Model.deliveryorderfee> feeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", strDeliveryOrderID));
                if (feeList.Count > 0)
                {
                    for (int i = 0; i < feeList.Count; i++)
                    {
                        if (feeList[i].DeliveryOrderDetailID != "")
                        {
                            List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}' and OrderDetailId='{1}'", feeList[i].DeliveryOrderId, feeList[i].DeliveryOrderDetailID));
                            feeList[i].ProductId = productList[0].ProductId;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            feeList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[0].ProductId))[0].ProductName;
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                            feeList[i].ProductCount = productList[0].Quantity.ToString();
                            feeList[i].ProductWeight = productList[0].Weight.ToString();
                            feeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId))[0].FeeTypeName;
                        }
                        else
                        {
                            feeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId))[0].FeeTypeName;
                        }
                    }               
                    dgvOrderfee.DataSource = null;
                    dgvOrderfee.DataSource = feeList;
                    if (dgvOrderfee.Rows.Count > 0)
                    {
                        dgvOrderfee.Rows[0].Selected = false;
                    }
                }
            }
            else if (totalfeeList != null)
            {
                for (int i = 0; i < totalfeeList.Count; i++)
                {
                    if (totalfeeList[i].ProductId == null)
                    {
                        List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}' and OrderDetailId='{1}'", totalfeeList[i].DeliveryOrderId, totalfeeList[i].DeliveryOrderDetailID));
                        totalfeeList[i].ProductId = productList[0].ProductId;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        totalfeeList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", totalfeeList[i].ProductId))[0].ProductName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        totalfeeList[i].ProductWeight = productList[0].Weight.ToString();
                        totalfeeList[i].ProductCount = productList[0].Quantity.ToString();
                    }
                    else
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        totalfeeList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", totalfeeList[i].ProductId))[0].ProductName;
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        totalfeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id={0}", totalfeeList[i].FeeTypeId))[0].FeeTypeName;
                    }
                   
                }                             
                dgvOrderfee.DataSource = null;
                dgvOrderfee.DataSource = totalfeeList;
                if (dgvOrderfee.Rows.Count > 0)
                {
                    dgvOrderfee.Rows[0].Selected = false;
                }
            }        
        }
    }
}
