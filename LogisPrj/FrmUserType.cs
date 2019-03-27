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
    public partial class FrmUserType : Form
    {
        YueYePlat.BLL.userstypeinfo bll;
        List<YueYePlat.Model.userstypeinfo> usertypeList;
        YueYePlat.Model.userstypeinfo usersType;
        private int userstypeId = -1;

        static FrmUserType instance;
        public string tabPageTitle = "";
        public FrmUserType()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.userstypeinfo();
        }
        public static FrmUserType getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmUserType();
            }
            return instance;
        }
        private void FrmUserType_Load(object sender, EventArgs e)
        {
            usertypeList = bll.GetModelList("");
            dgvUserType.DataSource = usertypeList;
            List<YueYePlat.Model.usercontrolinfo> usercontrol = new YueYePlat.BLL.usercontrolinfo().GetModelList("");
            cbxUserControlId.DisplayMember = "UserControlName";
            cbxUserControlId.ValueMember = "UserControlId";
            cbxUserControlId.DataSource = usercontrol;            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要增加" + txtUserTypeName.Text + "用户类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                YueYePlat.Model.userstypeinfo usersType = new YueYePlat.Model.userstypeinfo();            
                usersType.UserTypeName = txtUserTypeName.Text;
                usersType.UserControlId = cbxUserControlId.SelectedValue.ToString();
                if (new YueYePlat.BLL.userstypeinfo().Add(usersType))
                {
                    MessageBox.Show("增加成功");
                    usertypeList = bll.GetModelList("");
                    dgvUserType.DataSource = usertypeList;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (userstypeId != -1)
            {
                if (MessageBox.Show("您确定要修改" + txtUserTypeName.Text + "用户类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {                 
                    usersType.UserTypeName = txtUserTypeName.Text;
                    usersType.UserControlId = cbxUserControlId.SelectedValue.ToString();
                    if (new YueYePlat.BLL.userstypeinfo().Update(usersType))
                    {
                        MessageBox.Show("修改成功");
                        usertypeList = bll.GetModelList("");
                        dgvUserType.DataSource = usertypeList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择修改的用户类型");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (userstypeId != -1)
            {
                if (MessageBox.Show("您确定要删除" + txtUserTypeName.Text + "用户类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.userstypeinfo().Delete(userstypeId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功");
                        usertypeList = bll.GetModelList("");
                        dgvUserType.DataSource = usertypeList;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择删除的用户类型");
            }
        }

        private void dgvUserType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    userstypeId = int.Parse(dgvUserType.Rows[e.RowIndex].Cells["colUserTypeId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    userstypeId = -1;
                }
            }
            YueYePlat.Model.userstypeinfo info  = usertypeList.Find(v => v.UserTypeId.Equals(userstypeId));
            usersType = info ;
            if (usersType != null)
            {             
                txtUserTypeName.Text = usersType.UserTypeName;
                cbxUserControlId.SelectedValue = usersType.UserControlId;
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
