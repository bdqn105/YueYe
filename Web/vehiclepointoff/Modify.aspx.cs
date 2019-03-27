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
namespace YueYePlat.Web.vehiclepointoff
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
		YueYePlat.BLL.vehiclepointoff bll=new YueYePlat.BLL.vehiclepointoff();
		YueYePlat.Model.vehiclepointoff model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtLongitude.Text=model.Longitude;
		this.txtLatitude.Text=model.Latitude;
		this.txtPointOff.Text=model.PointOff;
		this.txtPointOffTime.Text=model.PointOffTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(this.txtLongitude.Text.Trim().Length==0)
			{
				strErr+="Longitude不能为空！\\n";	
			}
			if(this.txtLatitude.Text.Trim().Length==0)
			{
				strErr+="Latitude不能为空！\\n";	
			}
			if(this.txtPointOff.Text.Trim().Length==0)
			{
				strErr+="PointOff不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPointOffTime.Text))
			{
				strErr+="PointOffTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DeliveryId=this.txtDeliveryId.Text;
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string PointOff=this.txtPointOff.Text;
			DateTime PointOffTime=DateTime.Parse(this.txtPointOffTime.Text);


			YueYePlat.Model.vehiclepointoff model=new YueYePlat.Model.vehiclepointoff();
			model.Id=Id;
			model.DeliveryId=DeliveryId;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.PointOff=PointOff;
			model.PointOffTime=PointOffTime;

			YueYePlat.BLL.vehiclepointoff bll=new YueYePlat.BLL.vehiclepointoff();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
