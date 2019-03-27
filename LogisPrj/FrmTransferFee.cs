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
    public partial class FrmTransferFee : Form
    {
        public string strFeeInfo;
        public string deliveryOrderId;
        public decimal totalMoney=0;      
        public List<YueYePlat.Model.deliveryorderfee> feeList;
        int feeId = -1;
           public FrmTransferFee()
        {
            InitializeComponent();
        }

        private void FrmTransferFee_Load(object sender, EventArgs e)
        {
            dgvOrderFee.AutoGenerateColumns = false;
            List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Isdetail='{0}'",false));
            cbxFeeType.DisplayMember = "FeeTypeName";
            cbxFeeType.ValueMember = "Id";
            cbxFeeType.DataSource = feetypeList;            
            cbxFeeType.Text = "";
            txtMoney.Text = "";
            if (feeList != null)
            {
                List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                for (int i = 0; i < feeList.Count; i++)
                {
                    List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                    if (feetype[0].isDetail == false)
                    {
                        orderfeeList.Add(feeList[i]);
                    }                   
                }
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

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (txtMoney.Text == "")
            {
                MessageBox.Show("请输入金额！");
            }
            else
            {
                bool isNewfeetype = true;
                if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (feeList.Count > 0)
                {
                    for (int i = 0; i < feeList.Count; i++)
                    {
                        if (feeList[i].FeeTypeId.ToString().Equals(cbxFeeType.SelectedValue.ToString()))
                        {
                            feeList[i].Fee += decimal.Parse(txtMoney.Text);
                            feeList[i].Totalfee =feeList[i].Fee;
                            feeList[i].IsShow = feeList[i].IsShow;
                            isNewfeetype = false;
                            List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                            for (int j = 0; j < feeList.Count; j++)
                            {
                                List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[j].FeeTypeId));
                                if (feetype[0].isDetail == false)
                                {
                                    orderfeeList.Add(feeList[j]);
                                }
                            }
                            for (int j = 0; j < orderfeeList.Count; j++)
                            {
                                orderfeeList[j].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", orderfeeList[j].FeeTypeId))[0].FeeTypeName;
                            }
                            dgvOrderFee.DataSource = null;
                            dgvOrderFee.DataSource = orderfeeList;                           
                            if (dgvOrderFee.Rows.Count > 0)
                            {
                                dgvOrderFee.Rows[0].Selected = false;
                            }
                            break;
                        }                        
                    }
                    if (isNewfeetype == true)
                    {
                        YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                        feeInfo.DeliveryOrderId = deliveryOrderId;
                        feeInfo.IsShow = chkIsShow.Checked;
                        feeInfo.FeeTypeId = int.Parse(cbxFeeType.SelectedValue.ToString());
                        feeInfo.Fee = decimal.Parse(txtMoney.Text);
                        feeInfo.Totalfee = decimal.Parse(txtMoney.Text);
                        totalMoney += decimal.Parse(txtMoney.Text);
                        if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                        feeList.Add(feeInfo);
                        List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                        for (int i = 0; i < feeList.Count; i++)
                        {
                            List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                            if (feetype[0].isDetail == false)
                            {
                                orderfeeList.Add(feeList[i]);
                            }
                        }
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
                }
                else
                {
                    //txtFeeInfo.Text += cbxFeeType.Text+ ":" + txtMoney.Text + Environment.NewLine;
                    YueYePlat.Model.deliveryorderfee feeInfo = new YueYePlat.Model.deliveryorderfee();
                    feeInfo.DeliveryOrderId = deliveryOrderId;
                    feeInfo.IsShow = chkIsShow.Checked;
                    feeInfo.FeeTypeId = int.Parse(cbxFeeType.SelectedValue.ToString());
                    feeInfo.Fee = decimal.Parse(txtMoney.Text);
                    feeInfo.Totalfee = decimal.Parse(txtMoney.Text);
                    totalMoney += decimal.Parse(txtMoney.Text);
                    if (feeList == null) feeList = new List<YueYePlat.Model.deliveryorderfee>();
                    feeList.Add(feeInfo);
                    List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                    for (int i = 0; i < feeList.Count; i++)
                    {
                        List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[i].FeeTypeId));
                        if (feetype[0].isDetail == false)
                        {
                            orderfeeList.Add(feeList[i]);
                        }
                    }
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
            }                 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {           
            this.DialogResult = DialogResult.OK;
            this.Close();            
        }
        private void btnAddFeeType_Click(object sender, EventArgs e)
        {
            FrmFeeType feetype = new FrmFeeType();
            feetype.detail = "nodetail";
            if (feetype.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.feetype> feeList = new YueYePlat.BLL.feetype().GetModelList("");
                List<YueYePlat.Model.feetype> feetypeList = new List<YueYePlat.Model.feetype>();
                for (int i = 0; i < feeList.Count; i++)
                {
                    if (feeList[i].isDetail == false)
                    {
                        feetypeList.Add(feeList[i]);
                    }
                }
                cbxFeeType.DisplayMember = "FeeTypeName";
                cbxFeeType.ValueMember = "Id";
                cbxFeeType.DataSource = feetypeList;
                cbxFeeType.SelectedValue = feetypeList[feetypeList.Count - 1].Id;
            }
        }
        private void dgvOrderFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int str = int.Parse(dgvOrderFee.Rows[e.RowIndex].Cells["colfeetype"].Value.ToString());
                int cid = e.ColumnIndex;
                string strcolName = this.dgvOrderFee.Columns[cid].DefaultCellStyle.NullValue.ToString();
                List<YueYePlat.Model.deliveryorderfee> orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                if (strcolName == "删除")
                {
                    if (str != -1)
                    {
                        for (int i = 0; i < feeList.Count; i++)
                        {
                            if (feeList[i].FeeTypeId.Equals(str))
                            {
                                YueYePlat.Model.deliveryorderfee model = feeList[i];
                                feeList.Remove(model);
                                for (int j = 0; j < feeList.Count; j++)
                                {
                                    List<YueYePlat.Model.feetype> feetype = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", feeList[j].FeeTypeId));
                                    if (feetype[0].isDetail == false)
                                    {
                                        orderfeeList.Add(feeList[j]);
                                    }
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
        private void cbxFeeType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxFeeType.SelectedValue != null && cbxFeeType.SelectedValue.ToString() != "")
            {
                List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("Id='{0}'",cbxFeeType.SelectedValue.ToString ()));
                if (feetypeList.Count > 0)
                {
                    if (feetypeList[0].DefaultFee != null)
                    {
                        txtMoney.Text = feetypeList[0].DefaultFee.ToString();
                    }
                    else
                    {
                        txtMoney.Text = 0 + "";
                    }
                }
            }
            txtMoney.Focus();
        }
        private void dgvOrderFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    feeId = int.Parse(dgvOrderFee.Rows[e.RowIndex].Cells["colfeetype"].Value.ToString());
                }
                catch (Exception ex)
                {
                    feeId = -1;
                }
            }
        }
    }
}
