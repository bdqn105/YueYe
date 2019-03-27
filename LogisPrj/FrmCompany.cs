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
    public partial class FrmCompany : Form
    {
        YueYePlat .BLL .companyinfo bll;
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.companyinfo> companyList;
        private int companyId = -1;
        static FrmCompany instance;
        public string tabPageTitle = "";
        int pageSize = 25;//每页个数
        int pageIndex = 1;//页索引
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        string strWhere = "";

        public FrmCompany()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.companyinfo();       
        }

        public static FrmCompany getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmCompany();
            }
            return instance;
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> logiscompany = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyID='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompany[0].CompanyDBName);
            dgvCompany.AutoGenerateColumns = false;
            companyList = bll.GetModelList(pageSize,pageIndex,"");
            totalCount = new YueYePlat.BLL.companyinfo().GetRecordCount("");
            lbltotalCount.Text = totalCount.ToString();
            lblPre.Text = 1 + "";
            pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
            lbltotalPage.Text = pageCount.ToString();
            dgvCompany.DataSource = null;
            dgvCompany.DataSource = companyList;
            if (dgvCompany.Rows.Count > 0)
            {
                dgvCompany.Rows[0].Selected = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCompanyAddOrUpdate add = new LogisPrj.FrmCompanyAddOrUpdate();
            add.Text = "增加公司信息";
            if (add.ShowDialog() == DialogResult.OK)
            {
                pageIndex = 1;
                lbltotalCount.Text = new YueYePlat.BLL.companyinfo().GetRecordCount("").ToString ();
                companyList = bll.GetModelList(pageSize,pageIndex,"");
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = companyList;
                if (dgvCompany.Rows.Count > 0)
                {
                    dgvCompany.Rows[0].Selected = false;
                }
            }
            companyId = -1;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (companyId != -1)
            {
                FrmCompanyAddOrUpdate modify = new LogisPrj.FrmCompanyAddOrUpdate();
                YueYePlat.Model.companyinfo info = companyList.Find(v => v.Id.Equals(companyId));
                modify.userInfo = usersInfo;
                modify.company = info;
                modify.Text = "修改公司信息";
                if (modify.ShowDialog() == DialogResult.OK)
                {
                    companyList = bll.GetModelList(pageSize,pageIndex,"");
                    dgvCompany.DataSource = null;
                    dgvCompany.DataSource = companyList;
                    if (dgvCompany.Rows.Count > 0)
                    {
                        dgvCompany.Rows[0].Selected = false;
                    }
                }
                companyId = -1;
            }
            else
            {
                MessageBox.Show("请选择公司");
            }
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    companyId = int.Parse(dgvCompany.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    companyId = -1;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (companyId != -1)
            {
                if (MessageBox.Show("您确定删除该公司信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.companyinfo().Delete(companyId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除公司信息成功");
                        companyList = bll.GetModelList("");
                        dgvCompany.DataSource = null;
                        dgvCompany.DataSource = companyList;
                        if (dgvCompany.Rows.Count > 0)
                        {
                            dgvCompany.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的公司信息");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void dgvCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvCompany.Rows[e.RowIndex].Cells["colCompanyID"].Value.ToString();
                List<YueYePlat.Model.companyinfo> companyList = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", str));
                YueYePlat.Model.companyinfo companyInfo = companyList.Find(v => v.CompanyID.Equals(str));
                FrmCompanyAddOrUpdate company = new FrmCompanyAddOrUpdate();
                company.userInfo = usersInfo;
                company.company = companyInfo;
                if (company.ShowDialog() == DialogResult.OK)
                {
                    companyList = bll.GetModelList("");
                    dgvCompany.DataSource = null;
                    dgvCompany.DataSource = companyList;
                    if (dgvCompany.Rows.Count > 0)
                    {
                        dgvCompany.Rows[0].Selected = false;
                    }
                }
            }     
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = 1;
                lblPre.Text = pageIndex.ToString();
                companyList = bll.GetModelList(pageSize, pageIndex, "");                
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = companyList;
                if (dgvCompany.Rows.Count > 0)
                {
                    dgvCompany.Rows[0].Selected = false;
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
                companyList = bll.GetModelList(pageSize, pageIndex, "");
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = companyList;
                if (dgvCompany.Rows.Count > 0)
                {
                    dgvCompany.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是第一页！");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageIndex<pageCount)
            {
                pageIndex = pageIndex + 1;
                lblPre.Text = pageIndex.ToString();
                companyList = bll.GetModelList(pageSize, pageIndex, "");
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = companyList;
                if (dgvCompany.Rows.Count > 0)
                {
                    dgvCompany.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("当前页面已经是最后一页！");
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageIndex < pageCount)
            {
                pageIndex = pageCount;
                lblPre.Text = pageIndex.ToString();
                companyList = bll.GetModelList(pageSize, pageIndex, "");
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = companyList;
                if (dgvCompany.Rows.Count > 0)
                {
                    dgvCompany.Rows[0].Selected = false;
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
                    companyList = bll.GetModelList(pageSize, pageNum, "");
                    dgvCompany.DataSource = null;
                    dgvCompany.DataSource = companyList;
                    if (dgvCompany.Rows.Count > 0)
                    {
                        dgvCompany.Rows[0].Selected = false;
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
    }
}
