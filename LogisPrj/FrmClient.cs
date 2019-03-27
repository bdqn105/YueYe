using NUnit.Framework;
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
    public partial class FrmClient : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        YueYePlat.BLL.clientinfo bll;
        private int clientId = -1;
        List<YueYePlat.Model.clientinfo> clientList ;
        static FrmClient  instance;
        public string tabPageTitle = "";
        //初始化绑定默认关键词（此数据源可以从数据库取）
        List<string> listOnit = new List<string>();
        //输入key之后，返回的关键词
        List<string> listNew = new List<string>();
        int pageSize = 25;//每页个数
        int pageIndex = 1;//页索引
        private int totalCount = 0;//总数据个数
        private int pageCount = 0;//总页数
        string strWhere = "";
        List<YueYePlat.Model.companyinfo> companyInfos;

        public FrmClient()
        {
            InitializeComponent();
            bll = new YueYePlat .BLL .clientinfo ();
        }

        public static FrmClient  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmClient ();
            }
            return instance;
        }
        private void FrmClient_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> company = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);              
            dgvClient.AutoGenerateColumns = false; 
            companyInfos = new YueYePlat.BLL.companyinfo().GetModelList("");
            cbxCompany.DisplayMember = "CompanyName";
            cbxCompany.ValueMember = "CompanyID";
            cbxCompany.DataSource = companyInfos;             
            //权限设置
            if (usersInfo.UserTypeId == "YY01")  //跃叶
            {
                clientList = bll.GetModelList(pageSize, pageIndex, "");
                totalCount = new YueYePlat.BLL.clientinfo().GetRecordCount("");
                lbltotalCount.Text = totalCount.ToString();
                lblPre.Text = 1 + "";
                pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
                lbltotalPage.Text = pageCount.ToString();
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
                }
                btnAdd.Visible = false;
                btnModify.Visible = false;
            }
            if (usersInfo.UserTypeId == "WL01") //物流
            {               
                clientList = bll.GetModelList(pageSize,pageIndex,"");
                totalCount = new YueYePlat.BLL.clientinfo().GetRecordCount("");
                lbltotalCount.Text = totalCount.ToString();
                lblPre.Text = 1 + "";
                pageCount = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;
                lbltotalPage.Text = pageCount.ToString();
                for (int i = 0; i < clientList.Count; i++)
                {                   
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo ().GetModelList(String.Format ("CompanyID='{0}'",clientList[i].CompanyId))[0].CompanyName;
                }            
                
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
                }                
            }           
        }

        private List<string> getComboboxItems(ComboBox cb)
        {
            List<string> listOnit = new List<string>();
            //将数据项添加到listOnit中  
            for (int i = 0; i < cb.Items.Count; i++)
            {
                listOnit.Add(cb.Items[i].ToString());
            }
            return listOnit;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmClientAddOrUpdate add = new LogisPrj.FrmClientAddOrUpdate();
            add.usersInfo = usersInfo;
            add.Text = "增加客户信息";
            if (add.ShowDialog()  == DialogResult.OK)
            {
                pageIndex = 1;
                lbltotalCount.Text = new YueYePlat.BLL.clientinfo().GetRecordCount("").ToString();
                clientList = bll.GetModelList(pageSize,pageIndex,"");               
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                }
                //List<YueYePlat.Model.logiscompanyinfo> company = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
                }
            }
            clientId = -1;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (clientId > -1)
            {
                FrmClientAddOrUpdate modify = new LogisPrj.FrmClientAddOrUpdate();
                modify.usersInfo = usersInfo;
                YueYePlat.Model.clientinfo info = clientList.Find(v => v.Id.Equals(clientId));
                modify.client = info;
                modify.Text = "修改客户信息";
                if (modify.ShowDialog() == DialogResult.OK)
                {
                    clientList = bll.GetModelList(pageSize,pageIndex,"");
                    //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        clientList[i].CompanyName = new YueYePlat.BLL.companyinfo ().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName ;
                    }
                    //List<YueYePlat.Model.logiscompanyinfo> company = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                    //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(company[0].CompanyDBName);
                    dgvClient.DataSource = null;
                    dgvClient.DataSource = clientList;
                    if (dgvClient.Rows.Count > 0)
                    {
                        dgvClient.Rows[0].Selected = false;
                    }
                }
                clientId = -1;
            }
            else
            {
                MessageBox.Show("请选择客户");
            }        
        } 
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    clientId = int.Parse(dgvClient.Rows[e.RowIndex].Cells["colID"].Value .ToString());
                }
                catch (Exception ex)
                {
                    clientId = -1;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {       
           
            strWhere ="1=1";
            if (txtClientName.Text.Trim() != "")
            {
                strWhere += String.Format(" and ClientName like '%{0}%'", txtClientName.Text.Trim());
            }
            if (txtTelephone.Text.Trim() != "")
            {
                strWhere += String.Format(" and Mobile = '{0}'", txtTelephone.Text.Trim());
            }
            if (cbxCompany.SelectedValue!= null && cbxCompany.SelectedValue.ToString ()!="")
            {
                strWhere += String.Format(" and CompanyId = '{0}'", cbxCompany.SelectedValue.ToString ());
            }
            if (txtClientName.Text != "" || txtTelephone.Text != "" || cbxCompany.SelectedValue.ToString () != "")
            {
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format(strWhere ));               
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo ().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName ;
                }
                if (clientList.Count == 0)
                {
                    MessageBox.Show("没有查到对应的数据！");
                }                             
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }
        }

        private void cbxCompany_TextUpdate(object sender, EventArgs e)
        {
            //if (cbxCompany.Text.Trim() != "")
            //{
            //    //this.cbxCompany.Items.Clear();
            //    //清空listNew
            //    listNew.Clear();
            //    foreach (var item in companyInfos)
            //    {
            //        if (item.CompanyName.Contains(this.cbxCompany.Text))
            //        {
            //            //符合，插入ListNew
            //            listNew.Add(item.CompanyName);
            //        }
            //    }

            //    //combobox添加已经查到的关键词
            //    this.cbxCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
            //    this.cbxCompany.DataSource = listNew;
            //    //this.cbxCompany.Items.AddRange(listNew.ToArray());
            //    //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            //    this.cbxCompany.SelectionStart = this.cbxCompany.Text.Length;
            //    //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            //    Cursor = Cursors.Default;
            //    //自动弹出下拉框
            //    this.cbxCompany.DroppedDown = true;
            //}
        }

        private void cbxCompany_TextChanged(object sender, EventArgs e)
        {
            //string str = this.cbxCompany.Text;
            //for (int i = 0; i < this.cbxCompany.Items.Count; i++)
            //{
            //    if (this.cbxCompany.Items[i].ToString().IndexOf(str) == 0)
            //    {
            //        this.cbxCompany.Text = this.cbxCompany.Items[i].ToString();
            //        this.cbxCompany.Select(str.Length, this.cbxCompany.Text.Length - str.Length);
            //        break;
            //    }
            //}
        }

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvClient.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("Id='{0}'", int.Parse(str)));
                YueYePlat.Model.clientinfo clientInfo = clientList.Find(v => v.Id.Equals(int.Parse(str)));
                FrmClientAddOrUpdate client = new FrmClientAddOrUpdate();
                client.usersInfo = usersInfo;
                client.client = clientInfo;
                if (client.ShowDialog() == DialogResult.OK)
                {
                    clientList = bll.GetModelList(pageSize,pageIndex,"");
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                    }
                    dgvClient.DataSource = null;
                    dgvClient.DataSource = clientList;
                    if (dgvClient.Rows.Count > 0)
                    {
                        dgvClient.Rows[0].Selected = false;
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
                List<YueYePlat.Model.clientinfo > clientList = new YueYePlat.BLL.clientinfo().GetModelList(pageSize, pageIndex, "");
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                }             
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
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
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(pageSize, pageIndex, "");
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                }
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
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
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(pageSize, pageIndex, "");
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                }
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
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
                List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(pageSize, pageIndex, "");
                for (int i = 0; i < clientList.Count; i++)
                {
                    clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                }
                dgvClient.DataSource = null;
                dgvClient.DataSource = clientList;
                if (dgvClient.Rows.Count > 0)
                {
                    dgvClient.Rows[0].Selected = false;
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
                    List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList(pageSize, pageNum, "");
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        clientList[i].CompanyName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientList[i].CompanyId))[0].CompanyName;
                    }
                    dgvClient.DataSource = null;
                    dgvClient.DataSource = clientList;
                    if (dgvClient.Rows.Count > 0)
                    {
                        dgvClient.Rows[0].Selected = false;
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
