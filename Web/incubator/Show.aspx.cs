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
namespace YueYePlat.Web.incubator
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
		YueYePlat.BLL.incubator bll=new YueYePlat.BLL.incubator();
		YueYePlat.Model.incubator model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblIncubatorID.Text=model.IncubatorID;
		this.lblDeliveryId.Text=model.DeliveryId;
		this.lblLongitude.Text=model.Longitude;
		this.lblLatitude.Text=model.Latitude;
		this.lblTemperture.Text=model.Temperture;
		this.lblHumidity.Text=model.Humidity;
		this.lblTime.Text=model.Time.ToString();
		this.lblProductId.Text=model.ProductId;
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblUnit.Text=model.Unit;
		this.lblDestination.Text=model.Destination;

	}


    }
}
