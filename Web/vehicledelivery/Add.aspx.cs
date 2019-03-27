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
namespace YueYePlat.Web.vehicledelivery
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(this.txtDeviceId.Text.Trim().Length==0)
			{
				strErr+="DeviceId不能为空！\\n";	
			}
			if(this.txtVehicleId.Text.Trim().Length==0)
			{
				strErr+="VehicleId不能为空！\\n";	
			}
			if(this.txtDriver1Id.Text.Trim().Length==0)
			{
				strErr+="Driver1Id不能为空！\\n";	
			}
			if(this.txtDriver2Id.Text.Trim().Length==0)
			{
				strErr+="Driver2Id不能为空！\\n";	
			}
			if(this.txtOrigin.Text.Trim().Length==0)
			{
				strErr+="Origin不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginTime.Text))
			{
				strErr+="BeginTime格式错误！\\n";	
			}
			if(this.txtMinTempThreshold.Text.Trim().Length==0)
			{
				strErr+="MinTempThreshold不能为空！\\n";	
			}
			if(this.txtMaxTempThreshold.Text.Trim().Length==0)
			{
				strErr+="MaxTempThreshold不能为空！\\n";	
			}
			if(this.txtMinHumThreshold.Text.Trim().Length==0)
			{
				strErr+="MinHumThreshold不能为空！\\n";	
			}
			if(this.txtMaxHumThreshold.Text.Trim().Length==0)
			{
				strErr+="MaxHumThreshold不能为空！\\n";	
			}
			if(this.txtIfEnd.Text.Trim().Length==0)
			{
				strErr+="IfEnd不能为空！\\n";	
			}
			if(this.txtRecordId.Text.Trim().Length==0)
			{
				strErr+="RecordId不能为空！\\n";	
			}
			if(this.txtAuditor.Text.Trim().Length==0)
			{
				strErr+="Auditor不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeliveryId=this.txtDeliveryId.Text;
			string DeviceId=this.txtDeviceId.Text;
			string VehicleId=this.txtVehicleId.Text;
			string Driver1Id=this.txtDriver1Id.Text;
			string Driver2Id=this.txtDriver2Id.Text;
			string Origin=this.txtOrigin.Text;
			DateTime BeginTime=DateTime.Parse(this.txtBeginTime.Text);
			string MinTempThreshold=this.txtMinTempThreshold.Text;
			string MaxTempThreshold=this.txtMaxTempThreshold.Text;
			string MinHumThreshold=this.txtMinHumThreshold.Text;
			string MaxHumThreshold=this.txtMaxHumThreshold.Text;
			string IfEnd=this.txtIfEnd.Text;
			string RecordId=this.txtRecordId.Text;
			string Auditor=this.txtAuditor.Text;

			YueYePlat.Model.vehicledelivery model=new YueYePlat.Model.vehicledelivery();
			model.DeliveryId=DeliveryId;
			model.DeviceId=DeviceId;
			model.VehicleId=VehicleId;
			model.Driver1Id=Driver1Id;
			model.Driver2Id=Driver2Id;
			model.Origin=Origin;
			model.BeginTime=BeginTime;
			model.MinTempThreshold=MinTempThreshold;
			model.MaxTempThreshold=MaxTempThreshold;
			model.MinHumThreshold=MinHumThreshold;
			model.MaxHumThreshold=MaxHumThreshold;
			model.IfEnd=IfEnd;
			model.RecordId=RecordId;
			model.Auditor=Auditor;

			YueYePlat.BLL.vehicledelivery bll=new YueYePlat.BLL.vehicledelivery();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
