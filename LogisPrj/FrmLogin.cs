using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LogisPrj
{
    public partial class FrmLogin : Form
    {        
        public YueYePlat.Model.usersinfo usersInfo;
        public FrmLogin()
        {
            InitializeComponent();
            
        } 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text != "" && txtPwd.Text != "")
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                YueYePlat.BLL.usersinfo uBLL = new YueYePlat.BLL.usersinfo();
                string strPwd = Maticsoft.Common.StringPlus.GetMd5(txtPwd.Text);
                List<YueYePlat.Model.usersinfo> usersList = uBLL.GetModelList(txtUserId.Text, strPwd);
                if (usersList.Count > 0)
                {
                    if (usersList[0].UserTypeId.Contains("APP") || usersList[0].UserTypeId.Contains("App"))
                    {
                        MessageBox.Show("该APP用户无法登录，请输入有效的用户名！");
                    }
                    else
                    {
                        YueYePlat.Model.usersinfo info = usersList.Find(v => v.UserId.Equals(usersList[0].UserId));
                        usersInfo = info;
                        FrmMain main = new FrmMain();
                        main.usersInfo = usersInfo;
                        main.strLoginName = txtUserId.Text;
                        this.Hide();
                        if (main.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！");
                }
            }            
           
            else
            {
                MessageBox.Show("请输入正确的用户名和密码！");
            }        
        }      
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
         
            FrmUsers frm = new LogisPrj.FrmUsers();
            frm.usersInfo = usersInfo;
            frm.Text = "注册";            
            this.Hide();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出当前系统？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnClose, "退出");
        }
    }
}
