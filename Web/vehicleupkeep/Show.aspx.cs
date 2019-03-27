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
namespace YueYePlat.Web.vehicleupkeep
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
		YueYePlat.BLL.vehicleupkeep bll=new YueYePlat.BLL.vehicleupkeep();
		YueYePlat.Model.vehicleupkeep model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblVehicleId.Text=model.VehicleId;
		this.lblKilometres.Text=model.Kilometres;
		this.lblUpkeepDescribe.Text=model.UpkeepDescribe;
		this.lblUpkeepMoneys.Text=model.UpkeepMoneys;
		this.lblUpkeepTime.Text=model.UpkeepTime.ToString();
		this.lblUpkeepMan.Text=model.UpkeepMan;
		this.lblUpkeepLocation.Text=model.UpkeepLocation;
		this.lblInvoicePhoto.Text=model.InvoicePhoto;

	}


    }
}
