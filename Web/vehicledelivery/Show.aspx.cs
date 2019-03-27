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
namespace YueYePlat.Web.vehicledelivery
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
		YueYePlat.BLL.vehicledelivery bll=new YueYePlat.BLL.vehicledelivery();
		YueYePlat.Model.vehicledelivery model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDeliveryId.Text=model.DeliveryId;
		this.lblDeviceId.Text=model.DeviceId;
		this.lblVehicleId.Text=model.VehicleId;
		this.lblDriver1Id.Text=model.Driver1Id;
		this.lblDriver2Id.Text=model.Driver2Id;
		this.lblOrigin.Text=model.Origin;
		this.lblBeginTime.Text=model.BeginTime.ToString();
		this.lblMinTempThreshold.Text=model.MinTempThreshold;
		this.lblMaxTempThreshold.Text=model.MaxTempThreshold;
		this.lblMinHumThreshold.Text=model.MinHumThreshold;
		this.lblMaxHumThreshold.Text=model.MaxHumThreshold;
		this.lblIfEnd.Text=model.IfEnd;
		this.lblRecordId.Text=model.RecordId;
		this.lblAuditor.Text=model.Auditor;

	}


    }
}
