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
namespace YueYePlat.Web.companyinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyID.Text.Trim().Length==0)
			{
				strErr+="CompanyID不能为空！\\n";	
			}
			if(this.txtCompanyName.Text.Trim().Length==0)
			{
				strErr+="CompanyName不能为空！\\n";	
			}
			if(this.txtCompanyUnifiedCode.Text.Trim().Length==0)
			{
				strErr+="CompanyUnifiedCode不能为空！\\n";	
			}
			if(this.txtToPublicAccount.Text.Trim().Length==0)
			{
				strErr+="ToPublicAccount不能为空！\\n";	
			}
			if(this.txtToPrivateAccount.Text.Trim().Length==0)
			{
				strErr+="ToPrivateAccount不能为空！\\n";	
			}
			if(this.txtCompanyLocation.Text.Trim().Length==0)
			{
				strErr+="CompanyLocation不能为空！\\n";	
			}
			if(this.txtCompanyAddress.Text.Trim().Length==0)
			{
				strErr+="CompanyAddress不能为空！\\n";	
			}
			if(this.txtBusinessNature.Text.Trim().Length==0)
			{
				strErr+="BusinessNature不能为空！\\n";	
			}
			if(this.txtLegalRepresentative.Text.Trim().Length==0)
			{
				strErr+="LegalRepresentative不能为空！\\n";	
			}
			if(this.txtTelephone.Text.Trim().Length==0)
			{
				strErr+="Telephone不能为空！\\n";	
			}
			if(this.txtMobile.Text.Trim().Length==0)
			{
				strErr+="Mobile不能为空！\\n";	
			}
			if(this.txtFaxNo.Text.Trim().Length==0)
			{
				strErr+="FaxNo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyID=this.txtCompanyID.Text;
			string CompanyName=this.txtCompanyName.Text;
			string CompanyUnifiedCode=this.txtCompanyUnifiedCode.Text;
			string ToPublicAccount=this.txtToPublicAccount.Text;
			string ToPrivateAccount=this.txtToPrivateAccount.Text;
			string CompanyLocation=this.txtCompanyLocation.Text;
			string CompanyAddress=this.txtCompanyAddress.Text;
			string BusinessNature=this.txtBusinessNature.Text;
			string LegalRepresentative=this.txtLegalRepresentative.Text;
			string Telephone=this.txtTelephone.Text;
			string Mobile=this.txtMobile.Text;
			string FaxNo=this.txtFaxNo.Text;

			YueYePlat.Model.companyinfo model=new YueYePlat.Model.companyinfo();
			model.CompanyID=CompanyID;
			model.CompanyName=CompanyName;
			model.CompanyUnifiedCode=CompanyUnifiedCode;
			model.ToPublicAccount=ToPublicAccount;
			model.ToPrivateAccount=ToPrivateAccount;
			model.CompanyLocation=CompanyLocation;
			model.CompanyAddress=CompanyAddress;
			model.BusinessNature=BusinessNature;
			model.LegalRepresentative=LegalRepresentative;
			model.Telephone=Telephone;
			model.Mobile=Mobile;
			model.FaxNo=FaxNo;

			YueYePlat.BLL.companyinfo bll=new YueYePlat.BLL.companyinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
