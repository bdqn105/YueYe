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
namespace YueYePlat.Web.vehicleinfo
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
		YueYePlat.BLL.vehicleinfo bll=new YueYePlat.BLL.vehicleinfo();
		YueYePlat.Model.vehicleinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblVehicleId.Text=model.VehicleId;
		this.lblVehicleName.Text=model.VehicleName;
		this.lblVehicleNumber.Text=model.VehicleNumber;
		this.lblCompanyId.Text=model.CompanyId;
		this.lblVehicleType.Text=model.VehicleType;
		this.lblLoadCapacity.Text=model.LoadCapacity;
		this.lblLicensePhoto.Text=model.LicensePhoto;
		this.lblVehiclePhoto.Text=model.VehiclePhoto;
		this.lblIFBelongsto.Text=model.IFBelongsto;

	}


    }
}
