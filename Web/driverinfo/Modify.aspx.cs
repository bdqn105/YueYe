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
namespace YueYePlat.Web.driverinfo
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
		YueYePlat.BLL.driverinfo bll=new YueYePlat.BLL.driverinfo();
		YueYePlat.Model.driverinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDriverId.Text=model.DriverId;
		this.txtDriverName.Text=model.DriverName;
		this.txtDriverSex.Text=model.DriverSex;
		this.txtFamilyAddress.Text=model.FamilyAddress;
		this.txtMobile.Text=model.Mobile;
		this.txtIdNumber.Text=model.IdNumber;
		this.txtDriverLicense.Text=model.DriverLicense;
		this.txtLicenseType.Text=model.LicenseType;
		this.txtDriverLocation.Text=model.DriverLocation;
		this.txtEmergencyContact.Text=model.EmergencyContact;
		this.txtEmergencyMobile.Text=model.EmergencyMobile;
		this.txtEmergencyRelations.Text=model.EmergencyRelations;
		this.txtDriverPhoto.Text=model.DriverPhoto;
		this.txtCompanyId.Text=model.CompanyId;
		this.txtType.Text=model.Type;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDriverId.Text.Trim().Length==0)
			{
				strErr+="DriverId不能为空！\\n";	
			}
			if(this.txtDriverName.Text.Trim().Length==0)
			{
				strErr+="DriverName不能为空！\\n";	
			}
			if(this.txtDriverSex.Text.Trim().Length==0)
			{
				strErr+="DriverSex不能为空！\\n";	
			}
			if(this.txtFamilyAddress.Text.Trim().Length==0)
			{
				strErr+="FamilyAddress不能为空！\\n";	
			}
			if(this.txtMobile.Text.Trim().Length==0)
			{
				strErr+="Mobile不能为空！\\n";	
			}
			if(this.txtIdNumber.Text.Trim().Length==0)
			{
				strErr+="IdNumber不能为空！\\n";	
			}
			if(this.txtDriverLicense.Text.Trim().Length==0)
			{
				strErr+="DriverLicense不能为空！\\n";	
			}
			if(this.txtLicenseType.Text.Trim().Length==0)
			{
				strErr+="LicenseType不能为空！\\n";	
			}
			if(this.txtDriverLocation.Text.Trim().Length==0)
			{
				strErr+="DriverLocation不能为空！\\n";	
			}
			if(this.txtEmergencyContact.Text.Trim().Length==0)
			{
				strErr+="EmergencyContact不能为空！\\n";	
			}
			if(this.txtEmergencyMobile.Text.Trim().Length==0)
			{
				strErr+="EmergencyMobile不能为空！\\n";	
			}
			if(this.txtEmergencyRelations.Text.Trim().Length==0)
			{
				strErr+="EmergencyRelations不能为空！\\n";	
			}
			if(this.txtDriverPhoto.Text.Trim().Length==0)
			{
				strErr+="DriverPhoto不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DriverId=this.txtDriverId.Text;
			string DriverName=this.txtDriverName.Text;
			string DriverSex=this.txtDriverSex.Text;
			string FamilyAddress=this.txtFamilyAddress.Text;
			string Mobile=this.txtMobile.Text;
			string IdNumber=this.txtIdNumber.Text;
			string DriverLicense=this.txtDriverLicense.Text;
			string LicenseType=this.txtLicenseType.Text;
			string DriverLocation=this.txtDriverLocation.Text;
			string EmergencyContact=this.txtEmergencyContact.Text;
			string EmergencyMobile=this.txtEmergencyMobile.Text;
			string EmergencyRelations=this.txtEmergencyRelations.Text;
			string DriverPhoto=this.txtDriverPhoto.Text;
			string CompanyId=this.txtCompanyId.Text;
			string Type=this.txtType.Text;


			YueYePlat.Model.driverinfo model=new YueYePlat.Model.driverinfo();
			model.Id=Id;
			model.DriverId=DriverId;
			model.DriverName=DriverName;
			model.DriverSex=DriverSex;
			model.FamilyAddress=FamilyAddress;
			model.Mobile=Mobile;
			model.IdNumber=IdNumber;
			model.DriverLicense=DriverLicense;
			model.LicenseType=LicenseType;
			model.DriverLocation=DriverLocation;
			model.EmergencyContact=EmergencyContact;
			model.EmergencyMobile=EmergencyMobile;
			model.EmergencyRelations=EmergencyRelations;
			model.DriverPhoto=DriverPhoto;
			model.CompanyId=CompanyId;
			model.Type=Type;

			YueYePlat.BLL.driverinfo bll=new YueYePlat.BLL.driverinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
