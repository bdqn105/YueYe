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
    public partial class FrmPwdModify : Form
    {
        public  YueYePlat.Model.usersinfo users=null ;
        public FrmPwdModify()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string strPwd = Maticsoft.Common.StringPlus.GetMd5(txtPwd.Text );
            YueYePlat.BLL.usersinfo uBLL = new YueYePlat.BLL.usersinfo();           
            List<YueYePlat.Model.usersinfo> usersList = uBLL.GetModelList(txtUserID.Text, strPwd);
            if (usersList.Count > 0)
            {
                if (txtNewPwd.Text.Equals(txtConfirmPwd.Text))
                {
                    string strNewPwd = Maticsoft.Common.StringPlus.GetMd5(txtNewPwd.Text );                    
                    users.UserPassword = strNewPwd;
                    if (new YueYePlat.BLL.usersinfo().Update(users))
                    {
                        MessageBox.Show("密码重置成功！");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致，请重试！");                    
                }
            }
            else
            {
                MessageBox.Show("旧密码不正确，请重试！");
            }
        }

        private void FrmPwdModify_Load(object sender, EventArgs e)
        {
         
        }   
    }
}
