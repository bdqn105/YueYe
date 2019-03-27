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
namespace YueYePlat.Web.driverinfo
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
		YueYePlat.BLL.driverinfo bll=new YueYePlat.BLL.driverinfo();
		YueYePlat.Model.driverinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDriverId.Text=model.DriverId;
		this.lblDriverName.Text=model.DriverName;
		this.lblDriverSex.Text=model.DriverSex;
		this.lblFamilyAddress.Text=model.FamilyAddress;
		this.lblMobile.Text=model.Mobile;
		this.lblIdNumber.Text=model.IdNumber;
		this.lblDriverLicense.Text=model.DriverLicense;
		this.lblLicenseType.Text=model.LicenseType;
		this.lblDriverLocation.Text=model.DriverLocation;
		this.lblEmergencyContact.Text=model.EmergencyContact;
		this.lblEmergencyMobile.Text=model.EmergencyMobile;
		this.lblEmergencyRelations.Text=model.EmergencyRelations;
		this.lblDriverPhoto.Text=model.DriverPhoto;
		this.lblCompanyId.Text=model.CompanyId;
		this.lblType.Text=model.Type;

	}


    }
}
