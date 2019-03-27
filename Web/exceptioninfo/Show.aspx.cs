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
namespace YueYePlat.Web.exceptioninfo
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
		YueYePlat.BLL.exceptioninfo bll=new YueYePlat.BLL.exceptioninfo();
		YueYePlat.Model.exceptioninfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDeliverId.Text=model.DeliverId;
		this.lblExceptionType.Text=model.ExceptionType;
		this.lblExceptiondescribe.Text=model.Exceptiondescribe;
		this.lblExceptionDispose.Text=model.ExceptionDispose;
		this.lblSender.Text=model.Sender;
		this.lblSendTime.Text=model.SendTime.ToString();
		this.lblConductor.Text=model.Conductor;
		this.lblDisposeTime.Text=model.DisposeTime.ToString();

	}


    }
}
