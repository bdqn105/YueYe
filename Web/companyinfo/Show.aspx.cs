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
namespace YueYePlat.Web.companyinfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		YueYePlat.BLL.companyinfo bll=new YueYePlat.BLL.companyinfo();
		YueYePlat.Model.companyinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblCompanyID.Text=model.CompanyID;
		this.lblCompanyName.Text=model.CompanyName;
		this.lblCompanyUnifiedCode.Text=model.CompanyUnifiedCode;
		this.lblToPublicAccount.Text=model.ToPublicAccount;
		this.lblToPrivateAccount.Text=model.ToPrivateAccount;
		this.lblCompanyLocation.Text=model.CompanyLocation;
		this.lblCompanyAddress.Text=model.CompanyAddress;
		this.lblBusinessNature.Text=model.BusinessNature;
		this.lblLegalRepresentative.Text=model.LegalRepresentative;
		this.lblTelephone.Text=model.Telephone;
		this.lblMobile.Text=model.Mobile;
		this.lblFaxNo.Text=model.FaxNo;

	}


    }
}
