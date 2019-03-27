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
namespace YueYePlat.Web.userstypeinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserTypeName.Text.Trim().Length==0)
			{
				strErr+="UserTypeName不能为空！\\n";	
			}
			if(this.txtUserControlId.Text.Trim().Length==0)
			{
				strErr+="UserControlId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserTypeName=this.txtUserTypeName.Text;
			string UserControlId=this.txtUserControlId.Text;

			YueYePlat.Model.userstypeinfo model=new YueYePlat.Model.userstypeinfo();
			model.UserTypeName=UserTypeName;
			model.UserControlId=UserControlId;

			YueYePlat.BLL.userstypeinfo bll=new YueYePlat.BLL.userstypeinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
