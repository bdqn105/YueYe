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
    public partial class FrmTranferAddProduct : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        public string strOrderId;
        public decimal productFee;
        public YueYePlat.Model.productdelivery productInfo;
        private YueYePlat.Model.logiscompanyinfo companyInfo;
        public List<YueYePlat.Model.deliveryorderfee> feeList;
        public List<YueYePlat.Model.productdelivery> productdeliveryList; 
        public List<YueYePlat.Model.productdelivery> orderdetail;  //设置detailId
        List<YueYePlat.Model.deliveryorderfee> orderfeeList;//每单费用      
        public int productId = -1;
        string strorderDetailId = "";
        public FrmTranferAddProduct()
        {
            InitializeComponent();
        }

        private void FrmTranferAddProduct_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> companyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
            companyInfo = companyList.Find(v => v.CompanyID.Equals(usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
            dgvOrderFee.AutoGenerateColumns = false;           
            orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
            InitComponent();             
            if (productInfo != null)
            {
                strOrderId = productInfo.DeliveryOrderId;
                strorderDetailId = productInfo.OrderDetailId;
                cbxproductId.SelectedValue = productInfo.ProductId;
                txtQuantity.Text = productInfo.Quantity.ToString();               
                txtRemark.Text = productInfo.Remark;
                txtVolumeDescription.Text  = productInfo.VolumeDescription;
                txtWeight.Text = productInfo.Weight.ToString ();
                if (feeList != null)
                {
                    orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                    for (int i = 0; i < feeList.Count; i++)
                    {
                        List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(string.Format("Id='{0}'", feeList[i].FeeTypeId));
                        if (feetypeList[0].isDetail == true)
                        {
                            orderfeeList.Add(feeList[i]);
                        }                                      
                    }
                    for (int i = 0; i < orderfeeList.Count; i++)
                    {
                        orderfeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Id='{0}'",orderfeeList[i].FeeTypeId ))[0].FeeTypeName;
                    }
                    dgvOrderFee.DataSource = null;
                    dgvOrderFee.DataSource = orderfeeList;
                    if (dgvOrderFee.Rows.Count > 0)
                    {
                        dgvOrderFee.Rows[0].Selected = false;
                    }
                }
                           
            }
            else
            {
                strorderDetailId = GenerateOrderDetailID(strOrderId);            
            }
            cbxfeetype.SelectedValue = "";
            txtFee.Text = "";
             
        }

        private void InitComponent()
        {
            List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Isdetail={0}",true));
            cbxfeetype.DisplayMember = "FeeTypeName";
            cbxfeetype.ValueMember = "Id";
            cbxfeetype.DataSource = feetypeList;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueyePlatdb");             
            List<YueYePlat .Model .productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
            cbxproductId.DisplayMember = "ProductName";
            cbxproductId.ValueMember = "ProductId";
            cbxproductId.DataSource = productList;          
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);           

        }

        private void cbxproductId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxproductId.SelectedValue != null)
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");                
                List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", cbxproductId.SelectedValue));
                YueYePlat.Model.productinfo productInfo = productList.Find(v => v.ProductId.Equals(cbxproductId.SelectedValue));
                lblUnitofMeasurement.Text = productInfo.UnitofMeasurement;                
                txtQuantity.Focus();
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (strorderDetailId == "")
            {
                strorderDetailId = GenerateOrderDetailID(strOrderId);
            }
            if (feeList==null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
            if (feeList.Count > 0)
            {
                feeList = orderfeeList;
                if (productInfo != null)
                {
                    productInfo.ProductId = cbxproductId.SelectedValue.ToString();               
                    try
                    {
                        productInfo.Quantity = int.Parse(txtQuantity.Text);
                    }
                    catch (Exception ex)
                    {
                        productInfo.Quantity = 0;
                        txtQuantity.Text = 0 + "";
                    }
                    try
                    {
                        productInfo.Weight = double.Parse(txtWeight.Text);
                    }
                    catch (Exception ex)
                    {
                        productInfo.Weight = null;
                        txtWeight.Text = "";
                    }
                    productInfo.Remark = txtRemark.Text;
                    productInfo.VolumeDescription = txtVolumeDescription.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
               
            }
            else
            {          
                
                if (cbxproductId.SelectedValue != null)
                {                 
                    if (productdeliveryList == null) productdeliveryList = new List<YueYePlat.Model.productdelivery>();
                    feeList = new List<YueYePlat.Model.deliveryorderfee>();
                    for (int i = 0; i < orderfeeList.Count; i++)
                    {
                        YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                        feeInfo.Id = productId;
                        feeInfo.ProductId = cbxproductId.SelectedValue.ToString();
                        feeInfo.DeliveryOrderId = strOrderId;
                        feeInfo.IsShow =chkIfShow.Checked;
                        //feeInfo.IsShow = true;                        
                        feeInfo.DeliveryOrderDetailID = strorderDetailId;                    
                        feeInfo.FeeTypeId = orderfeeList[i].FeeTypeId;
                        feeInfo.Fee = orderfeeList[i].Fee;
                        feeInfo.ProductWeight = orderfeeList[i].ProductWeight;
                        feeInfo.ProductCount = orderfeeList[i].ProductCount;
                        feeInfo.Totalfee = orderfeeList[i].Totalfee;
                        feeList.Add(feeInfo);
                    }
                    if (productInfo == null)
                    {
                        productInfo = new YueYePlat.Model.productdelivery();
                        productInfo.DeliveryOrderId = strOrderId;             
                        productInfo.OrderDetailId = strorderDetailId;                   
                        productInfo.ProductId = cbxproductId.SelectedValue.ToString();
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueyePlatdb");
                        List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", cbxproductId.SelectedValue));
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
                        productInfo.ProductName = productList[0].ProductName;
                        try
                        {
                            productInfo.Quantity = int.Parse(txtQuantity.Text);
                        }
                        catch (Exception ex)
                        {
                            productInfo.Quantity = 0;
                            txtQuantity.Text = 0 + "";
                        }
                        try
                        {
                            productInfo.Weight = double.Parse(txtWeight.Text);
                        }
                        catch (Exception ex)
                        {
                            productInfo.Weight = null;
                            txtWeight.Text = "";
                        }
                        productInfo.Remark = txtRemark.Text;
                        productInfo.VolumeDescription = txtVolumeDescription.Text;
                        if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                        for (int i = 0; i < feeList.Count; i++)
                        {
                            productInfo.Totalfee += feeList[i].Totalfee;
                        }
                        productdeliveryList.Add(productInfo);
                        if (productdeliveryList.Count > 0)
                        {                          
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        try
                        {
                            productInfo.Quantity = int.Parse(txtQuantity.Text);
                        }
                        catch (Exception ex)
                        {
                            productInfo.Quantity = 0;
                            txtQuantity.Text = 0 + "";
                        }
                        try
                        {
                            productInfo.Weight = double.Parse(txtWeight.Text);
                        }
                        catch (Exception ex)
                        {
                            productInfo.Weight = null;
                            txtWeight.Text = "";
                        }
                        productInfo.ProductId = cbxproductId.SelectedValue.ToString();
                        productInfo.Remark = txtRemark.Text;
                        productInfo.VolumeDescription = txtVolumeDescription.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("请选择要增加的货品信息！");
                }
            }

            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProductAddOrUpdate product = new FrmProductAddOrUpdate();
            if (product.ShowDialog() == DialogResult.OK)
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueyePlatdb");
                List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList("");
                cbxproductId.DisplayMember = "ProductName";
                cbxproductId.ValueMember = "ProductId";
                cbxproductId.DataSource = productList;
                cbxproductId.SelectedValue = productList[productList.Count - 1].ProductId;           
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
            }         
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            FrmFeeType feetype = new FrmFeeType();
            feetype.detail = "isdetail";
            if (feetype.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("IsDetail={0}",true));
                cbxfeetype.DisplayMember = "FeeTypeName";
                cbxfeetype.ValueMember = "Id";
                cbxfeetype.DataSource = feetypeList;
            }
        }
        private string GenerateOrderDetailID(string orderId)
        {
            string str = orderId;
            if (orderdetail == null)
            {
                orderdetail = new YueYePlat.BLL.productdelivery().GetModelList(String.Format ("deliveryOrderId = '{0}' ",str));                
            }
            if (orderdetail.Count == 0)
            {
                return str.Substring(str.Length - 2) + "01";               
            }
            else
            {
                if (orderdetail[orderdetail.Count-1].OrderDetailId == null|| orderdetail[orderdetail.Count-1].OrderDetailId=="")
                {
                    return str.Substring(str.Length - 2) + "01";
                }
                else
                {
                    string cId = orderdetail[orderdetail.Count - 1].OrderDetailId;
                    string cidCount = "1" + cId.Substring(cId.Length - 2);
                    int count = int.Parse(cidCount) + 1;
                    return str.Substring(str.Length - 2) + count.ToString().Substring(1);
                }                
            }
        }      

        private void btnOK_Click(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
            if (strorderDetailId == "")
            {
                strorderDetailId = GenerateOrderDetailID(strOrderId);

            }
            if (cbxfeetype.SelectedValue!=null &&cbxfeetype.SelectedValue.ToString ()!=""&& txtFee.Text == "")
            {
                MessageBox.Show("请输入费用类型和金额信息完善！");
            }
            else
            {
                bool isNewFeetype = true;
                if (orderfeeList == null) orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (orderfeeList.Count > 0)
                {
                    for (int i = 0; i < orderfeeList.Count; i++)
                    {
                        if (orderfeeList[i].FeeTypeId.ToString().Equals(cbxfeetype.SelectedValue.ToString()))
                        {
                            List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[i].FeeTypeId));
                            if (feetypeList[0].isDetailCount == true)
                            {                              
                                orderfeeList[i].Fee += Math.Round(decimal.Parse(txtWeight.Text) * decimal.Parse(txtFee.Text));
                                isNewFeetype = false;
                                break;
                            }
                            else
                            {
                                orderfeeList[i].Fee += decimal.Parse(txtFee.Text) * int.Parse("1");
                            }
                        }
                    }
                    if (isNewFeetype == true)
                    {
                        YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                        feeInfo.DeliveryOrderId = strOrderId;
                        feeInfo.DeliveryOrderDetailID = strorderDetailId;
                        feeInfo.IsShow = chkIfShow.Checked;                     
                        feeInfo.FeeTypeId = int.Parse(cbxfeetype.SelectedValue.ToString());
                        List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", cbxfeetype.SelectedValue.ToString()));
                        if (feetypeList[0].isDetailCount == true)
                        {
                            feeInfo.Fee = Math.Round(decimal.Parse(txtFee.Text) * decimal.Parse(txtWeight.Text));
                        }
                        else
                        {
                            feeInfo.Fee = decimal.Parse(txtFee.Text);
                        }
                        feeInfo.ProductCount = txtQuantity.Text;
                        feeInfo.ProductWeight = txtWeight.Text;
                        feeInfo.ProductId = cbxproductId.SelectedValue.ToString();                      
                        orderfeeList.Add(feeInfo);
                        for (int i = 0; i < orderfeeList.Count; i++)
                        {
                            orderfeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[i].FeeTypeId))[0].FeeTypeName;
                        }
                    }
                    dgvOrderFee.DataSource = null;
                    dgvOrderFee.DataSource = orderfeeList;
                    if (dgvOrderFee.Rows.Count > 0)
                    {
                        dgvOrderFee.Rows[0].Selected = false;
                    }
                }
                else
                {
                    YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                    feeInfo.FeeTypeId = int.Parse(cbxfeetype.SelectedValue.ToString());
                    List<YueYePlat.Model.feetype> feeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id= '{0}'", cbxfeetype.SelectedValue.ToString()));
                    if (feeList.Count > 0)
                    {
                        if (feeList[0].isDetailCount == true)
                        {
                            feeInfo.Fee = Math.Round(decimal.Parse(txtFee.Text) * decimal.Parse(txtWeight.Text));
                        }
                        else
                        {
                            feeInfo.Fee = decimal.Parse(txtFee.Text);
                        }

                        feeInfo.ProductCount = txtQuantity.Text;
                        feeInfo.ProductWeight = txtWeight.Text;
                        feeInfo.IsShow = chkIfShow.Checked;
                        //feeInfo.IsShow = true;
                        feeInfo.ProductId = cbxproductId.SelectedValue.ToString();
                        feeInfo.Totalfee = decimal.Parse(txtFee.Text) * decimal.Parse(txtQuantity.Text);
                        orderfeeList.Add(feeInfo);
                        for (int i = 0; i < orderfeeList.Count; i++)
                        {
                            orderfeeList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[i].FeeTypeId))[0].FeeTypeName;
                        }
                        dgvOrderFee.DataSource = null;
                        dgvOrderFee.DataSource = orderfeeList;
                        if (dgvOrderFee.Rows.Count > 0)
                        {
                            dgvOrderFee.Rows[0].Selected = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("请检查费用类型是否存在！");
                    }
                }
            }
        }

        private void dgvOrderFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int str = int.Parse(dgvOrderFee.Rows[e.RowIndex].Cells["colfeetype"].Value.ToString());
                int cid = e.ColumnIndex;
                string strcolName = this.dgvOrderFee.Columns[cid].DefaultCellStyle.NullValue.ToString();
                if (strcolName == "删除")
                {
                    if (str != -1)
                    {
                        for (int i = 0; i < orderfeeList.Count; i++)
                        {
                            if (orderfeeList[i].FeeTypeId.Equals(str))
                            {
                                YueYePlat.Model.deliveryorderfee model = orderfeeList[i];
                                orderfeeList.Remove(model);
                                try
                                {
                                    feeList.Remove(model);
                                }
                                catch (Exception ex)
                                {
                                    feeList = new List<YueYePlat.Model.deliveryorderfee>();
                                }
                                for (int j = 0; j < orderfeeList.Count; j++)
                                {
                                    orderfeeList[j].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[j].FeeTypeId))[0].FeeTypeName;
                                }
                                break;
                            }
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

        private void dgvOrderFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void cbxfeetype_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxfeetype.SelectedValue != null && cbxfeetype.SelectedValue.ToString() != "")
            {
                List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", cbxfeetype.SelectedValue.ToString()));
                if (feetypeList.Count > 0)
                {
                    if (feetypeList[0].DefaultFee != null)
                    {
                        txtFee.Text = feetypeList[0].DefaultFee.ToString();
                    }
                    else
                    {
                        txtFee.Text = 0 + "";
                    }
                }
            }
            txtFee.Focus();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)  // 按下的是回车键
            {
                foreach (Control c in this.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)  // 当前控件是文本框控件
                    {
                        keyData = Keys.Tab;
                    }
                }
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void cbxproductId_MouseLeave(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.productinfo> productList = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductName='{0}'",cbxproductId.Text.Trim() ));
            if (productList.Count == 0)
            {
                MessageBox.Show("该货品不存在，请先增加！");
            }
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(companyInfo.CompanyDBName);
        }

        private void txtFee_Click(object sender, EventArgs e)
        {
            if (cbxfeetype.SelectedValue == null)
            {
                MessageBox.Show("请先选择费用类型！");
            }
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtFee.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtFee.Text, out oldf);
                    b2 = float.TryParse(txtFee.Text + e.KeyChar.ToString(), out f);
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("请输入正确的数值！");
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)                          //小数点
            {
                if (txtWeight.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtWeight.Text, out oldf);
                    b2 = float.TryParse(txtWeight.Text + e.KeyChar.ToString(), out f);
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

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
        //        keyData == Keys.Enter)
        //    {
        //        keyData = Keys.Tab;
        //    }
        //    return base.ProcessDialogKey(keyData);
        //}
    }
    
}
