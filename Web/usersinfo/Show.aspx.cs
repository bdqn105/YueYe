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
namespace YueYePlat.Web.usersinfo
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		YueYePlat.BLL.usersinfo bll=new YueYePlat.BLL.usersinfo();
		YueYePlat.Model.usersinfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblUserId.Text=model.UserId;
		this.lblUserName.Text=model.UserName;
		this.lblUserSex.Text=model.UserSex;
		this.lblUserPassword.Text=model.UserPassword;
		this.lblUserState.Text=model.UserState.ToString();
		this.lblUserTypeId.Text=model.UserTypeId;
		this.lblCompanyId.Text=model.CompanyId;

	}


    }
}
