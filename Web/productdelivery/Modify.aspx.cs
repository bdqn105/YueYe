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
namespace YueYePlat.Web.productdelivery
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
		YueYePlat.BLL.productdelivery bll=new YueYePlat.BLL.productdelivery();
		YueYePlat.Model.productdelivery model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtProductId.Text=model.ProductId;
		this.txtQuantity.Text=model.Quantity.ToString();
		this.txtOrigin.Text=model.Origin;
		this.txtBeginTime.Text=model.BeginTime.ToString();
		this.txtDestination.Text=model.Destination;
		this.txtLongitude.Text=model.Longitude;
		this.txtLatitude.Text=model.Latitude;
		this.txtPredictDeliveryTime.Text=model.PredictDeliveryTime.ToString();
		this.txtDeliveryTime.Text=model.DeliveryTime.ToString();
		this.txtClientId.Text=model.ClientId;
		this.txtArriveTime.Text=model.ArriveTime.ToString();
		this.txtSigner.Text=model.Signer;
		this.txtTelephone.Text=model.Telephone;
		this.chkIsBackFee.Checked=model.IsBackFee;
		this.txtAmount.Text=model.Amount.ToString();
		this.chkIsDeliver.Checked=model.IsDeliver;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(this.txtProductId.Text.Trim().Length==0)
			{
				strErr+="ProductId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(this.txtOrigin.Text.Trim().Length==0)
			{
				strErr+="Origin不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginTime.Text))
			{
				strErr+="BeginTime格式错误！\\n";	
			}
			if(this.txtDestination.Text.Trim().Length==0)
			{
				strErr+="Destination不能为空！\\n";	
			}
			if(this.txtLongitude.Text.Trim().Length==0)
			{
				strErr+="Longitude不能为空！\\n";	
			}
			if(this.txtLatitude.Text.Trim().Length==0)
			{
				strErr+="Latitude不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPredictDeliveryTime.Text))
			{
				strErr+="PredictDeliveryTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDeliveryTime.Text))
			{
				strErr+="DeliveryTime格式错误！\\n";	
			}
			if(this.txtClientId.Text.Trim().Length==0)
			{
				strErr+="ClientId不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtArriveTime.Text))
			{
				strErr+="ArriveTime格式错误！\\n";	
			}
			if(this.txtSigner.Text.Trim().Length==0)
			{
				strErr+="Signer不能为空！\\n";	
			}
			if(this.txtTelephone.Text.Trim().Length==0)
			{
				strErr+="Telephone不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAmount.Text))
			{
				strErr+="Amount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DeliveryId=this.txtDeliveryId.Text;
			string ProductId=this.txtProductId.Text;
			int Quantity=int.Parse(this.txtQuantity.Text);
			string Origin=this.txtOrigin.Text;
			DateTime BeginTime=DateTime.Parse(this.txtBeginTime.Text);
			string Destination=this.txtDestination.Text;
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			DateTime PredictDeliveryTime=DateTime.Parse(this.txtPredictDeliveryTime.Text);
			DateTime DeliveryTime=DateTime.Parse(this.txtDeliveryTime.Text);
			string ClientId=this.txtClientId.Text;
			DateTime ArriveTime=DateTime.Parse(this.txtArriveTime.Text);
			string Signer=this.txtSigner.Text;
			string Telephone=this.txtTelephone.Text;
			bool IsBackFee=this.chkIsBackFee.Checked;
			decimal Amount=decimal.Parse(this.txtAmount.Text);
			bool IsDeliver=this.chkIsDeliver.Checked;


			YueYePlat.Model.productdelivery model=new YueYePlat.Model.productdelivery();
			model.Id=Id;
			model.DeliveryId=DeliveryId;
			model.ProductId=ProductId;
			model.Quantity=Quantity;
			model.Origin=Origin;
			model.BeginTime=BeginTime;
			model.Destination=Destination;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.PredictDeliveryTime=PredictDeliveryTime;
			model.DeliveryTime=DeliveryTime;
			model.ClientId=ClientId;
			model.ArriveTime=ArriveTime;
			model.Signer=Signer;
			model.Telephone=Telephone;
			model.IsBackFee=IsBackFee;
			model.Amount=Amount;
			model.IsDeliver=IsDeliver;

			YueYePlat.BLL.productdelivery bll=new YueYePlat.BLL.productdelivery();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
