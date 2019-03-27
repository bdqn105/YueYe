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
    public partial class FrmClientAddOrUpdate : Form
    {
        public YueYePlat.Model.clientinfo client = null;
        public YueYePlat.Model.usersinfo usersInfo;    
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmClientAddOrUpdate()
        {
            InitializeComponent();
        }

        private void FrmClientAddOrUpdate_Load(object sender, EventArgs e)
        {           
            cbxCompanyId.SelectedValue = "";
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo .CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            lblClientID.Text = "";          
            List<YueYePlat.Model.companyinfo> companyInfos = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxCompanyId.DisplayMember = "CompanyName";
            cbxCompanyId.ValueMember = "CompanyID";
            cbxCompanyId.DataSource = companyInfos;
            if (client != null)
            {
                //txtClientId.ReadOnly = true;
                lblClientID.Text = client.ClientId;
                txtClientName.Text = client.ClientName;
                txtTelephone.Text = client.Telephone;
                txtMobile.Text = client.Mobile;
                cbxCompanyId.SelectedValue = client.CompanyId;
                cbxCompanyId.ForeColor = Color.Black;
            }
            else
            {
                lblClientID.Text = GenerateClientID(logiscompanyList[0].CompanyShortCode);
            }
                      
        }
        public string GenerateClientID(string companyShortCode)
        {
            string str = companyShortCode+"C";
            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId like '{0}%' order by ClientId desc",str));
            if (clientList.Count == 0)
            {
                return str + "000001";
            }
            else
            {
                string cId = clientList[0].ClientId.Substring(clientList[0].ClientId.Length-6);
                string cidCount = "1" + cId;
                int count = int.Parse(cidCount) + 1;
                return str + count.ToString().Substring(1);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxCompanyId.SelectedValue != null)
            {
                if (client != null)
                {
                    if (MessageBox.Show("您确定要修改" + txtClientName.Text + "的用户信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                       // client.ClientId = lblClientID.Text;
                        client.ClientName = txtClientName.Text;
                        client.Telephone = txtTelephone.Text;
                        client.Mobile = txtMobile.Text;
                        client.CompanyId = cbxCompanyId.SelectedValue.ToString();
                        if (new YueYePlat.BLL.clientinfo().Update(client))
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                { 
                    List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientName='{0}'", txtClientName.Text));
                    if (clientList.Count == 0)
                    {
                        if (MessageBox.Show("您确定要增加" + txtClientName.Text + "的用户信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            YueYePlat.Model.clientinfo client = new YueYePlat.Model.clientinfo();
                            client.ClientId = lblClientID.Text;
                            client.ClientName = txtClientName.Text;
                            client.Telephone = txtTelephone.Text;
                            client.Mobile = txtMobile.Text;
                            client.CompanyId = cbxCompanyId.SelectedValue.ToString();
                            if (lblClientID.Text != "")
                            {
                                YueYePlat.Model.usersinfo info = new YueYePlat.Model.usersinfo();
                                info.UserId = lblClientID.Text;
                                info.UserName = txtClientName.Text;
                                info.UserTypeId = "APP01";
                                info.UserState = 1;
                                info.UserSex = "男";
                                info.UserPassword = Maticsoft.Common.StringPlus.GetMd5("888888");
                                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                                List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", lblClientID.Text));
                                if (usersList.Count == 0)
                                {
                                    new YueYePlat.BLL.usersinfo().Add(info);
                                    YueYePlat.Model.logistouser logistouser = new YueYePlat.Model.logistouser();
                                    logistouser.UserID = lblClientID.Text;
                                    logistouser.LogisCompanyID = usersInfo.CompanyId;
                                    logistouser.CurDate = DateTime.Now;
                                    new YueYePlat.BLL.logistouser().Add(logistouser);
                                    Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                                    if (new YueYePlat.BLL.clientinfo().Add(client))
                                    {
                                        MessageBox.Show("增加成功！");
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该客户已经注册！");
                                }
                            }                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("该客户信息已经存在！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择当前客户所在公司！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void txtClientId_MouseClick(object sender, MouseEventArgs e)
        {
            //txtClientId.Text = "";           
            //txtClientId.ForeColor = Color.Black;
        }   
        private void txtClientId_Leave(object sender, EventArgs e)
        {
            //if (txtClientId.Text == "")
            //{
            //    txtClientId.Text = "请输入手机号码";            
            //    txtClientId.ForeColor = Color.Silver;
            //}
        }

        private void cbxCompanyId_Click(object sender, EventArgs e)
        {
            if (cbxCompanyId.Text == "请选择客户所在公司")
            {
                cbxCompanyId.Text = "";
                cbxCompanyId.ForeColor = Color.Black;
            }           
        }

        private void cbxCompanyId_Leave(object sender, EventArgs e)
        {
            if (cbxCompanyId.Text == "" && cbxCompanyId.SelectedValue == null)
            {
                cbxCompanyId.Text = "请选择客户所在公司";
                cbxCompanyId.ForeColor = Color.Silver;
            }
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

        private void txtClientId_Enter(object sender, EventArgs e)
        {
            //if (txtClientId.Text == "请输入手机号码")
            //{
            //    txtClientId.Text = "";
            //}
            //txtClientId.ForeColor = Color.Black;
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            FrmCompanyAddOrUpdate company = new FrmCompanyAddOrUpdate();
            company.userInfo = usersInfo;
            if (company.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList("");
                cbxCompanyId.DisplayMember = "CompanyName";
                cbxCompanyId.ValueMember = "CompanyId";
                cbxCompanyId.DataSource = companyList;
                cbxCompanyId.SelectedValue = companyList[companyList.Count - 1].CompanyID;
                cbxCompanyId.ForeColor = Color.Black;
            }
        }

        private void cbxCompanyId_DropDown(object sender, EventArgs e)
        {
            cbxCompanyId.ForeColor = Color.Black;
        }

        private void txtClientName_Leave(object sender, EventArgs e)
        {
            if (txtClientName.Text.Trim() != "")
            {
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format ("ClientName='{0}'",txtClientName.Text ));
                if (clientList.Count > 0)
                {
                    MessageBox.Show("该客户名称已经存在，请先核查！");
                    //btnSave.Visible = false;
                }
                else
                {
                    btnSave.Visible = true;
                }
            }
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            if (txtMobile.Text.Trim() != "")
            {
                List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format ("UserMobile='{0}' or UserId='{0}'",txtMobile.Text ));
                if (usersList.Count > 0)
                {
                    MessageBox.Show("该手机号已经注册！");
                    btnSave.Visible = false;
                }
                else
                {
                    btnSave.Visible = true;
                }
            }
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
        }
    }
}
