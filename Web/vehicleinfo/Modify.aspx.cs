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
namespace YueYePlat.Web.vehicleinfo
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
		YueYePlat.BLL.vehicleinfo bll=new YueYePlat.BLL.vehicleinfo();
		YueYePlat.Model.vehicleinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtVehicleId.Text=model.VehicleId;
		this.txtVehicleName.Text=model.VehicleName;
		this.txtVehicleNumber.Text=model.VehicleNumber;
		this.txtCompanyId.Text=model.CompanyId;
		this.txtVehicleType.Text=model.VehicleType;
		this.txtLoadCapacity.Text=model.LoadCapacity;
		this.txtLicensePhoto.Text=model.LicensePhoto;
		this.txtVehiclePhoto.Text=model.VehiclePhoto;
		this.txtIFBelongsto.Text=model.IFBelongsto;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVehicleId.Text.Trim().Length==0)
			{
				strErr+="VehicleId不能为空！\\n";	
			}
			if(this.txtVehicleName.Text.Trim().Length==0)
			{
				strErr+="VehicleName不能为空！\\n";	
			}
			if(this.txtVehicleNumber.Text.Trim().Length==0)
			{
				strErr+="VehicleNumber不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}
			if(this.txtVehicleType.Text.Trim().Length==0)
			{
				strErr+="VehicleType不能为空！\\n";	
			}
			if(this.txtLoadCapacity.Text.Trim().Length==0)
			{
				strErr+="LoadCapacity不能为空！\\n";	
			}
			if(this.txtLicensePhoto.Text.Trim().Length==0)
			{
				strErr+="LicensePhoto不能为空！\\n";	
			}
			if(this.txtVehiclePhoto.Text.Trim().Length==0)
			{
				strErr+="VehiclePhoto不能为空！\\n";	
			}
			if(this.txtIFBelongsto.Text.Trim().Length==0)
			{
				strErr+="IFBelongsto不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string VehicleId=this.txtVehicleId.Text;
			string VehicleName=this.txtVehicleName.Text;
			string VehicleNumber=this.txtVehicleNumber.Text;
			string CompanyId=this.txtCompanyId.Text;
			string VehicleType=this.txtVehicleType.Text;
			string LoadCapacity=this.txtLoadCapacity.Text;
			string LicensePhoto=this.txtLicensePhoto.Text;
			string VehiclePhoto=this.txtVehiclePhoto.Text;
			string IFBelongsto=this.txtIFBelongsto.Text;


			YueYePlat.Model.vehicleinfo model=new YueYePlat.Model.vehicleinfo();
			model.Id=Id;
			model.VehicleId=VehicleId;
			model.VehicleName=VehicleName;
			model.VehicleNumber=VehicleNumber;
			model.CompanyId=CompanyId;
			model.VehicleType=VehicleType;
			model.LoadCapacity=LoadCapacity;
			model.LicensePhoto=LicensePhoto;
			model.VehiclePhoto=VehiclePhoto;
			model.IFBelongsto=IFBelongsto;

			YueYePlat.BLL.vehicleinfo bll=new YueYePlat.BLL.vehicleinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
