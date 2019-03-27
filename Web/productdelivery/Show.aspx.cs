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
namespace YueYePlat.Web.productdelivery
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
		YueYePlat.BLL.productdelivery bll=new YueYePlat.BLL.productdelivery();
		YueYePlat.Model.productdelivery model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDeliveryId.Text=model.DeliveryId;
		this.lblProductId.Text=model.ProductId;
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblOrigin.Text=model.Origin;
		this.lblBeginTime.Text=model.BeginTime.ToString();
		this.lblDestination.Text=model.Destination;
		this.lblLongitude.Text=model.Longitude;
		this.lblLatitude.Text=model.Latitude;
		this.lblPredictDeliveryTime.Text=model.PredictDeliveryTime.ToString();
		this.lblDeliveryTime.Text=model.DeliveryTime.ToString();
		this.lblClientId.Text=model.ClientId;
		this.lblArriveTime.Text=model.ArriveTime.ToString();
		this.lblSigner.Text=model.Signer;
		this.lblTelephone.Text=model.Telephone;
		this.lblIsBackFee.Text=model.IsBackFee?"是":"否";
		this.lblAmount.Text=model.Amount.ToString();
		this.lblIsDeliver.Text=model.IsDeliver?"是":"否";

	}


    }
}
