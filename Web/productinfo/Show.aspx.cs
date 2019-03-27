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
namespace YueYePlat.Web.productinfo
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
		YueYePlat.BLL.productinfo bll=new YueYePlat.BLL.productinfo();
		YueYePlat.Model.productinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblProductId.Text=model.ProductId;
		this.lblProductName.Text=model.ProductName;
		this.lblProductType.Text=model.ProductType;
		this.lblSpecification.Text=model.Specification;
		this.lblManufaturer.Text=model.Manufaturer;
		this.lblBatchNum.Text=model.BatchNum;
		this.lblDataofManufaturer.Text=model.DataofManufaturer.ToString();
		this.lblUnitofMeasurement.Text=model.UnitofMeasurement;

	}


    }
}
