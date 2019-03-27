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
    public partial class FrmProduct : Form
    {
        YueYePlat.BLL.productinfo  bll;
        List<YueYePlat.Model.productinfo> productList;
        public YueYePlat.Model.usersinfo usersInfo;
        private int productId=-1;
        int pageSize = 25;//每页个数
        int pageIndex = 1;//页索引
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        string strWhere = "";
        static FrmProduct  instance;
        public string tabPageTitle = "";
        public FrmProduct()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.productinfo();
        }
        public static FrmProduct  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmProduct ();
            }
            return instance;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            totalCount = new YueYePlat.BLL.productinfo().GetRecordCount("");
            lbltotalCount.Text = totalCount.ToString();
            lblPre.Text = 1 + "";
            pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
            lbltotalPage.Text = pageCount.ToString();
            productList = bll.GetModelList(pageSize,pageIndex,"");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productList ;           
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Rows[0].Selected = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要增加货品信息吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmProductAddOrUpdate add = new LogisPrj.FrmProductAddOrUpdate();
                add.Text = "增加货品信息";
                if (add.ShowDialog() == DialogResult.OK)
                {
                    productList = bll.GetModelList("");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = productList;
                    if (dataGridView1.DataSource != null)
                    {
                        dataGridView1.Rows[0].Selected = false;
                    }
                }
            }
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productId != -1)
            {
                FrmProductAddOrUpdate update = new FrmProductAddOrUpdate();
                YueYePlat.Model.productinfo info = productList.Find(v => v.Id.Equals(productId));
                update.product = info;
                update.Text = "修改货品信息";
                if (update.ShowDialog() == DialogResult.OK)
                {
                    productList = bll.GetModelList("");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = productList;
                    if (dataGridView1.DataSource != null)
                    {
                        dataGridView1.Rows[0].Selected = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择货品信息！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (productId  != -1)
            {
                if (MessageBox.Show("您确定删除该货品信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.productinfo().Delete(productId );
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除货品信息成功！");
                        productList = bll.GetModelList("");
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = productList;
                        if (dataGridView1.DataSource != null)
                        {
                            dataGridView1.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的货品信息！");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    productId  = int.Parse(dataGridView1 .Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    productId  = -1;
                }
            }        
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex = 1;
                lblPre.Text = pageIndex.ToString();
                productList = bll.GetModelList("");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productList;
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.Rows[0].Selected = false;
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
                productList = bll.GetModelList(pageSize, pageIndex, "");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productList;
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.Rows[0].Selected = false;
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
                productList = bll.GetModelList(pageSize, pageIndex, "");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productList;
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.Rows[0].Selected = false;
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
                productList = bll.GetModelList(pageSize, pageIndex, "");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productList;
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.Rows[0].Selected = false;
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
                    productList = bll.GetModelList(pageSize, pageNum, "");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = productList;
                    if (dataGridView1.DataSource != null)
                    {
                        dataGridView1.Rows[0].Selected = false;
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
