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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		YueYePlat.BLL.companyinfo bll=new YueYePlat.BLL.companyinfo();
		YueYePlat.Model.companyinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtCompanyID.Text=model.CompanyID;
		this.txtCompanyName.Text=model.CompanyName;
		this.txtCompanyUnifiedCode.Text=model.CompanyUnifiedCode;
		this.txtToPublicAccount.Text=model.ToPublicAccount;
		this.txtToPrivateAccount.Text=model.ToPrivateAccount;
		this.txtCompanyLocation.Text=model.CompanyLocation;
		this.txtCompanyAddress.Text=model.CompanyAddress;
		this.txtBusinessNature.Text=model.BusinessNature;
		this.txtLegalRepresentative.Text=model.LegalRepresentative;
		this.txtTelephone.Text=model.Telephone;
		this.txtMobile.Text=model.Mobile;
		this.txtFaxNo.Text=model.FaxNo;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int Id=int.Parse(this.lblId.Text);
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
			model.Id=Id;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
