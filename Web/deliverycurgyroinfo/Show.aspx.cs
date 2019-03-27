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
namespace YueYePlat.Web.deliverycurgyroinfo
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
					long Id=(Convert.ToInt64(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(long Id)
	{
		YueYePlat.BLL.deliverycurgyroinfo bll=new YueYePlat.BLL.deliverycurgyroinfo();
		YueYePlat.Model.deliverycurgyroinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDeliveryId.Text=model.DeliveryId;
		this.lblLocation.Text=model.Location;
		this.lblSpeed.Text=model.Speed;
		this.lblCurrentTime.Text=model.CurrentTime.ToString();

	}


    }
}
