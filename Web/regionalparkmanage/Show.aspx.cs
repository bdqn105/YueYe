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
namespace YueYePlat.Web.regionalparkmanage
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
		YueYePlat.BLL.regionalparkmanage bll=new YueYePlat.BLL.regionalparkmanage();
		YueYePlat.Model.regionalparkmanage model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDeliveryId.Text=model.DeliveryId;
		this.lblLongitude.Text=model.Longitude;
		this.lblLatitude.Text=model.Latitude;
		this.lblParkingTime.Text=model.ParkingTime.ToString();

	}


    }
}
