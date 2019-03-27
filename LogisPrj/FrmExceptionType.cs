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
    public partial class FrmExceptionType : Form
    {
        YueYePlat.BLL.exceptiontype bll;
        List<YueYePlat.Model.exceptiontype> exceptiontypeList;
        YueYePlat.Model.exceptiontype exceptionType;
        private int exceptiontypeId = -1;

        static FrmExceptionType instance;
        public string tabPageTitle = "";
        public FrmExceptionType()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.exceptiontype();
                      
        }
        public static FrmExceptionType getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmExceptionType();
            }
            return instance;
        }
        private void FrmExceptionType_Load(object sender, EventArgs e)
        {
            dgvExceptionType.AutoGenerateColumns = false;
            exceptiontypeList = bll.GetModelList("");
            dgvExceptionType.DataSource = null;
            dgvExceptionType.DataSource = exceptiontypeList;
            if (dgvExceptionType.Rows.Count > 0)
            {
                dgvExceptionType.Rows[0].Selected = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text != "")
            {
                if (MessageBox.Show("您确定要增加" + txtTypeName.Text + "异常类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    YueYePlat.Model.exceptiontype exceptionType = new YueYePlat.Model.exceptiontype();
                    exceptionType.Typename = txtTypeName.Text;
                    if (new YueYePlat.BLL.exceptiontype().Add(exceptionType))
                    {
                        MessageBox.Show("增加成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        exceptiontypeList = bll.GetModelList("");
                        dgvExceptionType.DataSource = null;
                        dgvExceptionType.DataSource = exceptiontypeList;
                        if (dgvExceptionType.Rows.Count > 0)
                        {
                            dgvExceptionType.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入您要添加的异常类型名称！");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (exceptiontypeId != -1)
            {
                if (MessageBox.Show("您确定要修改" + txtTypeName.Text + "异常类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    exceptionType.Typename = txtTypeName.Text;
                    if (new YueYePlat.BLL.exceptiontype().Update(exceptionType))
                    {
                        MessageBox.Show("修改成功");
                        exceptiontypeList = bll.GetModelList("");
                        dgvExceptionType.DataSource = null;
                        dgvExceptionType.DataSource = exceptiontypeList;
                        if (dgvExceptionType.Rows.Count > 0)
                        {
                            dgvExceptionType.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的异常类型！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (exceptiontypeId != -1)
            {
                if (MessageBox.Show("您确定要删除" + txtTypeName.Text + "异常类型？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.exceptiontype().Delete(exceptiontypeId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功");
                        exceptiontypeList = bll.GetModelList("");
                        dgvExceptionType.DataSource = null;
                        dgvExceptionType.DataSource = exceptiontypeList;
                        if (dgvExceptionType.Rows.Count > 0)
                        {
                            dgvExceptionType.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的异常类型！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void dgvExceptionType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    exceptiontypeId = int.Parse(dgvExceptionType.Rows[e.RowIndex].Cells["colTypeId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    exceptiontypeId = -1;
                }
            }
            YueYePlat.Model.exceptiontype  info = exceptiontypeList. Find(v => v.TypeID.Equals(exceptiontypeId));
            exceptionType = info;
            if (exceptionType != null)
            {
                txtTypeName.Text = exceptionType.Typename;
            }
        }
    }
}
