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
namespace YueYePlat.Web.deliverypath
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliverId.Text.Trim().Length==0)
			{
				strErr+="DeliverId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNumber.Text))
			{
				strErr+="OrderNumber格式错误！\\n";	
			}
			if(this.txtLongitude.Text.Trim().Length==0)
			{
				strErr+="Longitude不能为空！\\n";	
			}
			if(this.txtLatitude.Text.Trim().Length==0)
			{
				strErr+="Latitude不能为空！\\n";	
			}
			if(this.txtLimitSpeed.Text.Trim().Length==0)
			{
				strErr+="LimitSpeed不能为空！\\n";	
			}
			if(this.txtLocationName.Text.Trim().Length==0)
			{
				strErr+="LocationName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeliverId=this.txtDeliverId.Text;
			int OrderNumber=int.Parse(this.txtOrderNumber.Text);
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string LimitSpeed=this.txtLimitSpeed.Text;
			string LocationName=this.txtLocationName.Text;

			YueYePlat.Model.deliverypath model=new YueYePlat.Model.deliverypath();
			model.DeliverId=DeliverId;
			model.OrderNumber=OrderNumber;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.LimitSpeed=LimitSpeed;
			model.LocationName=LocationName;

			YueYePlat.BLL.deliverypath bll=new YueYePlat.BLL.deliverypath();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
