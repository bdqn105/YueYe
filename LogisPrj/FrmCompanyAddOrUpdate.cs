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
    public partial class FrmCompanyAddOrUpdate : Form
    {
        public YueYePlat.Model.companyinfo company =null;
        public YueYePlat.Model.usersinfo userInfo;
          public FrmCompanyAddOrUpdate()
        {
            InitializeComponent();
        }

        private void FrmCompanyAddOrUpdate_Load(object sender, EventArgs e)
        {           
            List<ListItem> items = new List<ListItem>();
            items.Add(new ListItem("L", "物流公司"));
            items.Add(new ListItem("M", "医药公司"));
            items.Add(new ListItem("F", "生鲜蔬菜公司"));
            items.Add(new ListItem("N", "其他公司"));
            cbxCompanyType.DisplayMember = "Value";
            cbxCompanyType.ValueMember = "Key";
            cbxCompanyType.DataSource = items;

            if (company != null)
            {
                //cbxCompanyID .Text   = company.CompanyID;
                cbxCompanyType.SelectedValue = company.CompanyID.Substring(0,1);
                txtCompanyName.Text = company.CompanyName;
                txtCompanyUnifiedCode.Text = company.CompanyUnifiedCode;
                txtCompanyLocation.Text = company.CompanyLocation;
                txtCompanyAddress.Text = company.CompanyAddress;
                txtLegalRepresentative.Text = company.LegalRepresentative;
                txtToPrivateAccount.Text = company.ToPrivateAccount;
                txtToPublicAccount.Text = company.ToPublicAccount;
                txtTelephone.Text = company.Telephone;
                txtMobile.Text = company.Mobile;
                txtFaxNo.Text = company.FaxNo;
                cbxBusinessNature.Text = company.BusinessNature;
            }
            cbxCompanyType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (company != null)
            {
                if (MessageBox.Show("您是否要修改当前公司信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (txtCompanyName.Text.Trim() == "")
                    {
                        MessageBox.Show("公司名称不能为空！");
                    }
                    else
                    {
                        company.CompanyName = txtCompanyName.Text;
                        company.CompanyUnifiedCode = txtCompanyUnifiedCode.Text;
                        company.CompanyLocation = txtCompanyLocation.Text;
                        company.CompanyAddress = txtCompanyAddress.Text;
                        company.LegalRepresentative = txtLegalRepresentative.Text;
                        company.ToPrivateAccount = txtToPrivateAccount.Text;
                        company.ToPublicAccount = txtToPublicAccount.Text;
                        company.Telephone = txtTelephone.Text;
                        company.Mobile = txtMobile.Text;
                        company.FaxNo = txtFaxNo.Text;
                        company.BusinessNature = cbxBusinessNature.Text;
                        if (new YueYePlat.BLL.companyinfo().Update(company))
                        {
                            MessageBox.Show("公司信息修改成功");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }           
            }
            else
            {
                if (MessageBox.Show("您是否要增加该公司信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (txtCompanyName.Text.Trim() == "")
                    {
                        MessageBox.Show("公司名称不能为空！");
                    }
                    else
                    {
                        YueYePlat.Model.companyinfo company = new YueYePlat.Model.companyinfo();
                        company.CompanyID = GenerateCompanyID(cbxCompanyType.SelectedValue.ToString().Substring(0, 1));
                        company.CompanyName = txtCompanyName.Text;
                        company.CompanyUnifiedCode = txtCompanyUnifiedCode.Text;
                        company.CompanyLocation = txtCompanyLocation.Text;
                        company.CompanyAddress = txtCompanyAddress.Text;
                        company.LegalRepresentative = txtLegalRepresentative.Text;
                        company.ToPrivateAccount = txtToPrivateAccount.Text;
                        company.ToPublicAccount = txtToPublicAccount.Text;
                        company.Telephone = txtTelephone.Text;
                        company.Mobile = txtMobile.Text;
                        company.FaxNo = txtFaxNo.Text;
                        company.BusinessNature = cbxBusinessNature.Text;
                        if (new YueYePlat.BLL.companyinfo().Add(company))
                        {
                            MessageBox.Show("公司信息增加成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }                
                
            }
        }


        public string GenerateCompanyID(string companyType)
        {
            string str = companyType + DateTime.Now.ToString("yyMMdd");
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID like '{0}%' order by CompanyID desc",str));
            if(companyList.Count==0)
            {
                return str + "001";
            }
            else
            {
                string cId = companyList[0].CompanyID;
                string cidCount = "1" + cId.Substring(7);
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList(String.Format ("CompanyName='{0}'",txtCompanyName.Text ));
            if (companyList.Count > 0)
            {
                MessageBox.Show("该公司已经存在，请检查");
                btnSave.Visible = false;
            }
            else
            {
                btnSave.Visible = true;
            }
        }
    }
}
