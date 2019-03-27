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
namespace YueYePlat.Web.roadtoll
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
		YueYePlat.BLL.roadtoll bll=new YueYePlat.BLL.roadtoll();
		YueYePlat.Model.roadtoll model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtOrderNumber.Text=model.OrderNumber.ToString();
		this.txtTollStation.Text=model.TollStation;
		this.txtMoney.Text=model.Money;
		this.txtTollTime.Text=model.TollTime.ToString();
		this.txtInvoicePhoto.Text=model.InvoicePhoto;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNumber.Text))
			{
				strErr+="OrderNumber格式错误！\\n";	
			}
			if(this.txtTollStation.Text.Trim().Length==0)
			{
				strErr+="TollStation不能为空！\\n";	
			}
			if(this.txtMoney.Text.Trim().Length==0)
			{
				strErr+="Money不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTollTime.Text))
			{
				strErr+="TollTime格式错误！\\n";	
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
			int Id=int.Parse(this.lblId.Text);
			string DeliveryId=this.txtDeliveryId.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			string TollStation=this.txtTollStation.Text;
			string Money=this.txtMoney.Text;
			DateTime TollTime=DateTime.Parse(this.txtTollTime.Text);
			string InvoicePhoto=this.txtInvoicePhoto.Text;


			YueYePlat.Model.roadtoll model=new YueYePlat.Model.roadtoll();
			model.Id=Id;
			model.DeliveryId=DeliveryId;
			model.OrderNumber=OrderNumber;
			model.TollStation=TollStation;
			model.Money=Money;
			model.TollTime=TollTime;
			model.InvoicePhoto=InvoicePhoto;

			YueYePlat.BLL.roadtoll bll=new YueYePlat.BLL.roadtoll();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
