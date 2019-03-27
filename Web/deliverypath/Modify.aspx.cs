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
namespace YueYePlat.Web.deliverypath
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
		YueYePlat.BLL.deliverypath bll=new YueYePlat.BLL.deliverypath();
		YueYePlat.Model.deliverypath model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliverId.Text=model.DeliverId;
		this.txtOrderNumber.Text=model.OrderNumber.ToString();
		this.txtLongitude.Text=model.Longitude;
		this.txtLatitude.Text=model.Latitude;
		this.txtLimitSpeed.Text=model.LimitSpeed;
		this.txtLocationName.Text=model.LocationName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliverId.Text.Trim().Length==0)
			{
				strErr+="DeliverId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNumber.Text))
			{
				strErr+="OrderNumber格式错误！\\n";	
			}
			if(this.txtLongitude.Text.Trim().Length==0)
			{
				strErr+="Longitude不能为空！\\n";	
			}
			if(this.txtLatitude.Text.Trim().Length==0)
			{
				strErr+="Latitude不能为空！\\n";	
			}
			if(this.txtLimitSpeed.Text.Trim().Length==0)
			{
				strErr+="LimitSpeed不能为空！\\n";	
			}
			if(this.txtLocationName.Text.Trim().Length==0)
			{
				strErr+="LocationName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DeliverId=this.txtDeliverId.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string LimitSpeed=this.txtLimitSpeed.Text;
			string LocationName=this.txtLocationName.Text;


			YueYePlat.Model.deliverypath model=new YueYePlat.Model.deliverypath();
			model.Id=Id;
			model.DeliverId=DeliverId;
			model.OrderNumber=OrderNumber;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.LimitSpeed=LimitSpeed;
			model.LocationName=LocationName;

			YueYePlat.BLL.deliverypath bll=new YueYePlat.BLL.deliverypath();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
