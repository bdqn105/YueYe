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
namespace YueYePlat.Web.vehiclejam
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
					long JamId=(Convert.ToInt64(strid));
					ShowInfo(JamId);
				}
			}
		}
		
	private void ShowInfo(long JamId)
	{
		YueYePlat.BLL.vehiclejam bll=new YueYePlat.BLL.vehiclejam();
		YueYePlat.Model.vehiclejam model=bll.GetModel(JamId);
		this.lblJamId.Text=model.JamId.ToString();
		this.lblDeliverId.Text=model.DeliverId;
		this.lblJamTime.Text=model.JamTime.ToString();
		this.lblJamLocation.Text=model.JamLocation;

	}


    }
}
