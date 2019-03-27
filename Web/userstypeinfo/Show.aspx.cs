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
namespace YueYePlat.Web.userstypeinfo
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
					int UserTypeId=(Convert.ToInt32(strid));
					ShowInfo(UserTypeId);
				}
			}
		}
		
	private void ShowInfo(int UserTypeId)
	{
		YueYePlat.BLL.userstypeinfo bll=new YueYePlat.BLL.userstypeinfo();
		YueYePlat.Model.userstypeinfo model=bll.GetModel(UserTypeId);
		this.lblUserTypeId.Text=model.UserTypeId.ToString();
		this.lblUserTypeName.Text=model.UserTypeName;
		this.lblUserControlId.Text=model.UserControlId;

	}


    }
}
