using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace YueYePlat.Web.usercontrolinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserControlId.Text.Trim().Length==0)
			{
				strErr+="UserControlId不能为空！\\n";	
			}
			if(this.txtUserControlName.Text.Trim().Length==0)
			{
				strErr+="UserControlName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserControlId=this.txtUserControlId.Text;
			string UserControlName=this.txtUserControlName.Text;

			YueYePlat.Model.usercontrolinfo model=new YueYePlat.Model.usercontrolinfo();
			model.UserControlId=UserControlId;
			model.UserControlName=UserControlName;

			YueYePlat.BLL.usercontrolinfo bll=new YueYePlat.BLL.usercontrolinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
