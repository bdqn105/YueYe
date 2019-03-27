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
namespace YueYePlat.Web.vehicleupkeep
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
			if(this.txtKilometres.Text.Trim().Length==0)
			{
				strErr+="Kilometres不能为空！\\n";	
			}
			if(this.txtUpkeepDescribe.Text.Trim().Length==0)
			{
				strErr+="UpkeepDescribe不能为空！\\n";	
			}
			if(this.txtUpkeepMoneys.Text.Trim().Length==0)
			{
				strErr+="UpkeepMoneys不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpkeepTime.Text))
			{
				strErr+="UpkeepTime格式错误！\\n";	
			}
			if(this.txtUpkeepMan.Text.Trim().Length==0)
			{
				strErr+="UpkeepMan不能为空！\\n";	
			}
			if(this.txtUpkeepLocation.Text.Trim().Length==0)
			{
				strErr+="UpkeepLocation不能为空！\\n";	
			}
			if(this.txtInvoicePhoto.Text.Trim().Length==0)
			{
				strErr+="InvoicePhoto不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string VehicleId=this.txtVehicleId.Text;
			string Kilometres=this.txtKilometres.Text;
			string UpkeepDescribe=this.txtUpkeepDescribe.Text;
			string UpkeepMoneys=this.txtUpkeepMoneys.Text;
			DateTime UpkeepTime=DateTime.Parse(this.txtUpkeepTime.Text);
			string UpkeepMan=this.txtUpkeepMan.Text;
			string UpkeepLocation=this.txtUpkeepLocation.Text;
			string InvoicePhoto=this.txtInvoicePhoto.Text;

			YueYePlat.Model.vehicleupkeep model=new YueYePlat.Model.vehicleupkeep();
			model.VehicleId=VehicleId;
			model.Kilometres=Kilometres;
			model.UpkeepDescribe=UpkeepDescribe;
			model.UpkeepMoneys=UpkeepMoneys;
			model.UpkeepTime=UpkeepTime;
			model.UpkeepMan=UpkeepMan;
			model.UpkeepLocation=UpkeepLocation;
			model.InvoicePhoto=InvoicePhoto;

			YueYePlat.BLL.vehicleupkeep bll=new YueYePlat.BLL.vehicleupkeep();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
