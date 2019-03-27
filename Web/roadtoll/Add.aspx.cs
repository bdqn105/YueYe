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
			string DeliveryId=this.txtDeliveryId.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			string TollStation=this.txtTollStation.Text;
			string Money=this.txtMoney.Text;
			DateTime TollTime=DateTime.Parse(this.txtTollTime.Text);
			string InvoicePhoto=this.txtInvoicePhoto.Text;

			YueYePlat.Model.roadtoll model=new YueYePlat.Model.roadtoll();
			model.DeliveryId=DeliveryId;
			model.OrderNumber=OrderNumber;
			model.TollStation=TollStation;
			model.Money=Money;
			model.TollTime=TollTime;
			model.InvoicePhoto=InvoicePhoto;

			YueYePlat.BLL.roadtoll bll=new YueYePlat.BLL.roadtoll();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
