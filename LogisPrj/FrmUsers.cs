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
    public partial class FrmUsers : Form
    {
        public YueYePlat.Model.usersinfo users = null;
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public FrmUsers()
        {
            InitializeComponent();
     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim() != "" && txtUserName.Text.Trim() != "" && (rbMan.Checked == true || rBWoman.Checked == true))
            {
                if (users != null)
                {                    
                    //users.UserId = txtUserId.Text;
                    users.UserName = txtUserName.Text;
                    string strPwd = Maticsoft.Common.StringPlus.GetMd5(txtUserPassword.Text);
                    users.UserPassword = strPwd;
                    if (rbMan.Checked == true)
                    {
                        users.UserSex = "男";
                    }
                    else if (rBWoman.Checked == true)
                    {
                        users.UserSex = "女";
                    }
                    users.UserState = int.Parse(cbxUserState.SelectedValue.ToString());
                    users.UserTypeId = cbxUserTypeId.SelectedValue.ToString();
                    users.CompanyId = cbxCompanyID.SelectedValue.ToString ();
                    users.UserMobile = txtUserId.Text;
                    if (new YueYePlat.BLL.usersinfo().Update(users))
                    {
                        MessageBox.Show("用户修改成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    YueYePlat.Model.usersinfo users = new YueYePlat.Model.usersinfo();
                    users.UserId = txtUserId.Text;
                    users.UserName = txtUserName.Text;
                    if (txtUserPassword.Text != "")
                    {
                        string strPwd = Maticsoft.Common.StringPlus.GetMd5(txtUserPassword.Text);
                        users.UserPassword = strPwd;
                    }
                    else
                    {
                        string strPwd = Maticsoft.Common.StringPlus.GetMd5("888888");
                        users.UserPassword = strPwd;
                    }
                    
                    if (rbMan.Checked == true)
                    {
                        users.UserSex = "男";
                    }
                    else if (rBWoman.Checked == true)
                    {
                        users.UserSex = "女";
                    }
                    users.UserMobile = txtUserId.Text;
                    users.UserState = int.Parse(cbxUserState.SelectedValue.ToString());
                    users.UserTypeId = cbxUserTypeId.SelectedValue.ToString();
                    users.CompanyId = cbxCompanyID.SelectedValue.ToString();
                    if (txtUserId.Text.Trim() != "")
                    {
                        List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", txtUserId.Text));
                        if (usersList.Count == 0)
                        {
                            YueYePlat.Model.logistouser user = new YueYePlat.Model.logistouser();
                            user.UserID = txtUserId.Text;
                            user.LogisCompanyID = cbxCompanyID.SelectedValue.ToString ();
                            user.CurDate = DateTime.Now;
                            new YueYePlat.BLL.logistouser().Add(user);
                            if (new YueYePlat.BLL.usersinfo().Add(users))
                            {
                                MessageBox.Show("注册成功！");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("该用户已经存在，请联系管理员！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的手机格式！");
                    }
                }
            }
            else
            {
                if (txtUserId.Text.Trim() == "")
                {
                    MessageBox.Show("请输入手机号码！");
                }
                else if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入姓名！");
                }
                else if (rbMan.Checked == true || rBWoman.Checked == true)
                {
                    MessageBox.Show("请选择性别！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmUserManager usermanage = new FrmUserManager();
            this.Close();
            
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<ListItem> items = new List<ListItem>();
            items.Add(new ListItem("0", "未激活"));
            items.Add(new ListItem("1", "正常"));
            items.Add(new ListItem("9", "注销"));
            cbxUserState.DisplayMember = "Value";
            cbxUserState.ValueMember = "Key";
            cbxUserState.DataSource = items;
            List<YueYePlat.Model.userstypeinfo> typeInfos = new YueYePlat.BLL.userstypeinfo().GetModelList("");
            cbxUserTypeId.DisplayMember = "UserTypeName";
            cbxUserTypeId.ValueMember = "UserControlId";
            cbxUserTypeId.DataSource = typeInfos;
            List<YueYePlat.Model.logiscompanyinfo> logiscompany = new YueYePlat.BLL.logiscompanyinfo().GetModelList("");
            cbxCompanyID.DisplayMember = "CompanyName";
            cbxCompanyID.ValueMember = "CompanyId";
            cbxCompanyID.DataSource = logiscompany;
            //List<YueYePlat.Model.logiscompanyinfo> companyInfos = new YueYePlat.BLL.logiscompanyinfo().GetModelList("");
            //cbxCompanyID.DisplayMember = "CompanyShortName";
            //cbxCompanyID.ValueMember = "CompanyID";
            //cbxCompanyID.DataSource = companyInfos;
            //for (int i = 0; i < items.Count; i++)
            //{
            //    cbxUserState.Items.Add(items[i]);
            //}
            //cbxUserState.SelectedIndex = 0;
            if (users != null)
            {
                logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                txtUserId.Text = users.UserId;
                txtUserName.Text = users.UserName;
                txtUserPassword.Text = users.UserPassword;
                cbxUserTypeId.SelectedText = users.UserTypeId;
                cbxUserState.SelectedValue = users.UserState.ToString();
                if (users.UserSex == "男")
                {
                    rbMan.Checked = true;
                }
                else if (users.UserSex == "女")
                {
                    rBWoman.Checked = true;
                }
                cbxUserTypeId.Text = users.UserTypeId;
                cbxCompanyID.SelectedValue = users.CompanyId;
                
            }
            else
            {
                rbMan.Checked = true;
                cbxUserState.Text = "正常";
                cbxUserTypeId.Text = "物流公司员工";
            }
            if (usersInfo != null)
            {
                List<YueYePlat.Model.logiscompanyinfo> companyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                cbxCompanyID.DataSource = companyList;
            }
        }

        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUserId_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "请输入手机号码")
            {
                txtUserId.Text = "";
                txtUserId.ForeColor = Color.Black;
            }           
        }
        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim() == "")
            {
                txtUserId.Text = "请输入手机号码";
                txtUserId.ForeColor = Color.Silver;
            }
            else if (txtUserId.Text.Trim() != "")
            {
                List<YueYePlat.Model.usersinfo> usersList = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserMobile='{0}' or UserId='{0}'", txtUserId.Text));
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
        }

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
