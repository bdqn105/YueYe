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
    public partial class FrmFeeType : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public string detail ;
        public FrmFeeType()
        {
            InitializeComponent();
        }

        private void FrmFeeType_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            dgvFeeType.AutoGenerateColumns = false;
            //if (detail == "isdetail")
            //{
            //    List<YueYePlat.Model.feetype> fee = new YueYePlat.BLL.feetype().GetModelList(String.Format("Isdetail={0}", true));
            //    dgvFeeType.DataSource = null;
            //    dgvFeeType.DataSource = fee;
            //    if (dgvFeeType.Rows.Count > 0)
            //    {
            //        dgvFeeType.Rows[0].Selected = false;
            //    }
            //}
            //else if (detail == "nodetail")
            //{
            //    List<YueYePlat.Model.feetype> fee = new YueYePlat.BLL.feetype().GetModelList(String.Format("Isdetail={0}", false));
            //    dgvFeeType.DataSource = null;
            //    dgvFeeType.DataSource = fee;
            //    if (dgvFeeType.Rows.Count > 0)
            //    {
            //        dgvFeeType.Rows[0].Selected = false;
            //    }
            //}
            //else
            //{

            //}
            txtFeeTypeName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFeeTypeName.Text.Trim() != "")
            {
                List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format("FeeTypeName='{0}'", txtFeeTypeName.Text.Trim()));
                if (feetypeList.Count > 0)
                {
                    MessageBox.Show("该费用已经存在！");
                }
                else
                {

                    if (MessageBox.Show("您确定要新增" + txtFeeTypeName.Text + "费用名称？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        YueYePlat.Model.feetype feeInfo = new YueYePlat.Model.feetype();
                        feeInfo.FeeTypeName = txtFeeTypeName.Text;
                        try
                        {
                            feeInfo.DefaultFee = decimal.Parse(txtDefaultFee.Text);
                        }
                        catch (Exception ex)
                        {
                            feeInfo.DefaultFee = 0;
                            txtDefaultFee.Text = 0 + "";
                        }
                        feeInfo.isDetailCount = ckBisDetailWight.Checked;
                        if (detail == "nodetail")
                        {
                            feeInfo.isDetail = false;
                        }
                        if (detail == "isdetail")
                        {
                            feeInfo.isDetail = true;
                            if (feeInfo.isDetailCount == false)
                            {
                                feeInfo.DefaultFee = 1;
                            }
                        }

                        if (new YueYePlat.BLL.feetype().Add(feeInfo))
                        {
                            MessageBox.Show("增加成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入要新增的费用名称！");
            }
        }

        private void txtFeeTypeName_Enter(object sender, EventArgs e)
        {
           // txtDefaultFee.Focus();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void txtFeeTypeName_Leave(object sender, EventArgs e)
        {
            List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList(String.Format ("FeeTypeName='{0}'",txtFeeTypeName.Text .Trim ()));
            if (feetypeList.Count > 0)
            {
                MessageBox.Show("该费用已存在！");
                txtFeeTypeName.Text = "";
            }

        }
    }
}
