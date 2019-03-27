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
    public partial class FrmUserManager : Form
    {
        YueYePlat.BLL.usersinfo bll;
        private int usersId = -1;
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.usersinfo> userslist;
        static FrmUserManager instance;
        public string tabPageTitle = "";
        string strUserId;
        int pageSize = 25;//每页个数
        int pageIndex = 1;//页索引
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        string strWhere = "";
        public FrmUserManager()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.usersinfo();
        }
        public static FrmUserManager  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmUserManager ();
            }
            return instance;
        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {          
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");            
            dgvUserInfo.AutoGenerateColumns = false;
            userslist = bll.GetModelList( pageSize,pageIndex,String.Format ( "CompanyID='{0}'",usersInfo.CompanyId) );
            totalCount = new YueYePlat.BLL.usersinfo().GetRecordCount("");
            lbltotalCount.Text = totalCount.ToString();
            lblPre.Text = 1 + "";
            pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
            lbltotalPage.Text = pageCount.ToString();
            for (int i = 0; i < userslist.Count; i++)
            {
                userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String .Format ("UserControlId='{0}'",userslist[i].UserTypeId))[0].UserTypeName;
                if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
            }
            dgvUserInfo.DataSource = null;
            dgvUserInfo.DataSource = userslist;
            if (dgvUserInfo.Rows.Count > 0)
            {
                dgvUserInfo.Rows[0].Selected = false;
            }
           
        }     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要新增用户信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmUsers add = new FrmUsers();
                add.usersInfo = usersInfo;
                add.Text = "增加用户信息";
                if (add.ShowDialog() == DialogResult.OK)
                {
                    userslist = bll.GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                    for (int i = 0; i < userslist.Count; i++)
                    {
                        userslist[i].CompanyId = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", userslist[i].CompanyId))[0].CompanyShortName;
                        userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                        if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                        else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                        else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                    }
                    dgvUserInfo.DataSource = null;
                    dgvUserInfo.DataSource = userslist;
                    if (dgvUserInfo.Rows.Count > 0)
                    {
                        dgvUserInfo.Rows[0].Selected = false;
                    }
                }
                usersId = -1;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (usersId != -1)
            {
                if (MessageBox.Show("您确定要删除该用户信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    List<YueYePlat.Model.logistouser> logistouserList = new YueYePlat.BLL.logistouser().GetModelList(String.Format ("UserId='{0}'",strUserId));
                    if (logistouserList.Count > 0)
                    {
                        YueYePlat.Model.logistouser user = logistouserList.Find(v => v.UserID.Equals(strUserId));
                        new YueYePlat.BLL.logistouser().Delete(user.ID);
                    }                    
                    bool isSuccess = new YueYePlat.BLL.usersinfo().Delete(usersId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除用户成功");
                    }
                    userslist = bll.GetModelList(String.Format ("CompanyId='{0}'",usersInfo .CompanyId ));
                    for (int i = 0; i < userslist.Count; i++)
                    {
                        userslist[i].CompanyId = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", userslist[i].CompanyId))[0].CompanyShortName;
                        userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                        if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                        else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                        else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                    }
                    dgvUserInfo.DataSource = null;
                    dgvUserInfo.DataSource = userslist;
                    if (dgvUserInfo.Rows.Count > 0)
                    {
                        dgvUserInfo.Rows[0].Selected = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的用户信息！");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (usersId != -1)
            {
                if (MessageBox.Show("您确定要修改该用户信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
               
                    FrmUsers modify = new FrmUsers();
                    modify.usersInfo = usersInfo;
                    YueYePlat.Model.usersinfo info = userslist.Find(v => v.ID.Equals(usersId));
                    modify.users = info;
                    modify.Text = "修改用户信息";
                    if (modify.ShowDialog() == DialogResult.OK)
                    {
                        userslist = bll.GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                        dgvUserInfo.DataSource = null;
                        dgvUserInfo.DataSource = userslist;
                        for (int i = 0; i < userslist.Count; i++)
                        {
                            userslist[i].CompanyId = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", userslist[i].CompanyId))[0].CompanyShortName;
                            userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                            if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                            else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                            else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                        }
                        if (dgvUserInfo.Rows.Count > 0)
                        {
                            dgvUserInfo.Rows[0].Selected = false;
                        }
                    }                                      
                    usersId = -1;
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的用户");
                
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    usersId = int.Parse(dgvUserInfo.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch(Exception ex)
                {
                    usersId = -1;
                }
                strUserId = dgvUserInfo.Rows[e.RowIndex].Cells["colUserId"].Value.ToString();
            }
            else
            {
                if(dgvUserInfo.Rows.Count>0)
                {
                    dgvUserInfo.ClearSelection();
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnPwdModify_Click(object sender, EventArgs e)
        {
            FrmPwdModify frm = new LogisPrj.FrmPwdModify();
            YueYePlat.Model.usersinfo info = userslist.Find(v => v.ID.Equals(usersId));
            frm.users = info;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("密码重置成功！");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            userslist = bll.GetModelList(String.Format ("CompanyId='{0}'",usersInfo .CompanyId ));
            for (int i = 0; i < userslist.Count; i++)
            {
                userslist[i].CompanyId = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", userslist[i].CompanyId))[0].CompanyShortName;
                userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
            }
            dgvUserInfo.DataSource = null;
            dgvUserInfo.DataSource = userslist;
            if (dgvUserInfo.Rows.Count > 0)
            {
                dgvUserInfo.Rows[0].Selected = false;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageCount;
                lblPre.Text = pageIndex.ToString();
                userslist = bll.GetModelList(pageSize, pageIndex, String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                for (int i = 0; i < userslist.Count; i++)
                {
                    userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                    if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                    else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                    else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                }
                dgvUserInfo.DataSource = null;
                dgvUserInfo.DataSource = userslist;
                if (dgvUserInfo.Rows.Count > 0)
                {
                    dgvUserInfo.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是末页！");
            }
        }

        private void btnGoPage_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPage.Text.Trim(), "^\\d+$"))
            {
                int pageNum = int.Parse(txtPage.Text.Trim());
                if (pageNum >= 1 && pageNum <= pageCount)
                {
                    userslist = bll.GetModelList(pageSize, pageNum, String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                    for (int i = 0; i < userslist.Count; i++)
                    {
                        userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                        if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                        else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                        else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                    }
                    dgvUserInfo.DataSource = null;
                    dgvUserInfo.DataSource = userslist;
                    if (dgvUserInfo.Rows.Count > 0)
                    {
                        dgvUserInfo.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("请输入合理的页数！");
                }

            }
            else
            {
                MessageBox.Show("请输入正确的页数！");
            }
        }
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = 1;
                lblPre.Text = pageIndex.ToString();
                userslist = bll.GetModelList(pageSize, pageIndex, String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                for (int i = 0; i < userslist.Count; i++)
                {
                    userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                    if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                    else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                    else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                }
                dgvUserInfo.DataSource = null;
                dgvUserInfo.DataSource = userslist;
                if (dgvUserInfo.Rows.Count > 0)
                {
                    dgvUserInfo.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是首页！");
            }
        }
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = pageIndex - 1;
                lblPre.Text = pageIndex.ToString();
                userslist = bll.GetModelList(pageSize, pageIndex, String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                for (int i = 0; i < userslist.Count; i++)
                {
                    userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                    if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                    else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                    else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                }
                dgvUserInfo.DataSource = null;
                dgvUserInfo.DataSource = userslist;
                if (dgvUserInfo.Rows.Count > 0)
                {
                    dgvUserInfo.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是第一页！");
            }
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageIndex + 1;
                lblPre.Text = pageIndex.ToString();
                userslist = bll.GetModelList(pageSize, pageIndex, String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                for (int i = 0; i < userslist.Count; i++)
                {
                    userslist[i].UserTypeId = new YueYePlat.BLL.userstypeinfo().GetModelList(String.Format("UserControlId='{0}'", userslist[i].UserTypeId))[0].UserTypeName;
                    if (userslist[i].UserState == 1) userslist[i].UsersStateName = "正常状态";
                    else if (userslist[i].UserState == 9) userslist[i].UsersStateName = "注销状态";
                    else if (userslist[i].UserState == 0) userslist[i].UsersStateName = "未激活状态";
                }
                dgvUserInfo.DataSource = null;
                dgvUserInfo.DataSource = userslist;
                if (dgvUserInfo.Rows.Count > 0)
                {
                    dgvUserInfo.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是最后一页！");
            }
        }
    }
}
