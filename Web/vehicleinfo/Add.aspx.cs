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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
