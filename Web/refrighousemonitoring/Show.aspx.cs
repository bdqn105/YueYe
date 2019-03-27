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
namespace YueYePlat.Web.refrighousemonitoring
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
		YueYePlat.BLL.refrighousemonitoring bll=new YueYePlat.BLL.refrighousemonitoring();
		YueYePlat.Model.refrighousemonitoring model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblHouseId.Text=model.HouseId;
		this.lblTemperature1.Text=model.Temperature1;
		this.lblHumidity1.Text=model.Humidity1;
		this.lblTemperature2.Text=model.Temperature2;
		this.lblHumidity2.Text=model.Humidity2;
		this.lblTemperature3.Text=model.Temperature3;
		this.lblHumidity3.Text=model.Humidity3;
		this.lblMonitorTime.Text=model.MonitorTime.ToString();

	}


    }
}
