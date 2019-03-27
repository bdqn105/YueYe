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
    public partial class FrmTransferProductInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strOrderId = "";
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmTransferProductInfo()
        {
            InitializeComponent();
        }

        private void FrmTransferProductInfo_Load(object sender, EventArgs e)
        {            
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvProductList.AutoGenerateColumns = false;
            if (strOrderId != "")
            {
                
                List<YueYePlat.Model.productdelivery> productList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", strOrderId));
                for (int i = 0; i < productList.Count; i++)
                {
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                }                
                List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                List<YueYePlat .Model .deliveryorderfee> feeList= new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", strOrderId));
                for (int i = 0; i < feeList.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Id='{0}'",feeList[i].FeeTypeId));
                    if (feetypeList[0].isDetail == false)
                    {
                        feeList[i].FeetypeName = feetypeList[0].FeeTypeName;
                        orderfeeList.Add(feeList[i]);                  
                    }
                    else
                    {
                        feeList[i].FeetypeName = feetypeList[0].FeeTypeName;
                        for (int j = 0; j < productList.Count; j++)
                        {
                            if (productList[j].OrderDetailId.Equals(feeList[i].DeliveryOrderDetailID))
                            {
                                productList[j].Feetype = feeList[i].FeeTypeId.ToString ();
                                productList[j].Fee = feeList[i].Fee;
                                productList[j].Totalfee = decimal.Parse( productList[i].Quantity.ToString ()) * productList[i].Fee;
                            }
                        }
                    }
                }
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productList;
                if (dgvProductList.Rows.Count > 0)
                {
                    dgvProductList.Rows[0].Selected = false;
                }
                dgvOrderFee.DataSource = null;
                dgvOrderFee.DataSource = orderfeeList;
                if (dgvOrderFee.Rows.Count > 0)
                {
                    dgvOrderFee.Rows[0].Selected = false;
                }
            }


        }
    }
}
