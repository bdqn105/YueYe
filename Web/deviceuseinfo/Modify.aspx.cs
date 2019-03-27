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
namespace YueYePlat.Web.deviceuseinfo
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
		YueYePlat.BLL.deviceuseinfo bll=new YueYePlat.BLL.deviceuseinfo();
		YueYePlat.Model.deviceuseinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeviceId.Text=model.DeviceId;
		this.txtVehicleId.Text=model.VehicleId;
		this.txtIfBind.Text=model.IfBind;
		this.txtBindTime.Text=model.BindTime.ToString();
		this.txtUnbindTime.Text=model.UnbindTime.ToString();
		this.txtComment.Text=model.Comment;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeviceId.Text.Trim().Length==0)
			{
				strErr+="DeviceId不能为空！\\n";	
			}
			if(this.txtVehicleId.Text.Trim().Length==0)
			{
				strErr+="VehicleId不能为空！\\n";	
			}
			if(this.txtIfBind.Text.Trim().Length==0)
			{
				strErr+="IfBind不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBindTime.Text))
			{
				strErr+="BindTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUnbindTime.Text))
			{
				strErr+="UnbindTime格式错误！\\n";	
			}
			if(this.txtComment.Text.Trim().Length==0)
			{
				strErr+="Comment不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DeviceId=this.txtDeviceId.Text;
			string VehicleId=this.txtVehicleId.Text;
			string IfBind=this.txtIfBind.Text;
			DateTime BindTime=DateTime.Parse(this.txtBindTime.Text);
			DateTime UnbindTime=DateTime.Parse(this.txtUnbindTime.Text);
			string Comment=this.txtComment.Text;


			YueYePlat.Model.deviceuseinfo model=new YueYePlat.Model.deviceuseinfo();
			model.Id=Id;
			model.DeviceId=DeviceId;
			model.VehicleId=VehicleId;
			model.IfBind=IfBind;
			model.BindTime=BindTime;
			model.UnbindTime=UnbindTime;
			model.Comment=Comment;

			YueYePlat.BLL.deviceuseinfo bll=new YueYePlat.BLL.deviceuseinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
