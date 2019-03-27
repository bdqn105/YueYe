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
namespace YueYePlat.Web.refueling
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
		YueYePlat.BLL.refueling bll=new YueYePlat.BLL.refueling();
		YueYePlat.Model.refueling model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtVehicleID.Text=model.VehicleID;
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtLongitude.Text=model.Longitude;
		this.txtLatitude.Text=model.Latitude;
		this.txtPetrolStation.Text=model.PetrolStation;
		this.txtMoney.Text=model.Money.ToString();
		this.txtQuantity.Text=model.Quantity.ToString();
		this.txtRefuelTime.Text=model.RefuelTime.ToString();
		this.txtInvoicePhoto.Text=model.InvoicePhoto;
		this.txtIfVerifyed.Text=model.IfVerifyed;
		this.txtVerfielId.Text=model.VerfielId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVehicleID.Text.Trim().Length==0)
			{
				strErr+="VehicleID不能为空！\\n";	
			}
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
			if(this.txtPetrolStation.Text.Trim().Length==0)
			{
				strErr+="PetrolStation不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMoney.Text))
			{
				strErr+="Money格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRefuelTime.Text))
			{
				strErr+="RefuelTime格式错误！\\n";	
			}
			if(this.txtInvoicePhoto.Text.Trim().Length==0)
			{
				strErr+="InvoicePhoto不能为空！\\n";	
			}
			if(this.txtIfVerifyed.Text.Trim().Length==0)
			{
				strErr+="IfVerifyed不能为空！\\n";	
			}
			if(this.txtVerfielId.Text.Trim().Length==0)
			{
				strErr+="VerfielId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string VehicleID=this.txtVehicleID.Text;
			string DeliveryId=this.txtDeliveryId.Text;
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string PetrolStation=this.txtPetrolStation.Text;
			decimal Money=decimal.Parse(this.txtMoney.Text);
			decimal Quantity=decimal.Parse(this.txtQuantity.Text);
			DateTime RefuelTime=DateTime.Parse(this.txtRefuelTime.Text);
			string InvoicePhoto=this.txtInvoicePhoto.Text;
			string IfVerifyed=this.txtIfVerifyed.Text;
			string VerfielId=this.txtVerfielId.Text;


			YueYePlat.Model.refueling model=new YueYePlat.Model.refueling();
			model.Id=Id;
			model.VehicleID=VehicleID;
			model.DeliveryId=DeliveryId;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.PetrolStation=PetrolStation;
			model.Money=Money;
			model.Quantity=Quantity;
			model.RefuelTime=RefuelTime;
			model.InvoicePhoto=InvoicePhoto;
			model.IfVerifyed=IfVerifyed;
			model.VerfielId=VerfielId;

			YueYePlat.BLL.refueling bll=new YueYePlat.BLL.refueling();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
