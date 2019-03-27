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
namespace YueYePlat.Web.deliverycurgyroinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long Id=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(long Id)
	{
		YueYePlat.BLL.deliverycurgyroinfo bll=new YueYePlat.BLL.deliverycurgyroinfo();
		YueYePlat.Model.deliverycurgyroinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtLocation.Text=model.Location;
		this.txtSpeed.Text=model.Speed;
		this.txtCurrentTime.Text=model.CurrentTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(this.txtLocation.Text.Trim().Length==0)
			{
				strErr+="Location不能为空！\\n";	
			}
			if(this.txtSpeed.Text.Trim().Length==0)
			{
				strErr+="Speed不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCurrentTime.Text))
			{
				strErr+="CurrentTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long Id=long.Parse(this.lblId.Text);
			string DeliveryId=this.txtDeliveryId.Text;
			string Location=this.txtLocation.Text;
			string Speed=this.txtSpeed.Text;
			DateTime CurrentTime=DateTime.Parse(this.txtCurrentTime.Text);


			YueYePlat.Model.deliverycurgyroinfo model=new YueYePlat.Model.deliverycurgyroinfo();
			model.Id=Id;
			model.DeliveryId=DeliveryId;
			model.Location=Location;
			model.Speed=Speed;
			model.CurrentTime=CurrentTime;

			YueYePlat.BLL.deliverycurgyroinfo bll=new YueYePlat.BLL.deliverycurgyroinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
