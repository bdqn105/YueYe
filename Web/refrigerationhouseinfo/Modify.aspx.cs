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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace YueYePlat.Web.refrigerationhouseinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		YueYePlat.BLL.refrigerationhouseinfo bll=new YueYePlat.BLL.refrigerationhouseinfo();
		YueYePlat.Model.refrigerationhouseinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtHouseId.Text=model.HouseId;
		this.txtCompanyId.Text=model.CompanyId;
		this.txtHouseName.Text=model.HouseName;
		this.txtHouseLocation.Text=model.HouseLocation;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtHouseId.Text.Trim().Length==0)
			{
				strErr+="HouseId不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}
			if(this.txtHouseName.Text.Trim().Length==0)
			{
				strErr+="HouseName不能为空！\\n";	
			}
			if(this.txtHouseLocation.Text.Trim().Length==0)
			{
				strErr+="HouseLocation不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string HouseId=this.txtHouseId.Text;
			string CompanyId=this.txtCompanyId.Text;
			string HouseName=this.txtHouseName.Text;
			string HouseLocation=this.txtHouseLocation.Text;


			YueYePlat.Model.refrigerationhouseinfo model=new YueYePlat.Model.refrigerationhouseinfo();
			model.Id=Id;
			model.HouseId=HouseId;
			model.CompanyId=CompanyId;
			model.HouseName=HouseName;
			model.HouseLocation=HouseLocation;

			YueYePlat.BLL.refrigerationhouseinfo bll=new YueYePlat.BLL.refrigerationhouseinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
