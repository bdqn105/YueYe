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
namespace YueYePlat.Web.terminaldeviceinfo
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
		YueYePlat.BLL.terminaldeviceinfo bll=new YueYePlat.BLL.terminaldeviceinfo();
		YueYePlat.Model.terminaldeviceinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeviceId.Text=model.DeviceId;
		this.txtDeviceType.Text=model.DeviceType;
		this.txtDeviceName.Text=model.DeviceName;
		this.txtCompanyId.Text=model.CompanyId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeviceId.Text.Trim().Length==0)
			{
				strErr+="DeviceId不能为空！\\n";	
			}
			if(this.txtDeviceType.Text.Trim().Length==0)
			{
				strErr+="DeviceType不能为空！\\n";	
			}
			if(this.txtDeviceName.Text.Trim().Length==0)
			{
				strErr+="DeviceName不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DeviceId=this.txtDeviceId.Text;
			string DeviceType=this.txtDeviceType.Text;
			string DeviceName=this.txtDeviceName.Text;
			string CompanyId=this.txtCompanyId.Text;


			YueYePlat.Model.terminaldeviceinfo model=new YueYePlat.Model.terminaldeviceinfo();
			model.Id=Id;
			model.DeviceId=DeviceId;
			model.DeviceType=DeviceType;
			model.DeviceName=DeviceName;
			model.CompanyId=CompanyId;

			YueYePlat.BLL.terminaldeviceinfo bll=new YueYePlat.BLL.terminaldeviceinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
