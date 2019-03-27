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
namespace YueYePlat.Web.vehihiclemileage
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
					int MileageID=(Convert.ToInt32(strid));
					ShowInfo(MileageID);
				}
			}
		}
		
	private void ShowInfo(int MileageID)
	{
		YueYePlat.BLL.vehihiclemileage bll=new YueYePlat.BLL.vehihiclemileage();
		YueYePlat.Model.vehihiclemileage model=bll.GetModel(MileageID);
		this.lblMileageID.Text=model.MileageID.ToString();
		this.lblVehicleID.Text=model.VehicleID;
		this.lblDailyMileage.Text=model.DailyMileage;
		this.lblToalMileage.Text=model.ToalMileage;
		this.lblcurDate.Text=model.curDate.ToString();

	}


    }
}
