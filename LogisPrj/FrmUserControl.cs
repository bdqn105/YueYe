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
    public partial class FrmUserControl : Form
    {
        YueYePlat.BLL.usercontrolinfo bll;
        YueYePlat.Model.usercontrolinfo usercontrol=null;
        List<YueYePlat.Model.usercontrolinfo> usercontrolList;
        private int usercontrolId = -1;
        static FrmUserControl  instance;
        public string tabPageTitle = "";
        public FrmUserControl()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.usercontrolinfo();
        }
        public static FrmUserControl  getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmUserControl();
            }
            return instance;
        }
        private void FrmUserControl_Load(object sender, EventArgs e)
        {
            usercontrolList = bll.GetModelList("");
            dgvUserControl.DataSource = usercontrolList ;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    usercontrolId = int.Parse(dgvUserControl.Rows [e.RowIndex ].Cells ["colId"].Value .ToString ());
                }
                catch (Exception ex)
                {
                    usercontrolId = -1;
                }
            }
            YueYePlat.Model.usercontrolinfo info = usercontrolList.Find(v=>v.Id.Equals (usercontrolId));
            usercontrol = info;
            if (usercontrol != null)
            {
                txtUserControlId.Text = usercontrol.UserControlId;
                txtUserControlName.Text = usercontrol.UserControlName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserControlId.Text != "" && txtUserControlName.Text != "")
            {
                if (MessageBox.Show("您确定要增加" + txtUserControlId.Text + "用户权限,", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.usercontrolinfo usercontrol = new YueYePlat.Model.usercontrolinfo();
                    usercontrol.UserControlId = txtUserControlId.Text;
                    usercontrol.UserControlName = txtUserControlName.Text;
                    if (new YueYePlat.BLL.usercontrolinfo().Add(usercontrol))
                    {
                        MessageBox.Show("增加成功！");
                        usercontrolList = bll.GetModelList("");
                        dgvUserControl.DataSource = usercontrolList;
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (usercontrolId != -1)
            {
                if (MessageBox.Show("您确定要修改" + txtUserControlId.Text + "用户权限,", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    usercontrol.UserControlId = txtUserControlId.Text;
                    usercontrol.UserControlName = txtUserControlName.Text;
                    if (new YueYePlat.BLL.usercontrolinfo().Update (usercontrol))
                    {
                        MessageBox.Show("修改成功！");
                        usercontrolList = bll.GetModelList("");
                        dgvUserControl.DataSource = usercontrolList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的用户权限！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (usercontrolId != -1)
            {
                if (MessageBox.Show("您确定要删除" + txtUserControlId.Text + "用户权限,", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.usercontrolinfo().Delete(usercontrolId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                        usercontrolList = bll.GetModelList("");
                        dgvUserControl.DataSource = usercontrolList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的用户权限！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

      
    }
}
