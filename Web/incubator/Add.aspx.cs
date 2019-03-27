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
namespace YueYePlat.Web.incubator
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtIncubatorID.Text.Trim().Length==0)
			{
				strErr+="IncubatorID不能为空！\\n";	
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
			if(this.txtTemperture.Text.Trim().Length==0)
			{
				strErr+="Temperture不能为空！\\n";	
			}
			if(this.txtHumidity.Text.Trim().Length==0)
			{
				strErr+="Humidity不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTime.Text))
			{
				strErr+="Time格式错误！\\n";	
			}
			if(this.txtProductId.Text.Trim().Length==0)
			{
				strErr+="ProductId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(this.txtUnit.Text.Trim().Length==0)
			{
				strErr+="Unit不能为空！\\n";	
			}
			if(this.txtDestination.Text.Trim().Length==0)
			{
				strErr+="Destination不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string IncubatorID=this.txtIncubatorID.Text;
			string DeliveryId=this.txtDeliveryId.Text;
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string Temperture=this.txtTemperture.Text;
			string Humidity=this.txtHumidity.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string ProductId=this.txtProductId.Text;
			int Quantity=int.Parse(this.txtQuantity.Text);
			string Unit=this.txtUnit.Text;
			string Destination=this.txtDestination.Text;

			YueYePlat.Model.incubator model=new YueYePlat.Model.incubator();
			model.IncubatorID=IncubatorID;
			model.DeliveryId=DeliveryId;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.Temperture=Temperture;
			model.Humidity=Humidity;
			model.Time=Time;
			model.ProductId=ProductId;
			model.Quantity=Quantity;
			model.Unit=Unit;
			model.Destination=Destination;

			YueYePlat.BLL.incubator bll=new YueYePlat.BLL.incubator();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
