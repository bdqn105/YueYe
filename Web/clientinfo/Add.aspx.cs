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
namespace YueYePlat.Web.clientinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtClientId.Text.Trim().Length==0)
			{
				strErr+="ClientId不能为空！\\n";	
			}
			if(this.txtClientName.Text.Trim().Length==0)
			{
				strErr+="ClientName不能为空！\\n";	
			}
			if(this.txtTelephone.Text.Trim().Length==0)
			{
				strErr+="Telephone不能为空！\\n";	
			}
			if(this.txtMobile.Text.Trim().Length==0)
			{
				strErr+="Mobile不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ClientId=this.txtClientId.Text;
			string ClientName=this.txtClientName.Text;
			string Telephone=this.txtTelephone.Text;
			string Mobile=this.txtMobile.Text;
			string CompanyId=this.txtCompanyId.Text;

			YueYePlat.Model.clientinfo model=new YueYePlat.Model.clientinfo();
			model.ClientId=ClientId;
			model.ClientName=ClientName;
			model.Telephone=Telephone;
			model.Mobile=Mobile;
			model.CompanyId=CompanyId;

			YueYePlat.BLL.clientinfo bll=new YueYePlat.BLL.clientinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
